<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.RadioButton()
        Me.ColonLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Minutes = New Peter_Tran_s_Kitchen_Timer.MinutesCounter()
        Me.Seconds = New Peter_Tran_s_Kitchen_Timer.SecondsCounter()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartButton.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.StartButton.Location = New System.Drawing.Point(9, 152)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(59, 40)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.StopButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StopButton.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.StopButton.Location = New System.Drawing.Point(81, 152)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(59, 40)
        Me.StopButton.TabIndex = 1
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ClearButton.Location = New System.Drawing.Point(153, 152)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(59, 40)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.ForeColor = System.Drawing.Color.LavenderBlush
        Me.TitleLabel.Location = New System.Drawing.Point(41, 20)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(99, 27)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.TabStop = True
        Me.TitleLabel.Text = "Position"
        Me.TitleLabel.UseVisualStyleBackColor = True
        '
        'ColonLabel
        '
        Me.ColonLabel.AutoSize = True
        Me.ColonLabel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ColonLabel.Font = New System.Drawing.Font("Roboto", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ColonLabel.ForeColor = System.Drawing.Color.LavenderBlush
        Me.ColonLabel.Location = New System.Drawing.Point(92, 57)
        Me.ColonLabel.Name = "ColonLabel"
        Me.ColonLabel.Size = New System.Drawing.Size(37, 57)
        Me.ColonLabel.TabIndex = 4
        Me.ColonLabel.Text = ":"
        Me.ColonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Minutes
        '
        Me.Minutes.AutoSize = True
        Me.Minutes.Font = New System.Drawing.Font("Roboto", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Minutes.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Minutes.Location = New System.Drawing.Point(26, 60)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(77, 57)
        Me.Minutes.TabIndex = 7
        Me.Minutes.Text = "00"
        Me.Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Seconds
        '
        Me.Seconds.AutoSize = True
        Me.Seconds.Font = New System.Drawing.Font("Roboto", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Seconds.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Seconds.Location = New System.Drawing.Point(115, 60)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(77, 57)
        Me.Seconds.TabIndex = 8
        Me.Seconds.Text = "00"
        Me.Seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SingleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.ColonLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(221, 202)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents TitleLabel As RadioButton
    Friend WithEvents ColonLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Minutes As MinutesCounter
    Friend WithEvents Seconds As SecondsCounter
End Class
