<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VIN = New System.Windows.Forms.Label()
        Me.R1 = New System.Windows.Forms.Label()
        Me.R2 = New System.Windows.Forms.Label()
        Me.R3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me._IT = New System.Windows.Forms.Label()
        Me._V1 = New System.Windows.Forms.Label()
        Me._V3 = New System.Windows.Forms.Label()
        Me._V2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ConnectionStatus = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(6, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 59)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(89, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(420, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Orange
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SERIES CIRCUIT"
        '
        'VIN
        '
        Me.VIN.AutoSize = True
        Me.VIN.BackColor = System.Drawing.Color.White
        Me.VIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIN.Location = New System.Drawing.Point(123, 144)
        Me.VIN.Name = "VIN"
        Me.VIN.Size = New System.Drawing.Size(36, 20)
        Me.VIN.TabIndex = 3
        Me.VIN.Text = "VIN"
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.BackColor = System.Drawing.Color.White
        Me.R1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.Location = New System.Drawing.Point(299, 63)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(30, 20)
        Me.R1.TabIndex = 4
        Me.R1.Text = "R1"
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.BackColor = System.Drawing.Color.White
        Me.R2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2.Location = New System.Drawing.Point(455, 144)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(30, 20)
        Me.R2.TabIndex = 5
        Me.R2.Text = "R2"
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.BackColor = System.Drawing.Color.White
        Me.R3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R3.Location = New System.Drawing.Point(299, 239)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(30, 20)
        Me.R3.TabIndex = 6
        Me.R3.Text = "R3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(89, 363)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "R1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 396)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "R2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "R3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 462)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "VIN"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(89, 396)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(171, 20)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(89, 429)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(171, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(89, 462)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(171, 20)
        Me.TextBox4.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me._IT)
        Me.Panel1.Controls.Add(Me._V1)
        Me.Panel1.Controls.Add(Me._V3)
        Me.Panel1.Controls.Add(Me._V2)
        Me.Panel1.Location = New System.Drawing.Point(290, 352)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 142)
        Me.Panel1.TabIndex = 15
        '
        '_IT
        '
        Me._IT.AutoSize = True
        Me._IT.BackColor = System.Drawing.Color.Transparent
        Me._IT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IT.Location = New System.Drawing.Point(18, 107)
        Me._IT.Name = "_IT"
        Me._IT.Size = New System.Drawing.Size(36, 20)
        Me._IT.TabIndex = 21
        Me._IT.Text = "IT ="
        '
        '_V1
        '
        Me._V1.AutoSize = True
        Me._V1.BackColor = System.Drawing.Color.Transparent
        Me._V1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._V1.Location = New System.Drawing.Point(8, 10)
        Me._V1.Name = "_V1"
        Me._V1.Size = New System.Drawing.Size(46, 20)
        Me._V1.TabIndex = 18
        Me._V1.Text = "V1 = "
        '
        '_V3
        '
        Me._V3.AutoSize = True
        Me._V3.BackColor = System.Drawing.Color.Transparent
        Me._V3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._V3.Location = New System.Drawing.Point(12, 74)
        Me._V3.Name = "_V3"
        Me._V3.Size = New System.Drawing.Size(42, 20)
        Me._V3.TabIndex = 20
        Me._V3.Text = "V3 ="
        '
        '_V2
        '
        Me._V2.AutoSize = True
        Me._V2.BackColor = System.Drawing.Color.Transparent
        Me._V2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._V2.Location = New System.Drawing.Point(12, 43)
        Me._V2.Name = "_V2"
        Me._V2.Size = New System.Drawing.Size(42, 20)
        Me._V2.TabIndex = 19
        Me._V2.Text = "V2 ="
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 41)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "CALCULATE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(399, 507)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 41)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "SAVE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(249, 275)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 41)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Connect To" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Database" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ConnectionStatus
        '
        Me.ConnectionStatus.AutoSize = True
        Me.ConnectionStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.ConnectionStatus.Location = New System.Drawing.Point(263, 319)
        Me.ConnectionStatus.Name = "ConnectionStatus"
        Me.ConnectionStatus.Size = New System.Drawing.Size(73, 13)
        Me.ConnectionStatus.TabIndex = 19
        Me.ConnectionStatus.Text = "Disconnected"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
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
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Series Circuit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents VIN As Label
    Friend WithEvents R1 As Label
    Friend WithEvents R2 As Label
    Friend WithEvents R3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents _IT As Label
    Friend WithEvents _V3 As Label
    Friend WithEvents _V2 As Label
    Friend WithEvents _V1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ConnectionStatus As Label
End Class
