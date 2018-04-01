Public Class Battle2

    Private Sub combate2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.trainer_battle_3_, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hit As New Random
        Dim i As String
        i = Hit.Next(1, 50)
        ProgressBar1.Value = Val(ProgressBar1.Value) - Val(10)
        If ProgressBar1.Value <= 0 Then
            MsgBox("Your Pokémon won", vbInformation, "Samuel&André")
            Close()

        Else : Me.Refresh()
            System.Threading.Thread.Sleep(500)
            ProgressBar2.Value = Val(ProgressBar2.Value) - Val(15)

        End If



        If ProgressBar2.Value <= 0 Then
            MsgBox("Your Pokémon lost", vbInformation, "Samuel&André")
            Close()
            My.Computer.Audio.Stop()
        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Hit As New Random
        Dim i As String
        i = Hit.Next(1, 50)
        ProgressBar1.Value = Val(ProgressBar1.Value) - Val(20)
        If ProgressBar1.Value <= 0 Then
            MsgBox("Your Pokémon won", vbInformation, "Samuel&André")
            Close()

        Else : Me.Refresh()
            System.Threading.Thread.Sleep(500)
            ProgressBar2.Value = Val(ProgressBar2.Value) - Val(15)

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Hit As New Random
        Dim i As String
        i = Hit.Next(1, 50)
        ProgressBar1.Value = Val(ProgressBar1.Value) - Val(30)
        If ProgressBar1.Value <= 0 Then
            MsgBox("Your Pokémon won", vbInformation, "Samuel&André")
            Close()

        Else : Me.Refresh()
            System.Threading.Thread.Sleep(500)
            ProgressBar2.Value = Val(ProgressBar2.Value) - Val(15)

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Hit As New Random
        Dim i As String
        i = Hit.Next(1, 50)
        ProgressBar1.Value = Val(ProgressBar1.Value) - Val(40)
        If ProgressBar1.Value <= 0 Then
            MsgBox("Your Pokémon won", vbInformation, "Samuel&André")
            Close()


        Else : Me.Refresh()
            System.Threading.Thread.Sleep(500)
            ProgressBar2.Value = Val(ProgressBar2.Value) - Val(15)

        End If
    End Sub
End Class

