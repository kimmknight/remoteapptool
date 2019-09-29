Public Class RemoteAppIconPicker

    Dim NoValidate As Boolean = False

    Public Function PickIcon(DefaultPath As String, Optional DefaultIndex As Integer = 0) As RemoteAppLib.IconSelection
        Me.FileTypeLabel.Visible = False
        Me.FileTypeTextBox.Visible = False
        Me.IconIndexLabel.Visible = False
        Me.IconIndexTextBox.Visible = False

        Me.Text = "Select Icon"

        Me.IconPathTextBox.Text = DefaultPath
        Me.IconIndexTextBox.Text = DefaultIndex.ToString

        LoadIcons()
        Dim IconPick As New RemoteAppLib.IconSelection

        If Me.ShowDialog() = Windows.Forms.DialogResult.OK Then
            IconPick.IconPath = Me.IconPathTextBox.Text
            IconPick.IconIndex = Me.IconIndexTextBox.Text
        End If

        Return IconPick

        Me.Dispose()

    End Function

    Public Function ManageFTA(DefaultPath As String, Optional DefaultIndex As Integer = 0, Optional FileType As String = ".xyz", Optional IsEdit As Boolean = False) As RemoteAppLib.FileTypeAssociation

        Dim FTA As New RemoteAppLib.FileTypeAssociation

        Me.FileTypeLabel.Visible = True
        Me.FileTypeTextBox.Visible = True
        Me.IconIndexLabel.Visible = True
        Me.IconIndexTextBox.Visible = True
        Me.IconIndexTextBox.ReadOnly = True

        If IsEdit = True Then
            FileTypeTextBox.ReadOnly = True
        Else
            FileTypeTextBox.ReadOnly = False
        End If

        Me.Text = "File Type"

        Me.FileTypeTextBox.Text = FileType
        Me.IconPathTextBox.Text = DefaultPath
        Me.IconIndexTextBox.Text = DefaultIndex

        LoadIcons()

        If Me.ShowDialog = Windows.Forms.DialogResult.OK Then
            FTA.Extension = Me.FileTypeTextBox.Text
            FTA.IconPath = Me.IconPathTextBox.Text
            FTA.IconIndex = Me.IconIndexTextBox.Text
        End If

        Me.Dispose()

        Return FTA

    End Function

    Private Function LoadIcons() As Boolean
        Me.IconList.Clear()
        Me.SmallIcons.Images.Clear()
        Dim IconError As Boolean = False

        Me.IconIndexLabel.Visible = True
        Me.IconIndexTextBox.Visible = True

        If My.Computer.FileSystem.FileExists(Me.IconPathTextBox.Text) Then
            Dim mIcon As New IconLib.MultiIcon
            Dim IconIndex As Integer = 0

            Try
                mIcon.Load(Me.IconPathTextBox.Text)
                Me.IconIndexTextBox.ReadOnly = True
            Catch Ex As Exception
                IconError = True
                NoValidate = True
                Me.OKButton.Enabled = True
                MessageBox.Show("There was an error loading icons from:" & vbCrLf & Me.IconPathTextBox.Text & vbCrLf & "Icons may still be usable, but you can not select one using the icon picker.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.IconIndexTextBox.Text = "0"
                Me.IconIndexTextBox.ReadOnly = False
            End Try

            If Not IconError Then
                NoValidate = False
                For Each sIcon In mIcon
                    Dim IconKey = IconIndex
                    Dim IconItem As New ListViewItem(IconKey)
                    Dim fiImage As IconLib.IconImage = sIcon.Item(0)
                    For Each iImage In sIcon
                        If iImage.Icon.Width = 32 Then
                            Select Case iImage.ColorsInPalette
                                Case 0
                                    fiImage = iImage
                                Case Else
                                    If iImage.ColorsInPalette > fiImage.ColorsInPalette Then fiImage = iImage
                            End Select
                            If iImage.ColorsInPalette = 0 Then fiImage = iImage
                        End If

                    Next

                    Dim TheBitmap = fiImage.Icon.ToBitmap

                    Me.SmallIcons.Images.Add(IconKey, TheBitmap)
                    IconItem.ImageKey = IconKey

                    IconList.Items.Add(IconItem)
                    IconIndex += 1
                Next
                If Not NoValidate Then Me.OKButton.Enabled = False
            End If
        End If
        Return IconError
    End Function

    Private Sub IconList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IconList.SelectedIndexChanged
        CheckSelection()
    End Sub

    Private Sub CheckSelection()
        If Me.IconList.SelectedItems.Count > 0 Then
            'something is selected
            If Not FileTypeTextBox.Text = "" Then Me.OKButton.Enabled = True
            Me.IconIndexTextBox.Text = Me.IconList.SelectedItems(0).Text

        Else
            'nothing is selected
            If Not NoValidate Then Me.OKButton.Enabled = False
            Me.IconIndexTextBox.Text = "0"
        End If
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        If My.Computer.FileSystem.FileExists(Me.IconPathTextBox.Text) Then _
            Me.FileBrowserIcon.InitialDirectory = My.Computer.FileSystem.GetParentPath(Me.IconPathTextBox.Text)
        If FileBrowserIcon.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.IconPathTextBox.Text = FileBrowserIcon.FileName
            LoadIcons()
        End If
    End Sub

    Private Sub FileTypeTextBox_TextChanged(sender As Object, e As EventArgs) Handles FileTypeTextBox.TextChanged
        ValidateFileType(FileTypeTextBox)
        If Me.FileTypeTextBox.Text = "" Then Me.OKButton.Enabled = False Else If Me.IconList.SelectedItems.Count = 1 Then Me.OKButton.Enabled = True
    End Sub

    Private Sub IconIndexTextBox_TextChanged(sender As Object, e As EventArgs) Handles IconIndexTextBox.TextChanged
        ValidateInteger(IconIndexTextBox)
    End Sub

End Class