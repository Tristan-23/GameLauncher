Public Class Login
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        If My.Settings.Login = True Then
            SaveCheck.Checked = True
        Else
            SaveCheck.Checked = False
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If My.Settings.Login = True Then
            Me.Hide()
            Form1.Show()
        Else
            Form1.Hide()
        End If
        Timer1.Stop()

    End Sub


    Private Sub Login_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub


    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.Refresh()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If Not My.Settings.User = Nothing And Not My.Settings.Password = Nothing Then

            If UserText.Text = My.Settings.User And PassText.Text = My.Settings.Password Then
                If SaveCheck.Checked Then
                    My.Settings.Login = True
                Else
                    My.Settings.Login = False
                End If
                My.Settings.Save()
                My.Settings.Reload()
                Me.Hide()
                Form1.Show()

            Else
                MessageBox.Show("Username or password incorrect!")

            End If

        Else
            If Not UserText.Text = "Username" And Not PassText.Text = "Password" And Not UserText.Text = Nothing And Not PassText.Text = Nothing And Not UserText.Text = " " And Not PassText.Text = " " Then
                My.Settings.User = UserText.Text
                My.Settings.Password = PassText.Text
                If SaveCheck.Checked Then
                    My.Settings.Login = True
                Else
                    My.Settings.Login = False
                End If
                My.Settings.Save()
                My.Settings.Reload()
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Please enter a valid username and password!")

            End If

        End If
    End Sub


End Class