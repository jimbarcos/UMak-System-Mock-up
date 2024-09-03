Public Class S_T_EVALUATION3
    'POINTING SYSTEM
    ' SPORTS - LEVERAGE BY 5
    ' ACADEMIC - LEVERAGE 3
    ' ARTS - LEVERAGE  3
    ' TVL - LEVERAGE 2

    'Reason: Quantity of questions is in favor of TVL track since it has the most strand emebedded
    'SPORT has the least

    'Main form is the parent form

    'validation for only one processing of scores
    Dim once_count As Integer = 0

    'needed public varibles for future processing of scores
    Public HOTEL_REST As Integer = 0
    Public Tourism As Integer = 0
    Public FOOD As Integer = 0
    Public HEALTH As Integer = 0
    Public EMERGENCY As Integer = 0
    Public PROGRAMMING As Integer = 0
    Public SERVICING As Integer = 0
    Public BPO As Integer = 0

    'returns the user and deltes their saved progress
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        If MessageBox.Show("All of your progress will be lost.." & vbNewLine & "CONTINUE?", "NOTIFICATION BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Hide()
            HSU_INTERFACE.Show()
            S_T_EVALUATION.Close()
            S_T_EVALUATION2.Close()
            Close()
        End If
    End Sub

    'closes the program
    Private Sub OFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFF.Click
        If MessageBox.Show("Close the Application?", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MAIN_FORM.Close()
        End If
    End Sub

    'displays date and time
    Private Sub SYS_D_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_D_T.Tick
        DTE.Text = Today.DayOfWeek.ToString & ", " & Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year
        TME.Text = TimeOfDay

        'only once processing validation
        If once_count = 0 Then
            five_1.Checked = False
            once_count += 1
        End If

        'the form needs atleast one per number of radiobutton to be checked to proceed
        If (one_1.Checked = True Or two_1.Checked = True Or three_1.Checked = True Or four_1.Checked = True Or five_1.Checked = True) And (one_2.Checked = True Or two_2.Checked = True Or three_2.Checked = True Or four_2.Checked = True Or five_2.Checked = True) And (one_3.Checked = True Or two_3.Checked = True Or three_3.Checked = True Or four_3.Checked = True Or five_3.Checked = True) And (one_4.Checked = True Or two_4.Checked = True Or three_4.Checked = True Or four_4.Checked = True Or five_4.Checked = True) And (one_5.Checked = True Or two_5.Checked = True Or three_5.Checked = True Or four_5.Checked = True Or five_5.Checked = True) And (one_6.Checked = True Or two_6.Checked = True Or three_6.Checked = True Or four_6.Checked = True Or five_6.Checked = True) And (one_7.Checked = True Or two_7.Checked = True Or three_7.Checked = True Or four_7.Checked = True Or five_7.Checked = True) And (one_8.Checked = True Or two_8.Checked = True Or three_8.Checked = True Or four_8.Checked = True Or five_8.Checked = True) Then
            NEXT_ARR.Enabled = True
            NEXT_ARR.Visible = True
        End If
    End Sub

    'infomation box
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        MessageBox.Show("Rate the following items with 1 - being the not likely && 5 - being the likely", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub




    'resets the scores when user chooses to go back
    Private Sub back_arr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_arr.Click
        S_T_EVALUATION2.Show()
        S_T_EVALUATION2.ABM = 0
        S_T_EVALUATION2.STEM = 0
        S_T_EVALUATION2.HUMMS = 0
        S_T_EVALUATION2.ANIMATION = 0
        S_T_EVALUATION2.PERFORMING_ARTS = 0
        S_T_EVALUATION2.FILM_PRODUCTION = 0
        S_T_EVALUATION2.SPORTS_COACHING = 0
        S_T_EVALUATION2.SPORTS_OFFICIATING = 0


        Hide()
    End Sub

    'poiting system begins
    Private Sub NEXT_ARR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEXT_ARR.Click
        If one_1.Checked = True Then
            HOTEL_REST += 0


        ElseIf two_1.Checked = True Then
            HOTEL_REST += 0


        ElseIf three_1.Checked = True Then
            HOTEL_REST += 1


        ElseIf four_1.Checked = True Then
            HOTEL_REST += 2


        ElseIf five_1.Checked = True Then
            HOTEL_REST += 3

        End If

        'Q2
        'poiting system begins
        If one_2.Checked = True Then
            Tourism += 0


        ElseIf two_2.Checked = True Then
            Tourism += 0


        ElseIf three_2.Checked = True Then
            Tourism += 1


        ElseIf four_2.Checked = True Then
            Tourism += 2


        ElseIf five_2.Checked = True Then
            Tourism += 3

        End If

        'Q3
        'poiting system begins
        If one_3.Checked = True Then
            FOOD += 0


        ElseIf two_3.Checked = True Then
            FOOD += 0


        ElseIf three_3.Checked = True Then
            FOOD += 1


        ElseIf four_3.Checked = True Then
            FOOD += 2


        ElseIf five_3.Checked = True Then
            FOOD += 3

        End If

        'Q4
        'poiting system begins
        If one_4.Checked = True Then
            HEALTH += 0


        ElseIf two_4.Checked = True Then
            HEALTH += 0


        ElseIf three_4.Checked = True Then
            HEALTH += 1


        ElseIf four_4.Checked = True Then
            HEALTH += 2


        ElseIf five_4.Checked = True Then
            HEALTH += 3

        End If

        'Q5
        'poiting system begins
        If one_5.Checked = True Then
            EMERGENCY += 0


        ElseIf two_5.Checked = True Then
            EMERGENCY += 0


        ElseIf three_5.Checked = True Then
            EMERGENCY += 1


        ElseIf four_5.Checked = True Then
            EMERGENCY += 2


        ElseIf five_5.Checked = True Then
            EMERGENCY += 3

        End If

        'Q6
        'poiting system begins
        If one_6.Checked = True Then
            PROGRAMMING += 0


        ElseIf two_6.Checked = True Then
            PROGRAMMING += 0


        ElseIf three_6.Checked = True Then
            PROGRAMMING += 1


        ElseIf four_6.Checked = True Then
            PROGRAMMING += 2


        ElseIf five_6.Checked = True Then
            PROGRAMMING += 3

        End If

        'Q7
        'poiting system begins
        If one_7.Checked = True Then
            SERVICING += 0


        ElseIf two_7.Checked = True Then
            SERVICING += 0


        ElseIf three_7.Checked = True Then
            SERVICING += 1


        ElseIf four_7.Checked = True Then
            SERVICING += 2


        ElseIf five_7.Checked = True Then
            SERVICING += 3

        End If

        'Q8
        'poiting system begins
        If one_8.Checked = True Then
            BPO += 0


        ElseIf two_8.Checked = True Then
            BPO += 0


        ElseIf three_8.Checked = True Then
            BPO += 1

        ElseIf four_8.Checked = True Then
            BPO += 2


        ElseIf five_8.Checked = True Then
            BPO += 3
        End If


        S_T_EVALUATION4.Show()
        Hide()
    End Sub




    Private Sub S_T_EVALUATION3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class