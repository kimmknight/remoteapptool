<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RDPOptionsWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RDPOptionsWindow))
        Me.OptionsListBox = New System.Windows.Forms.ListBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ValueTextBox = New System.Windows.Forms.TextBox()
        Me.ChangedOptionsListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SmallerIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DefaultsButton = New System.Windows.Forms.Button()
        Me.ResetValueButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OptionsListBox
        '
        Me.OptionsListBox.FormattingEnabled = True
        Me.OptionsListBox.ItemHeight = 15
        Me.OptionsListBox.Location = New System.Drawing.Point(11, 12)
        Me.OptionsListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OptionsListBox.Name = "OptionsListBox"
        Me.OptionsListBox.Size = New System.Drawing.Size(213, 169)
        Me.OptionsListBox.TabIndex = 0
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescriptionTextBox.Location = New System.Drawing.Point(228, 12)
        Me.DescriptionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(347, 169)
        Me.DescriptionTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 188)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Set value:"
        '
        'ValueTextBox
        '
        Me.ValueTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValueTextBox.Location = New System.Drawing.Point(72, 185)
        Me.ValueTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ValueTextBox.Name = "ValueTextBox"
        Me.ValueTextBox.Size = New System.Drawing.Size(476, 23)
        Me.ValueTextBox.TabIndex = 3
        '
        'ChangedOptionsListView
        '
        Me.ChangedOptionsListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangedOptionsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ChangedOptionsListView.FullRowSelect = True
        Me.ChangedOptionsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ChangedOptionsListView.HideSelection = False
        Me.ChangedOptionsListView.Location = New System.Drawing.Point(11, 238)
        Me.ChangedOptionsListView.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangedOptionsListView.MultiSelect = False
        Me.ChangedOptionsListView.Name = "ChangedOptionsListView"
        Me.ChangedOptionsListView.Size = New System.Drawing.Size(564, 117)
        Me.ChangedOptionsListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ChangedOptionsListView.TabIndex = 6
        Me.ChangedOptionsListView.UseCompatibleStateImageBehavior = False
        Me.ChangedOptionsListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Option"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Value"
        Me.ColumnHeader3.Width = 282
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SaveButton.ImageList = Me.SmallerIcons
        Me.SaveButton.Location = New System.Drawing.Point(511, 366)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(64, 29)
        Me.SaveButton.TabIndex = 9
        Me.SaveButton.Text = "Close"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
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
        'ResetButton
        '
        Me.ResetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ResetButton.ImageIndex = 4
        Me.ResetButton.ImageList = Me.SmallerIcons
        Me.ResetButton.Location = New System.Drawing.Point(417, 366)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(90, 29)
        Me.ResetButton.TabIndex = 8
        Me.ResetButton.Text = "Clear all"
        Me.ResetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ResetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Selected options:"
        '
        'DefaultsButton
        '
        Me.DefaultsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DefaultsButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DefaultsButton.ImageIndex = 3
        Me.DefaultsButton.ImageList = Me.SmallerIcons
        Me.DefaultsButton.Location = New System.Drawing.Point(324, 366)
        Me.DefaultsButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DefaultsButton.Name = "DefaultsButton"
        Me.DefaultsButton.Size = New System.Drawing.Size(89, 29)
        Me.DefaultsButton.TabIndex = 7
        Me.DefaultsButton.Text = "Defaults"
        Me.DefaultsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DefaultsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DefaultsButton.UseVisualStyleBackColor = False
        '
        'ResetValueButton
        '
        Me.ResetValueButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetValueButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ResetValueButton.ImageIndex = 4
        Me.ResetValueButton.ImageList = Me.SmallerIcons
        Me.ResetValueButton.Location = New System.Drawing.Point(552, 184)
        Me.ResetValueButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetValueButton.Name = "ResetValueButton"
        Me.ResetValueButton.Size = New System.Drawing.Size(25, 25)
        Me.ResetValueButton.TabIndex = 4
        Me.ResetValueButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ResetValueButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ResetValueButton.UseVisualStyleBackColor = False
        '
        'RDPOptionsWindow
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(586, 406)
        Me.Controls.Add(Me.ResetValueButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DefaultsButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ChangedOptionsListView)
        Me.Controls.Add(Me.ValueTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.OptionsListBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RDPOptionsWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Additional RDP Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OptionsListBox As ListBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ValueTextBox As TextBox
    Friend WithEvents ChangedOptionsListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents SaveButton As Button
    Friend WithEvents SmallerIcons As ImageList
    Friend WithEvents ResetButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DefaultsButton As Button
    Friend WithEvents ResetValueButton As Button
End Class
