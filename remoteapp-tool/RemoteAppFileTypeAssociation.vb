Public Class RemoteAppFileTypeAssociation

    Private RemoteApp As New RemoteAppLib.RemoteApp

    Public Function EditFileTypes(SelectedRemoteApp As RemoteAppLib.RemoteApp) As RemoteAppLib.RemoteApp
        RemoteApp = SelectedRemoteApp
        Me.Text = "File type associations for " & RemoteApp.Name
        HelpSystem.SetupTips(Me)
        LoadFTAs()
        Me.ShowDialog()
        Me.Dispose()
        Return RemoteApp
    End Function

    'Private Sub SetToolTips()
    '    Dim toolTip1 As New ToolTip()
    '    ' Set up the delays for the ToolTip.
    '    toolTip1.AutoPopDelay = 5000
    '    toolTip1.InitialDelay = 1000
    '    toolTip1.ReshowDelay = 500
    '    ' Force the ToolTip text to be displayed whether or not the form is active:
    '    '  toolTip1.ShowAlways = True

    '    toolTip1.SetToolTip(Me.CreateButton, "Create a new File Type Association")
    '    toolTip1.SetToolTip(Me.DeleteButton, "Delete selected File Type Association")
    '    toolTip1.SetToolTip(Me.EditButton, "Change icon of selected File Type Association")
    'End Sub

    Private Sub LoadFTAs()
        FTAListView.Items.Clear()

        If Not RemoteApp.FileTypeAssociations Is Nothing Then
            For Each fta As RemoteAppLib.FileTypeAssociation In RemoteApp.FileTypeAssociations
                Dim FTitem As New ListViewItem(fta.Extension)

                Dim ftaStatus As String
                If LocalFtaModule.DoesFTAExist(fta.Extension) Then
                    'FTA exists - created by another app
                    ftaStatus = "Existing"
                    If LocalFtaModule.IsFTAMine(fta.Extension) Then
                        'FTA exists - created by RemoteApp Tool
                        ftaStatus = "Yes"
                    End If
                Else
                    'FTA does not exist
                    ftaStatus = "No"
                End If


                FTitem.SubItems.Add(fta.IconPath)
                FTitem.SubItems.Add(fta.IconIndex)
                FTitem.SubItems.Add(ftaStatus)
                FTAListView.Items.Add(FTitem)
            Next
        End If
        CheckSelection()
    End Sub


    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        If RemoteApp.FileTypeAssociations Is Nothing Then
            Dim FTACol As New RemoteAppLib.FileTypeAssociationCollection
            RemoteApp.FileTypeAssociations = FTACol
        End If

        Dim FTA As New RemoteAppLib.FileTypeAssociation
        FTA = RemoteAppIconPicker.ManageFTA(RemoteApp.IconPath, 0)
        Dim SameFTA As Boolean = False
        If Not FTA.Extension Is Nothing Then
            For Each RAFTA As RemoteAppLib.FileTypeAssociation In RemoteApp.FileTypeAssociations
                If RAFTA.Extension = FTA.Extension Then SameFTA = True
            Next
            If Not SameFTA Then
                RemoteApp.FileTypeAssociations.Add(FTA)
            Else
                MessageBox.Show("There is already an association for filetype: " & FTA.Extension, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        End If
        LoadFTAs()

    End Sub

    Private Sub FTAListView_DoubleClick(sender As Object, e As EventArgs) Handles FTAListView.DoubleClick
        EditFTA()
    End Sub

    Private Sub FTAListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FTAListView.SelectedIndexChanged
        CheckSelection()
    End Sub

    Private Sub CheckSelection()
        If FTAListView.SelectedItems.Count > 0 Then
            Me.EditButton.Enabled = True
            Me.DeleteButton.Enabled = True
            Me.SetAssociationButton.Enabled = True
        Else
            Me.EditButton.Enabled = False
            Me.DeleteButton.Enabled = False
            Me.SetAssociationButton.Enabled = False
        End If

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim FileType = FTAListView.SelectedItems(0).Text
        If MessageBox.Show("Are you sure you want to remove filetype:" & vbCrLf & "." & FileType & " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Dim IconPath = FTAListView.SelectedItems(0).SubItems(0).Text
            Dim IconIndex = FTAListView.SelectedItems(0).SubItems(1).Text
            Dim FTAtoRemove As New RemoteAppLib.FileTypeAssociation
            For Each FTA As RemoteAppLib.FileTypeAssociation In RemoteApp.FileTypeAssociations
                If FTA.Extension = FileType Then FTAtoRemove = FTA
            Next
            RemoteApp.FileTypeAssociations.Remove(FTAtoRemove)
        End If

        LoadFTAs()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        EditFTA()
    End Sub

    Private Sub EditFTA()
        Dim FTA As New RemoteAppLib.FileTypeAssociation

        FTA = RemoteAppIconPicker.ManageFTA(Me.FTAListView.SelectedItems(0).SubItems(1).Text, Val(Me.FTAListView.SelectedItems(0).SubItems(2).Text), Me.FTAListView.SelectedItems(0).Text, True)

        If Not FTA.Extension Is Nothing Then
            Dim IconPath = FTAListView.SelectedItems(0).SubItems(0).Text
            Dim IconIndex = FTAListView.SelectedItems(0).SubItems(1).Text
            Dim FileType = FTAListView.SelectedItems(0).Text
            Dim FTAtoRemove As New RemoteAppLib.FileTypeAssociation

            For Each FTA2 As RemoteAppLib.FileTypeAssociation In RemoteApp.FileTypeAssociations
                If FTA2.Extension = FileType Then FTAtoRemove = FTA2
            Next
            RemoteApp.FileTypeAssociations.Remove(FTAtoRemove)
            RemoteApp.FileTypeAssociations.Add(FTA)
            LoadFTAs()
        End If

    End Sub

    Private Sub SetAssociationButton_Click(sender As Object, e As EventArgs) Handles SetAssociationButton.Click ' NEED TO SORT OUT EVERYTHING IN THIS SUB!!!
        Dim fta As New RemoteAppLib.FileTypeAssociation
        fta.Extension = FTAListView.SelectedItems(0).SubItems(0).Text
        fta.IconPath = FTAListView.SelectedItems(0).SubItems(1).Text
        fta.IconIndex = FTAListView.SelectedItems(0).SubItems(2).Text

        Dim MsgBoxResult As Windows.Forms.DialogResult = Windows.Forms.DialogResult.Cancel

        If LocalFtaModule.DoesFTAExist(fta.Extension) Then
            'An existing association was found
            If Not IsFTAMine(fta.Extension) Then
                'FTA found and belongs to another application (replace?)
                MsgBoxResult = MessageBox.Show("An association already exists on the local computer for filetype. " & _
                                                    "Would you like to replace it?" & vbCrLf & vbCrLf & _
                                                    "Warning: This association was created by another application. " & _
                                                    "Replacing it can cause problems. " & _
                                                    "If the existing association is working, there is no need to replace it.", _
                                                    "File Type Association", _
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If MsgBoxResult = Windows.Forms.DialogResult.Yes Then _
                    LocalFtaModule.CreateFTA(fta, RemoteApp.Path, RemoteApp.Name, True)
            Else
                'FTA found and belongs to RemoteApp Tool (remove)
                MsgBoxResult = MessageBox.Show("Are you sure you want to remove this file type association on the local computer?", _
                                                    "File Type Association", _
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If MsgBoxResult = Windows.Forms.DialogResult.Yes Then _
                    LocalFtaModule.DeleteFTA(fta.Extension)
            End If

        Else
            'FTA not found (create)
            If LocalFtaModule.CreateFTA(fta, RemoteApp.Path, RemoteApp.Name) = True Then
                MessageBox.Show("File type association created for " & fta.Extension & ".", "File Type Association", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("File type association not created. There was an error.", "File Type Association", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

        Me.LoadFTAs()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class