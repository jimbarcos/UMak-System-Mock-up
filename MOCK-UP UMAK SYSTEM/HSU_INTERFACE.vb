Public Class HSU_INTERFACE
    'MAIN FORM is the Parent Form

    'Programs to back out the current form and go back to MAIN INTERFACE FORM
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        Hide()
        MAIN_FORM.username_tb.Clear()
        MAIN_FORM.password_tb.Clear()
        MAIN_FORM.INFO.Visible = False
        MAIN_FORM.Show()
        MAIN_FORM.username_tb_MouseClick()
        Close()
    End Sub

    'Programs to exit the program
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

    ' redirect to main interface when clicked
    Private Sub LEFT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEFT_ARR.Click
        Hide()
        MAIN_INTERFACE.Show()
    End Sub

    ' redirect to main interface when clicked
    Private Sub RIGHT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIGHT_ARR.Click
        Hide()
        MAIN_INTERFACE.Show()
    End Sub


    ' to make the logo responsive - will change their color once the cursor hits them
    Private Sub FOURTH_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles FOURTH.MouseEnter
        BORDER_13.BackColor = Color.DarkRed
        BORDER_14.BackColor = Color.DarkRed
        BORDER_15.BackColor = Color.DarkRed
        BORDER_16.BackColor = Color.DarkRed
        Label7.ForeColor = Color.White
        FOURTH.BackColor = Color.White
    End Sub

    ' to make the logo responsive - will change their color once the cursor hits them
    Private Sub FOURTH_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FOURTH.MouseLeave
        BORDER_13.BackColor = Color.Khaki
        BORDER_14.BackColor = Color.Khaki
        BORDER_15.BackColor = Color.Khaki
        BORDER_16.BackColor = Color.Khaki
        Label7.ForeColor = Color.Black
        FOURTH.BackColor = Color.Salmon
    End Sub

  
    ' to make the logo responsive - will change their color once the cursor hits them
    Private Sub FIFTH_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles FIFTH.MouseEnter
        BORDER_17.BackColor = Color.DarkRed
        BORDER_18.BackColor = Color.DarkRed
        BORDER_19.BackColor = Color.DarkRed
        BORDER_20.BackColor = Color.DarkRed
        Label3.ForeColor = Color.White
        FIFTH.BackColor = Color.White
    End Sub

    ' to make the logo responsive - will change their color once the cursor hits them
    Private Sub FIFTH_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles FIFTH.MouseLeave
        BORDER_17.BackColor = Color.Khaki
        BORDER_18.BackColor = Color.Khaki
        BORDER_19.BackColor = Color.Khaki
        BORDER_20.BackColor = Color.Khaki
        Label3.ForeColor = Color.Black
        FIFTH.BackColor = Color.Salmon
    End Sub

    ' to make the logo responsive - will change their color once the cursor hits them
    Private Sub PictureBox11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseEnter
        BORDER_21.BackColor = Color.DarkRed
        BORDER_22.BackColor = Color.DarkRed
        BORDER_23.BackColor = Color.DarkRed
        BORDER_24.BackColor = Color.DarkRed
        Label4.ForeColor = Color.White
        PictureBox11.BackColor = Color.White
    End Sub

    ' to make the logo responsive - will change their color once the cursor hits them
    Private Sub PictureBox11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseLeave
        BORDER_21.BackColor = Color.Khaki
        BORDER_22.BackColor = Color.Khaki
        BORDER_23.BackColor = Color.Khaki
        BORDER_24.BackColor = Color.Khaki
        Label4.ForeColor = Color.Black
        PictureBox11.BackColor = Color.Salmon
    End Sub

    ' redirect to hsu admission then the picture box fourth is clicked
    Private Sub FOURTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FOURTH.Click
        HSU_ADMISSION.Show()
        Close()
    End Sub


    ' redirect to strand and track encyclopedia when the picture box fifth is clicked
    Private Sub FIFTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FIFTH.Click
        S_T_ENCYCLOPEDIA.Show()
        Close()
    End Sub

    ' redirect to strand and track evaluation when the picture box sixth is clicked
    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        S_T_EVALUATION.Show()
        Close()
    End Sub

    
   
End Class