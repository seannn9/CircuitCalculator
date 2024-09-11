Imports MySql.Data.MySqlClient
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim seriesForm As New Form2()
        seriesForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim parallelForm As New Form3()
        parallelForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seriesParallelForm As New Form4()
        seriesParallelForm.Show()
        Me.Hide()
    End Sub

    Public Sub ShowMainForm()
        Me.Show()
        Me.Activate()
    End Sub


End Class
