Public Class MAIN_FORM

    'PARENT FORM
    Private Sub SYS_D_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_D_T.Tick
        DTE.Text = Today.DayOfWeek.ToString & ", " & Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year
        TME.Text = TimeOfDay
    End Sub


    'Programs to exit the program
    Private Sub OFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFF.Click
        If MessageBox.Show("Close the Application?", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        End If
    End Sub


    'programs to hide/unhide the password
    Private Sub show_pass_cb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles show_pass_cb.CheckedChanged

        If show_pass_cb.Checked = True Then
            password_tb.PasswordChar = Nothing
        Else
            password_tb.PasswordChar = "*"
        End If

    End Sub


    'validates the credentials and checks whether it is valid
    Private Sub LOG_IN_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOG_IN_BTN.Click

        If username_tb.Text = Nothing Or password_tb.Text = Nothing Then
            MessageBox.Show("Incorrect User Credentials." & vbNewLine & "Please try to retrieve it by clicking the - Retrieve my account -", "LOG IN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim username1 As System.IO.StreamWriter
        Dim password1 As System.IO.StreamWriter
        Dim pass_backup1 As System.IO.StreamWriter

        'stored in a text file for future referencing validation
        username1 = My.Computer.FileSystem.OpenTextFileWriter("username.txt", True)
        username1.Close()

        password1 = My.Computer.FileSystem.OpenTextFileWriter("password.txt", True)
        password1.Close()

        pass_backup1 = My.Computer.FileSystem.OpenTextFileWriter("pass_backup.txt", True)
        pass_backup1.Close()

        Dim user_check, user_pass As String

        Dim password As New System.IO.StreamReader("password.txt")


        Dim username As New System.IO.StreamReader("username.txt")

        user_check = username.ReadLine
        user_pass = password.ReadLine

        If user_check = username_tb.Text And user_pass = password_tb.Text Then
            Hide()
            MAIN_INTERFACE.Show()
        Else
            'when no acct credentials have been found
            MessageBox.Show("Incorrect User Credentials." & vbNewLine & "Please try to retrieve it by clicking the - Retrieve my account -", "LOG IN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        username.Close()
        password.Close()

        
    End Sub

    'responsible for displaying instruction text
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If INFO.Visible = False Then
            INFO.Visible = True
        Else
            INFO.Visible = False
        End If


    End Sub

    ' redirects to sign up
    Private Sub SIGN_UP_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIGN_UP_BTN.Click
        Hide()
        SIGN_up.Show()
    End Sub

    'redirects to retrieval acct
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        Hide()
        RETRIEVE_ACCT.Show()
    End Sub

   
    ''to go to the password textbox instantly when key.enter
    Private Sub username_tb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles username_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            password_tb_MouseClick()
        End If
    End Sub

    'character filtration - only gets 0-9 and A-Z or a-z
    Private Sub username_tb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles username_tb.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "a" And e.KeyChar <= "z") Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'to go to the login instantly when key.enter
    Private Sub password_tb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles password_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            LOG_IN_BTN.PerformClick()
        End If
    End Sub

    'character filtration - only gets 0-9 and A-Z or a-z
    Private Sub password_tb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles password_tb.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or (e.KeyChar >= "a" And e.KeyChar <= "z") Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'seamless handling for log in button
    Private Sub MAIN_FORM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            LOG_IN_BTN.PerformClick()
        End If
    End Sub


   


    'to go to the username textbox instantly
    Public Sub username_tb_MouseClick() Handles username_tb.MouseClick
        username_tb.Focus()
    End Sub

    'to default seed that username textbox will be first
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        password_tb.Text = Nothing
        username_tb_MouseClick()
        Timer1.Enabled = False
    End Sub

    'to go to the password textbox instantly
    Private Sub password_tb_MouseClick() Handles password_tb.MouseClick
        password_tb.Focus()
    End Sub

    
    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Hide()
        THE_DEV.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Hide()
        THE_DEV.Show()
    End Sub
End Class
