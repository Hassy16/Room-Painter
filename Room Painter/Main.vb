Public Class frm_Main


    Private Sub btn_Floor_Area_Click(sender As Object, e As EventArgs) Handles btn_Floor_Area.Click

        'Hide Main UI and show Floor Area UI.
        Hide()
        frm_Floor_Area.Show()

    End Sub

    Private Sub btn_Paint_Requirements_Click(sender As Object, e As EventArgs) Handles btn_Paint_Requirements.Click

        'Hide Main UI and show Paint Requirements UI.
        Hide()
        frm_Paint_Requirements.Show()

    End Sub

    Private Sub btn_Room_Volume_Click(sender As Object, e As EventArgs) Handles btn_Room_Volume.Click

        'Hide Main UI and show Room Volume UI.
        Hide()
        frm_Room_Volume.Show()

    End Sub

    Private Sub btn_About_Click(sender As Object, e As EventArgs) Handles btn_About.Click

        'Show About Dialog
        frm_About.Show()

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click

        End

    End Sub


End Class
