<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Me.lblitemid = New System.Windows.Forms.Label()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblammountavailable = New System.Windows.Forms.Label()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.Itempic = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttelephone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.cbodelivery = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtnationalid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtresidence = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpostaladdress = New System.Windows.Forms.TextBox()
        Me.btnorder = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Itempic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblitemid
        '
        Me.lblitemid.AutoSize = True
        Me.lblitemid.Location = New System.Drawing.Point(6, 43)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(38, 13)
        Me.lblitemid.TabIndex = 0
        Me.lblitemid.Text = "ItemID"
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.Location = New System.Drawing.Point(6, 16)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(49, 13)
        Me.lblcategory.TabIndex = 2
        Me.lblcategory.Text = "Category"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(240, 55)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(55, 13)
        Me.lblname.TabIndex = 3
        Me.lblname.Text = "ItemName"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(6, 70)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(31, 13)
        Me.lblprice.TabIndex = 4
        Me.lblprice.Text = "Price"
        '
        'lblammountavailable
        '
        Me.lblammountavailable.AutoSize = True
        Me.lblammountavailable.Location = New System.Drawing.Point(6, 96)
        Me.lblammountavailable.Name = "lblammountavailable"
        Me.lblammountavailable.Size = New System.Drawing.Size(94, 13)
        Me.lblammountavailable.TabIndex = 5
        Me.lblammountavailable.Text = "AmmountAvailable"
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.Location = New System.Drawing.Point(6, 129)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(60, 13)
        Me.lbldescription.TabIndex = 6
        Me.lbldescription.Text = "Description"
        '
        'txtitemname
        '
        Me.txtitemname.Location = New System.Drawing.Point(324, 52)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(100, 20)
        Me.txtitemname.TabIndex = 9
        '
        'Itempic
        '
        Me.Itempic.Location = New System.Drawing.Point(460, 55)
        Me.Itempic.Name = "Itempic"
        Me.Itempic.Size = New System.Drawing.Size(183, 201)
        Me.Itempic.TabIndex = 10
        Me.Itempic.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblcategory)
        Me.GroupBox1.Controls.Add(Me.lblitemid)
        Me.GroupBox1.Controls.Add(Me.lblprice)
        Me.GroupBox1.Controls.Add(Me.lbldescription)
        Me.GroupBox1.Controls.Add(Me.lblammountavailable)
        Me.GroupBox1.Location = New System.Drawing.Point(243, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 205)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ItemDetails"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(77, 127)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Telephone"
        '
        'txttelephone
        '
        Me.txttelephone.Location = New System.Drawing.Point(77, 93)
        Me.txttelephone.Name = "txttelephone"
        Me.txttelephone.Size = New System.Drawing.Size(100, 20)
        Me.txttelephone.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Name"
        '
        'Txtfirstname
        '
        Me.Txtfirstname.Location = New System.Drawing.Point(77, 64)
        Me.Txtfirstname.Name = "Txtfirstname"
        Me.Txtfirstname.Size = New System.Drawing.Size(100, 20)
        Me.Txtfirstname.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Delivery"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 20
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(77, 29)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(100, 20)
        Me.txtcustomerid.TabIndex = 21
        '
        'cbodelivery
        '
        Me.cbodelivery.FormattingEnabled = True
        Me.cbodelivery.Items.AddRange(New Object() {"Direct residence", "Through Poastal"})
        Me.cbodelivery.Location = New System.Drawing.Point(77, 221)
        Me.cbodelivery.Name = "cbodelivery"
        Me.cbodelivery.Size = New System.Drawing.Size(100, 21)
        Me.cbodelivery.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(511, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "ItemPicture"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "CustomerID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtpostaladdress)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtresidence)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtcustomerid)
        Me.GroupBox2.Controls.Add(Me.Txtfirstname)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbodelivery)
        Me.GroupBox2.Controls.Add(Me.txttelephone)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 248)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CustomerDetails"
        '
        'txtnationalid
        '
        Me.txtnationalid.Location = New System.Drawing.Point(85, 24)
        Me.txtnationalid.Name = "txtnationalid"
        Me.txtnationalid.Size = New System.Drawing.Size(100, 20)
        Me.txtnationalid.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "NationalID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Residence"
        '
        'txtresidence
        '
        Me.txtresidence.Location = New System.Drawing.Point(77, 160)
        Me.txtresidence.Name = "txtresidence"
        Me.txtresidence.Size = New System.Drawing.Size(100, 20)
        Me.txtresidence.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-3, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "PostalAddress"
        '
        'txtpostaladdress
        '
        Me.txtpostaladdress.Location = New System.Drawing.Point(77, 190)
        Me.txtpostaladdress.Name = "txtpostaladdress"
        Me.txtpostaladdress.Size = New System.Drawing.Size(100, 20)
        Me.txtpostaladdress.TabIndex = 31
        '
        'btnorder
        '
        Me.btnorder.Location = New System.Drawing.Point(14, 6)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(50, 23)
        Me.btnorder.TabIndex = 28
        Me.btnorder.Text = "Order"
        Me.btnorder.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(75, 6)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(51, 23)
        Me.btncancel.TabIndex = 29
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(132, 6)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(51, 23)
        Me.btnnew.TabIndex = 30
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnnew)
        Me.Panel1.Controls.Add(Me.btnorder)
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Location = New System.Drawing.Point(246, 318)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 32)
        Me.Panel1.TabIndex = 31
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 362)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnationalid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Itempic)
        Me.Controls.Add(Me.txtitemname)
        Me.Controls.Add(Me.lblname)
        Me.Name = "Orders"
        Me.Text = "Orders"
        CType(Me.Itempic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblitemid As System.Windows.Forms.Label
    Friend WithEvents lblcategory As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lblammountavailable As System.Windows.Forms.Label
    Friend WithEvents lbldescription As System.Windows.Forms.Label
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents Itempic As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcustomerid As System.Windows.Forms.TextBox
    Friend WithEvents cbodelivery As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnationalid As System.Windows.Forms.TextBox
    Friend WithEvents txtpostaladdress As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtresidence As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnorder As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
