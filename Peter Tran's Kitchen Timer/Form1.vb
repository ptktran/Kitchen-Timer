Public Class Form1
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SingleTimer1.initialize()
        SingleTimer1.selectMe()
        SingleTimer2.initialize()
        SingleTimer3.initialize()
        SingleTimer4.initialize()
    End Sub

    Private Sub Seconds_Click(sender As Object, e As EventArgs) Handles Sec1.Click, Sec3.Click, Sec10.Click
        SingleTimer.selectedTimer.AddSecondsToSelected(CInt(sender.Tag))
    End Sub

    Private Sub Minutes_Click(sender As Object, e As EventArgs) Handles Min1.Click, Min3.Click, Min10.Click

        SingleTimer.selectedTimer.AddMinutesToSelected(CInt(sender.Tag))
    End Sub

End Class
