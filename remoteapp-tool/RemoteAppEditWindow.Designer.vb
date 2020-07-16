<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteAppEditWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteAppEditWindow))
        Me.SmallerIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.TSWAbox = New System.Windows.Forms.ComboBox()
        Me.CommandLineOptionCombo = New System.Windows.Forms.ComboBox()
        Me.CommandLineText = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CancelEditButton = New System.Windows.Forms.Button()
        Me.FileBrowserPath = New System.Windows.Forms.OpenFileDialog()
        Me.FileBrowserIcon = New System.Windows.Forms.OpenFileDialog()
        Me.FileBrowserVPath = New System.Windows.Forms.OpenFileDialog()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.FTAButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FullNameText = New System.Windows.Forms.TextBox()
        Me.ShortNameText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BrowseIconPath = New System.Windows.Forms.Button()
        Me.IconResetButton = New System.Windows.Forms.Button()
        Me.IconPathText = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PathText = New System.Windows.Forms.TextBox()
        Me.IconIndexText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BrowsePath = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SmallerIcons
        '
        Me.SmallerIcons.ImageStream = CType(resources.GetObject("SmallerIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallerIcons.Images.SetKeyName(0, "favorites_16x16.png")
        Me.SmallerIcons.Images.SetKeyName(1, "folder_16x16.png")
        Me.SmallerIcons.Images.SetKeyName(2, "dotdotdot.ico")
        Me.SmallerIcons.Images.SetKeyName(3, "inside_icons_azure_marker_map_socialize_base.ico")
        Me.SmallerIcons.Images.SetKeyName(4, "pictures (1).ico")
        Me.SmallerIcons.Images.SetKeyName(5, "pictures.ico")
        Me.SmallerIcons.Images.SetKeyName(6, "arrows_line_connector_with_draw.png")
        Me.SmallerIcons.Images.SetKeyName(7, "doc_file_document_manager_paper_phone.ico")
        Me.SmallerIcons.Images.SetKeyName(8, "cross.ico")
        '
        'TSWAbox
        '
        Me.TSWAbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TSWAbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TSWAbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TSWAbox.FormattingEnabled = True
        Me.TSWAbox.Items.AddRange(New Object() {"No", "Yes"})
        Me.TSWAbox.Location = New System.Drawing.Point(318, 22)
        Me.TSWAbox.Name = "TSWAbox"
        Me.TSWAbox.Size = New System.Drawing.Size(81, 23)
        Me.TSWAbox.TabIndex = 3
        '
        'CommandLineOptionCombo
        '
        Me.CommandLineOptionCombo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CommandLineOptionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CommandLineOptionCombo.FormattingEnabled = True
        Me.CommandLineOptionCombo.Items.AddRange(New Object() {"Disabled", "Optional", "Enforced"})
        Me.CommandLineOptionCombo.Location = New System.Drawing.Point(139, 22)
        Me.CommandLineOptionCombo.Name = "CommandLineOptionCombo"
        Me.CommandLineOptionCombo.Size = New System.Drawing.Size(81, 23)
        Me.CommandLineOptionCombo.TabIndex = 1
        '
        'CommandLineText
        '
        Me.CommandLineText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommandLineText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CommandLineText.Location = New System.Drawing.Point(163, 53)
        Me.CommandLineText.Name = "CommandLineText"
        Me.CommandLineText.Size = New System.Drawing.Size(236, 23)
        Me.CommandLineText.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(229, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "TSWebAccess:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Command line option:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Command line parameters:"
        '
        'CancelEditButton
        '
        Me.CancelEditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelEditButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelEditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelEditButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CancelEditButton.ImageIndex = 8
        Me.CancelEditButton.ImageList = Me.SmallerIcons
        Me.CancelEditButton.Location = New System.Drawing.Point(269, 356)
        Me.CancelEditButton.Name = "CancelEditButton"
        Me.CancelEditButton.Size = New System.Drawing.Size(75, 29)
        Me.CancelEditButton.TabIndex = 3
        Me.CancelEditButton.Text = "Cancel"
        Me.CancelEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelEditButton.UseVisualStyleBackColor = False
        '
        'FileBrowserPath
        '
        Me.FileBrowserPath.Filter = "Programs|*.exe;*.com;*.cmd;*.bat|All files|*.*"
        Me.FileBrowserPath.Title = "Browse..."
        '
        'FileBrowserIcon
        '
        Me.FileBrowserIcon.Filter = "Icons|*.exe;*.dll;*.ico|All files|*.*"
        Me.FileBrowserIcon.Title = "Browse..."
        '
        'FileBrowserVPath
        '
        Me.FileBrowserVPath.Filter = "Programs|*.exe;*.com;*.cmd;*.bat|All files|*.*"
        Me.FileBrowserVPath.Title = "Browse..."
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveButton.ImageIndex = 0
        Me.SaveButton.ImageList = Me.SmallerIcons
        Me.SaveButton.Location = New System.Drawing.Point(350, 356)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(67, 29)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'FTAButton
        '
        Me.FTAButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FTAButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FTAButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FTAButton.ImageIndex = 7
        Me.FTAButton.ImageList = Me.SmallerIcons
        Me.FTAButton.Location = New System.Drawing.Point(163, 82)
        Me.FTAButton.Name = "FTAButton"
        Me.FTAButton.Size = New System.Drawing.Size(236, 29)
        Me.FTAButton.TabIndex = 7
        Me.FTAButton.Text = "Configure..."
        Me.FTAButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FTAButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.FullNameText)
        Me.GroupBox1.Controls.Add(Me.ShortNameText)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Title"
        '
        'FullNameText
        '
        Me.FullNameText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullNameText.Location = New System.Drawing.Point(72, 51)
        Me.FullNameText.Name = "FullNameText"
        Me.FullNameText.Size = New System.Drawing.Size(327, 23)
        Me.FullNameText.TabIndex = 3
        '
        'ShortNameText
        '
        Me.ShortNameText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShortNameText.Location = New System.Drawing.Point(72, 22)
        Me.ShortNameText.Name = "ShortNameText"
        Me.ShortNameText.Size = New System.Drawing.Size(327, 23)
        Me.ShortNameText.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Full name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.BrowseIconPath)
        Me.GroupBox2.Controls.Add(Me.IconResetButton)
        Me.GroupBox2.Controls.Add(Me.IconPathText)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.PathText)
        Me.GroupBox2.Controls.Add(Me.IconIndexText)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.BrowsePath)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 116)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Files"
        '
        'BrowseIconPath
        '
        Me.BrowseIconPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseIconPath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BrowseIconPath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BrowseIconPath.ImageIndex = 4
        Me.BrowseIconPath.ImageList = Me.SmallerIcons
        Me.BrowseIconPath.Location = New System.Drawing.Point(372, 49)
        Me.BrowseIconPath.Name = "BrowseIconPath"
        Me.BrowseIconPath.Size = New System.Drawing.Size(27, 27)
        Me.BrowseIconPath.TabIndex = 5
        Me.BrowseIconPath.UseVisualStyleBackColor = False
        '
        'IconResetButton
        '
        Me.IconResetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconResetButton.AutoSize = True
        Me.IconResetButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.IconResetButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IconResetButton.ImageIndex = 6
        Me.IconResetButton.ImageList = Me.SmallerIcons
        Me.IconResetButton.Location = New System.Drawing.Point(312, 80)
        Me.IconResetButton.Name = "IconResetButton"
        Me.IconResetButton.Size = New System.Drawing.Size(87, 29)
        Me.IconResetButton.TabIndex = 8
        Me.IconResetButton.Text = "Reset icon"
        Me.IconResetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconResetButton.UseVisualStyleBackColor = False
        '
        'IconPathText
        '
        Me.IconPathText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPathText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IconPathText.Location = New System.Drawing.Point(72, 51)
        Me.IconPathText.Name = "IconPathText"
        Me.IconPathText.Size = New System.Drawing.Size(294, 23)
        Me.IconPathText.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(6, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Icon Index:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(6, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Icon path:"
        '
        'PathText
        '
        Me.PathText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PathText.Location = New System.Drawing.Point(72, 22)
        Me.PathText.Name = "PathText"
        Me.PathText.Size = New System.Drawing.Size(294, 23)
        Me.PathText.TabIndex = 1
        '
        'IconIndexText
        '
        Me.IconIndexText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IconIndexText.Location = New System.Drawing.Point(72, 80)
        Me.IconIndexText.Name = "IconIndexText"
        Me.IconIndexText.Size = New System.Drawing.Size(60, 23)
        Me.IconIndexText.TabIndex = 7
        Me.IconIndexText.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "App path:"
        '
        'BrowsePath
        '
        Me.BrowsePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowsePath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BrowsePath.ImageIndex = 1
        Me.BrowsePath.ImageList = Me.SmallerIcons
        Me.BrowsePath.Location = New System.Drawing.Point(372, 20)
        Me.BrowsePath.Name = "BrowsePath"
        Me.BrowsePath.Size = New System.Drawing.Size(27, 27)
        Me.BrowsePath.TabIndex = 2
        Me.BrowsePath.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.FTAButton)
        Me.GroupBox3.Controls.Add(Me.CommandLineText)
        Me.GroupBox3.Controls.Add(Me.CommandLineOptionCombo)
        Me.GroupBox3.Controls.Add(Me.TSWAbox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(405, 119)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "File type associations:"
        '
        'RemoteAppEditWindow
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CancelEditButton
        Me.ClientSize = New System.Drawing.Size(429, 391)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelEditButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1500, 430)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(445, 430)
        Me.Name = "RemoteAppEditWindow"
        Me.Text = "RemoteAppEditWindow"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TSWAbox As System.Windows.Forms.ComboBox
    Friend WithEvents CommandLineOptionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CommandLineText As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SmallerIcons As System.Windows.Forms.ImageList
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CancelEditButton As System.Windows.Forms.Button
    Friend WithEvents FileBrowserPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileBrowserIcon As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileBrowserVPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FTAButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FullNameText As TextBox
    Friend WithEvents ShortNameText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BrowseIconPath As Button
    Friend WithEvents IconResetButton As Button
    Friend WithEvents IconPathText As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PathText As TextBox
    Friend WithEvents IconIndexText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BrowsePath As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
End Class
