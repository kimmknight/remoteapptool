Imports System
Imports System.Reflection

Public Class RemoteAppAboutWindow

    Private Sub RemoteAppAboutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "About " & My.Application.Info.Title
        Me.TitleLabel.Text = My.Application.Info.Title
        Me.VersionLabel.Text = "Version " & My.Application.Info.Version.ToString
    End Sub

    Private Sub SiteLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SiteLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://www.kimknight.net/remoteapptool")
    End Sub

    Private Sub IconLibLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles IconLibLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("http://creativecommons.org/licenses/by-sa/3.0/")
    End Sub

    Private Sub ralibLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.kimknight.net/")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.kimknight.net/")
    End Sub
End Class