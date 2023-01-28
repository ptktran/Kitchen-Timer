Public Class MinutesCounter : Inherits Counter
    Public Sub New()
        value = 0
        maxvalue = 99
    End Sub

    Private secCounter As SecondsCounter

    Public Sub decrement()
        If value > 0 Then
            setValue(value - 1)
        End If
    End Sub

    Public Sub increaseBy(increment As Integer)
        If value <= maxvalue Then
            setValue(value + increment)
            Return
        End If
        setValue(maxvalue)
        setToMax()
    End Sub

    Public Sub setSecondsCounter(newcounter As SecondsCounter)
        secCounter = newcounter
    End Sub
End Class
