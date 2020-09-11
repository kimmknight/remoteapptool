Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports RemoteAppLib

Public Class RemoteAppMainWindow

    Private Sub RemoteAppMainWindow_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If Not Me.WindowState = FormWindowState.Maximized Then
            My.Settings.MainWindowWidth = Me.Width
            My.Settings.MainWindowHeight = Me.Height
        End If
    End Sub

    Private Sub RemoteAppMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sra As New SystemRemoteApps
        sra.Init()
        
        Try
            TestIconLib()
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("IconLib.dll is unavailable. Please add it to the RemoteApp Tool folder.")
            End
        End Try

        Dim VersionString = My.Application.Info.Version.ToString
        If Not My.Application.Info.Description = Nothing Then
            VersionString = My.Application.Info.Version.ToString & " " & My.Application.Info.Description.ToLower
        End If

        Me.Text = My.Application.Info.Title & " " & versionstring & " (" & System.Net.Dns.GetHostName & ")"
        If Not My.Computer.Keyboard.ShiftKeyDown Then
            If Not My.Settings.MainWindowWidth < Me.MinimumSize.Width Then Me.Width = My.Settings.MainWindowWidth
            If Not My.Settings.MainWindowHeight < Me.MinimumSize.Height Then Me.Height = My.Settings.MainWindowHeight
        End If
        HelpSystem.SetupTips(Me)
        AddSysMenuItems()
        ReloadApps()
    End Sub

    Public Sub ReloadApps()
        Me.AppList.Clear()

        Dim SystemApps As New SystemRemoteApps
        Dim Apps As New RemoteAppCollection

        Apps = SystemApps.GetAll

        For Each App As RemoteApp In Apps
            SmallIcons.Images.RemoveByKey(App.Name)
            Dim TheBitmap = GetAppBitmap(App.Name)
            Dim AppItem As New ListViewItem(App.Name)
            AppItem.ToolTipText = App.FullName
            AppItem.ImageIndex = 0
            Me.SmallIcons.Images.Add(App.Name, TheBitmap)
            AppItem.ImageKey = App.Name
            AppList.Items.Add(AppItem)
        Next

        If Apps.Count = 0 Then
            NoAppsLabel.Visible = True
        Else
            NoAppsLabel.Visible = False
        End If

        EditButton.Enabled = False
        DeleteButton.Enabled = False
        CreateClientConnection.Enabled = False
    End Sub

    Private Sub AppList_DoubleClick(sender As Object, e As EventArgs) Handles AppList.DoubleClick
        If Me.AppList.SelectedItems.Count = 1 Then
            EditRemoteApp(Me.AppList.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub AppList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppList.SelectedIndexChanged
        If AppList.SelectedItems.Count = 1 Then
            Me.EditButton.Enabled = True
            Me.DeleteButton.Enabled = True
            CreateClientConnection.Enabled = True
        Else
            Me.EditButton.Enabled = False
            Me.DeleteButton.Enabled = False
            Me.CreateClientConnection.Enabled = False
        End If
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        If Me.AppList.SelectedItems.Count = 1 Then
            EditRemoteApp(Me.AppList.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub EditRemoteApp(AppName As String)
        Dim sra As New SystemRemoteApps
        RemoteAppEditWindow.EditRemoteApp(sra.GetApp(AppName))
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DeleteRemoteApp(AppList.SelectedItems(0).Text)
        ReloadApps()
    End Sub

    Private Sub DeleteRemoteApp(ByVal AppName As String)
        If MessageBox.Show("Are you sure you want to remove " & AppName & "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sra As New SystemRemoteApps
            sra.DeleteApp(AppName)
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        RemoteAppEditWindow.CreateRemoteApp()
        ReloadApps()
    End Sub

    'System Menu Code (for about box)
    Private Declare Function AppendMenu Lib "user32.dll" Alias "AppendMenuA" (ByVal hMenu As IntPtr, ByVal uFlags As Int32, ByVal uIDNewItem As IntPtr, ByVal lpNewItem As String) As Boolean
    Private Declare Function GetSystemMenu Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal bRevert As Boolean) As IntPtr
    Private Const MF_STRING As Integer = &H0
    Private Const MF_SEPARATOR As Integer = &H800
    Private Const WM_SYSCOMMAND = &H112

    Private Sub AddSysMenuItems()
        'Get the System Menus Handle.
        Dim hSysMenu As IntPtr = GetSystemMenu(Me.Handle, False)
        'Add a standard Separator Item.
        AppendMenu(hSysMenu, MF_SEPARATOR, 1000, Nothing)
        'Add an About Menu Item.
        AppendMenu(hSysMenu, MF_STRING, 1001, "About...")
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If (m.Msg = WM_SYSCOMMAND) Then
            Select Case m.WParam.ToInt32
                Case 1001
                    RemoteAppAboutWindow.ShowDialog()
            End Select
        End If
    End Sub

    Private Sub CreateClientConnection_Click(sender As Object, e As EventArgs) Handles CreateClientConnection.Click
        Dim sra As New SystemRemoteApps
        RemoteAppCreateClientConnection.CreateClientConnection(sra.GetApp(Me.AppList.SelectedItems(0).Text))
    End Sub

    Private Sub HostOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostOptionsToolStripMenuItem.Click
        RemoteAppHostOptions.SetValues()
        RemoteAppHostOptions.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        RemoteAppAboutWindow.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.kimknight.net/remoteapptool")
    End Sub

    Private Sub RemoveUnusedFileTypeAssociationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveUnusedFileTypeAssociationsToolStripMenuItem.Click
        LocalFtaModule.RemoveUnusedFTAs()
    End Sub

    Private Sub NewRemoteAppadvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRemoteAppadvancedToolStripMenuItem.Click
        RemoteAppEditWindow.CreateRemoteApp(True)
        ReloadApps()
    End Sub

    Private Sub RemoteAppMainWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' Check to see if this is a pre-release or debug version.
        ' This information comes from the project assembly description

        Dim AssemblyDescription = My.Application.Info.Description

        If Not AssemblyDescription = "" Then

            ' Ask the user if the application worked correctly
            Dim ReleaseType = AssemblyDescription
            If ReleaseType.StartsWith("rc", True, Nothing) Then
                ReleaseType = "Release Candidate"
            End If

            Dim ProblemYesNo = MessageBox.Show("This is a """ & ReleaseType.ToLower & """ of RemoteApp Tool." & vbCrLf & vbCrLf & "Did it work correctly?", AssemblyDescription.ToUpper & " version feedback", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' If the user had a problem, ask for more info.
            ' Put the responses + version # into an array, ready to be inserted into a URL

            Dim FeedbackResponses(3) As String
            Dim VersionString = My.Application.Info.Version.ToString & " " & My.Application.Info.Description.ToString

            If ProblemYesNo = DialogResult.No Then
                'Dim FeedbackText = InputBox("Please describe the problem you experienced:", "Problem description")
                FeedbackResponses = {VersionString, "No", ""}
            ElseIf ProblemYesNo = DialogResult.Yes Then
                FeedbackResponses = {VersionString, "Yes", ""}
            End If

            ' Build the Google Form URL

            Dim FormUrl = "https://docs.google.com/forms/d/e/1FAIpQLSet6jkUvj23n9IK0L_aM8ckv40BfcI9e8VTdfcDdz2XtU-ERA/viewform?usp=pp_url&entry.64442428=" &
                FeedbackResponses(0) &
                "&entry.1809958859=" &
                FeedbackResponses(1) &
                "&entry.612126075=" &
                FeedbackResponses(2)

            ' Send the user to the filled Google Form to submit

            System.Diagnostics.Process.Start(FormUrl)

        End If
    End Sub
End Class