<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteAppIconPicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteAppIconPicker))
        Me.IconList = New System.Windows.Forms.ListView()
        Me.ShortName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RequiredCommandLine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CommandLineSetting = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IconPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IconIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SecurityDescriptor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ShowInTSWA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SmallIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.SmallerIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.IconPathTextBox = New System.Windows.Forms.TextBox()
        Me.IconIndexTextBox = New System.Windows.Forms.TextBox()
        Me.FileBrowserIcon = New System.Windows.Forms.OpenFileDialog()
        Me.CancelEditButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.FileTypeLabel = New System.Windows.Forms.Label()
        Me.FileTypeTextBox = New System.Windows.Forms.TextBox()
        Me.IconIndexLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IconList
        '
        Me.IconList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ShortName, Me.Title, Me.Path, Me.VPath, Me.RequiredCommandLine, Me.CommandLineSetting, Me.IconPath, Me.IconIndex, Me.SecurityDescriptor, Me.ShowInTSWA})
        Me.IconList.GridLines = True
        Me.IconList.HideSelection = False
        Me.IconList.LargeImageList = Me.SmallIcons
        Me.IconList.Location = New System.Drawing.Point(16, 41)
        Me.IconList.MultiSelect = False
        Me.IconList.Name = "IconList"
        Me.IconList.Size = New System.Drawing.Size(471, 143)
        Me.IconList.SmallImageList = Me.SmallIcons
        Me.IconList.TabIndex = 4
        Me.IconList.UseCompatibleStateImageBehavior = False
        '
        'ShortName
        '
        Me.ShortName.Text = "ShortName"
        Me.ShortName.Width = 200
        '
        'Title
        '
        Me.Title.Text = "Name"
        '
        'Path
        '
        Me.Path.Text = "Path"
        '
        'VPath
        '
        Me.VPath.Text = "VPath"
        '
        'RequiredCommandLine
        '
        Me.RequiredCommandLine.Text = "RequiredCommandLine"
        '
        'CommandLineSetting
        '
        Me.CommandLineSetting.Text = "CommandLineSetting"
        '
        'IconPath
        '
        Me.IconPath.Text = "IconPath"
        '
        'IconIndex
        '
        Me.IconIndex.Text = "IconIndex"
        '
        'SecurityDescriptor
        '
        Me.SecurityDescriptor.Text = "SecurityDescriptor"
        '
        'ShowInTSWA
        '
        Me.ShowInTSWA.Text = "ShowInTSWA"
        '
        'SmallIcons
        '
        Me.SmallIcons.ImageStream = CType(resources.GetObject("SmallIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallIcons.Images.SetKeyName(0, "smallicons.ico")
        '
        'BrowseButton
        '
        Me.BrowseButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BrowseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BrowseButton.ImageIndex = 0
        Me.BrowseButton.ImageList = Me.SmallerIcons
        Me.BrowseButton.Location = New System.Drawing.Point(14, 8)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(82, 29)
        Me.BrowseButton.TabIndex = 0
        Me.BrowseButton.Text = "Browse..."
        Me.BrowseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BrowseButton.UseVisualStyleBackColor = False
        '
        'SmallerIcons
        '
        Me.SmallerIcons.ImageStream = CType(resources.GetObject("SmallerIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallerIcons.Images.SetKeyName(0, "folder_16x16.png")
        Me.SmallerIcons.Images.SetKeyName(1, "tick.ico")
        Me.SmallerIcons.Images.SetKeyName(2, "cross.ico")
        Me.SmallerIcons.Images.SetKeyName(3, "settings-16.ico")
        '
        'IconPathTextBox
        '
        Me.IconPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPathTextBox.Location = New System.Drawing.Point(103, 12)
        Me.IconPathTextBox.Name = "IconPathTextBox"
        Me.IconPathTextBox.ReadOnly = True
        Me.IconPathTextBox.Size = New System.Drawing.Size(267, 23)
        Me.IconPathTextBox.TabIndex = 1
        '
        'IconIndexTextBox
        '
        Me.IconIndexTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconIndexTextBox.Location = New System.Drawing.Point(420, 12)
        Me.IconIndexTextBox.Name = "IconIndexTextBox"
        Me.IconIndexTextBox.ReadOnly = True
        Me.IconIndexTextBox.Size = New System.Drawing.Size(67, 23)
        Me.IconIndexTextBox.TabIndex = 3
        Me.IconIndexTextBox.Visible = False
        '
        'FileBrowserIcon
        '
        Me.FileBrowserIcon.Filter = "Icons|*.exe;*.dll;*.ico|All files|*.*"
        Me.FileBrowserIcon.Title = "Browse..."
        '
        'CancelEditButton
        '
        Me.CancelEditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelEditButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelEditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelEditButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CancelEditButton.ImageIndex = 2
        Me.CancelEditButton.ImageList = Me.SmallerIcons
        Me.CancelEditButton.Location = New System.Drawing.Point(339, 190)
        Me.CancelEditButton.Name = "CancelEditButton"
        Me.CancelEditButton.Size = New System.Drawing.Size(75, 29)
        Me.CancelEditButton.TabIndex = 7
        Me.CancelEditButton.Text = "Cancel"
        Me.CancelEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelEditButton.UseVisualStyleBackColor = False
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.OKButton.ImageIndex = 1
        Me.OKButton.ImageList = Me.SmallerIcons
        Me.OKButton.Location = New System.Drawing.Point(420, 190)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(67, 29)
        Me.OKButton.TabIndex = 8
        Me.OKButton.Text = "OK"
        Me.OKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'FileTypeLabel
        '
        Me.FileTypeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FileTypeLabel.AutoSize = True
        Me.FileTypeLabel.Location = New System.Drawing.Point(12, 197)
        Me.FileTypeLabel.Name = "FileTypeLabel"
        Me.FileTypeLabel.Size = New System.Drawing.Size(66, 15)
        Me.FileTypeLabel.TabIndex = 5
        Me.FileTypeLabel.Text = "File type:   ."
        Me.FileTypeLabel.Visible = False
        '
        'FileTypeTextBox
        '
        Me.FileTypeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FileTypeTextBox.Location = New System.Drawing.Point(76, 194)
        Me.FileTypeTextBox.Name = "FileTypeTextBox"
        Me.FileTypeTextBox.Size = New System.Drawing.Size(80, 23)
        Me.FileTypeTextBox.TabIndex = 6
        Me.FileTypeTextBox.Text = "xyz"
        Me.FileTypeTextBox.Visible = False
        '
        'IconIndexLabel
        '
        Me.IconIndexLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconIndexLabel.AutoSize = True
        Me.IconIndexLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.IconIndexLabel.Location = New System.Drawing.Point(376, 15)
        Me.IconIndexLabel.Name = "IconIndexLabel"
        Me.IconIndexLabel.Size = New System.Drawing.Size(39, 15)
        Me.IconIndexLabel.TabIndex = 2
        Me.IconIndexLabel.Text = "Index:"
        Me.IconIndexLabel.Visible = False
        '
        'RemoteAppIconPicker
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CancelEditButton
        Me.ClientSize = New System.Drawing.Size(499, 231)
        Me.Controls.Add(Me.IconIndexLabel)
        Me.Controls.Add(Me.CancelEditButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.IconIndexTextBox)
        Me.Controls.Add(Me.IconPathTextBox)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.IconList)
        Me.Controls.Add(Me.FileTypeTextBox)
        Me.Controls.Add(Me.FileTypeLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(515, 270)
        Me.Name = "RemoteAppIconPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RemoteAppIconPicker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconList As System.Windows.Forms.ListView
    Friend WithEvents ShortName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Title As System.Windows.Forms.ColumnHeader
    Friend WithEvents Path As System.Windows.Forms.ColumnHeader
    Friend WithEvents VPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents RequiredCommandLine As System.Windows.Forms.ColumnHeader
    Friend WithEvents CommandLineSetting As System.Windows.Forms.ColumnHeader
    Friend WithEvents IconPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents IconIndex As System.Windows.Forms.ColumnHeader
    Friend WithEvents SecurityDescriptor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ShowInTSWA As System.Windows.Forms.ColumnHeader
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents IconPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IconIndexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FileBrowserIcon As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CancelEditButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents FileTypeLabel As System.Windows.Forms.Label
    Friend WithEvents FileTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SmallerIcons As System.Windows.Forms.ImageList
    Friend WithEvents IconIndexLabel As System.Windows.Forms.Label
    Friend WithEvents SmallIcons As System.Windows.Forms.ImageList
End Class
