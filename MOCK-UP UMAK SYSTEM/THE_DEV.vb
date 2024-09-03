Public Class THE_DEV
    ' Shows the developers name
    
    

    Private Sub BACK_BTN_Click_1(sender As System.Object, e As System.EventArgs) Handles BACK_BTN.Click
        Hide()
        MAIN_FORM.Show()

        'resets the textbox to clear and focus
        Hide()
        MAIN_FORM.username_tb.Clear()
        MAIN_FORM.password_tb.Clear()
        MAIN_FORM.INFO.Visible = False
        MAIN_FORM.Show()
        MAIN_FORM.username_tb_MouseClick()
        Close()
    End Sub
End Class