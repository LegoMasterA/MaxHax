Public Class VarChange
    Private _VarName As String
    Private _EditToMake As String

    Public Sub New(VarName As String, EditToMake As String)
        Me.VarName = _VarName
        Me.EditToMake = _EditToMake
    End Sub

    Property VarName As String
        Get
            Return _VarName
        End Get
        Set
            _VarName = Value
        End Set
    End Property

    Property EditToMake As String
        Get
            Return _EditToMake
        End Get
        Set
            _EditToMake = Value
        End Set
    End Property
End Class
