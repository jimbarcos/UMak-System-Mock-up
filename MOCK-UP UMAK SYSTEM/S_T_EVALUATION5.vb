Public Class S_T_EVALUATION5
    'POINTING SYSTEM
    ' SPORTS - LEVERAGE BY 5
    ' ACADEMIC - LEVERAGE 3
    ' ARTS - LEVERAGE  3
    ' TVL - LEVERAGE 2

    'Reason: Quantity of questions is in favor of TVL track since it has the most strand emebedded
    'SPORT has the least

    'Main form is the parent form

    'for the combination scores within TVL track
    Dim HES As Integer = 0
    Dim ICTS As Integer = 0
    Dim IAS As Integer = 0

    'returns the user to the hsu interface and deltes their saved progress
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        If MessageBox.Show("All of your progress will be lost.." & vbNewLine & "CONTINUE?", "NOTIFICATION BOX", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Hide()
            HSU_INTERFACE.Show()
            S_T_EVALUATION.Close()
            S_T_EVALUATION2.Close()
            S_T_EVALUATION3.Close()
            S_T_EVALUATION4.Close()
            Close()
        End If
    End Sub

    'closes the program
    Private Sub OFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFF.Click
        If MessageBox.Show("Close the Application?", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MAIN_FORM.Close()
        End If
    End Sub


    

    'shen the form loaded, it will start calculating the scores
    Private Sub S_T_EVALUATION5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'combines the scores gathered for mathematical processing of scores

        HES += Val(S_T_EVALUATION3.HOTEL_REST) + Val(S_T_EVALUATION3.Tourism) + Val(S_T_EVALUATION3.FOOD) + Val(S_T_EVALUATION3.HEALTH) + Val(S_T_EVALUATION3.EMERGENCY)
        ICTS += Val(S_T_EVALUATION3.PROGRAMMING) + Val(S_T_EVALUATION3.SERVICING) + Val(S_T_EVALUATION3.BPO)
        IAS += Val(S_T_EVALUATION4.DRAFTING) + Val(S_T_EVALUATION4.AUTOMOTIVE) + Val(S_T_EVALUATION4.ASSEMBLY) + Val(S_T_EVALUATION4.MAINTENANCE) + Val(S_T_EVALUATION4.CONSTRUCTION) + +Val(S_T_EVALUATION4.WELDING)

        'when scores of strand match within the other, there will be an equally incrementation of scores
        If S_T_EVALUATION.ACAD_score = S_T_EVALUATION.ARTS_score Or S_T_EVALUATION.ACAD_score = S_T_EVALUATION.TVL_score Or S_T_EVALUATION.ACAD_score = S_T_EVALUATION.SPORTS_score Then
            S_T_EVALUATION.ACAD_score += 1
        End If


        'when scores of strand match within the other, there will be an equally incrementation of scores
        If S_T_EVALUATION.ARTS_score = S_T_EVALUATION.TVL_score Or S_T_EVALUATION.ARTS_score = S_T_EVALUATION.SPORTS_score Then
            S_T_EVALUATION.ARTS_score += 1
        End If

        'when scores of strand match within the other, there will be an equally incrementation of scores
        If S_T_EVALUATION.TVL_score = S_T_EVALUATION.SPORTS_score Then
            S_T_EVALUATION.TVL_score += 1
        End If


        'Processes whthere the academic track has the highest points gathered
        If S_T_EVALUATION.ACAD_score > S_T_EVALUATION.ARTS_score And S_T_EVALUATION.ACAD_score > S_T_EVALUATION.TVL_score And S_T_EVALUATION.ACAD_score > S_T_EVALUATION.SPORTS_score Then
            Label5.Text = "Suggestion: Academic Track"

            'When validated to be the highestscore, it will then check what strand has the most highest points

            If S_T_EVALUATION2.ABM > S_T_EVALUATION2.STEM And S_T_EVALUATION2.ABM > S_T_EVALUATION2.HUMMS Then
                Label7.Text = "Accountancy, Business, and Management Strand"
                S_T_EVALUATION2.ABM += 1
            ElseIf S_T_EVALUATION2.ABM = S_T_EVALUATION2.STEM Then
                Label7.Text = "Accountancy, Business, and Management Strand"
                S_T_EVALUATION2.ABM += 1
            ElseIf S_T_EVALUATION2.ABM = S_T_EVALUATION2.HUMMS Then
                Label7.Text = "Humanities and Social Science Strand"
                S_T_EVALUATION2.HUMMS += 1
            ElseIf S_T_EVALUATION2.STEM = S_T_EVALUATION2.HUMMS Then
                Label7.Text = "Humanities and Social Science Strand"
                S_T_EVALUATION2.HUMMS += 1
            End If

            If S_T_EVALUATION2.STEM > S_T_EVALUATION2.ABM And S_T_EVALUATION2.STEM > S_T_EVALUATION2.HUMMS Then
                Label7.Text = "Science, Technology, Engineering and Mathematics Strand"

            End If

            If S_T_EVALUATION2.HUMMS > S_T_EVALUATION2.ABM And S_T_EVALUATION2.HUMMS > S_T_EVALUATION2.STEM Then
                Label7.Text = "Humanities and Social Science Strand"

            End If

            'When validated to be the highestscore, it will then check what strand has the most highest points
            'Processes whthere the arts and design track has the highest points gathered
        ElseIf S_T_EVALUATION.ARTS_score > S_T_EVALUATION.ACAD_score And S_T_EVALUATION.ARTS_score > S_T_EVALUATION.TVL_score And S_T_EVALUATION.ARTS_score > S_T_EVALUATION.SPORTS_score Then
            Label5.Text = "Suggestion: Arts && Design Track"

            If S_T_EVALUATION2.ANIMATION > S_T_EVALUATION2.FILM_PRODUCTION And S_T_EVALUATION2.ANIMATION > S_T_EVALUATION2.PERFORMING_ARTS Then
                Label7.Text = "Animation"
            ElseIf S_T_EVALUATION2.ANIMATION = S_T_EVALUATION2.FILM_PRODUCTION Then
                Label7.Text = "Aimation"
                S_T_EVALUATION2.ANIMATION += 1

            ElseIf S_T_EVALUATION2.FILM_PRODUCTION = S_T_EVALUATION2.PERFORMING_ARTS Then
                Label7.Text = "Film Production"
                S_T_EVALUATION2.FILM_PRODUCTION += 1

            ElseIf S_T_EVALUATION2.PERFORMING_ARTS = S_T_EVALUATION2.ANIMATION Then
                Label7.Text = "Performing Arts"
                S_T_EVALUATION2.PERFORMING_ARTS += 1
            End If

            If S_T_EVALUATION2.FILM_PRODUCTION > S_T_EVALUATION2.ANIMATION And S_T_EVALUATION2.FILM_PRODUCTION > S_T_EVALUATION2.PERFORMING_ARTS Then
                Label7.Text = "Film Production"

            End If

            If S_T_EVALUATION2.PERFORMING_ARTS > S_T_EVALUATION2.FILM_PRODUCTION And S_T_EVALUATION2.PERFORMING_ARTS > S_T_EVALUATION2.ANIMATION Then
                Label7.Text = "Performing Arts"

            End If

        ElseIf S_T_EVALUATION.TVL_score > S_T_EVALUATION.ACAD_score And S_T_EVALUATION.TVL_score > S_T_EVALUATION.ARTS_score And S_T_EVALUATION.TVL_score > S_T_EVALUATION.SPORTS_score Then
            Label5.Text = "Suggestion: TVL Track"

            'When validated to be the highestscore, it will then check what strand has the most highest points
            If HES > ICTS And HES > IAS Then
                Label7.Text = "Home Economics Strand"
            ElseIf HES = ICTS Then
                Label7.Text = "Information and Communications Technology Strand"
                ICTS += 1
            ElseIf ICTS = IAS Then
                Label7.Text = "Industrial Arts Strand"
                IAS += 1
            ElseIf IAS = HES Then
                Label7.Text = "Home Economics Strand"
                HES += 1
            End If

            If ICTS > HES And ICTS > IAS Then
                Label7.Text = "Information and Communications Technology Strand"

            End If

            If IAS > HES And IAS > ICTS Then
                Label7.Text = "Industrial Arts Strand"

            End If

            'When validated to be the highestscore, it will then check what strand has the most highest points
        ElseIf S_T_EVALUATION.SPORTS_score > S_T_EVALUATION.ACAD_score And S_T_EVALUATION.SPORTS_score > S_T_EVALUATION.TVL_score And S_T_EVALUATION.SPORTS_score > S_T_EVALUATION.ARTS_score Then
            Label5.Text = "Suggestion: Sports Track"

            If S_T_EVALUATION2.SPORTS_COACHING > S_T_EVALUATION2.SPORTS_OFFICIATING Then
                Label7.Text = "Sports Coaching"

            ElseIf S_T_EVALUATION2.SPORTS_COACHING < S_T_EVALUATION2.SPORTS_OFFICIATING Then
                Label7.Text = "Sports Officiating"

            ElseIf S_T_EVALUATION2.SPORTS_COACHING = S_T_EVALUATION2.SPORTS_OFFICIATING Then
                Label7.Text = "Sports Coaching"
                S_T_EVALUATION2.SPORTS_COACHING += 1
            End If
        End If

        'DISPLAYS THE INFORMATION TO THE LABELS
        ACAD_TRACK_LBL.Text = S_T_EVALUATION.ACAD_score
        ARTS_TRACK_LBL.Text = S_T_EVALUATION.ARTS_score
        SPORTS_TRACK_LBL.Text = S_T_EVALUATION.SPORTS_score
        TVL_TRACK_LBL.Text = S_T_EVALUATION.TVL_score

        HUMMS_STRAND_LBL.Text = S_T_EVALUATION2.HUMMS
        STEM_STRAND_LBL.Text = S_T_EVALUATION2.STEM
        ABM_STRAND_LBL.Text = S_T_EVALUATION2.ABM

        PERFORMING_STRAND_LBL.Text = S_T_EVALUATION2.PERFORMING_ARTS
        ANIMATION_STRAND_LBL.Text = S_T_EVALUATION2.ANIMATION
        FILM_STRAND_LBL.Text = S_T_EVALUATION2.FILM_PRODUCTION

        OFFICIATING_STRAND_LBL.Text = S_T_EVALUATION2.SPORTS_OFFICIATING
        COACHING_STRAND_LBL.Text = S_T_EVALUATION2.SPORTS_COACHING

        HOME_STRAND_LBL.Text = HES
        ICT_STRAND_LBL.Text = ICTS
        INDUSTRIAL_STRAND_LBL.Text = IAS


    End Sub


    'informs the user of the following message
    Public Sub PictureBox6_Click() Handles PictureBox6.Click
        MessageBox.Show("Points accumulated on the evaluation from the respondent's choice are shown." & vbNewLine & "The test may not accurately display the respondent's favoured strand or track." & vbNewLine & "--------------------------------------------------------------------------------" & vbNewLine & "Don't take the results seriously, the final decision is still in yours.", "NOTIFICATION BOX", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    
End Class