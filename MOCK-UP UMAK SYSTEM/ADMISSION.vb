Public Class ADMISSION
    'MAIN FORM is the Parent Form

    'Programs to back out the current form and go back to MAIN INTERFACE FORM
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        Hide()
        MAIN_INTERFACE.Show()
        Close()
    End Sub

    'Programs to exit the program
    Private Sub OFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFF.Click
        If MessageBox.Show("Close the Application?", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MAIN_FORM.Close()
        End If
    End Sub

    'For displayment of Time and date
    Private Sub SYS_D_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_D_T.Tick
        DTE1.Text = Today.DayOfWeek.ToString & ", " & Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year
        TME.Text = TimeOfDay
    End Sub

    


    'the form is loaded, the button will change its design to orange Forecolor and Maroon Backcolor
    Private Sub ADMISSION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.ForeColor = Color.Orange
        Button1.BackColor = Color.Maroon
    End Sub

End Class