Module RDP2MSImodule

    Public wxsPath
    Public wixobjPath
    Public wixpdbPath
    Public rdpFilePathD

    Public Sub Main()

        Dim cmdRdpPath = ""
        Dim cmdSwitches = "DS"

        LogText("RDP2MSI" & vbCrLf)
        If My.Application.CommandLineArgs.Count = 0 Then
            ShowUsage()
            End
        ElseIf My.Application.CommandLineArgs.Count = 1 Then
            cmdRdpPath = My.Application.CommandLineArgs(0)
        ElseIf My.Application.CommandLineArgs.Count = 2 Then
            If My.Application.CommandLineArgs(0).StartsWith("/") Then
                cmdSwitches = My.Application.CommandLineArgs(0)
                cmdRdpPath = My.Application.CommandLineArgs(1)
            Else
                cmdSwitches = My.Application.CommandLineArgs(1)
                cmdRdpPath = My.Application.CommandLineArgs(0)
            End If
        ElseIf My.Application.CommandLineArgs.Count > 2 Then
            LogText("Error: Too many parameters provided.", True)
        End If

        Dim relCmdRdpPath = System.IO.Directory.GetCurrentDirectory & "\" & cmdRdpPath
        If Not cmdRdpPath.Contains(":") Then cmdRdpPath = relCmdRdpPath

        If Not My.Computer.FileSystem.FileExists(cmdRdpPath) Then LogText("Error: Unable to find RDP file: " & cmdRdpPath, True)

        If Not cmdSwitches.ToUpper.Contains("D") Then
            If Not cmdSwitches.ToUpper.Contains("S") Then
                cmdSwitches += "DS"
            End If
        End If

        If cmdSwitches.ToUpper.Contains("~") Then LogText("Command line options: " & cmdSwitches.ToUpper)

        RDP2MSI(cmdRdpPath, cmdSwitches.ToUpper)

        'Console.Write("Press any key to continue...")
        'Console.ReadKey()
    End Sub

    Private Sub LogText(TheText As String, Optional DoExit As Boolean = False)
        Console.WriteLine(TheText)
        If DoExit = True Then
            CleanupTempFiles()
            'End
        End If
    End Sub

    Public Sub RDP2MSI(rdpFilePath As String, Optional CmdParameters As String = "", Optional ShortcutTag As String = "", Optional AppPublisher As String = "", Optional FlatFileTypes As String = "", Optional PerUser As Boolean = False)

        If Not My.Computer.FileSystem.FileExists(rdpFilePath) Then LogText("Error: Unable to find RDP file: " & rdpFilePath, True)
        If Not rdpFilePath.ToLower.EndsWith(".rdp") Then LogText("Error: Input file must be an RDP file.", True)
        If ReadRDPProperty(rdpFilePath, "remoteapplicationname") = "" Then LogText("Error: RDP file does not contain valid data.", True)

        Dim rdpParentFolder = My.Computer.FileSystem.GetParentPath(rdpFilePath)
        LogText("Working folder: " & rdpParentFolder)

        LogText("RDP file: " & rdpFilePath)
        Dim RemoteAppFullName = ReadRDPProperty(rdpFilePath, "remoteapplicationname")
        LogText("App full name: " & RemoteAppFullName)
        Dim RemoteAppShortName = ReadRDPProperty(rdpFilePath, "remoteapplicationprogram")
        LogText("App short name: " & RemoteAppShortName)

        Dim UpgradeCode
        If CmdParameters.ToUpper.Contains("A") Then
            UpgradeCode = GenerateGUIDfromString(RemoteAppShortName)
        Else
            Dim Rnd = New Random()
            UpgradeCode = GenerateGUIDfromString(Rnd.Next)
        End If
        LogText("Upgrade code: " & UpgradeCode)

        Dim IconFilePath = Left(rdpFilePath, rdpFilePath.Length - 4) & ".ico"

        Dim HasIcon = False
        If My.Computer.FileSystem.FileExists(IconFilePath) Then
            HasIcon = True
            LogText("Icon found: " & IconFilePath)
        Else
            LogText("Icon not found.")
        End If

        'Dim shortcutTag = ReadIni(My.Application.Info.DirectoryPath & "\rdp2msi.ini", "Settings", "ShortcutTag", "remote")
        If CmdParameters.ToUpper.Contains("T") Then ShortcutTag = ""

        'Dim appPublisher = ReadIni(My.Application.Info.DirectoryPath & "\rdp2msi.ini", "Settings", "AppPublisher", "")
        Dim rdpFileName = My.Computer.FileSystem.GetFileInfo(rdpFilePath).Name
        Dim ProductFileName = Left(rdpFileName, rdpFileName.Length - 4)

        Dim wxsString = GenerateWXSString(ProductFileName, RemoteAppFullName, AppPublisher, HasIcon, , UpgradeCode, ShortcutTag, CmdParameters, FlatFileTypes, PerUser)
        wxsPath = rdpParentFolder & "\" & ProductFileName & ".wxs"
        wixobjPath = rdpParentFolder & "\" & ProductFileName & ".wixobj"
        wixpdbPath = rdpParentFolder & "\" & ProductFileName & ".wixpdb"
        Dim msiPath = rdpParentFolder & "\" & ProductFileName & ".msi"

        Dim FilesToDelete As New ArrayList
        FilesToDelete.Add(rdpFilePath)
        FilesToDelete.Add(wxsPath)
        FilesToDelete.Add(wixobjPath)
        FilesToDelete.Add(wixpdbPath)

        My.Computer.FileSystem.WriteAllText(wxsPath, wxsString, False)

        Dim wixPath = FindWixPath()
        If wixPath = "" Then
            LogText("Error: Unable to locate the WiX Toolset. Exiting.", True)
        Else
            LogText("Found WiX Toolset in: " & wixPath)
        End If

        Dim CandlePath = wixPath & "\candle.exe "
        Dim LightPath = wixPath & "\light.exe "

        LogText("Invoking candle.exe from WiX Toolset")
        Dim CandleExitCode = RunWait(CandlePath, "-out """ & wixobjPath & """ """ & wxsPath & """")
        If CandleExitCode = 0 Then
            LogText("candle.exe executed successfully.")
        Else
            LogText("Error: candle.exe returned an error.", True)
        End If

        LogText("Invoking light.exe from WiX Toolset")
        Dim LightExitCode = RunWait(LightPath, " -out """ & msiPath & """ """ & wixobjPath & """")
        If LightExitCode = 0 Then
            LogText("light.exe executed successfully.")
        Else
            LogText("Error: light.exe returned an error.", True)
        End If

        If Not CmdParameters.Contains("~") Then
            DeleteFiles(FilesToDelete)
        End If

        If My.Computer.FileSystem.FileExists(msiPath) Then
            LogText(My.Computer.FileSystem.GetFileInfo(msiPath).Name & " created successfully.")
        Else
            LogText("Error: MSI creation failed.", True)
            MsgBox("MSI creation failed.", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Sub CleanupTempFiles()
        If My.Computer.FileSystem.FileExists(rdpFilePathD) Then My.Computer.FileSystem.DeleteFile(rdpFilePathD)
        If My.Computer.FileSystem.FileExists(wxsPath) Then My.Computer.FileSystem.DeleteFile(wxsPath)
        If My.Computer.FileSystem.FileExists(wixobjPath) Then My.Computer.FileSystem.DeleteFile(wixobjPath)
        If My.Computer.FileSystem.FileExists(wixpdbPath) Then My.Computer.FileSystem.DeleteFile(wixpdbPath)
    End Sub

    Function FindWixPath()
        LogText("Locating WiX Toolset")
        Dim searchExe = "\candle.exe"
        Dim wixPath = ""
        Dim wixIniPath = ReadIni(My.Application.Info.DirectoryPath & "\rdp2msi.ini", "WIX", "binpath", My.Application.Info.DirectoryPath & "\wix").TrimEnd(Chr(92))
        If My.Computer.FileSystem.FileExists(wixIniPath & searchExe) Then
            wixPath = wixIniPath
        ElseIf Environment.GetEnvironmentVariable("WIX") <> "" Then
            wixPath = Environment.GetEnvironmentVariable("WIX") & "bin"
        ElseIf My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\wix\" & searchExe) Then
            wixPath = My.Application.Info.DirectoryPath & "\wix"
        ElseIf My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\bin\" & searchExe) Then
            wixPath = My.Application.Info.DirectoryPath & "\bin"
        End If
        Return wixPath
    End Function

    Sub ShowUsage()
        LogText("Usage: rdp2msi.exe [/DSNAT] rdpfile.rdp")
        LogText("")
        LogText("Switches:")
        LogText("")
        LogText("  /D     MSI will deploy desktop shortcut")
        LogText("  /S     MSI will deploy shortcut in Start Menu > Programs > (AppName)")
        LogText("  /N     Requires /S. MSI will not create subfolder in Start Menu > Programs")
        LogText("  /A     Generate upgrade code based on app name, otherwise it is random")
        LogText("  /T     Do not include the (remote) tag on deployed shortcuts")
        LogText("")
        LogText("If no switches are specified, /DS is implied.")
        LogText("")
    End Sub

    Function GenerateWXSString(ProductFileName As String, ProductName As String, Optional ProductPublisher As String = "", Optional HasIcon As Boolean = False, Optional ProductVersion As String = "1.0.0.0", Optional ProductUpgradeCode As String = "random", Optional ProductRemoteTag As String = "remote", Optional ShortcutLocations As String = "DS", Optional FlatFileTypes As String = "", Optional PerUser As Boolean = False)
        Dim Rnd = New Random()

        If ProductUpgradeCode = "random" Then ProductUpgradeCode = GenerateGUIDfromString(Rnd.Next)
        If ProductPublisher = "" Then ProductPublisher = ProductName

        Dim RegRoot = "HKLM"
        If PerUser = True Then RegRoot = "HKCU"

        Dim FileTypes As New ArrayList
        If Not FlatFileTypes = "" Then FileTypes.AddRange(Split(FlatFileTypes, "|"))

        Dim AppFilesGuid = GenerateGUIDfromString("AppFiles" & ProductUpgradeCode)
        Dim AppStartShortcutsGuid = GenerateGUIDfromString("AppStartShortcuts" & ProductUpgradeCode)
        Dim AppDeskShortcutsGuid = GenerateGUIDfromString("AppDeskShortcuts" & ProductUpgradeCode)

        Dim wxsString = "<?xml version=""1.0""?>" & vbCrLf
        wxsString += "<?define ProductVersion = """ & ProductVersion & """?>" & vbCrLf
        wxsString += "<?define ProductUpgradeCode = """ & ProductUpgradeCode & """?>" & vbCrLf
        wxsString += "<?define AppFilesGuid = """ & AppFilesGuid & """?>" & vbCrLf
        wxsString += "<?define AppStartShortcutsGuid = """ & AppStartShortcutsGuid & """?>" & vbCrLf
        wxsString += "<?define AppDeskShortcutsGuid = """ & AppDeskShortcutsGuid & """?>" & vbCrLf
        wxsString += "<?define ProductName = """ & ProductName & """?>" & vbCrLf
        wxsString += "<?define ProductPublisher = """ & ProductPublisher & """?>" & vbCrLf
        wxsString += "<?define ProductFileName = """ & ProductFileName & """?>" & vbCrLf
        wxsString += "<?define RegRoot = """ & RegRoot & """?>" & vbCrLf
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
        wxsString += "                  <File Id=""rdpFile1"" Source=""$(var.ProductFileName).rdp""/>" & vbCrLf
        If HasIcon Then wxsString += "				  <File Id=""rdpIcon1"" Source=""$(var.ProductFileName).ico""/>" & vbCrLf
        If Not FlatFileTypes = "" Then
            For Each FileType In FileTypes
                wxsString += "				  <File Id=""$(var.ProductFileName)_" & FileType & ".ico"" Source=""$(var.ProductFileName)_" & FileType & ".ico"" />" & vbCrLf
                wxsString += "				  <ProgId Id=""remote.$(var.ProductFileName)." & FileType & "file"" Description=""$(var.ProductName) " & FileType & " file"" Icon=""$(var.ProductFileName)_" & FileType & ".ico"">" & vbCrLf
                wxsString += "				  <Extension Id=""" & FileType & """ ContentType=""application/" & FileType & """>" & vbCrLf
                wxsString += "				  <Verb Id=""open"" Command=""Open"" TargetProperty='MstscProperty' Argument='/REMOTEFILE:""%1"" ""[INSTALLDIR]$(var.ProductFileName).rdp""' />" & vbCrLf
                wxsString += "				  </Extension>" & vbCrLf
                wxsString += "				  </ProgId>" & vbCrLf
            Next
        End If
        wxsString += "               </Component>" & vbCrLf
        wxsString += "            </Directory>" & vbCrLf
        wxsString += "		</Directory>" & vbCrLf

        If ShortcutLocations.ToUpper.Contains("S") Then
            wxsString += "         <Directory Id=""ProgramMenuFolder"">" & vbCrLf
            If Not ShortcutLocations.ToUpper.Contains("N") Then wxsString += "            <Directory Id=""ProgramMenuSubfolder"" Name=""$(var.ProductName)$(var.ProductRemoteTag)"">" & vbCrLf
            wxsString += "               <Component Id=""ApplicationStartShortcuts"" Guid=""$(var.AppStartShortcutsGuid)"">" & vbCrLf
            wxsString += "                  <Shortcut Id=""rdpStartShortcut1"" Name=""$(var.ProductName)$(var.ProductRemoteTag)"" Description=""$(var.ProductName)$(var.ProductRemoteTag)"" " & vbCrLf
            wxsString += "                            Target=""[INSTALLDIR]$(var.ProductFileName).rdp"" WorkingDirectory=""INSTALLDIR"""

            If HasIcon Then
                wxsString += " Icon=""rdpStartIcon.rdp"" IconIndex=""0"">" & vbCrLf
                wxsString += "							<Icon Id=""rdpStartIcon.rdp"" SourceFile=""$(var.ProductFileName).ico"" />" & vbCrLf
                wxsString += "				  </Shortcut>" & vbCrLf
            Else
                wxsString += "/>" & vbCrLf
            End If

            wxsString += "                  <RegistryValue Root=""$(var.RegRoot)"" Key=""Software\RDP2MSI\$(var.ProductName)"" " & vbCrLf
            wxsString += "                            Name=""installed"" Type=""integer"" Value=""1"" KeyPath=""yes""/>" & vbCrLf
            wxsString += "                  <RemoveFolder Id=""ProgramMenuSubfolder"" On=""uninstall""/>" & vbCrLf
            wxsString += "               </Component>" & vbCrLf
            If Not ShortcutLocations.ToUpper.Contains("N") Then wxsString += "            </Directory>" & vbCrLf
            wxsString += "         </Directory>" & vbCrLf
        End If

        If ShortcutLocations.ToUpper.Contains("D") Then
            wxsString += "	     <Directory Id=""DesktopFolder"">" & vbCrLf
            wxsString += "		   <Component Id=""ApplicationDesktopShortcuts"" Guid=""$(var.AppDeskShortcutsGuid)"">" & vbCrLf
            wxsString += "			  <Shortcut Id=""rdpDesktopShortcut1"" Name=""$(var.ProductName)$(var.ProductRemoteTag)"" Description=""$(var.ProductName)$(var.ProductRemoteTag)"" " & vbCrLf
            wxsString += "						Target=""[INSTALLDIR]$(var.ProductFileName).rdp"" WorkingDirectory=""INSTALLDIR"""

            If HasIcon Then
                wxsString += " Icon=""rdpDeskIcon.rdp"" IconIndex=""0"">" & vbCrLf
                wxsString += "						<Icon Id=""rdpDeskIcon.rdp"" SourceFile=""$(var.ProductFileName).ico"" />" & vbCrLf
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
        If ShortcutLocations.ToUpper.Contains("S") Then wxsString += "         <ComponentRef Id=""ApplicationStartShortcuts""/>" & vbCrLf
        If ShortcutLocations.ToUpper.Contains("D") Then wxsString += "		 <ComponentRef Id=""ApplicationDesktopShortcuts""/>" & vbCrLf
        wxsString += "      </Feature>" & vbCrLf
        If HasIcon Then
            wxsString += "<Icon Id=""rdpARPIcon.rdp"" SourceFile=""$(var.ProductFileName).ico"" />" & vbCrLf
            wxsString += "<Property Id=""ARPPRODUCTICON"" Value=""rdpARPIcon.rdp"" />" & vbCrLf
        End If
        wxsString += "   </Product>" & vbCrLf
        wxsString += "</Wix>" & vbCrLf

        Return wxsString

    End Function

    Function ReadRDPProperty(rdpFile As String, rdpProperty As String) As String
        Dim rdpFileContents = My.Computer.FileSystem.ReadAllText(rdpFile)
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

    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpString As String, _
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, _
    ByVal lpKeyName As String, ByVal lpDefault As String, _
    ByVal lpReturnedString As String, ByVal nSize As Int32, _
    ByVal lpFileName As String) As Int32

    Public Sub writeIni(ByVal iniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamVal As String)
        Dim Result As Integer = WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName)
    End Sub

    Public Function ReadIni(ByVal IniFileName As String, ByVal Section As String, ByVal ParamName As String, ByVal ParamDefault As String) As String
        Dim ParamVal As String = Space$(1024)
        Dim LenParamVal As Long = GetPrivateProfileString(Section, ParamName, ParamDefault, ParamVal, Len(ParamVal), IniFileName)
        ReadIni = Left$(ParamVal, LenParamVal)
    End Function

    Public Function RunWait(App As String, Parameters As String) As Integer
        Dim proc As New Process
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proc.StartInfo.FileName = App
        proc.StartInfo.Arguments = Parameters
        proc.Start()
        proc.WaitForExit()
        Return proc.ExitCode
    End Function

End Module
