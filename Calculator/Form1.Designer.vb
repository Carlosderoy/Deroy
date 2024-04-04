<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label_num1 = New Label()
        Label_num2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label_num1
        ' 
        Label_num1.AutoSize = True
        Label_num1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_num1.Location = New Point(64, 46)
        Label_num1.Name = "Label_num1"
        Label_num1.Size = New Size(217, 45)
        Label_num1.TabIndex = 0
        Label_num1.Text = "First Number"
        ' 
        ' Label_num2
        ' 
        Label_num2.AutoSize = True
        Label_num2.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label_num2.Location = New Point(64, 184)
        Label_num2.Name = "Label_num2"
        Label_num2.Size = New Size(261, 45)
        Label_num2.TabIndex = 1
        Label_num2.Text = "Second Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(70, 94)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(211, 50)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(70, 234)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(255, 50)
        TextBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(70, 328)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 55)
        Button1.TabIndex = 4
        Button1.Text = "Results"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label_num2)
        Controls.Add(Label_num1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_num1 As Label
    Friend WithEvents Label_num2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button

End Class
