Public Class GamePanel



    Public Sub New()

    End Sub


    Public GamePanel1 As New Panel()
    Public GameLabel1 As New Label()
    Public GameImage1 As New PictureBox()

    Public Sub createNewGameTab(name As String, img As Image)

        Form1.addToGamesList(GamePanel1)
        Form1.addToGamesList(GameLabel1)
        Form1.addToGamesList(GameImage1)

        GamePanel1.Size = New Size(220, 293)
        GamePanel1.BackColor = Color.FromArgb(70, 73, 76)
        GamePanel1.Location = Form1.getNextLocation()
        GamePanel1.Cursor = Cursors.Hand

        GameLabel1.Location = New Point(32, 259)
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
        GameImage1.Location = New Point(3, 3)
        GameImage1.Left = GameImage1.Location.Y + 25
        GameImage1.Top = GameImage1.Location.X - 5
        GameImage1.Image = img
        GameImage1.Cursor = Cursors.Hand


        Form1.ContentPanel.Controls.Add(GameLabel1)
        Form1.ContentPanel.Controls.Add(GameImage1)
        Form1.ContentPanel.Controls.Add(GamePanel1)

        Form1.GameTabs += 1

    End Sub



End Class
