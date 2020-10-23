<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoteAppAboutWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RemoteAppAboutWindow))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.CopyrightLabel = New System.Windows.Forms.Label()
        Me.SiteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.IconLibCreatedByLabel = New System.Windows.Forms.Label()
        Me.IconLibLabel = New System.Windows.Forms.Label()
        Me.IconLibLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.IconLibLicenceTextLabel = New System.Windows.Forms.Label()
        Me.RemoteAppToolLicenceTextLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(17, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(263, 30)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "RemoteApp Tool"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.VersionLabel.Location = New System.Drawing.Point(17, 39)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(263, 30)
        Me.VersionLabel.TabIndex = 0
        Me.VersionLabel.Text = "Version 0.0.0.0"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CopyrightLabel
        '
        Me.CopyrightLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CopyrightLabel.Location = New System.Drawing.Point(17, 69)
        Me.CopyrightLabel.Name = "CopyrightLabel"
        Me.CopyrightLabel.Size = New System.Drawing.Size(263, 30)
        Me.CopyrightLabel.TabIndex = 0
        Me.CopyrightLabel.Text = "Kim Knight, Brian Gale"
        Me.CopyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SiteLinkLabel
        '
        Me.SiteLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SiteLinkLabel.Location = New System.Drawing.Point(15, 129)
        Me.SiteLinkLabel.Name = "SiteLinkLabel"
        Me.SiteLinkLabel.Size = New System.Drawing.Size(271, 30)
        Me.SiteLinkLabel.TabIndex = 1
        Me.SiteLinkLabel.TabStop = True
        Me.SiteLinkLabel.Text = "https://github.com/kimmknight/remoteapptool"
        Me.SiteLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconLibCreatedByLabel
        '
        Me.IconLibCreatedByLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconLibCreatedByLabel.Location = New System.Drawing.Point(17, 189)
        Me.IconLibCreatedByLabel.Name = "IconLibCreatedByLabel"
        Me.IconLibCreatedByLabel.Size = New System.Drawing.Size(263, 30)
        Me.IconLibCreatedByLabel.TabIndex = 4
        Me.IconLibCreatedByLabel.Text = "Created by CastorTiu"
        Me.IconLibCreatedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconLibLabel
        '
        Me.IconLibLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconLibLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconLibLabel.Location = New System.Drawing.Point(17, 159)
        Me.IconLibLabel.Name = "IconLibLabel"
        Me.IconLibLabel.Size = New System.Drawing.Size(263, 30)
        Me.IconLibLabel.TabIndex = 5
        Me.IconLibLabel.Text = "IconLib"
        Me.IconLibLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconLibLinkLabel
        '
        Me.IconLibLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconLibLinkLabel.Location = New System.Drawing.Point(12, 249)
        Me.IconLibLinkLabel.Name = "IconLibLinkLabel"
        Me.IconLibLinkLabel.Size = New System.Drawing.Size(274, 30)
        Me.IconLibLinkLabel.TabIndex = 1
        Me.IconLibLinkLabel.TabStop = True
        Me.IconLibLinkLabel.Text = "https://creativecommons.org/licenses/by-sa/3.0/"
        Me.IconLibLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconLibLicenceTextLabel
        '
        Me.IconLibLicenceTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IconLibLicenceTextLabel.Location = New System.Drawing.Point(17, 219)
        Me.IconLibLicenceTextLabel.Name = "IconLibLicenceTextLabel"
        Me.IconLibLicenceTextLabel.Size = New System.Drawing.Size(263, 30)
        Me.IconLibLicenceTextLabel.TabIndex = 4
        Me.IconLibLicenceTextLabel.Text = "Licensed under a Creative Commons" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Attribution-Share Alike 3.0 Unported License"
        Me.IconLibLicenceTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemoteAppToolLicenceTextLabel
        '
        Me.RemoteAppToolLicenceTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RemoteAppToolLicenceTextLabel.Location = New System.Drawing.Point(17, 99)
        Me.RemoteAppToolLicenceTextLabel.Name = "RemoteAppToolLicenceTextLabel"
        Me.RemoteAppToolLicenceTextLabel.Size = New System.Drawing.Size(263, 30)
        Me.RemoteAppToolLicenceTextLabel.TabIndex = 6
        Me.RemoteAppToolLicenceTextLabel.Text = "Licensed under The MIT License"
        Me.RemoteAppToolLicenceTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemoteAppAboutWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(298, 296)
        Me.Controls.Add(Me.RemoteAppToolLicenceTextLabel)
        Me.Controls.Add(Me.IconLibLicenceTextLabel)
        Me.Controls.Add(Me.IconLibCreatedByLabel)
        Me.Controls.Add(Me.IconLibLabel)
        Me.Controls.Add(Me.IconLibLinkLabel)
        Me.Controls.Add(Me.SiteLinkLabel)
        Me.Controls.Add(Me.CopyrightLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RemoteAppAboutWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RemoteAppAboutWindow"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents CopyrightLabel As System.Windows.Forms.Label
    Friend WithEvents SiteLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents IconLibCreatedByLabel As System.Windows.Forms.Label
    Friend WithEvents IconLibLabel As System.Windows.Forms.Label
    Friend WithEvents IconLibLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents IconLibLicenceTextLabel As System.Windows.Forms.Label
    Friend WithEvents RemoteAppToolLicenceTextLabel As Label
End Class
