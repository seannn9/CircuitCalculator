<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ConnectionStatus = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._IT = New System.Windows.Forms.Label()
        Me._I1 = New System.Windows.Forms.Label()
        Me._I3 = New System.Windows.Forms.Label()
        Me._I2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VIN = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Label()
        Me.R2 = New System.Windows.Forms.Label()
        Me.R3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectionStatus
        '
        Me.ConnectionStatus.AutoSize = True
        Me.ConnectionStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.ConnectionStatus.Location = New System.Drawing.Point(278, 319)
        Me.ConnectionStatus.Name = "ConnectionStatus"
        Me.ConnectionStatus.Size = New System.Drawing.Size(73, 13)
        Me.ConnectionStatus.TabIndex = 39
        Me.ConnectionStatus.Text = "Disconnected"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(264, 275)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 41)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Connect To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Database" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(414, 507)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 41)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 41)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "CALCULATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me._IT)
        Me.Panel1.Controls.Add(Me._I1)
        Me.Panel1.Controls.Add(Me._I3)
        Me.Panel1.Controls.Add(Me._I2)
        Me.Panel1.Location = New System.Drawing.Point(305, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 142)
        Me.Panel1.TabIndex = 35
        '
        '_IT
        '
        Me._IT.AutoSize = True
        Me._IT.BackColor = System.Drawing.Color.Transparent
        Me._IT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IT.Location = New System.Drawing.Point(15, 107)
        Me._IT.Name = "_IT"
        Me._IT.Size = New System.Drawing.Size(36, 20)
        Me._IT.TabIndex = 21
        Me._IT.Text = "IT ="
        '
        '_I1
        '
        Me._I1.AutoSize = True
        Me._I1.BackColor = System.Drawing.Color.Transparent
        Me._I1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._I1.Location = New System.Drawing.Point(15, 10)
        Me._I1.Name = "_I1"
        Me._I1.Size = New System.Drawing.Size(40, 20)
        Me._I1.TabIndex = 18
        Me._I1.Text = "I1 = "
        '
        '_I3
        '
        Me._I3.AutoSize = True
        Me._I3.BackColor = System.Drawing.Color.Transparent
        Me._I3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._I3.Location = New System.Drawing.Point(15, 74)
        Me._I3.Name = "_I3"
        Me._I3.Size = New System.Drawing.Size(36, 20)
        Me._I3.TabIndex = 20
        Me._I3.Text = "I3 ="
        '
        '_I2
        '
        Me._I2.AutoSize = True
        Me._I2.BackColor = System.Drawing.Color.Transparent
        Me._I2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._I2.Location = New System.Drawing.Point(15, 43)
        Me._I2.Name = "_I2"
        Me._I2.Size = New System.Drawing.Size(36, 20)
        Me._I2.TabIndex = 19
        Me._I2.Text = "I2 ="
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(104, 462)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(171, 20)
        Me.TextBox4.TabIndex = 34
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(104, 429)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(171, 20)
        Me.TextBox3.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(104, 396)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(171, 20)
        Me.TextBox2.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 462)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "VIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "R3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "R2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "R1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 363)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 27
        '
        'VIN
        '
        Me.VIN.AutoSize = True
        Me.VIN.BackColor = System.Drawing.Color.White
        Me.VIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIN.Location = New System.Drawing.Point(116, 144)
        Me.VIN.Name = "VIN"
        Me.VIN.Size = New System.Drawing.Size(36, 20)
        Me.VIN.TabIndex = 23
        Me.VIN.Text = "VIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Orange
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 34)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "PARALLEL CIRCUIT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(104, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(420, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(12, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 59)
        Me.Button5.TabIndex = 20
        Me.Button5.UseVisualStyleBackColor = False
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.BackColor = System.Drawing.Color.White
        Me.R1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.Location = New System.Drawing.Point(321, 176)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(30, 20)
        Me.R1.TabIndex = 24
        Me.R1.Text = "R1"
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.BackColor = System.Drawing.Color.White
        Me.R2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2.Location = New System.Drawing.Point(399, 176)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(30, 20)
        Me.R2.TabIndex = 25
        Me.R2.Text = "R2"
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.BackColor = System.Drawing.Color.White
        Me.R3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R3.Location = New System.Drawing.Point(470, 176)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(30, 20)
        Me.R3.TabIndex = 26
        Me.R3.Text = "R3"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 551)
        Me.Controls.Add(Me.ConnectionStatus)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.VIN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConnectionStatus As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _IT As Label
    Friend WithEvents _I1 As Label
    Friend WithEvents _I3 As Label
    Friend WithEvents _I2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents VIN As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents R1 As Label
    Friend WithEvents R2 As Label
    Friend WithEvents R3 As Label
End Class
