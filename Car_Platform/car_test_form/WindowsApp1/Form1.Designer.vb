<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.B_run = New System.Windows.Forms.Button()
        Me.B_left = New System.Windows.Forms.Button()
        Me.B_right = New System.Windows.Forms.Button()
        Me.B_stop = New System.Windows.Forms.Button()
        Me.B_back = New System.Windows.Forms.Button()
        Me.B_open = New System.Windows.Forms.Button()
        Me.B_close = New System.Windows.Forms.Button()
        Me.B_blue = New System.Windows.Forms.Button()
        Me.L_state = New System.Windows.Forms.Label()
        Me.L_speed = New System.Windows.Forms.Label()
        Me.Text_state = New System.Windows.Forms.TextBox()
        Me.Text_speed = New System.Windows.Forms.TextBox()
        Me.Cmb_scan = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_baud = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'B_run
        '
        Me.B_run.Location = New System.Drawing.Point(757, 300)
        Me.B_run.Margin = New System.Windows.Forms.Padding(4)
        Me.B_run.Name = "B_run"
        Me.B_run.Size = New System.Drawing.Size(100, 29)
        Me.B_run.TabIndex = 0
        Me.B_run.Text = "前进"
        Me.B_run.UseVisualStyleBackColor = True
        '
        'B_left
        '
        Me.B_left.Location = New System.Drawing.Point(623, 369)
        Me.B_left.Margin = New System.Windows.Forms.Padding(4)
        Me.B_left.Name = "B_left"
        Me.B_left.Size = New System.Drawing.Size(100, 29)
        Me.B_left.TabIndex = 1
        Me.B_left.Text = "左转"
        Me.B_left.UseVisualStyleBackColor = True
        '
        'B_right
        '
        Me.B_right.Location = New System.Drawing.Point(895, 369)
        Me.B_right.Margin = New System.Windows.Forms.Padding(4)
        Me.B_right.Name = "B_right"
        Me.B_right.Size = New System.Drawing.Size(100, 29)
        Me.B_right.TabIndex = 2
        Me.B_right.Text = "右转"
        Me.B_right.UseVisualStyleBackColor = True
        '
        'B_stop
        '
        Me.B_stop.Location = New System.Drawing.Point(757, 369)
        Me.B_stop.Margin = New System.Windows.Forms.Padding(4)
        Me.B_stop.Name = "B_stop"
        Me.B_stop.Size = New System.Drawing.Size(100, 29)
        Me.B_stop.TabIndex = 3
        Me.B_stop.Text = "停止"
        Me.B_stop.UseVisualStyleBackColor = True
        '
        'B_back
        '
        Me.B_back.Location = New System.Drawing.Point(757, 436)
        Me.B_back.Margin = New System.Windows.Forms.Padding(4)
        Me.B_back.Name = "B_back"
        Me.B_back.Size = New System.Drawing.Size(100, 29)
        Me.B_back.TabIndex = 4
        Me.B_back.Text = "后退"
        Me.B_back.UseVisualStyleBackColor = True
        '
        'B_open
        '
        Me.B_open.Location = New System.Drawing.Point(13, 72)
        Me.B_open.Margin = New System.Windows.Forms.Padding(4)
        Me.B_open.Name = "B_open"
        Me.B_open.Size = New System.Drawing.Size(100, 29)
        Me.B_open.TabIndex = 5
        Me.B_open.Text = "打开"
        Me.B_open.UseVisualStyleBackColor = True
        '
        'B_close
        '
        Me.B_close.Location = New System.Drawing.Point(13, 73)
        Me.B_close.Margin = New System.Windows.Forms.Padding(4)
        Me.B_close.Name = "B_close"
        Me.B_close.Size = New System.Drawing.Size(100, 29)
        Me.B_close.TabIndex = 6
        Me.B_close.Text = "关闭"
        Me.B_close.UseVisualStyleBackColor = True
        '
        'B_blue
        '
        Me.B_blue.Location = New System.Drawing.Point(13, 35)
        Me.B_blue.Margin = New System.Windows.Forms.Padding(4)
        Me.B_blue.Name = "B_blue"
        Me.B_blue.Size = New System.Drawing.Size(100, 29)
        Me.B_blue.TabIndex = 7
        Me.B_blue.Text = "蓝牙连接"
        Me.B_blue.UseVisualStyleBackColor = True
        '
        'L_state
        '
        Me.L_state.AutoSize = True
        Me.L_state.Location = New System.Drawing.Point(587, 80)
        Me.L_state.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_state.Name = "L_state"
        Me.L_state.Size = New System.Drawing.Size(37, 15)
        Me.L_state.TabIndex = 8
        Me.L_state.Text = "状态"
        '
        'L_speed
        '
        Me.L_speed.AutoSize = True
        Me.L_speed.Location = New System.Drawing.Point(777, 80)
        Me.L_speed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_speed.Name = "L_speed"
        Me.L_speed.Size = New System.Drawing.Size(37, 15)
        Me.L_speed.TabIndex = 9
        Me.L_speed.Text = "速度"
        '
        'Text_state
        '
        Me.Text_state.Location = New System.Drawing.Point(589, 111)
        Me.Text_state.Margin = New System.Windows.Forms.Padding(4)
        Me.Text_state.Name = "Text_state"
        Me.Text_state.Size = New System.Drawing.Size(132, 25)
        Me.Text_state.TabIndex = 10
        '
        'Text_speed
        '
        Me.Text_speed.Location = New System.Drawing.Point(780, 111)
        Me.Text_speed.Margin = New System.Windows.Forms.Padding(4)
        Me.Text_speed.Name = "Text_speed"
        Me.Text_speed.Size = New System.Drawing.Size(132, 25)
        Me.Text_speed.TabIndex = 11
        '
        'Cmb_scan
        '
        Me.Cmb_scan.FormattingEnabled = True
        Me.Cmb_scan.Location = New System.Drawing.Point(121, 41)
        Me.Cmb_scan.Margin = New System.Windows.Forms.Padding(4)
        Me.Cmb_scan.Name = "Cmb_scan"
        Me.Cmb_scan.Size = New System.Drawing.Size(160, 23)
        Me.Cmb_scan.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "比特率："
        '
        'Cmb_baud
        '
        Me.Cmb_baud.FormattingEnabled = True
        Me.Cmb_baud.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.Cmb_baud.Location = New System.Drawing.Point(348, 39)
        Me.Cmb_baud.Name = "Cmb_baud"
        Me.Cmb_baud.Size = New System.Drawing.Size(121, 23)
        Me.Cmb_baud.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 562)
        Me.Controls.Add(Me.Cmb_baud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_scan)
        Me.Controls.Add(Me.Text_speed)
        Me.Controls.Add(Me.Text_state)
        Me.Controls.Add(Me.L_speed)
        Me.Controls.Add(Me.L_state)
        Me.Controls.Add(Me.B_blue)
        Me.Controls.Add(Me.B_open)
        Me.Controls.Add(Me.B_back)
        Me.Controls.Add(Me.B_stop)
        Me.Controls.Add(Me.B_right)
        Me.Controls.Add(Me.B_left)
        Me.Controls.Add(Me.B_run)
        Me.Controls.Add(Me.B_close)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_run As Button
    Friend WithEvents B_left As Button
    Friend WithEvents B_right As Button
    Friend WithEvents B_stop As Button
    Friend WithEvents B_back As Button
    Friend WithEvents B_open As Button
    Friend WithEvents B_close As Button
    Friend WithEvents B_blue As Button
    Friend WithEvents L_state As Label
    Friend WithEvents L_speed As Label
    Friend WithEvents Text_state As TextBox
    Friend WithEvents Text_speed As TextBox
    Friend WithEvents Cmb_scan As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_baud As ComboBox
    Friend WithEvents Timer1 As Timer
End Class
