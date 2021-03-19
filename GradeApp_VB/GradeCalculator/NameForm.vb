'Name:      Grade Calculator - NameForm
'Class:     ENTD361 B001 Win 19
'Programmer:Christopher Rohrer
'Professor: Dr Deborah Moerland

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmName
    Public Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim res As DialogResult

        ' Makes sure the user wants to quit the application
        res = MessageBox.Show("Are you ready to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If (res = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' Ensures that both last name and first name are filled out and sends name info to other forms
        If (txtLName.Text = String.Empty OrElse txtFName.Text = String.Empty) Then
            MsgBox("Please enter a first and last name!", , "Name Needed!")
            txtLName.Focus()
        Else
            frmGrade.Show()
            frmGrade.lblStudentName.Text = txtLName.Text & ", " & txtFName.Text
            frmFinal.lblStudentName.Text = txtLName.Text & ", " & txtFName.Text
            Me.Hide()
        End If

    End Sub

    ' Entering a textbox will select all text already inside (Next 2 subroutines)
    Private Sub txtLName_Enter(sender As Object, e As EventArgs) Handles txtLName.Enter
        txtLName.SelectAll()
    End Sub

    Private Sub txtFName_Enter(sender As Object, e As EventArgs) Handles txtFName.Enter
        txtFName.SelectAll()
    End Sub

    Private Sub txtFName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFName.KeyPress

        ' Sends focus to Grades Button when "Enter" is pushed in First Name Textbox
        If (e.KeyChar = ControlChars.Cr) Then
            btnNext.Focus()
        End If

        ' Catches non-letter keys, backspace, hyphen, comma, single quote, and space keys and cancels their input
        If (Not (Asc(e.KeyChar) >= 65 AndAlso Asc(e.KeyChar) <= 90) AndAlso
        Not (Asc(e.KeyChar) >= 97 AndAlso Asc(e.KeyChar) <= 122) AndAlso
        Not (e.KeyChar = ControlChars.Back) AndAlso Not (e.KeyChar = "'") AndAlso
        Not (e.KeyChar = ",") AndAlso Not (e.KeyChar = "-") AndAlso Not (e.KeyChar = " ")) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtLName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLName.KeyPress

        ' Sends focus to FIrst Name Textbox when "Enter" is pushed in Last Name Textbox
        If (e.KeyChar = ControlChars.Cr) Then
            txtFName.Focus()
        End If

        ' Catches non-letter keys, backspace, hyphen, comma, single quote, and space keys and cancels their input
        If (Not (Asc(e.KeyChar) >= 65 AndAlso Asc(e.KeyChar) <= 90) AndAlso
        Not (Asc(e.KeyChar) >= 97 AndAlso Asc(e.KeyChar) <= 122) AndAlso
        Not (e.KeyChar = ControlChars.Back) AndAlso Not (e.KeyChar = "'") AndAlso
        Not (e.KeyChar = ",") AndAlso Not (e.KeyChar = "-") AndAlso Not (e.KeyChar = " ")) Then
            e.Handled = True
        End If

    End Sub
End Class
