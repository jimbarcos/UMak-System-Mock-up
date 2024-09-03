Public Class S_T_ENCYCLOPEDIA
    'Main form is the parent form

    'redirects back to the hsu interface
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        HSU_INTERFACE.Show()
        Close()
    End Sub

    'displays the date and time
    Private Sub SYS_D_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_D_T.Tick
        DTE.Text = Today.DayOfWeek.ToString & ", " & Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year
        TME.Text = TimeOfDay
    End Sub

    'exits the program
    Private Sub OFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFF.Click
        If MessageBox.Show("Close the Application?", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MAIN_FORM.Close()
        End If
    End Sub

    'When clicked, the button will be highlighted with a change of backcolor and forecolor, to make it seems responsive
    'will display the informations on the rich text box regarding to the senior high school track
    Private Sub Button1_Click() Handles Button1.Click
        Button1.ForeColor = Color.Orange
        Button1.BackColor = Color.Maroon

        Button2.ForeColor = Color.White
        Button2.BackColor = Color.Black

        Button3.ForeColor = Color.White
        Button3.BackColor = Color.Black

        RichTextBox1.BringToFront()
    End Sub

    'When clicked, the button will be highlighted with a change of backcolor and forecolor, to make it seems responsive
    'will display the informations on the rich text box regarding to the Tips on choosing your strand and track
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.ForeColor = Color.Orange
        Button2.BackColor = Color.Maroon

        Button1.ForeColor = Color.White
        Button1.BackColor = Color.Black

        Button3.ForeColor = Color.White
        Button3.BackColor = Color.Black

        RichTextBox2.BringToFront()
    End Sub

    'default clicked button 1
    Private Sub S_T_ENCYCLOPEDIA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1_Click()
    End Sub

    'redirect to the link using default browser when the label is clicked
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Process.Start("https://www.ciit.edu.ph/perfect-track-and-strand")
    End Sub

    'When clicked, the button will be highlighted with a change of backcolor and forecolor, to make it seems responsive
    'will display the informations on the rich text box regarding to the course offering
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.ForeColor = Color.Orange
        Button3.BackColor = Color.Maroon

        Button1.ForeColor = Color.White
        Button1.BackColor = Color.Black

        Button2.ForeColor = Color.White
        Button2.BackColor = Color.Black

        RichTextBox3.BringToFront()
    End Sub

    
End Class