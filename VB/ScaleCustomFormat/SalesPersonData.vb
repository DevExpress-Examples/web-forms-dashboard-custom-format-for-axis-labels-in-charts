Imports System
Imports System.Collections.Generic

Namespace ScaleCustomFormat
	Public Class SalesPersonData
		Public Property SalesPerson() As String
		Public Property Revenue() As Double

		Public Shared Function CreateData() As List(Of SalesPersonData)
			Dim salesPersons() As String = { "Andrew Fuller", "Michael Suyama", "Robert King", "Nancy Davolio", "Margaret Peacock", "Laura Callahan", "Steven Buchanan", "Janet Leverling" }
			Dim data As New List(Of SalesPersonData)()
			Dim rnd = New Random()
			For i As Integer = 0 To 99
				Dim record As New SalesPersonData()
				record.SalesPerson = salesPersons(rnd.Next(0, salesPersons.Length))
				record.Revenue = rnd.Next(0, 100000) / 100.0
				data.Add(record)
			Next i
			Return data
		End Function
	End Class
End Namespace