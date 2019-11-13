' code sample taken from:
'https://code.msdn.microsoft.com/windowsapps/How-to-know-the-process-170ed5f3/sourcecode?fileId=151114&pathId=1558127374
' Modified to suit the needs of this application
Imports System.ComponentModel
Imports System.Runtime.InteropServices

Module LockCheck
    ' maximum character count of application friendly name. 
    Private Const CCH_RM_MAX_APP_NAME As Integer = 255
    ' maximum character count of service short name. 
    Private Const CCH_RM_MAX_SVC_NAME As Integer = 63
    ' A system restart is not required. 
    Private Const RmRebootReasonNone As Integer = 0

    ''' <summary> 
    ''' Uniquely identifies a process by its PID and the time the process began.  
    ''' An array of RM_UNIQUE_PROCESS structures can be passed 
    ''' to the RmRegisterResources function. 
    ''' </summary> 
    <StructLayout(LayoutKind.Sequential)>
    Private Structure RM_UNIQUE_PROCESS
        ' The product identifier (PID). 
        Public dwProcessId As Integer
        ' The creation time of the process. 
        Public ProcessStartTime As System.Runtime.InteropServices.ComTypes.FILETIME
    End Structure

    ''' <summary> 
    ''' Specifies the type of application that is described by 
    ''' the RM_PROCESS_INFO structure. 
    ''' </summary> 
    Private Enum RM_APP_TYPE
        ' The application cannot be classified as any other type. 
        RmUnknownApp = 0
        ' A Windows application run as a stand-alone process that 
        ' displays a top-level window. 
        RmMainWindow = 1
        ' A Windows application that does not run as a stand-alone 
        ' process and does not display a top-level window. 
        RmOtherWindow = 2
        ' The application is a Windows service. 
        RmService = 3
        ' The application is Windows Explorer. 
        RmExplorer = 4
        ' The application is a stand-alone console application. 
        RmConsole = 5
        ' A system restart is required to complete the installation because 
        ' a process cannot be shut down. 
        RmCritical = 1000
    End Enum

    ''' <summary> 
    ''' Describes an application that is to be registered with the Restart Manager. 
    ''' </summary> 
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)>
    Private Structure RM_PROCESS_INFO
        ' Contains an RM_UNIQUE_PROCESS structure that uniquely identifies the 
        ' application by its PID and the time the process began. 
        Public Process As RM_UNIQUE_PROCESS
        ' If the process is a service, this parameter returns the  
        ' long name for the service. 
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=CCH_RM_MAX_APP_NAME + 1)>
        Public strAppName As String
        ' If the process is a service, this is the short name for the service. 
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=CCH_RM_MAX_SVC_NAME + 1)>
        Public strServiceShortName As String
        ' Contains an RM_APP_TYPE enumeration value. 
        Public ApplicationType As RM_APP_TYPE
        ' Contains a bit mask that describes the current status of the application. 
        Public AppStatus As UInteger
        ' Contains the Terminal Services session ID of the process. 
        Public TSSessionId As UInteger
        ' TRUE if the application can be restarted by the  
        ' Restart Manager; otherwise, FALSE. 
        <MarshalAs(UnmanagedType.Bool)>
        Public bRestartable As Boolean
    End Structure

    ''' <summary> 
    ''' Registers resources to a Restart Manager session. The Restart Manager uses  
    ''' the list of resources registered with the session to determine which  
    ''' applications and services must be shut down and restarted. Resources can be  
    ''' identified by filenames, service short names, or RM_UNIQUE_PROCESS structures 
    ''' that describe running applications. 
    ''' </summary> 
    ''' <param name="pSessionHandle"> 
    ''' A handle to an existing Restart Manager session. 
    ''' </param> 
    ''' <param name="nFiles">The number of files being registered</param> 
    ''' <param name="rgsFilenames"> 
    ''' An array of null-terminated strings of full filename paths. 
    ''' </param> 
    ''' <param name="nApplications">The number of processes being registered</param> 
    ''' <param name="rgApplications">An array of RM_UNIQUE_PROCESS structures</param> 
    ''' <param name="nServices">The number of services to be registered</param> 
    ''' <param name="rgsServiceNames"> 
    ''' An array of null-terminated strings of service short names. 
    ''' </param> 
    ''' <returns>The function can return one of the system error codes that  
    ''' are defined in Winerror.h 
    ''' </returns> 
    <DllImport("rstrtmgr.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Function RmRegisterResources(pSessionHandle As UInteger, nFiles As UInt32, rgsFilenames As String(), nApplications As UInt32, <[In]> rgApplications As RM_UNIQUE_PROCESS(), nServices As UInt32,
        rgsServiceNames As String()) As Integer
    End Function

    ''' <summary> 
    ''' Starts a new Restart Manager session. A maximum of 64 Restart Manager  
    ''' sessions per user session can be open on the system at the same time.  
    ''' When this function starts a session, it returns a session handle and  
    ''' session key that can be used in subsequent calls to the Restart Manager API. 
    ''' </summary> 
    ''' <param name="pSessionHandle"> 
    ''' A pointer to the handle of a Restart Manager session. 
    ''' </param> 
    ''' <param name="dwSessionFlags">Reserved. This parameter should be 0.</param> 
    ''' <param name="strSessionKey"> 
    ''' A null-terminated string that contains the session key to the new session. 
    ''' </param> 
    ''' <returns></returns> 
    <DllImport("rstrtmgr.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Function RmStartSession(ByRef pSessionHandle As UInteger, dwSessionFlags As Integer, strSessionKey As String) As Integer
    End Function

    ''' <summary> 
    ''' Ends the Restart Manager session. This function should be called by the  
    ''' primary installer that has previously started the session by calling the  
    ''' RmStartSession function. The RmEndSession function can be called by a  
    ''' secondary installer that is joined to the session once no more resources  
    ''' need to be registered by the secondary installer. 
    ''' </summary> 
    ''' <param name="pSessionHandle"> 
    ''' A handle to an existing Restart Manager session. 
    ''' </param> 
    ''' <returns> 
    ''' The function can return one of the system error codes 
    ''' that are defined in Winerror.h. 
    ''' </returns> 
    <DllImport("rstrtmgr.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Function RmEndSession(pSessionHandle As UInteger) As Integer
    End Function

    ''' <summary> 
    ''' Gets a list of all applications and services that are currently using  
    ''' resources that have been registered with the Restart Manager session. 
    ''' </summary> 
    ''' <param name="dwSessionHandle"> 
    ''' A handle to an existing Restart Manager session. 
    ''' </param> 
    ''' <param name="pnProcInfoNeeded">A pointer to an array size necessary to  
    ''' receive RM_PROCESS_INFO structures required to return information for  
    ''' all affected applications and services. 
    ''' </param> 
    ''' <param name="pnProcInfo"> 
    ''' A pointer to the total number of RM_PROCESS_INFO structures in an array 
    ''' and number of structures filled. 
    ''' </param> 
    ''' <param name="rgAffectedApps"> 
    ''' An array of RM_PROCESS_INFO structures that list the applications and  
    ''' services using resources that have been registered with the session. 
    ''' </param> 
    ''' <param name="lpdwRebootReasons"> 
    ''' Pointer to location that receives a value of the RM_REBOOT_REASON 
    ''' enumeration that describes the reason a system restart is needed. 
    ''' </param> 
    ''' <returns></returns> 
    <DllImport("rstrtmgr.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Function RmGetList(dwSessionHandle As UInteger, ByRef pnProcInfoNeeded As UInteger, ByRef pnProcInfo As UInteger, <[In], Out> rgAffectedApps As RM_PROCESS_INFO(), ByRef lpdwRebootReasons As UInteger) As Integer
    End Function

    Function LockCheck(Filename As String)
        Dim handle As UInteger
        Dim sessionkey As String = Guid.NewGuid().ToString()
        Dim processes As New List(Of Process)()
        Dim result As String = ""

        Dim res As Integer = RmStartSession(handle, 0, sessionkey)
        If res <> 0 Then
            Throw New Exception("Could not begin restart session.")
        End If

        Try
            Dim pnProcInfoNeeded As UInteger = 0, pnProcInfo As UInteger = 100, lpdwRebootReasons As UInteger = RmRebootReasonNone
            Dim resources As String() = New String() {Filename}

            ' Create an array to store the process results. 
            Dim processInfo As RM_PROCESS_INFO() = New RM_PROCESS_INFO(pnProcInfo - 1) {}

            res = RmRegisterResources(handle, CUInt(resources.Length), resources, 0, Nothing, 0,
                Nothing)
            If res <> 0 Then
                Throw New Exception("Could not register resource.")
            End If

            res = RmGetList(handle, pnProcInfoNeeded, pnProcInfo, processInfo, lpdwRebootReasons)
            If res = 0 Then
                'The function completed successfully. 

                If pnProcInfo <> 0 Then
                    For i As Integer = 0 To pnProcInfo - 1
                        'Console.WriteLine("File Name :" + resources(0))
                        result = result + "File Name :" + resources(0) + vbNewLine
                        'Console.WriteLine("Application locking the file :" + processInfo(i).strAppName)
                        result = result + "Application locking the file : " + processInfo(i).strAppName + vbNewLine
                        result = result + "PID of process locking the file: " + processInfo(i).Process.dwProcessId.ToString() + vbNewLine
                    Next
                Else
                    'Console.WriteLine("The specified file '{0}' is not locked by any process", resources(0))
                    result = result + "No locks"

                End If
            Else
                Throw New Exception("Could not list processes locking resource.")
            End If

            If res <> 0 Then
                Throw New Win32Exception(Marshal.GetLastWin32Error())

            End If
        Catch exception As Exception
            'Console.WriteLine(exception.Message)
            result = result + exception.Message
        Finally
            RmEndSession(handle)
        End Try
        Return result
    End Function
End Module
Public Class LockChecker
    Public Function CheckLock(FileName As String)
        Return LockCheck.LockCheck(FileName)
    End Function
End Class