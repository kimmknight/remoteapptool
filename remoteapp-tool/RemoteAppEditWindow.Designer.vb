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
        Me.IconPathCopyButton = New System.Windows.Forms.Button()
        Me.VPathCopyButton = New System.Windows.Forms.Button()
        Me.TSWAbox = New System.Windows.Forms.ComboBox()
        Me.CommandLineOptionCombo = New System.Windows.Forms.ComboBox()
        Me.IconPathText = New System.Windows.Forms.TextBox()
        Me.CommandLineText = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VPathText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PathText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FullNameText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IconIndexText = New System.Windows.Forms.TextBox()
        Me.ShortNameText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CancelEditButton = New System.Windows.Forms.Button()
        Me.FileBrowserPath = New System.Windows.Forms.OpenFileDialog()
        Me.FileBrowserIcon = New System.Windows.Forms.OpenFileDialog()
        Me.FileBrowserVPath = New System.Windows.Forms.OpenFileDialog()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BrowseIconPath = New System.Windows.Forms.Button()
        Me.BrowseVPath = New System.Windows.Forms.Button()
        Me.BrowsePath = New System.Windows.Forms.Button()
        Me.FTAButton = New System.Windows.Forms.Button()
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
        'IconPathCopyButton
        '
        Me.IconPathCopyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPathCopyButton.AutoSize = True
        Me.IconPathCopyButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.IconPathCopyButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IconPathCopyButton.ImageIndex = 6
        Me.IconPathCopyButton.ImageList = Me.SmallerIcons
        Me.IconPathCopyButton.Location = New System.Drawing.Point(382, 97)
        Me.IconPathCopyButton.Name = "IconPathCopyButton"
        Me.IconPathCopyButton.Size = New System.Drawing.Size(61, 27)
        Me.IconPathCopyButton.TabIndex = 15
        Me.IconPathCopyButton.Text = "Copy"
        Me.IconPathCopyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconPathCopyButton.UseVisualStyleBackColor = False
        '
        'VPathCopyButton
        '
        Me.VPathCopyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VPathCopyButton.AutoSize = True
        Me.VPathCopyButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VPathCopyButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VPathCopyButton.ImageIndex = 6
        Me.VPathCopyButton.ImageList = Me.SmallerIcons
        Me.VPathCopyButton.Location = New System.Drawing.Point(382, 67)
        Me.VPathCopyButton.Name = "VPathCopyButton"
        Me.VPathCopyButton.Size = New System.Drawing.Size(61, 27)
        Me.VPathCopyButton.TabIndex = 9
        Me.VPathCopyButton.Text = "Copy"
        Me.VPathCopyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.VPathCopyButton.UseVisualStyleBackColor = False
        '
        'TSWAbox
        '
        Me.TSWAbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TSWAbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TSWAbox.FormattingEnabled = True
        Me.TSWAbox.Items.AddRange(New Object() {"No", "Yes"})
        Me.TSWAbox.Location = New System.Drawing.Point(321, 157)
        Me.TSWAbox.Name = "TSWAbox"
        Me.TSWAbox.Size = New System.Drawing.Size(81, 23)
        Me.TSWAbox.TabIndex = 22
        '
        'CommandLineOptionCombo
        '
        Me.CommandLineOptionCombo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CommandLineOptionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CommandLineOptionCombo.FormattingEnabled = True
        Me.CommandLineOptionCombo.Items.AddRange(New Object() {"Disabled", "Optional", "Enforced"})
        Me.CommandLineOptionCombo.Location = New System.Drawing.Point(145, 157)
        Me.CommandLineOptionCombo.Name = "CommandLineOptionCombo"
        Me.CommandLineOptionCombo.Size = New System.Drawing.Size(81, 23)
        Me.CommandLineOptionCombo.TabIndex = 20
        '
        'IconPathText
        '
        Me.IconPathText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPathText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IconPathText.Location = New System.Drawing.Point(78, 99)
        Me.IconPathText.Name = "IconPathText"
        Me.IconPathText.Size = New System.Drawing.Size(159, 23)
        Me.IconPathText.TabIndex = 12
        '
        'CommandLineText
        '
        Me.CommandLineText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommandLineText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CommandLineText.Location = New System.Drawing.Point(112, 128)
        Me.CommandLineText.Name = "CommandLineText"
        Me.CommandLineText.Size = New System.Drawing.Size(364, 23)
        Me.CommandLineText.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(243, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 15)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Icon Index:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(232, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "TSWebAccess:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Command line option:"
        '
        'VPathText
        '
        Me.VPathText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VPathText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VPathText.Location = New System.Drawing.Point(60, 70)
        Me.VPathText.Name = "VPathText"
        Me.VPathText.Size = New System.Drawing.Size(315, 23)
        Me.VPathText.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Icon path:"
        '
        'PathText
        '
        Me.PathText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PathText.Location = New System.Drawing.Point(60, 41)
        Me.PathText.Name = "PathText"
        Me.PathText.Size = New System.Drawing.Size(383, 23)
        Me.PathText.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Command line:"
        '
        'FullNameText
        '
        Me.FullNameText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullNameText.Location = New System.Drawing.Point(304, 12)
        Me.FullNameText.Name = "FullNameText"
        Me.FullNameText.Size = New System.Drawing.Size(172, 23)
        Me.FullNameText.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "VPath:"
        '
        'IconIndexText
        '
        Me.IconIndexText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconIndexText.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IconIndexText.Location = New System.Drawing.Point(315, 99)
        Me.IconIndexText.Name = "IconIndexText"
        Me.IconIndexText.Size = New System.Drawing.Size(60, 23)
        Me.IconIndexText.TabIndex = 14
        Me.IconIndexText.Text = "0"
        '
        'ShortNameText
        '
        Me.ShortNameText.Location = New System.Drawing.Point(60, 12)
        Me.ShortNameText.Name = "ShortNameText"
        Me.ShortNameText.Size = New System.Drawing.Size(170, 23)
        Me.ShortNameText.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Path:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Full name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Name:"
        '
        'CancelEditButton
        '
        Me.CancelEditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelEditButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelEditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelEditButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CancelEditButton.ImageIndex = 8
        Me.CancelEditButton.ImageList = Me.SmallerIcons
        Me.CancelEditButton.Location = New System.Drawing.Point(327, 189)
        Me.CancelEditButton.Name = "CancelEditButton"
        Me.CancelEditButton.Size = New System.Drawing.Size(75, 29)
        Me.CancelEditButton.TabIndex = 24
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
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveButton.ImageIndex = 0
        Me.SaveButton.ImageList = Me.SmallerIcons
        Me.SaveButton.Location = New System.Drawing.Point(407, 189)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(67, 29)
        Me.SaveButton.TabIndex = 25
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'BrowseIconPath
        '
        Me.BrowseIconPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseIconPath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BrowseIconPath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BrowseIconPath.ImageIndex = 4
        Me.BrowseIconPath.ImageList = Me.SmallerIcons
        Me.BrowseIconPath.Location = New System.Drawing.Point(449, 97)
        Me.BrowseIconPath.Name = "BrowseIconPath"
        Me.BrowseIconPath.Size = New System.Drawing.Size(27, 27)
        Me.BrowseIconPath.TabIndex = 16
        Me.BrowseIconPath.UseVisualStyleBackColor = False
        '
        'BrowseVPath
        '
        Me.BrowseVPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseVPath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BrowseVPath.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BrowseVPath.ImageIndex = 1
        Me.BrowseVPath.ImageList = Me.SmallerIcons
        Me.BrowseVPath.Location = New System.Drawing.Point(449, 67)
        Me.BrowseVPath.Name = "BrowseVPath"
        Me.BrowseVPath.Size = New System.Drawing.Size(27, 27)
        Me.BrowseVPath.TabIndex = 10
        Me.BrowseVPath.UseVisualStyleBackColor = False
        '
        'BrowsePath
        '
        Me.BrowsePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowsePath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BrowsePath.ImageIndex = 1
        Me.BrowsePath.ImageList = Me.SmallerIcons
        Me.BrowsePath.Location = New System.Drawing.Point(449, 38)
        Me.BrowsePath.Name = "BrowsePath"
        Me.BrowsePath.Size = New System.Drawing.Size(27, 27)
        Me.BrowsePath.TabIndex = 6
        Me.BrowsePath.UseVisualStyleBackColor = False
        '
        'FTAButton
        '
        Me.FTAButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FTAButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FTAButton.ImageIndex = 7
        Me.FTAButton.ImageList = Me.SmallerIcons
        Me.FTAButton.Location = New System.Drawing.Point(12, 189)
        Me.FTAButton.Name = "FTAButton"
        Me.FTAButton.Size = New System.Drawing.Size(172, 29)
        Me.FTAButton.TabIndex = 23
        Me.FTAButton.Text = "File type associations..."
        Me.FTAButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FTAButton.UseVisualStyleBackColor = False
        '
        'RemoteAppEditWindow
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CancelEditButton
        Me.ClientSize = New System.Drawing.Size(488, 230)
        Me.Controls.Add(Me.FTAButton)
        Me.Controls.Add(Me.CancelEditButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.BrowseIconPath)
        Me.Controls.Add(Me.IconPathCopyButton)
        Me.Controls.Add(Me.VPathCopyButton)
        Me.Controls.Add(Me.TSWAbox)
        Me.Controls.Add(Me.CommandLineOptionCombo)
        Me.Controls.Add(Me.IconPathText)
        Me.Controls.Add(Me.CommandLineText)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.VPathText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PathText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FullNameText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IconIndexText)
        Me.Controls.Add(Me.ShortNameText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BrowseVPath)
        Me.Controls.Add(Me.BrowsePath)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(9000, 269)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(504, 269)
        Me.Name = "RemoteAppEditWindow"
        Me.Text = "RemoteAppEditWindow"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents BrowseIconPath As System.Windows.Forms.Button
    Friend WithEvents IconPathCopyButton As System.Windows.Forms.Button
    Friend WithEvents VPathCopyButton As System.Windows.Forms.Button
    Friend WithEvents TSWAbox As System.Windows.Forms.ComboBox
    Friend WithEvents CommandLineOptionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents IconPathText As System.Windows.Forms.TextBox
    Friend WithEvents CommandLineText As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VPathText As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PathText As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FullNameText As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IconIndexText As System.Windows.Forms.TextBox
    Friend WithEvents ShortNameText As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BrowseVPath As System.Windows.Forms.Button
    Friend WithEvents BrowsePath As System.Windows.Forms.Button
    Friend WithEvents SmallerIcons As System.Windows.Forms.ImageList
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CancelEditButton As System.Windows.Forms.Button
    Friend WithEvents FileBrowserPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileBrowserIcon As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FileBrowserVPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FTAButton As System.Windows.Forms.Button
End Class
