Imports System.IO
Imports System.Drawing
Imports System.Collections.Generic

Public Class IconExtractor
    Private Declare Function ExtractIconEx _
      Lib "shell32.dll" Alias "ExtractIconExA" _
      (ByVal lpszFile As String, ByVal nIconIndex As Int32, _
      ByRef phiconLarge As Int32, ByRef phiconSmall As Int32, _
      ByVal nIcons As Int32) As Int32

    Private Declare Function ExtractIcon _
     Lib "shell32.dll" Alias "ExtractIconA" _
     (ByVal hInst As IntPtr, ByVal lpszExeFileName As String, _
     ByVal nIconIndex As Int32) As Int32

    Private Declare Function DrawIconEx _
     Lib "user32" _
     (ByVal hdc As Int32, ByVal xLeft As Int32, ByVal yTop As Int32, _
          ByVal hIcon As IntPtr, ByVal cxWidth As Int32, ByVal cyWidth As Int32, _
          ByVal istepIfAniCur As Int32, ByVal hbrFlickerFreeDraw As Int32, _
          ByVal diFlags As Int32) As Int32

    Private Declare Function DestroyIcon _
     Lib "user32" _
     (ByVal hIcon As Int32) As Int32

    Private m_hIcons() As Int32


    Protected Overrides Sub Finalize()

        MyBase.Finalize()

        Dim countIcons As Integer = m_hIcons.Length

        If countIcons > 0 Then

            For iconIndex As Integer = 0 To countIcons - 1

                DestroyIcon(m_hIcons(iconIndex))

            Next iconIndex

        End If

    End Sub

    Public Function ExtractIcons(ByVal filePath As String, ByVal hInst As IntPtr) As List(Of Icon)

        Dim listIcons As New List(Of Icon)

        Try

            Dim numIcons As Integer = ExtractIconEx(filePath, -1, 0&, 0&, 0&)

            If numIcons = 0 Then
                Throw New Exception("No icons found in " & filePath)
            End If

            numIcons -= 1

            For currentIcon As Integer = 0 To numIcons

                m_hIcons(currentIcon) = ExtractIcon(hInst, filePath, currentIcon)

                Dim handleIcon As New IntPtr(m_hIcons(currentIcon))

                If Not handleIcon.Equals(IntPtr.Zero) Then

                    listIcons.Add(Icon.FromHandle(handleIcon))

                End If

            Next currentIcon

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try

        Return listIcons

    End Function

End Class

Module IconModule

    Public Sub TestIconLib()
        Dim testIcon As New IconLib.MultiIcon
    End Sub

    Public Function IconFromFilePath(filePath As String) As Icon
        Dim result As Icon = Nothing
        Try
            result = Icon.ExtractAssociatedIcon(filePath)
        Catch
        End Try
        Return result
    End Function

    Public Function ExtractToIco(IconSourcePath As String, IconSourceIndex As Integer, IcoDestPath As String) As Boolean
        Dim success = False
        Dim IconLoadError As Boolean = False
        If My.Computer.FileSystem.FileExists(IconSourcePath) = True Then
            Dim mIcon As New IconLib.MultiIcon
            Try
                mIcon.Load(IconSourcePath)
            Catch Ex As Exception
                IconLoadError = True
            End Try

            If Not IconLoadError Then
                Dim sIcon As IconLib.SingleIcon
                If IconSourceIndex = 0 Then
                    sIcon = mIcon.FirstOrDefault
                Else
                    sIcon = mIcon.Item(IconSourceIndex)
                End If

                Try
                    sIcon.Save(IcoDestPath)
                    success = True
                Catch Ex As Exception

                End Try
            End If
        End If

        Return success
    End Function

    Declare Function ExtractIcon Lib "shell32.dll" Alias "ExtractIconExA" (ByVal lpszFile As String, ByVal nIconIndex As Integer, ByRef phiconLarge As Integer, ByRef phiconSmall As Integer, ByVal nIcons As Integer) As Integer

    Public Function ReturnIcon(ByVal Path As String, ByVal Index As Integer, Optional ByVal small As Boolean = False) As Icon
        Dim bigIcon As Integer
        Dim smallIcon As Integer
        ExtractIcon(Path, Index, bigIcon, smallIcon, 1)
        If bigIcon = 0 Then
            ExtractIcon(Path, 0, bigIcon, smallIcon, 1)
        End If
        If bigIcon <> 0 Then
            If small = False Then
                Return Icon.FromHandle(bigIcon)
            Else
                Return Icon.FromHandle(smallIcon)
            End If
        Else
            Return ReturnIcon(GetSysDir() & "\mstsc.exe", 0)
        End If
    End Function

End Module