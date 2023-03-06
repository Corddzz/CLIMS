Public Class transactions

    Private Sub transactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvborRet.Rows.Clear()
        SelectAll("SELECT * FROM `tblborret`")
        MyLoad(dgvborRet, "LoadBorRetFew")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        transaction_details.Text = dgvborRet.CurrentRow.Cells(0).Value
        transaction_details.ShowDialog()
    End Sub
End Class