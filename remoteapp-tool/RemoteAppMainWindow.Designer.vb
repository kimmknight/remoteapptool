<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteAppMainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteAppMainWindow))
        Me.AppList = New System.Windows.Forms.ListView()
        Me.ShortName = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Path = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.VPath = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.RequiredCommandLine = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.CommandLineSetting = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.IconPath = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.IconIndex = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.SecurityDescriptor = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ShowInTSWA = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.SmallIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.SmallerIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.NoAppsLabel = New System.Windows.Forms.Label()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.CreateClientConnection = New System.Windows.Forms.Button()
        Me.ToolsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRemoteAppadvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveUnusedFileTypeAssociationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolsMenuStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AppList
        '
        Me.AppList.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.AppList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppList.BackColor = System.Drawing.Color.White
        Me.AppList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AppList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ShortName, Me.Title, Me.Path, Me.VPath, Me.RequiredCommandLine, Me.CommandLineSetting, Me.IconPath, Me.IconIndex, Me.SecurityDescriptor, Me.ShowInTSWA})
        Me.AppList.GridLines = True
        Me.AppList.HideSelection = False
        Me.AppList.LargeImageList = Me.SmallIcons
        Me.AppList.Location = New System.Drawing.Point(12, 28)
        Me.AppList.MultiSelect = False
        Me.AppList.Name = "AppList"
        Me.AppList.Size = New System.Drawing.Size(423, 189)
        Me.AppList.SmallImageList = Me.SmallIcons
        Me.AppList.TabIndex = 1
        Me.AppList.TileSize = New System.Drawing.Size(200, 36)
        Me.AppList.UseCompatibleStateImageBehavior = False
        Me.AppList.View = System.Windows.Forms.View.Tile
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
        'SmallerIcons
        '
        Me.SmallerIcons.ImageStream = CType(resources.GetObject("SmallerIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallerIcons.Images.SetKeyName(0, "tools_16x16.png")
        Me.SmallerIcons.Images.SetKeyName(1, "help_16x16.png")
        Me.SmallerIcons.Images.SetKeyName(2, "folder_16x16.png")
        Me.SmallerIcons.Images.SetKeyName(3, "msi small.ico")
        Me.SmallerIcons.Images.SetKeyName(4, "properties.ico")
        Me.SmallerIcons.Images.SetKeyName(5, "plus.ico")
        Me.SmallerIcons.Images.SetKeyName(6, "minus.ico")
        '
        'NoAppsLabel
        '
        Me.NoAppsLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoAppsLabel.ForeColor = System.Drawing.Color.DarkGray
        Me.NoAppsLabel.Location = New System.Drawing.Point(12, 91)
        Me.NoAppsLabel.Name = "NoAppsLabel"
        Me.NoAppsLabel.Size = New System.Drawing.Size(410, 58)
        Me.NoAppsLabel.TabIndex = 0
        Me.NoAppsLabel.Text = "There are no RemoteApps hosted on this computer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click + to add one."
        Me.NoAppsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NoAppsLabel.Visible = False
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
        Me.CreateButton.ImageIndex = 5
        Me.CreateButton.ImageList = Me.SmallerIcons
        Me.CreateButton.Location = New System.Drawing.Point(12, 227)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(22, 22)
        Me.CreateButton.TabIndex = 2
        Me.CreateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CreateButton.UseVisualStyleBackColor = False
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
        Me.DeleteButton.ImageIndex = 6
        Me.DeleteButton.ImageList = Me.SmallerIcons
        Me.DeleteButton.Location = New System.Drawing.Point(40, 227)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(22, 22)
        Me.DeleteButton.TabIndex = 3
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
        Me.EditButton.ImageIndex = 4
        Me.EditButton.ImageList = Me.SmallerIcons
        Me.EditButton.Location = New System.Drawing.Point(68, 227)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(22, 22)
        Me.EditButton.TabIndex = 4
        Me.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'CreateClientConnection
        '
        Me.CreateClientConnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateClientConnection.AutoSize = True
        Me.CreateClientConnection.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CreateClientConnection.Enabled = False
        Me.CreateClientConnection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CreateClientConnection.ImageIndex = 3
        Me.CreateClientConnection.ImageList = Me.SmallerIcons
        Me.CreateClientConnection.Location = New System.Drawing.Point(239, 224)
        Me.CreateClientConnection.Name = "CreateClientConnection"
        Me.CreateClientConnection.Size = New System.Drawing.Size(183, 29)
        Me.CreateClientConnection.TabIndex = 6
        Me.CreateClientConnection.Text = "Create Client Connection..."
        Me.CreateClientConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CreateClientConnection.UseVisualStyleBackColor = False
        '
        'ToolsMenuStrip
        '
        Me.ToolsMenuStrip.AllowMerge = False
        Me.ToolsMenuStrip.AutoSize = False
        Me.ToolsMenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.ToolsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ToolsMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolsMenuStrip.Name = "ToolsMenuStrip"
        Me.ToolsMenuStrip.ShowItemToolTips = True
        Me.ToolsMenuStrip.Size = New System.Drawing.Size(434, 24)
        Me.ToolsMenuStrip.TabIndex = 5
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRemoteAppadvancedToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewRemoteAppadvancedToolStripMenuItem
        '
        Me.NewRemoteAppadvancedToolStripMenuItem.Name = "NewRemoteAppadvancedToolStripMenuItem"
        Me.NewRemoteAppadvancedToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.NewRemoteAppadvancedToolStripMenuItem.Text = "New RemoteApp (advanced)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(232, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HostOptionsToolStripMenuItem, Me.ToolStripSeparator3, Me.RemoveUnusedFileTypeAssociationsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'HostOptionsToolStripMenuItem
        '
        Me.HostOptionsToolStripMenuItem.Name = "HostOptionsToolStripMenuItem"
        Me.HostOptionsToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.HostOptionsToolStripMenuItem.Text = "Host Options..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(277, 6)
        '
        'RemoveUnusedFileTypeAssociationsToolStripMenuItem
        '
        Me.RemoveUnusedFileTypeAssociationsToolStripMenuItem.Name = "RemoveUnusedFileTypeAssociationsToolStripMenuItem"
        Me.RemoveUnusedFileTypeAssociationsToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.RemoveUnusedFileTypeAssociationsToolStripMenuItem.Text = "Remove unused file type associations..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebsiteToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(113, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 191)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'RemoteAppMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 261)
        Me.Controls.Add(Me.NoAppsLabel)
        Me.Controls.Add(Me.CreateClientConnection)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.ToolsMenuStrip)
        Me.Controls.Add(Me.AppList)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ToolsMenuStrip
        Me.MinimumSize = New System.Drawing.Size(450, 300)
        Me.Name = "RemoteAppMainWindow"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "RemoteApp Tool"
        Me.ToolsMenuStrip.ResumeLayout(False)
        Me.ToolsMenuStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AppList As System.Windows.Forms.ListView
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
    Friend WithEvents SmallIcons As System.Windows.Forms.ImageList
    Friend WithEvents CreateButton As System.Windows.Forms.Button
    Friend WithEvents SmallerIcons As System.Windows.Forms.ImageList
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents NoAppsLabel As System.Windows.Forms.Label
    Friend WithEvents CreateClientConnection As System.Windows.Forms.Button
    Friend WithEvents ToolsMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HostOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RemoveUnusedFileTypeAssociationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRemoteAppadvancedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
