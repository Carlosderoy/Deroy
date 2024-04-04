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
        SubmitButton = New Button()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        unme = New Label()
        Label2 = New Label()
        ResetButton = New Button()
        ExitButton = New Button()
        ListView1 = New ListView()
        Label1 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' SubmitButton
        ' 
        SubmitButton.AutoSize = True
        SubmitButton.BackColor = SystemColors.ButtonFace
        SubmitButton.Cursor = Cursors.Hand
        SubmitButton.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitButton.ForeColor = SystemColors.ActiveCaptionText
        SubmitButton.Location = New Point(313, 295)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(84, 35)
        SubmitButton.TabIndex = 0
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = False
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(299, 102)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(237, 31)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(299, 202)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(237, 31)
        PasswordTextBox.TabIndex = 2
        ' 
        ' unme
        ' 
        unme.AutoSize = True
        unme.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        unme.Location = New Point(174, 108)
        unme.Name = "unme"
        unme.Size = New Size(107, 25)
        unme.TabIndex = 3
        unme.Text = "Username :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(174, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 25)
        Label2.TabIndex = 4
        Label2.Text = "Password :"
        ' 
        ' ResetButton
        ' 
        ResetButton.AutoSize = True
        ResetButton.BackColor = SystemColors.ControlLightLight
        ResetButton.Cursor = Cursors.Hand
        ResetButton.ForeColor = SystemColors.ActiveCaptionText
        ResetButton.Location = New Point(174, 295)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(84, 35)
        ResetButton.TabIndex = 5
        ResetButton.Text = "Reset"
        ResetButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.AutoSize = True
        ExitButton.BackColor = SystemColors.ControlLightLight
        ExitButton.Cursor = Cursors.Hand
        ExitButton.ForeColor = SystemColors.ActiveCaptionText
        ExitButton.Location = New Point(452, 295)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(84, 35)
        ExitButton.TabIndex = 6
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(108, 63)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(517, 341)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Font = New Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(315, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 51)
        Label1.TabIndex = 8
        Label1.Text = "Login"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Goudy Old Style", 11F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(498, 367)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 25)
        Label3.TabIndex = 9
        Label3.Text = "mywork.com"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(738, 486)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(ExitButton)
        Controls.Add(ResetButton)
        Controls.Add(Label2)
        Controls.Add(unme)
        Controls.Add(PasswordTextBox)
        Controls.Add(UsernameTextBox)
        Controls.Add(SubmitButton)
        Controls.Add(ListView1)
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents unme As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label

End Class
