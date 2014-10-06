<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtSideOne = New System.Windows.Forms.TextBox()
        Me.txtSideTwo = New System.Windows.Forms.TextBox()
        Me.txtHyp = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(46, 21)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(95, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Length of one side"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(39, 44)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(101, 13)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Length of other side"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(29, 174)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(112, 13)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "Length of Hypotenuse"
        '
        'txtSideOne
        '
        Me.txtSideOne.Location = New System.Drawing.Point(145, 19)
        Me.txtSideOne.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSideOne.Name = "txtSideOne"
        Me.txtSideOne.Size = New System.Drawing.Size(103, 20)
        Me.txtSideOne.TabIndex = 3
        '
        'txtSideTwo
        '
        Me.txtSideTwo.Location = New System.Drawing.Point(145, 41)
        Me.txtSideTwo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSideTwo.Name = "txtSideTwo"
        Me.txtSideTwo.Size = New System.Drawing.Size(103, 20)
        Me.txtSideTwo.TabIndex = 4
        '
        'txtHyp
        '
        Me.txtHyp.Location = New System.Drawing.Point(145, 171)
        Me.txtHyp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHyp.Name = "txtHyp"
        Me.txtHyp.ReadOnly = True
        Me.txtHyp.Size = New System.Drawing.Size(103, 20)
        Me.txtHyp.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(74, 99)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(140, 24)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Hypotenuse"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 217)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtHyp)
        Me.Controls.Add(Me.txtSideTwo)
        Me.Controls.Add(Me.txtSideOne)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Right Triangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents txtSideOne As System.Windows.Forms.TextBox
    Friend WithEvents txtSideTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtHyp As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
