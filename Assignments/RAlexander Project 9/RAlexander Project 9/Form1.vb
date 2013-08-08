Public Class Form1

    

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub AustinToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AustinToolStripMenuItem.Click
        wbMovieList.Visible = True
        wbMovieList.Url = New Uri("http://drafthouse.com/austin")
    End Sub

    Private Sub HoustonToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HoustonToolStripMenuItem.Click
        wbMovieList.Visible = True
        wbMovieList.Url = New Uri("http://drafthouse.com/houston")
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub
End Class
