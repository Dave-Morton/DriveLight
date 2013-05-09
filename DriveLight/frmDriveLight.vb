Public Class FormDriveLight

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim both As Integer = 0
        If (PerformanceCounter1.NextValue > 0) Then
            both += 1
        End If

        If (PerformanceCounter2.NextValue > 0) Then
            both += 2
        End If

        Select Case both
            Case 0
                NotifyIcon1.Icon = My.Resources.DA_Trans
            Case 1
                NotifyIcon1.Icon = My.Resources.DA_Green
            Case 2
                NotifyIcon1.Icon = My.Resources.DA_Red
            Case 3
                NotifyIcon1.Icon = My.Resources.DA_Both
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NotifyIcon1.Icon = My.Resources.DA_Green
        'Dim PerformanceCounter1 As New PerformanceCounter, PerformanceCounter2 As New PerformanceCounter

        With PerformanceCounter1
            .CategoryName = "LogicalDisk"
            .InstanceName = "_Total"
            .CounterName = "Disk Read Bytes/sec"
        End With

        With PerformanceCounter2
            .CategoryName = "LogicalDisk"
            .InstanceName = "_Total"
            .CounterName = "Disk Write Bytes/sec"
        End With
    End Sub

    Private Sub NotifyIcon1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        'If e.Button = Windows.Forms.MouseButtons.Right Then
        'NotifyIcon1.Visible = False
        'Application.Exit()
        'End If
    End Sub

    Private Sub TSM_About_Click(sender As System.Object, e As System.EventArgs) Handles TSM_About.Click
        AboutBox1.Show()
    End Sub

    Private Sub TSM_Exit_Click(sender As Object, e As System.EventArgs) Handles TSM_Exit.Click
        Application.Exit()
    End Sub
End Class
