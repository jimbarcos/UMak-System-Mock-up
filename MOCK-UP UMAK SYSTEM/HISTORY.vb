Public Class HISTORY
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

    'displays date and time
    Private Sub SYS_D_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_D_T.Tick
        DTE.Text = Today.DayOfWeek.ToString & ", " & Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year
        TME.Text = TimeOfDay
    End Sub

    'When clicked, the button will be highlighted with a change of backcolor and forecolor, to make it seems responsive
    'will display the informations on the rich text box regarding to the history of umak
    Private Sub Button1_Click() Handles Button1.Click
        Button1.ForeColor = Color.Orange
        Button1.BackColor = Color.Maroon

        Button2.ForeColor = Color.White
        Button2.BackColor = Color.Black

        Button3.ForeColor = Color.White
        Button3.BackColor = Color.Black

        RichTextBox1.Text = "   - HISTORY OF UMAK -" + vbNewLine + vbNewLine + "•	The University of Makati (UMAK) was first founded in 1972 and was first named as Makati Polytechnic Community College (MPCC). In 1987 this was changed to Makati College. In 1990 the Philippine Army gave the Fort Andres Bonifacio College to the municipal government of Makati, with this occurrence Fort Andres Bonifacio merged with Makati College. Then on 1991 Makati College was renamed to Pamantasan ng Makati to promote Internationally Competitiveness. Then on 2002 Pamantasan ng Makati was renamed into University of Makati through the city ordinance 2002-111 this was made as a marketing plan to attract more students and to show modernization, innovation. And educational excellence. The University of Makati  aims to create studentswith knowledge, skills, and the right amount of social confidence in order to get into respectable positions in their future jobs."

    End Sub

    'Button 1 (History of Umak) will be the default button
    Private Sub HISTORY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.PerformClick()
    End Sub

    'When clicked, the button will be highlighted with a change of backcolor and forecolor, to make it seems responsive
    'will display the informations on the rich text box regarding to the umak vision
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.ForeColor = Color.Orange
        Button2.BackColor = Color.Maroon

        Button1.ForeColor = Color.White
        Button1.BackColor = Color.Black

        Button3.ForeColor = Color.White
        Button3.BackColor = Color.Black

        RichTextBox1.Text = "   - UMAK VISION -" + vbNewLine + vbNewLine + "• 	We envision the University of Makati as the primary instrument where University education and Industry training programs interface to mold Makati youth into productive citizens and IT-enabled professionals who are exposed to the cutting edge of technology in their areas of specialization. The University shall be the final stage of Makati City's integrated primary level to university educational  system that allows its less privileged citizens to compete for high paying job opportunities in its business and industries."

    End Sub

    'When clicked, the button will be highlighted with a change of backcolor and forecolor, to make it seems responsive
    'will display the informations on the rich text box regarding to the umak mission
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.ForeColor = Color.Orange
        Button3.BackColor = Color.Maroon

        Button1.ForeColor = Color.White
        Button1.BackColor = Color.Black

        Button2.ForeColor = Color.White
        Button2.BackColor = Color.Black

        RichTextBox1.Text = "   - UMAK MISSION -" + vbNewLine + vbNewLine + vbNewLine + "•       To achieve our vision, University of Makati shall mold highly competent professionals and skilled workers from the children of poor Makati residents while inculcating in them good moral values and desirable personality development by offering baccalaureate degree, graduate degree, and non-degree programs with parallel on campus social, cultural, sports and other co-curricular activities."
    End Sub

    
   
    
End Class