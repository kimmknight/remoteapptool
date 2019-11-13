Imports System.Text.RegularExpressions

Module RemoteAppFunction

    Public Sub ValidateInteger(TheTextBox As TextBox)
        Dim cloc = TheTextBox.SelectionStart
        TheTextBox.Text = Val(TheTextBox.Text)
        TheTextBox.Select(TheTextBox.Text.Length, 0)
        TheTextBox.Select(cloc, 0)
    End Sub

    Public Sub ValidatePort(TheTextBox As TextBox)
        Dim cloc = TheTextBox.SelectionStart
        If Val(TheTextBox.Text) > 65535 Then
            TheTextBox.Text = "65535"
            cloc = TheTextBox.Text.Length
        End If

        TheTextBox.Text = Val(TheTextBox.Text)
        TheTextBox.Select(TheTextBox.Text.Length, 0)
        TheTextBox.Select(cloc, 0)
    End Sub

    Public Sub ValidateSeconds(TheTextBox As TextBox)
        Dim cloc = TheTextBox.SelectionStart
        If Val(TheTextBox.Text) > 2147483 Then
            TheTextBox.Text = 2147483
            cloc = TheTextBox.Text.Length
        End If

        TheTextBox.Text = Val(TheTextBox.Text)
        TheTextBox.Select(TheTextBox.Text.Length, 0)
        TheTextBox.Select(cloc, 0)
    End Sub

    Public Sub ValidateAppName(TheTextBox As TextBox)
        ValidateTextBoxR(TheTextBox, "[^\p{L}0-9\-_"" ""]")
    End Sub

    Private Sub ValidateTextBoxR(TheTextBox As TextBox, regex As String)
        Dim cloc = TheTextBox.SelectionStart
        Dim rx As New Regex(regex)
        If (rx.IsMatch(TheTextBox.Text)) Then
            TheTextBox.Text = rx.Replace(TheTextBox.Text, "")
            TheTextBox.Select(cloc - 1, 0)
        Else
            TheTextBox.Select(cloc, 0)
        End If
    End Sub

    Public Function FixShortAppName(TheText As String)
        If TheText <> "" Then
            Dim rx As New Regex("[^\p{L}0-9\-_"" ""]")
            If (rx.IsMatch(TheText)) Then
                TheText = rx.Replace(TheText, "")
            End If
        End If
        TheText = TheText.Trim
        Return TheText
    End Function

    Public Sub ValidateDNSname(ByVal TheTextBox As TextBox)
        ' pattern matches any character that is NOT A-Z (allows upper and lower case alphabets)
        Dim rx As New Regex("[^\p{L}LlUu0-9\-\._]")
        If (rx.IsMatch(TheTextBox.Text)) Then
            TheTextBox.Text = rx.Replace(TheTextBox.Text, "")
            TheTextBox.Select(TheTextBox.Text.Length, 0)
        End If
    End Sub

    Public Sub ValidateFileType(ByVal TheTextBox As TextBox)
        ' pattern matches any character that is NOT A-Z (allows upper and lower case alphabets)
        Dim rx As New Regex("[^\p{L}0-9\-_\!\@\#\$\%\^\&\(\)\{\}\[\]\+\=\;\,\']")
        If (rx.IsMatch(TheTextBox.Text)) Then
            TheTextBox.Text = rx.Replace(TheTextBox.Text, "")
            TheTextBox.Select(TheTextBox.Text.Length, 0)
        End If
    End Sub

    Public Function GetAppBitmap(RemoteAppShortName As String)
        On Error Resume Next
        Dim AppKey As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList\Applications" & "\" & RemoteAppShortName
        Dim TheRegKey = My.Computer.Registry.LocalMachine.OpenSubKey(AppKey)
        Dim TheIcon = ReturnIcon("", 0).ToBitmap
        If Not TheRegKey Is Nothing Then
            Dim IconPath = TheRegKey.GetValue("IconPath", "")
            Dim IconIndex = TheRegKey.GetValue("IconIndex", "")
            TheIcon = ReturnIcon(IconPath, IconIndex).ToBitmap
        End If
        Return TheIcon
    End Function

    Private Declare Function GetSystemDirectory Lib "kernel32" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long

    Public Function GetSysDir() As String
        Return Environment.SystemDirectory.ToString
    End Function

    Public Sub DeleteFiles(FilesArray As ArrayList)
        For Each dFile In FilesArray
            Dim LockCheck As New LockChecker.LockChecker()
            Dim FileLocked As String
            Dim SkipFile As Boolean = False
            FileLocked = LockCheck.CheckLock(dFile)
            While Not (FileLocked = "No locks")
                If (MessageBox.Show("The file " + dFile + " is currently locked.  Lock information:" + FileLocked + vbNewLine + "Do you want to try again?", "File Locked", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    FileLocked = LockCheck.CheckLock(dFile)
                Else
                    MessageBox.Show("The following file will not be deleted:" + vbNewLine + dFile)
                    SkipFile = True
                    FileLocked = "No locks"
                End If
            End While
            If Not (SkipFile) Then
                If My.Computer.FileSystem.FileExists(dFile) Then My.Computer.FileSystem.DeleteFile(dFile)
            End If

        Next
    End Sub

    Public Function GetEXETitle(exePath As String)
        Dim pname = System.Diagnostics.FileVersionInfo.GetVersionInfo(exePath).FileDescription
        If pname = "" Then pname = Left(My.Computer.FileSystem.GetFileInfo(exePath).Name, My.Computer.FileSystem.GetFileInfo(exePath).Name.Length - 4)

        Return pname
    End Function

End Module
