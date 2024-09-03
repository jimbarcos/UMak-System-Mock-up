Public Class UMAK_QUIZ

    Dim ques_lbl As String = Nothing
    Dim gen As New Random
    Dim num_gen As Integer = Nothing
    Dim count As Integer = 1
    Dim points As Integer = 0
    Dim click_once As Integer = 0
    Dim num_collect(55) As Integer
    Dim overall_ques As Integer = 0

    'for closing the program
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

    'returns to main interface when back button is hit
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        Hide()
        MAIN_INTERFACE.Show()
        Close()
    End Sub

    'for the time limit textbox to be enebled
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Enabled = True
        TextBox2.Enabled = True
    End Sub


    Private Sub SIGN_UP_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIGN_UP_BTN.Click

        'input validation for user
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Choose the time limit before proceeding", "START ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If Val(TextBox1.Text) >= 61 And Val(TextBox2.Text) >= 0 Then
            MessageBox.Show("Maximum Time limit is only: 60 minutes & 59 seconds ", "START ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MessageBox.Show("Invalid Time limit is only", "START ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Val(TextBox1.Text) = 0 And Val(TextBox2.Text) = 0 Then
            MessageBox.Show("Invalid Time limit is only", "START ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Val(TextBox2.Text) >= 60 Then
            MessageBox.Show("Invalid Time limit is only", "START ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Val(BC_tb.Text) >= 51 Then
            MessageBox.Show("Maximum Questions are: 50 only", "START ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Val(BC_tb.Text) <= 0 Then
            MessageBox.Show("INVALID NUMBER OF QUESTIONS", "START ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'adjusts the locatin of the timer labels
        If TextBox1.TextLength = 1 Then
            TextBox1.Left = 852
        End If

        'bringing the group box 1 to front that contains the answer and questions
        GroupBox2.Visible = False
        GroupBox1.BringToFront()

        'when checked it will not display the timer
        If RadioButton1.Checked = True Then

            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label8.Text = Val(TextBox1.Text)
            Label10.Text = Val(TextBox2.Text)
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If

        If Label10.Text.Length = 1 Then
            Label10.Text = "0" + Label10.Text
        End If

        If Label8.Text.Length = 1 Then
            Label8.Text = "0" + Label8.Text
        End If

        GroupBox2.Visible = False
        GroupBox2.Enabled = False
        GroupBox1.BringToFront()

        Label12.Visible = True
        Label11.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label17.Text = "Points: " & points
        GroupBox1.BackColor = Color.SkyBlue
        GroupBox1.BringToFront()

        Timer5.Enabled = True
        overall_ques = Val(BC_tb.Text)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Enabled = False
        TextBox2.Enabled = False

    End Sub

    'character filtration only accepts numbers
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'character filtration only accepts numbers
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'character filtration only accepts numbers
    Private Sub BC_tb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BC_tb.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub

    'sets up the default values
    Private Sub UMAK_QUIZ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        BC_tb.Text = 1
        TextBox1.Text = "01"
        TextBox2.Text = "00"
        GroupBox1.BackColor = Color.Transparent
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'makeshift program to create a timer 

        If Val(Label10.Text) >= 1 Then
            Label10.Text = Val(Label10.Text) - 1
        End If

        If Val(Label10.Text) = 0 Then
            Label10.Text = 59
            Label8.Text = Val(Label8.Text) - 1
        End If

        If Label10.Text.Length = 1 Then
            Label10.Text = "0" + Label10.Text
        End If

        If Label8.Text.Length = 1 Then
            Label8.Text = "0" + Label8.Text
        End If


    End Sub

    'shen timer has been reached, it will notify and back out the user. Revealing their scores at the end
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Val(Label8.Text) = -1 Then
            Close()
            MAIN_INTERFACE.Show()
            MessageBox.Show("Time Limit has been reached" & vbNewLine & "Points: " & points & " over " & overall_ques & " Questions" & vbNewLine & vbNewLine & "Score Percentage: " & String.Format("{0:n2}", ((points / overall_ques) * 100)) & "%", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    'creation of random questions assigned at different interval numbers
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

        'click once validation for scoring
        click_once += 1

        'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
        If num_gen = 6 Or num_gen = 9 Or num_gen = 12 Or num_gen = 18 Or num_gen = 21 Or num_gen = 22 Or num_gen = 23 Or num_gen = 24 Or num_gen = 25 Or num_gen = 26 Or num_gen = 31 Or num_gen = 41 Or num_gen = 43 Or num_gen = 49 Then
            If click_once = 1 Then
                points += 1
            End If

            Label17.Text = "Points: " & points
            Label13.ForeColor = Color.Green
            Label14.ForeColor = Color.DarkRed
            Label15.ForeColor = Color.DarkRed
            Label16.ForeColor = Color.DarkRed
        Else
            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 1 Or num_gen = 7 Or num_gen = 8 Or num_gen = 13 Or num_gen = 30 Or num_gen = 33 Or num_gen = 38 Or num_gen = 45 Or num_gen = 46 Or num_gen = 50 Then
                Label13.ForeColor = Color.DarkRed
                Label14.ForeColor = Color.Green
                Label15.ForeColor = Color.DarkRed
                Label16.ForeColor = Color.DarkRed
            End If
            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 3 Or num_gen = 4 Or num_gen = 10 Or num_gen = 14 Or num_gen = 16 Or num_gen = 17 Or num_gen = 19 Or num_gen = 20 Or num_gen = 27 Or num_gen = 29 Or num_gen = 34 Or num_gen = 36 Or num_gen = 40 Or num_gen = 42 Or num_gen = 47 Then
                Label13.ForeColor = Color.DarkRed
                Label14.ForeColor = Color.DarkRed
                Label15.ForeColor = Color.Green
                Label16.ForeColor = Color.DarkRed
            End If
            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 2 Or num_gen = 5 Or num_gen = 11 Or num_gen = 15 Or num_gen = 28 Or num_gen = 16 Or num_gen = 35 Or num_gen = 37 Or num_gen = 39 Or num_gen = 44 Or num_gen = 48 Or num_gen = 32 Then
                Label13.ForeColor = Color.DarkRed
                Label14.ForeColor = Color.DarkRed
                Label15.ForeColor = Color.DarkRed
                Label16.ForeColor = Color.Green
            End If
        End If

        Timer4.Enabled = True
        Timer3.Enabled = True


    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        'click once validation for scoring
        click_once += 1
        'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
        If num_gen = 1 Or num_gen = 7 Or num_gen = 8 Or num_gen = 13 Or num_gen = 30 Or num_gen = 33 Or num_gen = 38 Or num_gen = 45 Or num_gen = 46 Or num_gen = 50 Then
            If click_once = 1 Then
                points += 1
            End If
            Label17.Text = "Points: " & points
            Label13.ForeColor = Color.DarkRed
            Label14.ForeColor = Color.Green
            Label15.ForeColor = Color.DarkRed
            Label16.ForeColor = Color.DarkRed
        Else
            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 6 Or num_gen = 9 Or num_gen = 12 Or num_gen = 18 Or num_gen = 21 Or num_gen = 22 Or num_gen = 23 Or num_gen = 24 Or num_gen = 25 Or num_gen = 26 Or num_gen = 31 Or num_gen = 41 Or num_gen = 43 Or num_gen = 49 Then
                Label13.ForeColor = Color.Green
                Label14.ForeColor = Color.DarkRed
                Label15.ForeColor = Color.DarkRed
                Label16.ForeColor = Color.DarkRed
            End If
            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 3 Or num_gen = 4 Or num_gen = 10 Or num_gen = 14 Or num_gen = 16 Or num_gen = 17 Or num_gen = 19 Or num_gen = 20 Or num_gen = 27 Or num_gen = 29 Or num_gen = 34 Or num_gen = 36 Or num_gen = 40 Or num_gen = 42 Or num_gen = 47 Then
                Label13.ForeColor = Color.DarkRed
                Label14.ForeColor = Color.DarkRed
                Label15.ForeColor = Color.Green
                Label16.ForeColor = Color.DarkRed
            End If
            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 2 Or num_gen = 5 Or num_gen = 11 Or num_gen = 15 Or num_gen = 28 Or num_gen = 16 Or num_gen = 35 Or num_gen = 37 Or num_gen = 39 Or num_gen = 44 Or num_gen = 48 Or num_gen = 32 Then
                Label13.ForeColor = Color.DarkRed
                Label14.ForeColor = Color.DarkRed
                Label15.ForeColor = Color.DarkRed
                Label16.ForeColor = Color.Green
            End If
        End If

        Timer4.Enabled = True
        Timer3.Enabled = True
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

        'click once validation for scoring
        click_once += 1

        'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
        If num_gen = 3 Or num_gen = 4 Or num_gen = 10 Or num_gen = 14 Or num_gen = 16 Or num_gen = 17 Or num_gen = 19 Or num_gen = 20 Or num_gen = 27 Or num_gen = 29 Or num_gen = 34 Or num_gen = 36 Or num_gen = 40 Or num_gen = 42 Or num_gen = 47 Then
            If click_once = 1 Then
                points += 1
            End If
            Label17.Text = "Points: " & points
            Label13.ForeColor = Color.DarkRed
            Label14.ForeColor = Color.DarkRed
            Label15.ForeColor = Color.Green
            Label16.ForeColor = Color.DarkRed
        Else

            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 6 Or num_gen = 9 Or num_gen = 12 Or num_gen = 18 Or num_gen = 21 Or num_gen = 22 Or num_gen = 23 Or num_gen = 24 Or num_gen = 25 Or num_gen = 26 Or num_gen = 31 Or num_gen = 41 Or num_gen = 43 Or num_gen = 49 Then
                Label13.ForeColor = Color.Green
                Label14.ForeColor = Color.DarkRed
                Label15.ForeColor = Color.DarkRed
                Label16.ForeColor = Color.DarkRed
            End If


            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 1 Or num_gen = 7 Or num_gen = 8 Or num_gen = 13 Or num_gen = 30 Or num_gen = 33 Or num_gen = 38 Or num_gen = 45 Or num_gen = 46 Or num_gen = 50 Then
                Label13.ForeColor = Color.DarkRed
                Label14.ForeColor = Color.Green
                Label15.ForeColor = Color.DarkRed
                Label16.ForeColor = Color.DarkRed
            End If


            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 2 Or num_gen = 5 Or num_gen = 11 Or num_gen = 15 Or num_gen = 28 Or num_gen = 16 Or num_gen = 35 Or num_gen = 37 Or num_gen = 39 Or num_gen = 44 Or num_gen = 48 Or num_gen = 32 Then
                Label13.ForeColor = Color.DarkRed
                Label14.ForeColor = Color.DarkRed
                Label15.ForeColor = Color.DarkRed
                Label16.ForeColor = Color.Green
            End If
        End If

        Timer4.Enabled = True
        Timer3.Enabled = True
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
        'click once validation for scoring
        click_once += 1

        'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
        If num_gen = 2 Or num_gen = 5 Or num_gen = 11 Or num_gen = 15 Or num_gen = 28 Or num_gen = 16 Or num_gen = 35 Or num_gen = 37 Or num_gen = 39 Or num_gen = 44 Or num_gen = 48 Or num_gen = 32 Then
            If click_once = 1 Then
                points += 1
            End If
            Label17.Text = "Points: " & points
            Label13.ForeColor = Color.DarkRed
            Label14.ForeColor = Color.DarkRed
            Label15.ForeColor = Color.DarkRed
            Label16.ForeColor = Color.Green

        Else
            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 6 Or num_gen = 9 Or num_gen = 12 Or num_gen = 18 Or num_gen = 21 Or num_gen = 22 Or num_gen = 23 Or num_gen = 24 Or num_gen = 25 Or num_gen = 26 Or num_gen = 31 Or num_gen = 41 Or num_gen = 43 Or num_gen = 49 Then
                Label13.ForeColor = Color.Green
                Label14.ForeColor = Color.DarkRed
                Label15.ForeColor = Color.DarkRed
                Label16.ForeColor = Color.DarkRed
            End If
            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 1 Or num_gen = 7 Or num_gen = 8 Or num_gen = 13 Or num_gen = 30 Or num_gen = 33 Or num_gen = 38 Or num_gen = 45 Or num_gen = 46 Or num_gen = 50 Then
                Label13.ForeColor = Color.DarkRed
                Label14.ForeColor = Color.Green
                Label15.ForeColor = Color.DarkRed
                Label16.ForeColor = Color.DarkRed
            End If
            'checks the assigned nummbers on what option id the right one, turning the right answer to green forecolor
            If num_gen = 3 Or num_gen = 4 Or num_gen = 10 Or num_gen = 14 Or num_gen = 16 Or num_gen = 17 Or num_gen = 19 Or num_gen = 20 Or num_gen = 27 Or num_gen = 29 Or num_gen = 34 Or num_gen = 36 Or num_gen = 40 Or num_gen = 42 Or num_gen = 47 Then
                Label13.ForeColor = Color.DarkRed
                Label14.ForeColor = Color.DarkRed
                Label15.ForeColor = Color.Green
                Label16.ForeColor = Color.DarkRed
            End If

        End If

        Timer4.Enabled = True
        Timer3.Enabled = True
    End Sub

    'turns the label back to its normal forcolors after certain time
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label13.ForeColor = Color.Black
        Label14.ForeColor = Color.Black
        Label15.ForeColor = Color.Black
        Label16.ForeColor = Color.Black

        Timer3.Enabled = False
    End Sub

    'generates question and refreshes it every 0.9 seconds interval
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick

        If Timer4.Interval = 900 Then
            Timer5.Enabled = True
            click_once = 0
        End If
        Timer4.Enabled = False
    End Sub

    Private Sub Timer5_Tick() Handles Timer5.Tick
        num_gen = gen.Next(1, 50)

        For ques_count = 1 To count
            If num_collect(ques_count) = num_gen Then
                num_gen = gen.Next(1, 50)
            End If
        Next
        num_collect(count) = num_gen
        
        If count > Val(BC_tb.Text) Then
            Close()
            MAIN_INTERFACE.Show()
            MessageBox.Show("Question Limit has been reached" & vbNewLine & "Points: " & points & " over " & overall_ques & " Questions" & vbNewLine & vbNewLine & "Score Percentage: " & String.Format("{0:n2}", ((points / overall_ques) * 100)) & "%", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Label12.Text = "Question #" & count


        'All the ready made questions
        If num_gen = 1 Then

            Label11.Text = "Who is the Senior High School Dean?"

            Label13.Text = "Atty. Jewel D. Bulos"
            Label14.Text = "Dr. Ma. Corazon E. Benosa"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 2 Then

            Label11.Text = "Who is the College Dean?"

            Label13.Text = "Atty. Jewel D. Bulos"
            Label14.Text = "Dr. Ma. Corazon E. Benosa"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 3 Then

            Label11.Text = "Who is the OIC University President?"

            Label13.Text = "Atty. Jewel D. Bulos"
            Label14.Text = "Dr. Ma. Corazon E. Benosa"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 4 Then

            Label11.Text = "Who is the Vice President for Academic Affairs?"

            Label13.Text = "Atty. Jewel D. Bulos"
            Label14.Text = "Dr. Ma. Corazon E. Benosa"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 5 Then

            Label11.Text = "Who is the Vice President for Planning and Research?"

            Label13.Text = "Atty. Jewel D. Bulos"
            Label14.Text = "Dr. Ma. Corazon E. Benosa"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 6 Then

            Label11.Text = "Who is the Vice President for Administration?"

            Label13.Text = "Atty. Jewel D. Bulos"
            Label14.Text = "Dr. Ma. Corazon E. Benosa"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 7 Then

            Label11.Text = "Who is the Associate Professor and Director, Graduate Programs in Public Administration and Executive Doctorate in Leadership Program?"

            Label13.Text = "Atty. Jewel D. Bulos"
            Label14.Text = "A.P Pompeyo C. Adamos II"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 8 Then

            Label11.Text = "Who is the Vice President for Finance?"

            Label13.Text = "Atty. Jewel D. Bulos"
            Label14.Text = "Ms. Aurora F. Serrano, CPA"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"


        ElseIf num_gen = 9 Then

            Label11.Text = "Who is the Vice President for Student Services and Community Development?"

            Label13.Text = "Prof. Virgilio B. Tabbu"
            Label14.Text = "Ms. Aurora F. Serrano, CPA"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Estela P. De Vera"


        ElseIf num_gen = 10 Then

            Label11.Text = "Who is the University Secretary?"

            Label13.Text = "Prof. Virgilio B. Tabbu"
            Label14.Text = "Ms. Aurora F. Serrano, CPA"
            Label15.Text = "Engr. Luke Ivan B. Moro"
            Label16.Text = "Estela P. DE Vera"

        ElseIf num_gen = 11 Then

            Label11.Text = "When is the foundation year of University of Makati?"

            Label13.Text = "1970"
            Label14.Text = "1971"
            Label15.Text = "1969"
            Label16.Text = "1972"

        ElseIf num_gen = 12 Then

            Label11.Text = "Who is the Assistant Professor College Secretary and Director?"

            Label13.Text = "Assistant Prof. Noel A. Ybañez"
            Label14.Text = "Assistant Prof. Justine Marie A. Ocampo"
            Label15.Text = "Engr. Luke Ivan B. Moro"
            Label16.Text = "Estela P. DE Vera"

        ElseIf num_gen = 13 Then

            Label11.Text = "What is the original name of University of Makati?"

            Label13.Text = "University of Makati (UMAK)"
            Label14.Text = "Makati Polytechnic Community College (MPCC)"
            Label15.Text = "Makati College"
            Label16.Text = "Pamantasan ng Makati (PnM)"

        ElseIf num_gen = 14 Then



            Label11.Text = "What is the name of the University of Makati after MPCC in 1987?"

            Label13.Text = "Univeristy of Makati (UMAK)"
            Label14.Text = "Makati Polytechnic Community College (MPCC)"
            Label15.Text = "Makati College"
            Label16.Text = "Pamantasan ng Makati (PnM)"

        ElseIf num_gen = 15 Then

            Label11.Text = "What is the name of the University of Makati after it was named as Makati College in 1991?"

            Label13.Text = "Univeristy of Makati (UMAK)"
            Label14.Text = "Makati Polytechnic Community College (MPCC)"
            Label15.Text = "Makati College"
            Label16.Text = "Pamantasan ng Makati (PnM)"

        ElseIf num_gen = 16 Then

            Label11.Text = "When did they changed its name to University of Makati?"

            Label13.Text = "2000"
            Label14.Text = "1999"
            Label15.Text = "2002"
            Label16.Text = "2001"

        ElseIf num_gen = 17 Then

            Label11.Text = "Who is the Director (OIC), Special Programs in Development Management and Governance?"

            Label13.Text = "Professor Michael C. Tolentino"
            Label14.Text = "Dr. Danilo C. Sabado, DT"
            Label15.Text = "Assistant Professor Sonio F. Pimentel, MDMG"
            Label16.Text = "Associate Professor Janice Pola D. Congzon, MIT "

        ElseIf num_gen = 18 Then

            Label11.Text = "Who is the Director (OIC), Advanced Programs in Education?"

            Label13.Text = "Associate Professor Rhene Tabejen, PhD"
            Label14.Text = "Professor Michael C. Tolentino"
            Label15.Text = "Associate Professor Janice Pola D. Congzon, MIT "
            Label16.Text = "Assistant Professor Sonio F. Pimentel, MDMG"


        ElseIf num_gen = 19 Then

            Label11.Text = "Who is the Chief-of-Staff, Office of the Vice President for Planning and Research (concurrent)?"

            Label13.Text = "Associate Professor Janice Pola D. Congzon, MIT "
            Label14.Text = "Assistant Professor Sonio F. Pimentel, MDMG"
            Label15.Text = "Assistant Professor Ana Christina M. Dela Cruz, MA"
            Label16.Text = "Associate Professor Rhene Tabejen, PhD"

        ElseIf num_gen = 20 Then

            Label11.Text = "What are the 4 Core Values?"

            Label13.Text = "Price, Product, Place, Promotion"
            Label14.Text = "Reduce, Reuse, Recycle, Recover"
            Label15.Text = "Makadiyos, Makatao, Makakalikasan, Makabansa"
            Label16.Text = "Respect for autonomy, Beneficence, nonmaleficence, justice"

        ElseIf num_gen = 21 Then

            Label11.Text = "Who is the Department Head, Academics?"

            Label13.Text = "Dr. Tomasa F. Quiñones"
            Label14.Text = "Dr. Danilo C. Sabado, DT"
            Label15.Text = "Dr. Ma. Corazon E. Benosa"
            Label16.Text = "Dr. Elyxzur C. Ramos"

        ElseIf num_gen = 22 Then

            Label11.Text = "Who is the Department Head, Skills-based Courses and Work Immersion?"

            Label13.Text = "Prof. Audimor J. Pelayo Sr."
            Label14.Text = "Prof. Michael C. Tolentino"
            Label15.Text = "Prof. Virgilio B. Tabbu"
            Label16.Text = "Prof. Tomas B. Lopez Jr."

        ElseIf num_gen = 23 Then

            Label11.Text = "What is the office hours of University of Makati?"

            Label13.Text = "8:00am - 5:00pm"
            Label14.Text = "6:00am - 4:00pm"
            Label15.Text = "7:00am - 5:00pm"
            Label16.Text = "9:00am - 3:00pm"

        ElseIf num_gen = 24 Then

            Label11.Text = "Who is the UMAK Research Director?"

            Label13.Text = "Prof. Florante E. Delos Santos"
            Label13.Text = "Professor Michael C. Tolentino"
            Label13.Text = "Prof. Virgilio B. Tabbu"
            Label13.Text = "Prof. Tomas B. Lopez Jr."


        ElseIf num_gen = 25 Then

            Label11.Text = "Where is the School of Law located?"

            Label13.Text = "5th Floor of Health and Physical Science"
            Label14.Text = "4th Floor of Aero Dance and Dance Room"
            Label15.Text = "1st Floor of Registrar and Faculty"
            Label16.Text = "2nd Floor Office of the Principal"

        ElseIf num_gen = 26 Then

            Label11.Text = "How many colleges does University of Makati have?"

            Label13.Text = "15 Colleges"
            Label14.Text = "18 Colleges"
            Label15.Text = "12 Colleges"
            Label16.Text = "14 Colleges"

        ElseIf num_gen = 27 Then

            Label11.Text = "Where is the Higher School ng UMak located?"

            Label13.Text = "2nd Floor Office of the Principal"
            Label14.Text = "5th Floor of Health and Physical"
            Label15.Text = "3rd floor Academic Building 2"
            Label16.Text = "1st Floor of Registrar and Faculty"

        ElseIf num_gen = 28 Then


            Label13.Text = "Prof. Noel A. Ybañez"
            Label14.Text = "Prof. Pompeyo C. Adamos"
            Label15.Text = "Prof.  Ana Christina M. Dela Cruz"
            Label16.Text = "Prof. Tomas B. Lopez Jr."

            Label11.Text = "Who is the University President?"

        ElseIf num_gen = 29 Then


            Label13.Text = "Puerto Rico St, Makati City"
            Label14.Text = "Aguho Street, Comembo, Makati City"
            Label15.Text = "J.P. Rizal Extension West Rembo Makati City"
            Label16.Text = "Negros Street, Makati City"

            Label11.Text = "Where is the University of Makati  located?"

        ElseIf num_gen = 30 Then

            Label13.Text = "Edwin Asoro"
            Label14.Text = "Jasmin Figueroa"
            Label15.Text = "Ayssa Dalida"
            Label16.Text = "Arnel Ignacio"

            Label11.Text = "Who is the archer, who’s an athlete in Umak that participated at the 2004 Athens Olympic?"

        ElseIf num_gen = 31 Then

            Label13.Text = "Ayssa Dalida"
            Label14.Text = "China Roces"
            Label15.Text = "Jasmin Figueroa"
            Label16.Text = "Arnel Ignacio"


            Label11.Text = "An athlete also in Umak, who represented the Philippines 16th Asian Games in Guangzhou, China"

        ElseIf num_gen = 32 Then

            Label13.Text = "Ayssa Dalida"
            Label14.Text = "China Roces"
            Label15.Text = "Ramon Galicia"
            Label16.Text = "Edwin Asoro"

            Label11.Text = "He led the university in the finals of NAASCU in 2002"

        ElseIf num_gen = 33 Then

            Label13.Text = "8 Students"
            Label14.Text = "19 Students"
            Label15.Text = "20 Students"
            Label16.Text = "17 Students"

            Label11.Text = "How many students in Umak passed in CPA Board Examination on October 2011?"

        ElseIf num_gen = 34 Then

            Label13.Text = "Honor and Excellence"
            Label14.Text = "Truth in Charity"
            Label15.Text = "Aim High, UMak"
            Label16.Text = "Be Brave"

            Label11.Text = "What is the motto of Umak?"



        ElseIf num_gen = 35 Then

            Label13.Text = "Heroes"
            Label14.Text = "Umakers"
            Label15.Text = "Flyers"
            Label16.Text = "Herons"


            Label11.Text = "What do you call the student in University of Makati?"

        ElseIf num_gen = 36 Then

            Label13.Text = "Rene Mostrales"
            Label14.Text = "Marlou Gile"
            Label15.Text = "John Philip Bravo"
            Label16.Text = "Arthur Ignacio"

            Label11.Text = "He served as treasurer of the University of Makati College of Arts and Letter Student Council 2019-2020"

        ElseIf num_gen = 37 Then

            Label13.Text = "Rene Mostrales"
            Label14.Text = "Marlou Gile"
            Label15.Text = "John Philip Bravo"
            Label16.Text = "Prof. Florante E. Delos Santos"


            Label11.Text = "He is a tenured assistant professor at the University of Makati and a former Assistant Director of the Center for Guidance Services and is the current University Research Director of UMak"

        ElseIf num_gen = 38 Then

            Label11.Text = "Who is the dean of College of Technology Management?"

            Label13.Text = "Ms. Aurora F. Serrano"
            Label14.Text = "Prof. Moner G. Raguindin"
            Label15.Text = "Dr. Danilo C. Sabado"
            Label16.Text = "Atty. Cecilio Dioneda Duka"


        ElseIf num_gen = 39 Then

            Label11.Text = "What is the occasion on October 28 to November 3, 2021?"

            Label13.Text = "Foundation Day"
            Label14.Text = "CSS Competition"
            Label15.Text = "Halloween"
            Label16.Text = "Self-Care Awareness Week"


        ElseIf num_gen = 40 Then

            Label11.Text = "Former Hsu-SSG President A.Y. '2020-2021'"

            Label13.Text = "Marie Anne Lei Lina "
            Label14.Text = "Rhys Josiah Raval "
            Label15.Text = "Krisha Pangilinan"
            Label16.Text = "Marianne Stefanny Audar"


        ElseIf num_gen = 41 Then

            Label11.Text = "Higher School ng UMak - Supreme Student Government Adviser"

            Label13.Text = "Prof. Gladys O. Magno"
            Label14.Text = "Prof. Audimor J. Pelayo Sr."
            Label15.Text = "Dr.Elyxzur C. Ramos"
            Label16.Text = " Atty. Cecilio Dioneda Duka"


        ElseIf num_gen = 42 Then

            Label11.Text = "Director for Center For Community Development In Nation Building"

            Label13.Text = "Prof. Noel A. Ybañez"
            Label14.Text = "Prof. Audimor J. Pelayo Sr."
            Label15.Text = "Mr. Niño E. Faustino"
            Label16.Text = " Prof. Sonia F. Pimentel"


        ElseIf num_gen = 43 Then

            Label11.Text = "Dean of College of Allied Health Studies"

            Label13.Text = "Dr. Maria Fay Nenette Maximo-Cariaga"
            Label14.Text = "Dr. Maria Corazon E. Benosa"
            Label15.Text = "Dr. Ederson T. Tapia"
            Label16.Text = " Dr. Danilo C. Sabado"


        ElseIf num_gen = 44 Then

            Label11.Text = "Dean of College of Arts and Letters"
            Label13.Text = "Prof. Edita C. Bayona"
            Label14.Text = "Dr. Danilo C. Sabado"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Prof. Mary Acel D. German"

        ElseIf num_gen = 45 Then

            Label11.Text = "Dean of College of Human Kinetics"

            Label13.Text = "Prof. Edita C. Bayona"
            Label14.Text = "Prof. Michael C. Tolentino"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 46 Then

            Label11.Text = "Dean of College of Construction Sciences and Engineering"
            Label13.Text = "Prof. Edita C. Bayona"
            Label14.Text = "Engr. Concepcion Laurico"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 47 Then

            Label11.Text = "Dean of College of Education"

            Label13.Text = "Prof. Edita C. Bayona"
            Label14.Text = "Dr. Danilo C. Sabado"
            Label15.Text = "Atty. Cecilio Dioneda Duka"
            Label16.Text = "Dr. Ederson T. Tapia"

        ElseIf num_gen = 48 Then

            Label11.Text = "Dean of College Of Technology Management"

            Label13.Text = "Prof. Edita C. Bayona"
            Label14.Text = "Dr. Danilo C. Sabado"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Prof. Moner G. Raguindin"


        ElseIf num_gen = 49 Then

            Label11.Text = "Dean of College Of Tourism And Hospitality Management"

            Label13.Text = "Prof. Edita C. Bayona"
            Label14.Text = "Dr. Danilo C. Sabado"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"


        ElseIf num_gen = 50 Then

            Label11.Text = "Dean of College Of Computer Science"

            Label13.Text = "Atty. Jewel D. Bulos"
            Label14.Text = "Dr. Danilo C. Sabado"
            Label15.Text = "Dr. Elyxzur C. Ramos"
            Label16.Text = "Dr. Ederson T. Tapia"

           


        End If

        'If the choice is too big, it will automatically adjust to the size of the border set by the textbox
        If Label13.Text.Length >= 35 Then
            Label13.Font = New Font(Label13.Font.FontFamily, 18, FontStyle.Bold)
        Else
            Label13.Font = New Font(Label13.Font.FontFamily, 26, FontStyle.Bold)
        End If
        If Label14.Text.Length >= 35 Then
            Label14.Font = New Font(Label13.Font.FontFamily, 18, FontStyle.Bold)
        Else
            Label14.Font = New Font(Label13.Font.FontFamily, 26, FontStyle.Bold)

        End If
        If Label15.Text.Length >= 35 Then
            Label15.Font = New Font(Label13.Font.FontFamily, 18, FontStyle.Bold)
        Else
            Label15.Font = New Font(Label13.Font.FontFamily, 26, FontStyle.Bold)

        End If
        If Label16.Text.Length >= 40 Then
            Label16.Font = New Font(Label13.Font.FontFamily, 15, FontStyle.Bold)
        ElseIf Label16.Text.Length >= 35 Then
            Label16.Font = New Font(Label13.Font.FontFamily, 18, FontStyle.Bold)
        Else
            Label16.Font = New Font(Label13.Font.FontFamily, 26, FontStyle.Bold)

        End If


        count += 1
        Timer5.Enabled = False
    End Sub

    
   
   
End Class