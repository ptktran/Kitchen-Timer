Public MustInherit Class Counter
    Inherits Label

    Protected maxvalue As Integer
    Protected value As Integer

    Public Function isMax() As Boolean
        If value = maxvalue Then
            Return True
        End If
        Return False
    End Function

    Public Function isZero()
        If value = 0 Then
            Return True
        End If
        Return False
    End Function

    Public Sub reset()
        setValue(0)
        Me.Text = "00"
    End Sub

    Public Sub setToMax()
        setValue(maxvalue)
    End Sub

    Public Sub setValue(newvalue As Integer)
        If newvalue <= maxvalue Then
            value = newvalue
        Else
            value = maxvalue
        End If
        Me.Text = value.ToString("00")
    End Sub
End Class