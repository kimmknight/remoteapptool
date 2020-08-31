Imports System
Imports System.Reflection

Public Class RemoteAppAboutWindow

    Private Sub RemoteAppAboutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "About " & My.Application.Info.Title
        Me.TitleLabel.Text = My.Application.Info.Title
        Me.VersionLabel.Text = "Version " & My.Application.Info.Version.ToString & " " & My.Application.Info.Description.ToLower
    End Sub

    Private Sub SiteLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SiteLinkLabel.LinkClicked
        System.Diagnostics.Process.Start(SiteLinkLabel.Text)
    End Sub

    Private Sub IconLibLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles IconLibLinkLabel.LinkClicked
        System.Diagnostics.Process.Start(IconLibLinkLabel.Text)
    End Sub

End Class