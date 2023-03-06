Imports MySql.Data.MySqlClient


Public Class frmBorrowItem

    Private Sub UpdateQuantity()

        Try
            Dim qty As Double
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            Dim availstocks As Integer
            myconn.Open()

            sql = "Select * FROM tblinv WHERE NAME = '" & txtItem.Text & "' AND QUANTITY = '" & txtQuantity.Text & "'"
            cmd.Connection = myconn()
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                qty = Val(txtQuantity.Text)
                availstocks = Val((dt.Rows(0).Item("QUANTITY").ToString - qty))

                MyUpdate("UPDATE tblinv SET QUANTITY = '" & availstocks & "' WHERE CONTROLNUMBER = '" & txtID.Text & "' AND NAME = '" & txtItem.Text & "'")

            End If
        Catch ex As Exception
        Finally
            myconn.Close()

        End Try
    End Sub

    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "Save" Then
            MyInsert("INSERT INTO `tblborrow`(`ITEM`, `ID`, `QUANTITY`, `LOCATION`, `FIRSTNAME`, `LASTNAME`, `DEPARTMENT`, `DATE`) VALUES ('" & _
                      txtItem.Text & "', '" & txtID.Text & "', '" & txtQuantity.Text & "', '" & txtLocation.Text & "', '" & _
                      txtFirstname.Text & "', '" & txtLastname.Text & "', '" & txtDepartment.Text & "', ''" & Format(dtpDate.Value, "MM/dd/yyyy") & "'")



            frmBorrow.dgvBorrow.Rows.Clear()
            SelectAll("SELECT * FROM `tblborrow`")
            Me.Close()

        Else

            MyUpdate("UPDATE `tblborrow` SET `ITEM`='" & txtItem.Text & "', ID = '" & txtID.Text & "', QUANTITY = '" & txtQuantity.Text & _
                     "', LOCATION = '" & txtLocation.Text & "', FIRSTNAME = '" & txtFirstname.Text & "', LASTNAME = '" & txtLastname.Text & "', DEPARTMENT = '" & _
                     txtDepartment.Text & "', DATE = ''" & Format(dtpDate.Value, "MM/dd/yyyy") & "' WHERE `CONTROLNUMBER`=" & frmBorrow.dgvBorrow.CurrentRow.Cells(0).Value & "")

        End If

        frmBorret.dgvBorret.Rows.Clear()
        SelectAll("SELECT * FROM `tblborrow`")
        MyLoad(frmBorret.dgvBorret, "LoadBorrow")
        Me.Close()
        frmBorrow.Show()


    End Sub

    Private Sub frmBorrowItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UpdateQuantity()

        Dim con As MySqlConnection = New MySqlConnection("server=localhost;user id=root;database=inventorydb")
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Try
            dt = New DataTable
            'OPENING THE CONNECTION
            con.Open()
            'HOLDS THE DATA TO BE EXECUTED
            With cmd
                .Connection = con
                .CommandText = " SELECT NAME FROM tblinv "
            End With
            'FILLING THE DATA IN THE DATATABLE
            da.SelectCommand = cmd
            da.Fill(dt)
            'SET A VARIABLE AS A ROW OF DATA IN THE DATATABLE
            Dim r As DataRow
            'CLEARING THE AUTOCOMPLETE SOURCE OF THE TEXTBOX
            txtItem.AutoCompleteCustomSource.Clear()
            'LOOPING THE ROW OF DATA IN THE DATATABLE
            For Each r In dt.Rows
                'ADDING THE DATA IN THE AUTO COMPLETE SOURCE OF THE TEXTBOX
                txtItem.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
            ''''''''''''''''''''''''
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'CLOSING THE CONNECTION
        con.Close()
        da.Dispose()

    End Sub

    Private Sub rbtnEmployee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnEmployee.CheckedChanged
        txtFirstname.Enabled = False
        txtLastname.Enabled = False
        txtDepartment.Enabled = False
        dtpDate.Enabled = False
    End Sub

    Private Sub rbtnStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnStudent.CheckedChanged
        txtFirstname.Enabled = False
        txtLastname.Enabled = False
        txtDepartment.Enabled = False
        dtpDate.Enabled = False
    End Sub

End Class