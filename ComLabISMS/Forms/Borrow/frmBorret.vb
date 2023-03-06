Public Class frmBorret

    Private Sub RoundButton(ByVal btn As Button)

        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()

        'Top left Corner
        radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        radius.AddLine(10, 0, btn.Width - 20, 0)

        'Top Right Corner
        radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        radius.AddLine(btnAdd.Width, 20, btn.Width, btn.Height - 10)

        'Lower Right Corner
        radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        'Lower Left Corner
        radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        radius.CloseFigure()

        btnAdd.Region = New Region(radius)
        btnEdit.Region = New Region(radius)
        btnDelete.Region = New Region(radius)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmServices.Show()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddBorRet.Show()
        Me.Close()

    End Sub

    Private Sub frmBorRet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvBorret.Rows.Clear()
        SelectAll("SELECT * FROM `tblborret`")
        MyLoad(dgvBorret, "LoadBorRet")

        '// Round Buttons   //
        RoundButton(btnAdd)
        RoundButton(btnEdit)
        RoundButton(btnDelete)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MyDelete("DELETE FROM `tblborret` WHERE `CONTROLNUMBER` ='" & dgvBorret.CurrentRow.Cells(0).Value & "'")
        frmBorRet_Load(sender, e)
    End Sub

    Dim sql As String

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dgvBorret.Rows.Clear()
        SelectAll("SELECT * FROM `tblborret` WHERE LASTNAME LIKE '%" & txtSearch.Text & "%' or FIRSTNAME LIKE '%" & txtSearch.Text & "%'")
        MyLoad(dgvBorret, "LoadBorRet")

    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub txtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        dgvBorret.Rows.Clear()
        SelectAll("SELECT * FROM `tblborret` WHERE LASTNAME LIKE '%" & txtSearch.Text & "%' or FIRSTNAME LIKE '%" & txtSearch.Text & "%'")
        MyLoad(dgvBorret, "LoadBorRet")
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmAddBorRet.Show()

    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        MyDelete("DELETE FROM `tblborret` WHERE `CONTROLNUMBER` ='" & dgvBorret.CurrentRow.Cells(0).Value & "'")
        frmBorRet_Load(sender, e)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        frmAddBorRet.txtControlNum.Text = dgvBorret.CurrentRow.Cells(0).Value
        frmAddBorRet.txtSelectItem.Text = dgvBorret.CurrentRow.Cells(1).Value
        frmAddBorRet.txtLname.Text = dgvBorret.CurrentRow.Cells(2).Value
        frmAddBorRet.txtDepartment.Text = dgvBorret.CurrentRow.Cells(3).Value
        frmAddBorRet.txtSchoolYear.Text = dgvBorret.CurrentRow.Cells(4).Value
        frmAddBorRet.dtpDate.Text = dgvBorret.CurrentRow.Cells(5).Value
        frmAddBorRet.txtTrans.Text = dgvBorret.CurrentRow.Cells(6).Value
        frmAddBorRet.txtTrans.Text = dgvBorret.CurrentRow.Cells(7).Value
        frmAddBorRet.txtCond.Text = dgvBorret.CurrentRow.Cells(8).Value
        frmAddBorRet.txtDesc.Text = dgvBorret.CurrentRow.Cells(9).Value
        'Dim oDate As DateTime = Convert.ToDateTime(dgvBorret.CurrentRow.Cells(7).Value)
        'frmAddBorRet.dtpDate.Value = oDate
        'frmAddBorRet.txtTrans.Text = dgvBorret.CurrentRow.Cells(10).Value
        'frmAddBorRet.txtCond.Text = dgvBorret.CurrentRow.Cells(15).Value
        'frmAddBorRet.txtSerNum.Text = dgvBorret.CurrentRow.Cells(16).Value
        'frmAddBorRet.txtDesc.Text = dgvBorret.CurrentRow.Cells(17).Value

        frmAddBorRet.btnSave.Text = "Update"
        frmAddBorRet.Show()
    End Sub
End Class