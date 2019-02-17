'
' Created by SharpDevelop.
' User: Doka
' Date: 18/06/2017
' Time: 00:15
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.label1 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 9)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(60, 16)
		Me.label1.TabIndex = 2
		Me.label1.Text = "FullBright :"
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(72, 6)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(48, 20)
		Me.textBox1.TabIndex = 3
		AddHandler Me.textBox1.TextChanged, AddressOf Me.TextBox1TextChanged
		'
		'timer1
		'
		Me.timer1.Interval = 800
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'label2
		'
		Me.label2.ForeColor = System.Drawing.Color.Red
		Me.label2.Location = New System.Drawing.Point(126, 9)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(76, 16)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Not attached."
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(211, 33)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "MainForm"
		Me.Text = "FullbrightMOD"
		AddHandler FormClosing, AddressOf Me.MainFormFormClosing
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label2 As System.Windows.Forms.Label
	Private timer1 As System.Windows.Forms.Timer
	Private textBox1 As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
End Class
