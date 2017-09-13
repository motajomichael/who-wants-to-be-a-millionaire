Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Hide()
        Form2.Show()
        Form2.RadioButton1.Checked = False
        Form2.RadioButton2.Checked = False
        Form3.Close()
        Form4.Close()
    End Sub

End Class
