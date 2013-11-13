Public Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Friend Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        Dim intTotalBilled As Integer

        lblAddress.Text = tbAddress.Text
        If cbAwards.Checked = True Then
            lblCeremony.Text = "YES"
            intTotalBilled = CInt(ddTickets.SelectedValue) * 25
        Else
            lblCeremony.Text = "NO"
            intTotalBilled = CInt(ddTickets.SelectedValue) * 15
        End If
        lblTickets.Text = ddTickets.SelectedValue
        lblTotalBilled.Text = intTotalBilled.ToString
        UpdatePanel1.Visible = True
        UpdatePanel1.Focus()

    End Sub
End Class