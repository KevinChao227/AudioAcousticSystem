Public Class CRYAppInfo
    Private mVersion As String
    Private mPath As String
    Private mCOMObject As String

    Public Property Version() As String
        Get
            Version = mVersion
        End Get
        Set(ByVal value As String)
            mVersion = value
        End Set
    End Property

    Public Property ExePath() As String
        Get
            ExePath = mPath
        End Get
        Set(ByVal value As String)
            mPath = value
        End Set
    End Property

    Public Property COMString() As String
        Get
            COMString = mCOMObject
        End Get
        Set(ByVal value As String)
            mCOMObject = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
