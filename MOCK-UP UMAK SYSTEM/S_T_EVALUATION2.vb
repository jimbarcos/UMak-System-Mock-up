Public Class S_T_EVALUATION2
    'POINTING SYSTEM
    ' SPORTS - LEVERAGE BY 5
    ' ACADEMIC - LEVERAGE 3
    ' ARTS - LEVERAGE  3
    ' TVL - LEVERAGE 2

    'Reason: Quantity of questions is in favor of TVL track since it has the most strand emebedded
    'SPORT has the least

    'validation for 1 processing only system of points
    Dim once_count As Integer = 0

    'variables that will be needed for the calculation
    Public ABM As Integer = 0
    Public STEM As Integer = 0
    Public HUMMS As Integer = 0

    Public ANIMATION As Integer = 0
    Public PERFORMING_ARTS As Integer = 0
    Public FILM_PRODUCTION As Integer = 0

    Public SPORTS_COACHING As Integer = 0
    Public SPORTS_OFFICIATING As Integer = 0

    'returns the user to the hsu iterface while deleting all the saved progress
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        If MessageBox.Show("All of your progress will be lost.." & vbNewLine & "CONTINUE?", "NOTIFICATION BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Hide()
            HSU_INTERFACE.Show()
            S_T_EVALUATION.Close()
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

        'validation for only once processing of scores
        If once_count = 0 Then
            five_1.Checked = False
            once_count += 1
        End If

        'checks if the radiobutton per number even once has been checked
        If (one_1.Checked = True Or two_1.Checked = True Or three_1.Checked = True Or four_1.Checked = True Or five_1.Checked = True) And (one_2.Checked = True Or two_2.Checked = True Or three_2.Checked = True Or four_2.Checked = True Or five_2.Checked = True) And (one_3.Checked = True Or two_3.Checked = True Or three_3.Checked = True Or four_3.Checked = True Or five_3.Checked = True) And (one_4.Checked = True Or two_4.Checked = True Or three_4.Checked = True Or four_4.Checked = True Or five_4.Checked = True) And (one_5.Checked = True Or two_5.Checked = True Or three_5.Checked = True Or four_5.Checked = True Or five_5.Checked = True) And (one_6.Checked = True Or two_6.Checked = True Or three_6.Checked = True Or four_6.Checked = True Or five_6.Checked = True) And (one_7.Checked = True Or two_7.Checked = True Or three_7.Checked = True Or four_7.Checked = True Or five_7.Checked = True) And (one_8.Checked = True Or two_8.Checked = True Or three_8.Checked = True Or four_8.Checked = True Or five_8.Checked = True) Then
            NEXT_ARR.Enabled = True
            NEXT_ARR.Visible = True
        End If
    End Sub

    'instruction that shows message box
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        MessageBox.Show("Rate the following items with 1 - being the not likely && 5 - being the likely", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'resets the score of when tried to go back
    Private Sub back_arr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_arr.Click
        S_T_EVALUATION.Show()
        Hide()
        S_T_EVALUATION.ACAD_score = 0
        S_T_EVALUATION.ARTS_score = 0
        S_T_EVALUATION.TVL_score = 0
        S_T_EVALUATION.SPORTS_score = 0
        S_T_EVALUATION.RESET.Enabled = True
    End Sub

    'pointing system for each radiobutton begins
    Private Sub NEXT_ARR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEXT_ARR.Click
        'Q1
        'pointing system for each radiobutton begins
        If one_1.Checked = True Then
            ABM += 3


        ElseIf two_1.Checked = True Then
            ABM += 6


        ElseIf three_1.Checked = True Then
            ABM += 9


        ElseIf four_1.Checked = True Then
            ABM += 12


        ElseIf five_1.Checked = True Then
            ABM += 15

        End If

        'Q2
        'pointing system for each radiobutton begins
        If one_2.Checked = True Then
            STEM += 3


        ElseIf two_2.Checked = True Then
            STEM += 6


        ElseIf three_2.Checked = True Then
            STEM += 9


        ElseIf four_2.Checked = True Then
            STEM += 12


        ElseIf five_2.Checked = True Then
            STEM += 15

        End If

        'Q3
        'pointing system for each radiobutton begins
        If one_3.Checked = True Then
            HUMMS += 3


        ElseIf two_3.Checked = True Then
            HUMMS += 6


        ElseIf three_3.Checked = True Then
            HUMMS += 9


        ElseIf four_3.Checked = True Then
            HUMMS += 12


        ElseIf five_3.Checked = True Then
            HUMMS += 15

        End If

        'Q4
        'pointing system for each radiobutton begins
        If one_4.Checked = True Then
            ANIMATION += 3


        ElseIf two_4.Checked = True Then
            ANIMATION += 6


        ElseIf three_4.Checked = True Then
            ANIMATION += 9


        ElseIf four_4.Checked = True Then
            ANIMATION += 12


        ElseIf five_4.Checked = True Then
            ANIMATION += 15

        End If

        'Q5
        'pointing system for each radiobutton begins
        If one_5.Checked = True Then
            PERFORMING_ARTS += 3


        ElseIf two_5.Checked = True Then
            PERFORMING_ARTS += 6


        ElseIf three_5.Checked = True Then
            PERFORMING_ARTS += 9


        ElseIf four_5.Checked = True Then
            PERFORMING_ARTS += 12


        ElseIf five_5.Checked = True Then
            PERFORMING_ARTS += 15

        End If

        'Q6
        'pointing system for each radiobutton begins
        If one_6.Checked = True Then
            FILM_PRODUCTION += 3


        ElseIf two_6.Checked = True Then
            FILM_PRODUCTION += 6


        ElseIf three_6.Checked = True Then
            FILM_PRODUCTION += 9


        ElseIf four_6.Checked = True Then
            FILM_PRODUCTION += 12


        ElseIf five_6.Checked = True Then
            FILM_PRODUCTION += 15

        End If

        'Q7
        'pointing system for each radiobutton begins
        If one_7.Checked = True Then
            SPORTS_COACHING += 3


        ElseIf two_7.Checked = True Then
            SPORTS_COACHING += 6


        ElseIf three_7.Checked = True Then
            SPORTS_COACHING += 9


        ElseIf four_7.Checked = True Then
            SPORTS_COACHING += 14


        ElseIf five_7.Checked = True Then
            SPORTS_COACHING += 18

        End If

        'Q8
        'pointing system for each radiobutton begins
        If one_8.Checked = True Then
            SPORTS_OFFICIATING += 3


        ElseIf two_8.Checked = True Then
            SPORTS_OFFICIATING += 6


        ElseIf three_8.Checked = True Then
            SPORTS_OFFICIATING += 9

        ElseIf four_8.Checked = True Then
            SPORTS_OFFICIATING += 14


        ElseIf five_8.Checked = True Then
            SPORTS_OFFICIATING += 18
        End If



        S_T_EVALUATION3.Show()
        Hide()
    End Sub




    Private Sub S_T_EVALUATION2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class