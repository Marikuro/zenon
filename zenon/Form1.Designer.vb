<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Форма переопределяет dispose для очистки списка компонентов.
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

	'Является обязательной для конструктора форм Windows Forms
	Private components As System.ComponentModel.IContainer

	'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
	'Для ее изменения используйте конструктор форм Windows Form.  
	'Не изменяйте ее в редакторе исходного кода.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Button3
		'
		Me.Button3.Font = New System.Drawing.Font("Haettenschweiler", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Button3.Location = New System.Drawing.Point(425, 339)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(113, 50)
		Me.Button3.TabIndex = 18
		Me.Button3.Text = "Stop"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.Button2.Location = New System.Drawing.Point(292, 339)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(113, 50)
		Me.Button2.TabIndex = 17
		Me.Button2.Text = "Resume"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.RadioButton1.ForeColor = System.Drawing.Color.Black
		Me.RadioButton1.Location = New System.Drawing.Point(47, 214)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(62, 21)
		Me.RadioButton1.TabIndex = 16
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Switch"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Location = New System.Drawing.Point(29, 148)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 17)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "Turtle Speed"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(29, 67)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(80, 17)
		Me.Label1.TabIndex = 14
		Me.Label1.Text = "Achilles Speed"
		'
		'TextBox2
		'
		Me.TextBox2.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.TextBox2.Location = New System.Drawing.Point(19, 168)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 25)
		Me.TextBox2.TabIndex = 13
		'
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.TextBox1.Location = New System.Drawing.Point(19, 87)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 25)
		Me.TextBox1.TabIndex = 12
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Haettenschweiler", 12.0!)
		Me.Button1.Location = New System.Drawing.Point(159, 339)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(113, 50)
		Me.Button1.TabIndex = 11
		Me.Button1.Text = "Start"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PictureBox1.Location = New System.Drawing.Point(159, 26)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(379, 282)
		Me.PictureBox1.TabIndex = 10
		Me.PictureBox1.TabStop = False
		'
		'Timer1
		'
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(565, 410)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.RadioButton1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "Zenon"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Timer1 As Timer
End Class
