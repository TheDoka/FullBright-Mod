'
' Created by SharpDevelop.
' User: Doka
' Date: 18/06/2017
' Time: 00:15
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

     
     
Public Partial Class MainForm
	Enum FsModifiers
        None = 0 'aucune touche
        Alt = 1
        end Enum
    Declare Auto Function RegisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer, ByVal fsModifier As FsModifiers, ByVal vk As Keys) As Boolean
    Declare Auto Function UnregisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer) As Integer
    Private Const HOTKEY_ID1 As Integer = 571584
    Private Const WM_HOTKEY As Integer = 786
    Dim process = "iw4x"
    Dim actived As Boolean = 0 
    
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	
	Sub TextBox1TextChanged(sender As Object, e As EventArgs)
		If textBox1.Text.Length >=1 Then 
			ReadWritingMemory.writelong(process,&H6FABDF4,textbox1.text)
		End If
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		RegisterHotKey(Me.Handle, HOTKEY_ID1, FsModifiers.Alt, Keys.A)
		SetProcessName(process)
		timer1.Start		
	End Sub
	
	   Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg 
            Case WM_HOTKEY
                If m.WParam = HOTKEY_ID1 Then
                	
                	If actived = False Then 
                		WriteLong(process,(&H6FABDF4),9)
                		actived = True
                	ElseIf actived = True Then
                		WriteLong(process,(&H6FABDF4),4)
                		actived = False
                	End If
                	
                	End if
        End Select
        MyBase.WndProc(m)
    End Sub
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
		If UpdateProcessHandle() Then 
			label2.Text = "Attached."
			label2.ForeColor = Color.Green
			textBox1.text = ReadWritingMemory.ReadLong(process,&H6FABDF4,4)
		Else
			label2.Text = "Not attached."
			label2.ForeColor = Color.Red
		End If		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
	End Sub
	
	
	Sub MainFormFormClosing(sender As Object, e As FormClosingEventArgs)
		UnregisterHotKey(0,HOTKEY_ID1)
	End Sub
End Class
