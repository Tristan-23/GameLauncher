Public Class Game

    Public Sub New()

    End Sub

    Private gameInt As Integer = 0
    Private pointX As Integer = 25
    Private pointY As Integer = 19
    Private point As Point = New Point(pointX, pointY)

    Private labelPointX As Integer = 32
    Private labelPointY As Integer = 259
    Private labelPoint As Point = New Point(labelPointX, labelPointY)

    Private imagePointX As Integer = 3
    Private imagePointY As Integer = 3
    Private imagePoint As Point = New Point(imagePointX, imagePointY)

    Public Sub add(nameobj As String, imgobj As Image)
        If gameInt = 0 Then
            gameInt += 1
        Else
            gameInt += 1
            pointX += 230
            labelPointX += 230
            imagePointX += 230
        End If
        drawGameTabs(nameobj, imgobj)
    End Sub

    Public Sub drawGameTabs(name As String, img As Image)

        Dim GamePanel1 As New Panel()
        Dim GameLabel1 As New Label()
        Dim GameImage1 As New PictureBox()

        Form1.addToGamesList(GamePanel1)
        Form1.addToGamesList(GameLabel1)
        Form1.addToGamesList(GameImage1)

        GamePanel1.Size = New Size(220, 293)
        GamePanel1.BackColor = Color.FromArgb(70, 73, 76)
        GamePanel1.Location = point
        GamePanel1.Cursor = Cursors.Hand

        GameLabel1.Location = labelPoint
        GameLabel1.Left = GamePanel1.Width / 4
        GameLabel1.Text = name
        GameLabel1.Font = New Font("Century Gothic", 14)
        GameLabel1.RightToLeft = False
        GameLabel1.BackColor = Color.FromArgb(70, 73, 76)
        GameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        GameLabel1.Size = New Size(159, 22)
        GameLabel1.Top = GameLabel1.Location.X + 225
        GameLabel1.ForeColor = Color.White
        GameLabel1.Cursor = Cursors.Hand

        GameImage1.Size = New Size(214, 247)
        GameImage1.Location = imagePoint
        GameImage1.Left = GameImage1.Location.Y + 25
        GameImage1.Top = GameImage1.Location.X - 5
        GameImage1.Image = img
        GameImage1.Cursor = Cursors.Hand


        Form1.ContentPanel.Controls.Add(GameLabel1)
        Form1.ContentPanel.Controls.Add(GameImage1)
        Form1.ContentPanel.Controls.Add(GamePanel1)

    End Sub



End Class
