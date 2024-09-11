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
    Dim calculated As Boolean = False
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
        If String.IsNullOrEmpty(TextBox1.Text) Or
            String.IsNullOrEmpty(TextBox2.Text) Or
            String.IsNullOrEmpty(TextBox3.Text) Or
            String.IsNullOrEmpty(TextBox4.Text) Then
            MsgBox("Please fill in all input fields", vbExclamation, Title:="Warning")
        Else
            Dim R1 As Double = Convert.ToDouble(TextBox1.Text)
            Dim R2 As Double = Convert.ToDouble(TextBox2.Text)
            Dim R3 As Double = Convert.ToDouble(TextBox3.Text)
            Dim Vin As Double = Convert.ToDouble(TextBox4.Text)

            If R1 >= 1000000 Then
                Me.R1.Text = Math.Round((R1 / 1000000), 2) & "MΩ"
            ElseIf R1 >= 1000 Then
                Me.R1.Text = Math.Round((R1 / 1000), 2) & "kΩ"
            Else
                Me.R1.Text = R1 & "Ω"
            End If
            If R2 >= 1000000 Then
                Me.R2.Text = Math.Round((R2 / 1000000), 2) & "MΩ"
            ElseIf R2 >= 1000 Then
                Me.R2.Text = Math.Round((R2 / 1000), 2) & "kΩ"
            Else
                Me.R2.Text = R2 & "Ω"
            End If
            If R3 >= 1000000 Then
                Me.R3.Text = Math.Round((R3 / 1000000), 2) & "MΩ"
            ElseIf R3 >= 1000 Then
                Me.R3.Text = Math.Round((R3 / 1000), 2) & "kΩ"
            Else
                Me.R3.Text = R3 & "Ω"
            End If
            If Vin >= 1000000 Then
                Me.VIN.Text = Math.Round((Vin / 1000000), 2) & "MV"
            ElseIf Vin >= 1000 Then
                Me.R1.Text = Math.Round((Vin / 1000), 2) & "kV"
            Else
                Me.VIN.Text = Vin & "V"
            End If

            I1 = Vin / R1
            I2 = Vin / R2
            I3 = Vin / R3
            IT = I1 + I2 + I3

            If I1 < 0.001 Then
                _I1.Text = "I1 = " & Math.Round(I1 * 1000000, 3) & "µA"
            ElseIf I1 < 1 Then
                _I1.Text = "I1 = " & Math.Round(I1 * 1000, 3) & "mA"
            Else
                _I1.Text = "I1 = " & Math.Round(I1, 3) & "A"
            End If
            If I2 < 0.001 Then
                _I2.Text = "I2 = " & Math.Round(I2 * 1000000, 3) & "µA"
            ElseIf I2 < 1 Then
                _I2.Text = "I2 = " & Math.Round(I2 * 1000, 3) & "mA"
            Else
                _I2.Text = "I2 = " & Math.Round(I2, 3) & "A"
            End If
            If I3 < 0.001 Then
                _I3.Text = "I3 = " & Math.Round(I3 * 1000000, 3) & "µA"
            ElseIf I3 < 1 Then
                _I3.Text = "I3 = " & Math.Round(I3 * 1000, 3) & "mA"
            Else
                _I3.Text = "I3 = " & Math.Round(I3, 3) & "A"
            End If
            If IT < 0.001 Then
                _IT.Text = "IT = " & Math.Round(IT * 1000000, 3) & "µA"
            ElseIf IT < 1 Then
                _IT.Text = "IT = " & Math.Round(IT * 1000, 3) & "mA"
            Else
                _IT.Text = "IT = " & Math.Round(IT, 3) & "A"
            End If
            calculated = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If connection.State = ConnectionState.Closed Then
                MsgBox("Please connect to the database first", vbExclamation, Title:="Warning")
            ElseIf calculated = False Then
                MsgBox("Please calculate first", vbExclamation, Title:="Warning")
            Else
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If
                cmd = New MySqlCommand("INSERT INTO " & table_name & "(R1,R2,R3,VIN,I1,I2,I3,IT)
                    values (@R1, @R2, @R3, @VIN, @I1, @I2, @I3, @IT)", connection)
                cmd.Parameters.AddWithValue("@R1", R1.Text)
                cmd.Parameters.AddWithValue("@R2", R2.Text)
                cmd.Parameters.AddWithValue("@R3", R3.Text)
                cmd.Parameters.AddWithValue("@VIN", VIN.Text)

                If I1 < 0.001 Then
                    cmd.Parameters.AddWithValue("@I1", (Math.Round((I1 * 1000000), 3) & "µA"))
                ElseIf I1 < 1 Then
                    cmd.Parameters.AddWithValue("@I1", (Math.Round((I1 * 1000), 3) & "mA"))
                Else
                    cmd.Parameters.AddWithValue("@I1", (Math.Round(I1, 3) & "A"))
                End If

                If I2 < 0.001 Then
                    cmd.Parameters.AddWithValue("@I2", (Math.Round((I2 * 1000000), 3) & "µA"))
                ElseIf I2 < 1 Then
                    cmd.Parameters.AddWithValue("@I2", (Math.Round((I2 * 1000), 3) & "mA"))
                Else
                    cmd.Parameters.AddWithValue("@I2", (Math.Round(I2, 3) & "A"))
                End If

                If I3 < 0.001 Then
                    cmd.Parameters.AddWithValue("@I3", (Math.Round((I3 * 1000000), 3) & "µA"))
                ElseIf I3 < 1 Then
                    cmd.Parameters.AddWithValue("@I3", (Math.Round((I3 * 1000), 3) & "mA"))
                Else
                    cmd.Parameters.AddWithValue("@I3", (Math.Round(I3, 3) & "A"))
                End If

                If IT < 0.001 Then
                    cmd.Parameters.AddWithValue("@IT", (Math.Round((IT * 1000000), 3) & "µA"))
                ElseIf IT < 1 Then
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
                _I1.Text = "I1 ="
                _I2.Text = "I2 ="
                _I3.Text = "I3 ="
                _IT.Text = "IT ="
                VIN.Text = "V1"
                R1.Text = "R1"
                R2.Text = "R2"
                R3.Text = "R3"
                calculated = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class