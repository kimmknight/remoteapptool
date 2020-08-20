Imports RemoteAppLib

Module LocalFtaModule

    Public Sub RemoveUnusedFTAs()
        Dim KeyNames = My.Computer.Registry.ClassesRoot().GetSubKeyNames
        Dim RemoveCount As Integer = 0

        For Each KeyName In KeyNames
            Dim FTAkey As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey(KeyName)
            Dim RAvalue As String = FTAkey.GetValue("RemoteApp", "")
            If Not RAvalue = "" Then
                For Each KeyName2 In KeyNames
                    Try
                        Dim FTkey As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot.OpenSubKey(KeyName2)
                        Dim FTvalue As String = FTkey.GetValue("", "")
                        If FTvalue = KeyName Then
                            Dim sra As New RemoteAppLib.SystemRemoteApps
                            Dim AppExists As Boolean = False
                            For Each app As RemoteAppLib.RemoteApp In sra.GetAll
                                If app.Name = GetAppForFTA(KeyName2) Then AppExists = True
                            Next
                            If Not AppExists Then
                                LocalFtaModule.DeleteFTA(KeyName2)
                                RemoveCount += 1
                            End If
                        End If
                    Catch ex As Exception

                    End Try

                Next
            End If
        Next

        MessageBox.Show("Unused file type associations removed: " & RemoveCount, "File Type Association", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Function CreateFTACollection(ftaCol As FileTypeAssociationCollection, exeFile As String, RemoteAppName As String, Optional overwrite As Boolean = False) As String
        CreateFTACollection = ""
        For Each fta As FileTypeAssociation In ftaCol
            If DoesFTAExist(fta.Extension) And CreateFTA(fta, exeFile, RemoteAppName, overwrite) = False Then
                CreateFTACollection += "|" & fta.Extension
            End If
        Next
        CreateFTACollection = CreateFTACollection.Trim("|")
    End Function

    Public Function CreateFTA(fta As FileTypeAssociation, exeFile As String, RemoteAppName As String, Optional overwrite As Boolean = False) As Boolean
        If DoesFTAExist(fta.Extension) = False Or overwrite = True Then
            DeleteFTA(fta.Extension)

            Dim FileTypeReg = My.Computer.Registry.ClassesRoot.CreateSubKey("." & fta.Extension)
            FileTypeReg.SetValue("", fta.Extension & "_file")

            Dim FileTypeKey = My.Computer.Registry.ClassesRoot.CreateSubKey(fta.Extension & "_file")
            FileTypeKey.SetValue("RemoteApp", RemoteAppName)

            Dim FileTypeKeyShell = FileTypeKey.CreateSubKey("shell")
            Dim FileTypeKeyShellOpen = FileTypeKeyShell.CreateSubKey("open")
            Dim FileTypeKeyShellOpenCommand = FileTypeKeyShellOpen.CreateSubKey("command")

            FileTypeKeyShellOpenCommand.SetValue("", """" & exeFile & """ ""%1""")

            Dim FileTypeKeyDefIcon = FileTypeKey.CreateSubKey("DefaultIcon")
            FileTypeKeyDefIcon.SetValue("", """" & fta.IconPath & """," & fta.IconIndex)
            CreateFTA = True
        Else
            CreateFTA = False
        End If
    End Function

    Public Function GetAppForFTA(fileExtension As String) As String
        fileExtension = fileExtension.TrimStart(".")
        GetAppForFTA = ""

        If DoesFTAExist(fileExtension) And IsFTAMine(fileExtension) Then
            Try
                Dim HKCRext As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot().OpenSubKey("." & fileExtension)
                Dim HKCRfta = HKCRext.GetValue("", "")
                If Not HKCRfta = "" Then
                    Dim HKCRftaKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot().OpenSubKey(HKCRfta)
                    GetAppForFTA = HKCRftaKey.GetValue("RemoteApp", "")
                End If

            Catch ex As Exception

            End Try

        End If
    End Function

    Public Sub DeleteFTA(fileExtension As String)
        fileExtension = fileExtension.TrimStart(".")
        If Not My.Computer.Registry.ClassesRoot.OpenSubKey("." & fileExtension) Is Nothing Then _
            My.Computer.Registry.ClassesRoot.DeleteSubKeyTree("." & fileExtension)

        If Not My.Computer.Registry.ClassesRoot.OpenSubKey(fileExtension & "_file") Is Nothing Then _
        My.Computer.Registry.ClassesRoot.DeleteSubKeyTree(fileExtension & "_file")
    End Sub

    Public Function DoesFTAExist(fileExtension As String) As Boolean
        fileExtension = fileExtension.TrimStart(".")
        Dim FTAexists As Boolean = False

        If Not (My.Computer.Registry.ClassesRoot().OpenSubKey("." & fileExtension) Is Nothing) Then
            FTAexists = True
        End If

        Return FTAexists
    End Function


    Public Function IsFTAMine(fileExtension As String) As Boolean
        fileExtension = fileExtension.TrimStart(".")
        IsFTAMine = False
        Try
            Dim HKCRext As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot().OpenSubKey("." & fileExtension)
            Dim HKCRfta = HKCRext.GetValue("", "")
            If Not HKCRfta = "" Then
                Dim HKCRftaKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.ClassesRoot().OpenSubKey(HKCRfta)
                If Not HKCRftaKey.GetValue("RemoteApp", "") = "" Then IsFTAMine = True
            End If

        Catch ex As Exception

        End Try

    End Function

End Module
