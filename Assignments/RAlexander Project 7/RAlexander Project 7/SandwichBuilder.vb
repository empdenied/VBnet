Imports RAlexander_Project_7.Sandwich
Public Class SandwichBuilder

    Friend ThisSandwich As Sandwich
    Friend Shared Sandwiches As New List(Of Sandwich)
    Private intSandwichCount As Integer = 0
    Private strCondimentList As String
 



    Friend Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click

        Dim intCondiments = lbCondiments.SelectedItems.Count
        Dim intCount = 0
        For Each item In lbCondiments.SelectedItems
            intCount += 1
            strCondimentList = strCondimentList & item.ToString


            If intCount.Equals(intCondiments) Then
                strCondimentList = strCondimentList & "."
            Else
                strCondimentList = strCondimentList & ", "
            End If
        Next


        ThisSandwich = New Sandwich(tbName.Text.ToString, cbBread.SelectedItem.ToString, cbCheese.SelectedItem.ToString, cbMeat.SelectedItem.ToString, strCondimentList)
        Sandwiches.Add(ThisSandwich)

        tbName.Clear()
        strCondimentList = ""
        cbBread.SelectedIndex = 0
        cbCheese.SelectedIndex = 0
        cbMeat.SelectedIndex = 0
        lbCondiments.ClearSelected()
        lbCondiments.Refresh()
        lbCondiments.SelectedIndex = -1
        tbName.Focus()


    End Sub

    Friend Sub btnList_Click(sender As System.Object, e As System.EventArgs) Handles btnList.Click

        SandwichList.Show()

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class
