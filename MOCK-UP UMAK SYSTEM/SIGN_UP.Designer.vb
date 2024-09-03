<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGN_up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SIGN_up))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OFF = New System.Windows.Forms.PictureBox()
        Me.DTE = New System.Windows.Forms.Label()
        Me.TME = New System.Windows.Forms.Label()
        Me.SYS_D_T = New System.Windows.Forms.Timer(Me.components)
        Me.BACK_BTN = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.BC_CB = New System.Windows.Forms.CheckBox()
        Me.BC_tb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.show_pass_cb = New System.Windows.Forms.CheckBox()
        Me.SIGN_UP_BTN = New System.Windows.Forms.Button()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.INFO = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BACK_BTN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1032, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(156, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(348, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 156)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "NEW USER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "REGISTRATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bell MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(58, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1086, 72)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "_________________________________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bell MT", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(-99, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1406, 72)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "___________________________________________"
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
        Me.OFF.TabIndex = 39
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
        Me.DTE.TabIndex = 40
        Me.DTE.Text = "DATE"
        '
        'TME
        '
        Me.TME.AutoSize = True
        Me.TME.BackColor = System.Drawing.Color.Transparent
        Me.TME.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TME.ForeColor = System.Drawing.Color.White
        Me.TME.Location = New System.Drawing.Point(12, 574)
        Me.TME.Name = "TME"
        Me.TME.Size = New System.Drawing.Size(61, 23)
        Me.TME.TabIndex = 41
        Me.TME.Text = "TIME"
        '
        'SYS_D_T
        '
        Me.SYS_D_T.Enabled = True
        Me.SYS_D_T.Interval = 1000
        '
        'BACK_BTN
        '
        Me.BACK_BTN.BackColor = System.Drawing.Color.Transparent
        Me.BACK_BTN.Image = CType(resources.GetObject("BACK_BTN.Image"), System.Drawing.Image)
        Me.BACK_BTN.Location = New System.Drawing.Point(12, 202)
        Me.BACK_BTN.Name = "BACK_BTN"
        Me.BACK_BTN.Size = New System.Drawing.Size(123, 83)
        Me.BACK_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BACK_BTN.TabIndex = 65
        Me.BACK_BTN.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox9)
        Me.GroupBox2.Controls.Add(Me.PictureBox8)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.BC_CB)
        Me.GroupBox2.Controls.Add(Me.BC_tb)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.username_tb)
        Me.GroupBox2.Controls.Add(Me.show_pass_cb)
        Me.GroupBox2.Controls.Add(Me.SIGN_UP_BTN)
        Me.GroupBox2.Controls.Add(Me.password_tb)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(319, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 333)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(243, 234)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(31, 35)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox9.TabIndex = 44
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(243, 131)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(31, 35)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 43
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(243, 65)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(31, 35)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 42
        Me.PictureBox7.TabStop = False
        '
        'BC_CB
        '
        Me.BC_CB.AutoSize = True
        Me.BC_CB.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BC_CB.ForeColor = System.Drawing.Color.Transparent
        Me.BC_CB.Location = New System.Drawing.Point(238, 281)
        Me.BC_CB.Name = "BC_CB"
        Me.BC_CB.Size = New System.Drawing.Size(143, 30)
        Me.BC_CB.TabIndex = 41
        Me.BC_CB.Text = "Show Code"
        Me.BC_CB.UseVisualStyleBackColor = True
        '
        'BC_tb
        '
        Me.BC_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BC_tb.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.BC_tb.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BC_tb.ForeColor = System.Drawing.Color.Transparent
        Me.BC_tb.Location = New System.Drawing.Point(273, 234)
        Me.BC_tb.MaxLength = 10
        Me.BC_tb.Name = "BC_tb"
        Me.BC_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.BC_tb.Size = New System.Drawing.Size(200, 35)
        Me.BC_tb.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(39, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 32)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Back-up Code:"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(545, 51)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 37
        Me.PictureBox6.TabStop = False
        '
        'username_tb
        '
        Me.username_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username_tb.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.username_tb.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_tb.ForeColor = System.Drawing.Color.Transparent
        Me.username_tb.Location = New System.Drawing.Point(273, 65)
        Me.username_tb.MaxLength = 10
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(200, 35)
        Me.username_tb.TabIndex = 14
        '
        'show_pass_cb
        '
        Me.show_pass_cb.AutoSize = True
        Me.show_pass_cb.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show_pass_cb.ForeColor = System.Drawing.Color.Transparent
        Me.show_pass_cb.Location = New System.Drawing.Point(238, 178)
        Me.show_pass_cb.Name = "show_pass_cb"
        Me.show_pass_cb.Size = New System.Drawing.Size(185, 30)
        Me.show_pass_cb.TabIndex = 11
        Me.show_pass_cb.Text = "Show Password"
        Me.show_pass_cb.UseVisualStyleBackColor = True
        '
        'SIGN_UP_BTN
        '
        Me.SIGN_UP_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SIGN_UP_BTN.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIGN_UP_BTN.ForeColor = System.Drawing.Color.Black
        Me.SIGN_UP_BTN.Location = New System.Drawing.Point(396, 281)
        Me.SIGN_UP_BTN.Name = "SIGN_UP_BTN"
        Me.SIGN_UP_BTN.Size = New System.Drawing.Size(181, 46)
        Me.SIGN_UP_BTN.TabIndex = 10
        Me.SIGN_UP_BTN.Text = "REGISTER "
        Me.SIGN_UP_BTN.UseVisualStyleBackColor = False
        '
        'password_tb
        '
        Me.password_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password_tb.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.password_tb.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_tb.ForeColor = System.Drawing.Color.Transparent
        Me.password_tb.Location = New System.Drawing.Point(273, 131)
        Me.password_tb.MaxLength = 10
        Me.password_tb.Name = "password_tb"
        Me.password_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_tb.Size = New System.Drawing.Size(200, 35)
        Me.password_tb.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(96, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Baskerville Old Face", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(96, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(416, 36)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "- ENTER CREDENTIALS - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(88, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Teal
        Me.PictureBox4.Location = New System.Drawing.Point(238, 123)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(240, 49)
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Teal
        Me.PictureBox5.Location = New System.Drawing.Point(238, 57)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(240, 49)
        Me.PictureBox5.TabIndex = 13
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Teal
        Me.PictureBox3.Location = New System.Drawing.Point(238, 226)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(240, 49)
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'INFO
        '
        Me.INFO.AutoSize = True
        Me.INFO.BackColor = System.Drawing.Color.Transparent
        Me.INFO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.INFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.INFO.Font = New System.Drawing.Font("Book Antiqua", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INFO.ForeColor = System.Drawing.Color.White
        Me.INFO.Location = New System.Drawing.Point(922, 213)
        Me.INFO.Name = "INFO"
        Me.INFO.Size = New System.Drawing.Size(198, 376)
        Me.INFO.TabIndex = 67
        Me.INFO.Text = resources.GetString("INFO.Text")
        Me.INFO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.INFO.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'SIGN_up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.INFO)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BACK_BTN)
        Me.Controls.Add(Me.TME)
        Me.Controls.Add(Me.DTE)
        Me.Controls.Add(Me.OFF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1200, 600)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "SIGN_up"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GAMES_INTERFACE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BACK_BTN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OFF As System.Windows.Forms.PictureBox
    Friend WithEvents DTE As System.Windows.Forms.Label
    Friend WithEvents TME As System.Windows.Forms.Label
    Friend WithEvents SYS_D_T As System.Windows.Forms.Timer
    Friend WithEvents BACK_BTN As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents username_tb As System.Windows.Forms.TextBox
    Friend WithEvents show_pass_cb As System.Windows.Forms.CheckBox
    Friend WithEvents SIGN_UP_BTN As System.Windows.Forms.Button
    Friend WithEvents password_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents INFO As System.Windows.Forms.Label
    Friend WithEvents BC_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BC_CB As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
End Class
