Imports System.Configuration
Imports System.Collections.Specialized


Public Class Profil


    Public Shared Img As Image
    Private sAttr As String

    Private Sub Profil_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadStuff(Me)
    End Sub


#Region "Loading Stuff"

    Private Sub LoadStuff(profil As Profil)
        Me.StartPosition = FormStartPosition.CenterScreen

        UsernameLabel.Text = My.Settings.User

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(".\data\data.txt", System.Text.Encoding.UTF8)
        If Not fileReader = "np" Then
            ProfilPic.Image = Image.FromFile(fileReader)
        Else
            ProfilPic.Image = Image.FromFile(".\images\pb.png")
        End If



    End Sub

#End Region



#Region "Painting Stuff"

    Private Sub Profil_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub


    Private Sub Profil_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.Refresh()
    End Sub

    Private Sub TopPanel_Paint(sender As Object, e As PaintEventArgs) Handles TopPanel.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub


    Private Sub TopPanel_SizeChanged(sender As Object, e As EventArgs) Handles TopPanel.SizeChanged
        Me.Refresh()
    End Sub

#End Region

#Region "Other Stuff"

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub ProfilPic_Click(sender As Object, e As EventArgs) Handles ProfilPic.Click
        FileDialog.Title = "Please Select a File"
        FileDialog.InitialDirectory = "C:"
        FileDialog.FileName = ""
        FileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
        FileDialog.ShowDialog()
        If Not FileDialog.FileName.ToString = Nothing Then
            setProfilPicture(FileDialog.FileName.ToString)
        End If
    End Sub

    Private Sub setProfilPicture(img As String)
        My.Computer.FileSystem.WriteAllText(".\data\data.txt", img, False)
        My.Settings.PB = img

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(".\data\data.txt", System.Text.Encoding.UTF8)
        If Not fileReader = "np" Then
            ProfilPic.Image = Image.FromFile(My.Settings.PB)
            Form1.ProfilBtn.Image = Image.FromFile(My.Settings.PB)
        Else
            My.Settings.PB = "np"
            ProfilPic.Image = Image.FromFile(".\images\pb.png")
            Form1.ProfilBtn.Image = Image.FromFile(".\images\pb.png")
        End If


    End Sub

#End Region




End Class