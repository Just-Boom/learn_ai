Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text_state.Text = "stop"
        Text_speed.Text = "100"

        Cmb_baud.SelectedItem = "9600"



        Me.CenterToParent()
        B_open.Enabled = False
        B_open.BringToFront()

        B_close.Enabled = False
        B_close.SendToBack()

        B_run.Enabled = False
        B_back.Enabled = False
        B_stop.Enabled = False
        B_left.Enabled = False
        B_right.Enabled = False



    End Sub

    Private Sub B_run_Click(sender As Object, e As EventArgs) Handles B_run.Click
        Text_state.Text = "run"
        SerialPort1.Write(Text_state.Text)
    End Sub

    Private Sub B_left_Click(sender As Object, e As EventArgs) Handles B_left.Click
        Text_state.Text = "left"
        SerialPort1.Write(Text_state.Text)
    End Sub

    Private Sub B_stop_Click(sender As Object, e As EventArgs) Handles B_stop.Click
        Text_state.Text = "stop"
        SerialPort1.Write(Text_state.Text)
    End Sub

    Private Sub B_right_Click(sender As Object, e As EventArgs) Handles B_right.Click
        Text_state.Text = "right"
        SerialPort1.Write(Text_state.Text)
    End Sub

    Private Sub B_back_Click(sender As Object, e As EventArgs) Handles B_back.Click
        Text_state.Text = "back"
        SerialPort1.Write(Text_state.Text)
    End Sub

    Private Sub B_blue_Click(sender As Object, e As EventArgs) Handles B_blue.Click
        Cmb_scan.Items.Clear() ''清除状态栏
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Cmb_scan.Items.Add(sp)           'CompList是一个下列框控件，这里修改为你的下列框名称
        Next
        Cmb_scan.Text = Cmb_scan.Items(0)

        B_open.Enabled = True
        B_open.BringToFront()
        'Cmb_scan.Items.Clear() ''清除状态栏
        'Dim myport As Array
        'Dim i As Integer
        'myport = IO.Ports.SerialPort.GetPortNames() ''获取串口
        'i = Cmb_scan.Items.Count
        'i = i - i
        'Try
        '    Cmb_scan.SelectedIndex = i
        'Catch ex As Exception
        '    Dim result As DialogResult
        '    result = MessageBox.Show("com port not detected", "Warning!!!", MessageBoxButtons.OK)
        '    Cmb_scan.Text = ""
        '    Cmb_scan.Items.Clear()
        '    Call Form1_Load(Me, e)
        'End Try

    End Sub

    Private Sub B_open_Click(sender As Object, e As EventArgs) Handles B_open.Click
        B_open.Enabled = False
        B_open.SendToBack()

        SerialPort1.BaudRate = Cmb_baud.SelectedItem
        SerialPort1.PortName = Cmb_scan.SelectedItem
        SerialPort1.Open()

        B_close.Enabled = True
        B_close.BringToFront()

        B_run.Enabled = True
        B_back.Enabled = True
        B_stop.Enabled = True
        B_left.Enabled = True
        B_right.Enabled = True


    End Sub

    Private Sub B_close_Click(sender As Object, e As EventArgs) Handles B_close.Click
        B_close.Enabled = False
        B_close.SendToBack()

        SerialPort1.Close()
        B_open.Enabled = True
        B_open.BringToFront()

        B_run.Enabled = False
        B_back.Enabled = False
        B_stop.Enabled = False
        B_left.Enabled = False
        B_right.Enabled = False
    End Sub
End Class
