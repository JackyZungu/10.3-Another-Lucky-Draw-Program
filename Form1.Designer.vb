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
        btnDraw = New Button()
        Label1 = New Label()
        lbName = New Label()
        lbAge = New Label()
        lbLuckyNumber = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        TextBox3 = New TextBox()
        txtOutcome = New TextBox()
        SuspendLayout()
        ' 
        ' btnDraw
        ' 
        btnDraw.Location = New Point(439, 179)
        btnDraw.Name = "btnDraw"
        btnDraw.Size = New Size(118, 40)
        btnDraw.TabIndex = 0
        btnDraw.Text = "Draw"
        btnDraw.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI Emoji", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(164, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(432, 22)
        Label1.TabIndex = 1
        Label1.Text = "Please enter your name, age and draw your lucky"
        ' 
        ' lbName
        ' 
        lbName.AutoSize = True
        lbName.Location = New Point(164, 91)
        lbName.Name = "lbName"
        lbName.Size = New Size(49, 20)
        lbName.TabIndex = 2
        lbName.Text = "Name"
        ' 
        ' lbAge
        ' 
        lbAge.AutoSize = True
        lbAge.Location = New Point(164, 144)
        lbAge.Name = "lbAge"
        lbAge.Size = New Size(36, 20)
        lbAge.TabIndex = 3
        lbAge.Text = "Age"
        ' 
        ' lbLuckyNumber
        ' 
        lbLuckyNumber.AutoSize = True
        lbLuckyNumber.Location = New Point(112, 195)
        lbLuckyNumber.Name = "lbLuckyNumber"
        lbLuckyNumber.Size = New Size(136, 20)
        lbLuckyNumber.TabIndex = 4
        lbLuckyNumber.Text = "Your Lucky Number"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(257, 88)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 5
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(258, 128)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 27)
        txtAge.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(254, 192)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 7
        ' 
        ' txtOutcome
        ' 
        txtOutcome.BackColor = SystemColors.MenuHighlight
        txtOutcome.Location = New Point(204, 290)
        txtOutcome.Name = "txtOutcome"
        txtOutcome.Size = New Size(391, 27)
        txtOutcome.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtOutcome)
        Controls.Add(TextBox3)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(lbLuckyNumber)
        Controls.Add(lbAge)
        Controls.Add(lbName)
        Controls.Add(Label1)
        Controls.Add(btnDraw)
        Name = "Form1"
        Text = "Another Lucky Draw Program"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDraw As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbAge As Label
    Friend WithEvents lbLuckyNumber As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtOutcome As TextBox
End Class
