Public Class Form2

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        System.Diagnostics.Process.Start("shutdown", "-s -t 5")
    End Sub
End Class