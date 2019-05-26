<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSerialPort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSerialPort))
        Me.cbxComName = New System.Windows.Forms.ComboBox()
        Me.cbxBoudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxDataBits = New System.Windows.Forms.ComboBox()
        Me.cbxParityBits = New System.Windows.Forms.ComboBox()
        Me.cbxStopBits = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOpenSerialPort = New System.Windows.Forms.Button()
        Me.lblComStatus = New System.Windows.Forms.Label()
        Me.txtSendData1 = New System.Windows.Forms.TextBox()
        Me.txtReceive = New System.Windows.Forms.TextBox()
        Me.btnSendData1 = New System.Windows.Forms.Button()
        Me.btnSendData2 = New System.Windows.Forms.Button()
        Me.btnSendData3 = New System.Windows.Forms.Button()
        Me.txtSendData2 = New System.Windows.Forms.TextBox()
        Me.txtSendData3 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chxHex = New System.Windows.Forms.CheckBox()
        Me.btnClear1 = New System.Windows.Forms.Button()
        Me.chxHexSend1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSendFrames = New System.Windows.Forms.Label()
        Me.lblSendBytes = New System.Windows.Forms.Label()
        Me.lblReceiveFrames = New System.Windows.Forms.Label()
        Me.lblReceiveBytes = New System.Windows.Forms.Label()
        Me.btnClearCount = New System.Windows.Forms.Button()
        Me.btnStopDisplay = New System.Windows.Forms.Button()
        Me.chxTimerSend1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTimerSend1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTimerSend2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chxTimerSend2 = New System.Windows.Forms.CheckBox()
        Me.chxHexSend2 = New System.Windows.Forms.CheckBox()
        Me.btnClear2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTimerSend3 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.chxTimerSend3 = New System.Windows.Forms.CheckBox()
        Me.chxHexSend3 = New System.Windows.Forms.CheckBox()
        Me.btnClear3 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnOpen1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpen2 = New System.Windows.Forms.Button()
        Me.btnOpen3 = New System.Windows.Forms.Button()
        Me.chxAutoClear = New System.Windows.Forms.CheckBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rabtnParitySumHLByte = New System.Windows.Forms.RadioButton()
        Me.rabtnParityLowByte = New System.Windows.Forms.RadioButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnParitySum3 = New System.Windows.Forms.Button()
        Me.btnParitySum2 = New System.Windows.Forms.Button()
        Me.btnParitySum1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnFormExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxComName
        '
        Me.cbxComName.AccessibleDescription = ""
        Me.cbxComName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxComName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxComName.FormattingEnabled = True
        Me.cbxComName.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16", "COM17", "COM18", "COM19", "COM20"})
        Me.cbxComName.Location = New System.Drawing.Point(49, 15)
        Me.cbxComName.Name = "cbxComName"
        Me.cbxComName.Size = New System.Drawing.Size(64, 20)
        Me.cbxComName.TabIndex = 0
        '
        'cbxBoudRate
        '
        Me.cbxBoudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBoudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxBoudRate.FormattingEnabled = True
        Me.cbxBoudRate.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200", "230400", "460800", "921600"})
        Me.cbxBoudRate.Location = New System.Drawing.Point(49, 37)
        Me.cbxBoudRate.Name = "cbxBoudRate"
        Me.cbxBoudRate.Size = New System.Drawing.Size(64, 20)
        Me.cbxBoudRate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COM口"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "波特率"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "数据位"
        '
        'cbxDataBits
        '
        Me.cbxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDataBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxDataBits.FormattingEnabled = True
        Me.cbxDataBits.Items.AddRange(New Object() {"8", "7", "6", "5"})
        Me.cbxDataBits.Location = New System.Drawing.Point(49, 59)
        Me.cbxDataBits.Name = "cbxDataBits"
        Me.cbxDataBits.Size = New System.Drawing.Size(64, 20)
        Me.cbxDataBits.TabIndex = 5
        '
        'cbxParityBits
        '
        Me.cbxParityBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxParityBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxParityBits.FormattingEnabled = True
        Me.cbxParityBits.Items.AddRange(New Object() {"0", "1", "2"})
        Me.cbxParityBits.Location = New System.Drawing.Point(49, 81)
        Me.cbxParityBits.Name = "cbxParityBits"
        Me.cbxParityBits.Size = New System.Drawing.Size(64, 20)
        Me.cbxParityBits.TabIndex = 6
        '
        'cbxStopBits
        '
        Me.cbxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStopBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxStopBits.FormattingEnabled = True
        Me.cbxStopBits.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.cbxStopBits.Location = New System.Drawing.Point(49, 103)
        Me.cbxStopBits.Name = "cbxStopBits"
        Me.cbxStopBits.Size = New System.Drawing.Size(64, 20)
        Me.cbxStopBits.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "校验位"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "停止位"
        '
        'btnOpenSerialPort
        '
        Me.btnOpenSerialPort.BackColor = System.Drawing.SystemColors.Menu
        Me.btnOpenSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpenSerialPort.Location = New System.Drawing.Point(46, 127)
        Me.btnOpenSerialPort.Name = "btnOpenSerialPort"
        Me.btnOpenSerialPort.Size = New System.Drawing.Size(67, 26)
        Me.btnOpenSerialPort.TabIndex = 10
        Me.btnOpenSerialPort.Text = "打开串口"
        Me.btnOpenSerialPort.UseVisualStyleBackColor = False
        '
        'lblComStatus
        '
        Me.lblComStatus.AutoSize = True
        Me.lblComStatus.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblComStatus.Location = New System.Drawing.Point(4, 117)
        Me.lblComStatus.Name = "lblComStatus"
        Me.lblComStatus.Size = New System.Drawing.Size(39, 41)
        Me.lblComStatus.TabIndex = 11
        Me.lblComStatus.Text = "●"
        '
        'txtSendData1
        '
        Me.txtSendData1.AllowDrop = True
        Me.txtSendData1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSendData1.BackColor = System.Drawing.SystemColors.Window
        Me.txtSendData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSendData1.Location = New System.Drawing.Point(248, 345)
        Me.txtSendData1.Multiline = True
        Me.txtSendData1.Name = "txtSendData1"
        Me.txtSendData1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSendData1.Size = New System.Drawing.Size(505, 30)
        Me.txtSendData1.TabIndex = 12
        '
        'txtReceive
        '
        Me.txtReceive.AllowDrop = True
        Me.txtReceive.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReceive.BackColor = System.Drawing.Color.White
        Me.txtReceive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReceive.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReceive.ForeColor = System.Drawing.Color.Black
        Me.txtReceive.Location = New System.Drawing.Point(250, 5)
        Me.txtReceive.Multiline = True
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.ReadOnly = True
        Me.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReceive.Size = New System.Drawing.Size(573, 316)
        Me.txtReceive.TabIndex = 13
        '
        'btnSendData1
        '
        Me.btnSendData1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSendData1.BackColor = System.Drawing.SystemColors.Menu
        Me.btnSendData1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSendData1.Location = New System.Drawing.Point(173, 16)
        Me.btnSendData1.Name = "btnSendData1"
        Me.btnSendData1.Size = New System.Drawing.Size(58, 30)
        Me.btnSendData1.TabIndex = 14
        Me.btnSendData1.Text = "发送1"
        Me.btnSendData1.UseVisualStyleBackColor = False
        '
        'btnSendData2
        '
        Me.btnSendData2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSendData2.BackColor = System.Drawing.SystemColors.Menu
        Me.btnSendData2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSendData2.Location = New System.Drawing.Point(172, 49)
        Me.btnSendData2.Name = "btnSendData2"
        Me.btnSendData2.Size = New System.Drawing.Size(58, 30)
        Me.btnSendData2.TabIndex = 16
        Me.btnSendData2.Text = "发送2"
        Me.btnSendData2.UseVisualStyleBackColor = False
        '
        'btnSendData3
        '
        Me.btnSendData3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSendData3.BackColor = System.Drawing.SystemColors.Menu
        Me.btnSendData3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSendData3.Location = New System.Drawing.Point(172, 82)
        Me.btnSendData3.Name = "btnSendData3"
        Me.btnSendData3.Size = New System.Drawing.Size(58, 30)
        Me.btnSendData3.TabIndex = 17
        Me.btnSendData3.Text = "发送3"
        Me.btnSendData3.UseVisualStyleBackColor = False
        '
        'txtSendData2
        '
        Me.txtSendData2.AllowDrop = True
        Me.txtSendData2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSendData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSendData2.Location = New System.Drawing.Point(248, 378)
        Me.txtSendData2.Multiline = True
        Me.txtSendData2.Name = "txtSendData2"
        Me.txtSendData2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSendData2.Size = New System.Drawing.Size(505, 30)
        Me.txtSendData2.TabIndex = 18
        '
        'txtSendData3
        '
        Me.txtSendData3.AllowDrop = True
        Me.txtSendData3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSendData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSendData3.Location = New System.Drawing.Point(248, 411)
        Me.txtSendData3.Multiline = True
        Me.txtSendData3.Name = "txtSendData3"
        Me.txtSendData3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSendData3.Size = New System.Drawing.Size(505, 30)
        Me.txtSendData3.TabIndex = 19
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Menu
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(12, 216)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(67, 23)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "清空接收"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'chxHex
        '
        Me.chxHex.AutoSize = True
        Me.chxHex.Checked = True
        Me.chxHex.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chxHex.Location = New System.Drawing.Point(6, 139)
        Me.chxHex.Name = "chxHex"
        Me.chxHex.Size = New System.Drawing.Size(66, 16)
        Me.chxHex.TabIndex = 24
        Me.chxHex.Text = "hex接收"
        Me.chxHex.UseVisualStyleBackColor = True
        '
        'btnClear1
        '
        Me.btnClear1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear1.BackColor = System.Drawing.SystemColors.Menu
        Me.btnClear1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear1.Location = New System.Drawing.Point(129, 16)
        Me.btnClear1.Name = "btnClear1"
        Me.btnClear1.Size = New System.Drawing.Size(42, 30)
        Me.btnClear1.TabIndex = 25
        Me.btnClear1.Text = "清空"
        Me.btnClear1.UseVisualStyleBackColor = False
        '
        'chxHexSend1
        '
        Me.chxHexSend1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chxHexSend1.AutoSize = True
        Me.chxHexSend1.Checked = True
        Me.chxHexSend1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chxHexSend1.Location = New System.Drawing.Point(57, 16)
        Me.chxHexSend1.Name = "chxHexSend1"
        Me.chxHexSend1.Size = New System.Drawing.Size(72, 16)
        Me.chxHexSend1.TabIndex = 26
        Me.chxHexSend1.Text = "十六进制"
        Me.chxHexSend1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "发帧数"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "收帧数"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "发字节"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "收字节"
        '
        'lblSendFrames
        '
        Me.lblSendFrames.AutoSize = True
        Me.lblSendFrames.Location = New System.Drawing.Point(47, 10)
        Me.lblSendFrames.Name = "lblSendFrames"
        Me.lblSendFrames.Size = New System.Drawing.Size(11, 12)
        Me.lblSendFrames.TabIndex = 31
        Me.lblSendFrames.Text = "0"
        '
        'lblSendBytes
        '
        Me.lblSendBytes.AutoSize = True
        Me.lblSendBytes.Location = New System.Drawing.Point(47, 24)
        Me.lblSendBytes.Name = "lblSendBytes"
        Me.lblSendBytes.Size = New System.Drawing.Size(11, 12)
        Me.lblSendBytes.TabIndex = 32
        Me.lblSendBytes.Text = "0"
        '
        'lblReceiveFrames
        '
        Me.lblReceiveFrames.AutoSize = True
        Me.lblReceiveFrames.Location = New System.Drawing.Point(47, 37)
        Me.lblReceiveFrames.Name = "lblReceiveFrames"
        Me.lblReceiveFrames.Size = New System.Drawing.Size(11, 12)
        Me.lblReceiveFrames.TabIndex = 33
        Me.lblReceiveFrames.Text = "0"
        '
        'lblReceiveBytes
        '
        Me.lblReceiveBytes.AutoSize = True
        Me.lblReceiveBytes.Location = New System.Drawing.Point(47, 52)
        Me.lblReceiveBytes.Name = "lblReceiveBytes"
        Me.lblReceiveBytes.Size = New System.Drawing.Size(11, 12)
        Me.lblReceiveBytes.TabIndex = 34
        Me.lblReceiveBytes.Text = "0"
        '
        'btnClearCount
        '
        Me.btnClearCount.BackColor = System.Drawing.SystemColors.Menu
        Me.btnClearCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearCount.Location = New System.Drawing.Point(9, 107)
        Me.btnClearCount.Name = "btnClearCount"
        Me.btnClearCount.Size = New System.Drawing.Size(42, 23)
        Me.btnClearCount.TabIndex = 35
        Me.btnClearCount.Text = "清零"
        Me.btnClearCount.UseVisualStyleBackColor = False
        '
        'btnStopDisplay
        '
        Me.btnStopDisplay.BackColor = System.Drawing.SystemColors.Menu
        Me.btnStopDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStopDisplay.Location = New System.Drawing.Point(7, 76)
        Me.btnStopDisplay.Name = "btnStopDisplay"
        Me.btnStopDisplay.Size = New System.Drawing.Size(47, 23)
        Me.btnStopDisplay.TabIndex = 36
        Me.btnStopDisplay.Text = "暂停"
        Me.btnStopDisplay.UseVisualStyleBackColor = False
        '
        'chxTimerSend1
        '
        Me.chxTimerSend1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chxTimerSend1.AutoSize = True
        Me.chxTimerSend1.Location = New System.Drawing.Point(6, 17)
        Me.chxTimerSend1.Name = "chxTimerSend1"
        Me.chxTimerSend1.Size = New System.Drawing.Size(48, 16)
        Me.chxTimerSend1.TabIndex = 37
        Me.chxTimerSend1.Text = "定时"
        Me.chxTimerSend1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(258, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 12)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "注:hex数据发送格式""FF FF FF...""."
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "发送周期"
        '
        'txtTimerSend1
        '
        Me.txtTimerSend1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTimerSend1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimerSend1.Location = New System.Drawing.Point(58, 32)
        Me.txtTimerSend1.Multiline = True
        Me.txtTimerSend1.Name = "txtTimerSend1"
        Me.txtTimerSend1.Size = New System.Drawing.Size(50, 16)
        Me.txtTimerSend1.TabIndex = 40
        Me.txtTimerSend1.Text = "1000"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(110, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 12)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "ms"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(110, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 12)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "ms"
        '
        'txtTimerSend2
        '
        Me.txtTimerSend2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTimerSend2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimerSend2.Location = New System.Drawing.Point(58, 65)
        Me.txtTimerSend2.Multiline = True
        Me.txtTimerSend2.Name = "txtTimerSend2"
        Me.txtTimerSend2.Size = New System.Drawing.Size(50, 16)
        Me.txtTimerSend2.TabIndex = 46
        Me.txtTimerSend2.Text = "500"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "发送周期"
        '
        'chxTimerSend2
        '
        Me.chxTimerSend2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chxTimerSend2.AutoSize = True
        Me.chxTimerSend2.Location = New System.Drawing.Point(6, 51)
        Me.chxTimerSend2.Name = "chxTimerSend2"
        Me.chxTimerSend2.Size = New System.Drawing.Size(48, 16)
        Me.chxTimerSend2.TabIndex = 44
        Me.chxTimerSend2.Text = "定时"
        Me.chxTimerSend2.UseVisualStyleBackColor = True
        '
        'chxHexSend2
        '
        Me.chxHexSend2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chxHexSend2.AutoSize = True
        Me.chxHexSend2.Checked = True
        Me.chxHexSend2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chxHexSend2.Location = New System.Drawing.Point(57, 50)
        Me.chxHexSend2.Name = "chxHexSend2"
        Me.chxHexSend2.Size = New System.Drawing.Size(72, 16)
        Me.chxHexSend2.TabIndex = 43
        Me.chxHexSend2.Text = "十六进制"
        Me.chxHexSend2.UseVisualStyleBackColor = True
        '
        'btnClear2
        '
        Me.btnClear2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear2.BackColor = System.Drawing.SystemColors.Menu
        Me.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear2.Location = New System.Drawing.Point(129, 49)
        Me.btnClear2.Name = "btnClear2"
        Me.btnClear2.Size = New System.Drawing.Size(42, 30)
        Me.btnClear2.TabIndex = 42
        Me.btnClear2.Text = "清空"
        Me.btnClear2.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(110, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 12)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "ms"
        '
        'txtTimerSend3
        '
        Me.txtTimerSend3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTimerSend3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimerSend3.Location = New System.Drawing.Point(58, 96)
        Me.txtTimerSend3.Multiline = True
        Me.txtTimerSend3.Name = "txtTimerSend3"
        Me.txtTimerSend3.Size = New System.Drawing.Size(50, 16)
        Me.txtTimerSend3.TabIndex = 52
        Me.txtTimerSend3.Text = "1000"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "发送周期"
        '
        'chxTimerSend3
        '
        Me.chxTimerSend3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chxTimerSend3.AutoSize = True
        Me.chxTimerSend3.Location = New System.Drawing.Point(6, 83)
        Me.chxTimerSend3.Name = "chxTimerSend3"
        Me.chxTimerSend3.Size = New System.Drawing.Size(48, 16)
        Me.chxTimerSend3.TabIndex = 50
        Me.chxTimerSend3.Text = "定时"
        Me.chxTimerSend3.UseVisualStyleBackColor = True
        '
        'chxHexSend3
        '
        Me.chxHexSend3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chxHexSend3.AutoSize = True
        Me.chxHexSend3.Checked = True
        Me.chxHexSend3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chxHexSend3.Location = New System.Drawing.Point(57, 81)
        Me.chxHexSend3.Name = "chxHexSend3"
        Me.chxHexSend3.Size = New System.Drawing.Size(72, 16)
        Me.chxHexSend3.TabIndex = 49
        Me.chxHexSend3.Text = "十六进制"
        Me.chxHexSend3.UseVisualStyleBackColor = True
        '
        'btnClear3
        '
        Me.btnClear3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear3.BackColor = System.Drawing.SystemColors.Menu
        Me.btnClear3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear3.Location = New System.Drawing.Point(129, 82)
        Me.btnClear3.Name = "btnClear3"
        Me.btnClear3.Size = New System.Drawing.Size(42, 30)
        Me.btnClear3.TabIndex = 48
        Me.btnClear3.Text = "清空"
        Me.btnClear3.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Menu
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(12, 187)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 23)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "保存数据"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnOpen1
        '
        Me.btnOpen1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen1.BackColor = System.Drawing.SystemColors.Menu
        Me.btnOpen1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpen1.Font = New System.Drawing.Font("宋体", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOpen1.Location = New System.Drawing.Point(759, 345)
        Me.btnOpen1.Name = "btnOpen1"
        Me.btnOpen1.Size = New System.Drawing.Size(64, 30)
        Me.btnOpen1.TabIndex = 55
        Me.btnOpen1.Text = "打开"
        Me.btnOpen1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnOpen2
        '
        Me.btnOpen2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen2.BackColor = System.Drawing.SystemColors.Menu
        Me.btnOpen2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpen2.Font = New System.Drawing.Font("宋体", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOpen2.Location = New System.Drawing.Point(759, 378)
        Me.btnOpen2.Name = "btnOpen2"
        Me.btnOpen2.Size = New System.Drawing.Size(64, 30)
        Me.btnOpen2.TabIndex = 56
        Me.btnOpen2.Text = "打开"
        Me.btnOpen2.UseVisualStyleBackColor = False
        '
        'btnOpen3
        '
        Me.btnOpen3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen3.BackColor = System.Drawing.SystemColors.Menu
        Me.btnOpen3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOpen3.Font = New System.Drawing.Font("宋体", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOpen3.Location = New System.Drawing.Point(759, 411)
        Me.btnOpen3.Name = "btnOpen3"
        Me.btnOpen3.Size = New System.Drawing.Size(64, 30)
        Me.btnOpen3.TabIndex = 57
        Me.btnOpen3.Text = "打开"
        Me.btnOpen3.UseVisualStyleBackColor = False
        '
        'chxAutoClear
        '
        Me.chxAutoClear.AutoSize = True
        Me.chxAutoClear.Checked = True
        Me.chxAutoClear.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chxAutoClear.Location = New System.Drawing.Point(6, 165)
        Me.chxAutoClear.Name = "chxAutoClear"
        Me.chxAutoClear.Size = New System.Drawing.Size(72, 16)
        Me.chxAutoClear.TabIndex = 63
        Me.chxAutoClear.Text = "自动清空"
        Me.chxAutoClear.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.BackColor = System.Drawing.SystemColors.Window
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.Location = New System.Drawing.Point(173, 36)
        Me.txtFilter.Multiline = True
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(55, 18)
        Me.txtFilter.TabIndex = 67
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chxHexSend1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtTimerSend2)
        Me.GroupBox1.Controls.Add(Me.btnClear3)
        Me.GroupBox1.Controls.Add(Me.btnSendData1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.chxHexSend3)
        Me.GroupBox1.Controls.Add(Me.btnSendData2)
        Me.GroupBox1.Controls.Add(Me.chxTimerSend2)
        Me.GroupBox1.Controls.Add(Me.chxTimerSend3)
        Me.GroupBox1.Controls.Add(Me.btnSendData3)
        Me.GroupBox1.Controls.Add(Me.chxHexSend2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.btnClear1)
        Me.GroupBox1.Controls.Add(Me.btnClear2)
        Me.GroupBox1.Controls.Add(Me.txtTimerSend3)
        Me.GroupBox1.Controls.Add(Me.chxTimerSend1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtTimerSend1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 115)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "发送区属性"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.rabtnParitySumHLByte)
        Me.GroupBox2.Controls.Add(Me.rabtnParityLowByte)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.btnParitySum3)
        Me.GroupBox2.Controls.Add(Me.btnParitySum2)
        Me.GroupBox2.Controls.Add(Me.btnParitySum1)
        Me.GroupBox2.Controls.Add(Me.txtFilter)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 63)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "校验和计算过滤区"
        '
        'rabtnParitySumHLByte
        '
        Me.rabtnParitySumHLByte.AutoSize = True
        Me.rabtnParitySumHLByte.Location = New System.Drawing.Point(82, 14)
        Me.rabtnParitySumHLByte.Name = "rabtnParitySumHLByte"
        Me.rabtnParitySumHLByte.Size = New System.Drawing.Size(83, 16)
        Me.rabtnParitySumHLByte.TabIndex = 73
        Me.rabtnParitySumHLByte.Text = "低、高字节"
        Me.rabtnParitySumHLByte.UseVisualStyleBackColor = True
        '
        'rabtnParityLowByte
        '
        Me.rabtnParityLowByte.AutoSize = True
        Me.rabtnParityLowByte.Checked = True
        Me.rabtnParityLowByte.Location = New System.Drawing.Point(7, 14)
        Me.rabtnParityLowByte.Name = "rabtnParityLowByte"
        Me.rabtnParityLowByte.Size = New System.Drawing.Size(71, 16)
        Me.rabtnParityLowByte.TabIndex = 71
        Me.rabtnParityLowByte.TabStop = True
        Me.rabtnParityLowByte.Text = "仅低字节"
        Me.rabtnParityLowByte.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(175, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 12)
        Me.Label20.TabIndex = 70
        Me.Label20.Text = "帧关键字"
        '
        'btnParitySum3
        '
        Me.btnParitySum3.BackColor = System.Drawing.SystemColors.Menu
        Me.btnParitySum3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnParitySum3.Location = New System.Drawing.Point(112, 33)
        Me.btnParitySum3.Name = "btnParitySum3"
        Me.btnParitySum3.Size = New System.Drawing.Size(55, 23)
        Me.btnParitySum3.TabIndex = 70
        Me.btnParitySum3.Text = "校验3区"
        Me.btnParitySum3.UseVisualStyleBackColor = False
        '
        'btnParitySum2
        '
        Me.btnParitySum2.BackColor = System.Drawing.SystemColors.Menu
        Me.btnParitySum2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnParitySum2.Location = New System.Drawing.Point(57, 33)
        Me.btnParitySum2.Name = "btnParitySum2"
        Me.btnParitySum2.Size = New System.Drawing.Size(55, 23)
        Me.btnParitySum2.TabIndex = 69
        Me.btnParitySum2.Text = "校验2区"
        Me.btnParitySum2.UseVisualStyleBackColor = False
        '
        'btnParitySum1
        '
        Me.btnParitySum1.BackColor = System.Drawing.SystemColors.Menu
        Me.btnParitySum1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnParitySum1.Location = New System.Drawing.Point(2, 33)
        Me.btnParitySum1.Name = "btnParitySum1"
        Me.btnParitySum1.Size = New System.Drawing.Size(55, 23)
        Me.btnParitySum1.TabIndex = 68
        Me.btnParitySum1.Text = "校验1区"
        Me.btnParitySum1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cbxComName)
        Me.GroupBox3.Controls.Add(Me.btnFormExit)
        Me.GroupBox3.Controls.Add(Me.cbxBoudRate)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbxDataBits)
        Me.GroupBox3.Controls.Add(Me.cbxParityBits)
        Me.GroupBox3.Controls.Add(Me.cbxStopBits)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btnOpenSerialPort)
        Me.GroupBox3.Controls.Add(Me.lblComStatus)
        Me.GroupBox3.Location = New System.Drawing.Point(5, -4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(129, 209)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'btnFormExit
        '
        Me.btnFormExit.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFormExit.Location = New System.Drawing.Point(7, 165)
        Me.btnFormExit.Name = "btnFormExit"
        Me.btnFormExit.Size = New System.Drawing.Size(42, 23)
        Me.btnFormExit.TabIndex = 74
        Me.btnFormExit.Text = "退出"
        Me.btnFormExit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Menu
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(59, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "关于"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Controls.Add(Me.btnClear)
        Me.GroupBox4.Controls.Add(Me.chxHex)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.chxAutoClear)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lblSendFrames)
        Me.GroupBox4.Controls.Add(Me.lblSendBytes)
        Me.GroupBox4.Controls.Add(Me.lblReceiveFrames)
        Me.GroupBox4.Controls.Add(Me.lblReceiveBytes)
        Me.GroupBox4.Controls.Add(Me.btnClearCount)
        Me.GroupBox4.Controls.Add(Me.btnStopDisplay)
        Me.GroupBox4.Location = New System.Drawing.Point(141, -4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(99, 256)
        Me.GroupBox4.TabIndex = 71
        Me.GroupBox4.TabStop = False
        '
        'FormSerialPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(835, 458)
        Me.Controls.Add(Me.txtReceive)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOpen3)
        Me.Controls.Add(Me.btnOpen2)
        Me.Controls.Add(Me.btnOpen1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSendData3)
        Me.Controls.Add(Me.txtSendData2)
        Me.Controls.Add(Me.txtSendData1)
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSerialPort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Q Serial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxComName As System.Windows.Forms.ComboBox
    Friend WithEvents cbxBoudRate As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxDataBits As System.Windows.Forms.ComboBox
    Friend WithEvents cbxParityBits As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStopBits As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnOpenSerialPort As System.Windows.Forms.Button
    Friend WithEvents lblComStatus As System.Windows.Forms.Label
    Friend WithEvents txtSendData1 As System.Windows.Forms.TextBox
    Friend WithEvents txtReceive As System.Windows.Forms.TextBox
    Friend WithEvents btnSendData1 As System.Windows.Forms.Button
    Friend WithEvents btnSendData2 As System.Windows.Forms.Button
    Friend WithEvents btnSendData3 As System.Windows.Forms.Button
    Friend WithEvents txtSendData2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSendData3 As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents chxHex As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear1 As System.Windows.Forms.Button
    Friend WithEvents chxHexSend1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSendFrames As System.Windows.Forms.Label
    Friend WithEvents lblSendBytes As System.Windows.Forms.Label
    Friend WithEvents lblReceiveFrames As System.Windows.Forms.Label
    Friend WithEvents lblReceiveBytes As System.Windows.Forms.Label
    Friend WithEvents btnClearCount As System.Windows.Forms.Button
    Friend WithEvents btnStopDisplay As System.Windows.Forms.Button
    Friend WithEvents chxTimerSend1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTimerSend1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTimerSend2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents chxTimerSend2 As System.Windows.Forms.CheckBox
    Friend WithEvents chxHexSend2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear2 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTimerSend3 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chxTimerSend3 As System.Windows.Forms.CheckBox
    Friend WithEvents chxHexSend3 As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear3 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnOpen1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpen2 As System.Windows.Forms.Button
    Friend WithEvents btnOpen3 As System.Windows.Forms.Button
    Friend WithEvents chxAutoClear As System.Windows.Forms.CheckBox
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnParitySum3 As System.Windows.Forms.Button
    Friend WithEvents btnParitySum2 As System.Windows.Forms.Button
    Friend WithEvents btnParitySum1 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rabtnParitySumHLByte As System.Windows.Forms.RadioButton
    Friend WithEvents rabtnParityLowByte As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnFormExit As System.Windows.Forms.Button

End Class
