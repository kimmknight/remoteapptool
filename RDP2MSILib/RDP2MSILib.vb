Imports System.Reflection.Assembly
Imports System.Windows.Forms
Public Class RDP

    Private rdpFilePath As String
    Public Property rdpPath As String
        Get
            Return rdpFilePath
        End Get
        Set(value As String)
            rdpFilePath = value
            ReadRDPfile()
        End Set
    End Property

    Private ProductName As String ' Full remoteapp name as read from RDP file
    Public FlatFileTypes As String = ""
    Public PerUser As Boolean = False
    Private ProductBaseFileName As String ' RDP filename minus the file extension
    Public ProductPublisher As String
    Public ProductVersion As String = "1.0.0.0"
    Public ProductUpgradeRandom As Boolean = False
    Public ProductRemoteTag As String = "remote"
    Public ShortcutInStart As Boolean = True
    Public ShortcutSubfolderInStart As Boolean = True
    Public ShortcutOnDesktop As Boolean = True


    Private rdpFileContents As String
    Private hasIcon As Boolean
    Private rdpInTemp As Boolean

    Public Sub CreateMSI(Optional DestinationPath As String = "")

        'Check for wix, exit if not available
        If Not WixInstalled() Then Exit Sub

        'Get RDP file parent folder path
        Dim rdpParentFolder = My.Computer.FileSystem.GetParentPath(rdpFilePath)

        'Get the RDP filename and filename minus extension
        Dim rdpFileName = My.Computer.FileSystem.GetFileInfo(rdpFilePath).Name
        ProductBaseFileName = System.IO.Path.GetFileNameWithoutExtension(rdpFileName)

        'If DestinationPath not defined then set the path to the same as the rdp file
        If DestinationPath = "" Then DestinationPath = rdpParentFolder & "\" & ProductBaseFileName & ".msi"

        'Set iconpath (whether it exists or not)
        Dim IconFilePath = rdpParentFolder & "\" & ProductBaseFileName & ".ico"

        'Check for icon, set "HasIcon" to true if found
        hasIcon = My.Computer.FileSystem.FileExists(IconFilePath)

        'Get RemoteApp names (short and full) from RDP file contents
        Dim RemoteAppFullName = ReadRDPProperty("remoteapplicationname")
        Dim RemoteAppShortName = ReadRDPProperty("remoteapplicationprogram")

        'Define wix temp file paths
        Dim TempPath = Environment.GetEnvironmentVariable("TEMP")
        Dim wxsPath = TempPath & "\" & ProductBaseFileName & ".wxs"
        Dim wixobjPath = TempPath & "\" & ProductBaseFileName & ".wixobj"
        Dim wixpdbPath = TempPath & "\" & ProductBaseFileName & ".wixpdb"
        Dim msiPath = TempPath & "\" & ProductBaseFileName & ".msi"

        Dim rdpTempPath = TempPath & "\" & ProductBaseFileName & ".rdp"
        Dim icoTempPath = TempPath & "\" & ProductBaseFileName & ".ico"

        'Define temp files to delete
        Dim FilesToDelete As List(Of String) = New List(Of String)(New String() {wxsPath, wixobjPath, wixpdbPath})
        Dim LockCheck As New LockChecker.LockChecker()
        Dim FileLocked As String
        Dim SkipFile As Boolean = False
        'Check if rdp file is already in TEMP folder
        If rdpParentFolder = TempPath Then rdpInTemp = True

        'if RDP file not in temp, copy to temp
        If Not rdpInTemp Then
            FileLocked = LockCheck.CheckLock(rdpTempPath)
            While Not (FileLocked = "No locks")
                If (MessageBox.Show("The file " + rdpTempPath + " is currently locked.  Lock information:" + FileLocked + vbNewLine + "Do you want to try again?", "File Locked", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    FileLocked = LockCheck.CheckLock(rdpTempPath)
                Else
                    MessageBox.Show("The following file will not be deleted:" + vbNewLine + rdpTempPath)
                    SkipFile = True
                    FileLocked = "No locks"
                End If
            End While
            If Not (SkipFile) Then
                My.Computer.FileSystem.CopyFile(rdpFilePath, rdpTempPath, True)
            End If

            FilesToDelete.Add(rdpTempPath)
            If hasIcon Then
                FileLocked = LockCheck.CheckLock(icoTempPath)
                While Not (FileLocked = "No locks")
                    If (MessageBox.Show("The file " + icoTempPath + " is currently locked.  Lock information:" + FileLocked + vbNewLine + "Do you want to try again?", "File Locked", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                        FileLocked = LockCheck.CheckLock(icoTempPath)
                    Else
                        MessageBox.Show("The following file will not be deleted:" + vbNewLine + icoTempPath)
                        SkipFile = True
                        FileLocked = "No locks"
                    End If
                End While
                If Not (SkipFile) Then

                    My.Computer.FileSystem.CopyFile(IconFilePath, icoTempPath, True)
                End If

                FilesToDelete.Add(icoTempPath)
            End If

        End If

        'Save WXS file containing generated WXS string
        My.Computer.FileSystem.WriteAllText(wxsPath, GenerateWXSString(), False)

        Dim CandlePath = WixPath() & "\candle.exe "
        Dim LightPath = WixPath() & "\light.exe "

        'Run Candle.exe and Light.exe to process wxs file
        Dim CandleExitCode = RunWait(CandlePath, "-out """ & wixobjPath & """ """ & wxsPath & """")
        'If Not CandleExitCode = 0 Then Exit Sub
        Dim LightExitCode = RunWait(LightPath, "-out """ & msiPath & """ """ & wixobjPath & """")
        'If Not LightExitCode = 0 Then Exit Sub

        'Move MSI file to destination and delete temp files
        FileLocked = LockCheck.CheckLock(DestinationPath)
        While Not (FileLocked = "No locks")
            If (MessageBox.Show("The file " + DestinationPath + " is currently locked.  Lock information:" + FileLocked + vbNewLine + "Do you want to try again?", "File Locked", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                FileLocked = LockCheck.CheckLock(DestinationPath)
            Else
                MessageBox.Show("The following file will not be deleted:" + vbNewLine + DestinationPath)
                SkipFile = True
                FileLocked = "No locks"
            End If
        End While
        If Not (SkipFile) Then

            My.Computer.FileSystem.MoveFile(msiPath, DestinationPath, True)
        End If

        DeleteFiles(FilesToDelete)

    End Sub

    Public Function WixInstalled() As Boolean
        If WixPath() = "" Then
            WixInstalled = False
        Else
            WixInstalled = True
        End If
    End Function

    Private Function WixPath()
        Dim searchExe = "\candle.exe"
        WixPath = ""
        If Not Environment.GetEnvironmentVariable("WIX") = "" Then
            WixPath = Environment.GetEnvironmentVariable("WIX") & "bin"
        ElseIf My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\wix\" & searchExe) Then
            WixPath = My.Application.Info.DirectoryPath & "\wix"
        ElseIf My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\wix\bin\" & searchExe) Then
            WixPath = My.Application.Info.DirectoryPath & "\wix\bin"
        End If
    End Function

    Private Sub DeleteFiles(FilesArray As List(Of String))
        For Each dFile In FilesArray
            Dim LockCheck As New LockChecker.LockChecker()
            Dim FileLocked As String
            Dim SkipFile As Boolean = False
            FileLocked = LockCheck.CheckLock(dFile)
            While Not (FileLocked = "No locks")
                If (MessageBox.Show("The file " + dFile + " is currently locked.  Lock information:" + FileLocked + vbNewLine + "Do you want to try again?", "File Locked", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    FileLocked = LockCheck.CheckLock(dFile)
                Else
                    MessageBox.Show("The following file will not be deleted:" + vbNewLine + dFile)
                    SkipFile = True
                    FileLocked = "No locks"
                End If
            End While
            If Not (SkipFile) Then
                If My.Computer.FileSystem.FileExists(dFile) Then My.Computer.FileSystem.DeleteFile(dFile)
            End If
        Next
    End Sub

    Private Sub ReadRDPfile()
        'Check if RDP file exists
        If Not My.Computer.FileSystem.FileExists(rdpFilePath) Then Exit Sub

        'Check that RDP file is an RDP file
        If Not rdpFilePath.ToLower.EndsWith(".rdp") Then Exit Sub

        'Read RDP file into variable
        rdpFileContents = My.Computer.FileSystem.ReadAllText(rdpFilePath)

        'Check RDP file contains a remoteapplicationname value
        'If ReadRDPProperty("remoteapplicationname") = "" Then Exit Sub

        'Check if RDP file contains a server address
        If ReadRDPProperty("full address") = "" Then Exit Sub

        'Read variables
        ProductName = ReadRDPProperty("remoteapplicationname")

        If ProductName = "" Then
            ProductName = System.IO.Path.GetFileNameWithoutExtension(rdpFilePath)
        End If

        If ProductPublisher Is Nothing Then ProductPublisher = ProductName

    End Sub

    Public Function ProductUpgradeCode()
        ' random or generated - maybe allow caller to define?
        Dim UpgradeCode As String

        'Check if ProductUpgradeRandom is true, create a random productcode if so, otherwise generate it from the productname
        If Not ProductUpgradeRandom Then
            UpgradeCode = GenerateGUIDfromString(ProductName)
        Else
            Dim Rnd = New Random()
            UpgradeCode = GenerateGUIDfromString(Rnd.Next)
        End If
        Return UpgradeCode
    End Function

    Public Function MakeProgID(AppName) As String
        Dim rx As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9_]")
        MakeProgID = rx.Replace(AppName, "_")
    End Function


    Private Function GenerateWXSString()
        Dim Rnd = New Random()

        If ProductPublisher = "" Then ProductPublisher = ProductName

        Dim RegRoot = "HKLM"
        If PerUser = True Then RegRoot = "HKCU"


        Dim AppFilesGuid = GenerateGUIDfromString("AppFiles" & ProductUpgradeCode())
        Dim AppStartShortcutsGuid = GenerateGUIDfromString("AppStartShortcuts" & ProductUpgradeCode())
        Dim AppDeskShortcutsGuid = GenerateGUIDfromString("AppDeskShortcuts" & ProductUpgradeCode())

        Dim ProgID As String = MakeProgID(ProductBaseFileName)

        Dim wxsString = "<?xml version=""1.0""?>" & vbCrLf
        wxsString += "<?define ProductVersion = """ & ProductVersion & """?>" & vbCrLf
        wxsString += "<?define ProductUpgradeCode = """ & ProductUpgradeCode() & """?>" & vbCrLf
        wxsString += "<?define AppFilesGuid = """ & AppFilesGuid & """?>" & vbCrLf
        wxsString += "<?define AppStartShortcutsGuid = """ & AppStartShortcutsGuid & """?>" & vbCrLf
        wxsString += "<?define AppDeskShortcutsGuid = """ & AppDeskShortcutsGuid & """?>" & vbCrLf
        wxsString += "<?define ProductName = """ & ProductName & """?>" & vbCrLf
        wxsString += "<?define ProductPublisher = """ & ProductPublisher & """?>" & vbCrLf
        wxsString += "<?define ProductBaseFileName = """ & ProductBaseFileName & """?>" & vbCrLf
        wxsString += "<?define RegRoot = """ & RegRoot & """?>" & vbCrLf
        If Not FlatFileTypes = "" Then wxsString += "<?define ProductProgID = """ & ProgID & """?>" & vbCrLf
        If Not ProductRemoteTag = "" Then ProductRemoteTag = " (" & ProductRemoteTag & ")"
        wxsString += "<?define ProductRemoteTag = """ & ProductRemoteTag & """?>" & vbCrLf
        wxsString += "<Wix xmlns=""http://schemas.microsoft.com/wix/2006/wi"">" & vbCrLf

        wxsString += "   <Product Id=""*"" UpgradeCode=""$(var.ProductUpgradeCode)"" " & vbCrLf
        wxsString += "            Name=""$(var.ProductName)$(var.ProductRemoteTag)"" Version=""$(var.ProductVersion)"" Manufacturer=""$(var.ProductPublisher)"" Language=""1033"">" & vbCrLf
        wxsString += "      <Package InstallerVersion=""200"" Compressed=""yes"" Comments=""Windows Installer Package"""
        If Not PerUser Then
            wxsString += " InstallScope=""perMachine"""
        Else
            wxsString += " InstallPrivileges=""limited"""
        End If

        wxsString += "/>" & vbCrLf
        wxsString += "      <Media Id=""1"" Cabinet=""rdp2msi.cab"" EmbedCab=""yes""/>" & vbCrLf
        If Not PerUser Then wxsString += "      <Property Id=""AllUSERS"" Value=""1""/>" & vbCrLf
        wxsString += "      <Upgrade Id=""$(var.ProductUpgradeCode)"">" & vbCrLf
        wxsString += "         <UpgradeVersion Minimum=""$(var.ProductVersion)"" OnlyDetect=""yes"" Property=""NEWERVERSIONDETECTED""/>" & vbCrLf
        wxsString += "         <UpgradeVersion Minimum=""0.0.0"" Maximum=""$(var.ProductVersion)"" IncludeMinimum=""yes"" IncludeMaximum=""no"" " & vbCrLf
        wxsString += "                         Property=""OLDERVERSIONBEINGUPGRADED""/>	  " & vbCrLf
        wxsString += "      </Upgrade>" & vbCrLf
        wxsString += "      <Condition Message=""A newer version of this software is already installed."">NOT NEWERVERSIONDETECTED</Condition>" & vbCrLf
        wxsString += "      <Property Id=""MstscProperty"" Value=""mstsc.exe""/>" & vbCrLf
        wxsString += "      <Directory Id=""TARGETDIR"" Name=""SourceDir"">" & vbCrLf
        If Not PerUser Then
            wxsString += "         <Directory Id=""ProgramFilesFolder"">" & vbCrLf
        Else
            wxsString += "         <Directory Id=""LocalAppDataFolder"">" & vbCrLf
        End If
        wxsString += "            <Directory Id=""INSTALLDIR"" Name=""RemotePackages"">" & vbCrLf
        wxsString += "               <Component Id=""ApplicationFiles"" Guid=""$(var.AppFilesGuid)"">" & vbCrLf
        wxsString += "                  <File Id=""rdpFile1"" Source=""$(var.ProductBaseFileName).rdp""/>" & vbCrLf
        If hasIcon Then wxsString += "				  <File Id=""rdpIcon1"" Source=""$(var.ProductBaseFileName).ico""/>" & vbCrLf
        '# Begin filetype association code
        If Not FlatFileTypes = "" Then
            For Each FileType In FlatFileTypes.Replace(".", "").Split(",")
                wxsString += "				  <File Id=""$(var.ProductProgID)." & FileType & ".ico"" Source=""$(var.ProductBaseFileName)." & FileType & ".ico"" />" & vbCrLf
                wxsString += "				  <ProgId Id=""remote.$(var.ProductProgID)." & FileType & "file"" Description=""$(var.ProductName) " & FileType & " file"" Icon=""$(var.ProductProgID)." & FileType & ".ico"">" & vbCrLf
                wxsString += "				  <Extension Id=""" & FileType & """ ContentType=""application/" & FileType & """>" & vbCrLf
                wxsString += "				  <Verb Id=""open"" Command=""Open"" TargetProperty='MstscProperty' Argument='/REMOTEFILE:""%1"" ""[INSTALLDIR]$(var.ProductBaseFileName).rdp""' />" & vbCrLf
                wxsString += "				  </Extension>" & vbCrLf
                wxsString += "				  </ProgId>" & vbCrLf
                'wxsString += "				  <RegistryValue Root=""$(var.RegRoot)"" Key=""SOFTWARE\Classes\remote.$(var.ProductProgID)." & FileType & "file"" Name=""FriendlyTypeName"" Value=""$(var.ProductName) " & FileType & " file"" Type=""string"" />"
            Next
        End If
        '# End FTA code
        wxsString += "               </Component>" & vbCrLf
        wxsString += "            </Directory>" & vbCrLf
        wxsString += "		</Directory>" & vbCrLf

        If ShortcutInStart Then
            wxsString += "         <Directory Id=""ProgramMenuFolder"">" & vbCrLf
            If ShortcutSubfolderInStart Then wxsString += "            <Directory Id=""ProgramMenuSubfolder"" Name=""$(var.ProductName)$(var.ProductRemoteTag)"">" & vbCrLf
            wxsString += "               <Component Id=""ApplicationStartShortcuts"" Guid=""$(var.AppStartShortcutsGuid)"">" & vbCrLf
            wxsString += "                  <Shortcut Id=""rdpStartShortcut1"" Name=""$(var.ProductName)$(var.ProductRemoteTag)"" Description=""$(var.ProductName)$(var.ProductRemoteTag)"" " & vbCrLf
            wxsString += "                            Target=""[INSTALLDIR]$(var.ProductBaseFileName).rdp"" WorkingDirectory=""INSTALLDIR"""

            If hasIcon Then
                wxsString += " Icon=""rdpStartIcon.rdp"" IconIndex=""0"">" & vbCrLf
                wxsString += "							<Icon Id=""rdpStartIcon.rdp"" SourceFile=""$(var.ProductBaseFileName).ico"" />" & vbCrLf
                wxsString += "				  </Shortcut>" & vbCrLf
            Else
                wxsString += "/>" & vbCrLf
            End If

            wxsString += "                  <RegistryValue Root=""$(var.RegRoot)"" Key=""Software\RDP2MSI\$(var.ProductName)"" " & vbCrLf
            wxsString += "                            Name=""installed"" Type=""integer"" Value=""1"" KeyPath=""yes""/>" & vbCrLf
            wxsString += "                  <RemoveFolder Id=""ProgramMenuSubfolder"" On=""uninstall""/>" & vbCrLf
            wxsString += "               </Component>" & vbCrLf
            If ShortcutSubfolderInStart Then wxsString += "            </Directory>" & vbCrLf
            wxsString += "         </Directory>" & vbCrLf
        End If

        If ShortcutOnDesktop Then
            wxsString += "	     <Directory Id=""DesktopFolder"">" & vbCrLf
            wxsString += "		   <Component Id=""ApplicationDesktopShortcuts"" Guid=""$(var.AppDeskShortcutsGuid)"">" & vbCrLf
            wxsString += "			  <Shortcut Id=""rdpDesktopShortcut1"" Name=""$(var.ProductName)$(var.ProductRemoteTag)"" Description=""$(var.ProductName)$(var.ProductRemoteTag)"" " & vbCrLf
            wxsString += "						Target=""[INSTALLDIR]$(var.ProductBaseFileName).rdp"" WorkingDirectory=""INSTALLDIR"""

            If hasIcon Then
                wxsString += " Icon=""rdpDeskIcon.rdp"" IconIndex=""0"">" & vbCrLf
                wxsString += "						<Icon Id=""rdpDeskIcon.rdp"" SourceFile=""$(var.ProductBaseFileName).ico"" />" & vbCrLf
                wxsString += "			  </Shortcut>" & vbCrLf
            Else
                wxsString += "/>" & vbCrLf
            End If


            wxsString += "			  <RegistryValue Root=""$(var.RegRoot)"" Key=""Software\RDP2MSI\$(var.ProductName)"" " & vbCrLf
            wxsString += "						Name=""installed"" Type=""integer"" Value=""1"" KeyPath=""yes""/>" & vbCrLf
            wxsString += "		   </Component>" & vbCrLf
            wxsString += "         </Directory>" & vbCrLf
        End If
        wxsString += "		</Directory>" & vbCrLf

        wxsString += "      <InstallExecuteSequence>" & vbCrLf
        wxsString += "         <RemoveExistingProducts After=""InstallValidate""/>" & vbCrLf
        wxsString += "      </InstallExecuteSequence>" & vbCrLf
        wxsString += " "
        wxsString += "      <Feature Id=""DefaultFeature"" Level=""1"">" & vbCrLf
        wxsString += "         <ComponentRef Id=""ApplicationFiles""/>" & vbCrLf
        If ShortcutInStart Then wxsString += "         <ComponentRef Id=""ApplicationStartShortcuts""/>" & vbCrLf
        If ShortcutOnDesktop Then wxsString += "		 <ComponentRef Id=""ApplicationDesktopShortcuts""/>" & vbCrLf
        wxsString += "      </Feature>" & vbCrLf
        If hasIcon Then
            wxsString += "<Icon Id=""rdpARPIcon.rdp"" SourceFile=""$(var.ProductBaseFileName).ico"" />" & vbCrLf
            wxsString += "<Property Id=""ARPPRODUCTICON"" Value=""rdpARPIcon.rdp"" />" & vbCrLf
        End If
        wxsString += "   </Product>" & vbCrLf
        wxsString += "</Wix>" & vbCrLf

        Return wxsString

    End Function

    Public Function ReadRDPProperty(rdpProperty As String) As String
        Dim rdpFileLines = Split(rdpFileContents, vbLf)
        Dim rdpValue = ""
        For Each rdpLine In rdpFileLines
            rdpLine = Replace(rdpLine, vbCr, "")
            rdpLine = Replace(rdpLine, "|", "")
            Dim rdpLineSplit = Split(rdpLine, ":", 3)
            If rdpLineSplit(0) = rdpProperty Then
                rdpValue = rdpLineSplit(2)
            End If
        Next
        Return rdpValue
    End Function

    Private Function GenerateGUIDfromString(TheString As String)
        Dim TheHash = getMD5Hash(TheString)
        Dim MyGuid As Guid = New Guid(TheHash)
        Return MyGuid.ToString
    End Function

    Private Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""
        Dim b As Byte

        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Private Function RunWait(App As String, Parameters As String) As Integer
        Dim proc As New Process
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proc.StartInfo.FileName = App
        proc.StartInfo.Arguments = Parameters
        proc.Start()
        proc.WaitForExit()
        Return proc.ExitCode
    End Function

End Class