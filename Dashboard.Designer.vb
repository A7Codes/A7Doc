<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.dashPicLogo = New System.Windows.Forms.PictureBox()
        Me.DashBtnApts = New System.Windows.Forms.Button()
        Me.DashBtnPats = New System.Windows.Forms.Button()
        CType(Me.dashPicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dashPicLogo
        '
        Me.dashPicLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dashPicLogo.BackColor = System.Drawing.Color.Transparent
        Me.dashPicLogo.Image = Global.A7Doc.My.Resources.Resources.dashImg
        Me.dashPicLogo.Location = New System.Drawing.Point(743, 189)
        Me.dashPicLogo.Name = "dashPicLogo"
        Me.dashPicLogo.Size = New System.Drawing.Size(450, 450)
        Me.dashPicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dashPicLogo.TabIndex = 0
        Me.dashPicLogo.TabStop = False
        '
        'DashBtnApts
        '
        Me.DashBtnApts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DashBtnApts.BackgroundImage = Global.A7Doc.My.Resources.Resources.dashbtnbg
        Me.DashBtnApts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DashBtnApts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashBtnApts.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashBtnApts.ForeColor = System.Drawing.Color.White
        Me.DashBtnApts.Location = New System.Drawing.Point(645, 641)
        Me.DashBtnApts.Name = "DashBtnApts"
        Me.DashBtnApts.Size = New System.Drawing.Size(300, 100)
        Me.DashBtnApts.TabIndex = 1
        Me.DashBtnApts.Text = "Appointments"
        Me.DashBtnApts.UseVisualStyleBackColor = True
        '
        'DashBtnPats
        '
        Me.DashBtnPats.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DashBtnPats.BackgroundImage = Global.A7Doc.My.Resources.Resources.dashbtnbg
        Me.DashBtnPats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DashBtnPats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashBtnPats.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashBtnPats.ForeColor = System.Drawing.Color.White
        Me.DashBtnPats.Location = New System.Drawing.Point(975, 641)
        Me.DashBtnPats.Name = "DashBtnPats"
        Me.DashBtnPats.Size = New System.Drawing.Size(300, 100)
        Me.DashBtnPats.TabIndex = 1
        Me.DashBtnPats.Text = "Patients"
        Me.DashBtnPats.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.A7Doc.My.Resources.Resources.dashbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.DashBtnPats)
        Me.Controls.Add(Me.DashBtnApts)
        Me.Controls.Add(Me.dashPicLogo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.dashPicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dashPicLogo As PictureBox
    Friend WithEvents DashBtnApts As Button
    Friend WithEvents DashBtnPats As Button
End Class
