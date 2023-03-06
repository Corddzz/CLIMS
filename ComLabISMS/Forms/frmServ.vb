Public Class frmServ

    Private Sub btnBorret_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorret.Click
        frmBorret.Show()

    End Sub

    Private Sub btnRepair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepair.Click
        frmRepair2.Show()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Close()

    End Sub
End Class