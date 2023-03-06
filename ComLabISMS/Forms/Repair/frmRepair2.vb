Public Class frmRepair2

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmAddServ.Show()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        MyDelete("DELETE FROM `tblrepair` WHERE `CONTROLNUMBER` =" & dgvRepair2.CurrentRow.Cells(0).Value & "")
        frmRepair2_Load(sender, e)

    End Sub

    Private Sub frmRepair2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvRepair2.Rows.Clear()
        SelectAll("SELECT * FROM `tblrepair`")
        MyLoad(dgvRepair2, "LoadRepair")
    End Sub
End Class