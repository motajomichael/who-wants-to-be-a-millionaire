Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Me.Hide()
            Form4.Show()
            

        ElseIf RadioButton2.Checked Then
            Application.Exit()
        Else : MsgBox("You need to Agree or Disagree", vbOKOnly)

        End If
    End Sub
End Class