'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 25/11/2021
' Time: 12:21
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'Dimensions the arrays and variables needed for use in the program
		Dim player(20) As String
		Dim goal(20) As Int16
		Dim choice As String = ""
		Dim search As String = ""
		Dim updateGoal As Int16 = 0
		Dim newPlayer As String = ""
		Dim newGoal As Int16 = 0
		
		player(1) = "A"
		player(2) = "B"
		player(3) = "C"
		player(4) = "D"
		player(5) = "E"
		player(6) = "F"
		player(7) = "G"
		player(8) = "H"
		player(9) = "I"
		player(10) = "J"

		
		Do Until choice = "q"
			Console.WriteLine("Please enter 1 for displaying names and goal tally, 2 for editing the amount of goals a player has scored, 3 for adding in new players")
			choice = Console.ReadLine()
			If choice = "1" Then
				Console.WriteLine("Player		Goals")
				For c=1 To 20
					If player(c) = "" Then
						
					Else
						Console.WriteLine(player(c) & "		" & goal(c))
					End If
				Next
			End If
			If choice = "2" Then
				Console.WriteLine("Please enter the name of the player to change")
				search = Console.ReadLine()
				For c=1 To 20
					If player(c) = search Then
						Console.WriteLine("Please enter the updated goal tally")
						goal(c) = Console.ReadLine()
					End If
				Next
			End If
			If choice = "3" Then
				For c=1 To 20
					If player(c) = "" Then
						Console.WriteLine("Please enter the name of the new player")
						newPlayer = Console.ReadLine()
						player(c) = newPlayer
						Console.WriteLine("Please enter the goal tally")
						goal(c) = Console.ReadLine()
					End If
				Next
			End If
			If choice = "4" Then
				Console.WriteLine("Please enter the name of the footballer to be deleted")
				search = Console.ReadLine()
				For c=1 To 20
					If player(c) = search Then
						player(c) = ""
						goal(c) = 0
						Console.WriteLine("Player sucessfully deleted")
					End If
				Next
			End If
		Loop
	End Sub
End Module
