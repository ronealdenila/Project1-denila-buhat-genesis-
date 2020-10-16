<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.btnFeedback = New FontAwesome.Sharp.IconButton()
        Me.btnWallet = New FontAwesome.Sharp.IconButton()
        Me.btnEnrolledCourse = New FontAwesome.Sharp.IconButton()
        Me.btnGrades = New FontAwesome.Sharp.IconButton()
        Me.btnAssessment = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ImgHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButton7)
        Me.PanelMenu.Controls.Add(Me.btnFeedback)
        Me.PanelMenu.Controls.Add(Me.btnWallet)
        Me.PanelMenu.Controls.Add(Me.btnEnrolledCourse)
        Me.PanelMenu.Controls.Add(Me.btnGrades)
        Me.PanelMenu.Controls.Add(Me.btnAssessment)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 639)
        Me.PanelMenu.TabIndex = 0
        '
        'IconButton7
        '
        Me.IconButton7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton7.ForeColor = System.Drawing.Color.White
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconButton7.IconColor = System.Drawing.Color.White
        Me.IconButton7.IconSize = 32
        Me.IconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.Location = New System.Drawing.Point(0, 589)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton7.Rotation = 0R
        Me.IconButton7.Size = New System.Drawing.Size(220, 50)
        Me.IconButton7.TabIndex = 8
        Me.IconButton7.Text = "Logout"
        Me.IconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton7.UseVisualStyleBackColor = True
        '
        'btnFeedback
        '
        Me.btnFeedback.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFeedback.FlatAppearance.BorderSize = 0
        Me.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFeedback.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnFeedback.ForeColor = System.Drawing.Color.White
        Me.btnFeedback.IconChar = FontAwesome.Sharp.IconChar.Comment
        Me.btnFeedback.IconColor = System.Drawing.Color.White
        Me.btnFeedback.IconSize = 32
        Me.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.Location = New System.Drawing.Point(0, 440)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnFeedback.Rotation = 0R
        Me.btnFeedback.Size = New System.Drawing.Size(220, 60)
        Me.btnFeedback.TabIndex = 7
        Me.btnFeedback.Text = "Feedback"
        Me.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'btnWallet
        '
        Me.btnWallet.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnWallet.FlatAppearance.BorderSize = 0
        Me.btnWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWallet.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnWallet.ForeColor = System.Drawing.Color.White
        Me.btnWallet.IconChar = FontAwesome.Sharp.IconChar.Wallet
        Me.btnWallet.IconColor = System.Drawing.Color.White
        Me.btnWallet.IconSize = 32
        Me.btnWallet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWallet.Location = New System.Drawing.Point(0, 380)
        Me.btnWallet.Name = "btnWallet"
        Me.btnWallet.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnWallet.Rotation = 0R
        Me.btnWallet.Size = New System.Drawing.Size(220, 60)
        Me.btnWallet.TabIndex = 6
        Me.btnWallet.Text = "My wallet"
        Me.btnWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWallet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnWallet.UseVisualStyleBackColor = True
        '
        'btnEnrolledCourse
        '
        Me.btnEnrolledCourse.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnrolledCourse.FlatAppearance.BorderSize = 0
        Me.btnEnrolledCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrolledCourse.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEnrolledCourse.ForeColor = System.Drawing.Color.White
        Me.btnEnrolledCourse.IconChar = FontAwesome.Sharp.IconChar.UserGraduate
        Me.btnEnrolledCourse.IconColor = System.Drawing.Color.White
        Me.btnEnrolledCourse.IconSize = 32
        Me.btnEnrolledCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnrolledCourse.Location = New System.Drawing.Point(0, 320)
        Me.btnEnrolledCourse.Name = "btnEnrolledCourse"
        Me.btnEnrolledCourse.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnEnrolledCourse.Rotation = 0R
        Me.btnEnrolledCourse.Size = New System.Drawing.Size(220, 60)
        Me.btnEnrolledCourse.TabIndex = 5
        Me.btnEnrolledCourse.Text = "Enrolled Courses"
        Me.btnEnrolledCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnrolledCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnrolledCourse.UseVisualStyleBackColor = True
        '
        'btnGrades
        '
        Me.btnGrades.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnGrades.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGrades.FlatAppearance.BorderSize = 0
        Me.btnGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrades.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnGrades.ForeColor = System.Drawing.Color.White
        Me.btnGrades.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher
        Me.btnGrades.IconColor = System.Drawing.Color.White
        Me.btnGrades.IconSize = 32
        Me.btnGrades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrades.Location = New System.Drawing.Point(0, 260)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnGrades.Rotation = 0R
        Me.btnGrades.Size = New System.Drawing.Size(220, 60)
        Me.btnGrades.TabIndex = 4
        Me.btnGrades.Text = "Grades"
        Me.btnGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGrades.UseVisualStyleBackColor = False
        '
        'btnAssessment
        '
        Me.btnAssessment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAssessment.FlatAppearance.BorderSize = 0
        Me.btnAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssessment.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAssessment.ForeColor = System.Drawing.Color.White
        Me.btnAssessment.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
        Me.btnAssessment.IconColor = System.Drawing.Color.White
        Me.btnAssessment.IconSize = 32
        Me.btnAssessment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAssessment.Location = New System.Drawing.Point(0, 200)
        Me.btnAssessment.Name = "btnAssessment"
        Me.btnAssessment.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnAssessment.Rotation = 0R
        Me.btnAssessment.Size = New System.Drawing.Size(220, 60)
        Me.btnAssessment.TabIndex = 3
        Me.btnAssessment.Text = "Assessment"
        Me.btnAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAssessment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAssessment.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconSize = 32
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 140)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Rotation = 0R
        Me.btnDashboard.Size = New System.Drawing.Size(220, 60)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 1
        '
        'ImgHome
        '
        Me.ImgHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ImgHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImgHome.Image = CType(resources.GetObject("ImgHome.Image"), System.Drawing.Image)
        Me.ImgHome.Location = New System.Drawing.Point(0, 0)
        Me.ImgHome.Name = "ImgHome"
        Me.ImgHome.Size = New System.Drawing.Size(220, 140)
        Me.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgHome.TabIndex = 0
        Me.ImgHome.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.btnExit)
        Me.PanelTitleBar.Controls.Add(Me.btnMaximize)
        Me.PanelTitleBar.Controls.Add(Me.btnMinimize)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(889, 100)
        Me.PanelTitleBar.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnExit.IconColor = System.Drawing.Color.White
        Me.btnExit.IconSize = 16
        Me.btnExit.Location = New System.Drawing.Point(860, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Rotation = 0R
        Me.btnExit.Size = New System.Drawing.Size(26, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaximize.IconColor = System.Drawing.Color.White
        Me.btnMaximize.IconSize = 16
        Me.btnMaximize.Location = New System.Drawing.Point(838, 3)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Rotation = 0R
        Me.btnMaximize.Size = New System.Drawing.Size(23, 23)
        Me.btnMaximize.TabIndex = 3
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.White
        Me.btnMinimize.IconSize = 16
        Me.btnMinimize.Location = New System.Drawing.Point(808, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Rotation = 0R
        Me.btnMinimize.Size = New System.Drawing.Size(28, 23)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Location = New System.Drawing.Point(68, 43)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(35, 13)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconCurrentForm.Location = New System.Drawing.Point(39, 34)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.Transparent
        Me.PanelDesktop.BackgroundImage = Global.Project1.My.Resources.Resources._32b877ed4aa7778cc7d43ebb7d95a6f1
        Me.PanelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 100)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(889, 539)
        Me.PanelDesktop.TabIndex = 2
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 639)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents ImgHome As PictureBox
    Friend WithEvents btnWallet As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEnrolledCourse As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGrades As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAssessment As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFeedback As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
End Class
