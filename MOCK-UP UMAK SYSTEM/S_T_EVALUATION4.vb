Public Class S_T_EVALUATION4
    'POINTING SYSTEM
    ' SPORTS - LEVERAGE BY 5
    ' ACADEMIC - LEVERAGE 3
    ' ARTS - LEVERAGE  3
    ' TVL - LEVERAGE 2

    'Reason: Quantity of questions is in favor of TVL track since it has the most strand emebedded
    'SPORT has the least

    'Main form is the parent form

    'only once processing of scores

    Dim once_count As Integer = 0

    'needed variables for processing of scores
    Public DRAFTING As Integer = 0
    Public AUTOMOTIVE As Integer = 0
    Public ASSEMBLY As Integer = 0
    Public MAINTENANCE As Integer = 0
    Public CONSTRUCTION As Integer = 0
    Public WELDING As Integer = 0

    'returns the user to the hsu interface and deltes their saved progress
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        If MessageBox.Show("All of your progress will be lost.." & vbNewLine & "CONTINUE?", "NOTIFICATION BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Hide()
            HSU_INTERFACE.Show()
            S_T_EVALUATION.Close()
            S_T_EVALUATION2.Close()
            S_T_EVALUATION3.Close()
            Close()
        End If
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

        'only once processing validation
        If once_count = 0 Then
            five_1.Checked = False
            once_count += 1
        End If

        'the form needs atleast one per number of radiobutton to be checked to proceed
        If (one_1.Checked = True Or two_1.Checked = True Or three_1.Checked = True Or four_1.Checked = True Or five_1.Checked = True) And (one_2.Checked = True Or two_2.Checked = True Or three_2.Checked = True Or four_2.Checked = True Or five_2.Checked = True) And (one_3.Checked = True Or two_3.Checked = True Or three_3.Checked = True Or four_3.Checked = True Or five_3.Checked = True) And (one_4.Checked = True Or two_4.Checked = True Or three_4.Checked = True Or four_4.Checked = True Or five_4.Checked = True) And (one_5.Checked = True Or two_5.Checked = True Or three_5.Checked = True Or four_5.Checked = True Or five_5.Checked = True) And (one_6.Checked = True Or two_6.Checked = True Or three_6.Checked = True Or four_6.Checked = True Or five_6.Checked = True) Then
            SUBMIT.Enabled = True
            SUBMIT.Visible = True
        End If
    End Sub

    'infomation box
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        MessageBox.Show("Rate the following items with 1 - being the not likely && 5 - being the likely", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    'resets the scores when user chooses to go back
    Private Sub back_arr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_arr.Click
        S_T_EVALUATION3.Show()
        S_T_EVALUATION3.HOTEL_REST = 0
        S_T_EVALUATION3.Tourism = 0
        S_T_EVALUATION3.FOOD = 0
        S_T_EVALUATION3.HEALTH = 0
        S_T_EVALUATION3.EMERGENCY = 0
        S_T_EVALUATION3.PROGRAMMING = 0
        S_T_EVALUATION3.SERVICING = 0
        S_T_EVALUATION3.BPO = 0
        Hide()
    End Sub

    'poiting system begins when submit button is clicked
    Private Sub SUBMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUBMIT.Click
        'Q1
        'pointing system begins
        If S_T_EVALUATION2.one_1.Checked = True Then
            S_T_EVALUATION.ACAD_score += 1

        ElseIf S_T_EVALUATION2.two_1.Checked = True Then

            S_T_EVALUATION.ACAD_score += 2

        ElseIf S_T_EVALUATION2.three_1.Checked = True Then

            S_T_EVALUATION.ACAD_score += 3

        ElseIf S_T_EVALUATION2.four_1.Checked = True Then

            S_T_EVALUATION.ACAD_score += 4

        ElseIf S_T_EVALUATION2.five_1.Checked = True Then

            S_T_EVALUATION.ACAD_score += 5
        End If

        'Q2
        'pointing system begins
        If S_T_EVALUATION2.one_2.Checked = True Then

            S_T_EVALUATION.ACAD_score += 1

        ElseIf S_T_EVALUATION2.two_2.Checked = True Then

            S_T_EVALUATION.ACAD_score += 2

        ElseIf S_T_EVALUATION2.three_2.Checked = True Then

            S_T_EVALUATION.ACAD_score += 3

        ElseIf S_T_EVALUATION2.four_2.Checked = True Then

            S_T_EVALUATION.ACAD_score += 4

        ElseIf S_T_EVALUATION2.five_2.Checked = True Then

            S_T_EVALUATION.ACAD_score += 5
        End If

        'Q3
        'pointing system begins
        If S_T_EVALUATION2.one_3.Checked = True Then

            S_T_EVALUATION.ACAD_score += 1

        ElseIf S_T_EVALUATION2.two_3.Checked = True Then

            S_T_EVALUATION.ACAD_score += 2

        ElseIf S_T_EVALUATION2.three_3.Checked = True Then

            S_T_EVALUATION.ACAD_score += 3

        ElseIf S_T_EVALUATION2.four_3.Checked = True Then

            S_T_EVALUATION.ACAD_score += 4

        ElseIf S_T_EVALUATION2.five_3.Checked = True Then

            S_T_EVALUATION.ACAD_score += 5
        End If

        'Q4
        'pointing system begins
        If S_T_EVALUATION2.one_4.Checked = True Then

            S_T_EVALUATION.ARTS_score += 1

        ElseIf S_T_EVALUATION2.two_4.Checked = True Then

            S_T_EVALUATION.ARTS_score += 2

        ElseIf S_T_EVALUATION2.three_4.Checked = True Then

            S_T_EVALUATION.ARTS_score += 3

        ElseIf S_T_EVALUATION2.four_4.Checked = True Then

            S_T_EVALUATION.ARTS_score += 4

        ElseIf S_T_EVALUATION2.five_4.Checked = True Then

            S_T_EVALUATION.ARTS_score += 5
        End If

        'Q5
        'pointing system begins
        If S_T_EVALUATION2.one_5.Checked = True Then

            S_T_EVALUATION.ARTS_score += 1

        ElseIf S_T_EVALUATION2.two_5.Checked = True Then

            S_T_EVALUATION.ARTS_score += 2

        ElseIf S_T_EVALUATION2.three_5.Checked = True Then

            S_T_EVALUATION.ARTS_score += 3

        ElseIf S_T_EVALUATION2.four_5.Checked = True Then

            S_T_EVALUATION.ARTS_score += 4

        ElseIf S_T_EVALUATION2.five_5.Checked = True Then

            S_T_EVALUATION.ARTS_score += 5
        End If

        'Q6
        'pointing system begins
        If S_T_EVALUATION2.one_6.Checked = True Then

            S_T_EVALUATION.ARTS_score += 1

        ElseIf S_T_EVALUATION2.two_6.Checked = True Then

            S_T_EVALUATION.ARTS_score += 2

        ElseIf S_T_EVALUATION2.three_6.Checked = True Then

            S_T_EVALUATION.ARTS_score += 3

        ElseIf S_T_EVALUATION2.four_6.Checked = True Then

            S_T_EVALUATION.ARTS_score += 4

        ElseIf S_T_EVALUATION2.five_6.Checked = True Then

            S_T_EVALUATION.ARTS_score += 5
        End If

        'Q7
        'pointing system begins
        If S_T_EVALUATION2.one_7.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 1

        ElseIf S_T_EVALUATION2.two_7.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 2

        ElseIf S_T_EVALUATION2.three_7.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 3

        ElseIf S_T_EVALUATION2.four_7.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 4

        ElseIf S_T_EVALUATION2.five_7.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 5
        End If

        'Q8
        'pointing system begins
        If S_T_EVALUATION2.one_8.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 1

        ElseIf S_T_EVALUATION2.two_8.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 2

        ElseIf S_T_EVALUATION2.three_8.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 3

        ElseIf S_T_EVALUATION2.four_8.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 4

        ElseIf S_T_EVALUATION2.five_8.Checked = True Then

            S_T_EVALUATION.SPORTS_score += 5
        End If

        'poiting system begins for the provious evaluation form - s_t_evaluation3
        '------------------------------------------'
        'S_T3
        'Q1
        If S_T_EVALUATION3.one_1.Checked = True Then
            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.two_1.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.three_1.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.four_1.Checked = True Then

            S_T_EVALUATION.TVL_score += 1

        ElseIf S_T_EVALUATION3.five_1.Checked = True Then

            S_T_EVALUATION.TVL_score += 2
        End If

        'Q2
        If S_T_EVALUATION3.one_2.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.two_2.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.three_2.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.four_2.Checked = True Then

            S_T_EVALUATION.TVL_score += 1

        ElseIf S_T_EVALUATION3.five_2.Checked = True Then

            S_T_EVALUATION.TVL_score += 2
        End If

        'Q3
        If S_T_EVALUATION3.one_3.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.two_3.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.three_3.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.four_3.Checked = True Then

            S_T_EVALUATION.TVL_score += 1

        ElseIf S_T_EVALUATION3.five_3.Checked = True Then

            S_T_EVALUATION.TVL_score += 2
        End If

        'Q4
        If S_T_EVALUATION3.one_4.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.two_4.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.three_4.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.four_4.Checked = True Then

            S_T_EVALUATION.TVL_score += 1

        ElseIf S_T_EVALUATION3.five_4.Checked = True Then

            S_T_EVALUATION.TVL_score += 2
        End If

        'Q5
        If S_T_EVALUATION3.one_5.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.two_5.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.three_5.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.four_5.Checked = True Then

            S_T_EVALUATION.TVL_score += 1

        ElseIf S_T_EVALUATION3.five_5.Checked = True Then

            S_T_EVALUATION.TVL_score += 2
        End If

        'Q6
        If S_T_EVALUATION3.one_6.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.two_6.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.three_6.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.four_6.Checked = True Then

            S_T_EVALUATION.TVL_score += 1

        ElseIf S_T_EVALUATION3.five_6.Checked = True Then

            S_T_EVALUATION.TVL_score += 2
        End If

        'Q7
        If S_T_EVALUATION3.one_7.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.two_7.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.three_7.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.four_7.Checked = True Then

            S_T_EVALUATION.TVL_score += 1

        ElseIf S_T_EVALUATION3.five_7.Checked = True Then

            S_T_EVALUATION.TVL_score += 2
        End If

        'Q8
        If S_T_EVALUATION3.one_8.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.two_8.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.three_8.Checked = True Then

            S_T_EVALUATION.TVL_score += 0

        ElseIf S_T_EVALUATION3.four_8.Checked = True Then

            S_T_EVALUATION.TVL_score += 1

        ElseIf S_T_EVALUATION3.five_8.Checked = True Then

            S_T_EVALUATION.TVL_score += 2
        End If

        'poiting system begins for the provious evaluation form - s_t_evaluation4
        '________________________________________
        'S_T4

        If one_1.Checked = True Then
            DRAFTING += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf two_1.Checked = True Then
            DRAFTING += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf three_1.Checked = True Then
            DRAFTING += 1
            S_T_EVALUATION.TVL_score += 0

        ElseIf four_1.Checked = True Then
            DRAFTING += 2
            S_T_EVALUATION.TVL_score += 1

        ElseIf five_1.Checked = True Then
            DRAFTING += 3
            S_T_EVALUATION.TVL_score += 2
        End If

        'Q2
        If one_2.Checked = True Then
            AUTOMOTIVE += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf two_2.Checked = True Then
            AUTOMOTIVE += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf three_2.Checked = True Then
            AUTOMOTIVE += 1
            S_T_EVALUATION.TVL_score += 0

        ElseIf four_2.Checked = True Then
            AUTOMOTIVE += 2
            S_T_EVALUATION.TVL_score += 1

        ElseIf five_2.Checked = True Then
            AUTOMOTIVE += 3
            S_T_EVALUATION.TVL_score += 2
        End If

        'Q3
        If one_3.Checked = True Then
            ASSEMBLY += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf two_3.Checked = True Then
            ASSEMBLY += 0


        ElseIf three_3.Checked = True Then
            ASSEMBLY += 1
            S_T_EVALUATION.TVL_score += 0

        ElseIf four_3.Checked = True Then
            ASSEMBLY += 2
            S_T_EVALUATION.TVL_score += 1

        ElseIf five_3.Checked = True Then
            ASSEMBLY += 3
            S_T_EVALUATION.TVL_score += 2
        End If

        'Q4
        If one_4.Checked = True Then
            MAINTENANCE += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf two_4.Checked = True Then
            MAINTENANCE += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf three_4.Checked = True Then
            MAINTENANCE += 1
            S_T_EVALUATION.TVL_score += 0

        ElseIf four_4.Checked = True Then
            MAINTENANCE += 2
            S_T_EVALUATION.TVL_score += 1

        ElseIf five_4.Checked = True Then
            MAINTENANCE += 3
            S_T_EVALUATION.TVL_score += 2
        End If

        'Q5
        If one_5.Checked = True Then
            CONSTRUCTION += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf two_5.Checked = True Then
            CONSTRUCTION += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf three_5.Checked = True Then
            CONSTRUCTION += 1
            S_T_EVALUATION.TVL_score += 0

        ElseIf four_5.Checked = True Then
            CONSTRUCTION += 2
            S_T_EVALUATION.TVL_score += 1

        ElseIf five_5.Checked = True Then
            CONSTRUCTION += 3
            S_T_EVALUATION.TVL_score += 2
        End If

        'Q6
        If one_6.Checked = True Then
            WELDING += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf two_6.Checked = True Then
            WELDING += 0
            S_T_EVALUATION.TVL_score += 0

        ElseIf three_6.Checked = True Then
            WELDING += 1
            S_T_EVALUATION.TVL_score += 0

        ElseIf four_6.Checked = True Then
            WELDING += 2
            S_T_EVALUATION.TVL_score += 1

        ElseIf five_6.Checked = True Then
            WELDING += 3
            S_T_EVALUATION.TVL_score += 2
        End If

        S_T_EVALUATION5.Show()
        Hide()

        S_T_EVALUATION5.PictureBox6_Click()
    End Sub


    Private Sub S_T_EVALUATION4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class