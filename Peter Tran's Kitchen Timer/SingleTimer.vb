Imports System.Data.SqlTypes
Imports System.Media
Imports System.Net

Public Class SingleTimer
    Inherits UserControl

    Dim TitleText As String
    Dim AlarmSound As String
    Dim beeps As Integer
    Dim frequency As Integer
    Dim interval As Integer
    Public Shared selectedTimer As SingleTimer
    Dim beeping As Boolean
    Dim countdown As Boolean

    Public Property AlarmBeep As Integer
        Get
            Return beeps
        End Get
        Set(value As Integer)
            beeps = value
        End Set
    End Property

    Public Property AlarmFrequency As Integer
        Get
            Return frequency
        End Get
        Set(value As Integer)
            frequency = value
        End Set
    End Property

    Public Property AlarmInterval As Integer
        Get
            Return interval
        End Get
        Set(value As Integer)
            interval = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return TitleText
        End Get
        Set(ByVal value As String)
            TitleText = value
            TitleLabel.Text = TitleText
        End Set
    End Property

    Public Property Alarm As String
        Get
            Return AlarmSound
        End Get
        Set(value As String)
            AlarmSound = value
        End Set
    End Property

    Private Sub SingleTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Minutes.setSecondsCounter(Seconds)
        Seconds.setMinutesCounter(Minutes)
    End Sub

    Public Sub addMinutes(extraMins As Integer)
        If Not countdown And Not beeping Then
            Minutes.increaseBy(extraMins)
            StartButton.Enabled = True
            ClearButton.Enabled = True
        End If
    End Sub

    Public Sub AddMinutesToSelected(extraMins As Integer)
        Me.addMinutes(extraMins)
    End Sub

    Public Sub addSeconds(extraSecs As Integer)
        If Not countdown And Not beeping Then
            Seconds.increaseBy(extraSecs)
            StartButton.Enabled = True
            ClearButton.Enabled = True
        End If
    End Sub

    Public Sub AddSecondsToSelected(extraSecs As Integer)
        Me.addSeconds(extraSecs)
    End Sub

    Public Sub deSelectMe()
        Me.TitleLabel.Checked = False
        selectedTimer = Nothing
        SetLook()
    End Sub

    Public Sub selectMe()
        If Not Information.IsNothing(selectedTimer) Then
            selectedTimer.deSelectMe()
        End If
        selectedTimer = Me
        TitleLabel.Checked = True
        ColonLabel.Focus()
        SetLook()
    End Sub

    Sub DisableAllButtons()
        Me.StartButton.Enabled = False
        Me.StopButton.Enabled = False
        Me.ClearButton.Enabled = False
    End Sub

    Public Sub initialize()
        Minutes.setSecondsCounter(Seconds)
        Seconds.setMinutesCounter(Minutes)
        Seconds.reset()
        Minutes.reset()
        TitleLabel.Checked = False
        DisableAllButtons()
    End Sub

    Sub newColor(newcolor As Color)
        Me.BackColor = newcolor
        Me.TitleLabel.BackColor = Color.Transparent
        Me.ColonLabel.BackColor = Color.Transparent
    End Sub

    Sub SetLook()
        If Not TitleLabel.Checked Then
            newColor(Color.CornflowerBlue)
        Else
            newColor(Color.MediumOrchid)
        End If
        If beeping Then
            newColor(Color.Red)
            Me.Seconds.BackColor = Color.Transparent
            Me.Minutes.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub UserControl1_Click(sender As Object, e As EventArgs) Handles Me.Click, TitleLabel.Click, ColonLabel.Click, Minutes.Click, Seconds.Click
        selectMe()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If Not beeping And Not (Minutes.isZero And Seconds.isZero) Then
            countdown = True
            Timer1.Start()
            StartButton.Enabled = False
            StopButton.Enabled = True
            ClearButton.Enabled = True
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        selectMe()
        stopTiming()
        Minutes.reset()
        Seconds.reset()
        DisableAllButtons()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        selectMe()
        stopTiming()
        If Minutes.isZero And Seconds.isZero Then
            DisableAllButtons()
            Timer1.Interval = 1000
            Return
        End If
        StartButton.Enabled = True
        StopButton.Enabled = False
        Timer1.Interval = 1000
    End Sub

    Sub soundAlarm(interval As Integer)
        Timer1.Interval = interval
        Console.Beep(AlarmFrequency, AlarmBeep)
    End Sub

    Sub stopTiming()
        Timer1.Stop()
        countdown = False
        beeping = False
        SetLook()
    End Sub

    Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If countdown Then
            Seconds.decrement()
            If Minutes.isZero And Seconds.isZero Then
                countdown = False
                StartButton.Enabled = False
                ClearButton.Enabled = False
                beeping = True
                SetLook()
                soundAlarm(AlarmInterval)
                Return
            End If
        End If
        If beeping Then
            soundAlarm(AlarmInterval)
        End If
    End Sub

End Class
