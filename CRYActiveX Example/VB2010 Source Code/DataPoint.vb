Option Strict Off
Option Explicit On
Friend Class DataPoint
	'local variable(s) to hold property value(s)
	Private mvarX As Double 'local copy
	Private mvarY As Double 'local copy

	Public Property Y() As Double
		Get
			'used when retrieving value of a property, on the right side of an assignment.
			'Syntax: Debug.Print X.Y
			Y = mvarY
		End Get
		Set(ByVal Value As Double)
			'used when assigning a value to the property, on the left side of an assignment.
			'Syntax: X.Y = 5
			mvarY = Value
		End Set
	End Property
	
    Public Property X() As Double
        Get
            'used when retrieving value of a property, on the right side of an assignment.
            'Syntax: Debug.Print X.X
            X = mvarX
        End Get
        Set(ByVal Value As Double)
            'used when assigning a value to the property, on the left side of an assignment.
            'Syntax: X.X = 5
            mvarX = Value
        End Set
    End Property
	
    Private Sub DataPoint_Initialize()
        X = 0.0#
        Y = 0.0#
    End Sub

    Public Sub New()
        MyBase.New()
        DataPoint_Initialize()
    End Sub
End Class