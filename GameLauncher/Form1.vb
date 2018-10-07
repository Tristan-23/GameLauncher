Public Class Form1


    Public LauncherName As String = "Gaya Launcher"
    Public Version As String = "1.0.0"




    Public gp = New GamePanel()
    Private GamePanelPoint = New Point(25, 19)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.PB = "np"
        'My.Settings.Login = False
        'My.Settings.User = Nothing
        'My.Settings.Password = Nothing
        'My.Settings.Save()
        'My.Settings.Reload()
        SetControls()
        LoadStuff()

    End Sub



#Region "Loading Stuff"

    Public Home As Boolean = True
    Public Game As Boolean = False
    Public HomeList As New List(Of Control)
    Public GamesList As New List(Of Control)
    Public GameTabs As Integer
    Public Games As Integer = 3
    Private GameTabsLocationX As Integer = 25
    Private GameTabsLocationY As Integer = 19

    Private Banner1 As Boolean = True
    Private Banner2 As Boolean = False
    Private Banner3 As Boolean = False

    Public Shared GameList As List(Of Game)

    Private Sub LoadStuff()

        If Not My.Settings.PB = "np" Then
            ProfilBtn.Image = Image.FromFile(My.Settings.PB)
        Else
            ProfilBtn.Image = Image.FromFile(".\images\pb.png")
        End If


        If My.Settings.Login = True Then

        Else
            Me.Hide()
            Login.Show()
        End If

        UsernameLabel.Text = My.Settings.User


        HomeBannerTimer.Start()
        HomeVersion.Text = "Version: " + Version
        TopLabel.Text = LauncherName


        'ADD ALL CONTROLS OF HOME'
        HomeList.Add(HomeBtn1)
        HomeList.Add(HomeBtn2)
        HomeList.Add(HomeBtn3)
        HomeList.Add(HomePanel)
        HomeList.Add(HomePictureBox)
        HomeList.Add(Home2)
        HomeList.Add(Home3)
        HomeList.Add(Home4)
        HomeList.Add(Home2Label)

        'ADD ALL CONTROLS OF GAMES TAB'
        'GamesList.Add(GamePanel)
        'GamesList.Add(GameLabel)
        'GamesList.Add(GameImage)
        addToGamesList(Game1)
        addToGamesList(GameI1)
        addToGamesList(GameL1)
        addToGamesList(Game2)
        addToGamesList(GameI2)
        addToGamesList(GameL2)
        addToGamesList(Game3)
        addToGamesList(GameI3)
        addToGamesList(GameL3)
        addToGamesList(Game4)
        addToGamesList(GameI4)
        addToGamesList(GameL4)

        initGames()

        If Home = True Then

            For Each c As Control In HomeList
                c.Visible = True
            Next

        End If

    End Sub


    Public Sub addToGamesList(c As Control)
        GamesList.Add(c)
    End Sub

    Public Function getNextLocation() As Size

        If GameTabs = 0 Then

            Return New Point(25, 19)
            GameTabsLocationX = GameTabsLocationX + 10

        ElseIf GameTabs > 0 Then

            Return New Point(GameTabsLocationX, GameTabsLocationY)
            GameTabsLocationX = GameTabsLocationX + 10

        End If

    End Function



#End Region



#Region "Painting Stuff"

    Private Sub SetControls()
        For Each MECOntrol As Control In GamePanel.Controls
            AddHandler MECOntrol.MouseEnter, AddressOf MouseEnters
        Next
        For Each MECOntrol As Control In GamePanel.Controls
            AddHandler MECOntrol.MouseLeave, AddressOf MouseLeaves
        Next
    End Sub



    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub


    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.Refresh()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub


    Private Sub MouseEnters(ByVal sender As Object, ByVal e As EventArgs)
        'Dim Farben As New List(Of Pen)
        'Farben.Add(Pens.DimGray)
        'Farben.Add(Pens.Gray)
        'Farben.Add(Pens.DarkGray)
        'Farben.Add(Pens.Silver)
        'Farben.Add(Pens.LightGray)
        'Farben.Add(Pens.Gainsboro)
        'Schatten(GamePanel, Farben, False)
    End Sub

    Private Sub MouseLeaves(ByVal sender As Object, ByVal e As EventArgs)
        'Dim Farben As New List(Of Pen)
        'Farben.Add(Pens.DimGray)
        'Farben.Add(Pens.DimGray)
        'Farben.Add(Pens.DimGray)
        'Farben.Add(Pens.DimGray)
        'Farben.Add(Pens.DimGray)
        'Schatten(GamePanel, Farben, False)
    End Sub

    Private Sub Schatten(ByVal Name As Control, ByVal Farben As List(Of Pen), Optional ByVal Umrandung As Boolean = True)
        Dim g As Graphics = Graphics.FromHwnd(Me.Handle)
        Dim Start As Integer = 0
        If Umrandung = True Then
            Start = 1
            g.DrawRectangle(Pens.Red, New Rectangle(Name.Left - 1, Name.Top - 1, Name.Width + 1, Name.Height + 1))
        End If
        For i As Integer = Start To Farben.Count - 1
            g.DrawRectangle(Farben(i), New Rectangle(Name.Left + Name.Width + i, Name.Top + i, 1, Name.Height + Start))
            g.DrawRectangle(Farben(i), New Rectangle(Name.Left + i, Name.Top + Name.Height + i, Name.Width + Start, 1))
        Next
    End Sub

#End Region



#Region "Home"

