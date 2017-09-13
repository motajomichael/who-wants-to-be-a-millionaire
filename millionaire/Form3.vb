Public Class Form3
    Dim answer As String
    Dim q1 As String = "Q1. Which of these is the name of a British Football Club?"
    Dim q2 As String = "Q2. An establishment where money can be deposited or withdrawn is called what?"
    Dim q3 As String = "Q3. Name given to a boy born on Sunday in Ghana is what?"
    Dim q4 As String = "Q4. Which of the following refer to the word fire?"
    Dim q5 As String = "Q5. According to the constitution a public officer is not allowed to do which of these?"
    Dim q6 As String = "Q6. The process by which genetic traits are transmitted from parents to offspring is called what?"
    Dim q7 As String = "Q7. Roland Garros stadium is in which city?"
    Dim q8 As String = "Q8. Where is Tiananmen Square?"
    Dim q9 As String = "Q9. The word supersonic denotes which of these?"
    Dim q10 As String = "Q10. Which of these holds bones together at the joints of the body?"
    Dim q11 As String = "Q11. Linus Mbah achieved fame in Nigerian sporting circles as what?"
    Dim q12 As String = "Q12. DAX refers to the stock market of which country?"
    Dim q13 As String = "Q13. Who won the Academy Award for directing the movie ‘Million Dollar Baby’?"
    Dim q14 As String = "Q14. In which country is the Galeras Volcano?"
    Dim q15 As String = "Q15. Professor Maathai Wangari won the Nobel Prize for which of these?"
    Dim amt1 As Integer = 50
    Dim amt2 As Integer = 100
    Dim amt3 As Integer = 200
    Dim amt4 As Integer = 500
    Dim amt5 As Integer = 1000
    Dim amt6 As Integer = 2000
    Dim amt7 As Integer = 4000
    Dim amt8 As Integer = 8000
    Dim amt9 As Integer = 16000
    Dim amt10 As Integer = 32000
    Dim amt11 As Integer = 64000
    Dim amt12 As Integer = 128000
    Dim amt13 As Integer = 250000
    Dim amt14 As Integer = 500000
    Dim amt15 As Integer = 1000000
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        quest1int()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = q1 Then
            quest1()
        ElseIf TextBox1.Text = q2 Then
            quest2()
        ElseIf TextBox1.Text = q3 Then
            quest3()
        ElseIf TextBox1.Text = q4 Then
            quest4()
        ElseIf TextBox1.Text = q5 Then
            quest5()
        ElseIf TextBox1.Text = q6 Then
            quest6()
        ElseIf TextBox1.Text = q7 Then
            quest7()
        ElseIf TextBox1.Text = q8 Then
            quest8()
        ElseIf TextBox1.Text = q9 Then
            quest9()
        ElseIf TextBox1.Text = q10 Then
            quest10()
        ElseIf TextBox1.Text = q11 Then
            quest11()
        ElseIf TextBox1.Text = q12 Then
            quest12()
        ElseIf TextBox1.Text = q13 Then
            quest13()
        ElseIf TextBox1.Text = q14 Then
            quest14()
        ElseIf TextBox1.Text = q15 Then
            quest15()
        End If
    End Sub

    Function quest1int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q1
        TextBox2.Text = amt1
        TextBox3.Text = 0
        Label3.Text = "You are playing as " & Form4.TextBox1.Text
        RadioButton1.Text = "A. Blackburn Rovers"
        RadioButton2.Text = "B. Blackburn Losers"
        RadioButton3.Text = "C. Blackburn Lovers"
        RadioButton4.Text = "D. Blackburn Wanderers"
    End Function
    Function quest2int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q2
        TextBox2.Text = amt2
        TextBox3.Text = amt1
        RadioButton1.Text = "A. Fridge"
        RadioButton2.Text = "B. Market"
        RadioButton3.Text = "C. Bank"
        RadioButton4.Text = "D. Shoe"
    End Function
    Function quest3int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q3
        TextBox2.Text = amt3
        TextBox3.Text = amt2
        RadioButton1.Text = "A. Bassey"
        RadioButton2.Text = "B. Kwesi"
        RadioButton3.Text = "C. Abiodun"
        RadioButton4.Text = "D. Ejima"
    End Function
    Function quest4int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q4
        TextBox2.Text = amt4
        TextBox3.Text = amt3
        RadioButton1.Text = "A. Inferno"
        RadioButton2.Text = "B. Domino"
        RadioButton3.Text = "C. Stiletto"
        RadioButton4.Text = "D. Tornado"
    End Function
    Function quest5int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q5
        TextBox2.Text = amt5
        TextBox3.Text = amt4
        RadioButton1.Text = "A. Marry a wife"
        RadioButton2.Text = "B. Bury a dead parent"
        RadioButton3.Text = "C. Accept gifts or favour in kind"
        RadioButton4.Text = "D. Have thanksgiving in church"
    End Function
    Function quest6int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q6
        TextBox2.Text = amt6
        TextBox3.Text = amt5
        RadioButton1.Text = "A. Hereditary"
        RadioButton2.Text = "B. Verifiability"
        RadioButton3.Text = "C. Tenacity"
        RadioButton4.Text = "D. Validation"
    End Function
    Function quest7int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q7
        TextBox2.Text = amt7
        TextBox3.Text = amt6
        RadioButton1.Text = "A. Madrid"
        RadioButton2.Text = "B. Copenhagen"
        RadioButton3.Text = "C. New York"
        RadioButton4.Text = "D. Paris"
    End Function
    Function quest8int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q8
        TextBox2.Text = amt8
        TextBox3.Text = amt7
        RadioButton1.Text = "A. Mumbai"
        RadioButton2.Text = "B. Beijing"
        RadioButton3.Text = "C. Rio de Janeiro"
        RadioButton4.Text = "D. Seville"
    End Function
    Function quest9int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q9
        TextBox2.Text = amt9
        TextBox3.Text = amt8
        RadioButton1.Text = "A. A speed equal to that of sound"
        RadioButton2.Text = "B. A speed equal to that of light"
        RadioButton3.Text = "C. A speed greater than that of sound"
        RadioButton4.Text = "D. A speed greater than that of light"
    End Function
    Function quest10int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q10
        TextBox2.Text = amt10
        TextBox3.Text = amt9
        RadioButton1.Text = "A. Ligaments"
        RadioButton2.Text = "B. Nerves"
        RadioButton3.Text = "C. Nephrons"
        RadioButton4.Text = "D. Stitches"
    End Function
    Function quest11int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q11
        TextBox2.Text = amt11
        TextBox3.Text = amt10
        RadioButton1.Text = "A. Swimmer"
        RadioButton2.Text = "B. Referee"
        RadioButton3.Text = "C. Football Fan"
        RadioButton4.Text = "D. Judoka"
    End Function
    Function quest12int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q12
        TextBox2.Text = amt12
        TextBox3.Text = amt11
        RadioButton1.Text = "A. France"
        RadioButton2.Text = "B. United States"
        RadioButton3.Text = "C. Germany"
        RadioButton4.Text = "D. India"
    End Function
    Function quest13int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q13
        TextBox2.Text = amt13
        TextBox3.Text = amt12
        RadioButton1.Text = "A. Clint Eastwood"
        RadioButton2.Text = "B. Oliver Stone"
        RadioButton3.Text = "C. Peter Jackson"
        RadioButton4.Text = "D. Morgan Freeman"
    End Function
    Function quest14int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q14
        TextBox2.Text = amt14
        TextBox3.Text = amt13
        RadioButton1.Text = "A. Lebanon"
        RadioButton2.Text = "B. Eritrea"
        RadioButton3.Text = "C. Japan"
        RadioButton4.Text = "D. Columbia"
    End Function
    Function quest15int() As String
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True
        TextBox1.Text = q15
        TextBox2.Text = amt15
        TextBox3.Text = amt14
        RadioButton1.Text = "A. Literature"
        RadioButton2.Text = "B. Economics"
        RadioButton3.Text = "C. Peace"
        RadioButton4.Text = "D. Medicine"
    End Function
    Function quest1() As Integer
        If RadioButton1.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            quest2int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()
        End If
    End Function
    Function quest2() As Integer
        If RadioButton3.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest3int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest3() As Integer
        If RadioButton2.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest4int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest4() As Integer
        If RadioButton1.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest5int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest5() As Integer
        If RadioButton3.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest6int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest6() As Integer
        If RadioButton1.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest7int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If

    End Function
    Function quest7() As Integer
        If RadioButton4.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest8int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest8() As Integer
        If RadioButton2.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest9int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest9() As Integer
        If RadioButton3.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest10int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest10() As Integer
        If RadioButton1.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest11int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest11() As Integer
        If RadioButton2.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest12int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest12() As Integer
        If RadioButton3.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest13int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest13() As Integer
        If RadioButton1.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest14int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest14() As Integer
        If RadioButton4.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest15int()
        ElseIf RadioButton1.Checked = False And
        RadioButton2.Checked = False And
        RadioButton3.Checked = False And
        RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function quest15() As Integer
        If RadioButton3.Checked = True Then
            MsgBox("CORRECT!!! YOU JUST WON " & TextBox2.Text & " DOLLARS", vbOKOnly)
            Call quest1int()
        ElseIf RadioButton1.Checked = False And
            RadioButton2.Checked = False And
            RadioButton3.Checked = False And
            RadioButton4.Checked = False Then
            MsgBox("please select an answer", vbOKOnly)
        Else : wrong()


        End If
    End Function
    Function wrong() As String
        If TextBox1.Text = q1 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q2 Then
            answer = RadioButton3.Text
        ElseIf TextBox1.Text = q3 Then
            answer = RadioButton2.Text
        ElseIf TextBox1.Text = q4 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q5 Then
            answer = RadioButton3.Text
        ElseIf TextBox1.Text = q6 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q7 Then
            answer = RadioButton4.Text
        ElseIf TextBox1.Text = q8 Then
            answer = RadioButton2.Text
        ElseIf TextBox1.Text = q9 Then
            answer = RadioButton3.Text
        ElseIf TextBox1.Text = q10 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q11 Then
            answer = RadioButton2.Text
        ElseIf TextBox1.Text = q12 Then
            answer = RadioButton3.Text
        ElseIf TextBox1.Text = q13 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q14 Then
            answer = RadioButton4.Text
        ElseIf TextBox1.Text = q15 Then
            answer = RadioButton3.Text
        End If
        If MsgBox("WRONG ANSWER" & vbNewLine & "THE RIGHT ANSWER WAS " & answer & vbNewLine & "Play again?", vbYesNo) = vbYes Then
            Me.Close()
            Form1.Show()
        Else : Application.Exit()
        End If
    End Function
    Function walkaway() As String
        If TextBox1.Text = q1 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q2 Then
            answer = RadioButton3.Text
        ElseIf TextBox1.Text = q3 Then
            answer = RadioButton2.Text
        ElseIf TextBox1.Text = q4 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q5 Then
            answer = RadioButton3.Text
        ElseIf TextBox1.Text = q6 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q7 Then
            answer = RadioButton4.Text
        ElseIf TextBox1.Text = q8 Then
            answer = RadioButton2.Text
        ElseIf TextBox1.Text = q9 Then
            answer = RadioButton3.Text
        ElseIf TextBox1.Text = q10 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q11 Then
            answer = RadioButton2.Text
        ElseIf TextBox1.Text = q12 Then
            answer = RadioButton3.Text
        ElseIf TextBox1.Text = q13 Then
            answer = RadioButton1.Text
        ElseIf TextBox1.Text = q14 Then
            answer = RadioButton4.Text
        ElseIf TextBox1.Text = q15 Then
            answer = RadioButton3.Text
        End If
        If MsgBox("YOU CHOSE TO WALK AWAY" & vbNewLine & "THE RIGHT ANSWER WAS " & answer & vbNewLine & "YOU WALK AWAY WITH " & TextBox3.Text & " DOLLARS" & vbNewLine & "Play again?", vbYesNo) = vbYes Then
            Me.Close()
            Form1.Show()
        Else : Application.Exit()
        End If
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
         walkaway()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = q1 Then
            MsgBox("Your friend says it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q2 Then
            MsgBox("Your friend says it is option c", vbOKOnly)
        ElseIf TextBox1.Text = q3 Then
            MsgBox("Your friend says it is option b", vbOKOnly)
        ElseIf TextBox1.Text = q4 Then
            MsgBox("Your friend says it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q5 Then
            MsgBox("Your friend says it is option c", vbOKOnly)
        ElseIf TextBox1.Text = q6 Then
            MsgBox("Your friend says it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q7 Then
            MsgBox("Your friend says it is option d", vbOKOnly)
        ElseIf TextBox1.Text = q8 Then
            MsgBox("Your friend says it is option b", vbOKOnly)
        ElseIf TextBox1.Text = q9 Then
            MsgBox("Your friend says it is option c", vbOKOnly)
        ElseIf TextBox1.Text = q10 Then
            MsgBox("Your friend says it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q11 Then
            MsgBox("Your friend says it is option b", vbOKOnly)
        ElseIf TextBox1.Text = q12 Then
            MsgBox("Your friend says it is option c", vbOKOnly)
        ElseIf TextBox1.Text = q13 Then
            MsgBox("Your friend says it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q14 Then
            MsgBox("Your friend says it is option d", vbOKOnly)
        ElseIf TextBox1.Text = q15 Then
            MsgBox("Your friend says it is option c", vbOKOnly)
        End If
        Button3.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = q1 Then
            MsgBox("100% of the audience is sure it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q2 Then
            MsgBox("80% of the audience is sure it is option c", vbOKOnly)
        ElseIf TextBox1.Text = q3 Then
            MsgBox("90% of the audience is sure it is option b", vbOKOnly)
        ElseIf TextBox1.Text = q4 Then
            MsgBox("80% of the audience is sure it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q5 Then
            MsgBox("75% of the audience is sure it is option c", vbOKOnly)
        ElseIf TextBox1.Text = q6 Then
            MsgBox("50% of the audience is sure it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q7 Then
            MsgBox("70% of the audience is sure it is option d", vbOKOnly)
        ElseIf TextBox1.Text = q8 Then
            MsgBox("90% of the audience is sure it is option b", vbOKOnly)
        ElseIf TextBox1.Text = q9 Then
            MsgBox("80% of the audience is sure it is option c", vbOKOnly)
        ElseIf TextBox1.Text = q10 Then
            MsgBox("95% of the audience is sure it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q11 Then
            MsgBox("85% of the audience is sure it is option b", vbOKOnly)
        ElseIf TextBox1.Text = q12 Then
            MsgBox("55% of the audience is sure it is option c", vbOKOnly)
        ElseIf TextBox1.Text = q13 Then
            MsgBox("45% of the audience is sure it is option a", vbOKOnly)
        ElseIf TextBox1.Text = q14 Then
            MsgBox("35% of the audience is sure it is option d", vbOKOnly)
        ElseIf TextBox1.Text = q15 Then
            MsgBox("25% of the audience is sure it is option ", vbOKOnly)
        End If
        Button4.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = q1 Then
            RadioButton2.Hide()
            RadioButton4.Hide()
        ElseIf TextBox1.Text = q2 Then
            RadioButton1.Hide()
            RadioButton4.Hide()
        ElseIf TextBox1.Text = q3 Then
            RadioButton3.Hide()
            RadioButton4.Hide()
        ElseIf TextBox1.Text = q4 Then
            RadioButton2.Hide()
            RadioButton3.Hide()
        ElseIf TextBox1.Text = q5 Then
            RadioButton2.Hide()
            RadioButton1.Hide()
        ElseIf TextBox1.Text = q6 Then
            RadioButton2.Hide()
            RadioButton4.Hide()
        ElseIf TextBox1.Text = q7 Then
            RadioButton2.Hide()
            RadioButton3.Hide()
        ElseIf TextBox1.Text = q8 Then
            RadioButton1.Hide()
            RadioButton4.Hide()
        ElseIf TextBox1.Text = q9 Then
            RadioButton2.Hide()
            RadioButton1.Hide()
        ElseIf TextBox1.Text = q10 Then
            RadioButton3.Hide()
            RadioButton4.Hide()
        ElseIf TextBox1.Text = q11 Then
            RadioButton1.Hide()
            RadioButton3.Hide()
        ElseIf TextBox1.Text = q12 Then
            RadioButton2.Hide()
            RadioButton1.Hide()
        ElseIf TextBox1.Text = q13 Then
            RadioButton2.Hide()
            RadioButton3.Hide()
        ElseIf TextBox1.Text = q14 Then
            RadioButton2.Hide()
            RadioButton3.Hide()
        ElseIf TextBox1.Text = q15 Then
            RadioButton2.Hide()
            RadioButton4.Hide()
        End If
        Button5.Hide()
    End Sub

   

   

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class