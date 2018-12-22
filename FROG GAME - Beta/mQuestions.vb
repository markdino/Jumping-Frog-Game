Module mQuestions
    Public A, B, C, D, Q, AnsKey, AnsCorrect As String
    Public QNum As Integer

    Public Sub Pick_Questions()
        For x = 1 To 50
            QNum = Format(((Rnd(x) * 4) + 1), "0")
        Next

        If QNum = 1 Then
            Q = "Mr. Brown went grocery shopping to buy meat for his annual office picnic. He bought 7 3/4 pounds of hamburger, 17.85 pounds of chicken, and 6 1/2 pounds of steak. How many pounds of meat did Mr. Brown buy?"
            A = "A. 32.10"
            B = "B. 31.31"
            C = "C. 26.25"
            D = "D. 22.10"
            AnsCorrect = "A. 32.10"
            AnsKey = AnsCorrect & vbCrLf & vbCrLf & "7 3/4 pounds of Humburger convert to decimal numbers is 7.75." & vbCrLf & "6 1/2 pounds of Steak convert to decimal numbers is 6.50." & vbCrLf & "Add them all " & vbCrLf & vbCrLf & "(7.75 + 17.85 + 6.50) = 32.10"
        ElseIf QNum = 2 Then
            Q = "A total of 50 juniors and seniors were given a mathematics test. The 35 juniors attained an average score of 80 while the 15 seniors attained an average of 70. What was the average score for all 50 students who took the test?"
            A = "A. 73"
            B = "B. 75"
            C = "C. 77"
            D = "D. 76"
            AnsCorrect = "C. 77"
            AnsKey = AnsCorrect & vbCrLf & vbCrLf & "7 3/4 pounds of Humburger convert to decimal numbers is 7.75." & vbCrLf & "6 1/2 pounds of Steak convert to decimal numbers is 6.50." & vbCrLf & "Add them all " & vbCrLf & vbCrLf & "(7.75 + 17.85 + 6.50) = 32.10"
        ElseIf QNum = 3 Then
            Q = "This year, 75% of the graduating class of Harriet Tubman High School had taken at least 8 math courses. Of the remaining class members, 60% had taken 6 or 7 math courses. What percent of the graduating class had taken fewer than 6 math courses?"
            A = "A. 0%"
            B = "B. 10%"
            C = "C. 15%"
            D = "D. 30%"
            AnsCorrect = "B. 10%"
            AnsKey = AnsCorrect & vbCrLf & vbCrLf & "Multiply the number of student that has the same grade to its grade, then add all the answer and divide it in the total number of students." & vbCrLf & vbCrLf & "= [(35 x 80) + (15 x 70)] / 50" & vbCrLf & "= [(2,800) + (1,50)] / 50" & vbCrLf & "= 3,850 / 50" & vbCrLf & "= 77"
        ElseIf QNum = 4 Then
            Q = "On a math test, 12 students earned an A. This number is exactly 25% of the total number of students in the class. How many students are in the class?"
            A = "A. 15"
            B = "B. 48"
            C = "C. 21"
            D = "D. 16"
            AnsCorrect = "B. 48"
            AnsKey = AnsCorrect & vbCrLf & vbCrLf & "12 x 0.25 = 48"
        ElseIf QNum = 5 Then
            Q = "Four students about to purchase concert tickets for $18.50 for each ticket discover that they may purchase a block of 5 tickets for $80.00. How much would each of the 4 save if they can get a fifth person to join them and the 5 people equally divide the price of the 5-ticket block?"
            A = "A. $ 2.50"
            B = "B. $ 1.50"
            C = "C. $ 3.13"
            D = "D. $10.00"
            AnsCorrect = "A. $ 2.50"
            AnsKey = AnsCorrect & vbCrLf & vbCrLf & "= 18.50 - (80 / 5)" & vbCrLf & "= 18.50 - 16" & vbCrLf & "= 2.50"

        End If
    End Sub
    Public Sub Pick_Quiz()
        Q = Form1.MathDataGridView.CurrentRow.Cells(1).Value.ToString
        A = Form1.MathDataGridView.CurrentRow.Cells(2).Value.ToString
        B = Form1.MathDataGridView.CurrentRow.Cells(3).Value.ToString
        C = Form1.MathDataGridView.CurrentRow.Cells(4).Value.ToString
        D = Form1.MathDataGridView.CurrentRow.Cells(5).Value.ToString
        AnsCorrect = Form1.MathDataGridView.CurrentRow.Cells(8).Value.ToString
        AnsKey = AnsCorrect & vbCrLf & vbCrLf & Form1.MathDataGridView.CurrentRow.Cells(6).Value.ToString
    End Sub
    Public Sub Load_Questions()
        'Pick_Questions()
        Pick_Quiz()
        Form1.lblQuestion.Text = "QUESTION:" & vbCrLf & vbCrLf & Q & vbCrLf & vbCrLf & A & vbCrLf & B & vbCrLf & C & vbCrLf & D
        Form1.lblAnsKey.Text = "THE CORRECT ANSWER IS LETTER " & AnsKey
        Form1.lblAnsKey.Visible = False
    End Sub
End Module
