<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteAppHostOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteAppHostOptions))
        Me.TimeoutDisconnectedCheckBox = New System.Windows.Forms.CheckBox()
        Me.DisableAllowListCheckBox = New System.Windows.Forms.CheckBox()
        Me.DisconnectTimeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeoutIdleCheckBox = New System.Windows.Forms.CheckBox()
        Me.IdleTimeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogoffWhenTimoutCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SmallerIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CancelEditButton = New System.Windows.Forms.Button()
        Me.AllowUnlistedRemoteProgramsCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TimeoutDisconnectedCheckBox
        '
        Me.TimeoutDisconnectedCheckBox.AutoSize = True
        Me.TimeoutDisconnectedCheckBox.Location = New System.Drawing.Point(14, 64)
        Me.TimeoutDisconnectedCheckBox.Name = "TimeoutDisconnectedCheckBox"
        Me.TimeoutDisconnectedCheckBox.Size = New System.Drawing.Size(212, 19)
        Me.TimeoutDisconnectedCheckBox.TabIndex = 2
        Me.TimeoutDisconnectedCheckBox.Text = "Timeout for disconnected sessions:"
        Me.TimeoutDisconnectedCheckBox.UseVisualStyleBackColor = True
        '
        'DisableAllowListCheckBox
        '
        Me.DisableAllowListCheckBox.AutoSize = True
        Me.DisableAllowListCheckBox.Location = New System.Drawing.Point(14, 14)
        Me.DisableAllowListCheckBox.Name = "DisableAllowListCheckBox"
        Me.DisableAllowListCheckBox.Size = New System.Drawing.Size(137, 19)
        Me.DisableAllowListCheckBox.TabIndex = 0
        Me.DisableAllowListCheckBox.Text = "Disable AppAllowList"
        Me.DisableAllowListCheckBox.UseVisualStyleBackColor = True
        '
        'DisconnectTimeTextBox
        '
        Me.DisconnectTimeTextBox.Location = New System.Drawing.Point(245, 62)
        Me.DisconnectTimeTextBox.MaxLength = 8
        Me.DisconnectTimeTextBox.Name = "DisconnectTimeTextBox"
        Me.DisconnectTimeTextBox.Size = New System.Drawing.Size(83, 23)
        Me.DisconnectTimeTextBox.TabIndex = 3
        Me.DisconnectTimeTextBox.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "seconds"
        '
        'TimeoutIdleCheckBox
        '
        Me.TimeoutIdleCheckBox.AutoSize = True
        Me.TimeoutIdleCheckBox.Location = New System.Drawing.Point(14, 91)
        Me.TimeoutIdleCheckBox.Name = "TimeoutIdleCheckBox"
        Me.TimeoutIdleCheckBox.Size = New System.Drawing.Size(160, 19)
        Me.TimeoutIdleCheckBox.TabIndex = 5
        Me.TimeoutIdleCheckBox.Text = "Timeout for idle sessions:"
        Me.TimeoutIdleCheckBox.UseVisualStyleBackColor = True
        '
        'IdleTimeTextBox
        '
        Me.IdleTimeTextBox.Location = New System.Drawing.Point(189, 89)
        Me.IdleTimeTextBox.MaxLength = 8
        Me.IdleTimeTextBox.Name = "IdleTimeTextBox"
        Me.IdleTimeTextBox.Size = New System.Drawing.Size(83, 23)
        Me.IdleTimeTextBox.TabIndex = 6
        Me.IdleTimeTextBox.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "seconds"
        '
        'LogoffWhenTimoutCheckBox
        '
        Me.LogoffWhenTimoutCheckBox.AutoSize = True
        Me.LogoffWhenTimoutCheckBox.Location = New System.Drawing.Point(14, 117)
        Me.LogoffWhenTimoutCheckBox.Name = "LogoffWhenTimoutCheckBox"
        Me.LogoffWhenTimoutCheckBox.Size = New System.Drawing.Size(262, 19)
        Me.LogoffWhenTimoutCheckBox.TabIndex = 8
        Me.LogoffWhenTimoutCheckBox.Text = "Logoff sessions when time limits are reached"
        Me.LogoffWhenTimoutCheckBox.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SaveButton.FlatAppearance.BorderSize = 0
        Me.SaveButton.ImageIndex = 0
        Me.SaveButton.ImageList = Me.SmallerIcons
        Me.SaveButton.Location = New System.Drawing.Point(334, 190)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(67, 29)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'SmallerIcons
        '
        Me.SmallerIcons.ImageStream = CType(resources.GetObject("SmallerIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SmallerIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.SmallerIcons.Images.SetKeyName(0, "favorites_16x16.png")
        Me.SmallerIcons.Images.SetKeyName(1, "cross.ico")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(11, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(385, 33)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Note: Settings here will be overridden by local policy and group policy. Some set" & _
    "tings require a reboot."
        '
        'CancelEditButton
        '
        Me.CancelEditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelEditButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelEditButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelEditButton.ImageIndex = 1
        Me.CancelEditButton.ImageList = Me.SmallerIcons
        Me.CancelEditButton.Location = New System.Drawing.Point(253, 190)
        Me.CancelEditButton.Name = "CancelEditButton"
        Me.CancelEditButton.Size = New System.Drawing.Size(75, 29)
        Me.CancelEditButton.TabIndex = 10
        Me.CancelEditButton.Text = "Cancel"
        Me.CancelEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CancelEditButton.UseVisualStyleBackColor = False
        '
        'AllowUnlistedRemoteProgramsCheckBox
        '
        Me.AllowUnlistedRemoteProgramsCheckBox.AutoSize = True
        Me.AllowUnlistedRemoteProgramsCheckBox.Location = New System.Drawing.Point(14, 39)
        Me.AllowUnlistedRemoteProgramsCheckBox.Name = "AllowUnlistedRemoteProgramsCheckBox"
        Me.AllowUnlistedRemoteProgramsCheckBox.Size = New System.Drawing.Size(200, 19)
        Me.AllowUnlistedRemoteProgramsCheckBox.TabIndex = 1
        Me.AllowUnlistedRemoteProgramsCheckBox.Text = "Allow Unlisted Remote Programs"
        Me.AllowUnlistedRemoteProgramsCheckBox.UseVisualStyleBackColor = True
        '
        'RemoteAppHostOptions
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CancelEditButton
        Me.ClientSize = New System.Drawing.Size(413, 231)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CancelEditButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdleTimeTextBox)
        Me.Controls.Add(Me.DisconnectTimeTextBox)
        Me.Controls.Add(Me.AllowUnlistedRemoteProgramsCheckBox)
        Me.Controls.Add(Me.DisableAllowListCheckBox)
        Me.Controls.Add(Me.LogoffWhenTimoutCheckBox)
        Me.Controls.Add(Me.TimeoutIdleCheckBox)
        Me.Controls.Add(Me.TimeoutDisconnectedCheckBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RemoteAppHostOptions"
        Me.Text = "Host Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimeoutDisconnectedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DisableAllowListCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DisconnectTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimeoutIdleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IdleTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LogoffWhenTimoutCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents SmallerIcons As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CancelEditButton As System.Windows.Forms.Button
    Friend WithEvents AllowUnlistedRemoteProgramsCheckBox As System.Windows.Forms.CheckBox
End Class
