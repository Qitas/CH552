Imports System.Text
Imports System.IO.Ports
Public Class FormSerialPort
    Private strFileName As String '定义保存和打开文件的名
    Dim WithEvents Timer1 As New Timer() '定一个新的定时器类
    Dim WithEvents Timer2 As New Timer()
    Dim WithEvents Timer3 As New Timer()
    Dim WithEvents MySerialPorts As New SerialPort() '定义一个新的串口类
    Delegate Sub MyDelegate(ByVal strInPutString As String) '声明一个委托代理
    Dim MyReceiveDelegate As New MyDelegate(AddressOf MyStringProcessing) '定义一个委托代理
    Dim intReceiveBytesCount As ULong = 0 '保存收到的字节数
    Dim intSendBytesCount As ULong = 0 '保存发送的字节数
    Dim intReceiveFramesCount As UInteger = 0 '保存发送的帧数目
    Dim intSendBytesFramesCount As UInteger = 0 '保存接收的帧数目
    Dim boolAutoClearFlag As Boolean = 0 '定义自动清空接收区标志
    Dim boolHexSelectFlag As Boolean = 0 '定义十六进制发送选择位标记
    Dim boolFilterFlag As Boolean = 0 '定义一个标记位，如果选择了过滤后显示，那么此标记做为是否解析标记，即，只解析过滤到的帧数据
    ' Dim boolAutoUpdateFlag() As Boolean = {False}  '定义一个布尔数组，作为用来存储数据自动更新的标志
    Public Sub MySerialPorts_DataRecived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles MySerialPorts.DataReceived
        Try
            If chxHex.Checked Then '十六进制数据接收,并转换为字符串显示
                Dim intReceiveCount As Integer, strReceiveString As String = "" '初始化字符串变量为空
                '             Dim strReceiveArray() As String
                Dim hexReceiveArray() As Byte
                lblComStatus.ForeColor = Color.Green
                Threading.Thread.Sleep(100) '延时100ms
                intReceiveBytesCount += MySerialPorts.BytesToRead '保存收到的字节数
                '  intReceiveFramesCount += 1 '接收到帧数目加1
                ReDim hexReceiveArray(MySerialPorts.BytesToRead - 1) '重新定义数组长度为ReadBuffer中的字节数
                '   ReDim strReceiveArray(intReceiveCount)
                intReceiveCount = MySerialPorts.Read(hexReceiveArray, 0, MySerialPorts.BytesToRead) '读取ReadBuffer数据到字节数组
                If intReceiveCount = 0 Then '如果没有读到就退出
                    Exit Sub
                Else
                    For Each hexReceiveArray1 As Byte In hexReceiveArray '循环转换读到的字节到十六进制字符串形式
                        strReceiveString += [String].Format("{0:X2}", hexReceiveArray1) + " " '字符转换为十六进制并追加存储在strReceiveString变量中,以空格隔开
                        '   Invoke(MyReceiveDelegate, strReceiveString)
                    Next
                    Invoke(MyReceiveDelegate, strReceiveString) '调用委托处理函数，即以字符串的形式显示读取到的十六进制数
                    lblComStatus.ForeColor = Color.Orange
                End If
            Else '如果接收的数据不是十六进制，默认为字符串显示
                Dim strInPutData As String
                lblComStatus.ForeColor = Color.Green
                Threading.Thread.Sleep(100) '延时100ms
                intReceiveBytesCount += MySerialPorts.BytesToRead '接收到的字节计数，累计相加
                ' intReceiveFramesCount += 1 '接收到的帧数加1
                strInPutData = MySerialPorts.ReadExisting.ToString '读取所有可用的字节
                Invoke(MyReceiveDelegate, strInPutData) '调用委托代理
                lblComStatus.ForeColor = Color.Orange
            End If
        Catch ex As Exception
            Exit Sub
            'MessageBox.Show(ex.Message, "接收数据出错提示")
        End Try
    End Sub
    Sub MyStringProcessing(ByVal strData As String) '代理处理，接收到的数据以字符串的形式显示到文本框中
        If btnStopDisplay.Text = "暂停" Then '先判断是否暂停显示
            If txtFilter.Text.Length = 0 Then '判断是否需要过滤关键字后显示
                txtReceive.AppendText(vbCrLf + "【RX】" + strData) '如果没有过滤显示，则全部显示
            Else '如果需要过滤显示，就判断数据帧里是否包含要过滤的字符串，如果包含则显示
                If strData.Contains(txtFilter.Text) Then
                    txtReceive.AppendText(vbCrLf + "【RX】" + strData)
                    boolFilterFlag = True
                Else
                    boolFilterFlag = False
                End If
            End If
        End If
        intReceiveFramesCount += 1 '接收到的帧数加1
        If boolAutoClearFlag Then
            Dim intLinesNumber As Integer = txtReceive.GetLineFromCharIndex(txtReceive.Text.Length) '获取当前文本框的行数
            If intLinesNumber > 44 And btnStopDisplay.Text = "暂停" Then txtReceive.Clear() '如果自动清，超过44行就清空
        End If
        lblReceiveFrames.Text = intReceiveFramesCount.ToString '显示接收到的帧数
        lblReceiveBytes.Text = intReceiveBytesCount.ToString '显示接收到的字节数

    End Sub
    Private Sub OpenStatusDisplay() '打开串口界面初始化
        'lblComStatus.Text = "已打开"
        lblComStatus.ForeColor = Color.Orange
        btnOpenSerialPort.Text = "单击关闭"
        btnOpenSerialPort.ForeColor = Color.White
        btnStopDisplay.BackColor = Color.Gold
        btnOpenSerialPort.BackColor = Color.Green
        btnClear.BackColor = Color.OrangeRed
    End Sub
    Private Sub CloseStatusDisplay() '关闭串口界面初始化
        'lblComStatus.Text = "未打开"
        lblComStatus.ForeColor = Color.Black
        btnOpenSerialPort.Text = "打开串口"
        btnOpenSerialPort.ForeColor = Color.Black
        btnStopDisplay.BackColor = Color.WhiteSmoke
        btnOpenSerialPort.BackColor = Color.WhiteSmoke
        btnClear.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub CommPortStup() '窗体加载时初始化串口界面,加载上次用户界面配置
        '用GetSetting("区域","项名","键值名",默认值)来获取注册表中的内容
        cbxComName.SelectedIndex = GetSetting("SerialPort1", "MySerialStartup", "cbxComName", 0) '将第1个端口设为默认端口
        'cbxBoudRate.SelectedItem = "9600"
        cbxBoudRate.SelectedIndex = GetSetting("SerialPort1", "MySerialStartup", "cbxBoudRate", 12)
        ' cbxDataBits.SelectedItem = "8"
        cbxDataBits.SelectedIndex = GetSetting("SerialPort1", "MySerialStartup", "cbxDataBits", 0)
        'cbxParityBits.SelectedItem = "0"
        cbxParityBits.SelectedIndex = GetSetting("SerialPort1", "MySerialStartup", "cbxParityBits", 0)
        ' cbxStopBits.SelectedItem = "1"
        cbxStopBits.SelectedIndex = GetSetting("SerialPort1", "MySerialStartup", "cbxStopBits", 0)
        'lblComStatus.Text = "状态"
        lblComStatus.ForeColor = Color.Black
        'txtReceive.ForeColor = Color.Blue
        With MySerialPorts
            .PortName = cbxComName.Items(cbxComName.SelectedIndex).ToString
            .BaudRate = cbxBoudRate.Items(cbxBoudRate.SelectedIndex).ToString
            .DataBits = cbxDataBits.Items(cbxDataBits.SelectedIndex).ToString
            .StopBits = cbxStopBits.Items(cbxStopBits.SelectedIndex).ToString
            ' .StopBits = StopBits.One 
            .Parity = cbxParityBits.Items(cbxParityBits.SelectedIndex).ToString
            ' .Parity = Parity.None
        End With
        chxHex.Checked = GetSetting("SerialPort1", "MySerialStartup", "chxHex", True)
        chxAutoClear.Checked = GetSetting("SerialPort1", "MySerialStartup", "chxAutoClear", True)
        chxHexSend1.Checked = GetSetting("SerialPort1", "MySerialStartup", "chxHexSend1", True)
        chxHexSend2.Checked = GetSetting("SerialPort1", "MySerialStartup", "chxHexSend2", True)
        chxHexSend3.Checked = GetSetting("SerialPort1", "MySerialStartup", "chxHexSend3", True)
        txtTimerSend1.Text = GetSetting("SerialPort1", "MySerialStartup", "txtTimerSend1", "1000")
        txtTimerSend2.Text = GetSetting("SerialPort1", "MySerialStartup", "txtTimerSend2", "500")
        txtTimerSend3.Text = GetSetting("SerialPort1", "MySerialStartup", "txtTimerSend3", "1000")
        txtSendData1.Text = GetSetting("SerialPort1", "MySerialStartup", "txtSendData1", "")
        txtSendData2.Text = GetSetting("SerialPort1", "MySerialStartup", "txtSendData2", "")
        txtSendData3.Text = GetSetting("SerialPort1", "MySerialStartup", "txtSendData3", "")
    End Sub
    Public Sub MySettingSave() '保留用户上一次的设置
        '用SaveSetting("区域","项名","键值名","键值")来保存数据到注册表
        SaveSetting("SerialPort1", "MySerialStartup", "cbxComName", cbxComName.SelectedIndex)
        SaveSetting("SerialPort1", "MySerialStartup", "cbxBoudRate", cbxBoudRate.SelectedIndex)
        SaveSetting("SerialPort1", "MySerialStartup", "cbxDataBits", cbxDataBits.SelectedIndex)
        SaveSetting("SerialPort1", "MySerialStartup", "cbxStopBits", cbxStopBits.SelectedIndex)
        SaveSetting("SerialPort1", "MySerialStartup", "cbxParityBits", cbxParityBits.SelectedIndex)
        SaveSetting("SerialPort1", "MySerialStartup", "chxHex", chxHex.Checked)
        SaveSetting("SerialPort1", "MySerialStartup", "chxAutoClear", chxAutoClear.Checked)
        SaveSetting("SerialPort1", "MySerialStartup", "chxHexSend1", chxHexSend1.Checked)
        SaveSetting("SerialPort1", "MySerialStartup", "chxHexSend2", chxHexSend2.Checked)
        SaveSetting("SerialPort1", "MySerialStartup", "chxHexSend3", chxHexSend3.Checked)
        SaveSetting("SerialPort1", "MySerialStartup", "txtTimerSend1", txtTimerSend1.Text)
        SaveSetting("SerialPort1", "MySerialStartup", "txtTimerSend2", txtTimerSend2.Text)
        SaveSetting("SerialPort1", "MySerialStartup", "txtTimerSend3", txtTimerSend3.Text)
        SaveSetting("SerialPort1", "MySerialStartup", "txtSendData1", txtSendData1.Text)
        SaveSetting("SerialPort1", "MySerialStartup", "txtSendData2", txtSendData2.Text)
        SaveSetting("SerialPort1", "MySerialStartup", "txtSendData3", txtSendData3.Text)
    End Sub
    Private Sub FormSerialPort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CommPortStup() '窗体加载时初始化串口
    End Sub

    Private Sub btnFormExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormExit.Click
        MySettingSave()
        Me.Close()
        '  My.Settings.Save()
    End Sub
    Private Sub FormSerialPort_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed '窗口关闭
        MySettingSave()
    End Sub

    Private Sub btnOpenSerialPort_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOpenSerialPort.Click '打开串口
        Try
            If MySerialPorts.IsOpen = True Then
                MySerialPorts.Close()
                CloseStatusDisplay()
            Else
                MySerialPorts.Open()
                OpenStatusDisplay()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            CloseStatusDisplay()
        End Try
    End Sub

    Private Sub cbxComName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxComName.SelectedIndexChanged
        MySerialPorts.Close() '重新选择串口后，串口需重新打开
        CloseStatusDisplay()
        'MySerialPorts.PortName = cbxComName.Items(cbxComName.SelectedIndex).ToString '可以
        MySerialPorts.PortName = cbxComName.SelectedItem.ToString '可以

        ' MySerialPorts.PortName = cbxComName.SelectedIndex.ToString'不可以
    End Sub

    Private Sub cbxBoudRate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxBoudRate.SelectedIndexChanged
        MySerialPorts.Close() '重新选择波特率后，串口需重新打开
        CloseStatusDisplay()
        'MySerialPorts.BaudRate = cbxBoudRate.SelectedItem
        MySerialPorts.BaudRate = ULong.Parse(cbxBoudRate.SelectedItem)
    End Sub

    Private Sub cbxDataBits_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDataBits.SelectedIndexChanged
        'Dim strDataName As String
        MySerialPorts.Close() '重新选择数据位后，串口需重新打开
        CloseStatusDisplay()
        ' MySerialPorts.DataBits = cbxDataBits.SelectedItem
        'strDataName = MySerialPorts.DataBits.ToString
        ' MessageBox.Show(strDataName)
        MySerialPorts.DataBits = Integer.Parse(cbxDataBits.SelectedItem)
    End Sub

    Private Sub cbxParityBits_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxParityBits.SelectedIndexChanged
        MySerialPorts.Close() '重新选择校验位后，串口需要重新打开
        CloseStatusDisplay()
        MySerialPorts.Parity = cbxParityBits.SelectedItem
    End Sub

    Private Sub cbxStopBits_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxStopBits.SelectedIndexChanged
        MySerialPorts.Close() '重新选择停止位后，串口需要重新打开
        CloseStatusDisplay()
        MySerialPorts.StopBits = cbxStopBits.SelectedItem
    End Sub

    Private Sub btnSendData1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendData1.Click
        If MySerialPorts.IsOpen Then
            SendData1() '单击发送1区的按钮，发送1区的数据处理
        Else
            MessageBox.Show("串口未打开", "错误提示")
        End If
    End Sub
    Private Sub btnSendData2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendData2.Click
        If MySerialPorts.IsOpen Then
            SendData2() '单击发送1区的按钮，发送1区的数据处理
        Else
            MessageBox.Show("串口未打开", "错误提示")
        End If
    End Sub
    Private Sub btnSendData3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendData3.Click
        If MySerialPorts.IsOpen Then
            SendData3() '单击发送1区的按钮，发送1区的数据处理
        Else
            MessageBox.Show("串口未打开", "错误提示")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtReceive.Clear() '清空接收区
    End Sub

    Private Sub btnClear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear1.Click
        txtSendData1.Clear() '清空发送区1
    End Sub
    Private Sub btnClear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear2.Click
        txtSendData2.Clear()
    End Sub
    Private Sub btnClear3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear3.Click
        txtSendData3.Clear()
    End Sub

    Private Sub btnClearCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearCount.Click
        intReceiveBytesCount = 0 '清空各计数器
        intSendBytesCount = 0
        intReceiveFramesCount = 0
        intSendBytesFramesCount = 0
        lblReceiveBytes.Text = "0"
        lblSendBytes.Text = "0"
        lblReceiveFrames.Text = "0"
        lblSendFrames.Text = "0"
    End Sub

    Private Sub btnStopDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopDisplay.Click
        If btnStopDisplay.Text = "暂停" Then '接收区数据显示，暂停处理，暂停后，显示部分条件为假，不再显示
            btnStopDisplay.Text = "继续"
            btnStopDisplay.ForeColor = Color.Red
        Else
            btnStopDisplay.Text = "暂停"
            btnStopDisplay.ForeColor = Color.Black
        End If
    End Sub

    Private Sub chxTimerSend1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chxTimerSend1.CheckedChanged '设置定时器的开关1
        If chxTimerSend1.Checked Then '如果选择定时1发送
            txtTimerSend1.Enabled = False '发送1周期文本框在发送过程中不允许编辑
            Timer1.Interval = Val(txtTimerSend1.Text) '定时器发送周期设置为文本框中的数值
            Timer1.Start() '开起定时器
            ' AddHandler Timer1.Tick, AddressOf timer1Send1
        Else
            txtTimerSend1.Enabled = True '如果没有选择定时发送，则可以编辑时间，最少10ms，停止定时器
            Timer1.Stop()
        End If
    End Sub
    Private Sub chxTimerSend2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chxTimerSend2.CheckedChanged '设置定时器的开关2
        If chxTimerSend2.Checked Then '如果选择定时1发送
            txtTimerSend2.Enabled = False '发送1周期文本框在发送过程中不允许编辑
            Timer2.Interval = Val(txtTimerSend2.Text) '定时器发送周期设置为文本框中的数值
            Timer2.Start() '开起定时器
            ' AddHandler Timer1.Tick, AddressOf timer1Send1
        Else
            txtTimerSend2.Enabled = True '如果没有选择定时发送，则可以编辑时间，最少10ms，停止定时器
            Timer2.Stop()
        End If
    End Sub
    Private Sub chxTimerSend3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chxTimerSend3.CheckedChanged '设置定时器的开关3
        If chxTimerSend3.Checked Then '如果选择定时1发送
            txtTimerSend3.Enabled = False '发送1周期文本框在发送过程中不允许编辑
            Timer3.Interval = Val(txtTimerSend3.Text) '定时器发送周期设置为文本框中的数值
            Timer3.Start() '开起定时器
            ' AddHandler Timer1.Tick, AddressOf timer1Send1
        Else
            txtTimerSend3.Enabled = True '如果没有选择定时发送，则可以编辑时间，最少10ms，停止定时器
            Timer3.Stop()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick '定时器1的Tick事件,定时时间到就执行
        If MySerialPorts.IsOpen = True Then '如果串口打开了，就定时发送数据
            SendData1()
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick '定时器2的Tick事件,定时时间到就执行
        If MySerialPorts.IsOpen = True Then '如果串口打开了，就定时发送数据
            SendData2()
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick '定时器3的Tick事件,定时时间到就执行
        If MySerialPorts.IsOpen = True Then '如果串口打开了，就定时发送数据
            SendData3()
        End If
    End Sub
    Private Sub SendData1()
        If chxHexSend1.Checked Then
            boolHexSelectFlag = True '标记十六进制发送位
        Else
            boolHexSelectFlag = False
        End If
        SendData(txtSendData1.Text) '处理发送区数据
    End Sub
    Private Sub SendData2()
        If chxHexSend2.Checked Then
            boolHexSelectFlag = True '标记十六进制发送位
        Else
            boolHexSelectFlag = False
        End If
        SendData(txtSendData2.Text) '处理发送区数据
    End Sub
    Private Sub SendData3()
        If chxHexSend3.Checked Then
            boolHexSelectFlag = True '标记十六进制发送位
        Else
            boolHexSelectFlag = False
        End If
        SendData(txtSendData3.Text) '处理发送区数据
    End Sub
    Private Sub SendData(ByVal strSendString As String) '发送数据处理
        Try
            If strSendString.Length > 0 Then '如果发送的字符不为空，必须先处理要发送的文本，不然十六进制发送时会发生很多错误
                If boolHexSelectFlag Then '以十六进制发送显示
                    '***********区域部分为对要发送的字符串的格式化，很重要****************************
                    '思想：对发送的十六进制数格式的处理，去除其中多余的空格
                    Dim intSendStringCount As Integer '存储发送区文本长度
                    intSendStringCount = strSendString.Length '计算发送区文本长度
                    For i = intSendStringCount To 1 Step -1 '必须去除文本中多余的空格，因文本中最多有intSendStringCount个空格，循环查询依次替换成1个空格
                        strSendString = Replace(strSendString, Space(i), " ")
                    Next
                    strSendString = Trim(strSendString) '用Trim方法去除字符串的首尾空格
                    '***********************************************************************************
                    If strSendString.Length > 0 Then '字符串处理完毕后，如果不为空，则发送处理
                        Try
                            Dim strTextArray() As String = Split(strSendString) '分离发送1文本框中的数据
                            Dim hexBytes() As Byte '定义一个存储十六进制数据的字节数组
                            ReDim hexBytes(strTextArray.Length - 1) '重新定义数组长度
                            Dim intCount As Integer '定义一个计数器，发送数组中的长度
                            intSendBytesCount += strTextArray.Length '获取文本框中发送字节数目，发送字节计数器
                            For intCount = 0 To strTextArray.Length - 1 '将所有字符转换为十六进制，并存入字节数组
                                hexBytes(intCount) = Val("&h" & strTextArray(intCount)) '十六进制字符串转为十六进制格式数的函数
                            Next
                            MySerialPorts.Write(hexBytes, 0, hexBytes.Length) '以十六进制发送所有数据
                            If btnStopDisplay.Text = "暂停" Then txtReceive.AppendText(vbCrLf + "[TX]" + strSendString) '在接收区以字符串形式显示发送的数据
                            intSendBytesFramesCount += 1 '发送帧计数
                            lblSendFrames.Text = intSendBytesFramesCount.ToString '发送帧计数显示更新
                            lblSendBytes.Text = intSendBytesCount.ToString '发送字节显示更新
                        Catch ex As Exception
                            If chxTimerSend1.Checked Then chxTimerSend1.Checked = False '避免定时器1反复进入错误处理
                            If chxTimerSend2.Checked Then chxTimerSend2.Checked = False '避免定时器1反复进入错误处理
                            If chxTimerSend2.Checked Then chxTimerSend2.Checked = False '避免定时器1反复进入错误处理
                            MessageBox.Show("请输入正确发送格式的十六进制数", "十六进制输入错误提示")
                        End Try
                    End If
                Else '默认以字符串形式发送数据
                    Dim strInPut As String '定义存储发送区中字符串的变量
                    strInPut = strSendString  '获取发送区中的字符串
                    MySerialPorts.Write(strInPut) '发送数据
                    intSendBytesCount += strInPut.Length  '获取发送字节数
                    If btnStopDisplay.Text = "暂停" Then txtReceive.AppendText(vbCrLf + "[TX]" + strInPut) '追加文本显示，而不是赋值，可以不擦除之前显示
                    intSendBytesFramesCount += 1 '发送帧累加计数
                    lblSendFrames.Text = intSendBytesFramesCount.ToString '更新显示
                    lblSendBytes.Text = intSendBytesCount.ToString '更新显示
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "发送数据错误提示")
        End Try
    End Sub
    Private Sub txtTimerSend1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTimerSend1.TextChanged '改变定时器1时间
        If Val(txtTimerSend1.Text) <= 10 Then '定时器最小自动发送间隔设置为10ms
            Timer1.Interval = 10
            txtTimerSend1.Text = "10"
        Else
            Timer1.Interval = Val(txtTimerSend1.Text)
        End If
    End Sub
    Private Sub txtTimerSend2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTimerSend2.TextChanged '改变定时器2时间
        If Val(txtTimerSend2.Text) <= 10 Then '定时器最小自动发送间隔设置为10ms
            Timer2.Interval = 10
            txtTimerSend2.Text = "10"
        Else
            Timer2.Interval = Val(txtTimerSend2.Text)
        End If
    End Sub
    Private Sub txtTimerSend3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTimerSend3.TextChanged '改变定时器3时间
        If Val(txtTimerSend3.Text) <= 10 Then '定时器最小自动发送间隔设置为10ms
            Timer3.Interval = 10
            txtTimerSend3.Text = "10"
        Else
            Timer3.Interval = Val(txtTimerSend3.Text)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click '保存收到的数据
        With SaveFileDialog1
            .DefaultExt = "txt"
            .FileName = strFileName
            .Filter = " Text Decuments (*.txt) | *.txt|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True '覆盖原文件设置
            .Title = "保存接收到的数据"
        End With
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = SaveFileDialog1.FileName
                My.Computer.FileSystem.WriteAllText(strFileName, txtReceive.Text, False)
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnOpen1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen1.Click '打开要发送的数据文件1
        With OpenFileDialog1
            .Filter = " Text Decuments (*.txt) | *.txt|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "请选择要要打开发送的文件"
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = OpenFileDialog1.FileName
                Dim fileContents As String
                fileContents = My.Computer.FileSystem.ReadAllText(strFileName)
                txtSendData1.Text = fileContents
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnOpen2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen2.Click '打开要发送的数据文件2
        With OpenFileDialog1
            .Filter = " Text Decuments (*.txt) | *.txt|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "请选择要要打开发送的文件"
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = OpenFileDialog1.FileName
                Dim fileContents As String
                fileContents = My.Computer.FileSystem.ReadAllText(strFileName)
                txtSendData2.Text = fileContents
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnOpen3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen3.Click '打开要发送的数据文件3
        With OpenFileDialog1
            .Filter = " Text Decuments (*.txt) | *.txt|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "请选择要要打开发送的文件"
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = OpenFileDialog1.FileName
                Dim fileContents As String
                fileContents = My.Computer.FileSystem.ReadAllText(strFileName)
                txtSendData3.Text = fileContents
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub chxAutoClear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chxAutoClear.CheckedChanged
        If chxAutoClear.Checked Then '检测是否选择显示区自动清空
            boolAutoClearFlag = 1 '自动清
        Else
            boolAutoClearFlag = 0 '不自动清
        End If
    End Sub


    Private Sub btnParitySum1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParitySum1.Click
        If chxHexSend1.Checked Then
            boolHexSelectFlag = True
        Else
            boolHexSelectFlag = False
        End If
        Try
            txtSendData1.AppendText(ParitySum(txtSendData1.Text)) '计算显示校验和
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnParitySum2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParitySum2.Click
        If chxHexSend2.Checked Then
            boolHexSelectFlag = True
        Else
            boolHexSelectFlag = False
        End If
        Try
            txtSendData2.AppendText(ParitySum(txtSendData2.Text)) '计算显示校验和
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnParitySum3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParitySum3.Click
        If chxHexSend3.Checked Then
            boolHexSelectFlag = True
        Else
            boolHexSelectFlag = False
        End If
        Try
            txtSendData3.AppendText(ParitySum(txtSendData3.Text)) '计算显示校验和
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function ParitySum(ByVal strSendString As String) '校验和计算
        Dim strSendStringSum As String = "" '存储校验和的字符串变量
        If strSendString.Length > 0 Then '如果发送的字符不为空，必须先处理要发送的文本，不然十六进制发送时会发生很多错误
            If boolHexSelectFlag Then '以十六进制发送
                Dim intSendStringCount As Integer  '存储发送区文本长度
                intSendStringCount = strSendString.Length '计算发送区文本长度
                For i = intSendStringCount To 1 Step -1 '必须去除文本中多余的空格，因文本中最多有intSendStringCount个空格，循环查询依次替换成1个空格
                    strSendString = Replace(strSendString, Space(i), " ") '替换函数，注意格式
                Next
                strSendString = Trim(strSendString) '用Trim方法去除字符串的首位空格
                Dim strTextArray() As String = Split(strSendString) '分离发送1文本框中的数据
                ' Dim hexBytes() As Byte '定义一个存储十六进制数据的字节数组
                Dim hexSum As UInteger  '定义整型变量存储十六进制累加和
                ' ReDim hexBytes(strTextArray.Length - 1) '重新定义数组长度
                Dim intCount As Integer '定义一个计数器，发送数组中的长度
                intSendBytesCount += strTextArray.Length '获取文本框中发送字节数目，发送字节计数器
                For intCount = 0 To strTextArray.Length - 1 '将所有字符转换为十六进制，并累加
                    hexSum += CInt("&h" & strTextArray(intCount)) '把所有十六进制转化为整型，再累加
                Next
                '校验和的低八位截取：整型和hexSum转换为十六进制字符串的后两个字符
                If rabtnParityLowByte.Checked Then
                    If Hex(hexSum).Length < 2 Then
                        strSendStringSum = " " & "0" & Hex(hexSum).Substring(Hex(hexSum).Length - 1) '如果不足两位，补0，仅截取最后两位，即低字节
                    Else
                        strSendStringSum = " " & Hex(hexSum).Substring(Hex(hexSum).Length - 2) '仅截取最后两位，即低字节
                    End If
                End If
                If rabtnParitySumHLByte.Checked Then
                    If Hex(hexSum).Length < 2 Then
                        strSendStringSum = " " & "0" & Hex(hexSum).Substring(Hex(hexSum).Length - 1) & " " & "00" '如果只有1位，低字节补0，高字节补00
                    ElseIf Hex(hexSum).Length = 2 Then
                        strSendStringSum = " " & Hex(hexSum).Substring(Hex(hexSum).Length - 2) & " " & "00" '如果只有2位，先截取校验和的后2位，再补00，即高八位
                    ElseIf Hex(hexSum).Length = 3 Then
                        strSendStringSum = " " & Hex(hexSum).Substring(Hex(hexSum).Length - 2) & " " _
                             & "0" & (Hex(hexSum).Substring(Hex(hexSum).Length - 3)).Substring(0, 1) '如果只有3位，先截取校验和的后3位，再补0，即高八位
                    Else
                        strSendStringSum = " " & Hex(hexSum).Substring(Hex(hexSum).Length - 2) & " " _
                             & (Hex(hexSum).Substring(Hex(hexSum).Length - 4)).Substring(0, 2) '加上高字节八位的十六机制形式，先截取校验和的后4位，再截取后四位的前两位，即高八位
                    End If
                End If
            End If
        End If
        Return strSendStringSum
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
