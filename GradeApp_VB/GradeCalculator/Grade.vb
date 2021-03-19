'Name:      Grade Calculator - GradeClass
'Class:     ENTD361 B001 Win 19
'Programmer:Christopher Rohrer
'Professor: Dr Deborah Moerland

Public Class Grade
    Private _intForum As Integer
    Private _intAssignment As Integer
    Private _intProject As Integer

    Public ReadOnly Property ForumFinal As Double

        ' Averages forum grades and prepares for percent format
        Get
            Return _intForum / 800
        End Get

    End Property

    Public ReadOnly Property AssignmentFinal As Double

        ' Averages assignment grades and prepares for percent format
        Get
            Return _intAssignment / 800
        End Get

    End Property

    Public ReadOnly Property ProjectFinal As Double

        ' Prepares for percent format
        Get
            Return _intProject / 100
        End Get

    End Property

    Public Sub New()
        _intForum = 0
        _intAssignment = 0
        _intProject = 0

    End Sub

    Public Sub New(ByVal intForumTotal As Integer,
                    ByVal intAssignmentTotal As Integer,
                    ByVal intProjectTotal As Integer)
        _intForum = intForumTotal
        _intAssignment = intAssignmentTotal
        _intProject = intProjectTotal

    End Sub

    Public Function getFinalGrade() As Double
        Dim dblFinal As Double

        ' Calculates the final grade for the class
        dblFinal = (Me.ForumFinal * 0.3) + (Me.AssignmentFinal * 0.45) + (Me.ProjectFinal * 0.25)
        Return dblFinal

    End Function

End Class
