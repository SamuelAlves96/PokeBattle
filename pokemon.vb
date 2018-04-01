Public Class pokemon

    Private Sub combate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Pokemon_Ruby_Sapphire_Emerald__Welcome_to_the_Pokemon_World, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub pokemon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox2.Visible = False


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Label1.Text = "Hi, my name is Oak, but people call me Professor Oak"
        Me.Refresh()
        System.Threading.Thread.Sleep(1)
        Button1.Visible = False
        Me.Refresh()
        System.Threading.Thread.Sleep(3000)
        Label1.Text = "This is a POKéMON"
        PictureBox2.Visible = True
        Me.Refresh()
        System.Threading.Thread.Sleep(3000)
        Label1.Text = "Some people use their POKéMON as pets, or to help them with chores"
        Me.Refresh()
        System.Threading.Thread.Sleep(3000)
        Label1.Text = "Others train them to fight"
        Me.Refresh()
        System.Threading.Thread.Sleep(3000)
        Label1.Text = "Try to fight with one"
        Me.Refresh()
        System.Threading.Thread.Sleep(3000)
        Label1.Text = "Start by selecting your POKéMON"
        Me.Refresh()
        System.Threading.Thread.Sleep(6000)
        Label1.Text = "After that choose the POKéMON's attack"
        Me.Refresh()
        System.Threading.Thread.Sleep(5000)
        Label1.Text = "Good luck!"

        Me.Refresh()
        System.Threading.Thread.Sleep(3000)
        PokeChoose.Show()

        Me.Hide()




    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class