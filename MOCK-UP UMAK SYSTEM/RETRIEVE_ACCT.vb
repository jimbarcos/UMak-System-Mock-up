Public Class RETRIEVE_ACCT
    'validator to the credentials of usrname and password
    Dim user_disp, pass_disp As String

    'closes the program
    Private Sub OFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFF.Click
        If MessageBox.Show("Close the Application?", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MAIN_FORM.Close()
        End If
    End Sub

    'displays date and time
    Private Sub SYS_D_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_D_T.Tick
        DTE.Text = Today.DayOfWeek.ToString & ", " & Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year
        TME.Text = TimeOfDay
    End Sub

    'redirect back to main form while the focus textbox will be back to username_tb as default
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        Hide()
        MAIN_FORM.username_tb.Clear()
        MAIN_FORM.password_tb.Clear()
        MAIN_FORM.INFO.Visible = False
        MAIN_FORM.Show()
        MAIN_FORM.username_tb_MouseClick()
        Close()

    End Sub

    'show password when checked and not
    Private Sub BC_CB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BC_CB.CheckedChanged
        If BC_CB.Checked = True Then
            BC_tb.PasswordChar = Nothing
        Else
            BC_tb.PasswordChar = "*"
        End If
    End Sub

    'ease nacigation of key entry 
    Private Sub BC_tb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BC_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            SIGN_UP_BTN.PerformClick()
        End If
    End Sub

    'character filtration 0-9 only accepted
    Private Sub BC_tb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BC_tb.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub


    Private Sub SIGN_UP_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIGN_UP_BTN.Click

        'checks whether there are ccontents inside the textbox
        If BC_tb.Text = Nothing Or Not IsNumeric(BC_tb.Text) Then
            MessageBox.Show("Please Enter a valid BACKUP CODE" + vbNewLine + "(This will help you recover your account)", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'validator to use text files input output for validation if the credentials match
        Dim username1 As System.IO.StreamWriter
        Dim password1 As System.IO.StreamWriter
        Dim pass_backup1 As System.IO.StreamWriter

        'creates files under username
        username1 = My.Computer.FileSystem.OpenTextFileWriter("username.txt", True)
        username1.Close()

        'creates files under password
        password1 = My.Computer.FileSystem.OpenTextFileWriter("password.txt", True)
        password1.Close()

        'creates files under pass backup
        pass_backup1 = My.Computer.FileSystem.OpenTextFileWriter("pass_backup.txt", True)
        pass_backup1.Close()


        'reader of the texst file
        Dim pass_backup As New System.IO.StreamReader("pass_backup.txt")
        Dim password As New System.IO.StreamReader("password.txt")
        Dim username As New System.IO.StreamReader("username.txt")
        Dim pass_backup_checker As String

        'passing of values to the reader
        user_disp = username.ReadLine
        pass_disp = password.ReadLine
        pass_backup_checker = pass_backup.ReadLine


        'validation to show the credentials in the form else mesage box wil be shown
        If BC_tb.Text = pass_backup_checker Then

            If MessageBox.Show("Do you want to Display your Credentials in the portal?", "SHOW CREDENTIALS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Label4.Text = "Username: " & vbNewLine & user_disp
                Label6.Text = "Password: " & vbNewLine & pass_disp
                Label4.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                SHOW_BTN.Visible = True
                SHOW_BTN.Enabled = True
            Else
                MessageBox.Show("You Chose to not display it in the portal" & vbNewLine & vbNewLine & "- USER CREDENTIALS -" & vbNewLine & Label4.Text & user_disp & vbNewLine & Label6.Text & pass_disp & vbNewLine & "==========================", "SHOW CREDENTIALS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



        Else
            'when credentials are not matched
            MessageBox.Show("INCORRECT BACKUP CODE", "PLEASE TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        password.Close()
        username.Close()

        pass_backup.Close()
    End Sub


    'to focus the key enter on the textbox
    Private Sub BC_tb_MouseClick() Handles BC_tb.MouseClick
        BC_tb.Focus()
    End Sub

    ' toredirect the fdocus on the textbox once ticked
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        BC_tb_MouseClick()
        Timer1.Enabled = False

    End Sub

    'shows and hide the credentials in the form
    Private Sub SHOW_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOW_BTN.Click
        If SHOW_BTN.Text = "ON HIDE" Then
            Label4.Text = "Username: " & vbNewLine & user_disp
            Label6.Text = "Password: " & vbNewLine & pass_disp
            Label4.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            SHOW_BTN.Text = "ON DISPLAY"
        ElseIf SHOW_BTN.Text = "ON DISPLAY" Then
            Label4.Text = "Username: " & vbNewLine & user_disp
            Label6.Text = "Password: " & vbNewLine & pass_disp
            Label4.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            SHOW_BTN.Text = "ON HIDE"
        End If

    End Sub


  
End Class