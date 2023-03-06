Imports MySql.Data.MySqlClient
Public Class frmAddInv

    Private Sub UpdateQuantity()

        Try
            Dim qty As Double
            Dim sql As String
            Dim cmd As New MySqlCommand
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter
            Dim availstocks As Integer
            myconn.Open()

            sql = "Select * FROM tblinv WHERE NAME = '" & txtItemName.Text & "' AND QUANTITY = '" & txtQuantity.Text & "'"
            cmd.Connection = myconn()
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                qty = Val(txtQuantity.Text)
                availstocks = Val((dt.Rows(0).Item("QUANTITY").ToString - qty))

                MyUpdate("UPDATE tblinv SET QUANTITY = '" & availstocks & "' WHERE CONTROLNUMBER = '" & txtCN.Text & "' AND NAME = '" & txtItemName.Text & "'")

            End If
        Catch ex As Exception
        Finally
            myconn.Close()

        End Try
    End Sub

    '// GENERATE AUTO ALPHANUMERIC ID //
    Private Sub autogenerate_ID()
        Dim mysqlconnection As MySqlConnection
        Dim command As New MySqlCommand

        mysqlconnection = New MySqlConnection()
        mysqlconnection.ConnectionString = "server=localhost;user id=root;password=;database=inventorydb; Convert Zero Datetime=True"
        command.Connection = mysqlconnection
        mysqlconnection.Open()

        Dim sqlquery = "select Max(CONTROLNUMBER) from tblinventory "
        command.CommandText = sqlquery
        Dim ID As Integer
        Dim value As String

        value = command.ExecuteScalar().ToString()

        If String.IsNullOrEmpty(value) Then
            value = "ID000"
        End If

        value = value.Substring(3)
        Int32.TryParse(value, ID)
        ID = ID + 1
        value = "ID" + ID.ToString("D3")
        txtCN.Text = value

        command.Dispose()
        mysqlconnection.Close()
        mysqlconnection.Dispose()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmInventory.Show()

    End Sub
    Private num As Integer
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If btnAdd.Text = "Save" Then
            MyInsert("INSERT INTO `tblinventory`(`ITEM`, `DESCRIPTION`, `DATE`, `QUANTITY`, `CONDITIONOFITEM`, `LOCATION`) VALUES ('" & _
                      txtItemName.Text & "', '" & txtDescription.Text & "', '" & dtpDate.Text & "', '" & txtQuantity.Text & "', '" & cbConItem.Text & "', '" & cbLocation.Text & "')")

            frmInventory.dgvInventory.Rows.Clear()
            SelectAll("SELECT * FROM `tblinventory`")
            Me.Close()

        Else

            MyUpdate("UPDATE `tblinv` SET `NAME`='" & txtItemName.Text & "', `ITEMTYPE`='" & cbConItem.Text & "', `CONTROLNUMBER`='" & txtCN.Text & _
                     "', `LOCATION`='" & cbLocation.Text & "', `QUANTITY`='" & txtQuantity.Text & "', '" & Format(dtpDate.Value, "MM/dd/yyyy") & _
                     "', `DESCRIPTION`='" & txtDescription.Text & "' WHERE `CONTROLNUMBER`='" & frmInventory.dgvInventory.CurrentRow.Cells(0).Value & "'")

        End If

        frmInventory.dgvInventory.Rows.Clear()
        SelectAll("SELECT * FROM `tblinv`")
        MyLoad(frmInventory.dgvInventory, "LoadInv")
        Me.Close()
        frmInventory.Show()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        frmInventory.Show()

    End Sub

    Private Sub frmAddInv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateQuantity()
        autogenerate_ID()
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class