Public Class RemoteAppHostOptions

    Private Sub DisconnectTimeTextBox_TextChanged(sender As Object, e As EventArgs) Handles DisconnectTimeTextBox.TextChanged
        ValidateSeconds(Me.DisconnectTimeTextBox)
    End Sub

    Private Sub IdleTimeTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdleTimeTextBox.TextChanged
        ValidateSeconds(Me.IdleTimeTextBox)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim PolicyKeyStringMS = "SOFTWARE\Policies\Microsoft"
        Dim PolicyKeyString = "SOFTWARE\Policies\Microsoft\Windows NT\Terminal Services"
        Dim PolicyKey As Microsoft.Win32.RegistryKey

        'Create policy reg keys
        Dim PolicyKeyMS = My.Computer.Registry.LocalMachine.OpenSubKey(PolicyKeyStringMS, True)
        Dim PolicyKeyWNT = PolicyKeyMS.CreateSubKey("Windows NT")
        Dim PolicyKeyTS = PolicyKeyWNT.CreateSubKey("Terminal Services")

        PolicyKey = My.Computer.Registry.LocalMachine.OpenSubKey(PolicyKeyString, True)
            
        If Me.DisableAllowListCheckBox.Checked Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList", "fDisabledAllowList", "1", Microsoft.Win32.RegistryValueKind.DWord)
        Else
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList", "fDisabledAllowList", "0", Microsoft.Win32.RegistryValueKind.DWord)
        End If

        If Me.AllowUnlistedRemoteProgramsCheckBox.Checked Then
            PolicyKey.SetValue("fAllowUnlistedRemotePrograms", 1, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            PolicyKey.DeleteValue("fAllowUnlistedRemotePrograms", False)
        End If

        If Me.TimeoutDisconnectedCheckBox.Checked Then
            PolicyKey.SetValue("MaxDisconnectionTime", Val(DisconnectTimeTextBox.Text) * 1000, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            PolicyKey.DeleteValue("MaxDisconnectionTime", False)
        End If

        If Me.TimeoutIdleCheckBox.Checked Then
            PolicyKey.SetValue("MaxIdleTime", Val(IdleTimeTextBox.Text) * 1000, Microsoft.Win32.RegistryValueKind.DWord)
        Else
            PolicyKey.DeleteValue("MaxIdleTime", False)
        End If

        If Me.LogoffWhenTimoutCheckBox.Checked Then
            PolicyKey.SetValue("fResetBroken", "1", Microsoft.Win32.RegistryValueKind.DWord)
        Else
            PolicyKey.DeleteValue("fResetBroken", False)
        End If

        Me.Close()

    End Sub

    Public Sub SetValues()
        On Error Resume Next

        Dim PolicyKeyString = "SOFTWARE\Policies\Microsoft\Windows NT\Terminal Services"
        Dim PolicyKey = My.Computer.Registry.LocalMachine.OpenSubKey(PolicyKeyString, False)

        Me.DisconnectTimeTextBox.Text = "0"
        Me.IdleTimeTextBox.Text = "0"

        If Val(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Terminal Server\TSAppAllowList", "fDisabledAllowList", "")) = 1 Then
            Me.DisableAllowListCheckBox.Checked = True
        Else
            Me.DisableAllowListCheckBox.Checked = False
        End If

        Dim MaxDisconnectionTime = -1
        MaxDisconnectionTime = PolicyKey.GetValue("MaxDisconnectionTime", -1)
        If Not MaxDisconnectionTime = -1 Then
            Me.TimeoutDisconnectedCheckBox.Checked = True
            Me.DisconnectTimeTextBox.Text = MaxDisconnectionTime / 1000
        Else
            Me.TimeoutDisconnectedCheckBox.Checked = False
        End If

        Dim MaxIdleTime = -1
        MaxIdleTime = PolicyKey.GetValue("MaxIdleTime", -1)
        If Not MaxIdleTime = -1 Then
            Me.TimeoutIdleCheckBox.Checked = True
            Me.IdleTimeTextBox.Text = MaxIdleTime / 1000
        Else
            Me.TimeoutIdleCheckBox.Checked = False
        End If

        Dim fResetBroken = PolicyKey.GetValue("fResetBroken")
        If Not fResetBroken = Nothing Then
            Me.LogoffWhenTimoutCheckBox.Checked = True
        Else
            Me.LogoffWhenTimoutCheckBox.Checked = False
        End If

        Dim fAllowUnlistedRemotePrograms = PolicyKey.GetValue("fAllowUnlistedRemotePrograms")
        If Not fAllowUnlistedRemotePrograms = Nothing Then
            Me.AllowUnlistedRemoteProgramsCheckBox.Checked = True
        Else
            Me.AllowUnlistedRemoteProgramsCheckBox.Checked = False
        End If

        If Me.TimeoutDisconnectedCheckBox.Checked = True Then
            Me.DisconnectTimeTextBox.Enabled = True
        Else
            Me.DisconnectTimeTextBox.Enabled = False
        End If

        If Me.TimeoutIdleCheckBox.Checked = True Then
            Me.IdleTimeTextBox.Enabled = True
        Else
            Me.IdleTimeTextBox.Enabled = False
        End If

    End Sub

    Private Sub TimeoutDisconnectedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TimeoutDisconnectedCheckBox.CheckedChanged
        If Me.TimeoutDisconnectedCheckBox.Checked = True Then
            Me.DisconnectTimeTextBox.Enabled = True
        Else
            Me.DisconnectTimeTextBox.Enabled = False
        End If
    End Sub

    Private Sub TimeoutIdleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TimeoutIdleCheckBox.CheckedChanged
        If Me.TimeoutIdleCheckBox.Checked = True Then
            Me.IdleTimeTextBox.Enabled = True
        Else
            Me.IdleTimeTextBox.Enabled = False
        End If
    End Sub

    Private Sub CancelEditButton_Click(sender As Object, e As EventArgs) Handles CancelEditButton.Click
        Me.Close()
    End Sub

End Class