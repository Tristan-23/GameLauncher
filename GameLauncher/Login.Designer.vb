<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.UserText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.PassText = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.LoginBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.SaveCheck = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TopPanel.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(184, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.BunifuImageButton1)
        Me.TopPanel.Controls.Add(Me.Label1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(501, 81)
        Me.TopPanel.TabIndex = 1
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(471, 6)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(27, 25)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'UserText
        '
        Me.UserText.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.UserText.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.UserText.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.UserText.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.UserText.BorderThickness = 3
        Me.UserText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.UserText.ForeColor = System.Drawing.Color.White
        Me.UserText.isPassword = False
        Me.UserText.Location = New System.Drawing.Point(0, 199)
        Me.UserText.Margin = New System.Windows.Forms.Padding(4)
        Me.UserText.Name = "UserText"
        Me.UserText.Size = New System.Drawing.Size(501, 44)
        Me.UserText.TabIndex = 2
        Me.UserText.Text = "Username"
        Me.UserText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PassText
        '
        Me.PassText.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PassText.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PassText.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PassText.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PassText.BorderThickness = 3
        Me.PassText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PassText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.PassText.ForeColor = System.Drawing.Color.White
        Me.PassText.isPassword = False
        Me.PassText.Location = New System.Drawing.Point(0, 242)
        Me.PassText.Margin = New System.Windows.Forms.Padding(4)
        Me.PassText.Name = "PassText"
        Me.PassText.Size = New System.Drawing.Size(501, 44)
        Me.PassText.TabIndex = 3
        Me.PassText.Text = "Password"
        Me.PassText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Timer1
        '
        '
        'DragControl
        '
        Me.DragControl.Fixed = True
        Me.DragControl.Horizontal = True
        Me.DragControl.TargetControl = Me.TopPanel
        Me.DragControl.Vertical = True
        '
        'LoginBtn
        '
        Me.LoginBtn.ActiveBorderThickness = 1
        Me.LoginBtn.ActiveCornerRadius = 20
        Me.LoginBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LoginBtn.ActiveForecolor = System.Drawing.Color.Gray
        Me.LoginBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LoginBtn.BackgroundImage = CType(resources.GetObject("LoginBtn.BackgroundImage"), System.Drawing.Image)
        Me.LoginBtn.ButtonText = "Login"
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.IdleBorderThickness = 1
        Me.LoginBtn.IdleCornerRadius = 20
        Me.LoginBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LoginBtn.IdleForecolor = System.Drawing.Color.White
        Me.LoginBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LoginBtn.Location = New System.Drawing.Point(-21, -17)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(618, 69)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LoginBtn)
        Me.Panel1.Location = New System.Drawing.Point(-37, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 38)
        Me.Panel1.TabIndex = 5
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'SaveCheck
        '
        Me.SaveCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SaveCheck.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.SaveCheck.Checked = False
        Me.SaveCheck.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.SaveCheck.ForeColor = System.Drawing.Color.White
        Me.SaveCheck.Location = New System.Drawing.Point(160, 379)
        Me.SaveCheck.Name = "SaveCheck"
        Me.SaveCheck.Size = New System.Drawing.Size(20, 20)
        Me.SaveCheck.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(186, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Save password?"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(501, 639)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveCheck)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PassText)
        Me.Controls.Add(Me.UserText)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TopPanel As Panel
    Friend WithEvents UserText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PassText As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents LoginBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveCheck As Bunifu.Framework.UI.BunifuCheckbox
End Class
