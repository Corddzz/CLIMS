
Public Class frmInventory

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvInventory.Rows.Clear()
        SelectAll("SELECT * FROM `tblinventory`")
        MyLoad(dgvInventory, "LoadInv")

    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub btnItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmAddInv.Show()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        MyDelete("DELETE FROM `tblinventory` WHERE `CONTROLNUMBER` ='" & dgvInventory.CurrentRow.Cells(0).Value & "'")
        frmInventory_Load(sender, e)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        frmAddInv.txtItemName.Text = dgvInventory.CurrentRow.Cells(0).Value
        frmAddInv.cbConItem.Text = dgvInventory.CurrentRow.Cells(1).Value
        frmAddInv.txtCN.Text = dgvInventory.CurrentRow.Cells(2).Value
        frmAddInv.cbLocation.Text = dgvInventory.CurrentRow.Cells(3).Value
        frmAddInv.txtQuantity.Text = dgvInventory.CurrentRow.Cells(4).Value
        frmAddInv.dtpDate.Text = dgvInventory.CurrentRow.Cells(5).Value
        frmAddInv.txtDescription.Text = dgvInventory.CurrentRow.Cells(6).Value

        frmAddInv.btnAdd.Text = "Update"
        frmAddInv.Show()

    End Sub


    Private Sub btnComInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComInv.Click
        frmComInv.Show()
        Me.Close()

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        dgvInventory.Rows.Clear()
        SelectAll("SELECT * FROM `tblinventory` WHERE CONTROLNUMBER LIKE '%" & txtSearch.Text & "%' or ITEM LIKE '%" & txtSearch.Text & "%'or DESCRIPTION LIKE '%" & txtSearch.Text & "%'")
        MyLoad(dgvInventory, "LoadInv")
    End Sub
End Class