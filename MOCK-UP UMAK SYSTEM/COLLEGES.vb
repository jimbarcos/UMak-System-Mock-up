Public Class COLLEGES
    'MAIN FORM is the Parent Form

    'Programs to back out the current form and go back to MAIN INTERFACE FORM
    Private Sub BACK_BTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK_BTN.Click
        MAIN_INTERFACE.Show()
        Close()
    End Sub

    'Programs to exit the program
    Private Sub OFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OFF.Click
        If MessageBox.Show("Close the Application?", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MAIN_FORM.Close()
        End If
    End Sub

   
    'The combo box that has the collection of all colleges will not accept any key characters input
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.KeyChar = Nothing
    End Sub

    'when their respective text matched, the picture box and rich text box will match correspondingly to the college
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        'for COAHS
        If ComboBox1.Text = "College of Allied Health Studies (COAHS)" Then
            PictureBox2.BringToFront()
            RichTextBox1.BringToFront()
        End If

        'for CAL
        If ComboBox1.Text = "College of Arts and Letters (CAL)" Then
            PictureBox3.BringToFront()
            RichTextBox2.BringToFront()
        End If

        'for CBFS
        If ComboBox1.Text = "College of Business and Finance Science (CBFS)" Then
            PictureBox4.BringToFront()
            RichTextBox3.BringToFront()
        End If

        'for CCS
        If ComboBox1.Text = "College of Computer Science (CCS)" Then
            PictureBox5.BringToFront()
            RichTextBox4.BringToFront()
        End If

        'for CCSE
        If ComboBox1.Text = "College of Construction Sciences and Engineering (CCSE)" Then
            PictureBox6.BringToFront()
            RichTextBox5.BringToFront()
        End If

        'for COE
        If ComboBox1.Text = "College of Education (COE)" Then
            PictureBox7.BringToFront()
            RichTextBox6.BringToFront()
        End If

        'for CGPP
        If ComboBox1.Text = "College of Governance and Public Policy (CGPP)" Then
            PictureBox8.BringToFront()
            RichTextBox7.BringToFront()
        End If

        'for CMLI
        If ComboBox1.Text = "College of Maritime Leadership Innovation (CMLI)" Then
            PictureBox9.BringToFront()
            RichTextBox8.BringToFront()
        End If

        'for COS
        If ComboBox1.Text = "College of Science (COS)" Then
            PictureBox10.BringToFront()
            RichTextBox9.BringToFront()
        End If

        'for CTM
        If ComboBox1.Text = "College of Technology Management (CTM)" Then
            PictureBox11.BringToFront()
            RichTextBox10.BringToFront()
        End If

        'for CTHM
        If ComboBox1.Text = "College of Tourism and Hospitality Management (CTHM)" Then
            PictureBox12.BringToFront()
            RichTextBox11.BringToFront()
        End If

        'for CHK
        If ComboBox1.Text = "Center for Human Kinesthetics (CHK)" Then
            PictureBox13.BringToFront()
            RichTextBox12.BringToFront()
        End If

        'for SOL
        If ComboBox1.Text = "School of Law (SOL)" Then
            PictureBox14.BringToFront()
            RichTextBox13.BringToFront()
        End If

        'for CCAPS
        If ComboBox1.Text = "College of Continuing Advanced and Professional Studies (CCAPS)" Then
            PictureBox15.BringToFront()
            RichTextBox14.BringToFront()
        End If

        ' the border in those logo wwill bve prioritze to be in front
        BORDER1.BringToFront()
        BORDER2.BringToFront()
        BORDER3.BringToFront()
        BORDER4.BringToFront()
        PictureBox14_Click()

    End Sub

    'Renders the COAHS to be the default - first one to display once the form loaded
    Private Sub COLLEGES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox2.BringToFront()
        RichTextBox1.BringToFront()

        BORDER1.BringToFront()
        BORDER2.BringToFront()
        BORDER3.BringToFront()
        BORDER4.BringToFront()
    End Sub

 
    'Bring focus to the SOL Picture, due to it being bugged out when bring to front
    Private Sub PictureBox14_Click() Handles PictureBox14.Click
        PictureBox14.Focus()
    End Sub

   
    'Dsipalys the time and date
    Private Sub SYS_D_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYS_D_T.Tick
        DTE.Text = Today.DayOfWeek.ToString & ", " & Today.ToString("MMMM ") & Today.ToString("dd, ") & Today.Year
        TME.Text = TimeOfDay
    End Sub

  

End Class