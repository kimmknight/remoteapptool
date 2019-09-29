Module RDP2MSI

    Sub Main()
        Dim cmdRdpPath = ""
        Dim cmdSwitches = ""

        LogText("RDP2MSI" & vbCrLf)
        If My.Application.CommandLineArgs.Count = 0 Then
            ShowUsage()
            End
        ElseIf My.Application.CommandLineArgs.Count = 1 Then
            cmdRdpPath = My.Application.CommandLineArgs(0)
        ElseIf My.Application.CommandLineArgs.Count = 2 Then
            If My.Application.CommandLineArgs(0).StartsWith("/") Then
                cmdSwitches = My.Application.CommandLineArgs(0)
                cmdRdpPath = My.Application.CommandLineArgs(1)
            Else
                cmdSwitches = My.Application.CommandLineArgs(1)
                cmdRdpPath = My.Application.CommandLineArgs(0)
            End If
        ElseIf My.Application.CommandLineArgs.Count > 2 Then
            LogText("Error: Too many parameters provided.", True)
        End If

        Dim relCmdRdpPath = System.IO.Directory.GetCurrentDirectory & "\" & cmdRdpPath
        If Not cmdRdpPath.Contains(":") Then cmdRdpPath = relCmdRdpPath

        If Not My.Computer.FileSystem.FileExists(cmdRdpPath) Then LogText("Error: Unable to find RDP file: " & cmdRdpPath, True)

        If Not cmdSwitches.ToUpper.Contains("D") Then
            If Not cmdSwitches.ToUpper.Contains("S") Then
                cmdSwitches += "DS"
            End If
        End If


        PrepareRDP2MSI(cmdRdpPath, cmdSwitches.ToUpper)
    End Sub

    Sub ShowUsage()
        LogText("Usage: rdp2msi.exe [/DSNATU] rdpfile.rdp")
        LogText("")
        LogText("Switches:")
        LogText("")
        LogText("  /D     MSI will deploy desktop shortcut.")
        LogText("  /S     MSI will deploy shortcut in Start Menu > Programs > (AppName)")
        LogText("  /N     Requires /S. MSI will not create subfolder in Start Menu > Programs.")
        LogText("  /A     Generate upgrade code based on app name. By default, it is random.")
        LogText("  /T     Do not include the (remote) tag on deployed shortcuts.")
        LogText("  /U     MSI installs per-user. By default, MSI will install per-machine.")
        LogText("")
        LogText("If no switches are specified, /DS is implied.")
        LogText("")
        LogText("If an ICO file with the same name as the RDP file exists, it will be used.")
        LogText("")
    End Sub

    Private Sub PrepareRDP2MSI(rdpFilePath As String, Optional cmdSwitches As String = "DS")
        If Not My.Computer.FileSystem.FileExists(rdpFilePath) Then LogText("Error: Unable to find RDP file: " & rdpFilePath, True)
        If Not rdpFilePath.ToLower.EndsWith(".rdp") Then LogText("Error: Input file must be an RDP file.", True)

        Dim RDP As New RDP2MSIlib.RDP
        RDP.rdpPath = rdpFilePath

        If Not RDP.WixInstalled Then LogText("Error: WiX Toolset not found. If you have just installed it, please reboot and try again.", True)

        LogText("RDP file: " & rdpFilePath)
        Dim RemoteAppFullName = RDP.ReadRDPProperty("remoteapplicationname")
        Dim RDPFullAddress = RDP.ReadRDPProperty("full address")
        If RDPFullAddress = "" Then LogText("Error: RDP file does not contain a Remote Desktop Server address.", True)
        If RemoteAppFullName = "" Then
            'Full desktop connection
            LogText("RDP file type: Full desktop session")
        Else
            'RemoteApp connection
            LogText("RDP file type: RemoteApp")
            LogText("App full name: " & RemoteAppFullName)
        End If
        LogText("Command line switches: " & cmdSwitches.ToUpper)


        RDP.ShortcutInStart = cmdSwitches.Contains("S")
        RDP.ShortcutOnDesktop = cmdSwitches.Contains("D")
        RDP.ShortcutSubfolderInStart = Not cmdSwitches.Contains("N")
        Dim ShortcutLocations As New List(Of String)
        If RDP.ShortcutInStart Then
            If RDP.ShortcutSubfolderInStart Then
                ShortcutLocations.Add("Start menu (subfolder)")
            Else
                ShortcutLocations.Add("Start menu (top level)")
            End If
        End If
        If RDP.ShortcutOnDesktop Then ShortcutLocations.Add("Desktop")

        LogText("Shortcut locations: " & String.Join(", ", ShortcutLocations))

        RDP.ProductUpgradeRandom = Not cmdSwitches.Contains("A")
        LogText("MSI upgrade code: {" & RDP.ProductUpgradeCode & "}")
        If cmdSwitches.Contains("T") Then RDP.ProductRemoteTag = ""

        RDP.PerUser = cmdSwitches.Contains("U")
        If RDP.PerUser Then
            LogText("MSI install context: User")
        Else
            LogText("MSI install context: Machine")
        End If

        Dim ShortcutTag = "NONE"
        If Not RDP.ProductRemoteTag = "" Then ShortcutTag = "(" & RDP.ProductRemoteTag & ")"
        LogText("Shortcut tag: " & ShortcutTag)

        LogText("")
        LogText("Generating MSI...")

        RDP.CreateMSI()



    End Sub


    Private Sub LogText(TheText As String, Optional DoExit As Boolean = False)
        Console.WriteLine(TheText)
        If DoExit = True Then
            'CleanupTempFiles()
            End
        End If
    End Sub

End Module


