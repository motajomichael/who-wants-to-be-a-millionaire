Public Class Form4


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("You need an alias", vbOKOnly)
        Else : Me.Hide()
            Form3.Show()
            Form3.RadioButton1.Checked = False
            Form3.RadioButton2.Checked = False
            Form3.RadioButton3.Checked = False
            Form3.RadioButton4.Checked = False
        End If
        

    End Sub

    
End Class