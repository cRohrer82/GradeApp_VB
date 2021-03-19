<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinal))
        Me.lblForum = New System.Windows.Forms.Label()
        Me.lblAssignment = New System.Windows.Forms.Label()
        Me.lblFinalProject = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblForumFinal = New System.Windows.Forms.Label()
        Me.lblAssignmentFinal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblProjectFinal = New System.Windows.Forms.Label()
        Me.lblClassFinal = New System.Windows.Forms.Label()
        Me.lblClassLetter = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.btnNextStudent = New System.Windows.Forms.Button()
        Me.grpName = New System.Windows.Forms.GroupBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.grpName.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblForum
        '
        Me.lblForum.AutoSize = True
        Me.lblForum.Location = New System.Drawing.Point(12, 82)
        Me.lblForum.Name = "lblForum"
        Me.lblForum.Size = New System.Drawing.Size(71, 13)
        Me.lblForum.TabIndex = 0
        Me.lblForum.Text = "Forum Grade:"
        '
        'lblAssignment
        '
        Me.lblAssignment.AutoSize = True
        Me.lblAssignment.Location = New System.Drawing.Point(94, 82)
        Me.lblAssignment.Name = "lblAssignment"
        Me.lblAssignment.Size = New System.Drawing.Size(96, 13)
        Me.lblAssignment.TabIndex = 1
        Me.lblAssignment.Text = "Assignment Grade:"
        '
        'lblFinalProject
        '
        Me.lblFinalProject.AutoSize = True
        Me.lblFinalProject.Location = New System.Drawing.Point(12, 115)
        Me.lblFinalProject.Name = "lblFinalProject"
        Me.lblFinalProject.Size = New System.Drawing.Size(100, 13)
        Me.lblFinalProject.TabIndex = 2
        Me.lblFinalProject.Text = "Final Project Grade:"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(10, 153)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(139, 26)
        Me.lblClass.TabIndex = 3
        Me.lblClass.Text = "Class Grade:"
        '
        'lblForumFinal
        '
        Me.lblForumFinal.AutoSize = True
        Me.lblForumFinal.Location = New System.Drawing.Point(12, 95)
        Me.lblForumFinal.Name = "lblForumFinal"
        Me.lblForumFinal.Size = New System.Drawing.Size(68, 13)
        Me.lblForumFinal.TabIndex = 8
        Me.lblForumFinal.Text = "lblForumFinal"
        '
        'lblAssignmentFinal
        '
        Me.lblAssignmentFinal.AutoSize = True
        Me.lblAssignmentFinal.Location = New System.Drawing.Point(94, 95)
        Me.lblAssignmentFinal.Name = "lblAssignmentFinal"
        Me.lblAssignmentFinal.Size = New System.Drawing.Size(93, 13)
        Me.lblAssignmentFinal.TabIndex = 9
        Me.lblAssignmentFinal.Text = "lblAssignmentFinal"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Location = New System.Drawing.Point(236, 194)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblProjectFinal
        '
        Me.lblProjectFinal.AutoSize = True
        Me.lblProjectFinal.Location = New System.Drawing.Point(12, 128)
        Me.lblProjectFinal.Name = "lblProjectFinal"
        Me.lblProjectFinal.Size = New System.Drawing.Size(72, 13)
        Me.lblProjectFinal.TabIndex = 11
        Me.lblProjectFinal.Text = "lblProjectFinal"
        '
        'lblClassFinal
        '
        Me.lblClassFinal.AutoSize = True
        Me.lblClassFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassFinal.Location = New System.Drawing.Point(8, 184)
        Me.lblClassFinal.Name = "lblClassFinal"
        Me.lblClassFinal.Size = New System.Drawing.Size(136, 26)
        Me.lblClassFinal.TabIndex = 12
        Me.lblClassFinal.Text = "lblClassFinal"
        '
        'lblClassLetter
        '
        Me.lblClassLetter.AutoSize = True
        Me.lblClassLetter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblClassLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClassLetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassLetter.Location = New System.Drawing.Point(106, 182)
        Me.lblClassLetter.Name = "lblClassLetter"
        Me.lblClassLetter.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblClassLetter.Size = New System.Drawing.Size(45, 28)
        Me.lblClassLetter.TabIndex = 13
        Me.lblClassLetter.Text = "CL"
        Me.lblClassLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.BackColor = System.Drawing.Color.Silver
        Me.lblStudentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblStudentName.Location = New System.Drawing.Point(7, 22)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(0, 26)
        Me.lblStudentName.TabIndex = 15
        '
        'btnNextStudent
        '
        Me.btnNextStudent.BackColor = System.Drawing.SystemColors.Control
        Me.btnNextStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextStudent.Location = New System.Drawing.Point(236, 154)
        Me.btnNextStudent.Name = "btnNextStudent"
        Me.btnNextStudent.Size = New System.Drawing.Size(75, 41)
        Me.btnNextStudent.TabIndex = 2
        Me.btnNextStudent.Text = "&Next Student"
        Me.btnNextStudent.UseVisualStyleBackColor = False
        '
        'grpName
        '
        Me.grpName.Controls.Add(Me.lblStudentName)
        Me.grpName.Location = New System.Drawing.Point(12, 5)
        Me.grpName.Name = "grpName"
        Me.grpName.Size = New System.Drawing.Size(299, 63)
        Me.grpName.TabIndex = 17
        Me.grpName.TabStop = False
        Me.grpName.Text = "Student Name:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.Location = New System.Drawing.Point(236, 118)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 37)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "&Back to Grades"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Gold
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(236, 82)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 33)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmFinal
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 227)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.grpName)
        Me.Controls.Add(Me.btnNextStudent)
        Me.Controls.Add(Me.lblClassLetter)
        Me.Controls.Add(Me.lblClassFinal)
        Me.Controls.Add(Me.lblProjectFinal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAssignmentFinal)
        Me.Controls.Add(Me.lblForumFinal)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblFinalProject)
        Me.Controls.Add(Me.lblAssignment)
        Me.Controls.Add(Me.lblForum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFinal"
        Me.Text = "Final Grade Form"
        Me.grpName.ResumeLayout(False)
        Me.grpName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblForum As Label
    Friend WithEvents lblAssignment As Label
    Friend WithEvents lblFinalProject As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents lblForumFinal As Label
    Friend WithEvents lblAssignmentFinal As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblProjectFinal As Label
    Friend WithEvents lblClassFinal As Label
    Friend WithEvents lblClassLetter As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents btnNextStudent As Button
    Friend WithEvents grpName As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
