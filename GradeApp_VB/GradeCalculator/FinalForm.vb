'Name:      Grade Calculator - FinalForm
'Class:     ENTD361 B001 Win 19
'Programmer:Christopher Rohrer
'Professor: Dr Deborah Moerland

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmFinal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Makes sure the user wants to quit the application
        frmName.btnExit_Click(Me, e)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ' Hides this form and shows the Grade Form
        Me.Hide()
        frmGrade.Show()

    End Sub

    Private Sub btnNextStudent_Click(sender As Object, e As EventArgs) Handles btnNextStudent.Click
        Dim ctlTextbox As New Control

        ' Clears the textboxes in the Forum Group
        For intInd As Integer = 0 To 7
            ctlTextbox = frmGrade.grpForum.GetNextControl(ctlTextbox, True)
            ctlTextbox.Text = String.Empty
        Next

        ' Clears the textboxes in the Assignment Group
        For intInd As Integer = 0 To 7
            ctlTextbox = frmGrade.grpAssignment.GetNextControl(ctlTextbox, True)
            ctlTextbox.Text = String.Empty
        Next

        ' Clears the Final Project Combobox and Button
        frmProject.cboFinalProject.Items.Clear()
        For intPercent As Integer = 100 To 0 Step -1
            frmProject.cboFinalProject.Items.Add(intPercent)
        Next
        frmGrade.btnFinalProject.Text = "Set Grade"

        ' Clears the Last Name and First Name Textboxes
        frmName.txtLName.Text = String.Empty
        frmName.txtFName.Text = String.Empty

        ' Sets Grade Form's focus to Forum Week 1 Textbox
        frmGrade.Show()
        frmGrade.txtForumWk1.Focus()
        frmGrade.Hide()

        ' Sets Name Form's focus to Last Name Textbox, then shows the Name Form
        frmName.Show()
        frmName.txtLName.Focus()
        Me.Hide()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        ' Makes buttons invisible for printing
        btnBack.Visible = False
        btnExit.Visible = False
        btnNextStudent.Visible = False
        btnPrint.Visible = False

        ' Sends form to Print Preview Window, then opens Print Preview Window
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

        ' Makes button visible after printing
        btnBack.Visible = True
        btnExit.Visible = True
        btnNextStudent.Visible = True
        btnPrint.Visible = True

    End Sub

End Class