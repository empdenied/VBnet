Imports RAlexander_Project_7.SandwichBuilder
Imports RAlexander_Project_7.Sandwich

Public Class SandwichList
    Dim SandwichMenu() As Sandwich
    Dim intIndex As Integer = 0
    Private Sub SandwichList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each Sandwich In Sandwiches
            Label1.Text = Label1.Text & Sandwiches.Item(intIndex).Ingredients & vbCr & vbCr
            intIndex += 1
        Next




    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class