Module HelpSystem
    Public Sub SetupTips(TheForm As Windows.Forms.Form)
        Dim toolTip1 As New ToolTip With {
            .AutoPopDelay = 10000,
            .InitialDelay = 500,
            .ReshowDelay = 500
        }

        Dim HelpString As String

        For Each Control As Control In TheForm.Controls
            For Each SubControl As Control In Control.Controls
                For Each SubSubControl In SubControl.Controls
                    For Each SubSubSubControl In SubSubControl.Controls
                        HelpString = GetTipString(Control.Parent.Name, SubSubSubControl.Name)
                        If Not HelpString = "" Then toolTip1.SetToolTip(SubSubSubControl, HelpString)
                    Next
                    HelpString = GetTipString(Control.Parent.Name, SubSubControl.Name)
                    If Not HelpString = "" Then toolTip1.SetToolTip(SubSubControl, HelpString)
                Next
                HelpString = GetTipString(Control.Parent.Name, SubControl.Name)
                If Not HelpString = "" Then toolTip1.SetToolTip(SubControl, HelpString)
            Next
            HelpString = GetTipString(Control.Parent.Name, Control.Name)
            If Not HelpString = "" Then toolTip1.SetToolTip(Control, HelpString)
        Next

    End Sub

    Private Function GetTipString(FormName As String, ControlName As String) As String
        Dim TipString As String = ""

        Dim TipText As String = GetTipFile()
        Dim TipArray = TipText.Split(ControlChars.CrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

        For Each TipLine As String In TipArray
            Dim TipLineArray = TipLine.Split("|")
            If TipLineArray(0) = FormName And TipLineArray(1) = ControlName Then TipString = TipLineArray(2)
        Next

        TipString = TipString.Replace("\r", vbCr)
        TipString = TipString.Replace("\n", vbLf)

        Return TipString
    End Function

    Private Function GetTipFile() As String
        Dim TipFile As String = ""

        If My.Computer.FileSystem.FileExists("tips.txt") Then
            TipFile = My.Computer.FileSystem.ReadAllText("tips.txt")
        Else
            TipFile = GetBuiltInTips()
        End If

        Return TipFile
    End Function

    Private Function GetBuiltInTips() As String
        Dim Tips As String = ""

        Tips += "RemoteAppMainWindow|CreateButton|Add a new RemoteApp." & vbCrLf
        Tips += "RemoteAppMainWindow|DeleteButton|Remove selected RemoteApp." & vbCrLf
        Tips += "RemoteAppMainWindow|EditButton|Edit properties of selected RemoteApp." & vbCrLf
        Tips += "RemoteAppMainWindow|CreateClientConnection|Creates a RDP file or MSI installer for the selected RemoteApp." & vbCrLf

        Tips += "RemoteAppEditWindow|SaveButton|Save changes and close." & vbCrLf
        Tips += "RemoteAppEditWindow|FTAButton|Set file type associations for this RemoteApp." & vbCrLf
        Tips += "RemoteAppEditWindow|CancelEditButton|Discard changes and close." & vbCrLf
        Tips += "RemoteAppEditWindow|BrowseIconPath|Select an icon for the RemoteApp." & vbCrLf
        Tips += "RemoteAppEditWindow|IconPathCopyButton|Copy the value from the ""Path"" field into the ""Icon path"" field. " & vbCrLf
        Tips += "RemoteAppEditWindow|BrowsePath|Browse for application." & vbCrLf
        Tips += "RemoteAppEditWindow|IconResetButton|Reset the icon to the default for this application." & vbCrLf

        'IconResetButton

        Tips += "RemoteAppCreateClientConnection|RDPRadioButton|Create an RDP file." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|MSIRadioButton|Create an MSI file." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|EditAfterSave|Edit the RDP connection file." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|CreateRAWebIcon|Generate an icon for the application and any file type associations.\r\nUse this with RAWeb." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|FTAButton|Set file type associations for this RemoteApp.\r\nChanges here will only affect this client connection. They will not be saved." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|DisabledFTACheckBox|Do not include file type associations in this client connection." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|SaveButton|Save window settings for next time." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|ResetButton|Reset window settings to defaults." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|CancelEditButton|Close and return to the main window." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|CreateButton|Create the client connection and choose where to save it." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|UseRDGatewayCheckBox|Use a Remote Desktop Gateway to connect to the host." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|AttemptDirectCheckBox|Try a direct connection first, if that fails then use the Remote Desktop Gateway." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|ShortcutTagCheckBox|Append some text to the end of each shortcut title." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|PerMachineRadioButton|Should the shortcuts install for all users (per-machine), or only for the logged in user (per user)?" & vbCrLf
        Tips += "RemoteAppCreateClientConnection|PerUserRadioButton|Should the shortcuts install for all users (per-machine), or only for the logged in user (per user)?" & vbCrLf
        Tips += "RemoteAppCreateClientConnection|CheckBoxSignRDPEnabled|Digitally sign the RDP file." & vbCrLf
        Tips += "RemoteAppCreateClientConnection|CheckBoxCreateSignedAndUnsigned|Produce both a signed and unsigned copy of the RDP file." & vbCrLf

        Tips += "RemoteAppFileTypeAssociation|CreateButton|Create a new File Type Association." & vbCrLf
        Tips += "RemoteAppFileTypeAssociation|DeleteButton|Delete selected File Type Association." & vbCrLf
        Tips += "RemoteAppFileTypeAssociation|EditButton|Change icon of selected File Type Association." & vbCrLf
        Tips += "RemoteAppFileTypeAssociation|SetAssociationButton|Create or remove the selected File Type Association on the current system." & vbCrLf
        Tips += "RemoteAppFileTypeAssociation|CloseButton|Save changes and close." & vbCrLf

        Tips += "RemoteAppIconPicker|BrowseButton|Browse for a file that contains icons." & vbCrLf
        Tips += "RemoteAppIconPicker|CancelEditButton|Discard changes and close." & vbCrLf
        Tips += "RemoteAppIconPicker|OKButton|Choose the selected icon." & vbCrLf

        Return Tips
    End Function

End Module
