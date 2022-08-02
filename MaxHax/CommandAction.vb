Public Class CommandAction
    Private _Selection As Selections
    Private _RunCommand As String
    Private _ChangeVar As VarChange

    Public Sub New(Optional RunCommand As String = Nothing, Optional ChangeVar As VarChange = Nothing)
        Select Case True
            Case RunCommand Is Nothing
                _ChangeVar = ChangeVar
            Case ChangeVar Is Nothing
                _RunCommand = RunCommand
        End Select
    End Sub

    Public Enum Selections As Integer
        RunCommand = 0
        ChangeVar = 1
    End Enum

    Public Property Selection As Selections
        Get
            Return _Selection
        End Get
        Set
            _Selection = Value
        End Set
    End Property

    Public Property RunCommand As String
        Get
            Return _RunCommand
        End Get
        Set
            _RunCommand = Value
        End Set
    End Property

    Public Property ChangeVar As VarChange
        Get
            Return _ChangeVar
        End Get
        Set
            _ChangeVar = Value
        End Set
    End Property
End Class
