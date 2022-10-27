Option Strict Off
Option Explicit On
Friend Class frmCurves
	Inherits System.Windows.Forms.Form
	
	Private mIsCommitted As Boolean
	Private mSelectedCurves As Collection
	Private mAvailableCurves As Collection
	Private mLoadDataAuto As Boolean
	
	Public ReadOnly Property isCommitted() As Boolean
		Get
			isCommitted = mIsCommitted
		End Get
	End Property
	
	
	Public Property loadDataAuto() As Boolean
		Get
			mLoadDataAuto = chkLoadAuto.CheckState
			loadDataAuto = mLoadDataAuto
		End Get
		Set(ByVal Value As Boolean)
			mLoadDataAuto = Value
		End Set
	End Property
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		mIsCommitted = False
		Me.Hide()
	End Sub
	
	Private Sub cmdDone_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDone.Click
		Dim numberCurves As Integer
		Dim curveIndex As Integer
		
		mSelectedCurves = Nothing
		mSelectedCurves = New Collection
		mAvailableCurves = Nothing
		mAvailableCurves = New Collection
		
		numberCurves = lstSelected.Items.Count
		For curveIndex = 0 To numberCurves - 1
			mSelectedCurves.Add(VB6.GetItemString(lstSelected, curveIndex))
		Next curveIndex
		
		numberCurves = lstAvailable.Items.Count
		For curveIndex = 0 To numberCurves - 1
			mAvailableCurves.Add(VB6.GetItemString(lstAvailable, curveIndex))
		Next curveIndex
		
		mIsCommitted = True
        Me.Close()
	End Sub
	
	Private Sub cmdMoveAll2A_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMoveAll2A.Click
        Dim numberItems As Integer
		Dim itemString As String
		
		numberItems = lstSelected.Items.Count
		Do Until numberItems = 0
			numberItems = numberItems - 1
			itemString = VB6.GetItemString(lstSelected, numberItems)
			lstSelected.Items.RemoveAt((numberItems))
			lstAvailable.Items.Add(itemString)
		Loop 
	End Sub
	
	Private Sub cmdMoveAll2S_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMoveAll2S.Click
        Dim numberItems As Integer
		Dim itemString As String
		
		numberItems = lstAvailable.Items.Count
		Do Until numberItems = 0
			numberItems = numberItems - 1
			itemString = VB6.GetItemString(lstAvailable, numberItems)
			lstAvailable.Items.RemoveAt((numberItems))
			lstSelected.Items.Add(itemString)
		Loop 
	End Sub
	
	Private Sub cmdMoveOne2A_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMoveOne2A.Click
        Dim numberItems As Integer
		Dim itemString As String
		
		numberItems = lstSelected.Items.Count
		Do Until numberItems = 0
			numberItems = numberItems - 1
			If (lstSelected.GetSelected(numberItems) = True) Then
				itemString = VB6.GetItemString(lstSelected, numberItems)
				lstSelected.Items.RemoveAt((numberItems))
				lstAvailable.Items.Add(itemString)
			End If
		Loop 
	End Sub
	
	Private Sub cmdMoveOne2S_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMoveOne2S.Click
        Dim numberItems As Integer
		Dim itemString As String
		
		numberItems = lstAvailable.Items.Count
		Do Until numberItems = 0
			numberItems = numberItems - 1
			If (lstAvailable.GetSelected(numberItems) = True) Then
				itemString = VB6.GetItemString(lstAvailable, numberItems)
				lstAvailable.Items.RemoveAt((numberItems))
				lstSelected.Items.Add(itemString)
			End If
		Loop 
	End Sub
	
	Public Sub Initialize()
		Dim curveNameIndex As Integer
		Dim curveName As String
		Dim numberCurves As Integer
		
		numberCurves = mAvailableCurves.Count()
		curveNameIndex = 1
		Do Until curveNameIndex > numberCurves
			curveName = mAvailableCurves.Item(curveNameIndex)
			lstAvailable.Items.Add(curveName)
			curveNameIndex = curveNameIndex + 1
		Loop 
		curveNameIndex = 1
		numberCurves = mSelectedCurves.Count()
		Do Until curveNameIndex > numberCurves
			curveName = mSelectedCurves.Item(curveNameIndex)
			lstSelected.Items.Add(curveName)
			curveNameIndex = curveNameIndex + 1
		Loop 
		If (mLoadDataAuto = True) Then
			chkLoadAuto.CheckState = System.Windows.Forms.CheckState.Checked
		Else
			chkLoadAuto.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	Public Sub SetAvailableCurves(ByRef inAvailables As Collection)
		Dim numberCurves As Integer
		Dim curveName As String
		Dim nameIndex As Integer
		
		numberCurves = inAvailables.Count()
		nameIndex = 1
		Do Until nameIndex > numberCurves
			curveName = inAvailables.Item(nameIndex)
			If (Len(curveName) > 0) Then
				mAvailableCurves.Add(curveName)
			End If
			nameIndex = nameIndex + 1
		Loop 
	End Sub
	
	Public Sub SetSelectedCurves(ByRef inSelected As Collection)
		Dim numberCurves As Integer
		Dim curveName As String
		Dim nameIndex As Integer
		
		numberCurves = inSelected.Count()
		nameIndex = 1
		Do Until nameIndex > numberCurves
			curveName = inSelected.Item(nameIndex)
			If (Len(curveName) > 0) Then
				mSelectedCurves.Add(curveName)
			End If
			nameIndex = nameIndex + 1
		Loop 
	End Sub
	
	Public Sub GetSelectedCurves(ByRef outSelected As Collection)
		Dim numberCurves As Integer
		Dim curveName As String
		Dim nameIndex As Integer
		
		numberCurves = mSelectedCurves.Count()
		nameIndex = 1
		Do Until nameIndex > numberCurves
			curveName = mSelectedCurves.Item(nameIndex)
			If (Len(curveName) > 0) Then
				outSelected.Add(curveName)
			End If
			nameIndex = nameIndex + 1
		Loop 
	End Sub
	
	Public Sub GetAvailableCurves(ByRef outAvailable As Collection)
		Dim numberCurves As Integer
		Dim curveName As String
		Dim nameIndex As Integer
		
		numberCurves = mAvailableCurves.Count()
		nameIndex = 1
		Do Until nameIndex > numberCurves
			curveName = mAvailableCurves.Item(nameIndex)
			If (Len(curveName) > 0) Then
				outAvailable.Add(curveName)
			End If
			nameIndex = nameIndex + 1
		Loop 
	End Sub
	
    Private Sub Initialize_frmCurves()
        mSelectedCurves = New Collection
        mAvailableCurves = New Collection
    End Sub
End Class