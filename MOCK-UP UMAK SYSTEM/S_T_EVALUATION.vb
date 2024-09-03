Public Class S_T_EVALUATION

    'POINTING SYSTEM
    ' SPORTS - LEVERAGE BY 5
    ' ACADEMIC - LEVERAGE 3
    ' ARTS - LEVERAGE  3
    ' TVL - LEVERAGE 2

    'Reason: Quantity of questions is in favor of TVL track since it has the most strand emebedded
    'SPORT has the least




    Dim count As Integer = 0
    Dim ans_count As Integer = 0

    Public TVL_score As Integer = 0
    Public ACAD_score As Integer = 0
    Public SPORTS_score As Integer = 0
    Public ARTS_score As Integer = 0

    'returns to hsu interface when back btn is clicked
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        If MessageBox.Show("All of your progress will be lost.." & vbNewLine & "CONTINUE?", "NOTIFICATION BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Hide()
            HSU_INTERFACE.Show()
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

        'notification box for the user
        If count = 0 Then
            YES1.Checked = False
            count += 1
            MessageBox.Show("This Evaluation should not be taken seriously." & vbNewLine & "--------------------------------------------------------------------------------" & vbNewLine & "It is the Respondent's final decision and passion that will matter the most, as they know what they want for themselves.", "QUICK REMINDER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'refreshes the textbox enability to accept input
        If RATING_CB.Checked = True Then
            FIL.Enabled = False
            ENG.Enabled = False
            SCI.Enabled = False
            MATH.Enabled = False
            AVE.Enabled = False
        Else
            FIL.Enabled = True
            ENG.Enabled = True
            SCI.Enabled = True
            MATH.Enabled = True
            AVE.Enabled = True
        End If

        'refreshes the textbox enability to accept input
        If RATING_NCAE.Checked = True Then
            ACAD.Enabled = False
            SPORT.Enabled = False
            ARTS.Enabled = False
            TVL.Enabled = False
        Else
            ACAD.Enabled = True
            SPORT.Enabled = True
            ARTS.Enabled = True
            TVL.Enabled = True
        End If

        'validates if the radiobutton even once for every number has been checked, will show the next arrow if condition has been met
        If (YES1.Checked = True Or NO1.Checked = True) And (YES2.Checked = True Or NO2.Checked = True) And (YES3.Checked = True Or NO3.Checked = True) And (YES4.Checked = True Or NO4.Checked = True) And (YES5.Checked = True Or NO5.Checked = True) And (YES6.Checked = True Or NO6.Checked = True) And (YES7.Checked = True Or NO7.Checked = True) And (YES8.Checked = True Or NO8.Checked = True) Then
            NEXT_ARR.Visible = True
            NEXT_ARR.Enabled = True
        End If

    End Sub

  
    'validates all the input made by the user
    Private Sub NEXT_ARR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NEXT_ARR.Click

        'if they don't check the rating, they will be subjected to these validations; number limit
        If RATING_CB.Checked = False Then
            If FIL.Text = Nothing Or SCI.Text = Nothing Or MATH.Text = Nothing Or ENG.Text = Nothing Or AVE.Text = Nothing Then
                MessageBox.Show("Please fill-out the necessary informations in the ACADEMIC PERFORMANCE", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Val(FIL.Text) < 75 Or Val(ENG.Text) < 75 Or Val(SCI.Text) < 75 Or Val(MATH.Text) < 75 Or Val(AVE.Text) < 75 Then
                MessageBox.Show("75 is the lowest valid grade accepted in the ACADEMIC PERFORMANCE", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Val(FIL.Text) > 100 Or Val(ENG.Text) > 100 Or Val(SCI.Text) > 100 Or Val(MATH.Text) > 100 Or Val(AVE.Text) > 100 Then
                MessageBox.Show("100 is the highest valid grade accepted in the ACADEMIC PERFORMANCE", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        End If


        'if they don't check the rating, they will be subjected to these validations; number limit
        If RATING_NCAE.Checked = False Then
            If ACAD.Text = Nothing Or TVL.Text = Nothing Or ARTS.Text = Nothing Or SPORT.Text = Nothing Then
                MessageBox.Show("Please fill-out the necessary informations in the NCAE RESULTS", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Val(ACAD.Text) < 75 Or Val(TVL.Text) < 75 Or Val(ARTS.Text) < 75 Or Val(SPORT.Text) < 75 Then
                MessageBox.Show("75 is the lowest valid grade accepted in the NCAE RESULTS", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Val(ACAD.Text) > 99 Or Val(TVL.Text) > 99 Or Val(ARTS.Text) > 99 Or Val(SPORT.Text) > 99 Then
                MessageBox.Show("99 is the highest valid grade accepted in the NCAE RESULTS", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If


        'pointing system begins
        If YES1.Checked = True Then
            ACAD_score += 3
            ARTS_score += 2
            TVL_score += 2
        ElseIf NO1.Checked = True Then
            TVL_score += 3
            SPORTS_score += 2
        End If

        If YES2.Checked = True Then
            ACAD_score += 2
            TVL_score += 3
        ElseIf NO2.Checked = True Then
            SPORTS_score += 2
            ARTS_score = 2
        End If

        If YES3.Checked = True Then
            ACAD_score += 2
            TVL_score += 3
        End If

        If YES4.Checked = True Then
            TVL_score += 1
        End If

        If YES5.Checked = True Then
            TVL_score += 1
            ACAD_score += 3
            ARTS_score += 2
            SPORTS_score += 2
        End If

        If YES6.Checked = True Then
            ACAD_score += 2
        End If

        If YES7.Checked = True Then
            ARTS_score += 5
        End If

        If YES8.Checked = True Then
            SPORTS_score += 3
        End If

        'pointing system begins for the textbox of academic performance
        If RATING_CB.Checked = False Then
            If Val(FIL.Text) >= 85 Then
                TVL_score += 1
                ACAD_score += 2
                ARTS_score += 1
                SPORTS_score += 1
            End If

            If Val(SCI.Text) >= 85 Then
                TVL_score += 1
                ACAD_score += 2
                ARTS_score += 1
                SPORTS_score += 1
            End If

            If Val(MATH.Text) >= 85 Then
                TVL_score += 1
                ACAD_score += 2
                ARTS_score += 1
                SPORTS_score += 1
            End If

            If Val(AVE.Text) >= 85 Then
                TVL_score += 1
                ACAD_score += 2
                ARTS_score += 1
                SPORTS_score += 1
            End If

            If Val(ENG.Text) >= 85 Then
                TVL_score += 1
                ACAD_score += 2
                ARTS_score += 1
                SPORTS_score += 1
            End If
        End If

        
        'pointing system begins for the NCAE textbox
        If RATING_NCAE.Checked = False Then
            ACAD_score += Val(ACAD.Text) / 10
            TVL_score += Val(TVL.Text) / 10
            SPORTS_score += Val(SPORT.Text) / 10
            ARTS_score += Val(ARTS.Text) / 10
        End If

        'totals the scoring
        LBL_ACAD.Text = Val(ACAD_score)
        LBL_SPORTS.Text = Val(SPORTS_score)
        LBL_ARTS.Text = Val(ARTS_score)
        LBL_TVL.Text = Val(TVL_score)


        'redirects to the part 2 of the evaluation
        S_T_EVALUATION2.Show()
        Hide()



    End Sub

    'insturction logo when clicked will show notification
    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        MessageBox.Show("The respondent shall answer some yes/no questions that may reflect their wanted strand/track" & vbNewLine & "They can also provide their academic rating and NCAE Results, all data will be confidentially treated", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'character filtration, only accepts numbers
    Private Sub FIL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FIL.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub
    'character filtration, only accepts numbers
    Private Sub ENG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ENG.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub
    'character filtration, only accepts numbers
    Private Sub AVE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AVE.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub
    'character filtration, only accepts numbers
    Private Sub MATH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MATH.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub
    'character filtration, only accepts numbers
    Private Sub SCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SCI.KeyPress
       If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub
    'character filtration, only accepts numbers
    Private Sub ACAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ACAD.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub
    'character filtration, only accepts numbers
    Private Sub TVL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TVL.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub
    'character filtration, only accepts numbers
    Private Sub SPORT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SPORT.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub
    'character filtration, only accepts numbers
    Private Sub ARTS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ARTS.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or Asc(e.KeyChar) = 8) Then
            e.KeyChar = Nothing
        End If
    End Sub


    'if the user goes back to the form to change something, the tallied score will be reset
    Private Sub RESET_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESET.Tick
        ACAD_score = 0
        TVL_score = 0
        SPORTS_score = 0
        ARTS_score = 0
        RESET.Enabled = False
    End Sub


    Private Sub S_T_EVALUATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ACAD_TextChanged(sender As System.Object, e As System.EventArgs) Handles ACAD.TextChanged

    End Sub
End Class