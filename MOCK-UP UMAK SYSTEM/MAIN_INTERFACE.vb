Public Class MAIN_INTERFACE
    'MAIN_FROM is the Parent Form

    'displays the date and time
    Private Sub SYS_D_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_D_T.Tick
        DTE.Text = Today.DayOfWeek.ToString & ", " & Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year
        TME.Text = TimeOfDay
    End Sub

    ' closes the program
    Private Sub OFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFF.Click
        If MessageBox.Show("Close the Application?", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MAIN_FORM.Close()
        End If
    End Sub

    ' Returns to Main form when button is clicked
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        Hide()
        MAIN_FORM.username_tb.Clear()
        MAIN_FORM.password_tb.Clear()
        MAIN_FORM.INFO.Visible = False
        MAIN_FORM.Show()
        MAIN_FORM.username_tb_MouseClick()
        Close()
    End Sub

    
    'appreance change on the logo when cursor navigated through and out of it
    Private Sub FIRST_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles FIRST.MouseEnter
        BORDER_1.BackColor = Color.DarkRed
        BORDER_2.BackColor = Color.DarkRed
        BORDER_3.BackColor = Color.DarkRed
        BORDER_4.BackColor = Color.DarkRed
        Label4.ForeColor = Color.White
        FIRST.BackColor = Color.White
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub FIRST_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FIRST.MouseLeave
        BORDER_1.BackColor = Color.Khaki
        BORDER_2.BackColor = Color.Khaki
        BORDER_3.BackColor = Color.Khaki
        BORDER_4.BackColor = Color.Khaki
        Label4.ForeColor = Color.Black
        FIRST.BackColor = Color.Salmon
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub SECOND_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SECOND.MouseEnter
        BORDER_5.BackColor = Color.DarkRed
        BORDER_6.BackColor = Color.DarkRed
        BORDER_7.BackColor = Color.DarkRed
        BORDER_8.BackColor = Color.DarkRed
        Label5.ForeColor = Color.White
        SECOND.BackColor = Color.White
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub SECOND_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SECOND.MouseLeave
        BORDER_5.BackColor = Color.Khaki
        BORDER_6.BackColor = Color.Khaki
        BORDER_7.BackColor = Color.Khaki
        BORDER_8.BackColor = Color.Khaki
        Label5.ForeColor = Color.Black
        SECOND.BackColor = Color.Salmon
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub THIRD_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles THIRD.MouseEnter
        BORDER_9.BackColor = Color.DarkRed
        BORDER_10.BackColor = Color.DarkRed
        BORDER_11.BackColor = Color.DarkRed
        BORDER_12.BackColor = Color.DarkRed
        Label6.ForeColor = Color.White
        THIRD.BackColor = Color.White
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub THIRD_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles THIRD.MouseLeave
        BORDER_9.BackColor = Color.Khaki
        BORDER_10.BackColor = Color.Khaki
        BORDER_11.BackColor = Color.Khaki
        BORDER_12.BackColor = Color.Khaki
        Label6.ForeColor = Color.Black
        THIRD.BackColor = Color.Salmon
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub FOURTH_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles FOURTH.MouseEnter
        BORDER_13.BackColor = Color.DarkRed
        BORDER_14.BackColor = Color.DarkRed
        BORDER_15.BackColor = Color.DarkRed
        BORDER_16.BackColor = Color.DarkRed
        Label7.ForeColor = Color.White
        FOURTH.BackColor = Color.White

    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub FOURTH_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FOURTH.MouseLeave
        BORDER_13.BackColor = Color.Khaki
        BORDER_14.BackColor = Color.Khaki
        BORDER_15.BackColor = Color.Khaki
        BORDER_16.BackColor = Color.Khaki
        Label7.ForeColor = Color.Black
        FOURTH.BackColor = Color.Salmon
    End Sub


    'appreance change on the logo when cursor navigated through and out of it
    Private Sub FIFTH_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles FIFTH.MouseEnter
        BORDER_17.BackColor = Color.DarkRed
        BORDER_18.BackColor = Color.DarkRed
        BORDER_19.BackColor = Color.DarkRed
        BORDER_20.BackColor = Color.DarkRed
        Label8.ForeColor = Color.White
        FIFTH.BackColor = Color.White

    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub FIFTH_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FIFTH.MouseLeave
        BORDER_17.BackColor = Color.Khaki
        BORDER_18.BackColor = Color.Khaki
        BORDER_19.BackColor = Color.Khaki
        BORDER_20.BackColor = Color.Khaki
        Label8.ForeColor = Color.Black
        FIFTH.BackColor = Color.Salmon
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub SIXTH_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SIXTH.MouseEnter
        BORDER_21.BackColor = Color.DarkRed
        BORDER_22.BackColor = Color.DarkRed
        BORDER_23.BackColor = Color.DarkRed
        BORDER_24.BackColor = Color.DarkRed
        Label3.ForeColor = Color.White
        SIXTH.BackColor = Color.White
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub SIXTH_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SIXTH.MouseLeave
        BORDER_21.BackColor = Color.Khaki
        BORDER_22.BackColor = Color.Khaki
        BORDER_23.BackColor = Color.Khaki
        BORDER_24.BackColor = Color.Khaki
        Label3.ForeColor = Color.Black
        SIXTH.BackColor = Color.Salmon
    End Sub

    
    'redirects to umak quiz when logo clicked
    Private Sub SIXTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIXTH.Click
        Hide()
        UMAK_QUIZ.Show()
        Close()
    End Sub

    'redirects to awards when logo clicked
    Private Sub FIRST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FIRST.Click
        Hide()
        AWARDS.Show()
        Close()
    End Sub

    'redirects to history when logo clicked
    Private Sub SECOND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SECOND.Click
        Hide()
        HISTORY.Show()
        Close()
    End Sub

    'redirects to facilities when logo clicked
    Private Sub THIRD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles THIRD.Click
        Hide()
        FACILITIES.Show()
        Close()
    End Sub

    'redirects to hsu interface when logo clicked
    Private Sub RIGHT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIGHT_ARR.Click
        Hide()
        HSU_INTERFACE.Show()
    End Sub

    'redirects to hsu interface when logo clicked
    Private Sub LEFT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEFT_ARR.Click
        Hide()
        HSU_INTERFACE.Show()
    End Sub

    'redirects to scholarship when logo clicked
    Private Sub FOURTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FOURTH.Click
        Hide()
        SCHOLARSHIP.Show()

    End Sub

    'redirects to admission when logo clicked
    Private Sub FIFTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FIFTH.Click
        Hide()
        ADMISSION.Show()
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub PictureBox_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox.MouseEnter
        PictureBox3.BackColor = Color.DarkRed
        PictureBox2.BackColor = Color.DarkRed
        PictureBox4.BackColor = Color.DarkRed
        PictureBox5.BackColor = Color.DarkRed
        Label9.ForeColor = Color.White
        PictureBox.BackColor = Color.White
    End Sub

    'appreance change on the logo when cursor navigated through and out of it
    Private Sub PictureBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox.MouseLeave
        PictureBox3.BackColor = Color.Khaki
        PictureBox2.BackColor = Color.Khaki
        PictureBox4.BackColor = Color.Khaki
        PictureBox5.BackColor = Color.Khaki
        Label9.ForeColor = Color.Black
        PictureBox.BackColor = Color.Salmon
    End Sub

    'redirects to colleges
    Private Sub PictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox.Click
        COLLEGES.Show()
        Close()
    End Sub

   
   
End Class