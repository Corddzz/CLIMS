Public Class frmBorrow

    Private Sub RoundButton(ByVal btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btnProfile.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner bottom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btnProfile.Region = New Region(Raduis)

    End Sub

    Private Sub btnServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmServices.Show()

    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmInventory.Show()

    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reportname = "CrystalReport1"
        reportselect = "SELECT * FROM `tblborret`"
        tblborretreports.Show()




    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim result = MessageBox.Show(" Are you sure you want to Exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfile.Click
        frmLogin.Show()

    End Sub
    Sub load_items()
        dgvBorrow.Rows.Clear()
        SelectAll("SELECT * FROM `tblinv`")
        MyLoad(dgvBorrow, "LoadItems")
    End Sub

    Sub load_details()
        dgvDetails.Rows.Clear()
        SelectAll("SELECT `tblborret_details`.`ID`, tblborret_details.`ITEMID`, tblinv.NAME, tblinv.ITEMTYPE, tblinv.LOCATION, tblborret_details.QUANTITY, tblborret_details.REMARKS FROM `tblborret_details` LEFT JOIN tblinv ON tblborret_details.ITEMID = tblinv.CONTROLNUMBER WHERE tblborret_details.TRANSACTION_ID = '" & LabelTransactionID.Text & "' AND tblborret_details.STATUS <> 'Returned'")
        MyLoad(dgvDetails, "LoadDetails")
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_items()
        RoundButton(btnProfile)
        load_details()
        

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '// 24hr Format //
        'lblTime.Text = TimeString

        '// 12hr Format //
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub lblTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTime.Click

    End Sub

    Private Sub dgvBorrow_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBorrow.CellClick
        Me.txtCN.Text = dgvBorrow.CurrentRow.Cells(0).Value
        Me.txtName.Text = dgvBorrow.CurrentRow.Cells(1).Value
        Me.txtItemtype.Text = dgvBorrow.CurrentRow.Cells(2).Value
        Me.txtLocation.Text = dgvBorrow.CurrentRow.Cells(3).Value

        Me.txtDescription.Text = dgvBorrow.CurrentRow.Cells(5).Value
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBorrowItem.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'FIND EXISTING DETAILS
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            sql = "SELECT * FROM `tblborret_details` WHERE `TRANSACTION_ID` = '" & LabelTransactionID.Text & "' AND `ITEMID` = '" & txtCN.Text & "' LIMIT 1"
            With cmd
                cmd.CommandText = sql
                cmd.Connection = con
            End With
            cmd.ExecuteNonQuery()
            Dim dtDataTable As New DataTable
            da.SelectCommand = cmd 
            da.Fill(dtDataTable)
            con.Close()

            If dtDataTable IsNot Nothing AndAlso dtDataTable.Rows.Count > 0 Then
                'if items already exist in the request
                MyUpdate("UPDATE `tblborret_details` SET  `QUANTITY`= `QUANTITY` + " & Val(txtQuantity.Text) & " WHERE `TRANSACTION_ID` = '" & LabelTransactionID.Text & "' AND `ITEMID` = '" & txtCN.Text & "'")
            Else
                'insert new row of request
                MyInsert("INSERT INTO `tblborret_details`(`TRANSACTION_ID`, `ITEMID`, `QUANTITY`, `REMARKS`) VALUES ('" & LabelTransactionID.Text & "', '" & txtCN.Text & "'," & txtQuantity.Text & ", '" & txtRemarks.Text & "')")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try 

        'UPDATE QUANTITY IN TBLINV
        MyUpdate("UPDATE `tblinv` SET `QUANTITY`= `QUANTITY` - " & Val(txtQuantity.Text) & " WHERE `CONTROLNUMBER` = '" & txtCN.Text & "'")

        load_items()
        load_details()
 
        ClearTextBoxes(Panel5)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click


        MyUpdate("UPDATE `tblinv` SET `QUANTITY`= `QUANTITY` + " & dgvDetails.CurrentRow.Cells(5).Value & " WHERE `CONTROLNUMBER` = '" & dgvDetails.CurrentRow.Cells(1).Value.ToString & "'")

        MyDelete("DELETE FROM `tblborret_details` WHERE `ID` ='" & dgvDetails.CurrentRow.Cells(0).Value & "'")


        load_items()
        load_details()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        MyUpdate("UPDATE `tblinv` SET `QUANTITY`= `QUANTITY` + " & dgvDetails.CurrentRow.Cells(5).Value & " WHERE `CONTROLNUMBER` = '" & dgvDetails.CurrentRow.Cells(1).Value.ToString & "'")

        MyUpdate("UPDATE `tblborret_details` SET `STATUS`= 'Returned' WHERE `ID` ='" & dgvDetails.CurrentRow.Cells(0).Value & "'")

        load_items()
        load_details()
    End Sub

End Class