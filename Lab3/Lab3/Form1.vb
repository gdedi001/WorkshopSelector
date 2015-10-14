Public Class Form1
	' Create array to hold the names of each workshop
	Dim workshops() As String = {"Handling Stress",
								 "Time Management",
								 "Supervision Skills",
								 "Negotation",
								 "How to Interview"}

	' Create array to hold the registration fee for each workshop
	Dim workshopFees() As Integer = {595, 695, 995, 1295, 395}

	' Create array to hold the number of days for each workshop
	Dim workshopDays() As Integer = {3, 3, 3, 5, 1}

	' Create array to hold the names of each location
	Dim wrkshpLocation() As String = {"Austin",
									  "Chicago",
									  "Dallas",
									  "Orlando",
									  "Pheonix",
									  "Raleigh"}

	' Create array to hold the corresponding daily lodging fee for each location 
	Dim locationFees() As Integer = {95, 125, 110, 100, 92, 90}

	' Declare variable to hold the total for the current workshop with desired location
	Dim workshopTotal As Integer
	' Declare variable to hold the absolute total of all workshops and corresponding locations that the client has selected
	Dim finalTotal As Integer

	Private Sub btnAddWrkshp_Click(sender As Object, e As EventArgs) Handles btnAddWrkshp.Click

		' Declare variables to hold names of workshop and its corresponding values
		Dim workshopName As String
		Dim workshopFee As Integer
		Dim workshopNum As Integer
		' Declare variable to hold the daily lodging fee for clients desired location
		Dim locationName As String
		Dim locationFee As Integer

		' Determine which workshop the client has selected and assign the name/fee of workshop and the number of days 
		' each workshop takes to complete
		For i As Integer = 0 To workshops.Length() - 1
			If lstWrkshp.Text = workshops(i) Then
				workshopName = workshops(i)
				workshopFee = workshopFees(i)
				workshopNum = workshopDays(i)
			End If
		Next

		' Determine which location the client has selected and assign locationFee to the lodging fee of the chosen location
		For x As Integer = 0 To wrkshpLocation.Length() - 1
			If lstLocation.Text = wrkshpLocation(x) Then
				locationName = wrkshpLocation(x)
				locationFee = locationFees(x)
			End If
		Next

		' Compute the necessary calculations based on the clients chosen values.
		workshopTotal = workshopFee + (locationFee * workshopNum)

		' If the required information is unselected or null, alert the client ELSE update final total and add items to list box.
		If lstWrkshp.Text = Nothing Then
			lblStatus.Text = "Please select a workshop."

		ElseIf lstLocation.Text = Nothing Then
			lblStatus.Text = "Please select a location for the workshop."

		Else
			lstSelWrkshp.Items.Add(workshopName & " in " & locationName & " = " & workshopTotal.ToString("c"))
			finalTotal += workshopTotal
		End If

		lblTotal.Text = finalTotal.ToString("c")

	End Sub

	' Removes the selected item from the selected workshop listBox
	Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

		' Create variable that holds the clients selected workshop to remove and use substring to obtain the dollar amount
		Dim selected = lstSelWrkshp.Text.Substring(lstSelWrkshp.Text.IndexOf("$") + 1).Replace(".00", "")

		' If the selected amount contains a comma, remove the comma so that TryParse can work properly
		If selected.Contains(",") Then
			selected = selected.Replace(",", "")
		End If

		' Get the string workshop value and parse it as Integer
		Dim removedAmount As Integer
		Integer.TryParse(selected, removedAmount)


		If selected = "" Then
			lblStatus.Text = "Please select a workshop to remove."
		Else
			lblStatus.Text = "Workshop has been removed. Please view total."
		End If

		' Remove the selected item from the listBox
		lstSelWrkshp.Items.Remove(lstSelWrkshp.SelectedItem)

		' Update the new final total
		finalTotal -= removedAmount

		' Update the total label with new final total
		lblTotal.Text = finalTotal.ToString("c")

	End Sub

	' Resets everything on the form
	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

		' Clear all list boxes
		lstWrkshp.ClearSelected()
		lstLocation.ClearSelected()
		lstSelWrkshp.Items.Clear()
		' Clear the label holding the final total 
		lblTotal.Text = ""
		' Clear the Status Label
		lblStatus.Text = ""

		' Reset the integer values for the current workshop and final total
		workshopTotal = 0
		finalTotal = 0

	End Sub

	' Closes the form when the client clicks Exit button
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

End Class
