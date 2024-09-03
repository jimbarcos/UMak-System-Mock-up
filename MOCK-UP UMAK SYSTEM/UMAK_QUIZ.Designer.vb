<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UMAK_QUIZ
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UMAK_QUIZ))
        Me.BACK_BTN = New System.Windows.Forms.PictureBox()
        Me.OFF = New System.Windows.Forms.PictureBox()
        Me.DTE = New System.Windows.Forms.Label()
        Me.TME = New System.Windows.Forms.Label()
        Me.SYS_D_T = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SIGN_UP_BTN = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BC_tb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BACK_BTN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BACK_BTN
        '
        Me.BACK_BTN.BackColor = System.Drawing.Color.Transparent
        Me.BACK_BTN.Image = CType(resources.GetObject("BACK_BTN.Image"), System.Drawing.Image)
        Me.BACK_BTN.Location = New System.Drawing.Point(-4, 1)
        Me.BACK_BTN.Name = "BACK_BTN"
        Me.BACK_BTN.Size = New System.Drawing.Size(147, 111)
        Me.BACK_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BACK_BTN.TabIndex = 65
        Me.BACK_BTN.TabStop = False
        '
        'OFF
        '
        Me.OFF.BackColor = System.Drawing.Color.Transparent
        Me.OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OFF.Image = CType(resources.GetObject("OFF.Image"), System.Drawing.Image)
        Me.OFF.Location = New System.Drawing.Point(1122, 543)
        Me.OFF.Name = "OFF"
        Me.OFF.Size = New System.Drawing.Size(66, 55)
        Me.OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OFF.TabIndex = 66
        Me.OFF.TabStop = False
        '
        'DTE
        '
        Me.DTE.AutoSize = True
        Me.DTE.BackColor = System.Drawing.Color.Transparent
        Me.DTE.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTE.ForeColor = System.Drawing.Color.White
        Me.DTE.Location = New System.Drawing.Point(12, 543)
        Me.DTE.Name = "DTE"
        Me.DTE.Size = New System.Drawing.Size(66, 23)
        Me.DTE.TabIndex = 67
        Me.DTE.Text = "DATE"
        '
        'TME
        '
        Me.TME.AutoSize = True
        Me.TME.BackColor = System.Drawing.Color.Transparent
        Me.TME.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TME.ForeColor = System.Drawing.Color.White
        Me.TME.Location = New System.Drawing.Point(12, 573)
        Me.TME.Name = "TME"
        Me.TME.Size = New System.Drawing.Size(61, 23)
        Me.TME.TabIndex = 68
        Me.TME.Text = "TIME"
        '
        'SYS_D_T
        '
        Me.SYS_D_T.Enabled = True
        Me.SYS_D_T.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 47.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(169, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(834, 77)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "UNIVERSITY OF MAKATI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(373, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 28)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "- AIM HIGH, FLY LIKE A HERON -"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1004, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1179, 372)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 307)
        Me.Label14.MaximumSize = New System.Drawing.Size(581, 57)
        Me.Label14.MinimumSize = New System.Drawing.Size(581, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.ReadOnly = True
        Me.Label14.Size = New System.Drawing.Size(581, 57)
        Me.Label14.TabIndex = 11
        Me.Label14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.Label13.Font = New System.Drawing.Font("Book Antiqua", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 244)
        Me.Label13.MaximumSize = New System.Drawing.Size(581, 57)
        Me.Label13.MinimumSize = New System.Drawing.Size(581, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.ReadOnly = True
        Me.Label13.Size = New System.Drawing.Size(581, 57)
        Me.Label13.TabIndex = 10
        Me.Label13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Label13.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Khaki
        Me.Label11.Location = New System.Drawing.Point(6, 12)
        Me.Label11.Multiline = True
        Me.Label11.Name = "Label11"
        Me.Label11.ReadOnly = True
        Me.Label11.Size = New System.Drawing.Size(1167, 226)
        Me.Label11.TabIndex = 9
        Me.Label11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Label11.Visible = False
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.Label16.Font = New System.Drawing.Font("Book Antiqua", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(590, 307)
        Me.Label16.MaximumSize = New System.Drawing.Size(581, 57)
        Me.Label16.MinimumSize = New System.Drawing.Size(581, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.ReadOnly = True
        Me.Label16.Size = New System.Drawing.Size(581, 57)
        Me.Label16.TabIndex = 8
        Me.Label16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.Label15.Font = New System.Drawing.Font("Book Antiqua", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(590, 244)
        Me.Label15.MaximumSize = New System.Drawing.Size(581, 57)
        Me.Label15.MinimumSize = New System.Drawing.Size(581, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.ReadOnly = True
        Me.Label15.Size = New System.Drawing.Size(581, 57)
        Me.Label15.TabIndex = 7
        Me.Label15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Label15.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.SIGN_UP_BTN)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.BC_tb)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(395, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(414, 235)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'SIGN_UP_BTN
        '
        Me.SIGN_UP_BTN.BackColor = System.Drawing.Color.Azure
        Me.SIGN_UP_BTN.Font = New System.Drawing.Font("Baskerville Old Face", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIGN_UP_BTN.ForeColor = System.Drawing.Color.Black
        Me.SIGN_UP_BTN.Location = New System.Drawing.Point(110, 183)
        Me.SIGN_UP_BTN.Name = "SIGN_UP_BTN"
        Me.SIGN_UP_BTN.Size = New System.Drawing.Size(181, 46)
        Me.SIGN_UP_BTN.TabIndex = 47
        Me.SIGN_UP_BTN.Text = "START"
        Me.SIGN_UP_BTN.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(31, 94)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(202, 28)
        Me.RadioButton2.TabIndex = 46
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Without Timelimit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(31, 66)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(172, 28)
        Me.RadioButton1.TabIndex = 45
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "With Timelimit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(189, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 31)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = ": "
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.TextBox2.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.DarkOrange
        Me.TextBox2.Location = New System.Drawing.Point(222, 18)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(58, 35)
        Me.TextBox2.TabIndex = 42
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.TextBox1.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkOrange
        Me.TextBox1.Location = New System.Drawing.Point(125, 18)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(58, 35)
        Me.TextBox1.TabIndex = 41
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BC_tb
        '
        Me.BC_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BC_tb.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.BC_tb.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BC_tb.ForeColor = System.Drawing.Color.DarkOrange
        Me.BC_tb.Location = New System.Drawing.Point(292, 136)
        Me.BC_tb.MaxLength = 2
        Me.BC_tb.Name = "BC_tb"
        Me.BC_tb.Size = New System.Drawing.Size(89, 35)
        Me.BC_tb.TabIndex = 40
        Me.BC_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 31)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "# OF QUESTIONS: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TIMER: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Baskerville Old Face", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(275, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 31)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "min &&  sec"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(677, 546)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 57)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "TIMER: "
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label8.Location = New System.Drawing.Point(891, 546)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 57)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "00"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label9.Location = New System.Drawing.Point(958, 541)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 57)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = ":"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label10.Location = New System.Drawing.Point(987, 546)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 57)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "01"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(292, 57)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Question #1"
        Me.Label12.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Book Antiqua", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(762, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(175, 57)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "Points:"
        Me.Label17.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 900
        '
        'Timer4
        '
        Me.Timer4.Interval = 900
        '
        'Timer5
        '
        Me.Timer5.Interval = 1
        '
        'UMAK_QUIZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TME)
        Me.Controls.Add(Me.DTE)
        Me.Controls.Add(Me.OFF)
        Me.Controls.Add(Me.BACK_BTN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label17)
        Me.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1200, 600)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "UMAK_QUIZ"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UMAK_QUIZ"
        CType(Me.BACK_BTN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BACK_BTN As System.Windows.Forms.PictureBox
    Friend WithEvents OFF As System.Windows.Forms.PictureBox
    Friend WithEvents DTE As System.Windows.Forms.Label
    Friend WithEvents TME As System.Windows.Forms.Label
    Friend WithEvents SYS_D_T As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BC_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SIGN_UP_BTN As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label16 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.TextBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
End Class
