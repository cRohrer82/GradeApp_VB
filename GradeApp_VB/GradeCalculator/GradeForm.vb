'Name:      Grade Calculator - GradeForm
'Class:     ENTD361 B001 Win 19
'Programmer:Christopher Rohrer
'Professor: Dr Deborah Moerland

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmGrade

    ' Entering a textbox will select all text already inside (Next 16 subroutines)
    Private Sub txtAssignWk1_Enter(sender As Object, e As EventArgs) Handles txtAssignWk1.Enter
        txtAssignWk1.SelectAll()
    End Sub

    Private Sub txtAssignWk2_Enter(sender As Object, e As EventArgs) Handles txtAssignWk2.Enter
        txtAssignWk2.SelectAll()
    End Sub

    Private Sub txtAssignWk3_Enter(sender As Object, e As EventArgs) Handles txtAssignWk3.Enter
        txtAssignWk3.SelectAll()
    End Sub

    Private Sub txtAssignWk4_Enter(sender As Object, e As EventArgs) Handles txtAssignWk4.Enter
        txtAssignWk4.SelectAll()
    End Sub

    Private Sub txtAssignWk5_Enter(sender As Object, e As EventArgs) Handles txtAssignWk5.Enter
        txtAssignWk5.SelectAll()
    End Sub

    Private Sub txtAssignWk6_Enter(sender As Object, e As EventArgs) Handles txtAssignWk6.Enter
        txtAssignWk6.SelectAll()
    End Sub

    Private Sub txtAssignWk7_Enter(sender As Object, e As EventArgs) Handles txtAssignWk7.Enter
        txtAssignWk7.SelectAll()
    End Sub

    Private Sub txtAssignWk8_Enter(sender As Object, e As EventArgs) Handles txtAssignWk8.Enter
        txtAssignWk8.SelectAll()
    End Sub

    Private Sub txtForumWk1_Enter(sender As Object, e As EventArgs) Handles txtForumWk1.Enter
        txtForumWk1.SelectAll()
    End Sub

    Private Sub txtForumWk2_Enter(sender As Object, e As EventArgs) Handles txtForumWk2.Enter
        txtForumWk2.SelectAll()
    End Sub

    Private Sub txtForumWk3_Enter(sender As Object, e As EventArgs) Handles txtForumWk3.Enter
        txtForumWk3.SelectAll()
    End Sub

    Private Sub txtForumWk4_Enter(sender As Object, e As EventArgs) Handles txtForumWk4.Enter
        txtForumWk4.SelectAll()
    End Sub

    Private Sub txtForumWk5_Enter(sender As Object, e As EventArgs) Handles txtForumWk5.Enter
        txtForumWk5.SelectAll()
    End Sub

    Private Sub txtForumWk6_Enter(sender As Object, e As EventArgs) Handles txtForumWk6.Enter
        txtForumWk6.SelectAll()
    End Sub

    Private Sub txtForumWk7_Enter(sender As Object, e As EventArgs) Handles txtForumWk7.Enter
        txtForumWk7.SelectAll()
    End Sub

    Private Sub txtForumWk8_Enter(sender As Object, e As EventArgs) Handles txtForumWk8.Enter
        txtForumWk8.SelectAll()
    End Sub


    Private Sub validateEntry(control As Object, e As KeyPressEventArgs) Handles txtAssignWk1.KeyPress,
    txtAssignWk2.KeyPress, txtAssignWk3.KeyPress, txtAssignWk4.KeyPress, txtAssignWk5.KeyPress,
    txtAssignWk6.KeyPress, txtAssignWk7.KeyPress, txtAssignWk8.KeyPress, txtForumWk1.KeyPress,
    txtForumWk2.KeyPress, txtForumWk3.KeyPress, txtForumWk4.KeyPress, txtForumWk5.KeyPress,
    txtForumWk6.KeyPress, txtForumWk7.KeyPress, txtForumWk8.KeyPress
        Static Dim ctlActiveTextbox As New Control
        Static Dim ctlActiveGroup As New Control

        ' Sets controls to control variables
        ctlActiveGroup = Me.ActiveControl.Parent
        ctlActiveTextbox = Me.ActiveControl

        ' Checks for special focus locations and sends focus to correct control
        If (Me.ActiveControl Is txtAssignWk8) Then
            ctlActiveGroup = Nothing
        ElseIf (Me.ActiveControl Is txtForumWk8) Then
            ctlActiveGroup = Me.grpAssignment
        End If

        ' Catches "Enter" key to move focus to next control
        If ((e.KeyChar = ControlChars.Cr) AndAlso (ctlActiveGroup Is Nothing)) Then
            Me.ActiveControl = btnFinalProject
        ElseIf ((e.KeyChar = ControlChars.Cr) AndAlso (ctlActiveGroup IsNot Nothing)) Then
            ctlActiveTextbox = ctlActiveGroup.GetNextControl(ctlActiveTextbox, True)
            ctlActiveTextbox.Focus()
        End If

        ' Catches non-number or backspace keys and cancels their input
        If ((e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim grade As Grade
        Dim intForumTotal As Integer
        Dim intAssignmentTotal As Integer
        Dim intProjectTotal As Integer
        Dim ctlTextbox As New Control

        ' Totals the data from the "Forum" section
        For intInd As Integer = 0 To 7
            Dim intNext As Integer

            ctlTextbox = grpForum.GetNextControl(ctlTextbox, True)
            Integer.TryParse(ctlTextbox.Text, intNext)
            intForumTotal += intNext
        Next

        ' Totals the data from the "Assignment" section
        For intInd As Integer = 0 To 7
            Dim intNext As Integer

            ctlTextbox = grpAssignment.GetNextControl(ctlTextbox, True)
            Integer.TryParse(ctlTextbox.Text, intNext)
            intAssignmentTotal += intNext
        Next

        ' Converts Text in Final Project Button to Integer
        If (btnFinalProject.Text = "Set Grade") Then
            intProjectTotal = 0
        Else
            Integer.TryParse(btnFinalProject.Text, intProjectTotal)
        End If

        ' Instantiates a new Grade class with totals from above
        grade = New Grade(intForumTotal, intAssignmentTotal, intProjectTotal)

        ' Updates labels in FinalForm with calculated data from Grade class
        frmFinal.lblForumFinal.Text = grade.ForumFinal.ToString("P2")
        frmFinal.lblAssignmentFinal.Text = grade.AssignmentFinal.ToString("P2")
        frmFinal.lblProjectFinal.Text = grade.ProjectFinal.ToString("P0")
        frmFinal.lblClassFinal.Text = grade.getFinalGrade().ToString("P2")

        ' Updates letter grade and label color based on class final grade
        Select Case grade.getFinalGrade()
            Case = 1
                frmFinal.lblClassLetter.BackColor = Color.Gold
                frmFinal.lblClassLetter.Text = "A"
            Case >= 0.93
                frmFinal.lblClassLetter.BackColor = Color.LightGreen
                frmFinal.lblClassLetter.Text = "A"
            Case 0.9 To 0.929
                frmFinal.lblClassLetter.BackColor = Color.LightGreen
                frmFinal.lblClassLetter.Text = "A-"
            Case 0.88 To 0.899
                frmFinal.lblClassLetter.BackColor = Color.LightGreen
                frmFinal.lblClassLetter.Text = "B+"
            Case 0.83 To 0.879
                frmFinal.lblClassLetter.BackColor = Color.LightGreen
                frmFinal.lblClassLetter.Text = "B"
            Case 0.8 To 0.829
                frmFinal.lblClassLetter.BackColor = Color.LightGreen
                frmFinal.lblClassLetter.Text = "B-"
            Case 0.78 To 0.799
                frmFinal.lblClassLetter.BackColor = Color.Yellow
                frmFinal.lblClassLetter.Text = "C+"
            Case 0.73 To 0.779
                frmFinal.lblClassLetter.BackColor = Color.Yellow
                frmFinal.lblClassLetter.Text = "C"
            Case 0.7 To 0.729
                frmFinal.lblClassLetter.BackColor = Color.Yellow
                frmFinal.lblClassLetter.Text = "C-"
            Case 0.68 To 0.699
                frmFinal.lblClassLetter.BackColor = Color.Yellow
                frmFinal.lblClassLetter.Text = "D+"
            Case 0.63 To 0.679
                frmFinal.lblClassLetter.BackColor = Color.Yellow
                frmFinal.lblClassLetter.Text = "D"
            Case 0.6 To 0.629
                frmFinal.lblClassLetter.BackColor = Color.Yellow
                frmFinal.lblClassLetter.Text = "D-"
            Case Else
                frmFinal.lblClassLetter.BackColor = Color.Red
                frmFinal.lblClassLetter.Text = "F"
        End Select

        Me.Hide()
        frmFinal.Show()
        frmFinal.btnPrint.Focus()

    End Sub

    Private Sub btnChangeName_Click(sender As Object, e As EventArgs) Handles btnChangeName.Click

        ' Returns to the Name Form and sets focus to the Last Name Textbox
        Me.Hide()
        frmName.Show()
        frmName.txtLName.Focus()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim ctlTextbox As New Control

        ' Clears the textboxes in the Forum Group
        For intInd As Integer = 0 To 7
            ctlTextbox = grpForum.GetNextControl(ctlTextbox, True)
            ctlTextbox.Text = String.Empty
        Next

        ' Clears the textboxes in the Assignment Group
        For intInd As Integer = 0 To 7
            ctlTextbox = grpAssignment.GetNextControl(ctlTextbox, True)
            ctlTextbox.Text = String.Empty
        Next

        ' Clears the Final Project Combobox
        frmProject.cboFinalProject.Items.Clear()
        For intPercent As Integer = 100 To 0 Step -1
            frmProject.cboFinalProject.Items.Add(intPercent)
        Next
        btnFinalProject.Text = "Set Grade"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Makes sure the user wants to quit the application
        frmName.btnExit_Click(Me, e)

    End Sub

    Private Sub btnFinalProject_Click(sender As Object, e As EventArgs) Handles btnFinalProject.Click

        ' Shows the Project Form and hides the Grade Form
        frmProject.Show()
        Me.Hide()

    End Sub

End Class