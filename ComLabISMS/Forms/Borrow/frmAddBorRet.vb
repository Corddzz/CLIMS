Imports MySql.Data.MySqlClient

Public Class frmAddBorRet


    'GENERATE AUTO ALPHANUMERIC ID
    Private Sub autogenerate_ID()
        Dim mysqlconnection As MySqlConnection
        Dim command As New MySqlCommand

        mysqlconnection = New MySqlConnection()
        mysqlconnection.ConnectionString = "server=localhost;user id=root;password=;database=inventorydb; Convert Zero Datetime=True"
        command.Connection = mysqlconnection
        mysqlconnection.Open()

        Dim sqlquery = "select Max(CONTROLNUMBER) from tblborret "
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
        txtControlNum.Text = value

        command.Dispose()
        mysqlconnection.Close()
        mysqlconnection.Dispose()

    End Sub

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmBorret.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub frmAddBorRet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'Dim rnd = New System.Random        ' Create an instance
        'Dim intResult = rnd.Next(100, 10000)  ' Get random numbers from 100 to 10000
        'txtControlNum.Text = intResult.ToString

        RoundButton(btnSave)
        RoundButton(btnCancel)
    End Sub
    Private num As Integer
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If btnSave.Text = "Save" Then
            MyInsert("INSERT INTO `tblborret`(`CONTROLNUMBER`, `FIRSTNAME`, `LASTNAME`, `DEPARTMENT`, `SCHOOLYEAR`, `DATE`, `TYPE`, `CONDITIONOFITEM`, `DESCRIPTION`) VALUES ('" & _
                      txtControlNum.Text & "', '" & txtSelectItem.Text & "', '" & txtLname.Text & "', '" & txtDepartment.Text & "', '" & txtSchoolYear.Text & "',  '" & _
                      dtpDate.Text & "', '" & txtTrans.Text & "', '" & txtCond.Text & "', '" & txtDesc.Text & "')")

            autogenerate_ID()
            frmBorret.dgvBorret.Rows.Clear()
            SelectAll("SELECT * FROM `tblborret`")
            Me.Close()

        Else

            MyUpdate("UPDATE `tblborret` SET `FIRSTNAME`='" & txtSelectItem.Text & "', `LASTNAME`='" & txtLname.Text & _
                     "', `DEPARTMENT`='" & txtDepartment.Text & "', `SCHOOLYEAR`='" & txtSchoolYear.Text & "', `DATE`='" & dtpDate.Text & _
                     "', `TYPE`='" & txtTrans.Text & "',`CONDITIONOFITEM`='" & txtCond.Text & "', `DESCRIPTION`='" & txtDesc.Text & _
                     "' WHERE `CONTROLNUMBER`=" & frmBorret.dgvBorret.CurrentRow.Cells(0).Value & "")

        End If

        frmBorret.dgvBorret.Rows.Clear()
        SelectAll("SELECT * FROM `tblborret`")
        MyLoad(frmBorret.dgvBorret, "LoadBorRet")
        Me.Close()
        frmBorret.Show()


    End Sub

    'Sub autoid()
    '    Dim cn As New MySqlConnection
    '    Dim cmd As New MySqlCommand
    '    cn.ConnectionString = "server=localhost;user id=root;password=;database=inventorydb; Convert Zero Datetime=True"
    '    cmd.Connection = cn
    '    cn.Open()

    '    Dim number As Integer

    '    cmd.CommandText = "SELECT Max(ID) FROM `tblinv` "

    '    If IsDBNull(cmd.ExecuteScalar) Then
    '        number = 1
    '        txtControlNum.Text = number
    '    Else
    '        number = cmd.ExecuteScalar + 1
    '        txtControlNum.Text = number
    '        cmd.Dispose()
    '        cn.Close()
    '        cmd.Dispose()

    '    End If

    Private Sub btnSelectItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectItem.Click
        frmListOfItems.Show()
    End Sub

End Class