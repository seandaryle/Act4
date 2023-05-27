Imports System.Windows

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTextBox.Text = "abcd" And PasswordTextBox.Text = "123" Then
            MsgBox("Login Successfully!")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Wrong Username or Password")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If
    End Sub


    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub LoginSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class