Public Class RDPOptionsWindow

    ' Array to store the all RDP options
    ' Each row represents an RDP option with its name, type, default value, and description
    Dim optionsList As String(,) = {
        {"administrative_session", "administrative session", "i", "0", "Connect to the administrative session of the remote computer.\n\n0 - Do not use the administrative session.\n1 - Connect to the administrative session."},
        {"allow_desktop_composition", "allow desktop composition", "i", "0", "Determines whether desktop composition (needed for Aero) is permitted when you log on to the remote computer.\n\n0 - Disable desktop composition in the remote session.\n1 - Desktop composition is permitted."},
        {"allow_font_smoothing", "allow font smoothing", "i", "0", "Determines whether font smoothing may be used in the remote session.\n\n0 - Disable font smoothing in the remote session.\n1 - Font smoothing is permitted."},
        {"audiocapturemode", "audiocapturemode", "i", "0", "Determines how sounds captured (recorded) on the local computer are handled when you are connected to the remote computer.\n\n0 - Do not capture audio from the local computer.\n1 - Capture audio from the local computer and send to the remote computer."},
        {"audiomode", "audiomode", "i", "0", "Determines how sounds on a remote computer are handled when you are connected to the remote computer.\n\n0 - Play sounds on the local computer.\n1 - Play sounds on the remote computer.\n2 - Do not play sounds."},
        {"audioqualitymode", "audioqualitymode", "i", "0", "Determines the quality of the audio played in the remote session.\n\n0 - Dynamically adjust audio quality based on available bandwidth.\n1 - Always use medium audio quality.\n2 - Always use uncompressed audio quality."},
        {"authentication_level", "authentication level", "i", "2", "Determines what should happen when server authentication fails.\n\n0 - If server authentication fails, connect without giving a warning.\n1 - If server authentication fails, do not connect.\n2 - If server authentication fails, show a warning and allow the user to connect or not.\n3 - Server authentication is not required."},
        {"autoreconnect_max_retries", "autoreconnect max retries", "i", "20", "Determines the maximum number of times the client computer will try to reconnect to the remote computer if the connection is dropped.\n\nNote: The maximum value Remote Desktop can handle is 200."},
        {"autoreconnection_enabled", "autoreconnection enabled", "i", "1", "Determines whether the client computer will automatically try to reconnect to the remote computer if the connection is dropped.\n\n0 - Do not attempt to reconnect.\n1 - Attempt to reconnect."},
        {"bandwidthautodetect", "bandwidthautodetect", "i", "1", "Enables the option for automatic detection of the network type. Used in conjunction with networkautodetect. Also see connection type.\n\n0 - Do not enable the option for automatic network detection.\n1 - Enable the option for automatic network detection."},
        {"bitmapcachepersistenable", "bitmapcachepersistenable", "i", "1", "Determines whether bitmaps are cached on the local computer (disk-based cache). Bitmap caching can improve the performance of your remote session.\n\n0 - Do not cache bitmaps.\n1 - Cache bitmaps."},
        {"bitmapcachesize", "bitmapcachesize", "i", "1500", "Specifies the size in kilobytes of the memory-based bitmap cache. The maximum value is 32000."},
        {"camerastoredirect", "camerastoredirect", "s", "", "Configures which cameras to redirect. This setting uses a semicolon-delimited list of KSCATEGORY_VIDEO_CAMERA interfaces of cameras enabled for redirection."},
        {"compression", "compression", "i", "1", "Determines whether the connection should use bulk compression.\n\n0 - Do not use bulk compression.\n1 - Use bulk compression."},
        {"connection_type", "connection type", "i", "2", "Specifies pre-defined performance settings for the Remote Desktop session.\n\n1 - Modem (56 Kbps).\n2 - Low-speed broadband (256 Kbps - 2 Mbps).\n3 - Satellite (2 Mbps - 16 Mbps with high latency).\n4 - High-speed broadband (2 Mbps - 10 Mbps).\n5 - WAN (10 Mbps or higher with high latency).\n6 - LAN (10 Mbps or higher).\n7 - Automatic bandwidth detection. Requires bandwidthautodetect.\n\nBy itself, this setting does nothing. When selected in the RDC GUI, this option changes several performance related settings (themes, animation, font smoothing, etcetera). These separate settings always overrule the connection type setting."},
        {"desktopheight", "desktopheight", "i", "600", "The height (in pixels) of the remote session desktop."},
        {"desktop_size_id", "desktop size id", "i", "0", "Specifies pre-defined dimensions of the remote session desktop.\n\n0 - 640x480.\n1 - 800x600.\n2 - 1024x768.\n3 - 1280x1024.\n4 - 1600x1200.\n\nThis setting is ignored when either /w and /h, or desktopwidth and desktopheight are already specified."},
        {"desktopwidth", "desktopwidth", "i", "800", "The width (in pixels) of the remote session desktop."},
        {"devicestoredirect", "devicestoredirect", "s", "", "Determines which supported Plug and Play devices on the client computer will be redirected and available in the remote session.\n\nNo value specified - Do not redirect any supported Plug and Play devices.\n* - Redirect all supported Plug and Play devices, including ones that are connected later.\nDynamicDevices - Redirect any supported Plug and Play devices that are connected later.\nThe hardware ID for one or more Plug and Play devices - Redirect the specified supported Plug and Play device(s)."},
        {"disable_ctrl_alt_del", "disable ctrl+alt+del", "i", "1", "Determines whether you have to press CTRL+ALT+DELETE before entering credentials after you are connected to the remote computer.\n\n0 - CTRL+ALT+DELETE is required before logging in.\n1 - CTRL+ALT+DELETE is not required. You can logon immediately.\n\nNote: When disabled, this setting will also delay the autologin until the user has pressed CTRL+ALT+DELETE."},
        {"disable_full_window_drag", "disable full window drag", "i", "1", "Determines whether window content is displayed when you drag the window to a new location.\n\n0 - Show the contents of the window while dragging.\n1 - Show an outline of the window while dragging."},
        {"disable_menu_anims", "disable menu anims", "i", "1", "Determines whether menus and windows can be displayed with animation effects in the remote session.\n\n0 - Menu and window animation is permitted.\n1 - No menu and window animation."},
        {"disable_themes", "disable themes", "i", "0", "Determines whether themes are permitted when you log on to the remote computer.\n\n0 - Themes are permitted.\n1 - Disable theme in the remote session."},
        {"disable_wallpaper", "disable wallpaper", "i", "1", "Determines whether the desktop background is displayed in the remote session.\n\n0 - Display the wallpaper.\n1 - Do not show any wallpaper."},
        {"disableconnectionsharing", "disableconnectionsharing", "i", "0", "Determines whether a new Terminal Server session is started with every launch of a RemoteApp to the same computer and with the same credentials.\n\n0 - No new session is started. The currently active session of the user is shared.\n1 - A new login session is started for the RemoteApp."},
        {"disableremoteappcapscheck", "disableremoteappcapscheck", "i", "0", "Specifies whether the Remote Desktop client should check the remote computer for RemoteApp capabilities.\n\n0 - Check the remote computer for RemoteApp capabilities before logging in.\n1 - Do not check the remote computer for RemoteApp capabilities.\n\nNote: This setting must be set to 1 when connecting to Windows XP SP3, Vista or 7 computers with RemoteApps configured on them."},
        {"displayconnectionbar", "displayconnectionbar", "i", "1", "Determines whether the connection bar appears when you are in full screen mode.\n\n0 - Do not show the connection bar.\n1 - Show the connection bar."},
        {"domain", "domain", "s", "", "Specifies the name of the domain of the user."},
        {"drivestoredirect", "drivestoredirect", "s", "", "Determines which local disk drives on the client computer will be redirected and available in the remote session.\n\nNo value specified - Do not redirect any drives.\n* - Redirect all disk drives, including drives that are connected later.\nDynamicDrives - Redirect any drives that are connected later.\nThe drive and labels for one or more drives - Redirect the specified drive(s)."},
        {"enablecredsspsupport", "enablecredsspsupport", "i", "1", "Determines whether Remote Desktop will use CredSSP for authentication if it's available.\n\n0 - Do not use CredSSP, even if the operating system supports it.\n1 - Use CredSSP, if the operating system supports it."},
        {"enablesuperpan", "enablesuperpan", "i", "0", "Determines whether SuperPan is enabled or disabled. SuperPan allows the user to navigate a remote desktop in full-screen mode without scroll bars, when the dimensions of the remote desktop are larger than the dimensions of the current client window. The user can point to the window border, and the desktop view will scroll automatically in that direction.\n\n0 - Do not use SuperPan. The remote session window is sized to the client window size.\n1 - Enable SuperPan. The remote session window is sized to the dimensions specified through /w and /h, or through desktopwidth and desktopheight."},
        {"encode_redirected_video_capture", "encode redirected video capture", "i", "1", "Enables or disables encoding of redirected video.\n\n0 - Disable encoding of redirected video.\n\n1 - Enable encoding of redirected video."},
        {"gatewaycredentialssource", "gatewaycredentialssource", "i", "4", "Specifies the credentials that should be used to validate the connection with the RD Gateway.\n\n0 - Ask for password (NTLM).\n1 - Use smart card.\n4 - Allow user to select later."},
        {"keyboardhook", "keyboardhook", "i", "2", "Determines how Windows key combinations are applied when you are connected to a remote computer.\n\n0 - Windows key combinations are applied on the local computer.\n1 - Windows key combinations are applied on the remote computer.\n2 - Windows key combinations are applied in full-screen mode only."},
        {"negotiate_security_layer", "negotiate security layer", "i", "1", "Determines whether the level of security is negotiated or not.\n\n0 - Security layer negotiation is not enabled and the session is started by using Secure Sockets Layer (SSL).\n1 - Security layer negotiation is enabled and the session is started by using x.224 encryption."},
        {"networkautodetect", "networkautodetect", "i", "1", "Determines whether to use automatic network bandwidth detection or not. Requires the option bandwidthautodetect to be set and correlates with connection type 7.\n\n0 - Use automatic network bandwitdh detection.\n1 - Do not use automatic network bandwitdh detection."},
        {"pinconnectionbar", "pinconnectionbar", "i", "1", "Determines whether or not the connection bar should be pinned to the top of the remote session upon connection when in full screen mode.\n\n0 - The connection bar should not be pinned to the top of the remote session.\n1 - The connection bar should be pinned to the top of the remote session."},
        {"prompt_for_credentials", "prompt for credentials", "i", "0", "Determines whether Remote Desktop Connection will prompt for credentials when connecting to a remote computer for which the credentials have been previously saved.\n\n0 - Remote Desktop will use the saved credentials and will not prompt for credentials.\n1 - Remote Desktop will prompt for credentials."},
        {"prompt_for_credentials_on_client", "prompt for credentials on client", "i", "0", "Determines whether Remote Desktop Connection will prompt for credentials when connecting to a server that does not support server authentication.\n\n0 - Remote Desktop will not prompt for credentials.\n1 - Remote Desktop will prompt for credentials."},
        {"promptcredentialonce", "promptcredentialonce", "i", "1", "When connecting through an RD Gateway, determines whether RDC should use the same credentials for both the RD Gateway and the remote computer.\n\n0 - Remote Desktop will not use the same credentials .\n1 - Remote Desktop will use the same credentials for both the RD gateway and the remote computer."},
        {"public_mode", "public mode", "i", "0", "Determines whether Remote Desktop Connection will be started in public mode.\n\n0 - Remote Desktop will not start in public mode .\n1 - Remote Desktop will start in public mode and will not save any user data (credentials, bitmap cache, MRU) on the local machine."},
        {"redirected_video_capture_encoding_quality", "redirected video capture encoding quality", "i", "0", "Controls the quality of encoded video.\n\n0 - High compression video. Quality may suffer when there's a lot of motion.\n1 - Medium compression.\n2 - Low compression video with high picture quality."},
        {"redirectclipboard", "redirectclipboard", "i", "1", "Determines whether the clipboard on the client computer will be redirected and available in the remote session and vice versa.\n\n0 - Do not redirect the clipboard.\n1 - Redirect the clipboard."},
        {"redirectcomports", "redirectcomports", "i", "0", "Determines whether the COM (serial) ports on the client computer will be redirected and available in the remote session.\n\n0 - The COM ports on the local computer are not available in the remote session.\n1 - The COM ports on the local computer are available in the remote session."},
        {"redirectdirectx", "redirectdirectx", "i", "1", "Determines whether DirectX will be enabled for the remote session.\n\n0 - Do not enable DirectX rendering.\n1 - Enable DirectX rendering in the remote session."},
        {"redirectlocation", "redirectlocation", "i", "0", "Determines whether the location of the local device will be redirected and available in the remote session.\n\n0 - The remote session uses the location of the remote computer.\n1 - The remote session uses the location of the local device."},
        {"redirectposdevices", "redirectposdevices", "i", "0", "Determines whether Microsoft Point of Service (POS) for .NET devices connected to the client computer will be redirected and available in the remote session.\n\n0 - The POS devices from the local computer are not available in the remote session.\n1 - The POS devices from the local computer are available in the remote session."},
        {"redirectprinters", "redirectprinters", "i", "1", "Determines whether printers configured on the client computer will be redirected and available in the remote session.\n\n0 - The printers on the local computer are not available in the remote session.\n1 - The printers on the local computer are available in the remote session."},
        {"redirectsmartcards", "redirectsmartcards", "i", "1", "Determines whether smart card devices on the client computer will be redirected and available in the remote session.\n\n0 - The smart card device on the local computer is not available in the remote session.\n1 - The smart card device on the local computer is available in the remote session."},
        {"redirectwebauthn", "redirectwebauthn", "i", "1", "Determines whether WebAuthn requests on the remote computer will be redirected to the local computer allowing the use of local authenticators (such as Windows Hello for Business and security key).\n\n0 - WebAuthn requests from the remote session aren't sent to the local computer for authentication and must be completed in the remote session.\n1 - WebAuthn requests from the remote session are sent to the local computer for authentication."},
        {"remoteapplicationfile", "remoteapplicationfile", "s", "", "Specifies a file to be opened on the remote computer by the RemoteApp.\n\nNote: For local files to be opened, you must also enable drive redirection for (at least) the source drive."},
        {"remoteapplicationexpandcmdline", "remoteapplicationexpandcmdline", "i", "1", "Determines whether environment variables contained in the RemoteApp command line parameter should be expanded locally or remotely.\n\n0 - Environment variables should be expanded to the values of the local computer.\n1 - Environment variables should be expanded on the remote computer to the values of the remote computer."},
        {"remoteapplicationexpandworkingdir", "remoteapplicationexpandworkingdir", "i", "0", "Determines whether environment variables contained in the RemoteApp working directory parameter should be expanded locally or remotely.\n\n0 - Environment variables should be expanded to the values of the local computer.\n1 - Environment variables should be expanded on the remote computer to the values of the remote computer.\n\nNote: The RemoteApp working directory is specified through the shell working directory parameter."},
        {"remoteapplicationicon", "remoteapplicationicon", "s", "", "Specifies the file name of an icon file to be displayed in the Remote Desktop interface while starting the RemoteApp. By default RDC will show the standard Remote Desktop icon.\n\nNote: Only .ico files are supported."},
        {"screen_mode_id", "screen mode id", "i", "2", "Determines whether the remote session window appears full screen when you connect to the remote computer.\n\n1 - The remote session will appear in a window.\n2 - The remote session will appear full screen."},
        {"selectedmonitors", "selectedmonitors", "s", "", "Specifies which local displays to use for the remote session. The selected displays must be contiguous. Requires use multimon to be set to 1.\n\nComma separated list of machine-specific display IDs. You can retrieve IDs by calling mstsc.exe /l. The first ID listed will be set as the primary display in the session. Defaults to all displays."},
        {"session_bpp", "session bpp", "i", "32", "Determines the color depth (in bits) on the remote computer when you connect.\n\n8 - 256 colors (8 bit).\n15 - High color (15 bit).\n16 - High color (16 bit).\n24 - True color (24 bit).\n32 - Highest quality (32 bit)."},
        {"shell_working_directory", "shell working directory", "s", "", "The working directory on the remote computer to be used if an alternate shell is specified."},
        {"signscope", "signscope", "s", "", "Comma-delimited list of .rdp file settings for which the signature is generated when using .rdp file signing."},
        {"smart_sizing", "smart sizing", "i", "0", "Determines whether the client computer should scale the content on the remote computer to fit the window size of the client computer when the window is resized.\n\n0 - The client window display will not be scaled when resized.\n1 - The client window display will be scaled when resized."},
        {"span_monitors", "span monitors", "i", "0", "Determines whether the remote session window will be spanned across multiple monitors when you connect to the remote computer.\n\n0 - Monitor spanning is not enabled.\n1 - Monitor spanning is enabled.\n\nNote: When using Remote Desktop Connection 7 (Windows 7/2008), the use multimon setting is recommended."},
        {"superpanaccelerationfactor", "superpanaccelerationfactor", "i", "1", "Specifies the number of pixels that the screen view scrolls in a given direction for every pixel of mouse movement by the client when in SuperPan mode"},
        {"usbdevicestoredirect", "usbdevicestoredirect", "s", "", "Determines which supported RemoteFX USB devices on the client computer will be redirected and available in the remote session when you connect to a remote session that supports RemoteFX USB redirection.\n\nNo value specified - Do not redirect any supported RemoteFX USB devices.\n* - Redirect all supported RemoteFX USB devices for redirection that are not redirected by high-level redirection mechanisms.\n{Device Setup Class GUID} - Redirect all supported RemoteFX USB devices that are members of the specified device setup class.\nUSB\InstanceID - Redirect the supported RemoteFX USB device specified by the given instance ID.\n-USB\InstanceID - Do not redirect the supported RemoteFX USB device specified by the given instance ID, even if the device is in a device setup class that is redirected.."},
        {"use_multimon", "use multimon", "i", "0", "Determines whether the session should use true multiple monitor support when connecting to the remote computer.\n\n0 - Do not enable multiple monitor support.\n1 - Enable multiple monitor support."},
        {"username", "username", "s", "", "Specifies the name of the user account that will be used to log on to the remote computer."},
        {"videoplaybackmode", "videoplaybackmode", "i", "1", "Determines whether RDC will use RDP efficient multimedia streaming for video playback.\n\n0 - Do not use RDP efficient multimedia streaming for video playback.\n1 - Use RDP efficient multimedia streaming for video playback when possible."},
        {"winposstr", "winposstr", "s", "0,3,0,0,800,600", "Specifies the position and dimensions of the session window on the client computer."},
        {"workspaceid", "workspaceid", "s", "", "This setting defines the RemoteApp and Desktop ID associated with the RDP file that contains this setting."}
    }

    ' Array to store recommended default options
    Public RecommendedDefaultOptions As String(,) = {
        {"disableremoteappcapscheck", "disableremoteappcapscheck", "i", "1"},
        {"drivestoredirect", "drivestoredirect", "s", "*"},
        {"prompt_for_credentials", "prompt for credentials", "i", "1"},
        {"promptcredentialonce", "promptcredentialonce", "i", "0"},
        {"redirectcomports", "redirectcomports", "i", "1"},
        {"span_monitors", "span monitors", "i", "1"},
        {"use_multimon", "use multimon", "i", "1"}
    }

    ' Array to store changed options during editing
    Dim changedOptions As String(,)

    ' Index of the currently selected row in the OptionsListBox
    Dim selectedRow As Integer = 0

    ' Copy the original options to the changedOptions array
    Private Sub CopyOptions()
        changedOptions = New String(optionsList.GetLength(0) - 1, optionsList.GetLength(1) - 1) {}
        Array.Copy(optionsList, changedOptions, optionsList.Length)
    End Sub

    ' Main function that prepares and opens the window (to be called from elsewhere)
    Public Function EditAdditionalOptions(additionalOptions As String(,))
        ' Copy options, load additional options, and update the changed options
        CopyOptions()
        LoadAdditionalOptions(additionalOptions)
        UpdateChangedOptions()

        ' Load options into the OptionsListBox
        OptionsListBox.Items.Clear()
        For row As Integer = 0 To optionsList.GetLength(0) - 1
            OptionsListBox.Items.Add(optionsList(row, 1))
        Next

        ' Set the selected item in OptionsListBox and load the selected option
        OptionsListBox.SelectedIndex = selectedRow
        LoadSelected()

        ' Show the form
        ShowDialog()

        ' Export saved options and return the result
        Dim SavedOptions As String(,) = ExportSavedOptionsAsArray()
        Return SavedOptions

        ' Dispose of the form
        Dispose()
    End Function

    ' Load additional options and update the changed options array
    Private Sub LoadAdditionalOptions(additionalOptions As String(,))
        If additionalOptions.Length > 1 Then
            For row As Integer = 0 To optionsList.GetLength(0) - 1
                For additionalOptionRow As Integer = 0 To additionalOptions.GetLength(0) - 1
                    If optionsList(row, 1) = additionalOptions(additionalOptionRow, 1) Then
                        changedOptions(row, 3) = additionalOptions(additionalOptionRow, 3)
                    End If
                Next
            Next
        End If
    End Sub

    ' Handle the selection change in OptionsListBox
    Private Sub OptionsListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OptionsListBox.SelectedIndexChanged
        If OptionsListBox.SelectedItems.Count = 1 Then
            selectedRow = OptionsListBox.SelectedIndex
            LoadSelected()
        End If
    End Sub

    ' Load the details of the selected option into the description and value textboxes
    Private Sub LoadSelected()
        Dim descriptionText = "# " & optionsList(selectedRow, 1) & vbCrLf & vbCrLf
        descriptionText = descriptionText & optionsList(selectedRow, 4).Replace("\n", vbCrLf)
        Dim valueText = changedOptions(selectedRow, 3)

        If optionsList(selectedRow, 3) <> "" Then
            descriptionText = descriptionText & vbCrLf & vbCrLf & "Default: " & optionsList(selectedRow, 3)
        End If

        DescriptionTextBox.Text = descriptionText
        ValueTextBox.Text = valueText
    End Sub

    ' Handle the change in the value textbox
    Private Sub ValueTextBox_TextChanged(sender As Object, e As EventArgs) Handles ValueTextBox.TextChanged
        If changedOptions(selectedRow, 3) <> ValueTextBox.Text Then
            changedOptions(selectedRow, 3) = ValueTextBox.Text
            UpdateChangedOptions()
        End If
    End Sub

    ' Update the ChangedOptionsListView with any changes
    Private Sub UpdateChangedOptions()
        ChangedOptionsListView.Items.Clear()

        For row As Integer = 0 To optionsList.GetLength(0) - 1
            If optionsList(row, 3) <> changedOptions(row, 3) Then
                Dim newItem As ListViewItem = ChangedOptionsListView.Items.Add(changedOptions(row, 1))
                newItem.SubItems.Add(changedOptions(row, 2))
                newItem.SubItems.Add(changedOptions(row, 3))
            End If
        Next
    End Sub

    ' Export only the modified options as an array
    Private Function ExportSavedOptionsAsArray()
        Dim selectedIndicesList As New List(Of Integer)

        For row As Integer = 0 To optionsList.GetLength(0) - 1
            If optionsList(row, 3) <> changedOptions(row, 3) Then
                selectedIndicesList.Add(row)
            End If
        Next

        Dim selectedIndices() As Integer = selectedIndicesList.ToArray()

        Dim changedOptionsNoDesc As String(,) = RemoveDescriptions(changedOptions)
        Return SelectRows(changedOptionsNoDesc, selectedIndices)
    End Function

    ' Select specific rows from the array
    Function SelectRows(originalArray As String(,), selectedIndices() As Integer) As String(,)
        Dim numSelectedRows As Integer = selectedIndices.Length
        Dim numCols As Integer = originalArray.GetLength(1)

        ' Create a new array with the selected rows
        Dim newArray(numSelectedRows - 1, numCols - 1) As String

        ' Copy the selected rows from the original array
        For i As Integer = 0 To numSelectedRows - 1
            Dim rowIndex As Integer = selectedIndices(i)
            For j As Integer = 0 To numCols - 1
                newArray(i, j) = originalArray(rowIndex, j)
            Next
        Next

        Return newArray
    End Function

    ' Remove descriptions from the array
    Function RemoveDescriptions(originalArray(,) As String) As String(,)
        Dim numRows As Integer = originalArray.GetLength(0)
        Dim numColumns As Integer = Math.Min(originalArray.GetLength(1), 4)

        Dim newArray(numRows - 1, numColumns - 1) As String

        For i As Integer = 0 To numRows - 1
            For j As Integer = 0 To numColumns - 1
                newArray(i, j) = originalArray(i, j)
            Next
        Next

        Return newArray
    End Function

    ' Handle the Close button being clicked
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Me.Close()
    End Sub

    ' Handles the Reset button being clicked, resets all options to RDP defaults (so they are not active)
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        CopyOptions()
        UpdateChangedOptions()
        LoadSelected()
    End Sub

    ' Handles the Defaults button being clicked, clears all options and adds all recommended default options
    Private Sub DefaultsButton_Click(sender As Object, e As EventArgs) Handles DefaultsButton.Click
        CopyOptions()
        LoadAdditionalOptions(RecommendedDefaultOptions)
        UpdateChangedOptions()
        LoadSelected()
    End Sub

    ' Handles items in the Changed Options ListView being clicked/selected, scrolls to the selected option in the main Options ListBox
    Private Sub ChangedOptionsListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChangedOptionsListView.SelectedIndexChanged
        ScrollToSelectedOption()
        ChangedOptionsListView.Focus()
    End Sub

    ' As above, scrolls to the selected option in the main Options ListBox
    Private Sub ScrollToSelectedOption()
        If ChangedOptionsListView.SelectedItems.Count > 0 Then
            Dim selectedOptionName As String = ChangedOptionsListView.SelectedItems(0).Text
            OptionsListBox.SelectedItem = selectedOptionName
        End If
    End Sub

    Private Sub ResetValueButton_Click(sender As Object, e As EventArgs) Handles ResetValueButton.Click
        If ValueTextBox.Text <> optionsList(selectedRow, 3) Then
            changedOptions(selectedRow, 3) = optionsList(selectedRow, 3)
            LoadSelected()
            UpdateChangedOptions()
        End If
    End Sub
End Class