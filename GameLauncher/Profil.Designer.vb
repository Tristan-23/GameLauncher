<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profil))
        Me.BGPanel = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.ProfilPic = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DragControl = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.FileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BGPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BGPanel
        '
        Me.BGPanel.BackgroundImage = CType(resources.GetObject("BGPanel.BackgroundImage"), System.Drawing.Image)
        Me.BGPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BGPanel.Controls.Add(Me.TopPanel)
        Me.BGPanel.Controls.Add(Me.ShapeContainer1)
        Me.BGPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BGPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BGPanel.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BGPanel.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BGPanel.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BGPanel.Location = New System.Drawing.Point(0, 0)
        Me.BGPanel.Name = "BGPanel"
        Me.BGPanel.Quality = 10
        Me.BGPanel.Size = New System.Drawing.Size(308, 573)
        Me.BGPanel.TabIndex = 0
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.BunifuImageButton1)
        Me.TopPanel.Controls.Add(Me.UsernameLabel)
        Me.TopPanel.Controls.Add(Me.ProfilPic)
        Me.TopPanel.Controls.Add(Me.ShapeContainer2)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(308, 92)
        Me.TopPanel.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(279, 7)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(22, 24)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 7
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(86, 34)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(101, 22)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "Username"
        '
        'ProfilPic
        '
        Me.ProfilPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProfilPic.Image = CType(resources.GetObject("ProfilPic.Image"), System.Drawing.Image)
        Me.ProfilPic.Location = New System.Drawing.Point(12, 12)
        Me.ProfilPic.Name = "ProfilPic"
        Me.ProfilPic.Size = New System.Drawing.Size(68, 66)
        Me.ProfilPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilPic.TabIndex = 5
        Me.ProfilPic.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4})
        Me.ShapeContainer2.Size = New System.Drawing.Size(308, 92)
        Me.ShapeContainer2.TabIndex = 8
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = -10
        Me.LineShape4.X2 = 317
        Me.LineShape4.Y1 = 91
        Me.LineShape4.Y2 = 91
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(308, 573)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 307
        Me.LineShape3.X2 = 307
        Me.LineShape3.Y1 = -4
        Me.LineShape3.Y2 = 586
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 315
        Me.LineShape2.Y1 = 572
        Me.LineShape2.Y2 = 572
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 0
        Me.LineShape1.Y1 = -5
        Me.LineShape1.Y2 = 574
        '
        'DragControl
        '
        Me.DragControl.Fixed = True
        Me.DragControl.Horizontal = True
        Me.DragControl.TargetControl = Me.TopPanel
        Me.DragControl.Vertical = True
        '
        'FileDialog
        '
        Me.FileDialog.FileName = "OpenFileDialog1"
        '
        'Profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 573)
        Me.Controls.Add(Me.BGPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profil"
        Me.BGPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BGPanel As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents DragControl As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents ProfilPic As PictureBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents FileDialog As OpenFileDialog
End Class
