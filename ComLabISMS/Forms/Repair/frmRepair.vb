Public Class frmRepair

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
        btnUpdate.Region = New Region(radius)
        btnDelete.Region = New Region(radius)
        btnPrint.Region = New Region(radius)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmMain.Show()
        Me.Close()

    End Sub

    Private Sub frmRepair_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvRepair.Rows.Clear()
        SelectAll("SELECT * FROM `tblrepair`")
        MyLoad(dgvRepair, "LoadRepair")

        RoundButton(btnAdd)
        RoundButton(btnUpdate)
        RoundButton(btnDelete)
        RoundButton(btnPrint)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmAddServ.Show()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        MyDelete("DELETE FROM `tblrepair` WHERE `CONTROLNUMBER` =" & dgvRepair.CurrentRow.Cells(0).Value & "")
        frmRepair_Load(sender, e)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

    End Sub
End Class