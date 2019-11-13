<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteAppCreateClientConnection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteAppCreateClientConnection))
        Me.EditAfterSave = New System.Windows.Forms.CheckBox()
        Me.SmallerIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.FileSaveRDP = New System.Windows.Forms.SaveFileDialog()
        Me.CancelEditButton = New System.Windows.Forms.Button()
        Me.ServerGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ServerPort = New System.Windows.Forms.TextBox()
        Me.AltServerAddress = New System.Windows.Forms.TextBox()
        Me.ServerAddress = New System.Windows.Forms.TextBox()
        Me.RDGWGroupBox = New System.Windows.Forms.GroupBox()
        Me.AttemptDirectCheckBox = New System.Windows.Forms.CheckBox()
        Me.UseRDGatewayCheckBox = New System.Windows.Forms.CheckBox()
        Me.RDGWLabel = New System.Windows.Forms.Label()
        Me.GatewayAddress = New System.Windows.Forms.TextBox()
        Me.ClientConnectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.MSIRadioButton = New System.Windows.Forms.RadioButton()
        Me.RDPRadioButton = New System.Windows.Forms.RadioButton()
        Me.CreateRAWebIcon = New System.Windows.Forms.CheckBox()
        Me.FTAButton = New System.Windows.Forms.Button()
        Me.FileBrowserIcon = New System.Windows.Forms.OpenFileDialog()
        Me.FileSaveMSI = New System.Windows.Forms.SaveFileDialog()
        Me.ShortcutDesktopCheckBox = New System.Windows.Forms.CheckBox()
        Me.MSIGroupBox = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PerMachineRadioButton = New System.Windows.Forms.RadioButton()
        Me.PerUserRadioButton = New System.Windows.Forms.RadioButton()
        Me.TopLevelRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubfolderRadioButton = New System.Windows.Forms.RadioButton()
        Me.ShortcutStartCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShortcutTagCheckBox = New System.Windows.Forms.CheckBox()
        Me.ShortcutTagTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.FileTypesGroupBox = New System.Windows.Forms.GroupBox()
        Me.FTACountLabel = New System.Windows.Forms.Label()
        Me.DisabledFTACheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSignRDP = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCreateSignedAndUnsigned = New System.Windows.Forms.CheckBox()
        Me.CertificateComboBox = New System.Windows.Forms.ComboBox()
        Me.CertificateLabel = New System.Windows.Forms.Label()
        Me.CheckBoxSignRDPEnabled = New System.Windows.Forms.CheckBox()
        Me.ServerGroupBox.SuspendLayout()
        Me.RDGWGroupBox.SuspendLayout()
        Me.ClientConnectionGroupBox.SuspendLayout()
        Me.MSIGroupBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FileTypesGroupBox.SuspendLayout()
        Me.GroupBoxSignRDP.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditAfterSave
        '
        Me.EditAfterSave.BackColor = System.Drawing.Color.Transparent
        Me.EditAfterSave.ImageIndex = 2
        Me.EditAfterSave.ImageList = Me.SmallerIcons
        Me.EditAfterSave.Location = New System.Drawing.Point(313, 13)
        Me.EditAfterSave.Name = "EditAfterSave"
        Me.EditAfterSave.Size = New System.Drawing.Size(165, 30)
        Me.EditAfterSave.TabIndex = 2
        Me.EditAfterSave.Text = "Manually edit RDP file"
        Me.EditAfterSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.EditAfterSave.UseVisualStyleBackColor = False
        '
        'SmallerIcons
        '
        Me.SmallerIcons.ImageStream = CType(resources.GetObject("SmallerIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallerIcons.Images.SetKeyName(0, "save-as_16x16.png")
        Me.SmallerIcons.Images.SetKeyName(1, "msi small.ico")
        Me.SmallerIcons.Images.SetKeyName(2, "doc_file_document_manager_paper_phone.ico")
        Me.SmallerIcons.Images.SetKeyName(3, "16.ico")
        Me.SmallerIcons.Images.SetKeyName(4, "cross.ico")
        Me.SmallerIcons.Images.SetKeyName(5, "pictures (1).ico")
        Me.SmallerIcons.Images.SetKeyName(6, "Remote Desktop Connection.ico")
        '
        'CreateButton
        '
        Me.CreateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CreateButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CreateButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CreateButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CreateButton.ImageIndex = 6
        Me.CreateButton.ImageList = Me.SmallerIcons
        Me.CreateButton.Location = New System.Drawing.Point(416, 555)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(80, 29)
        Me.CreateButton.TabIndex = 9
        Me.CreateButton.Text = "Create..."
        Me.CreateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'FileSaveRDP
        '
        Me.FileSaveRDP.DefaultExt = "rdp"
        Me.FileSaveRDP.Filter = "RDP files|*.rdp"
        '
        'CancelEditButton
        '
        Me.CancelEditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CancelEditButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelEditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelEditButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CancelEditButton.ImageIndex = 4
        Me.CancelEditButton.ImageList = Me.SmallerIcons
        Me.CancelEditButton.Location = New System.Drawing.Point(343, 555)
        Me.CancelEditButton.Name = "CancelEditButton"
        Me.CancelEditButton.Size = New System.Drawing.Size(67, 29)
        Me.CancelEditButton.TabIndex = 8
        Me.CancelEditButton.Text = "Cancel"
        Me.CancelEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelEditButton.UseVisualStyleBackColor = False
        '
        'ServerGroupBox
        '
        Me.ServerGroupBox.Controls.Add(Me.Label13)
        Me.ServerGroupBox.Controls.Add(Me.Label14)
        Me.ServerGroupBox.Controls.Add(Me.Label12)
        Me.ServerGroupBox.Controls.Add(Me.ServerPort)
        Me.ServerGroupBox.Controls.Add(Me.AltServerAddress)
        Me.ServerGroupBox.Controls.Add(Me.ServerAddress)
        Me.ServerGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ServerGroupBox.Location = New System.Drawing.Point(12, 92)
        Me.ServerGroupBox.Name = "ServerGroupBox"
        Me.ServerGroupBox.Size = New System.Drawing.Size(484, 87)
        Me.ServerGroupBox.TabIndex = 1
        Me.ServerGroupBox.TabStop = False
        Me.ServerGroupBox.Text = "Remote Server"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Alternative server:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(382, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Port:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Server address:"
        '
        'ServerPort
        '
        Me.ServerPort.Location = New System.Drawing.Point(420, 22)
        Me.ServerPort.Name = "ServerPort"
        Me.ServerPort.Size = New System.Drawing.Size(53, 23)
        Me.ServerPort.TabIndex = 3
        Me.ServerPort.Text = "3389"
        '
        'AltServerAddress
        '
        Me.AltServerAddress.Location = New System.Drawing.Point(121, 51)
        Me.AltServerAddress.Name = "AltServerAddress"
        Me.AltServerAddress.Size = New System.Drawing.Size(352, 23)
        Me.AltServerAddress.TabIndex = 5
        '
        'ServerAddress
        '
        Me.ServerAddress.Location = New System.Drawing.Point(121, 22)
        Me.ServerAddress.Name = "ServerAddress"
        Me.ServerAddress.Size = New System.Drawing.Size(255, 23)
        Me.ServerAddress.TabIndex = 1
        '
        'RDGWGroupBox
        '
        Me.RDGWGroupBox.Controls.Add(Me.AttemptDirectCheckBox)
        Me.RDGWGroupBox.Controls.Add(Me.UseRDGatewayCheckBox)
        Me.RDGWGroupBox.Controls.Add(Me.RDGWLabel)
        Me.RDGWGroupBox.Controls.Add(Me.GatewayAddress)
        Me.RDGWGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RDGWGroupBox.Location = New System.Drawing.Point(12, 185)
        Me.RDGWGroupBox.Name = "RDGWGroupBox"
        Me.RDGWGroupBox.Size = New System.Drawing.Size(484, 103)
        Me.RDGWGroupBox.TabIndex = 2
        Me.RDGWGroupBox.TabStop = False
        Me.RDGWGroupBox.Text = "Remote Desktop Gateway"
        '
        'AttemptDirectCheckBox
        '
        Me.AttemptDirectCheckBox.AutoSize = True
        Me.AttemptDirectCheckBox.Enabled = False
        Me.AttemptDirectCheckBox.Location = New System.Drawing.Point(10, 76)
        Me.AttemptDirectCheckBox.Name = "AttemptDirectCheckBox"
        Me.AttemptDirectCheckBox.Size = New System.Drawing.Size(326, 19)
        Me.AttemptDirectCheckBox.TabIndex = 3
        Me.AttemptDirectCheckBox.Text = "Only use RD Gateway if direct connection is unsuccessful"
        Me.AttemptDirectCheckBox.UseVisualStyleBackColor = True
        '
        'UseRDGatewayCheckBox
        '
        Me.UseRDGatewayCheckBox.AutoSize = True
        Me.UseRDGatewayCheckBox.Location = New System.Drawing.Point(10, 22)
        Me.UseRDGatewayCheckBox.Name = "UseRDGatewayCheckBox"
        Me.UseRDGatewayCheckBox.Size = New System.Drawing.Size(111, 19)
        Me.UseRDGatewayCheckBox.TabIndex = 0
        Me.UseRDGatewayCheckBox.Text = "Use RD Gateway"
        Me.UseRDGatewayCheckBox.UseVisualStyleBackColor = True
        '
        'RDGWLabel
        '
        Me.RDGWLabel.AutoSize = True
        Me.RDGWLabel.Enabled = False
        Me.RDGWLabel.Location = New System.Drawing.Point(7, 50)
        Me.RDGWLabel.Name = "RDGWLabel"
        Me.RDGWLabel.Size = New System.Drawing.Size(116, 15)
        Me.RDGWLabel.TabIndex = 1
        Me.RDGWLabel.Text = "RD Gateway address:"
        '
        'GatewayAddress
        '
        Me.GatewayAddress.Enabled = False
        Me.GatewayAddress.Location = New System.Drawing.Point(145, 47)
        Me.GatewayAddress.Name = "GatewayAddress"
        Me.GatewayAddress.Size = New System.Drawing.Size(328, 23)
        Me.GatewayAddress.TabIndex = 2
        '
        'ClientConnectionGroupBox
        '
        Me.ClientConnectionGroupBox.Controls.Add(Me.MSIRadioButton)
        Me.ClientConnectionGroupBox.Controls.Add(Me.RDPRadioButton)
        Me.ClientConnectionGroupBox.Controls.Add(Me.CreateRAWebIcon)
        Me.ClientConnectionGroupBox.Controls.Add(Me.EditAfterSave)
        Me.ClientConnectionGroupBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ClientConnectionGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.ClientConnectionGroupBox.Name = "ClientConnectionGroupBox"
        Me.ClientConnectionGroupBox.Size = New System.Drawing.Size(484, 74)
        Me.ClientConnectionGroupBox.TabIndex = 0
        Me.ClientConnectionGroupBox.TabStop = False
        Me.ClientConnectionGroupBox.Text = "Client Connection"
        '
        'MSIRadioButton
        '
        Me.MSIRadioButton.AutoSize = True
        Me.MSIRadioButton.Location = New System.Drawing.Point(10, 47)
        Me.MSIRadioButton.Name = "MSIRadioButton"
        Me.MSIRadioButton.Size = New System.Drawing.Size(89, 19)
        Me.MSIRadioButton.TabIndex = 1
        Me.MSIRadioButton.TabStop = True
        Me.MSIRadioButton.Text = "MSI installer"
        Me.MSIRadioButton.UseVisualStyleBackColor = True
        '
        'RDPRadioButton
        '
        Me.RDPRadioButton.AutoSize = True
        Me.RDPRadioButton.Checked = True
        Me.RDPRadioButton.Location = New System.Drawing.Point(10, 22)
        Me.RDPRadioButton.Name = "RDPRadioButton"
        Me.RDPRadioButton.Size = New System.Drawing.Size(66, 19)
        Me.RDPRadioButton.TabIndex = 0
        Me.RDPRadioButton.TabStop = True
        Me.RDPRadioButton.Text = "RDP file"
        Me.RDPRadioButton.UseVisualStyleBackColor = True
        '
        'CreateRAWebIcon
        '
        Me.CreateRAWebIcon.BackColor = System.Drawing.Color.Transparent
        Me.CreateRAWebIcon.ImageIndex = 5
        Me.CreateRAWebIcon.ImageList = Me.SmallerIcons
        Me.CreateRAWebIcon.Location = New System.Drawing.Point(313, 36)
        Me.CreateRAWebIcon.Name = "CreateRAWebIcon"
        Me.CreateRAWebIcon.Size = New System.Drawing.Size(126, 30)
        Me.CreateRAWebIcon.TabIndex = 3
        Me.CreateRAWebIcon.Text = "Create icon files"
        Me.CreateRAWebIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.CreateRAWebIcon.UseVisualStyleBackColor = False
        '
        'FTAButton
        '
        Me.FTAButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FTAButton.ImageIndex = 2
        Me.FTAButton.ImageList = Me.SmallerIcons
        Me.FTAButton.Location = New System.Drawing.Point(301, 22)
        Me.FTAButton.Name = "FTAButton"
        Me.FTAButton.Size = New System.Drawing.Size(172, 29)
        Me.FTAButton.TabIndex = 2
        Me.FTAButton.Text = "File type associations..."
        Me.FTAButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FTAButton.UseVisualStyleBackColor = False
        '
        'FileBrowserIcon
        '
        Me.FileBrowserIcon.Filter = "Icons|*.exe;*.dll;*.ico|All files|*.*"
        Me.FileBrowserIcon.Title = "Browse..."
        '
        'FileSaveMSI
        '
        Me.FileSaveMSI.DefaultExt = "msi"
        Me.FileSaveMSI.Filter = "MSI files|*.msi"
        '
        'ShortcutDesktopCheckBox
        '
        Me.ShortcutDesktopCheckBox.AutoSize = True
        Me.ShortcutDesktopCheckBox.Checked = True
        Me.ShortcutDesktopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShortcutDesktopCheckBox.Location = New System.Drawing.Point(116, 18)
        Me.ShortcutDesktopCheckBox.Name = "ShortcutDesktopCheckBox"
        Me.ShortcutDesktopCheckBox.Size = New System.Drawing.Size(69, 19)
        Me.ShortcutDesktopCheckBox.TabIndex = 1
        Me.ShortcutDesktopCheckBox.Text = "Desktop"
        Me.ShortcutDesktopCheckBox.UseVisualStyleBackColor = True
        '
        'MSIGroupBox
        '
        Me.MSIGroupBox.Controls.Add(Me.Panel1)
        Me.MSIGroupBox.Controls.Add(Me.TopLevelRadioButton)
        Me.MSIGroupBox.Controls.Add(Me.SubfolderRadioButton)
        Me.MSIGroupBox.Controls.Add(Me.ShortcutStartCheckBox)
        Me.MSIGroupBox.Controls.Add(Me.Label3)
        Me.MSIGroupBox.Controls.Add(Me.Label2)
        Me.MSIGroupBox.Controls.Add(Me.ShortcutTagCheckBox)
        Me.MSIGroupBox.Controls.Add(Me.ShortcutDesktopCheckBox)
        Me.MSIGroupBox.Controls.Add(Me.ShortcutTagTextBox)
        Me.MSIGroupBox.Controls.Add(Me.Label4)
        Me.MSIGroupBox.Controls.Add(Me.Label1)
        Me.MSIGroupBox.Enabled = False
        Me.MSIGroupBox.Location = New System.Drawing.Point(10, 363)
        Me.MSIGroupBox.Name = "MSIGroupBox"
        Me.MSIGroupBox.Size = New System.Drawing.Size(484, 107)
        Me.MSIGroupBox.TabIndex = 4
        Me.MSIGroupBox.TabStop = False
        Me.MSIGroupBox.Text = "MSI Options"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PerMachineRadioButton)
        Me.Panel1.Controls.Add(Me.PerUserRadioButton)
        Me.Panel1.Location = New System.Drawing.Point(89, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 26)
        Me.Panel1.TabIndex = 9
        '
        'PerMachineRadioButton
        '
        Me.PerMachineRadioButton.AutoSize = True
        Me.PerMachineRadioButton.Checked = True
        Me.PerMachineRadioButton.Location = New System.Drawing.Point(3, 3)
        Me.PerMachineRadioButton.Name = "PerMachineRadioButton"
        Me.PerMachineRadioButton.Size = New System.Drawing.Size(93, 19)
        Me.PerMachineRadioButton.TabIndex = 0
        Me.PerMachineRadioButton.TabStop = True
        Me.PerMachineRadioButton.Text = "Per-machine"
        Me.PerMachineRadioButton.UseVisualStyleBackColor = True
        '
        'PerUserRadioButton
        '
        Me.PerUserRadioButton.AutoSize = True
        Me.PerUserRadioButton.Location = New System.Drawing.Point(100, 3)
        Me.PerUserRadioButton.Name = "PerUserRadioButton"
        Me.PerUserRadioButton.Size = New System.Drawing.Size(69, 19)
        Me.PerUserRadioButton.TabIndex = 1
        Me.PerUserRadioButton.TabStop = True
        Me.PerUserRadioButton.Text = "Per-user"
        Me.PerUserRadioButton.UseVisualStyleBackColor = True
        '
        'TopLevelRadioButton
        '
        Me.TopLevelRadioButton.AutoSize = True
        Me.TopLevelRadioButton.Location = New System.Drawing.Point(366, 17)
        Me.TopLevelRadioButton.Name = "TopLevelRadioButton"
        Me.TopLevelRadioButton.Size = New System.Drawing.Size(72, 19)
        Me.TopLevelRadioButton.TabIndex = 4
        Me.TopLevelRadioButton.Text = "Top level"
        Me.TopLevelRadioButton.UseVisualStyleBackColor = True
        '
        'SubfolderRadioButton
        '
        Me.SubfolderRadioButton.AutoSize = True
        Me.SubfolderRadioButton.Checked = True
        Me.SubfolderRadioButton.Location = New System.Drawing.Point(284, 17)
        Me.SubfolderRadioButton.Name = "SubfolderRadioButton"
        Me.SubfolderRadioButton.Size = New System.Drawing.Size(76, 19)
        Me.SubfolderRadioButton.TabIndex = 3
        Me.SubfolderRadioButton.TabStop = True
        Me.SubfolderRadioButton.Text = "Subfolder"
        Me.SubfolderRadioButton.UseVisualStyleBackColor = True
        '
        'ShortcutStartCheckBox
        '
        Me.ShortcutStartCheckBox.AutoSize = True
        Me.ShortcutStartCheckBox.Checked = True
        Me.ShortcutStartCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShortcutStartCheckBox.Location = New System.Drawing.Point(191, 18)
        Me.ShortcutStartCheckBox.Name = "ShortcutStartCheckBox"
        Me.ShortcutStartCheckBox.Size = New System.Drawing.Size(87, 19)
        Me.ShortcutStartCheckBox.TabIndex = 2
        Me.ShortcutStartCheckBox.Text = "Start Menu:"
        Me.ShortcutStartCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = ")"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "("
        '
        'ShortcutTagCheckBox
        '
        Me.ShortcutTagCheckBox.AutoSize = True
        Me.ShortcutTagCheckBox.Checked = True
        Me.ShortcutTagCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShortcutTagCheckBox.Location = New System.Drawing.Point(10, 48)
        Me.ShortcutTagCheckBox.Name = "ShortcutTagCheckBox"
        Me.ShortcutTagCheckBox.Size = New System.Drawing.Size(94, 19)
        Me.ShortcutTagCheckBox.TabIndex = 5
        Me.ShortcutTagCheckBox.Text = "Shortcut tag:"
        Me.ShortcutTagCheckBox.UseVisualStyleBackColor = True
        '
        'ShortcutTagTextBox
        '
        Me.ShortcutTagTextBox.Location = New System.Drawing.Point(127, 46)
        Me.ShortcutTagTextBox.Name = "ShortcutTagTextBox"
        Me.ShortcutTagTextBox.Size = New System.Drawing.Size(156, 23)
        Me.ShortcutTagTextBox.TabIndex = 6
        Me.ShortcutTagTextBox.Text = "remote"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Install scope:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Place shortcuts in:"
        '
        'ResetButton
        '
        Me.ResetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ResetButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ResetButton.ImageIndex = 3
        Me.ResetButton.ImageList = Me.SmallerIcons
        Me.ResetButton.Location = New System.Drawing.Point(126, 555)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(121, 29)
        Me.ResetButton.TabIndex = 7
        Me.ResetButton.Text = "Reset to default"
        Me.ResetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveButton.ImageIndex = 0
        Me.SaveButton.ImageList = Me.SmallerIcons
        Me.SaveButton.Location = New System.Drawing.Point(12, 555)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(108, 29)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save settings"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'FileTypesGroupBox
        '
        Me.FileTypesGroupBox.Controls.Add(Me.FTACountLabel)
        Me.FileTypesGroupBox.Controls.Add(Me.DisabledFTACheckBox)
        Me.FileTypesGroupBox.Controls.Add(Me.FTAButton)
        Me.FileTypesGroupBox.Location = New System.Drawing.Point(12, 294)
        Me.FileTypesGroupBox.Name = "FileTypesGroupBox"
        Me.FileTypesGroupBox.Size = New System.Drawing.Size(482, 63)
        Me.FileTypesGroupBox.TabIndex = 3
        Me.FileTypesGroupBox.TabStop = False
        Me.FileTypesGroupBox.Text = "File Type Associations"
        '
        'FTACountLabel
        '
        Me.FTACountLabel.AutoSize = True
        Me.FTACountLabel.Location = New System.Drawing.Point(154, 29)
        Me.FTACountLabel.Name = "FTACountLabel"
        Me.FTACountLabel.Size = New System.Drawing.Size(52, 15)
        Me.FTACountLabel.TabIndex = 1
        Me.FTACountLabel.Text = "Count: 0"
        '
        'DisabledFTACheckBox
        '
        Me.DisabledFTACheckBox.AutoSize = True
        Me.DisabledFTACheckBox.Location = New System.Drawing.Point(10, 28)
        Me.DisabledFTACheckBox.Name = "DisabledFTACheckBox"
        Me.DisabledFTACheckBox.Size = New System.Drawing.Size(71, 19)
        Me.DisabledFTACheckBox.TabIndex = 0
        Me.DisabledFTACheckBox.Text = "Disabled"
        Me.DisabledFTACheckBox.UseVisualStyleBackColor = True
        '
        'GroupBoxSignRDP
        '
        Me.GroupBoxSignRDP.Controls.Add(Me.CheckBoxCreateSignedAndUnsigned)
        Me.GroupBoxSignRDP.Controls.Add(Me.CertificateComboBox)
        Me.GroupBoxSignRDP.Controls.Add(Me.CertificateLabel)
        Me.GroupBoxSignRDP.Controls.Add(Me.CheckBoxSignRDPEnabled)
        Me.GroupBoxSignRDP.Location = New System.Drawing.Point(12, 477)
        Me.GroupBoxSignRDP.Name = "GroupBoxSignRDP"
        Me.GroupBoxSignRDP.Size = New System.Drawing.Size(482, 68)
        Me.GroupBoxSignRDP.TabIndex = 5
        Me.GroupBoxSignRDP.TabStop = False
        Me.GroupBoxSignRDP.Text = "Digital Signing"
        '
        'CheckBoxCreateSignedAndUnsigned
        '
        Me.CheckBoxCreateSignedAndUnsigned.AutoSize = True
        Me.CheckBoxCreateSignedAndUnsigned.Location = New System.Drawing.Point(10, 41)
        Me.CheckBoxCreateSignedAndUnsigned.Name = "CheckBoxCreateSignedAndUnsigned"
        Me.CheckBoxCreateSignedAndUnsigned.Size = New System.Drawing.Size(175, 19)
        Me.CheckBoxCreateSignedAndUnsigned.TabIndex = 1
        Me.CheckBoxCreateSignedAndUnsigned.Text = "Create Signed and Unsigned"
        Me.CheckBoxCreateSignedAndUnsigned.UseVisualStyleBackColor = True
        '
        'CertificateComboBox
        '
        Me.CertificateComboBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CertificateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CertificateComboBox.FormattingEnabled = True
        Me.CertificateComboBox.Location = New System.Drawing.Point(282, 25)
        Me.CertificateComboBox.Name = "CertificateComboBox"
        Me.CertificateComboBox.Size = New System.Drawing.Size(191, 23)
        Me.CertificateComboBox.TabIndex = 3
        '
        'CertificateLabel
        '
        Me.CertificateLabel.AutoSize = True
        Me.CertificateLabel.Location = New System.Drawing.Point(212, 28)
        Me.CertificateLabel.Name = "CertificateLabel"
        Me.CertificateLabel.Size = New System.Drawing.Size(64, 15)
        Me.CertificateLabel.TabIndex = 2
        Me.CertificateLabel.Text = "Certificate:"
        '
        'CheckBoxSignRDPEnabled
        '
        Me.CheckBoxSignRDPEnabled.AutoSize = True
        Me.CheckBoxSignRDPEnabled.Location = New System.Drawing.Point(10, 22)
        Me.CheckBoxSignRDPEnabled.Name = "CheckBoxSignRDPEnabled"
        Me.CheckBoxSignRDPEnabled.Size = New System.Drawing.Size(93, 19)
        Me.CheckBoxSignRDPEnabled.TabIndex = 0
        Me.CheckBoxSignRDPEnabled.Text = "Sign RDP file"
        Me.CheckBoxSignRDPEnabled.UseVisualStyleBackColor = True
        '
        'RemoteAppCreateClientConnection
        '
        Me.AcceptButton = Me.CreateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CancelEditButton
        Me.ClientSize = New System.Drawing.Size(507, 596)
        Me.Controls.Add(Me.GroupBoxSignRDP)
        Me.Controls.Add(Me.FileTypesGroupBox)
        Me.Controls.Add(Me.MSIGroupBox)
        Me.Controls.Add(Me.ClientConnectionGroupBox)
        Me.Controls.Add(Me.RDGWGroupBox)
        Me.Controls.Add(Me.ServerGroupBox)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.CancelEditButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RemoteAppCreateClientConnection"
        Me.Text = "RemoteAppCreateClientConnection"
        Me.ServerGroupBox.ResumeLayout(False)
        Me.ServerGroupBox.PerformLayout()
        Me.RDGWGroupBox.ResumeLayout(False)
        Me.RDGWGroupBox.PerformLayout()
        Me.ClientConnectionGroupBox.ResumeLayout(False)
        Me.ClientConnectionGroupBox.PerformLayout()
        Me.MSIGroupBox.ResumeLayout(False)
        Me.MSIGroupBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FileTypesGroupBox.ResumeLayout(False)
        Me.FileTypesGroupBox.PerformLayout()
        Me.GroupBoxSignRDP.ResumeLayout(False)
        Me.GroupBoxSignRDP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EditAfterSave As System.Windows.Forms.CheckBox
    Friend WithEvents SmallerIcons As System.Windows.Forms.ImageList
    Friend WithEvents CreateButton As System.Windows.Forms.Button
    Friend WithEvents FileSaveRDP As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CancelEditButton As System.Windows.Forms.Button
    Friend WithEvents ServerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ServerPort As System.Windows.Forms.TextBox
    Friend WithEvents AltServerAddress As System.Windows.Forms.TextBox
    Friend WithEvents ServerAddress As System.Windows.Forms.TextBox
    Friend WithEvents RDGWGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents UseRDGatewayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RDGWLabel As System.Windows.Forms.Label
    Friend WithEvents GatewayAddress As System.Windows.Forms.TextBox
    Friend WithEvents ClientConnectionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MSIRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RDPRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FTAButton As System.Windows.Forms.Button
    Friend WithEvents FileBrowserIcon As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileSaveMSI As System.Windows.Forms.SaveFileDialog
    Friend WithEvents AttemptDirectCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ShortcutDesktopCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MSIGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ShortcutStartCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ShortcutTagCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ShortcutTagTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TopLevelRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SubfolderRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CreateRAWebIcon As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PerMachineRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PerUserRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FileTypesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DisabledFTACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FTACountLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBoxSignRDP As GroupBox
    Friend WithEvents CheckBoxSignRDPEnabled As CheckBox
    Friend WithEvents CertificateComboBox As ComboBox
    Friend WithEvents CertificateLabel As Label
    Friend WithEvents CheckBoxCreateSignedAndUnsigned As CheckBox
End Class
