Imports System
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace Stock2DChart
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
	Public Class ChartViewModel
		Private privateData As ObservableCollection(Of DataPoint)
		Public Property Data() As ObservableCollection(Of DataPoint)
			Get
				Return privateData
			End Get
			Private Set(ByVal value As ObservableCollection(Of DataPoint))
				privateData = value
			End Set
		End Property
		Public Sub New()
			Data = New ObservableCollection(Of DataPoint) From {
				New DataPoint(New Date(2019,1,1), 25, 28, 24, 27),
				New DataPoint(New Date(2019,1,2), 27, 35, 26, 32),
				New DataPoint(New Date(2019,1,3), 32, 35, 27, 29),
				New DataPoint(New Date(2019,1,4), 29, 37, 29, 36),
				New DataPoint(New Date(2019,1,5), 36, 37, 32, 33)
			}
		End Sub
	End Class
	Public Class DataPoint
		Public Property [Date]() As Date
		Public Property Open() As Double
		Public Property High() As Double
		Public Property Low() As Double
		Public Property Close() As Double
		Public Sub New(ByVal arg As Date, ByVal open As Double, ByVal high As Double, ByVal low As Double, ByVal close As Double)
			Me.Date = arg
			Me.Open = open
			Me.High = high
			Me.Low = low
			Me.Close = close
		End Sub
	End Class
End Namespace
