<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculator
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
        Me.btnpoint = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnlogarithm = New System.Windows.Forms.Button()
        Me.btntangent = New System.Windows.Forms.Button()
        Me.btnCosine = New System.Windows.Forms.Button()
        Me.btnsine = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btncleareverything = New System.Windows.Forms.Button()
        Me.btndivide = New System.Windows.Forms.Button()
        Me.btnmultiply = New System.Windows.Forms.Button()
        Me.btnsubtract = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnpoint
        '
        Me.btnpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpoint.Location = New System.Drawing.Point(408, 131)
        Me.btnpoint.Name = "btnpoint"
        Me.btnpoint.Size = New System.Drawing.Size(50, 32)
        Me.btnpoint.TabIndex = 46
        Me.btnpoint.Text = "."
        Me.btnpoint.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(117, 206)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(31, 28)
        Me.btnclear.TabIndex = 45
        Me.btnclear.Text = "C"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnlogarithm
        '
        Me.btnlogarithm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogarithm.Location = New System.Drawing.Point(408, 88)
        Me.btnlogarithm.Name = "btnlogarithm"
        Me.btnlogarithm.Size = New System.Drawing.Size(50, 32)
        Me.btnlogarithm.TabIndex = 44
        Me.btnlogarithm.Text = "Log"
        Me.btnlogarithm.UseVisualStyleBackColor = True
        '
        'btntangent
        '
        Me.btntangent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntangent.Location = New System.Drawing.Point(340, 167)
        Me.btntangent.Name = "btntangent"
        Me.btntangent.Size = New System.Drawing.Size(50, 32)
        Me.btntangent.TabIndex = 43
        Me.btntangent.Text = "Tan"
        Me.btntangent.UseVisualStyleBackColor = True
        '
        'btnCosine
        '
        Me.btnCosine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCosine.Location = New System.Drawing.Point(340, 130)
        Me.btnCosine.Name = "btnCosine"
        Me.btnCosine.Size = New System.Drawing.Size(50, 32)
        Me.btnCosine.TabIndex = 42
        Me.btnCosine.Text = "Cos"
        Me.btnCosine.UseVisualStyleBackColor = True
        '
        'btnsine
        '
        Me.btnsine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsine.Location = New System.Drawing.Point(340, 88)
        Me.btnsine.Name = "btnsine"
        Me.btnsine.Size = New System.Drawing.Size(50, 32)
        Me.btnsine.TabIndex = 41
        Me.btnsine.Text = "Sin"
        Me.btnsine.UseVisualStyleBackColor = True
        '
        'btncalculate
        '
        Me.btncalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(340, 209)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(50, 29)
        Me.btncalculate.TabIndex = 40
        Me.btncalculate.Text = "="
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'btncleareverything
        '
        Me.btncleareverything.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncleareverything.Location = New System.Drawing.Point(210, 208)
        Me.btncleareverything.Name = "btncleareverything"
        Me.btncleareverything.Size = New System.Drawing.Size(49, 30)
        Me.btncleareverything.TabIndex = 39
        Me.btncleareverything.Text = " CE"
        Me.btncleareverything.UseVisualStyleBackColor = True
        '
        'btndivide
        '
        Me.btndivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndivide.Location = New System.Drawing.Point(286, 208)
        Me.btndivide.Name = "btndivide"
        Me.btndivide.Size = New System.Drawing.Size(28, 24)
        Me.btndivide.TabIndex = 38
        Me.btndivide.Text = "/"
        Me.btndivide.UseVisualStyleBackColor = True
        '
        'btnmultiply
        '
        Me.btnmultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiply.Location = New System.Drawing.Point(286, 171)
        Me.btnmultiply.Name = "btnmultiply"
        Me.btnmultiply.Size = New System.Drawing.Size(28, 24)
        Me.btnmultiply.TabIndex = 37
        Me.btnmultiply.Text = "*"
        Me.btnmultiply.UseVisualStyleBackColor = True
        '
        'btnsubtract
        '
        Me.btnsubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubtract.Location = New System.Drawing.Point(286, 131)
        Me.btnsubtract.Name = "btnsubtract"
        Me.btnsubtract.Size = New System.Drawing.Size(28, 32)
        Me.btnsubtract.TabIndex = 36
        Me.btnsubtract.Text = "-"
        Me.btnsubtract.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(286, 87)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(28, 32)
        Me.btnadd.TabIndex = 35
        Me.btnadd.Text = "+"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtdisplay
        '
        Me.txtdisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisplay.Location = New System.Drawing.Point(119, 25)
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(195, 26)
        Me.txtdisplay.TabIndex = 34
        Me.txtdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(164, 210)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(30, 23)
        Me.btn0.TabIndex = 33
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(210, 171)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(28, 23)
        Me.btn9.TabIndex = 32
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(163, 171)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(29, 23)
        Me.btn8.TabIndex = 31
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(119, 171)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(29, 23)
        Me.btn7.TabIndex = 30
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(210, 130)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(28, 23)
        Me.btn6.TabIndex = 29
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(164, 130)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(28, 23)
        Me.btn5.TabIndex = 28
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(119, 131)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(29, 23)
        Me.btn4.TabIndex = 27
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(210, 87)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(28, 23)
        Me.btn3.TabIndex = 26
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(163, 88)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(29, 23)
        Me.btn2.TabIndex = 25
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(119, 88)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(29, 23)
        Me.btn1.TabIndex = 24
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 262)
        Me.Controls.Add(Me.btnpoint)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnlogarithm)
        Me.Controls.Add(Me.btntangent)
        Me.Controls.Add(Me.btnCosine)
        Me.Controls.Add(Me.btnsine)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.btncleareverything)
        Me.Controls.Add(Me.btndivide)
        Me.Controls.Add(Me.btnmultiply)
        Me.Controls.Add(Me.btnsubtract)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtdisplay)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnpoint As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnlogarithm As System.Windows.Forms.Button
    Friend WithEvents btntangent As System.Windows.Forms.Button
    Friend WithEvents btnCosine As System.Windows.Forms.Button
    Friend WithEvents btnsine As System.Windows.Forms.Button
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents btncleareverything As System.Windows.Forms.Button
    Friend WithEvents btndivide As System.Windows.Forms.Button
    Friend WithEvents btnmultiply As System.Windows.Forms.Button
    Friend WithEvents btnsubtract As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtdisplay As System.Windows.Forms.TextBox
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
End Class
