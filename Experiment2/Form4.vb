Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form4
    Dim connection As MySqlConnection
    Dim cmd As MySqlCommand
    Dim database_name As New String("experiment2")
    Dim table_name As New String("seriesparallel")
    Dim VR1 As Double
    Dim VR2 As Double
    Dim I1 As Double
    Dim I2 As Double
    Dim I3 As Double
    Dim calculated As Boolean = False

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;username=root;password=;database='" & database_name & "'"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mainForm As Form1 = Application.OpenForms.OfType(Of Form1)().FirstOrDefault()
        If mainForm IsNot Nothing Then
            mainForm.ShowMainForm()
        End If
        Me.Close()
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
            If VR1 >= 1000000 Then
                Me.VIN.Text = Math.Round((Vin / 1000000), 2) & "MV"
            ElseIf Vin >= 1000 Then
                Me.R1.Text = Math.Round((Vin / 1000), 2) & "kV"
            Else
                Me.VIN.Text = Vin & "V"
            End If

            Dim RP As Double = (1 / ((1 / R2) + (1 / R3)))
            Dim RT As Double = R1 + RP

            I1 = Vin / RT
            I2 = I1 * (R3 / (R2 + R3))
            I3 = I1 * (R2 / (R2 + R3))
            VR1 = I1 * R1
            VR2 = Vin - VR1


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
            If VR1 < 0.001 Then
                _VR1.Text = "VR1 = " & Math.Round(VR1 * 1000000, 3) & "µV"
            ElseIf VR1 < 1 Then
                _VR1.Text = "VR1 = " & Math.Round(VR1 * 1000, 3) & "mV"
            Else
                _VR1.Text = "VR1 = " & Math.Round(VR1, 3) & "V"
            End If
            If VR2 < 0.001 Then
                _VR2.Text = "VR2 = " & Math.Round(VR2 * 1000000, 3) & "µV"
            ElseIf VR2 < 1 Then
                _VR2.Text = "VR2 = " & Math.Round(VR2 * 1000, 3) & "mV"
            Else
                _VR2.Text = "VR2 = " & Math.Round(VR2, 3) & "V"
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
                cmd = New MySqlCommand("INSERT INTO " & table_name & "(R1,R2,R3,VIN,I1,I2,I3,VR1,VR2)
                    values (@R1, @R2, @R3, @VIN, @I1, @I2, @I3, @VR1, @VR2)", connection)
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

                If VR1 < 0.001 Then
                    cmd.Parameters.AddWithValue("@VR1", (Math.Round((VR1 * 1000000), 3) & "µV"))
                ElseIf VR1 < 1 Then
                    cmd.Parameters.AddWithValue("@VR1", (Math.Round((VR1 * 1000), 3) & "mV"))
                Else
                    cmd.Parameters.AddWithValue("@VR1", (Math.Round(VR1, 3) & "V"))
                End If

                If VR2 < 0.001 Then
                    cmd.Parameters.AddWithValue("@VR2", (Math.Round((VR2 * 1000000), 3) & "µV"))
                ElseIf VR2 < 1 Then
                    cmd.Parameters.AddWithValue("@VR2", (Math.Round((VR2 * 1000), 3) & "mV"))
                Else
                    cmd.Parameters.AddWithValue("@VR2", (Math.Round(VR2, 3) & "V"))
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
                _VR1.Text = "VR1 ="
                _VR2.Text = "VR2 ="
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