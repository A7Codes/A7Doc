<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient
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
        Me.patDetailsBG = New System.Windows.Forms.PictureBox()
        Me.patLblName = New System.Windows.Forms.Label()
        Me.patLblPhone = New System.Windows.Forms.Label()
        Me.patLblAddress = New System.Windows.Forms.Label()
        Me.patLblNameV = New System.Windows.Forms.Label()
        Me.patLblPhoneV = New System.Windows.Forms.Label()
        Me.patLblAddressV = New System.Windows.Forms.Label()
        Me.patLblNameTB = New System.Windows.Forms.TextBox()
        Me.patLblAddressTB = New System.Windows.Forms.TextBox()
        Me.patLblPhoneTB = New System.Windows.Forms.TextBox()
        Me.patSearchBarBtn = New System.Windows.Forms.Button()
        Me.patSearchBarTxt = New System.Windows.Forms.TextBox()
        Me.patSearchBG = New System.Windows.Forms.PictureBox()
        Me.PatBtnDelete = New System.Windows.Forms.Button()
        Me.PatBtnEdit = New System.Windows.Forms.Button()
        Me.PatBtnAdd = New System.Windows.Forms.Button()
        CType(Me.patDetailsBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.patSearchBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'patDetailsBG
        '
        Me.patDetailsBG.Image = Global.A7Doc.My.Resources.Resources.aptsCom1Bg
        Me.patDetailsBG.Location = New System.Drawing.Point(770, 332)
        Me.patDetailsBG.Name = "patDetailsBG"
        Me.patDetailsBG.Size = New System.Drawing.Size(905, 630)
        Me.patDetailsBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.patDetailsBG.TabIndex = 0
        Me.patDetailsBG.TabStop = False
        '
        'patLblName
        '
        Me.patLblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.patLblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLblName.ForeColor = System.Drawing.Color.White
        Me.patLblName.Location = New System.Drawing.Point(823, 446)
        Me.patLblName.Name = "patLblName"
        Me.patLblName.Size = New System.Drawing.Size(173, 47)
        Me.patLblName.TabIndex = 1
        Me.patLblName.Text = "Name"
        Me.patLblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patLblPhone
        '
        Me.patLblPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.patLblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLblPhone.ForeColor = System.Drawing.Color.White
        Me.patLblPhone.Location = New System.Drawing.Point(823, 613)
        Me.patLblPhone.Name = "patLblPhone"
        Me.patLblPhone.Size = New System.Drawing.Size(173, 47)
        Me.patLblPhone.TabIndex = 1
        Me.patLblPhone.Text = "Phone"
        Me.patLblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patLblAddress
        '
        Me.patLblAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.patLblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLblAddress.ForeColor = System.Drawing.Color.White
        Me.patLblAddress.Location = New System.Drawing.Point(823, 786)
        Me.patLblAddress.Name = "patLblAddress"
        Me.patLblAddress.Size = New System.Drawing.Size(173, 47)
        Me.patLblAddress.TabIndex = 1
        Me.patLblAddress.Text = "Address"
        Me.patLblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patLblNameV
        '
        Me.patLblNameV.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.patLblNameV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLblNameV.ForeColor = System.Drawing.Color.White
        Me.patLblNameV.Location = New System.Drawing.Point(1002, 446)
        Me.patLblNameV.Name = "patLblNameV"
        Me.patLblNameV.Size = New System.Drawing.Size(180, 47)
        Me.patLblNameV.TabIndex = 2
        Me.patLblNameV.Text = "NA"
        Me.patLblNameV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patLblPhoneV
        '
        Me.patLblPhoneV.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.patLblPhoneV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLblPhoneV.ForeColor = System.Drawing.Color.White
        Me.patLblPhoneV.Location = New System.Drawing.Point(1042, 613)
        Me.patLblPhoneV.Name = "patLblPhoneV"
        Me.patLblPhoneV.Size = New System.Drawing.Size(180, 47)
        Me.patLblPhoneV.TabIndex = 2
        Me.patLblPhoneV.Text = "PH"
        Me.patLblPhoneV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patLblAddressV
        '
        Me.patLblAddressV.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.patLblAddressV.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLblAddressV.ForeColor = System.Drawing.Color.White
        Me.patLblAddressV.Location = New System.Drawing.Point(1042, 786)
        Me.patLblAddressV.Name = "patLblAddressV"
        Me.patLblAddressV.Size = New System.Drawing.Size(180, 47)
        Me.patLblAddressV.TabIndex = 2
        Me.patLblAddressV.Text = "AD"
        Me.patLblAddressV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patLblNameTB
        '
        Me.patLblNameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLblNameTB.Location = New System.Drawing.Point(1169, 446)
        Me.patLblNameTB.Name = "patLblNameTB"
        Me.patLblNameTB.Size = New System.Drawing.Size(226, 36)
        Me.patLblNameTB.TabIndex = 3
        '
        'patLblAddressTB
        '
        Me.patLblAddressTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLblAddressTB.Location = New System.Drawing.Point(1169, 786)
        Me.patLblAddressTB.Name = "patLblAddressTB"
        Me.patLblAddressTB.Size = New System.Drawing.Size(226, 36)
        Me.patLblAddressTB.TabIndex = 3
        '
        'patLblPhoneTB
        '
        Me.patLblPhoneTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patLblPhoneTB.Location = New System.Drawing.Point(1169, 613)
        Me.patLblPhoneTB.Name = "patLblPhoneTB"
        Me.patLblPhoneTB.Size = New System.Drawing.Size(226, 36)
        Me.patLblPhoneTB.TabIndex = 3
        '
        'patSearchBarBtn
        '
        Me.patSearchBarBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.patSearchBarBtn.BackgroundImage = Global.A7Doc.My.Resources.Resources.aptSearchbtn
        Me.patSearchBarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.patSearchBarBtn.FlatAppearance.BorderSize = 0
        Me.patSearchBarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.patSearchBarBtn.Location = New System.Drawing.Point(1387, 261)
        Me.patSearchBarBtn.Name = "patSearchBarBtn"
        Me.patSearchBarBtn.Size = New System.Drawing.Size(60, 48)
        Me.patSearchBarBtn.TabIndex = 6
        Me.patSearchBarBtn.UseVisualStyleBackColor = False
        '
        'patSearchBarTxt
        '
        Me.patSearchBarTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.patSearchBarTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.patSearchBarTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patSearchBarTxt.ForeColor = System.Drawing.Color.White
        Me.patSearchBarTxt.Location = New System.Drawing.Point(935, 261)
        Me.patSearchBarTxt.Name = "patSearchBarTxt"
        Me.patSearchBarTxt.Size = New System.Drawing.Size(446, 48)
        Me.patSearchBarTxt.TabIndex = 5
        Me.patSearchBarTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'patSearchBG
        '
        Me.patSearchBG.BackColor = System.Drawing.Color.Transparent
        Me.patSearchBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.patSearchBG.Image = Global.A7Doc.My.Resources.Resources.dashbtnbg
        Me.patSearchBG.Location = New System.Drawing.Point(908, 248)
        Me.patSearchBG.Name = "patSearchBG"
        Me.patSearchBG.Size = New System.Drawing.Size(571, 77)
        Me.patSearchBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.patSearchBG.TabIndex = 4
        Me.patSearchBG.TabStop = False
        '
        'PatBtnDelete
        '
        Me.PatBtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.PatBtnDelete.BackgroundImage = Global.A7Doc.My.Resources.Resources.dashbtnbg
        Me.PatBtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PatBtnDelete.FlatAppearance.BorderSize = 0
        Me.PatBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PatBtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatBtnDelete.ForeColor = System.Drawing.Color.White
        Me.PatBtnDelete.Location = New System.Drawing.Point(1500, 961)
        Me.PatBtnDelete.Name = "PatBtnDelete"
        Me.PatBtnDelete.Size = New System.Drawing.Size(175, 60)
        Me.PatBtnDelete.TabIndex = 9
        Me.PatBtnDelete.Text = "DELETE"
        Me.PatBtnDelete.UseVisualStyleBackColor = False
        '
        'PatBtnEdit
        '
        Me.PatBtnEdit.BackColor = System.Drawing.Color.Transparent
        Me.PatBtnEdit.BackgroundImage = Global.A7Doc.My.Resources.Resources.dashbtnbg
        Me.PatBtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PatBtnEdit.FlatAppearance.BorderSize = 0
        Me.PatBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PatBtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatBtnEdit.ForeColor = System.Drawing.Color.White
        Me.PatBtnEdit.Location = New System.Drawing.Point(1134, 961)
        Me.PatBtnEdit.Name = "PatBtnEdit"
        Me.PatBtnEdit.Size = New System.Drawing.Size(175, 60)
        Me.PatBtnEdit.TabIndex = 10
        Me.PatBtnEdit.Text = "EDIT"
        Me.PatBtnEdit.UseVisualStyleBackColor = False
        '
        'PatBtnAdd
        '
        Me.PatBtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.PatBtnAdd.BackgroundImage = Global.A7Doc.My.Resources.Resources.dashbtnbg
        Me.PatBtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PatBtnAdd.FlatAppearance.BorderSize = 0
        Me.PatBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PatBtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatBtnAdd.ForeColor = System.Drawing.Color.White
        Me.PatBtnAdd.Location = New System.Drawing.Point(770, 961)
        Me.PatBtnAdd.Name = "PatBtnAdd"
        Me.PatBtnAdd.Size = New System.Drawing.Size(175, 60)
        Me.PatBtnAdd.TabIndex = 11
        Me.PatBtnAdd.Text = "ADD"
        Me.PatBtnAdd.UseVisualStyleBackColor = False
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.A7Doc.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.PatBtnDelete)
        Me.Controls.Add(Me.PatBtnEdit)
        Me.Controls.Add(Me.PatBtnAdd)
        Me.Controls.Add(Me.patSearchBarBtn)
        Me.Controls.Add(Me.patSearchBarTxt)
        Me.Controls.Add(Me.patSearchBG)
        Me.Controls.Add(Me.patLblPhoneTB)
        Me.Controls.Add(Me.patLblAddressTB)
        Me.Controls.Add(Me.patLblNameTB)
        Me.Controls.Add(Me.patLblAddressV)
        Me.Controls.Add(Me.patLblPhoneV)
        Me.Controls.Add(Me.patLblNameV)
        Me.Controls.Add(Me.patLblAddress)
        Me.Controls.Add(Me.patLblPhone)
        Me.Controls.Add(Me.patLblName)
        Me.Controls.Add(Me.patDetailsBG)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patient"
        Me.Text = "Patient"
        CType(Me.patDetailsBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.patSearchBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents patDetailsBG As PictureBox
    Friend WithEvents patLblName As Label
    Friend WithEvents patLblPhone As Label
    Friend WithEvents patLblAddress As Label
    Friend WithEvents patLblNameV As Label
    Friend WithEvents patLblPhoneV As Label
    Friend WithEvents patLblAddressV As Label
    Friend WithEvents patLblNameTB As TextBox
    Friend WithEvents patLblAddressTB As TextBox
    Friend WithEvents patLblPhoneTB As TextBox
    Friend WithEvents patSearchBarBtn As Button
    Friend WithEvents patSearchBarTxt As TextBox
    Friend WithEvents patSearchBG As PictureBox
    Friend WithEvents PatBtnDelete As Button
    Friend WithEvents PatBtnEdit As Button
    Friend WithEvents PatBtnAdd As Button
End Class
