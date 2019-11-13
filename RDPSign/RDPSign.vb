Imports System.Windows.Forms

Public Class RDPSign
    Public ErrorNumber As Integer = 0
    Public ErrorString As String = ""

    Sub main()

    End Sub

    ''' <summary>
    ''' Get all Certificate friendly names
    ''' </summary>
    ''' <returns>String array of Certificate friendly names</returns>
    Function GetCertificateFriendlyName()
        Dim CertStoreLM As Security.Cryptography.X509Certificates.X509Store
        Dim CertStoreCU As Security.Cryptography.X509Certificates.X509Store
        CertStoreLM = GetCertificateStoreLM()
        CertStoreCU = GetCertificateStoreCU()

        Dim FriendlyNames(CertStoreLM.Certificates.Count + CertStoreCU.Certificates.Count) As String
        Dim Counter As Integer = 0
        For Each Certificate In CertStoreLM.Certificates
            If Certificate.FriendlyName IsNot "" Then
                FriendlyNames(Counter) = Certificate.FriendlyName
                Counter = Counter + 1
            End If
        Next
        For Each Certificate In CertStoreCU.Certificates
            If Certificate.FriendlyName IsNot "" Then
                FriendlyNames(Counter) = Certificate.FriendlyName
                Counter = Counter + 1
            End If
        Next
        Array.Resize(FriendlyNames, Counter)
        Return FriendlyNames
    End Function

    ''' <summary>
    ''' Open the Local Machine certificate store and return it to the calling function/sub
    ''' </summary>
    ''' <returns>Certificate Store</returns>
    Function GetCertificateStoreLM()
        Dim CertStore As New Security.Cryptography.X509Certificates.X509Store(Security.Cryptography.X509Certificates.StoreLocation.LocalMachine)
        CertStore.Open(Security.Cryptography.X509Certificates.OpenFlags.ReadOnly)
        Return CertStore
    End Function

    ''' <summary>
    ''' Open the Current User certificate store and return it to the calling function/sub
    ''' </summary>
    ''' <returns>Certificate Store</returns>
    Function GetCertificateStoreCU()
        Dim CertStore As New Security.Cryptography.X509Certificates.X509Store(Security.Cryptography.X509Certificates.StoreLocation.CurrentUser)
        CertStore.Open(Security.Cryptography.X509Certificates.OpenFlags.ReadOnly)
        Return CertStore
    End Function

    ''' <summary>
    ''' Given a friendly name, find and return the associated thumbprint
    ''' </summary>
    ''' <param name="FriendlyName">String of the Friendly Name of a certificate</param>
    ''' <returns>String of the thumbprint of the certificate</returns>
    Function GetThumbprint(FriendlyName As String)
        Dim Thumbprint As String
        Dim CertStoreLM As Security.Cryptography.X509Certificates.X509Store
        CertStoreLM = GetCertificateStoreLM()
        For Each certificate In CertStoreLM.Certificates
            If certificate.FriendlyName = FriendlyName Then
                Thumbprint = certificate.Thumbprint
                CertStoreLM.Close()
                Return Thumbprint
            End If
        Next
        CertStoreLM.Close()
        Dim CertStoreCU As Security.Cryptography.X509Certificates.X509Store
        CertStoreCU = GetCertificateStoreCU()
        For Each certificate In CertStoreCU.Certificates
            If certificate.FriendlyName = FriendlyName Then
                Thumbprint = certificate.Thumbprint
                CertStoreCU.Close()
                Return Thumbprint
            End If
        Next
        ' We could get here if something went wrong such as Certificate was removed from certificate store after it was loaded into the application
        ' return an invalid thumbprint
        Return "0000"
    End Function

    ''' <summary>
    ''' Sign an RDP file and make a backup of the unsigned one if requested
    ''' </summary>
    ''' <param name="Thumbprint">Thumbprint used to sign RDP file</param>
    ''' <param name="RDPFileLocation">Location of RDP file</param>
    ''' <param name="CreateBackup">Boolean indicating if a backup should be created or not</param>
    Sub SignRDP(Thumbprint As String, RDPFileLocation As String, CreateBackup As Boolean)
        If Thumbprint = "0000" Then
            'Invalid thumbprint, this should be handled on the application side, but just as a safety, return without doing any work if invalid thumbprint sent
            Return
        End If
        If CreateBackup Then
            Dim BackupFile = System.IO.Path.GetDirectoryName(RDPFileLocation) & "\" & System.IO.Path.GetFileNameWithoutExtension(RDPFileLocation) & "-Unsigned.rdp"
            Dim LockCheck As New LockChecker.LockChecker()
            Dim FileLocked As String
            Dim SkipFile As Boolean = False
            FileLocked = LockCheck.CheckLock(BackupFile)
            While Not (FileLocked = "No locks")
                If (MessageBox.Show("The file " + BackupFile + " is currently locked.  Lock information:" + FileLocked + vbNewLine + "Do you want to try again?", "File Locked", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                    FileLocked = LockCheck.CheckLock(BackupFile)
                Else
                    MessageBox.Show("The following file will not be copied:" + vbNewLine + BackupFile)
                    SkipFile = True
                    FileLocked = "No locks"
                End If
            End While
            If Not (SkipFile) Then
                System.IO.File.Copy(RDPFileLocation, BackupFile, True) 'backup file with overwrite
            End If

        End If

            'If we get here, we should be good to run the command to sign the RDP file.
            Dim Command As String = GetSysDir() & "\rdpsign.exe"
        If My.Computer.FileSystem.FileExists(Command) Then
            Dim Arguments As String
            Dim FileVersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Command)
            ' On my windows 10 computer, the argument is /sha256 instead of /sha1.  /sha1 doesn't work.
            ' On my windows 10 computer, the Product parts come in at 10.0.18362.1
            ' On a Windows Server 2008 R2 server I have access to, the argument is /sha1.
            ' On a Windows Server 2008 R2 server I have access to, the Product parts come in at 6.1.7601.17514 which is lower than the windows 10 ones.
            ' I do not have other versions of windows to test, so will need external testing for this.
            ' Not sure where the version number switches over, but also not sure how to determine which method to use otherwise
            If (FileVersionInfo.ProductMajorPart >= 10) Then
                Arguments = " /sha256 " & Thumbprint & " """ & RDPFileLocation & """"

            Else
                Arguments = " /sha1 " & Thumbprint & " """ & RDPFileLocation & """"
            End If
            Dim StartInfo As New ProcessStartInfo
            StartInfo.FileName = Command
            StartInfo.Arguments = Arguments
            StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(StartInfo)
        Else
            MessageBox.Show("RDPSign executable not found:" & vbNewLine & vbNewLine & Command, My.Application.Info.AssemblyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Declare Function GetSystemDirectory Lib "kernel32" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long

    Function GetSysDir() As String
        Return Environment.SystemDirectory.ToString
    End Function

End Class
