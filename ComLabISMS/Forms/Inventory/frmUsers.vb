
Public Class frmUsers



    'Private Sub RoundButton(ByVal btn As Button)

    '    Dim radius As New Drawing2D.GraphicsPath
    '    radius.StartFigure()

    '    'Top left Corner
    '    radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
    '    radius.AddLine(10, 0, btn.Width - 20, 0)

    '    'Top Right Corner
    '    radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
    '    radius.AddLine(btnAdd.Width, 20, btn.Width, btn.Height - 10)

    '    'Lower Right Corner
    '    radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

    '    'Lower Left Corner
    '    radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

    '    radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
    '    radius.CloseFigure()

    '    btnAdd.Region = New Region(radius)
    '    btnUpdate.Region = New Region(radius)
    '    btnDelete.Region = New Region(radius)


    'End Sub

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvUser.Rows.Clear()
        SelectAll("SELECT * FROM `tbluser`")
        MyLoad(dgvUser, "LoadUsers")

        '// Round Buttons   //
        'RoundButton(btnAdd)
        'RoundButton(btnUpdate)
        'RoundButton(btnDelete)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmAddInv.txtItemName.Text = dgvUser.CurrentRow.Cells(0).Value
        frmAddInv.cbConItem.Text = dgvUser.CurrentRow.Cells(1).Value
        frmAddInv.txtCN.Text = dgvUser.CurrentRow.Cells(2).Value
        frmAddInv.cbLocation.Text = dgvUser.CurrentRow.Cells(3).Value
        frmAddInv.txtQuantity.Text = dgvUser.CurrentRow.Cells(4).Value
        frmAddInv.txtDescription.Text = dgvUser.CurrentRow.Cells(5).Value

        frmAddInv.btnAdd.Text = "Update"
        frmAddInv.Show()

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'dgvInventory.Rows.Clear()
        'SelectAll("SELECT * FROM `tblinv` WHERE NAME LIKE '%" & txtSearch.Text & "%' OR ITEMTYPE LIKE '%" & _
        '          txtSearch.Text & "%' OR CONTROLNUMBER LIKE '%" & txtSearch.Text & "%'OR LOCATION LIKE '%" & _
        '          txtSearch.Text & "%'")
        'MyLoad(dgvInventory, "LoadInv")
    End Sub

    Private Sub btnServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmItems1.Show()

    End Sub

    Private Sub btnAdd_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

        frmAddInv.Show()


    End Sub

    Private Sub btnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmAddInv.txtItemName.Text = dgvUser.CurrentRow.Cells(0).Value
        frmAddInv.cbConItem.Text = dgvUser.CurrentRow.Cells(1).Value
        frmAddInv.txtCN.Text = dgvUser.CurrentRow.Cells(2).Value
        frmAddInv.cbLocation.Text = dgvUser.CurrentRow.Cells(3).Value
        frmAddInv.txtQuantity.Text = dgvUser.CurrentRow.Cells(4).Value
        frmAddInv.txtDescription.Text = dgvUser.CurrentRow.Cells(5).Value

        frmAddInv.btnAdd.Text = "Update"
        frmAddInv.Show()
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MyDelete("DELETE FROM `tblinv` WHERE `NAME` ='" & dgvUser.CurrentRow.Cells(0).Value & "'")
        frmInventory_Load(sender, e)
    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class