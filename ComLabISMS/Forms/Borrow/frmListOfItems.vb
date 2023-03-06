Public Class frmListOfItems

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvListOfItems.Rows.Clear()
        SelectAll("SELECT * FROM `tblinv`")
        MyLoad(dgvListOfItems, "LoadItems")
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub dgvListOfItems_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListOfItems.CellDoubleClick
        frmAddBorRet.txtSelectItem.Text = dgvListOfItems.CurrentRow.Cells(1).Value
        Me.Close()
    End Sub
End Class