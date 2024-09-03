Public Class SCHOLARSHIP
    'Main form is the Parent form

    'redirect back to main interface
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        Hide()
        MAIN_INTERFACE.Show()
        Close()
    End Sub

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

   

    'When clicked, the button will be highlighted with a change of backcolor and forecolor, to make it seems responsive
    'will display the informations on the rich text box regarding to the scholarship
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
    'will display the informations on the rich text box regarding to the scho vision
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.ForeColor = Color.Orange
        Button2.BackColor = Color.Maroon

        Button1.ForeColor = Color.White
        Button1.BackColor = Color.Black

        Button3.ForeColor = Color.White
        Button3.BackColor = Color.Black

        RichTextBox2.BringToFront()
    End Sub

    'When clicked, the button will be highlighted with a change of backcolor and forecolor, to make it seems responsive
    'will display the informations on the rich text box regarding to the scho. mission
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.ForeColor = Color.Orange
        Button3.BackColor = Color.Maroon

        Button1.ForeColor = Color.White
        Button1.BackColor = Color.Black

        Button2.ForeColor = Color.White
        Button2.BackColor = Color.Black

        RichTextBox3.BringToFront()
    End Sub

    'button 1 sets to be the default
    Private Sub SCHOLARSHIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1_Click()
    End Sub
End Class