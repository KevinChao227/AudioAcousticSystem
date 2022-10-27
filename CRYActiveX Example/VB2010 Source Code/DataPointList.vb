Option Strict Off
Option Explicit On
Friend Class DataPointList
    'local variable to hold collection
    Private mCol() As DataPoint
    Private mCurveName As String
    Private mInUse As Integer
    Private mMin As DataPoint
    Private mMax As DataPoint
    Private mXUnit As String
    Private mXScaleType As Integer
    Private mYUnit As String
    Private mYScaleType As Integer

    Public Function Add(ByRef X As Double, ByRef Y As Double) As DataPoint
        'create a new object
        Dim objNewMember As DataPoint
        objNewMember = New DataPoint

        'Make sure mCol is large enough to hold new point
        If (mInUse = mCol.Length) Then
            Dim increment As Integer
            increment = 100
            ReDim Preserve mCol(mCol.Length + increment)
        End If

        'set the properties passed into the method
        objNewMember.X = X
        objNewMember.Y = Y
        mCol(mInUse) = objNewMember
        mInUse = mInUse + 1

        'return the object created
        Add = objNewMember
        objNewMember = Nothing
    End Function
	
    Public Property XScaleType() As Integer
        Get
            Return mXScaleType
        End Get
        Set(ByVal Value As Integer)
            mXScaleType = Value
        End Set
    End Property

    Public Property YScaleType() As Integer
        Get
            Return mYScaleType
        End Get
        Set(ByVal Value As Integer)
            mYScaleType = Value
        End Set
    End Property

    Public Property XUnit() As String
        Get
            Return mXUnit
        End Get
        Set(ByVal Value As String)
            mXUnit = Value
        End Set
    End Property

    Public Property YUnit() As String
        Get
            Return mYUnit
        End Get
        Set(ByVal Value As String)
            mYUnit = Value
        End Set
    End Property

    Default Public ReadOnly Property Item(ByVal index As Integer) As DataPoint
        Get
            Item = mCol(index)
        End Get
    End Property
	
    Public Property Name() As String
        Set(ByVal Value As String)
            mCurveName = Value
        End Set
        Get
            Return mCurveName
        End Get
    End Property
	
	Public ReadOnly Property Count() As Integer
		Get
			'used when retrieving the number of elements in the
			'collection. Syntax: Debug.Print x.Count
            Count = mInUse
		End Get
	End Property
	
    Public ReadOnly Property Maximum() As DataPoint
        Get
            Dim numberPoints As Integer
            Dim dpIndex As Integer
            Dim aDataPoint As DataPoint

            numberPoints = Count()
            Maximum = New DataPoint
            Maximum.X = Item(0).X
            Maximum.Y = Item(0).Y

            dpIndex = 1

            Do Until dpIndex >= numberPoints
                aDataPoint = Item(dpIndex)
                If (aDataPoint.X > Maximum.X) Then
                    Maximum.X = aDataPoint.X
                End If
                If (aDataPoint.Y > Maximum.Y) Then
                    Maximum.Y = aDataPoint.Y
                End If
                dpIndex = dpIndex + 1
            Loop
        End Get
    End Property
	
	Public ReadOnly Property Minimum() As DataPoint
		Get
			Dim numberPoints As Integer
			Dim dpIndex As Integer
			Dim aDataPoint As DataPoint
			
            numberPoints = Count()

            Minimum = New DataPoint
            Minimum.X = Item(0).X
            Minimum.Y = Item(0).Y

            dpIndex = 1
			
            Do Until dpIndex >= numberPoints
                aDataPoint = Item(dpIndex)
                If (aDataPoint.X < Minimum.X) Then
                    Minimum.X = aDataPoint.X
                End If
                If (aDataPoint.Y < Minimum.Y) Then
                    Minimum.Y = aDataPoint.Y
                End If
                dpIndex = dpIndex + 1
            Loop
        End Get
	End Property

    Private Sub DataPointList_Initialize()
        'creates the collection when this class is created
        Dim initSize As Integer
        initSize = 200
        ReDim mCol(initSize)
        mInUse = 0
        mXUnit = ""
        mXScaleType = 1
        mYUnit = ""
        mYScaleType = 1
    End Sub

	Public Sub New()
		MyBase.New()
        DataPointList_Initialize()
	End Sub
	
    Private Sub DataPointList_Terminate()
        'destroys collection when this class is terminated
        ReDim mCol(0)
    End Sub
	Protected Overrides Sub Finalize()
        DataPointList_Terminate()
		MyBase.Finalize()
    End Sub
    Public Sub Copy(ByRef new_curve As DataPointList)
        Dim pointIndex As Integer
        Dim aPoint As DataPoint

        new_curve.Name = Me.Name
        new_curve.XScaleType = Me.XScaleType
        new_curve.XUnit = Me.XUnit
        new_curve.YScaleType = Me.YScaleType
        new_curve.YUnit = Me.YUnit

        pointIndex = 0
        Do Until pointIndex > Me.Count
            aPoint = Me.Item(pointIndex)
            If Not (aPoint Is Nothing) Then
                new_curve.Add((aPoint.X), (aPoint.Y))
            End If
            pointIndex = pointIndex + 1
        Loop
    End Sub
End Class