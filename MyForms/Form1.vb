Public Class frm

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        btnSubmit.Enabled = True
        MsgBox("Form is clicked")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSubmit.Enabled = False
    End Sub

    Private Sub txtBox_TextChanged(sender As Object, e As EventArgs) Handles txtBox.TextChanged
        txtBox.ForeColor = Color.Red
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MsgBox("Button is clicked")
    End Sub
End Class
