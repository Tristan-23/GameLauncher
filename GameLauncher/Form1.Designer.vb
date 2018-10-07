<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TopDragPanel = New System.Windows.Forms.Panel()
        Me.TopLabel = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.ProfilBtn = New System.Windows.Forms.PictureBox()
        Me.GamesBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.HomeBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.Game1 = New System.Windows.Forms.Panel()
        Me.GameL1 = New System.Windows.Forms.Label()
        Me.GameI1 = New System.Windows.Forms.PictureBox()
        Me.Home4 = New System.Windows.Forms.Panel()
        Me.Home3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Home2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HomeVersion = New System.Windows.Forms.Label()
        Me.Home2Label = New System.Windows.Forms.Label()
        Me.Game4 = New System.Windows.Forms.Panel()
        Me.GameL4 = New System.Windows.Forms.Label()
        Me.GameI4 = New System.Windows.Forms.PictureBox()
        Me.Game2 = New System.Windows.Forms.Panel()
        Me.GameL2 = New System.Windows.Forms.Label()
        Me.GameI2 = New System.Windows.Forms.PictureBox()
        Me.Game3 = New System.Windows.Forms.Panel()
        Me.GameL3 = New System.Windows.Forms.Label()
        Me.GameI3 = New System.Windows.Forms.PictureBox()
        Me.HomePanel = New System.Windows.Forms.Panel()
        Me.HomeBtn3 = New System.Windows.Forms.PictureBox()
        Me.HomeBtn2 = New System.Windows.Forms.PictureBox()
        Me.HomeBtn1 = New System.Windows.Forms.PictureBox()
        Me.HomePictureBox = New System.Windows.Forms.PictureBox()
        Me.GamePanel = New System.Windows.Forms.Panel()
        Me.GameLabel = New System.Windows.Forms.Label()
        Me.GameImage = New System.Windows.Forms.PictureBox()
        Me.HomeBannerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.TopDragPanel.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProfilBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContentPanel.SuspendLayout()
        Me.Game1.SuspendLayout()
        CType(Me.GameI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Home3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Home2.SuspendLayout()
        Me.Game4.SuspendLayout()
        CType(Me.GameI4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Game2.SuspendLayout()
        CType(Me.GameI2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Game3.SuspendLayout()
        CType(Me.GameI3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HomePanel.SuspendLayout()
        CType(Me.HomeBtn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeBtn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeBtn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GamePanel.SuspendLayout()
        CType(Me.GameImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopDragPanel
        '
        Me.TopDragPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TopDragPanel.Controls.Add(Me.TopLabel)
        Me.TopDragPanel.Controls.Add(Me.BunifuImageButton1)
        Me.TopDragPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopDragPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopDragPanel.Name = "TopDragPanel"
        Me.TopDragPanel.Size = New System.Drawing.Size(1087, 50)
        Me.TopDragPanel.TabIndex = 0
        '
        'TopLabel
        '
        Me.TopLabel.AutoSize = True
        Me.TopLabel.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopLabel.ForeColor = System.Drawing.Color.White
        Me.TopLabel.Location = New System.Drawing.Point(3, 8)
        Me.TopLabel.Name = "TopLabel"
        Me.TopLabel.Size = New System.Drawing.Size(229, 33)
        Me.TopLabel.TabIndex = 1
        Me.TopLabel.Text = "Game Launcher"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1057, 6)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(24, 26)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'DragControl
        '
        Me.DragControl.Fixed = True
        Me.DragControl.Horizontal = True
        Me.DragControl.TargetControl = Me.TopDragPanel
        Me.DragControl.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.ProfilBtn)
        Me.Panel1.Controls.Add(Me.GamesBtn)
        Me.Panel1.Controls.Add(Me.HomeBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1087, 37)
        Me.Panel1.TabIndex = 1
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UsernameLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(975, 10)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UsernameLabel.Size = New System.Drawing.Size(103, 17)
        Me.UsernameLabel.TabIndex = 5
        Me.UsernameLabel.Text = "Username here"
        '
        'ProfilBtn
        '
        Me.ProfilBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProfilBtn.Image = CType(resources.GetObject("ProfilBtn.Image"), System.Drawing.Image)
        Me.ProfilBtn.Location = New System.Drawing.Point(936, 3)
        Me.ProfilBtn.Name = "ProfilBtn"
        Me.ProfilBtn.Size = New System.Drawing.Size(31, 31)
        Me.ProfilBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilBtn.TabIndex = 4
        Me.ProfilBtn.TabStop = False
        '
        'GamesBtn
        '
        Me.GamesBtn.ActiveBorderThickness = 1
        Me.GamesBtn.ActiveCornerRadius = 20
        Me.GamesBtn.ActiveFillColor = System.Drawing.Color.Transparent
        Me.GamesBtn.ActiveForecolor = System.Drawing.Color.Gray
        Me.GamesBtn.ActiveLineColor = System.Drawing.Color.Transparent
        Me.GamesBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.GamesBtn.BackgroundImage = CType(resources.GetObject("GamesBtn.BackgroundImage"), System.Drawing.Image)
        Me.GamesBtn.ButtonText = "Games"
        Me.GamesBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GamesBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GamesBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.GamesBtn.IdleBorderThickness = 1
        Me.GamesBtn.IdleCornerRadius = 20
        Me.GamesBtn.IdleFillColor = System.Drawing.Color.Transparent
        Me.GamesBtn.IdleForecolor = System.Drawing.Color.White
        Me.GamesBtn.IdleLineColor = System.Drawing.Color.Transparent
        Me.GamesBtn.Location = New System.Drawing.Point(178, 3)
        Me.GamesBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.GamesBtn.Name = "GamesBtn"
        Me.GamesBtn.Size = New System.Drawing.Size(178, 35)
        Me.GamesBtn.TabIndex = 3
        Me.GamesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomeBtn
        '
        Me.HomeBtn.ActiveBorderThickness = 1
        Me.HomeBtn.ActiveCornerRadius = 20
        Me.HomeBtn.ActiveFillColor = System.Drawing.Color.Transparent
        Me.HomeBtn.ActiveForecolor = System.Drawing.Color.Gray
        Me.HomeBtn.ActiveLineColor = System.Drawing.Color.Transparent
        Me.HomeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.HomeBtn.BackgroundImage = CType(resources.GetObject("HomeBtn.BackgroundImage"), System.Drawing.Image)
        Me.HomeBtn.ButtonText = "Home"
        Me.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HomeBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.HomeBtn.IdleBorderThickness = 1
        Me.HomeBtn.IdleCornerRadius = 20
        Me.HomeBtn.IdleFillColor = System.Drawing.Color.Transparent
        Me.HomeBtn.IdleForecolor = System.Drawing.Color.White
        Me.HomeBtn.IdleLineColor = System.Drawing.Color.Transparent
        Me.HomeBtn.Location = New System.Drawing.Point(5, 3)
        Me.HomeBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(173, 35)
        Me.HomeBtn.TabIndex = 2
        Me.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContentPanel
        '
        Me.ContentPanel.Controls.Add(Me.Game1)
        Me.ContentPanel.Controls.Add(Me.Home4)
        Me.ContentPanel.Controls.Add(Me.Home3)
        Me.ContentPanel.Controls.Add(Me.Home2)
        Me.ContentPanel.Controls.Add(Me.Game4)
        Me.ContentPanel.Controls.Add(Me.Game2)
        Me.ContentPanel.Controls.Add(Me.Game3)
        Me.ContentPanel.Controls.Add(Me.HomePanel)
        Me.ContentPanel.Controls.Add(Me.GamePanel)
        Me.ContentPanel.Location = New System.Drawing.Point(0, 87)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(1087, 517)
        Me.ContentPanel.TabIndex = 3
        '
        'Game1
        '
        Me.Game1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Game1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Game1.Controls.Add(Me.GameL1)
        Me.Game1.Controls.Add(Me.GameI1)
        Me.Game1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Game1.Location = New System.Drawing.Point(71, 498)
        Me.Game1.Name = "Game1"
        Me.Game1.Size = New System.Drawing.Size(220, 293)
        Me.Game1.TabIndex = 5
        Me.Game1.Visible = False
        '
        'GameL1
        '
        Me.GameL1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameL1.AutoSize = True
        Me.GameL1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameL1.ForeColor = System.Drawing.Color.White
        Me.GameL1.Location = New System.Drawing.Point(81, 260)
        Me.GameL1.Name = "GameL1"
        Me.GameL1.Size = New System.Drawing.Size(69, 22)
        Me.GameL1.TabIndex = 1
        Me.GameL1.Text = "Game"
        Me.GameL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GameL1.Visible = False
        '
        'GameI1
        '
        Me.GameI1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameI1.Image = CType(resources.GetObject("GameI1.Image"), System.Drawing.Image)
        Me.GameI1.Location = New System.Drawing.Point(3, 3)
        Me.GameI1.Name = "GameI1"
        Me.GameI1.Size = New System.Drawing.Size(214, 247)
        Me.GameI1.TabIndex = 0
        Me.GameI1.TabStop = False
        Me.GameI1.Visible = False
        '
        'Home4
        '
        Me.Home4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Home4.Location = New System.Drawing.Point(802, 276)
        Me.Home4.Name = "Home4"
        Me.Home4.Size = New System.Drawing.Size(279, 220)
        Me.Home4.TabIndex = 7
        '
        'Home3
        '
        Me.Home3.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Home3.Controls.Add(Me.PictureBox2)
        Me.Home3.Location = New System.Drawing.Point(294, 276)
        Me.Home3.Name = "Home3"
        Me.Home3.Size = New System.Drawing.Size(502, 220)
        Me.Home3.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-12, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(521, 220)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Home2
        '
        Me.Home2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Home2.Controls.Add(Me.Label1)
        Me.Home2.Controls.Add(Me.HomeVersion)
        Me.Home2.Controls.Add(Me.Home2Label)
        Me.Home2.Location = New System.Drawing.Point(9, 276)
        Me.Home2.Name = "Home2"
        Me.Home2.Size = New System.Drawing.Size(279, 220)
        Me.Home2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 68)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Changelog:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Added new games" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - New overlay design" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - 10% SALE on selected ga" &
    "mes"
        '
        'HomeVersion
        '
        Me.HomeVersion.AutoSize = True
        Me.HomeVersion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeVersion.ForeColor = System.Drawing.Color.White
        Me.HomeVersion.Location = New System.Drawing.Point(10, 49)
        Me.HomeVersion.Name = "HomeVersion"
        Me.HomeVersion.Size = New System.Drawing.Size(62, 17)
        Me.HomeVersion.TabIndex = 1
        Me.HomeVersion.Text = "Version: "
        '
        'Home2Label
        '
        Me.Home2Label.AutoSize = True
        Me.Home2Label.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home2Label.ForeColor = System.Drawing.Color.White
        Me.Home2Label.Location = New System.Drawing.Point(9, 9)
        Me.Home2Label.Name = "Home2Label"
        Me.Home2Label.Size = New System.Drawing.Size(169, 24)
        Me.Home2Label.TabIndex = 0
        Me.Home2Label.Text = "Launcher News"
        '
        'Game4
        '
        Me.Game4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Game4.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Game4.Controls.Add(Me.GameL4)
        Me.Game4.Controls.Add(Me.GameI4)
        Me.Game4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Game4.Location = New System.Drawing.Point(749, 495)
        Me.Game4.Name = "Game4"
        Me.Game4.Size = New System.Drawing.Size(220, 293)
        Me.Game4.TabIndex = 5
        Me.Game4.Visible = False
        '
        'GameL4
        '
        Me.GameL4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameL4.AutoSize = True
        Me.GameL4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameL4.ForeColor = System.Drawing.Color.White
        Me.GameL4.Location = New System.Drawing.Point(32, 259)
        Me.GameL4.Name = "GameL4"
        Me.GameL4.Size = New System.Drawing.Size(159, 22)
        Me.GameL4.TabIndex = 1
        Me.GameL4.Text = "Template Game"
        Me.GameL4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GameL4.Visible = False
        '
        'GameI4
        '
        Me.GameI4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameI4.Image = CType(resources.GetObject("GameI4.Image"), System.Drawing.Image)
        Me.GameI4.Location = New System.Drawing.Point(3, 3)
        Me.GameI4.Name = "GameI4"
        Me.GameI4.Size = New System.Drawing.Size(214, 247)
        Me.GameI4.TabIndex = 0
        Me.GameI4.TabStop = False
        Me.GameI4.Visible = False
        '
        'Game2
        '
        Me.Game2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Game2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Game2.Controls.Add(Me.GameL2)
        Me.Game2.Controls.Add(Me.GameI2)
        Me.Game2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Game2.Location = New System.Drawing.Point(297, 498)
        Me.Game2.Name = "Game2"
        Me.Game2.Size = New System.Drawing.Size(220, 293)
        Me.Game2.TabIndex = 4
        Me.Game2.Visible = False
        '
        'GameL2
        '
        Me.GameL2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameL2.AutoSize = True
        Me.GameL2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameL2.ForeColor = System.Drawing.Color.White
        Me.GameL2.Location = New System.Drawing.Point(81, 260)
        Me.GameL2.Name = "GameL2"
        Me.GameL2.Size = New System.Drawing.Size(69, 22)
        Me.GameL2.TabIndex = 1
        Me.GameL2.Text = "Game"
        Me.GameL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GameL2.Visible = False
        '
        'GameI2
        '
        Me.GameI2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameI2.Image = CType(resources.GetObject("GameI2.Image"), System.Drawing.Image)
        Me.GameI2.Location = New System.Drawing.Point(3, 3)
        Me.GameI2.Name = "GameI2"
        Me.GameI2.Size = New System.Drawing.Size(214, 247)
        Me.GameI2.TabIndex = 0
        Me.GameI2.TabStop = False
        Me.GameI2.Visible = False
        '
        'Game3
        '
        Me.Game3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Game3.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Game3.Controls.Add(Me.GameL3)
        Me.Game3.Controls.Add(Me.GameI3)
        Me.Game3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Game3.Location = New System.Drawing.Point(523, 498)
        Me.Game3.Name = "Game3"
        Me.Game3.Size = New System.Drawing.Size(220, 293)
        Me.Game3.TabIndex = 4
        Me.Game3.Visible = False
        '
        'GameL3
        '
        Me.GameL3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameL3.AutoSize = True
        Me.GameL3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameL3.ForeColor = System.Drawing.Color.White
        Me.GameL3.Location = New System.Drawing.Point(32, 259)
        Me.GameL3.Name = "GameL3"
        Me.GameL3.Size = New System.Drawing.Size(159, 22)
        Me.GameL3.TabIndex = 1
        Me.GameL3.Text = "Template Game"
        Me.GameL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GameL3.Visible = False
        '
        'GameI3
        '
        Me.GameI3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameI3.Image = CType(resources.GetObject("GameI3.Image"), System.Drawing.Image)
        Me.GameI3.Location = New System.Drawing.Point(3, 3)
        Me.GameI3.Name = "GameI3"
        Me.GameI3.Size = New System.Drawing.Size(214, 247)
        Me.GameI3.TabIndex = 0
        Me.GameI3.TabStop = False
        Me.GameI3.Visible = False
        '
        'HomePanel
        '
        Me.HomePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.HomePanel.Controls.Add(Me.HomeBtn3)
        Me.HomePanel.Controls.Add(Me.HomeBtn2)
        Me.HomePanel.Controls.Add(Me.HomeBtn1)
        Me.HomePanel.Controls.Add(Me.HomePictureBox)
        Me.HomePanel.Location = New System.Drawing.Point(9, 19)
        Me.HomePanel.Name = "HomePanel"
        Me.HomePanel.Size = New System.Drawing.Size(1072, 251)
        Me.HomePanel.TabIndex = 4
        Me.HomePanel.Visible = False
        '
        'HomeBtn3
        '
        Me.HomeBtn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HomeBtn3.Image = CType(resources.GetObject("HomeBtn3.Image"), System.Drawing.Image)
        Me.HomeBtn3.Location = New System.Drawing.Point(539, 209)
        Me.HomeBtn3.Name = "HomeBtn3"
        Me.HomeBtn3.Size = New System.Drawing.Size(42, 24)
        Me.HomeBtn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HomeBtn3.TabIndex = 3
        Me.HomeBtn3.TabStop = False
        Me.HomeBtn3.Visible = False
        '
        'HomeBtn2
        '
        Me.HomeBtn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HomeBtn2.Image = CType(resources.GetObject("HomeBtn2.Image"), System.Drawing.Image)
        Me.HomeBtn2.Location = New System.Drawing.Point(500, 209)
        Me.HomeBtn2.Name = "HomeBtn2"
        Me.HomeBtn2.Size = New System.Drawing.Size(42, 24)
        Me.HomeBtn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HomeBtn2.TabIndex = 2
        Me.HomeBtn2.TabStop = False
        Me.HomeBtn2.Visible = False
        '
        'HomeBtn1
        '
        Me.HomeBtn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HomeBtn1.Image = CType(resources.GetObject("HomeBtn1.Image"), System.Drawing.Image)
        Me.HomeBtn1.Location = New System.Drawing.Point(462, 209)
        Me.HomeBtn1.Name = "HomeBtn1"
        Me.HomeBtn1.Size = New System.Drawing.Size(42, 24)
        Me.HomeBtn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HomeBtn1.TabIndex = 1
        Me.HomeBtn1.TabStop = False
        Me.HomeBtn1.Visible = False
        '
        'HomePictureBox
        '
        Me.HomePictureBox.Image = CType(resources.GetObject("HomePictureBox.Image"), System.Drawing.Image)
        Me.HomePictureBox.Location = New System.Drawing.Point(13, 13)
        Me.HomePictureBox.Name = "HomePictureBox"
        Me.HomePictureBox.Size = New System.Drawing.Size(1053, 176)
        Me.HomePictureBox.TabIndex = 0
        Me.HomePictureBox.TabStop = False
        Me.HomePictureBox.Visible = False
        '
        'GamePanel
        '
        Me.GamePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GamePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.GamePanel.Controls.Add(Me.GameLabel)
        Me.GamePanel.Controls.Add(Me.GameImage)
        Me.GamePanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GamePanel.Location = New System.Drawing.Point(975, 498)
        Me.GamePanel.Name = "GamePanel"
        Me.GamePanel.Size = New System.Drawing.Size(220, 293)
        Me.GamePanel.TabIndex = 3
        Me.GamePanel.Visible = False
        '
        'GameLabel
        '
        Me.GameLabel.AutoSize = True
        Me.GameLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameLabel.ForeColor = System.Drawing.Color.White
        Me.GameLabel.Location = New System.Drawing.Point(32, 259)
        Me.GameLabel.Name = "GameLabel"
        Me.GameLabel.Size = New System.Drawing.Size(159, 22)
        Me.GameLabel.TabIndex = 1
        Me.GameLabel.Text = "Template Game"
        Me.GameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GameLabel.Visible = False
        '
        'GameImage
        '
        Me.GameImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameImage.Image = CType(resources.GetObject("GameImage.Image"), System.Drawing.Image)
        Me.GameImage.Location = New System.Drawing.Point(3, 3)
        Me.GameImage.Name = "GameImage"
        Me.GameImage.Size = New System.Drawing.Size(214, 247)
        Me.GameImage.TabIndex = 0
        Me.GameImage.TabStop = False
        Me.GameImage.Visible = False
        '
        'HomeBannerTimer
        '
        Me.HomeBannerTimer.Interval = 6000
        '
        'DragControl2
        '
        Me.DragControl2.Fixed = True
        Me.DragControl2.Horizontal = True
        Me.DragControl2.TargetControl = Me.TopDragPanel
        Me.DragControl2.Vertical = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1087, 604)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopDragPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameLauncher"
        Me.TopDragPanel.ResumeLayout(False)
        Me.TopDragPanel.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProfilBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContentPanel.ResumeLayout(False)
        Me.Game1.ResumeLayout(False)
        Me.Game1.PerformLayout()
        CType(Me.GameI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Home3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Home2.ResumeLayout(False)
        Me.Home2.PerformLayout()
        Me.Game4.ResumeLayout(False)
        Me.Game4.PerformLayout()
        CType(Me.GameI4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Game2.ResumeLayout(False)
        Me.Game2.PerformLayout()
        CType(Me.GameI2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Game3.ResumeLayout(False)
        Me.Game3.PerformLayout()
        CType(Me.GameI3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HomePanel.ResumeLayout(False)
        CType(Me.HomeBtn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeBtn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeBtn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GamePanel.ResumeLayout(False)
        Me.GamePanel.PerformLayout()
        CType(Me.GameImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopDragPanel As Panel
    Friend WithEvents DragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TopLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents HomeBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GamesBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ContentPanel As Panel
    Friend WithEvents GamePanel As Panel
    Friend WithEvents GameLabel As Label
    Friend WithEvents GameImage As PictureBox
    Friend WithEvents HomePanel As Panel
    Friend WithEvents HomePictureBox As PictureBox
    Friend WithEvents HomeBtn1 As PictureBox
    Friend WithEvents HomeBtn3 As PictureBox
    Friend WithEvents HomeBtn2 As PictureBox
    Friend WithEvents HomeBannerTimer As Timer
    Friend WithEvents Game4 As Panel
    Friend WithEvents GameL4 As Label
    Friend WithEvents GameI4 As PictureBox
    Friend WithEvents Game2 As Panel
    Friend WithEvents GameL2 As Label
    Friend WithEvents GameI2 As PictureBox
    Friend WithEvents Game3 As Panel
    Friend WithEvents GameL3 As Label
    Friend WithEvents GameI3 As PictureBox
    Friend WithEvents Home2 As Panel
    Friend WithEvents Home4 As Panel
    Friend WithEvents Home3 As Panel
    Friend WithEvents Home2Label As Label
    Friend WithEvents HomeVersion As Label
    Friend WithEvents Game1 As Panel
    Friend WithEvents GameL1 As Label
    Friend WithEvents GameI1 As PictureBox
    Friend WithEvents ProfilBtn As PictureBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DragControl2 As Bunifu.Framework.UI.BunifuDragControl
End Class
