<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Sec1 = New System.Windows.Forms.Button()
        Me.Sec3 = New System.Windows.Forms.Button()
        Me.Sec10 = New System.Windows.Forms.Button()
        Me.Min1 = New System.Windows.Forms.Button()
        Me.Min3 = New System.Windows.Forms.Button()
        Me.Min10 = New System.Windows.Forms.Button()
        Me.SingleTimer1 = New Peter_Tran_s_Kitchen_Timer.SingleTimer()
        Me.SingleTimer2 = New Peter_Tran_s_Kitchen_Timer.SingleTimer()
        Me.SingleTimer3 = New Peter_Tran_s_Kitchen_Timer.SingleTimer()
        Me.SingleTimer4 = New Peter_Tran_s_Kitchen_Timer.SingleTimer()
        Me.SuspendLayout()
        '
        'Sec1
        '
        Me.Sec1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Sec1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sec1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sec1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sec1.ForeColor = System.Drawing.Color.Ivory
        Me.Sec1.Location = New System.Drawing.Point(13, 460)
        Me.Sec1.Name = "Sec1"
        Me.Sec1.Size = New System.Drawing.Size(150, 54)
        Me.Sec1.TabIndex = 0
        Me.Sec1.Tag = "1"
        Me.Sec1.Text = "1 Second"
        Me.Sec1.UseVisualStyleBackColor = False
        '
        'Sec3
        '
        Me.Sec3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Sec3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sec3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sec3.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sec3.ForeColor = System.Drawing.Color.Ivory
        Me.Sec3.Location = New System.Drawing.Point(167, 460)
        Me.Sec3.Name = "Sec3"
        Me.Sec3.Size = New System.Drawing.Size(150, 54)
        Me.Sec3.TabIndex = 1
        Me.Sec3.Tag = "3"
        Me.Sec3.Text = "3 Seconds"
        Me.Sec3.UseVisualStyleBackColor = False
        '
        'Sec10
        '
        Me.Sec10.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Sec10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sec10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sec10.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Sec10.ForeColor = System.Drawing.Color.Ivory
        Me.Sec10.Location = New System.Drawing.Point(321, 460)
        Me.Sec10.Name = "Sec10"
        Me.Sec10.Size = New System.Drawing.Size(150, 54)
        Me.Sec10.TabIndex = 2
        Me.Sec10.Tag = "10"
        Me.Sec10.Text = "10 Seconds"
        Me.Sec10.UseVisualStyleBackColor = False
        '
        'Min1
        '
        Me.Min1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Min1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Min1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Min1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Min1.ForeColor = System.Drawing.Color.Ivory
        Me.Min1.Location = New System.Drawing.Point(13, 523)
        Me.Min1.Name = "Min1"
        Me.Min1.Size = New System.Drawing.Size(150, 54)
        Me.Min1.TabIndex = 3
        Me.Min1.Tag = "1"
        Me.Min1.Text = "1 Minute"
        Me.Min1.UseVisualStyleBackColor = False
        '
        'Min3
        '
        Me.Min3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Min3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Min3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Min3.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Min3.ForeColor = System.Drawing.Color.Ivory
        Me.Min3.Location = New System.Drawing.Point(167, 523)
        Me.Min3.Name = "Min3"
        Me.Min3.Size = New System.Drawing.Size(150, 54)
        Me.Min3.TabIndex = 4
        Me.Min3.Tag = "3"
        Me.Min3.Text = "3 Minutes"
        Me.Min3.UseVisualStyleBackColor = False
        '
        'Min10
        '
        Me.Min10.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Min10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Min10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Min10.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Min10.ForeColor = System.Drawing.Color.Ivory
        Me.Min10.Location = New System.Drawing.Point(321, 523)
        Me.Min10.Name = "Min10"
        Me.Min10.Size = New System.Drawing.Size(150, 54)
        Me.Min10.TabIndex = 5
        Me.Min10.Tag = "10"
        Me.Min10.Text = "10 Minutes"
        Me.Min10.UseVisualStyleBackColor = False
        '
        'SingleTimer1
        '
        Me.SingleTimer1.Alarm = ""
        Me.SingleTimer1.AlarmBeep = 400
        Me.SingleTimer1.AlarmFrequency = 800
        Me.SingleTimer1.AlarmInterval = 300
        Me.SingleTimer1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SingleTimer1.Location = New System.Drawing.Point(13, 12)
        Me.SingleTimer1.Name = "SingleTimer1"
        Me.SingleTimer1.Size = New System.Drawing.Size(221, 202)
        Me.SingleTimer1.TabIndex = 6
        Me.SingleTimer1.Title = "Back Left"
        '
        'SingleTimer2
        '
        Me.SingleTimer2.Alarm = ""
        Me.SingleTimer2.AlarmBeep = 200
        Me.SingleTimer2.AlarmFrequency = 1200
        Me.SingleTimer2.AlarmInterval = 100
        Me.SingleTimer2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SingleTimer2.Location = New System.Drawing.Point(250, 12)
        Me.SingleTimer2.Name = "SingleTimer2"
        Me.SingleTimer2.Size = New System.Drawing.Size(221, 202)
        Me.SingleTimer2.TabIndex = 7
        Me.SingleTimer2.Title = "Back Right"
        '
        'SingleTimer3
        '
        Me.SingleTimer3.Alarm = ""
        Me.SingleTimer3.AlarmBeep = 900
        Me.SingleTimer3.AlarmFrequency = 1800
        Me.SingleTimer3.AlarmInterval = 1000
        Me.SingleTimer3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SingleTimer3.Location = New System.Drawing.Point(13, 231)
        Me.SingleTimer3.Name = "SingleTimer3"
        Me.SingleTimer3.Size = New System.Drawing.Size(221, 202)
        Me.SingleTimer3.TabIndex = 8
        Me.SingleTimer3.Title = "Front Left"
        '
        'SingleTimer4
        '
        Me.SingleTimer4.Alarm = ""
        Me.SingleTimer4.AlarmBeep = 600
        Me.SingleTimer4.AlarmFrequency = 1400
        Me.SingleTimer4.AlarmInterval = 50
        Me.SingleTimer4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.SingleTimer4.Location = New System.Drawing.Point(250, 231)
        Me.SingleTimer4.Name = "SingleTimer4"
        Me.SingleTimer4.Size = New System.Drawing.Size(221, 202)
        Me.SingleTimer4.TabIndex = 9
        Me.SingleTimer4.Title = "Front Right"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(487, 589)
        Me.Controls.Add(Me.SingleTimer4)
        Me.Controls.Add(Me.SingleTimer3)
        Me.Controls.Add(Me.SingleTimer2)
        Me.Controls.Add(Me.SingleTimer1)
        Me.Controls.Add(Me.Min10)
        Me.Controls.Add(Me.Min3)
        Me.Controls.Add(Me.Min1)
        Me.Controls.Add(Me.Sec10)
        Me.Controls.Add(Me.Sec3)
        Me.Controls.Add(Me.Sec1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peter Tran's Kitchen Timer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Sec1 As Button
    Friend WithEvents Sec3 As Button
    Friend WithEvents Sec10 As Button
    Friend WithEvents Min1 As Button
    Friend WithEvents Min3 As Button
    Friend WithEvents Min10 As Button
    Friend WithEvents SingleTimer1 As SingleTimer
    Friend WithEvents SingleTimer2 As SingleTimer
    Friend WithEvents SingleTimer3 As SingleTimer
    Friend WithEvents SingleTimer4 As SingleTimer
End Class
