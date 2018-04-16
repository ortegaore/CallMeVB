Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        TextBox1.Text = Me.PerformanceCounter1.MachineName

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class
