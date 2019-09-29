Imports RemoteAppLib

Public Class RemoteAppEditWindow

    Private RemoteApp As New RemoteApp

    Public Function EditRemoteApp(SelectedRemoteApp As RemoteApp) As RemoteApp
        HelpSystem.SetupTips(Me)
        RemoteApp = SelectedRemoteApp
        Me.Text = "Properties of " & RemoteApp.Name
        Me.Size = Me.MinimumSize
        HelpSystem.SetupTips(Me)
        Me.LoadValues()
        Dim dlgResult = Me.ShowDialog()
        RemoteAppMainWindow.ReloadApps()
        Me.Dispose()
        Return RemoteApp
    End Function

    Public Function CreateRemoteApp(Optional Advanced As Boolean = False) As RemoteApp
        Me.Text = "New RemoteApp"
        Me.Size = Me.MinimumSize
        HelpSystem.SetupTips(Me)
        Me.CommandLineOptionCombo.SelectedIndex = 1
        Me.TSWAbox.SelectedIndex = 0
        Me.FTAButton.Enabled = False

        If Advanced Then

            Me.ShowDialog()
        Else
            If DoBrowsePath() = True Then

                SaveAndCloseOrWindow()

            End If
        End If

        Me.Dispose()
        Return RemoteApp
    End Function

    Private Sub SetToolTips()
        Dim toolTip1 As New ToolTip()
        ' Set up the delays for the ToolTip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500

        toolTip1.SetToolTip(Me.BrowseIconPath, "Select an icon")
        toolTip1.SetToolTip(Me.BrowsePath, "Browse for application")
        toolTip1.SetToolTip(Me.BrowseVPath, "Browse for application")
        toolTip1.SetToolTip(Me.VPathCopyButton, "Copy Path into VPath")
        toolTip1.SetToolTip(Me.IconPathCopyButton, "Copy Path into Icon path")
    End Sub

    Sub LoadValues()

        Me.ShortNameText.Text = RemoteApp.Name
        Me.CommandLineOptionCombo.SelectedIndex = RemoteApp.CommandLineOption

        Me.FullNameText.Text = RemoteApp.FullName
        Me.PathText.Text = RemoteApp.Path
        Me.VPathText.Text = RemoteApp.VPath
        Me.CommandLineText.Text = RemoteApp.CommandLine
        Me.CommandLineOptionCombo.SelectedIndex = RemoteApp.CommandLineOption
        Me.IconPathText.Text = RemoteApp.IconPath
        Me.IconIndexText.Text = RemoteApp.IconIndex
        Dim TSWA As Integer = 0
        If RemoteApp.TSWA = True Then TSWA = 1
        Me.TSWAbox.SelectedIndex = TSWA

        Dim TheIcon = ReturnIcon(Me.IconPathText.Text, Val(Me.IconIndexText.Text), True)
        If Not TheIcon Is Nothing Then
            Me.Icon = TheIcon
        Else
            Me.Icon = RemoteAppMainWindow.Icon
        End If
    End Sub

    Private Sub CancelEditButton_Click(sender As Object, e As EventArgs) Handles CancelEditButton.Click
        Me.Close()
    End Sub

    Private Sub VPathCopyButton_Click(sender As Object, e As EventArgs) Handles VPathCopyButton.Click
        Me.VPathText.Text = Me.PathText.Text
    End Sub

    Private Sub IconPathCopyButton_Click(sender As Object, e As EventArgs) Handles IconPathCopyButton.Click
        Me.IconPathText.Text = Me.PathText.Text
    End Sub

    Private Sub BrowseVPath_Click(sender As Object, e As EventArgs) Handles BrowseVPath.Click
        If My.Computer.FileSystem.FileExists(VPathText.Text) Then FileBrowserVPath.InitialDirectory = My.Computer.FileSystem.GetParentPath(VPathText.Text)
        If FileBrowserVPath.ShowDialog() = Windows.Forms.DialogResult.OK Then Me.VPathText.Text = FileBrowserVPath.FileName
    End Sub

    Private Sub BrowseIconPath_Click(sender As Object, e As EventArgs) Handles BrowseIconPath.Click
        IconPick()
    End Sub

    Private Sub IconPick()
        Dim StartPath As String = GetSysDir() & "\shell32.dll"
        Dim StartIndex As Integer = Val(Me.IconIndexText.Text)
        If My.Computer.FileSystem.FileExists(IconPathText.Text) Then StartPath = IconPathText.Text
        Dim PickedIcon = RemoteAppIconPicker.PickIcon(StartPath, StartIndex)
        If Not PickedIcon.IconPath Is Nothing Then
            Me.IconPathText.Text = PickedIcon.IconPath
            Me.IconIndexText.Text = PickedIcon.IconIndex
        End If
    End Sub

    Private Sub BrowsePath_Click(sender As Object, e As EventArgs) Handles BrowsePath.Click
        DoBrowsePath()
    End Sub

    Private Function DoBrowsePath() As Boolean

        DoBrowsePath = False

        If My.Computer.FileSystem.FileExists(PathText.Text) Then FileBrowserPath.InitialDirectory = My.Computer.FileSystem.GetParentPath(PathText.Text)
        If FileBrowserPath.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim FilePath = FileBrowserPath.FileName
            Me.PathText.Text = FilePath
            RemoteApp.Path = FilePath
            If Me.VPathText.Text = "" Then RemoteApp.VPath = FilePath
            If Me.IconPathText.Text = "" Then RemoteApp.IconPath = FilePath
            If FilePath.ToLower.EndsWith(".exe") Then
                Dim title = GetEXETitle(FilePath)
                If Me.ShortNameText.Text = "" Then RemoteApp.Name = FixShortAppName(title)
                If Me.FullNameText.Text = "" Then RemoteApp.FullName = title
            End If
            LoadValues()
            DoBrowsePath = True
        End If
    End Function

    Private Sub SaveRemoteApp(ShortName As String, FullName As String, Path As String, VPath As String, CommandLine As String, CommandLineSetting As Integer, IconPath As String, IconIndex As Integer, ShowInTSWA As Integer)

        Dim SysApps As New SystemRemoteApps

        If Not RemoteApp.Name Is Nothing Then If Not RemoteApp.Name = ShortName Then SysApps.RenameApp(RemoteApp.Name, ShortName)

        RemoteApp.Name = ShortName
        RemoteApp.FullName = FullName
        RemoteApp.Path = Path
        RemoteApp.VPath = VPath
        RemoteApp.IconPath = IconPath
        RemoteApp.IconIndex = IconIndex
        RemoteApp.CommandLine = CommandLine
        RemoteApp.CommandLineOption = CommandLineSetting
        RemoteApp.TSWA = ShowInTSWA

        SysApps.SaveApp(RemoteApp)

    End Sub

    Private Function DoesAppExist(AppName As String) As Boolean
        Dim AppExists = False

        Dim sra As New SystemRemoteApps
        Dim AppCol As New RemoteAppCollection

        AppCol = sra.GetAll

        For Each App As RemoteApp In AppCol
            If App.Name = AppName Then AppExists = True
        Next

        Return AppExists
    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveAndClose()
    End Sub

    Private Sub SaveAndCloseOrWindow()
        If Me.ShortNameText.Text = "" Then
            MessageBox.Show("Name must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.ShowDialog()
        ElseIf Me.FullNameText.Text = "" Then
            MessageBox.Show("Full name must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.ShowDialog()
        ElseIf Me.PathText.Text = "" Then
            MessageBox.Show("Path must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.ShowDialog()
        ElseIf Not Me.ShortNameText.Text = RemoteApp.Name And DoesAppExist(Me.ShortNameText.Text) Then
            MessageBox.Show("A RemoteApp with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.ShowDialog()
        ElseIf Me.Text = "New RemoteApp" And DoesAppExist(Me.ShortNameText.Text) Then
            MessageBox.Show("A RemoteApp with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.ShowDialog()
        Else
            SaveRemoteApp(Me.ShortNameText.Text.Trim, Me.FullNameText.Text, Me.PathText.Text, Me.VPathText.Text, Me.CommandLineText.Text, Me.CommandLineOptionCombo.SelectedIndex, Me.IconPathText.Text, Val(IconIndexText.Text), Me.TSWAbox.SelectedIndex)
            Me.Close()
        End If
    End Sub

    Private Sub SaveAndClose()
        If Me.ShortNameText.Text = "" Then
            MessageBox.Show("Name must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Me.FullNameText.Text = "" Then
            MessageBox.Show("Full name must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Me.PathText.Text = "" Then
            MessageBox.Show("Path must not be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Not Me.ShortNameText.Text = RemoteApp.Name And DoesAppExist(Me.ShortNameText.Text) Then
            MessageBox.Show("A RemoteApp with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Me.Text = "New RemoteApp" And DoesAppExist(Me.ShortNameText.Text) Then
            MessageBox.Show("A RemoteApp with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            SaveRemoteApp(Me.ShortNameText.Text.Trim, Me.FullNameText.Text, Me.PathText.Text, Me.VPathText.Text, Me.CommandLineText.Text, Me.CommandLineOptionCombo.SelectedIndex, Me.IconPathText.Text, Val(IconIndexText.Text), Me.TSWAbox.SelectedIndex)
            Me.Close()
        End If
    End Sub

    Private Sub IconIndexText_TextChanged(sender As Object, e As EventArgs) Handles IconIndexText.TextChanged
        ValidateInteger(IconIndexText)
    End Sub

    Private Sub FTAButton_Click(sender As Object, e As EventArgs) Handles FTAButton.Click

        RemoteAppFileTypeAssociation.EditFileTypes(RemoteApp)

    End Sub


    Private Sub ShortNameText_TextChanged(sender As Object, e As EventArgs) Handles ShortNameText.TextChanged
        ValidateAppName(Me.ShortNameText)
    End Sub

End Class