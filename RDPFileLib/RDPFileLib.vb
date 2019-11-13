Imports System.Windows.Forms
Imports LockChecker

Public Class RDPFile
    Public administrative_session As Integer = 0
    Public allow_desktop_composition As Integer = 0
    Public allow_font_smoothing As Integer = 0
    Public alternate_full_address As String = ""
    Public alternate_shell As String = ""
    Public audiocapturemode As Integer = 0
    Public audiomode As Integer = 0
    Public audioqualitymode As Integer = 0
    Public authentication_level As Integer = 2
    Public autoreconnect_max_retries As Integer = 20
    Public autoreconnection_enabled As Integer = 1
    Public bandwidthautodetect As Integer = 1
    Public bitmapcachepersistenable As Integer = 1
    Public bitmapcachesize As Integer = 1500
    Public compression As Integer = 1
    Public connect_to_console As Integer = 0
    Public connection_type As Integer = 2
    Public desktop_size_id As Integer = 0
    Public desktopheight As Integer = 600
    Public desktopwidth As Integer = 800
    Public devicestoredirect As String = ""
    Public disable_ctrl_alt_del As Integer = 1
    Public disable_full_window_drag As Integer = 1
    Public disable_menu_anims As Integer = 1
    Public disable_themes As Integer = 0
    Public disable_wallpaper As Integer = 1
    Public disableconnectionsharing As Integer = 0
    Public disableremoteappcapscheck As Integer = 0
    Public displayconnectionbar As Integer = 1
    Public domain As String = ""
    Public drivestoredirect As String = ""
    Public enablecredsspsupport As Integer = 1
    Public enablesuperpan As Integer = 0
    Public full_address As String = ""
    Public gatewaycredentialssource As Integer = 4
    Public gatewayhostname As String = ""
    Public gatewayprofileusagemethod As Integer = 0
    Public gatewayusagemethod As Integer = 4
    Public keyboardhook As Integer = 2
    Public negotiate_security_layer As Integer = 1
    Public networkautodetect As Integer = 1
    'Public password_51 As Binary
    Public pinconnectionbar As Integer = 1
    Public prompt_for_credentials As Integer = 0
    Public prompt_for_credentials_on_client As Integer = 0
    Public promptcredentialonce As Integer = 1
    Public public_mode As Integer = 0
    Public redirectclipboard As Integer = 1
    Public redirectcomports As Integer = 0
    Public redirectdirectx As Integer = 1
    Public redirectdrives As Integer = 0
    Public redirectposdevices As Integer = 0
    Public redirectprinters As Integer = 1
    Public redirectsmartcards As Integer = 1
    Public remoteapplicationcmdline As String = ""
    Public remoteapplicationexpandcmdline As Integer = 1
    Public remoteapplicationexpandworkingdir As Integer = 0
    Public remoteapplicationfile As String = ""
    Public remoteapplicationfileextensions As String = ""
    Public remoteapplicationicon As String = ""
    Public remoteapplicationmode As Integer = 0
    Public remoteapplicationname As String = ""
    Public remoteapplicationprogram As String = ""
    Public screen_mode_id As Integer = 2
    Public server_port As Integer = 3389
    Public session_bpp As Integer = 32
    Public shell_working_directory As String = ""
    Public smart_sizing As Integer = 0
    Public span_monitors As Integer = 0
    Public superpanaccelerationfactor As Integer = 1
    Public usbdevicestoredirect As String = ""
    Public use_multimon As Integer = 0
    Public username As String = ""
    Public videoplaybackmode As Integer = 1
    Public winposstr As String = "0,3,0,0,800,600"

    Public Sub SaveRDPfile(FilePath As String, Optional SaveDefaultSettings As Boolean = False)
        Dim LockCheck As New LockChecker.LockChecker()
        Dim FileLocked As String
        Dim SkipFile As Boolean = False
        FileLocked = LockCheck.CheckLock(FilePath)
        While Not (FileLocked = "No locks")
            If (MessageBox.Show("The file " + FilePath + " is currently locked.  Lock information:" + FileLocked + vbNewLine + "Do you want to try again?", "File Locked", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                FileLocked = LockCheck.CheckLock(FilePath)
            Else
                MessageBox.Show("The following file will not be copied:" + vbNewLine + FilePath)
                SkipFile = True
                FileLocked = "No locks"
            End If
        End While
        If Not (SkipFile) Then

            My.Computer.FileSystem.WriteAllText(FilePath, GetRDPstring(SaveDefaultSettings), False)
        End If
    End Sub

    Public Function GetRDPstring(Optional SaveDefaultSettings As Boolean = False)
        Dim RDPstring As String = ""

        Dim DefaultRDP As New RDPFile

        If SaveDefaultSettings Or Not DefaultRDP.administrative_session = administrative_session Then RDPstring += "administrative session" & ":" & administrative_session.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & administrative_session.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.allow_desktop_composition = allow_desktop_composition Then RDPstring += "allow desktop composition" & ":" & allow_desktop_composition.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & allow_desktop_composition.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.allow_font_smoothing = allow_font_smoothing Then RDPstring += "allow font smoothing" & ":" & allow_font_smoothing.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & allow_font_smoothing.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.alternate_full_address = alternate_full_address Then RDPstring += "alternate full address" & ":" & alternate_full_address.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & alternate_full_address.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.alternate_shell = alternate_shell Then RDPstring += "alternate shell" & ":" & alternate_shell.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & alternate_shell.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.audiocapturemode = audiocapturemode Then RDPstring += "audiocapturemode" & ":" & audiocapturemode.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & audiocapturemode.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.audiomode = audiomode Then RDPstring += "audiomode" & ":" & audiomode.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & audiomode.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.audioqualitymode = audioqualitymode Then RDPstring += "audioqualitymode" & ":" & audioqualitymode.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & audioqualitymode.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.authentication_level = authentication_level Then RDPstring += "authentication level" & ":" & authentication_level.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & authentication_level.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.autoreconnect_max_retries = autoreconnect_max_retries Then RDPstring += "autoreconnect max retries" & ":" & autoreconnect_max_retries.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & autoreconnect_max_retries.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.autoreconnection_enabled = autoreconnection_enabled Then RDPstring += "autoreconnection enabled" & ":" & autoreconnection_enabled.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & autoreconnection_enabled.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.bandwidthautodetect = bandwidthautodetect Then RDPstring += "bandwidthautodetect" & ":" & bandwidthautodetect.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & bandwidthautodetect.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.bitmapcachepersistenable = bitmapcachepersistenable Then RDPstring += "bitmapcachepersistenable" & ":" & bitmapcachepersistenable.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & bitmapcachepersistenable.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.bitmapcachesize = bitmapcachesize Then RDPstring += "bitmapcachesize" & ":" & bitmapcachesize.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & bitmapcachesize.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.compression = compression Then RDPstring += "compression" & ":" & compression.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & compression.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.connect_to_console = connect_to_console Then RDPstring += "connect to console" & ":" & connect_to_console.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & connect_to_console.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.connection_type = connection_type Then RDPstring += "connection type" & ":" & connection_type.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & connection_type.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.desktop_size_id = desktop_size_id Then RDPstring += "desktop size id" & ":" & desktop_size_id.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & desktop_size_id.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.desktopheight = desktopheight Then RDPstring += "desktopheight" & ":" & desktopheight.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & desktopheight.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.desktopwidth = desktopwidth Then RDPstring += "desktopwidth" & ":" & desktopwidth.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & desktopwidth.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.devicestoredirect = devicestoredirect Then RDPstring += "devicestoredirect" & ":" & devicestoredirect.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & devicestoredirect.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.disable_ctrl_alt_del = disable_ctrl_alt_del Then RDPstring += "disable ctrl+alt+del" & ":" & disable_ctrl_alt_del.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & disable_ctrl_alt_del.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.disable_full_window_drag = disable_full_window_drag Then RDPstring += "disable full window drag" & ":" & disable_full_window_drag.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & disable_full_window_drag.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.disable_menu_anims = disable_menu_anims Then RDPstring += "disable menu anims" & ":" & disable_menu_anims.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & disable_menu_anims.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.disable_themes = disable_themes Then RDPstring += "disable themes" & ":" & disable_themes.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & disable_themes.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.disable_wallpaper = disable_wallpaper Then RDPstring += "disable wallpaper" & ":" & disable_wallpaper.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & disable_wallpaper.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.disableconnectionsharing = disableconnectionsharing Then RDPstring += "disableconnectionsharing" & ":" & disableconnectionsharing.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & disableconnectionsharing.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.disableremoteappcapscheck = disableremoteappcapscheck Then RDPstring += "disableremoteappcapscheck" & ":" & disableremoteappcapscheck.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & disableremoteappcapscheck.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.displayconnectionbar = displayconnectionbar Then RDPstring += "displayconnectionbar" & ":" & displayconnectionbar.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & displayconnectionbar.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.domain = domain Then RDPstring += "domain" & ":" & domain.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & domain.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.drivestoredirect = drivestoredirect Then RDPstring += "drivestoredirect" & ":" & drivestoredirect.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & drivestoredirect.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.enablecredsspsupport = enablecredsspsupport Then RDPstring += "enablecredsspsupport" & ":" & enablecredsspsupport.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & enablecredsspsupport.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.enablesuperpan = enablesuperpan Then RDPstring += "enablesuperpan" & ":" & enablesuperpan.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & enablesuperpan.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.full_address = full_address Then RDPstring += "full address" & ":" & full_address.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & full_address.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.gatewaycredentialssource = gatewaycredentialssource Then RDPstring += "gatewaycredentialssource" & ":" & gatewaycredentialssource.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & gatewaycredentialssource.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.gatewayhostname = gatewayhostname Then RDPstring += "gatewayhostname" & ":" & gatewayhostname.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & gatewayhostname.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.gatewayprofileusagemethod = gatewayprofileusagemethod Then RDPstring += "gatewayprofileusagemethod" & ":" & gatewayprofileusagemethod.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & gatewayprofileusagemethod.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.gatewayusagemethod = gatewayusagemethod Then RDPstring += "gatewayusagemethod" & ":" & gatewayusagemethod.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & gatewayusagemethod.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.keyboardhook = keyboardhook Then RDPstring += "keyboardhook" & ":" & keyboardhook.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & keyboardhook.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.negotiate_security_layer = negotiate_security_layer Then RDPstring += "negotiate security layer" & ":" & negotiate_security_layer.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & negotiate_security_layer.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.networkautodetect = networkautodetect Then RDPstring += "networkautodetect" & ":" & networkautodetect.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & networkautodetect.ToString & vbCrLf
        'If SaveDefaultSettings Or Not DefaultRDP.password_51 = password_51 Then RDPstring += "password 51" & ":" & password_51.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & password_51.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.pinconnectionbar = pinconnectionbar Then RDPstring += "pinconnectionbar" & ":" & pinconnectionbar.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & pinconnectionbar.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.prompt_for_credentials = prompt_for_credentials Then RDPstring += "prompt for credentials" & ":" & prompt_for_credentials.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & prompt_for_credentials.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.prompt_for_credentials_on_client = prompt_for_credentials_on_client Then RDPstring += "prompt for credentials on client" & ":" & prompt_for_credentials_on_client.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & prompt_for_credentials_on_client.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.promptcredentialonce = promptcredentialonce Then RDPstring += "promptcredentialonce" & ":" & promptcredentialonce.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & promptcredentialonce.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.public_mode = public_mode Then RDPstring += "public mode" & ":" & public_mode.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & public_mode.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.redirectclipboard = redirectclipboard Then RDPstring += "redirectclipboard" & ":" & redirectclipboard.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & redirectclipboard.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.redirectcomports = redirectcomports Then RDPstring += "redirectcomports" & ":" & redirectcomports.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & redirectcomports.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.redirectdirectx = redirectdirectx Then RDPstring += "redirectdirectx" & ":" & redirectdirectx.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & redirectdirectx.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.redirectdrives = redirectdrives Then RDPstring += "redirectdrives" & ":" & redirectdrives.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & redirectdrives.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.redirectposdevices = redirectposdevices Then RDPstring += "redirectposdevices" & ":" & redirectposdevices.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & redirectposdevices.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.redirectprinters = redirectprinters Then RDPstring += "redirectprinters" & ":" & redirectprinters.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & redirectprinters.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.redirectsmartcards = redirectsmartcards Then RDPstring += "redirectsmartcards" & ":" & redirectsmartcards.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & redirectsmartcards.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.remoteapplicationcmdline = remoteapplicationcmdline Then RDPstring += "remoteapplicationcmdline" & ":" & remoteapplicationcmdline.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & remoteapplicationcmdline.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.remoteapplicationexpandcmdline = remoteapplicationexpandcmdline Then RDPstring += "remoteapplicationexpandcmdline" & ":" & remoteapplicationexpandcmdline.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & remoteapplicationexpandcmdline.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.remoteapplicationexpandworkingdir = remoteapplicationexpandworkingdir Then RDPstring += "remoteapplicationexpandworkingdir" & ":" & remoteapplicationexpandworkingdir.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & remoteapplicationexpandworkingdir.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.remoteapplicationfile = remoteapplicationfile Then RDPstring += "remoteapplicationfile" & ":" & remoteapplicationfile.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & remoteapplicationfile.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.remoteapplicationfileextensions = remoteapplicationfileextensions Then RDPstring += "remoteapplicationfileextensions" & ":" & remoteapplicationfileextensions.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & remoteapplicationfileextensions.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.remoteapplicationicon = remoteapplicationicon Then RDPstring += "remoteapplicationicon" & ":" & remoteapplicationicon.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & remoteapplicationicon.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.remoteapplicationmode = remoteapplicationmode Then RDPstring += "remoteapplicationmode" & ":" & remoteapplicationmode.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & remoteapplicationmode.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.remoteapplicationname = remoteapplicationname Then RDPstring += "remoteapplicationname" & ":" & remoteapplicationname.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & remoteapplicationname.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.remoteapplicationprogram = remoteapplicationprogram Then RDPstring += "remoteapplicationprogram" & ":" & remoteapplicationprogram.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & remoteapplicationprogram.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.screen_mode_id = screen_mode_id Then RDPstring += "screen mode id" & ":" & screen_mode_id.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & screen_mode_id.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.server_port = server_port Then RDPstring += "server port" & ":" & server_port.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & server_port.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.session_bpp = session_bpp Then RDPstring += "session bpp" & ":" & session_bpp.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & session_bpp.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.shell_working_directory = shell_working_directory Then RDPstring += "shell working directory" & ":" & shell_working_directory.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & shell_working_directory.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.smart_sizing = smart_sizing Then RDPstring += "smart sizing" & ":" & smart_sizing.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & smart_sizing.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.span_monitors = span_monitors Then RDPstring += "span monitors" & ":" & span_monitors.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & span_monitors.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.superpanaccelerationfactor = superpanaccelerationfactor Then RDPstring += "superpanaccelerationfactor" & ":" & superpanaccelerationfactor.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & superpanaccelerationfactor.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.usbdevicestoredirect = usbdevicestoredirect Then RDPstring += "usbdevicestoredirect" & ":" & usbdevicestoredirect.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & usbdevicestoredirect.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.use_multimon = use_multimon Then RDPstring += "use multimon" & ":" & use_multimon.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & use_multimon.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.username = username Then RDPstring += "username" & ":" & username.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & username.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.videoplaybackmode = videoplaybackmode Then RDPstring += "videoplaybackmode" & ":" & videoplaybackmode.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & videoplaybackmode.ToString & vbCrLf
        If SaveDefaultSettings Or Not DefaultRDP.winposstr = winposstr Then RDPstring += "winposstr" & ":" & winposstr.GetType().ToString.Replace("System.", "").ToLower.Substring(0, 1) & ":" & winposstr.ToString & vbCrLf

        Return RDPstring
    End Function

    Public Sub LoadRDPfile(FilePath As String)
        Dim sr As New System.IO.StreamReader(FilePath)

        While (sr.Peek <> -1)
            Dim line As String = sr.ReadLine
            Dim SplitLine As Array = line.Split(":")

            If Not SplitLine(2) = "" Then
                If SplitLine(0) = "administrative session" Then administrative_session = SplitLine(2)
                If SplitLine(0) = "allow desktop composition" Then allow_desktop_composition = SplitLine(2)
                If SplitLine(0) = "allow font smoothing" Then allow_font_smoothing = SplitLine(2)
                If SplitLine(0) = "alternate full address" Then alternate_full_address = SplitLine(2)
                If SplitLine(0) = "alternate shell" Then alternate_shell = SplitLine(2)
                If SplitLine(0) = "audiocapturemode" Then audiocapturemode = SplitLine(2)
                If SplitLine(0) = "audiomode" Then audiomode = SplitLine(2)
                If SplitLine(0) = "audioqualitymode" Then audioqualitymode = SplitLine(2)
                If SplitLine(0) = "authentication level" Then authentication_level = SplitLine(2)
                If SplitLine(0) = "autoreconnect max retries" Then autoreconnect_max_retries = SplitLine(2)
                If SplitLine(0) = "autoreconnection enabled" Then autoreconnection_enabled = SplitLine(2)
                If SplitLine(0) = "bandwidthautodetect" Then bandwidthautodetect = SplitLine(2)
                If SplitLine(0) = "bitmapcachepersistenable" Then bitmapcachepersistenable = SplitLine(2)
                If SplitLine(0) = "bitmapcachesize" Then bitmapcachesize = SplitLine(2)
                If SplitLine(0) = "compression" Then compression = SplitLine(2)
                If SplitLine(0) = "connect to console" Then connect_to_console = SplitLine(2)
                If SplitLine(0) = "connection type" Then connection_type = SplitLine(2)
                If SplitLine(0) = "desktop size id" Then desktop_size_id = SplitLine(2)
                If SplitLine(0) = "desktopheight" Then desktopheight = SplitLine(2)
                If SplitLine(0) = "desktopwidth" Then desktopwidth = SplitLine(2)
                If SplitLine(0) = "devicestoredirect" Then devicestoredirect = SplitLine(2)
                If SplitLine(0) = "disable ctrl+alt+del" Then disable_ctrl_alt_del = SplitLine(2)
                If SplitLine(0) = "disable full window drag" Then disable_full_window_drag = SplitLine(2)
                If SplitLine(0) = "disable menu anims" Then disable_menu_anims = SplitLine(2)
                If SplitLine(0) = "disable themes" Then disable_themes = SplitLine(2)
                If SplitLine(0) = "disable wallpaper" Then disable_wallpaper = SplitLine(2)
                If SplitLine(0) = "disableconnectionsharing" Then disableconnectionsharing = SplitLine(2)
                If SplitLine(0) = "disableremoteappcapscheck" Then disableremoteappcapscheck = SplitLine(2)
                If SplitLine(0) = "displayconnectionbar" Then displayconnectionbar = SplitLine(2)
                If SplitLine(0) = "domain" Then domain = SplitLine(2)
                If SplitLine(0) = "drivestoredirect" Then drivestoredirect = SplitLine(2)
                If SplitLine(0) = "enablecredsspsupport" Then enablecredsspsupport = SplitLine(2)
                If SplitLine(0) = "enablesuperpan" Then enablesuperpan = SplitLine(2)
                If SplitLine(0) = "full address" Then full_address = SplitLine(2)
                If SplitLine(0) = "gatewaycredentialssource" Then gatewaycredentialssource = SplitLine(2)
                If SplitLine(0) = "gatewayhostname" Then gatewayhostname = SplitLine(2)
                If SplitLine(0) = "gatewayprofileusagemethod" Then gatewayprofileusagemethod = SplitLine(2)
                If SplitLine(0) = "gatewayusagemethod" Then gatewayusagemethod = SplitLine(2)
                If SplitLine(0) = "keyboardhook" Then keyboardhook = SplitLine(2)
                If SplitLine(0) = "negotiate security layer" Then negotiate_security_layer = SplitLine(2)
                If SplitLine(0) = "networkautodetect" Then networkautodetect = SplitLine(2)
                'If SplitLine(0) = "password 51" Then password_51 = SplitLine(2)
                If SplitLine(0) = "pinconnectionbar" Then pinconnectionbar = SplitLine(2)
                If SplitLine(0) = "prompt for credentials" Then prompt_for_credentials = SplitLine(2)
                If SplitLine(0) = "prompt for credentials on client" Then prompt_for_credentials_on_client = SplitLine(2)
                If SplitLine(0) = "promptcredentialonce" Then promptcredentialonce = SplitLine(2)
                If SplitLine(0) = "public mode" Then public_mode = SplitLine(2)
                If SplitLine(0) = "redirectclipboard" Then redirectclipboard = SplitLine(2)
                If SplitLine(0) = "redirectcomports" Then redirectcomports = SplitLine(2)
                If SplitLine(0) = "redirectdirectx" Then redirectdirectx = SplitLine(2)
                If SplitLine(0) = "redirectdrives" Then redirectdrives = SplitLine(2)
                If SplitLine(0) = "redirectposdevices" Then redirectposdevices = SplitLine(2)
                If SplitLine(0) = "redirectprinters" Then redirectprinters = SplitLine(2)
                If SplitLine(0) = "redirectsmartcards" Then redirectsmartcards = SplitLine(2)
                If SplitLine(0) = "remoteapplicationcmdline" Then remoteapplicationcmdline = SplitLine(2)
                If SplitLine(0) = "remoteapplicationexpandcmdline" Then remoteapplicationexpandcmdline = SplitLine(2)
                If SplitLine(0) = "remoteapplicationexpandworkingdir" Then remoteapplicationexpandworkingdir = SplitLine(2)
                If SplitLine(0) = "remoteapplicationfile" Then remoteapplicationfile = SplitLine(2)
                If SplitLine(0) = "remoteapplicationfileextensions" Then remoteapplicationfileextensions = SplitLine(2)
                If SplitLine(0) = "remoteapplicationicon" Then remoteapplicationicon = SplitLine(2)
                If SplitLine(0) = "remoteapplicationmode" Then remoteapplicationmode = SplitLine(2)
                If SplitLine(0) = "remoteapplicationname" Then remoteapplicationname = SplitLine(2)
                If SplitLine(0) = "remoteapplicationprogram" Then remoteapplicationprogram = SplitLine(2)
                If SplitLine(0) = "screen mode id" Then screen_mode_id = SplitLine(2)
                If SplitLine(0) = "server port" Then server_port = SplitLine(2)
                If SplitLine(0) = "session bpp" Then session_bpp = SplitLine(2)
                If SplitLine(0) = "shell working directory" Then shell_working_directory = SplitLine(2)
                If SplitLine(0) = "smart sizing" Then smart_sizing = SplitLine(2)
                If SplitLine(0) = "span monitors" Then span_monitors = SplitLine(2)
                If SplitLine(0) = "superpanaccelerationfactor" Then superpanaccelerationfactor = SplitLine(2)
                If SplitLine(0) = "usbdevicestoredirect" Then usbdevicestoredirect = SplitLine(2)
                If SplitLine(0) = "use multimon" Then use_multimon = SplitLine(2)
                If SplitLine(0) = "username" Then username = SplitLine(2)
                If SplitLine(0) = "videoplaybackmode" Then videoplaybackmode = SplitLine(2)
                If SplitLine(0) = "winposstr" Then winposstr = SplitLine(2)

            End If

        End While
    End Sub

End Class
