<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteAppFileTypeAssociation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteAppFileTypeAssociation))
        Me.FTAListView = New System.Windows.Forms.ListView()
        Me.FileExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IconPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IconIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Associated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.SmallerIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SetAssociationButton = New System.Windows.Forms.Button()
        Me.SmallerIcons2 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'FTAListView
        '
        Me.FTAListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FTAListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FTAListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileExtension, Me.IconPath, Me.IconIndex, Me.Associated})
        Me.FTAListView.FullRowSelect = True
        Me.FTAListView.GridLines = True
        Me.FTAListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.FTAListView.HideSelection = False
        Me.FTAListView.Location = New System.Drawing.Point(-1, -1)
        Me.FTAListView.MultiSelect = False
        Me.FTAListView.Name = "FTAListView"
        Me.FTAListView.Size = New System.Drawing.Size(496, 164)
        Me.FTAListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.FTAListView.TabIndex = 0
        Me.FTAListView.UseCompatibleStateImageBehavior = False
        Me.FTAListView.View = System.Windows.Forms.View.Details
        '
        'FileExtension
        '
        Me.FileExtension.Text = "Extension"
        Me.FileExtension.Width = 64
        '
        'IconPath
        '
        Me.IconPath.Text = "Icon Path"
        Me.IconPath.Width = 305
        '
        'IconIndex
        '
        Me.IconIndex.Text = "Index"
        Me.IconIndex.Width = 51
        '
        'Associated
        '
        Me.Associated.Text = "Association"
        Me.Associated.Width = 76
        '
        'CreateButton
        '
        Me.CreateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CreateButton.AutoSize = True
        Me.CreateButton.BackColor = System.Drawing.Color.Transparent
        Me.CreateButton.FlatAppearance.BorderSize = 0
        Me.CreateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CreateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.ImageIndex = 1
        Me.CreateButton.ImageList = Me.SmallerIcons
        Me.CreateButton.Location = New System.Drawing.Point(12, 169)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(29, 29)
        Me.CreateButton.TabIndex = 1
        Me.CreateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'SmallerIcons
        '
        Me.SmallerIcons.ImageStream = CType(resources.GetObject("SmallerIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallerIcons.Images.SetKeyName(0, "properties.ico")
        Me.SmallerIcons.Images.SetKeyName(1, "plus.ico")
        Me.SmallerIcons.Images.SetKeyName(2, "minus.ico")
        Me.SmallerIcons.Images.SetKeyName(3, "tick.ico")
        Me.SmallerIcons.Images.SetKeyName(4, "flag2-add.ico")
        Me.SmallerIcons.Images.SetKeyName(5, "settings-16.ico")
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.AutoSize = True
        Me.DeleteButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ImageIndex = 2
        Me.DeleteButton.ImageList = Me.SmallerIcons
        Me.DeleteButton.Location = New System.Drawing.Point(48, 169)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(29, 29)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EditButton.AutoSize = True
        Me.EditButton.BackColor = System.Drawing.Color.Transparent
        Me.EditButton.Enabled = False
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EditButton.ImageIndex = 0
        Me.EditButton.ImageList = Me.SmallerIcons
        Me.EditButton.Location = New System.Drawing.Point(84, 169)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(29, 29)
        Me.EditButton.TabIndex = 3
        Me.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CloseButton.ImageIndex = 3
        Me.CloseButton.ImageList = Me.SmallerIcons
        Me.CloseButton.Location = New System.Drawing.Point(415, 169)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(67, 29)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.Text = "OK"
        Me.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'SetAssociationButton
        '
        Me.SetAssociationButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SetAssociationButton.AutoSize = True
        Me.SetAssociationButton.BackColor = System.Drawing.Color.Transparent
        Me.SetAssociationButton.Enabled = False
        Me.SetAssociationButton.FlatAppearance.BorderSize = 0
        Me.SetAssociationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SetAssociationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SetAssociationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetAssociationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetAssociationButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SetAssociationButton.ImageIndex = 4
        Me.SetAssociationButton.ImageList = Me.SmallerIcons
        Me.SetAssociationButton.Location = New System.Drawing.Point(119, 169)
        Me.SetAssociationButton.Name = "SetAssociationButton"
        Me.SetAssociationButton.Size = New System.Drawing.Size(29, 29)
        Me.SetAssociationButton.TabIndex = 4
        Me.SetAssociationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SetAssociationButton.UseVisualStyleBackColor = False
        '
        'SmallerIcons2
        '
        Me.SmallerIcons2.ImageStream = CType(resources.GetObject("SmallerIcons2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallerIcons2.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallerIcons2.Images.SetKeyName(0, "cross.ico")
        '
        'RemoteAppFileTypeAssociation
        '
        Me.AcceptButton = Me.CloseButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(494, 208)
        Me.Controls.Add(Me.SetAssociationButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.FTAListView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(510, 247)
        Me.Name = "RemoteAppFileTypeAssociation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "File Type Associations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FTAListView As System.Windows.Forms.ListView
    Friend WithEvents FileExtension As System.Windows.Forms.ColumnHeader
    Friend WithEvents IconPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents IconIndex As System.Windows.Forms.ColumnHeader
    Friend WithEvents CreateButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Associated As System.Windows.Forms.ColumnHeader
    Friend WithEvents SetAssociationButton As System.Windows.Forms.Button
    Friend WithEvents SmallerIcons As System.Windows.Forms.ImageList
    Friend WithEvents SmallerIcons2 As System.Windows.Forms.ImageList
End Class
