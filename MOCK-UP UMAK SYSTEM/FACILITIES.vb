Public Class FACILITIES
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

    'makes the blank picture box the default front
    Private Sub FACILITIES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox2.BringToFront()
    End Sub

    ' corresponding text will siaply the corresponding text and picture box
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ' for case room
        If ListBox1.Text = ">> Case Room" Then
            PictureBox3.BringToFront()
            Label4.Text = "Location: Bldg. #3 - Ground Floor"

            ' for employee faculty & executive lounge
        ElseIf ListBox1.Text = ">> Employee Faculty & Executive Lounge" Then
            PictureBox4.BringToFront()
            Label4.Text = "Location: Admin Bldg. - Basement"

            'for grand theatre
        ElseIf ListBox1.Text = ">> Grand Theatre" Then
            PictureBox5.BringToFront()
            Label4.Text = "Location: Admin Bldg. - 6 Flr. && 6 Mezzanine"

            'for HPSB 11th flr cafeteria
        ElseIf ListBox1.Text = ">> HPSB 11th Floor Cafeteria" Then
            PictureBox6.BringToFront()
            Label4.Text = "Location: HPSB - 11th Flr."

            'For HPSB Aero Dance Studio
        ElseIf ListBox1.Text = ">> HPSB Aero Dance Studio" Then
            PictureBox7.BringToFront()
            Label4.Text = "Location: HPSB - 11th Flr."

            'for HPSB Multimedia rooms
        ElseIf ListBox1.Text = ">> HPSB Multimedia Rooms" Then
            PictureBox8.BringToFront()
            Label4.Text = "Location: HPSB - 5th, 7th, 9th, 10th, 11th Flr."

            'for HPSB Skill labs
        ElseIf ListBox1.Text = ">> HPSB Skill Labs" Then
            PictureBox9.BringToFront()
            Label4.Text = "Location: HPSB - 6th, 7th, 8th Flr."

            'for mini theatre
        ElseIf ListBox1.Text = ">> Mini Theatre" Then
            PictureBox10.BringToFront()
            Label4.Text = "Location: Admin Bldg. - Ground Floor"

            'for track oval field
        ElseIf ListBox1.Text = ">> Track Oval Field" Then
            PictureBox11.BringToFront()
            Label4.Text = "Location: Left side of Main Gate"

            'for volleyball court
        ElseIf ListBox1.Text = ">> Volleyball Court" Then
            PictureBox12.BringToFront()
            Label4.Text = "Location: HPSB - 12th Flr."

            'for accenture room
        ElseIf ListBox1.Text = ">> Accenture Room" Then
            PictureBox13.BringToFront()
            Label4.Text = "Location: Bldg. #2 - 4th Flr."

            'for admin canteen
        ElseIf ListBox1.Text = ">> Admin Canteen" Then
            PictureBox14.BringToFront()
            Label4.Text = "Location: Admin Bldg. - Basement"

            'for avr II
        ElseIf ListBox1.Text = ">> AVR II" Then
            PictureBox15.BringToFront()
            Label4.Text = "Location: Bldg. #2 - 4th Flr."

            'for Basketball court
        ElseIf ListBox1.Text = ">> Basketball Court" Then
            PictureBox16.BringToFront()
            Label4.Text = "Location: HPSB - 12th Flr."

            'For Bridgeway
        ElseIf ListBox1.Text = ">> Bridgeway" Then
            PictureBox17.BringToFront()
            Label4.Text = "Location: Between Bldg. #2 && Bldg. #3"

        Else
            'else the blank picture box will be displayed
            PictureBox2.BringToFront()
        End If
    End Sub

    'For notification box, insturctions
    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        MessageBox.Show("We have list down some common facilities and landmarks in the University of Makati" & vbNewLine & vbNewLine & "This will help you familiarize and know the location of the facilities/landmarks", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class