Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connection As MySqlConnection
    Dim cmd As MySqlCommand
    Dim database_name As New String("experiment2")
    Dim table_name As New String("series")
    Dim IT As Double
    Dim V1 As Double
    Dim V2 As Double
    Dim V3 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if Form1 exist, if it does show it without creating a new one
        Dim mainForm As Form1 = Application.OpenForms.OfType(Of Form1)().FirstOrDefault()
        If mainForm IsNot Nothing Then
            mainForm.ShowMainForm()
        End If
        Me.Close()
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Get values from user input
        Dim R1 As Double = Convert.ToDouble(TextBox1.Text)
        Dim R2 As Double = Convert.ToDouble(TextBox2.Text)
        Dim R3 As Double = Convert.ToDouble(TextBox3.Text)
        Dim Vin As Double = Convert.ToDouble(TextBox4.Text)

        'Update schematic to show values
        Me.R1.Text = R1 & "Ω"
        Me.R2.Text = R2 & "Ω"
        Me.R3.Text = R3 & "Ω"
        Me.VIN.Text = Vin & "V"

        'Calculate the missing values
        Dim RT As Double = R1 + R2 + R3
        IT = Vin / RT
        V1 = IT * R1
        V2 = IT * R2
        V3 = IT * R3

        'Show results
        If V1 < 1 Then
            _V1.Text = "V1 = " & Math.Round((V1 * 1000), 3) & " mV"
        Else
            _V1.Text = "V1 = " & Math.Round(V1, 3) & " V"
        End If

        If V2 < 1 Then
            _V2.Text = "V2 = " & Math.Round((V2 * 1000), 3) & " mV"
        Else
            _V2.Text = "V2 = " & Math.Round(V2, 3) & " V"
        End If

        If V3 < 1 Then
            _V3.Text = "V3 = " & Math.Round((V3 * 1000), 3) & " mV"
        Else
            _V3.Text = "V3 = " & Math.Round(V3, 3) & " V"
        End If

        If IT < 1 Then
            _IT.Text = "IT = " & Math.Round((IT * 1000), 3) & " mA"
        Else
            _IT.Text = "IT = " & Math.Round(IT, 3) & " A"
        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If connection.State = ConnectionState.Closed Then
                MsgBox("Please connect to the database first", vbExclamation, Title:="Warning")
            Else
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                cmd = New MySqlCommand("INSERT INTO " & table_name & "(R1,R2,R3,VIN,V1,V2,V3,IT)
                    values (@R1, @R2, @R3, @VIN, @V1, @V2, @V3, @IT)", connection)
                cmd.Parameters.AddWithValue("@R1", R1.Text)
                cmd.Parameters.AddWithValue("@R2", R2.Text)
                cmd.Parameters.AddWithValue("@R3", R3.Text)
                cmd.Parameters.AddWithValue("@VIN", VIN.Text)
                If V1 < 1 Then
                    cmd.Parameters.AddWithValue("@V1", (Math.Round((V1 * 1000), 3) & "mV"))
                Else
                    cmd.Parameters.AddWithValue("@V1", (Math.Round(V1, 3) & "V"))
                End If

                If V2 < 1 Then
                    cmd.Parameters.AddWithValue("@V2", (Math.Round((V2 * 1000), 3) & "mV"))
                Else
                    cmd.Parameters.AddWithValue("@V2", (Math.Round(V2, 3) & "V"))
                End If

                If V3 < 1 Then
                    cmd.Parameters.AddWithValue("@V3", (Math.Round((V3 * 1000), 3) & "mV"))
                Else
                    cmd.Parameters.AddWithValue("@V3", (Math.Round(V3, 3) & "V"))
                End If

                If IT < 1 Then
                    cmd.Parameters.AddWithValue("@IT", (Math.Round((IT * 1000), 3) & "mA"))
                Else
                    cmd.Parameters.AddWithValue("@IT", (Math.Round(IT, 3) & "A"))
                End If


                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Successfully Added Record To " & table_name & "", vbInformation, Title:="Success")
                Else
                    MsgBox("Failed to Add Record To " & table_name & "", vbExclamation, Title:="Error")
                End If
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class