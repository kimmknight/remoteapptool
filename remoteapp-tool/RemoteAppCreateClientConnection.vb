Imports VB = Microsoft.VisualBasic

Public Class RemoteAppCreateClientConnection

    Private RemoteApp As New RemoteAppLib.RemoteApp

    Public Sub CreateClientConnection(SelectedRemoteApp As RemoteAppLib.RemoteApp)

        RemoteApp = SelectedRemoteApp

        Dim rdpSign As New RDPSign.RDPSign
        Dim RemoteAppShortName = RemoteApp.Name
        Me.Text = "Create Client Connection for " & RemoteAppShortName

        CertificateComboBox.Items.AddRange(rdpSign.GetCertificateFriendlyName)

        SetCCWindowSettings()

        If Me.ServerAddress.Text = "" Then Me.ServerAddress.Text = System.Net.Dns.GetHostName
        If Me.AltServerAddress.Text = "" Then Me.AltServerAddress.Text = Me.ServerAddress.Text
        If Me.ServerPort.Text = "0" Then Me.ServerPort.Text = "3389"

        If Not My.Computer.FileSystem.FileExists(RemoteApp.IconPath) Then
            CreateRAWebIcon.Checked = False
            CreateRAWebIcon.Enabled = False
        Else
            CreateRAWebIcon.Enabled = RDPRadioButton.Checked
        End If

        Dim wx As New RDP2MSIlib.RDP
        If Not wx.WixInstalled Then
            RDPRadioButton.Checked = True
            MSIRadioButton.Enabled = False
            MSIRadioButton.Text = "MSI installer (requires WiX Toolset)"
        End If

        If Not My.Computer.FileSystem.FileExists(rdpSign.GetRdpsignExeLocation) Then
            GroupBoxSignRDP.Enabled = False
            GroupBoxSignRDP.Text += " (requires rdpsign.exe)"
            GroupBoxSignRDP.Tag = "noexe"
            CheckBoxSignRDPEnabled.Checked = False
            CheckBoxCreateSignedAndUnsigned.Checked = False
            CertificateComboBox.Text = ""
        End If

        If Not RemoteApp.FileTypeAssociations Is Nothing Then _
        FTACountLabel.Text = "Count: " & RemoteApp.FileTypeAssociations.Count

        Me.RDPRadioButton.Focus()
        HelpSystem.SetupTips(Me)
        Me.ShowDialog()
        RemoteAppMainWindow.ReloadApps()
        Me.Dispose()
    End Sub

    Sub ResetCCWindowSettings()
        My.Settings.SavedConnectionModeMSI = False
        My.Settings.SavedOpenWithNotepad = False
        My.Settings.SavedServerAddress = System.Net.Dns.GetHostName
        My.Settings.SavedServerPort = 3389
        My.Settings.SavedAltServerAddress = My.Settings.SavedServerAddress
        My.Settings.SavedUseRDGateway = False
        My.Settings.SavedRDGatewayAddress = ""
        My.Settings.SavedAttemptDirectRDGateway = False
        My.Settings.SavedMSIShortcutDesktop = True
        My.Settings.SavedMSIShortcutStart = True
        My.Settings.SavedMSIShortcutStartTopLevel = False
        My.Settings.SavedUseShortcutTag = True
        My.Settings.SavedShortcutTag = "remote"
        My.Settings.SavedClientConnectionOptions = False
        My.Settings.SavedCreateRAWebIcon = False
        My.Settings.SavedMSIPerUser = False
        My.Settings.SavedDisableFTA = False
        My.Settings.SavedSignRDP = False
        My.Settings.SavedSignedAndUnsigned = False
        My.Settings.SavedCertSelected = 0
    End Sub

    Sub SaveCCWindowSettings()
        My.Settings.SavedConnectionModeMSI = MSIRadioButton.Checked
        My.Settings.SavedOpenWithNotepad = EditAfterSave.Checked
        My.Settings.SavedServerAddress = ServerAddress.Text
        My.Settings.SavedServerPort = Val(ServerPort.Text)
        My.Settings.SavedAltServerAddress = AltServerAddress.Text
        My.Settings.SavedUseRDGateway = UseRDGatewayCheckBox.Checked
        My.Settings.SavedRDGatewayAddress = GatewayAddress.Text
        My.Settings.SavedAttemptDirectRDGateway = AttemptDirectCheckBox.Checked
        My.Settings.SavedMSIShortcutDesktop = ShortcutDesktopCheckBox.Checked
        My.Settings.SavedMSIShortcutStart = ShortcutStartCheckBox.Checked
        My.Settings.SavedMSIShortcutStartTopLevel = TopLevelRadioButton.Checked
        My.Settings.SavedUseShortcutTag = ShortcutTagCheckBox.Checked
        My.Settings.SavedShortcutTag = ShortcutTagTextBox.Text
        My.Settings.SavedCreateRAWebIcon = CreateRAWebIcon.Checked
        My.Settings.SavedMSIPerUser = PerUserRadioButton.Checked
        My.Settings.SavedDisableFTA = DisabledFTACheckBox.Checked
        My.Settings.SavedSignRDP = CheckBoxSignRDPEnabled.Checked
        My.Settings.SavedSignedAndUnsigned = CheckBoxCreateSignedAndUnsigned.Checked
        My.Settings.SavedCertSelected = CertificateComboBox.SelectedIndex
    End Sub

    Sub SetCCWindowSettings()
        If My.Settings.SavedConnectionModeMSI = True Then
            RDPRadioButton.Checked = False
            MSIRadioButton.Checked = True
        Else
            RDPRadioButton.Checked = True
            MSIRadioButton.Checked = False
        End If
        EditAfterSave.Checked = My.Settings.SavedOpenWithNotepad
        ServerAddress.Text = My.Settings.SavedServerAddress
        ServerPort.Text = My.Settings.SavedServerPort
        AltServerAddress.Text = My.Settings.SavedAltServerAddress
        UseRDGatewayCheckBox.Checked = My.Settings.SavedUseRDGateway
        GatewayAddress.Text = My.Settings.SavedRDGatewayAddress
        AttemptDirectCheckBox.Checked = My.Settings.SavedAttemptDirectRDGateway
        ShortcutDesktopCheckBox.Checked = My.Settings.SavedMSIShortcutDesktop
        ShortcutStartCheckBox.Checked = My.Settings.SavedMSIShortcutStart
        If My.Settings.SavedMSIShortcutStartTopLevel = True Then
            SubfolderRadioButton.Checked = False
            TopLevelRadioButton.Checked = True
        Else
            SubfolderRadioButton.Checked = True
            TopLevelRadioButton.Checked = False
        End If
        ShortcutTagCheckBox.Checked = My.Settings.SavedUseShortcutTag
        ShortcutTagTextBox.Text = My.Settings.SavedShortcutTag
        MSIGroupBox.Enabled = MSIRadioButton.Checked
        CreateRAWebIcon.Checked = My.Settings.SavedCreateRAWebIcon
        DisabledFTACheckBox.Checked = My.Settings.SavedDisableFTA
        If My.Settings.SavedMSIPerUser = False Then
            PerMachineRadioButton.Checked = True
            PerUserRadioButton.Checked = False
        Else
            PerMachineRadioButton.Checked = False
            PerUserRadioButton.Checked = True
        End If

        CheckBoxSignRDPEnabled.Checked = My.Settings.SavedSignRDP
        CertificateComboBox.Enabled = My.Settings.SavedSignRDP
        CheckBoxCreateSignedAndUnsigned.Checked = My.Settings.SavedSignedAndUnsigned

        If CertificateComboBox.Items.Count >= (My.Settings.SavedCertSelected + 1) Then
            CertificateComboBox.SelectedIndex() = My.Settings.SavedCertSelected
        ElseIf CertificateComboBox.Items.Count > 0 Then
            CertificateComboBox.SelectedIndex() = 0
        ElseIf Not GroupBoxSignRDP.Tag = "noexe" Then
            GroupBoxSignRDP.Text += " (No certificates found)"
            GroupBoxSignRDP.Enabled = False
            CheckBoxSignRDPEnabled.Checked = False
            CheckBoxCreateSignedAndUnsigned.Checked = False
            CertificateComboBox.Text = ""
        End If

    End Sub

    Private Sub UseRDGatewayCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles UseRDGatewayCheckBox.CheckedChanged
        If UseRDGatewayCheckBox.Checked Then
            Me.GatewayAddress.Enabled = True
            Me.RDGWLabel.Enabled = True
            Me.AttemptDirectCheckBox.Enabled = True
        Else
            Me.GatewayAddress.Enabled = False
            Me.RDGWLabel.Enabled = False
            Me.AttemptDirectCheckBox.Enabled = False
        End If
    End Sub

    Private Sub RDPRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RDPRadioButton.CheckedChanged
        MSIGroupBox.Enabled = MSIRadioButton.Checked
        EditAfterSave.Enabled = RDPRadioButton.Checked
        CreateRAWebIcon.Enabled = RDPRadioButton.Checked

        If RDPRadioButton.Checked Then
            CreateButton.ImageIndex = 6
            CheckBoxCreateSignedAndUnsigned.Enabled = True
        Else
            CreateButton.ImageIndex = 1
            CheckBoxCreateSignedAndUnsigned.Enabled = False
            CheckBoxCreateSignedAndUnsigned.Checked = False
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim RDPPath = ""
        Dim MSIPath = ""
        Dim TempMSIPath = ""

        If CheckBoxSignRDPEnabled.Checked And CertificateComboBox.SelectedItem = "" Then
            MessageBox.Show("You must select a certificate to sign the RDP file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If DisabledFTACheckBox.Checked And Not RemoteApp.FileTypeAssociations Is Nothing Then RemoteApp.FileTypeAssociations.Clear()

        If RDPRadioButton.Checked Then
            FileSaveRDP.FileName = RemoteApp.Name
            If Not FileSaveRDP.ShowDialog() = Windows.Forms.DialogResult.OK Then Return
            RDPPath = FileSaveRDP.FileName
        Else
            FileSaveMSI.FileName = RemoteApp.Name
            If Not FileSaveMSI.ShowDialog() = Windows.Forms.DialogResult.OK Then Return
            MSIPath = FileSaveMSI.FileName
            RDPPath = Environment.GetEnvironmentVariable("TEMP") & "\" & RemoteApp.Name & ".rdp"
            TempMSIPath = Environment.GetEnvironmentVariable("TEMP") & "\" & RemoteApp.Name & ".msi"
        End If

        Dim gwaddress As String = ""
        Dim trydirect As Boolean = False
        If UseRDGatewayCheckBox.Checked Then
            gwaddress = GatewayAddress.Text
            trydirect = AttemptDirectCheckBox.Checked
        End If


        If RDPRadioButton.Checked Then
            CreateRDPFile(RDPPath, RemoteApp)
            '!!!!!!! If it's an RDP file
            If EditAfterSave.Checked Then
                Dim CmdLine = GetSysDir() & "\notepad.exe"
                System.Diagnostics.Process.Start(CmdLine, FileSaveRDP.FileName)
            End If
            If CreateRAWebIcon.Checked Then
                Dim IconFilePath = Microsoft.VisualBasic.Left(RDPPath, RDPPath.Length - 4) & ".ico"
                If ExtractToIco(RemoteApp.IconPath, RemoteApp.IconIndex, IconFilePath) = False Then
                    MessageBox.Show("Icon could not be created the RemoteApp. RDP file will still be created.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                ' Check if there are file type associations before trying to work with the file type association icons
                If Not (RemoteApp.FileTypeAssociations Is Nothing) Then
                    For Each FTA As RemoteAppLib.FileTypeAssociation In RemoteApp.FileTypeAssociations
                        Dim ProductFileName = VB.Left(RDPPath, RDPPath.Length - 4)
                        ExtractFTIcon(ProductFileName, FTA)
                    Next
                End If
            End If
            Me.Close()
        Else
            '!!!!!!!  If it's an MSI
            Dim RDP As New RDP2MSIlib.RDP
            CreateRDPFile(RDPPath, RemoteApp)

            RDP.rdpPath = RDPPath
            RDP.ShortcutOnDesktop = ShortcutDesktopCheckBox.Checked
            RDP.ShortcutInStart = ShortcutStartCheckBox.Checked
            RDP.ShortcutSubfolderInStart = SubfolderRadioButton.Checked
            RDP.ProductRemoteTag = ShortcutTagTextBox.Text
            RDP.PerUser = PerUserRadioButton.Checked

            Dim FilesToDelete As New ArrayList
            Dim ProductFileName = VB.Left(RDPPath, RDPPath.Length - 4)
            Dim IconFilePath = ProductFileName & ".ico"

            FilesToDelete.Add(RDPPath)

            If ExtractToIco(RemoteApp.IconPath, RemoteApp.IconIndex, IconFilePath) = False Then
                MessageBox.Show("There was an error loading icon:" & vbCrLf & RemoteApp.IconPath & "," & RemoteApp.IconIndex & vbCrLf & "The MSI will still be created but the main icon will be missing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                FilesToDelete.Add(IconFilePath)
            End If

            If Not RemoteApp.FileTypeAssociations Is Nothing Then
                For Each FTA As RemoteAppLib.FileTypeAssociation In RemoteApp.FileTypeAssociations
                    ExtractFTIcon(ProductFileName, FTA)
                    FilesToDelete.Add(ProductFileName & "." & FTA.Extension & ".ico")
                Next
                RDP.FlatFileTypes = RemoteApp.FileTypeAssociations.GetFlatFileTypes
            End If


            RDP.CreateMSI(MSIPath)

            DeleteFiles(FilesToDelete)
            Me.Close()
        End If
    End Sub

    Private Sub ExtractFTIcon(ProductFileName As String, FTA As RemoteAppLib.FileTypeAssociation)
        'Extract icon for filetype
        If ExtractToIco(FTA.IconPath, FTA.IconIndex, ProductFileName & "." & FTA.Extension & ".ico") = False Then
            'If filetype icon fails to extract, then grab the default document icon from Shell32.dll
            ExtractToIco(GetSysDir() & "\shell32.dll", 0, ProductFileName & "." & FTA.Extension & ".ico")
            'Possibly show an error here??
        End If
    End Sub

    Private Sub CreateRDPFile(RDPPath As String, RemoteApp As RemoteAppLib.RemoteApp)

        'Dim App As New RemoteAppLib.RemoteApp = RemoteApp
        'App = RemoteApp
        Dim FileTypeAssociations As RemoteAppLib.FileTypeAssociationCollection
        FileTypeAssociations = RemoteApp.FileTypeAssociations

        Dim ServerAddress = Me.ServerAddress.Text
        Dim AltServerAddress = Me.AltServerAddress.Text
        Dim ServerPort = Me.ServerPort.Text

        Dim FlatFileTypes = ""
        If Not FileTypeAssociations Is Nothing Then FlatFileTypes = FileTypeAssociations.GetFlatFileTypes

        Dim RDPfile As New RDPFileLib.RDPFile With {
            .full_address = ServerAddress,
            .alternate_full_address = AltServerAddress,
            .server_port = Val(ServerPort),
            .remoteapplicationname = RemoteApp.FullName,
            .remoteapplicationprogram = "||" & RemoteApp.Name,
            .remoteapplicationmode = 1,
            .disableremoteappcapscheck = 1,
            .alternate_shell = "rdpinit.exe"
        }

        If UseRDGatewayCheckBox.Checked Then
            RDPfile.gatewayhostname = Me.GatewayAddress.Text
            If Me.AttemptDirectCheckBox.CheckAlign Then RDPfile.gatewayusagemethod = 2 Else RDPfile.gatewayusagemethod = 1
            RDPfile.gatewayprofileusagemethod = 1
        End If

        RDPfile.prompt_for_credentials_on_client = 1
        RDPfile.promptcredentialonce = 0

        RDPfile.devicestoredirect = "*"
        RDPfile.drivestoredirect = "*"
        RDPfile.redirectcomports = 1
        RDPfile.redirectdrives = 1

        RDPfile.allow_desktop_composition = 1
        RDPfile.allow_font_smoothing = 1
        RDPfile.span_monitors = 1
        RDPfile.use_multimon = 1

        RDPfile.remoteapplicationfileextensions = FlatFileTypes

        RDPfile.SaveRDPfile(RDPPath)

        If CheckBoxSignRDPEnabled.Checked Then
            Dim rdpSign As New RDPSign.RDPSign
            Dim Thumbprint As String = rdpSign.GetThumbprint(CertificateComboBox.Text)
            rdpSign.SignRDP(Thumbprint, RDPPath, CheckBoxCreateSignedAndUnsigned.Checked)
        End If

    End Sub

    Private Function GetFlatFileTypesList(AppName As String, Optional Delim As String = ",") As String
        Dim BaseKeyName As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList\Applications\" & AppName & "\Filetypes"
        Dim FlatFTList = ""

        Try
            Dim BaseKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey(BaseKeyName)

            For Each FT As String In BaseKey.GetSubKeyNames
                FlatFTList &= "." & FT & Delim
            Next
            FlatFTList = FlatFTList.TrimEnd(Delim)

        Catch Ex As Exception

        End Try
        Return FlatFTList
    End Function

    Private Sub FTAButton_Click(sender As Object, e As EventArgs) Handles FTAButton.Click
        MessageBox.Show(Me, "Changes made here to File Type Associations are for this client connection only and will not be saved for next time." & vbCrLf & vbCrLf &
               "To make permanent changes to the File Type Associations for this RemoteApp, edit the RemoteApp.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RemoteApp = RemoteAppFileTypeAssociation.EditFileTypes(RemoteApp)
        If Not RemoteApp.FileTypeAssociations Is Nothing Then _
        FTACountLabel.Text = "Count: " & RemoteApp.FileTypeAssociations.Count

    End Sub

    Private Sub ShortcutStartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShortcutStartCheckBox.CheckedChanged
        SubfolderRadioButton.Enabled = ShortcutStartCheckBox.Checked
        TopLevelRadioButton.Enabled = ShortcutStartCheckBox.Checked
    End Sub

    Private Sub ShortcutTagCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShortcutTagCheckBox.CheckedChanged
        ShortcutTagTextBox.Enabled = ShortcutTagCheckBox.Checked
    End Sub

    Private Sub ServerAddress_TextChanged(sender As Object, e As EventArgs) Handles ServerAddress.TextChanged
        ValidateDNSname(ServerAddress)
    End Sub

    Private Sub AltServerAddress_TextChanged(sender As Object, e As EventArgs) Handles AltServerAddress.TextChanged
        ValidateDNSname(AltServerAddress)
    End Sub

    Private Sub ServerPort_TextChanged(sender As Object, e As EventArgs) Handles ServerPort.TextChanged
        ValidatePort(ServerPort)
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ResetCCWindowSettings()
        SetCCWindowSettings()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveCCWindowSettings()
    End Sub

    Private Sub DisabledFTACheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DisabledFTACheckBox.CheckedChanged
        If Me.DisabledFTACheckBox.Checked Then
            Me.FTAButton.Enabled = False
            Me.FTACountLabel.Enabled = False
        Else
            Me.FTAButton.Enabled = True
            Me.FTACountLabel.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxSignRDPEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSignRDPEnabled.CheckedChanged
        CertificateComboBox.Enabled = CheckBoxSignRDPEnabled.Checked
        If (EditAfterSave.Checked And CheckBoxSignRDPEnabled.Checked) Then
            If MessageBox.Show("You have selected ""Sign RDP file"" and ""Manually edit RDP file""." & vbCrLf & vbCrLf & "If you save any changes to a signed RDP file it will stop working." & vbCrLf & vbCrLf & "Are you sure you want the RDP file to be signed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                CheckBoxSignRDPEnabled.Checked = True
            Else
                CheckBoxSignRDPEnabled.Checked = False
            End If
        End If
    End Sub

    Private Sub EditAfterSave_CheckedChanged(sender As Object, e As EventArgs) Handles EditAfterSave.CheckedChanged
        If (EditAfterSave.Checked And CheckBoxSignRDPEnabled.Checked) Then
            If MessageBox.Show("You have selected ""Sign RDP file"" and ""Manually edit RDP file""." & vbCrLf & vbCrLf & "If you save any changes to a signed RDP file it will stop working." & vbCrLf & vbCrLf & "Are you sure you want to edit after saving?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                EditAfterSave.Checked = True
            Else
                EditAfterSave.Checked = False
            End If
        End If

    End Sub

    Private Sub CheckBoxCreateSignedAndUnsigned_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCreateSignedAndUnsigned.CheckedChanged
        If CheckBoxCreateSignedAndUnsigned.Checked = True Then
            CheckBoxSignRDPEnabled.Checked = True
        End If
    End Sub
End Class