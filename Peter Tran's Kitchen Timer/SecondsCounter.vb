Public Class SecondsCounter : Inherits Counter
    Public Sub New()
        value = 0
        maxvalue = 59
    End Sub

    Private minCounter As MinutesCounter

    Public Sub decrement()
        If value > 0 Then
            setValue(value - 1)
            Return
        End If
        If Not minCounter.isZero() Then
            setValue(maxvalue)
            minCounter.decrement()
        End If
    End Sub

    Public Sub increaseBy(increment As Integer)
        If value <= maxvalue Then
            setValue(value + increment)
            Return
        End If
        If minCounter.isMax Then
            setValue(maxvalue)
            Return
        End If
    End Sub

    Public Sub setMinutesCounter(newcounter As MinutesCounter)
        minCounter = newcounter
    End Sub
End Class