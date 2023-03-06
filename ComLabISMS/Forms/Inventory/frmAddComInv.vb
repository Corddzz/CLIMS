Imports MySql.Data.MySqlClient
Public Class frmAddComInv

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        frmComInv.Show()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If btnAdd.Text = "Save" Then
            MyInsert("INSERT INTO `tblcominv`(`COMPUTERNAME`, `DATEADDED`, `OPERATINGSYSTEM`, `RAM`, `PROCESSOR`, `LOCATION`, `STATUS`, `DESCRIPTION`) VALUES ('" & _
                      txtComputerName.Text & "', '" & dtpDate.Text & "', '" & cbOperatingSystem.Text & "', '" & cbRAM.Text & "', '" & cbProcessor.Text & "',  '" & _
                      cbLocation.Text & "', '" & cbStatus.Text & "', '" & txtDescription.Text & "')")

            frmComInv.dgvComInv.Rows.Clear()
            SelectAll("SELECT * FROM `tblcominv`")
            Me.Close()

            'Else

            '    MyUpdate("UPDATE `tblborret` SET `FIRSTNAME`='" & txtSelectItem.Text & "', `LASTNAME`='" & txtLname.Text & _
            '             "', `DEPARTMENT`='" & txtDepartment.Text & "', `SCHOOLYEAR`='" & txtSchoolYear.Text & "', `DATE`='" & dtpDate.Text & _
            '             "', `TYPE`='" & txtTrans.Text & "',`CONDITIONOFITEM`='" & txtCond.Text & "', `DESCRIPTION`='" & txtDesc.Text & _
            '             "' WHERE `CONTROLNUMBER`=" & frmBorret.dgvBorret.CurrentRow.Cells(0).Value & "")

        End If

        frmComInv.dgvComInv.Rows.Clear()
        SelectAll("SELECT * FROM `tblcominv`")
        MyLoad(frmBorret.dgvBorret, "LoadComInv")
        Me.Close()
        frmComInv.Show()

    End Sub
End Class