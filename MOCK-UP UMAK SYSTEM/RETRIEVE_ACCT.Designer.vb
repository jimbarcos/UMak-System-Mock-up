<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RETRIEVE_ACCT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RETRIEVE_ACCT))
        Me.OFF = New System.Windows.Forms.PictureBox()
        Me.DTE = New System.Windows.Forms.Label()
        Me.TME = New System.Windows.Forms.Label()
        Me.SYS_D_T = New System.Windows.Forms.Timer(Me.components)
        Me.BACK_BTN = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BC_CB = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BC_tb = New System.Windows.Forms.TextBox()
        Me.SIGN_UP_BTN = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SHOW_BTN = New System.Windows.Forms.Button()
        CType(Me.OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BACK_BTN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.OFF.TabIndex = 32
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
        Me.DTE.TabIndex = 33
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
        Me.TME.TabIndex = 34
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
        Me.BACK_BTN.TabIndex = 66
        Me.BACK_BTN.TabStop = False
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
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(336, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(564, 156)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "USER ACCOUNT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RETRIEVAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
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
        Me.Label8.TabIndex = 70
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
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "___________________________________________"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.BC_CB)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.BC_tb)
        Me.GroupBox2.Controls.Add(Me.SIGN_UP_BTN)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(394, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 348)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.SkyBlue
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(117, 100)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 35)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 43
        Me.PictureBox4.TabStop = False
        '
        'BC_CB
        '
        Me.BC_CB.AutoSize = True
        Me.BC_CB.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BC_CB.ForeColor = System.Drawing.Color.Transparent
        Me.BC_CB.Location = New System.Drawing.Point(108, 147)
        Me.BC_CB.Name = "BC_CB"
        Me.BC_CB.Size = New System.Drawing.Size(143, 30)
        Me.BC_CB.TabIndex = 42
        Me.BC_CB.Text = "Show Code"
        Me.BC_CB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Khaki
        Me.Label2.Location = New System.Drawing.Point(25, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(405, 78)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "You need to input the code that you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "register when you sign-up as a new user." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It" & _
            " only accepts number values" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BC_tb
        '
        Me.BC_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BC_tb.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.BC_tb.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BC_tb.ForeColor = System.Drawing.Color.Transparent
        Me.BC_tb.Location = New System.Drawing.Point(145, 100)
        Me.BC_tb.MaxLength = 10
        Me.BC_tb.Name = "BC_tb"
        Me.BC_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.BC_tb.Size = New System.Drawing.Size(199, 35)
        Me.BC_tb.TabIndex = 39
        '
        'SIGN_UP_BTN
        '
        Me.SIGN_UP_BTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SIGN_UP_BTN.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIGN_UP_BTN.ForeColor = System.Drawing.Color.Black
        Me.SIGN_UP_BTN.Location = New System.Drawing.Point(133, 207)
        Me.SIGN_UP_BTN.Name = "SIGN_UP_BTN"
        Me.SIGN_UP_BTN.Size = New System.Drawing.Size(181, 46)
        Me.SIGN_UP_BTN.TabIndex = 10
        Me.SIGN_UP_BTN.Text = "RETRIEVE"
        Me.SIGN_UP_BTN.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(23, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(426, 39)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "- ENTER BACKUP CODE - " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Teal
        Me.PictureBox3.Location = New System.Drawing.Point(108, 92)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(240, 49)
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(890, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 28)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Username: "
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(895, 439)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 28)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Password: "
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Khaki
        Me.Label7.Location = New System.Drawing.Point(887, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(275, 43)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "CREDENTIALS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'SHOW_BTN
        '
        Me.SHOW_BTN.BackColor = System.Drawing.Color.Orange
        Me.SHOW_BTN.Enabled = False
        Me.SHOW_BTN.Font = New System.Drawing.Font("Book Antiqua", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHOW_BTN.ForeColor = System.Drawing.Color.Black
        Me.SHOW_BTN.Location = New System.Drawing.Point(857, 519)
        Me.SHOW_BTN.Name = "SHOW_BTN"
        Me.SHOW_BTN.Size = New System.Drawing.Size(237, 46)
        Me.SHOW_BTN.TabIndex = 75
        Me.SHOW_BTN.Text = "ON DISPLAY"
        Me.SHOW_BTN.UseVisualStyleBackColor = False
        Me.SHOW_BTN.Visible = False
        '
        'RETRIEVE_ACCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.SHOW_BTN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BACK_BTN)
        Me.Controls.Add(Me.TME)
        Me.Controls.Add(Me.DTE)
        Me.Controls.Add(Me.OFF)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximumSize = New System.Drawing.Size(1200, 600)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "RETRIEVE_ACCT"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER ACCOUNT RETRIEVAL"
        CType(Me.OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BACK_BTN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OFF As System.Windows.Forms.PictureBox
    Friend WithEvents DTE As System.Windows.Forms.Label
    Friend WithEvents TME As System.Windows.Forms.Label
    Friend WithEvents SYS_D_T As System.Windows.Forms.Timer
    Friend WithEvents BACK_BTN As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SIGN_UP_BTN As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BC_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BC_CB As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SHOW_BTN As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
