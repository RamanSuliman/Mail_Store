<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Interaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Interaction))
        Me.lblEmailTo = New System.Windows.Forms.Label()
        Me.lblSecelt = New System.Windows.Forms.Label()
        Me.txtMessageContent = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioOwn = New System.Windows.Forms.RadioButton()
        Me.RadioDefault = New System.Windows.Forms.RadioButton()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ChHotmail = New System.Windows.Forms.CheckBox()
        Me.ChGmail = New System.Windows.Forms.CheckBox()
        Me.ChLive = New System.Windows.Forms.CheckBox()
        Me.ChOutlook = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblValidation = New System.Windows.Forms.Label()
        Me.btnFileCreator = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSubmit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEmailTo
        '
        Me.lblEmailTo.AutoSize = True
        Me.lblEmailTo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblEmailTo.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailTo.Location = New System.Drawing.Point(10, 22)
        Me.lblEmailTo.Name = "lblEmailTo"
        Me.lblEmailTo.Size = New System.Drawing.Size(161, 24)
        Me.lblEmailTo.TabIndex = 2
        Me.lblEmailTo.Text = "Set receiver email:"
        '
        'lblSecelt
        '
        Me.lblSecelt.AutoSize = True
        Me.lblSecelt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblSecelt.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecelt.Location = New System.Drawing.Point(7, 8)
        Me.lblSecelt.Name = "lblSecelt"
        Me.lblSecelt.Size = New System.Drawing.Size(218, 24)
        Me.lblSecelt.TabIndex = 3
        Me.lblSecelt.Text = "Select the desired option:"
        '
        'txtMessageContent
        '
        Me.txtMessageContent.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txtMessageContent.Enabled = False
        Me.txtMessageContent.ForeColor = System.Drawing.Color.Black
        Me.txtMessageContent.Location = New System.Drawing.Point(7, 39)
        Me.txtMessageContent.MaxLength = 500
        Me.txtMessageContent.Multiline = True
        Me.txtMessageContent.Name = "txtMessageContent"
        Me.txtMessageContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMessageContent.Size = New System.Drawing.Size(444, 102)
        Me.txtMessageContent.TabIndex = 4
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(5, 53)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(67, 23)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone"
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblService.Location = New System.Drawing.Point(12, 6)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(318, 31)
        Me.lblService.TabIndex = 6
        Me.lblService.Text = "Choose your mail service"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioOwn)
        Me.Panel1.Controls.Add(Me.RadioDefault)
        Me.Panel1.Controls.Add(Me.txtMessageContent)
        Me.Panel1.Controls.Add(Me.lblSecelt)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 152)
        Me.Panel1.TabIndex = 7
        '
        'RadioOwn
        '
        Me.RadioOwn.AutoSize = True
        Me.RadioOwn.Location = New System.Drawing.Point(231, 10)
        Me.RadioOwn.Name = "RadioOwn"
        Me.RadioOwn.Size = New System.Drawing.Size(103, 17)
        Me.RadioOwn.TabIndex = 5
        Me.RadioOwn.TabStop = True
        Me.RadioOwn.Text = "Type my own ☺"
        Me.RadioOwn.UseVisualStyleBackColor = True
        '
        'RadioDefault
        '
        Me.RadioDefault.AutoSize = True
        Me.RadioDefault.Location = New System.Drawing.Point(344, 10)
        Me.RadioDefault.Name = "RadioDefault"
        Me.RadioDefault.Size = New System.Drawing.Size(107, 17)
        Me.RadioDefault.TabIndex = 5
        Me.RadioDefault.TabStop = True
        Me.RadioDefault.Text = "Default message!"
        Me.RadioDefault.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(10, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(62, 23)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'ChHotmail
        '
        Me.ChHotmail.AutoSize = True
        Me.ChHotmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChHotmail.Location = New System.Drawing.Point(8, 68)
        Me.ChHotmail.Name = "ChHotmail"
        Me.ChHotmail.Size = New System.Drawing.Size(15, 14)
        Me.ChHotmail.TabIndex = 9
        Me.ChHotmail.UseVisualStyleBackColor = True
        '
        'ChGmail
        '
        Me.ChGmail.AutoSize = True
        Me.ChGmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChGmail.Location = New System.Drawing.Point(8, 113)
        Me.ChGmail.Name = "ChGmail"
        Me.ChGmail.Size = New System.Drawing.Size(15, 14)
        Me.ChGmail.TabIndex = 9
        Me.ChGmail.UseVisualStyleBackColor = True
        '
        'ChLive
        '
        Me.ChLive.AutoSize = True
        Me.ChLive.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChLive.ForeColor = System.Drawing.Color.Blue
        Me.ChLive.Location = New System.Drawing.Point(8, 178)
        Me.ChLive.Name = "ChLive"
        Me.ChLive.Size = New System.Drawing.Size(88, 37)
        Me.ChLive.TabIndex = 9
        Me.ChLive.Text = "Live"
        Me.ChLive.UseVisualStyleBackColor = True
        '
        'ChOutlook
        '
        Me.ChOutlook.AutoSize = True
        Me.ChOutlook.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChOutlook.Location = New System.Drawing.Point(8, 155)
        Me.ChOutlook.Name = "ChOutlook"
        Me.ChOutlook.Size = New System.Drawing.Size(15, 14)
        Me.ChOutlook.TabIndex = 9
        Me.ChOutlook.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.ChGmail)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.ChOutlook)
        Me.Panel2.Controls.Add(Me.ChLive)
        Me.Panel2.Controls.Add(Me.ChHotmail)
        Me.Panel2.Controls.Add(Me.lblService)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(65, 168)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 222)
        Me.Panel2.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(28, 147)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(129, 29)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Info
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Maroon
        Me.txtEmail.Location = New System.Drawing.Point(177, 22)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(292, 22)
        Me.txtEmail.TabIndex = 11
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Image = CType(resources.GetObject("BtnSubmit.Image"), System.Drawing.Image)
        Me.BtnSubmit.Location = New System.Drawing.Point(424, 281)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(483, 109)
        Me.BtnSubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSubmit.TabIndex = 12
        Me.BtnSubmit.TabStop = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Info
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Maroon
        Me.txtName.Location = New System.Drawing.Point(80, 14)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(250, 21)
        Me.txtName.TabIndex = 13
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Info
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Maroon
        Me.txtPhone.Location = New System.Drawing.Point(80, 56)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(250, 21)
        Me.txtPhone.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblPhone)
        Me.Panel3.Controls.Add(Me.txtPhone)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Location = New System.Drawing.Point(65, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(343, 93)
        Me.Panel3.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblValidation)
        Me.Panel4.Controls.Add(Me.txtEmail)
        Me.Panel4.Controls.Add(Me.lblEmailTo)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Panel4.Location = New System.Drawing.Point(424, 59)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(483, 216)
        Me.Panel4.TabIndex = 15
        '
        'lblValidation
        '
        Me.lblValidation.AutoSize = True
        Me.lblValidation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidation.ForeColor = System.Drawing.Color.Red
        Me.lblValidation.Location = New System.Drawing.Point(237, 6)
        Me.lblValidation.Name = "lblValidation"
        Me.lblValidation.Size = New System.Drawing.Size(163, 16)
        Me.lblValidation.TabIndex = 12
        Me.lblValidation.Text = "This isn't a valid email"
        Me.lblValidation.Visible = False
        '
        'btnFileCreator
        '
        Me.btnFileCreator.BackColor = System.Drawing.Color.Transparent
        Me.btnFileCreator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFileCreator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFileCreator.FlatAppearance.BorderSize = 0
        Me.btnFileCreator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileCreator.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileCreator.Location = New System.Drawing.Point(938, 200)
        Me.btnFileCreator.Name = "btnFileCreator"
        Me.btnFileCreator.Size = New System.Drawing.Size(53, 52)
        Me.btnFileCreator.TabIndex = 16
        Me.btnFileCreator.Text = "☺"
        Me.btnFileCreator.UseVisualStyleBackColor = False
        '
        'User_Interaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1051, 447)
        Me.Controls.Add(Me.btnFileCreator)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User_Interaction"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User_Interaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSubmit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEmailTo As Label
    Friend WithEvents lblSecelt As Label
    Friend WithEvents txtMessageContent As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblService As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioOwn As RadioButton
    Friend WithEvents RadioDefault As RadioButton
    Friend WithEvents lblName As Label
    Friend WithEvents ChHotmail As CheckBox
    Friend WithEvents ChGmail As CheckBox
    Friend WithEvents ChLive As CheckBox
    Friend WithEvents ChOutlook As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BtnSubmit As PictureBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblValidation As Label
    Friend WithEvents btnFileCreator As Button
End Class
