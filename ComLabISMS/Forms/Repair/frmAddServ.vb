Public Class frmAddServ
    Dim prio As String
    Private Sub RoundButton(ByVal btn As Button)

        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()

        'Top left Corner
        radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        radius.AddLine(10, 0, btn.Width - 20, 0)

        'Top Right Corner
        radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        radius.AddLine(btnSave.Width, 20, btn.Width, btn.Height - 10)

        'Lower Right Corner
        radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        'Lower Left Corner
        radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        radius.CloseFigure()

        btnSave.Region = New Region(radius)
        btnCancel.Region = New Region(radius)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmRepair.Show()

    End Sub

    Private Sub frmAddServ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RoundButton(btnSave)
        RoundButton(btnCancel)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        frmRepair.Show()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If btnSave.Text = "Save" Then
            MyInsert("INSERT INTO `tblrepair`(`CONTROLNUMBER`, `NAME`, `DEPARTMENT`, `DATEFILED`, `DESCRIPTION`, `PRIORITYCLASS`, `CONFIRMEDDATE`, `REMARKS`) VALUES ('" & _
                      lblAutoNum.Text & "', '" & txtName.Text & "', '" & txtDepartment.Text & "', '" & Format(dtpDate.Value, "MM/dd/yyyy") & "', '" & _
                      txtDescription.Text & "', '" & prio & "', '" & Format(dtpConfirm.Value, "MM/dd/yyyy") & "', '" & txtRemarks.Text & _
                      "')")

            frmRepair.dgvRepair.Rows.Clear()
            SelectAll("SELECT * FROM `tblrepair`")
            Me.Close()

        End If

        frmRepair.dgvRepair.Rows.Clear()
        SelectAll("SELECT * FROM `tblrepair`")
        MyLoad(frmRepair.dgvRepair, "LoadRepair")
        Me.Close()
        frmRepair.Show()

    End Sub

    Private Sub rbtnUrgent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnUrgent.CheckedChanged
        prio = "Urgent"
    End Sub

    Private Sub rbtnNormal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnNormal.CheckedChanged
        prio = "Normal"
    End Sub

    Private Sub rbtnApprove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnApprove.CheckedChanged
        prio = "For Approval & Schedule"
    End Sub

End Class