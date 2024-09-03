Public Class SIGN_up
    'Main form is the parent form
   
    'closes the program
    Private Sub OFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFF.Click
        If MessageBox.Show("Close the Application?", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MAIN_FORM.Close()
        End If
    End Sub

    'displays the date and time
    Private Sub SYS_D_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_D_T.Tick
        DTE.Text = Today.DayOfWeek.ToString & ", " & Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year
        TME.Text = TimeOfDay
    End Sub

    'returns back to main form when clicked
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        Hide()
        MAIN_FORM.username_tb.Clear()
        MAIN_FORM.password_tb.Clear()
        MAIN_FORM.INFO.Visible = False
        MAIN_FORM.Show()
        MAIN_FORM.username_tb_MouseClick()
        Close()
    End Sub

    'show passwrod option to be visible or not
    Private Sub show_pass_cb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles show_pass_cb.CheckedChanged
        If show_pass_cb.Checked = True Then
            password_tb.PasswordChar = Nothing
        Else
            password_tb.PasswordChar = "*"
        End If
    End Sub

    'instruction box will be shown when clicked
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If INFO.Visible = False Then
            INFO.Visible = True
        Else
            INFO.Visible = False
        End If
    End Sub

   
    'show back up code option to be visible or not
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BC_CB.CheckedChanged
        If BC_CB.Checked = True Then
            BC_tb.PasswordChar = Nothing
        Else
            BC_tb.PasswordChar = "*"
        End If
    End Sub

    'seamless navigation to the cursor when hit key enter
    Private Sub BC_tb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BC_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            SIGN_UP_BTN.PerformClick()
        End If
    End Sub

    'character filtration only accepts 0-9
    Private Sub BC_tb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BC_tb.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub


    'validation 
    Private Sub SIGN_UP_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIGN_UP_BTN.Click
        If username_tb.Text = Nothing Then
            MessageBox.Show("Please Enter a valid USERNAME", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If password_tb.Text = Nothing Then
            MessageBox.Show("Please Enter a valid PASSWORD", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If BC_tb.Text = Nothing Or Not IsNumeric(BC_tb.Text) Then
            MessageBox.Show("Please Enter a valid BACKUP CODE" + vbNewLine + "(This will help you recover your account)", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'writes to text files for storing informations
        Dim username As System.IO.StreamWriter
        Dim password As System.IO.StreamWriter
        Dim pass_backup As System.IO.StreamWriter

        'creates files
        username = My.Computer.FileSystem.OpenTextFileWriter("username.txt", True)
        username.Close()

        password = My.Computer.FileSystem.OpenTextFileWriter("password.txt", True)
        password.Close()

        pass_backup = My.Computer.FileSystem.OpenTextFileWriter("pass_backup.txt", True)
        pass_backup.Close()


        'creates a reader for the text files
        Dim chk_pass As New System.IO.StreamReader("password.txt")
        Dim chk_user As New System.IO.StreamReader("username.txt")

        Dim copy_pass, copy_user As String

        copy_pass = chk_pass.ReadLine
        copy_user = chk_user.ReadLine

        'if duplicate found credentials have found
        If copy_user = username_tb.Text And copy_pass = password_tb.Text Then
            MessageBox.Show("DUPLICATE CREDENTIALS HAVE FOUND " + vbNewLine + "No need to Register", "ERROR REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            chk_pass.Close()
            chk_user.Close()
            Exit Sub
        End If
        chk_pass.Close()
        chk_user.Close()

        'last notification for approval creation of account
        If MessageBox.Show("The credentials of the last user will be deleted in order to store yours, CONTINUE?", "PLEASE READ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            username = My.Computer.FileSystem.OpenTextFileWriter("username.txt", False)

            'writes the new account credentials
            username.WriteLine(username_tb.Text)
            username.Close()

            password = My.Computer.FileSystem.OpenTextFileWriter("password.txt", False)
            password.WriteLine(password_tb.Text)
            password.Close()

            pass_backup = My.Computer.FileSystem.OpenTextFileWriter("pass_backup.txt", False)
            pass_backup.WriteLine(BC_tb.Text)
            pass_backup.Close()
            Dim status As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("STATUS.txt", False)
            status.Close()

            'info box to remeber credentials
            MessageBox.Show("Please Remember your credentials." + vbNewLine + "- YOU WILL BE REDIRECTED BACK TO THE MAIN FORM -", "REGISTRATION COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Hide()
            MAIN_FORM.username_tb.Clear()
            MAIN_FORM.password_tb.Clear()
            MAIN_FORM.INFO.Visible = False
            MAIN_FORM.Show()
            MAIN_FORM.username_tb_MouseClick()
            Close()
        Else
            Exit Sub
        End If



      
    End Sub


    'seamless navigation whne key enter
    Private Sub username_tb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles username_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            password_tb_MouseClick()
        End If
    End Sub

    'character filtration only accepts letters and numbers
    Private Sub username_tb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles username_tb.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "a" And e.KeyChar <= "z") Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'seamless navigation whne key enter
    Private Sub password_tb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles password_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            BC_tb_MouseClick()
        End If
    End Sub

    'character filtration only accepts letters and numbers
    Private Sub password_tb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles password_tb.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "a" And e.KeyChar <= "z") Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'seamless navigation whne key enter
    Private Sub SIGN_up_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SIGN_UP_BTN.PerformClick()
        End If
    End Sub
   
   
    
    


    'focuses the type beam to the textbox
    Private Sub username_tb_MouseClick() Handles username_tb.MouseClick
        username_tb.Focus()
    End Sub

    'default ticked to focus the username textbox once the form loaded
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        username_tb_MouseClick()
        Timer1.Enabled = False
    End Sub

    'focuses the type beam to the textbox
    Private Sub password_tb_MouseClick() Handles password_tb.MouseClick
        password_tb.Focus()
    End Sub

    'focuses the type beam to the textbox
    Private Sub BC_tb_MouseClick() Handles BC_tb.MouseClick
        BC_tb.Focus()
    End Sub

    
   
End Class