Imports MySql.Data.MySqlClient

Public Class Form3
    Dim connection As MySqlConnection
    Dim cmd As MySqlCommand
    Dim database_name As New String("experiment2")
    Dim table_name As New String("parallel")
    Dim IT As Double
    Dim I1 As Double
    Dim I2 As Double
    Dim I3 As Double
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mainForm As Form1 = Application.OpenForms.OfType(Of Form1)().FirstOrDefault()
        If mainForm IsNot Nothing Then
            mainForm.ShowMainForm()
        End If
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;username=root;password=;database='" & database_name & "'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
                ConnectionStatus.Text = "Connected"
                ConnectionStatus.ForeColor = Color.Green
                Button4.Text = "Disconnect to Database"
            Else
                connection.Close()
                ConnectionStatus.Text = "Disconnected"
                ConnectionStatus.ForeColor = Color.DarkRed
                Button4.Text = "Connect to Database"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim R1 As Double = Convert.ToDouble(TextBox1.Text)
        Dim R2 As Double = Convert.ToDouble(TextBox2.Text)
        Dim R3 As Double = Convert.ToDouble(TextBox3.Text)
        Dim Vin As Double = Convert.ToDouble(TextBox4.Text)

        Me.R1.Text = R1 & "Ω"
        Me.R2.Text = R2 & "Ω"
        Me.R3.Text = R3 & "Ω"
        Me.VIN.Text = Vin & "V"

        I1 = Vin / R1
        I2 = Vin / R2
        I3 = Vin / R3
        IT = I1 + I2 + I3

        _I1.Text = "I1 = " & Math.Round(I1, 3) & "A"
        _I2.Text = "I2 = " & Math.Round(I2, 3) & "A"
        _I3.Text = "I3 = " & Math.Round(I3, 3) & "A"
        _IT.Text = "IT = " & Math.Round(IT, 3) & "A"
    End Sub
End Class