#Region "Banner"
    Private Sub HomeBtn1_Click(sender As Object, e As EventArgs) Handles HomeBtn1.Click
        HomePictureBox.Image = Image.FromFile(".\images\1.jpg")
        HomeBtn1.Image = Image.FromFile(".\images\blockFilled.png")
        HomeBtn2.Image = Image.FromFile(".\images\block.png")
        HomeBtn3.Image = Image.FromFile(".\images\block.png")
        Banner1 = True
        Banner2 = False
        Banner3 = False
    End Sub

    Private Sub HomeBtn2_Click(sender As Object, e As EventArgs) Handles HomeBtn2.Click
        HomePictureBox.Image = Image.FromFile(".\images\2.jpg")
        HomeBtn1.Image = Image.FromFile(".\images\block.png")
        HomeBtn2.Image = Image.FromFile(".\images\blockFilled.png")
        HomeBtn3.Image = Image.FromFile(".\images\block.png")
        Banner1 = False
        Banner2 = True
        Banner3 = False
    End Sub

    Private Sub HomeBtn3_Click(sender As Object, e As EventArgs) Handles HomeBtn3.Click
        HomePictureBox.Image = Image.FromFile(".\images\3.jpeg")
        HomeBtn1.Image = Image.FromFile(".\images\block.png")
        HomeBtn2.Image = Image.FromFile(".\images\block.png")
        HomeBtn3.Image = Image.FromFile(".\images\blockFilled.png")
        Banner1 = False
        Banner2 = False
        Banner3 = True
    End Sub



    Private Sub HomeBannerTimer_Tick(sender As Object, e As EventArgs) Handles HomeBannerTimer.Tick
        If Banner1 = True Then
            HomePictureBox.Image = Image.FromFile(".\images\2.jpg")
            HomeBtn1.Image = Image.FromFile(".\images\block.png")
            HomeBtn2.Image = Image.FromFile(".\images\blockFilled.png")
            HomeBtn3.Image = Image.FromFile(".\images\block.png")
            Banner1 = False
            Banner2 = True

        ElseIf Banner2 = True Then
            HomePictureBox.Image = Image.FromFile(".\images\3.jpeg")
            HomeBtn1.Image = Image.FromFile(".\images\block.png")
            HomeBtn2.Image = Image.FromFile(".\images\block.png")
            HomeBtn3.Image = Image.FromFile(".\images\blockFilled.png")
            Banner2 = False
            Banner3 = True

        ElseIf Banner3 = True Then
            HomePictureBox.Image = Image.FromFile(".\images\1.jpg")
            HomeBtn1.Image = Image.FromFile(".\images\blockFilled.png")
            HomeBtn2.Image = Image.FromFile(".\images\block.png")
            HomeBtn3.Image = Image.FromFile(".\images\block.png")
            Banner3 = False
            Banner1 = True

        End If

    End Sub
#End Region

    '\/ ADD HERE MORE STUFF \/'

    Public Sub hideHome()
        For Each c As Control In HomeList
            c.Visible = False
        Next
        HomeBannerTimer.Stop()
        Home = False
    End Sub

    Public Sub showHome()
        If Home = False Then
            For Each c As Control In HomeList
                c.Visible = True
            Next
            HomeBannerTimer.Start()
            Home = True
        End If
    End Sub





#End Region


#Region "Games"
    Public Sub hideGames()
        For Each c As Control In GamesList
            c.Visible = False
        Next
        Game = False
    End Sub

    Public Sub showGames()
        If Game = False Then
            For Each c As Control In GamesList
                c.Visible = True
            Next
            Game = True
        End If
    End Sub




    Public Sub initGames()
        Game1.Location = getNextLocation()
        Game2.Location = New Point(255, 19)
        Game3.Location = New Point(485, 19)
        Game4.Location = New Point(715, 19)

        GameI1.Image = Image.FromFile(".\games\images\game.png")
        GameI2.Image = Image.FromFile(".\games\images\game.png")
        GameI3.Image = Image.FromFile(".\games\images\game.png")
        GameI4.Image = Image.FromFile(".\games\images\game.png")

        'Dim game As Game = New Game()
        'Game.add("CSGO", Image.FromFile(".\games\images\csgo.png"))
        'Game.add("CSGO2", Image.FromFile(".\games\images\csgo.png"))


    End Sub

    Private Sub GameI1_Click(sender As Object, e As EventArgs) Handles GameI1.Click
        MessageBox.Show("No game selected on this tab")
    End Sub

    Private Sub GameI2_Click(sender As Object, e As EventArgs) Handles GameI2.Click
        MessageBox.Show("No game selected on this tab")
    End Sub

    Private Sub GameI3_Click(sender As Object, e As EventArgs) Handles GameI3.Click
        MessageBox.Show("No game selected on this tab")
    End Sub

    Private Sub GameI4_Click(sender As Object, e As EventArgs) Handles GameI4.Click
        MessageBox.Show("No game selected on this tab")
    End Sub

#End Region



#Region "Menu"

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        hideGames()
        showHome()
    End Sub

    Private Sub GamesBtn_Click(sender As Object, e As EventArgs) Handles GamesBtn.Click
        hideHome()
        showGames()
        'gp.createNewGameTab("GTA 5", Image.FromFile(".\games\images\gta.png"))
    End Sub

#End Region


#Region "Profil"

    Private Sub ProfilBtn_Click(sender As Object, e As EventArgs) Handles ProfilBtn.Click
        Profil.Show()

    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click
        Profil.Show()
    End Sub



#End Region



End Class
