Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub
    Private Sub lblWelcome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblWelcome.Click

    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim conn As MySqlConnection
        Dim cmd As New MySqlCommand
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root;password=;database=inventorydb; Convert Zero Datetime=True"
        Dim Reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM tbluser WHERE USERNAME='" & txtUsername.Text & "' AND PASSWORD = '" & txtPassword.Text & "'"
            cmd = New MySqlCommand(query, conn)
            Reader = cmd.ExecuteReader

            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                Dim usertype = Reader.GetString("ROLE")

                If usertype = "Administrator" Then
                    MsgBox("Welcome, Admin!")

                    For j = 0 To 500
                    Next
                    frmMain.Show()
                    Me.Hide()
                    conn.Close()
                    conn.Dispose()

                ElseIf usertype = "Staff" Then
                    MsgBox("Welcome, Staff!")

                    frmMain.btnReports.Enabled = False
                    frmMain.btnUsers.Enabled = False
                    frmMain.btnInventory.Enabled = False

                    For j = 0 To 500
                    Next
                    frmMain.Show()
                    Me.Hide()
                    conn.Close()
                    conn.Dispose()

                ElseIf usertype = "Teacher" Then
                    MsgBox("Welcome, Teacher!")

                    frmMain.btnReports.Enabled = False
                    frmMain.btnUsers.Enabled = False
                    frmMain.btnInventory.Enabled = False
                    frmInventory.btnEdit.Enabled = False
                    frmInventory.btnDelete.Enabled = False
                    frmBorret.btnEdit.Enabled = False
                    frmBorret.btnDelete.Enabled = False

                    For j = 0 To 500
                    Next
                    frmMain.Show()
                    Me.Hide()
                    conn.Close()
                    conn.Dispose()

                ElseIf usertype = "Student" Then
                    MsgBox("Welcome, Student!")

                    frmMain.btnReports.Enabled = False
                    frmMain.btnUsers.Enabled = False
                    frmMain.btnInventory.Enabled = False

                    For j = 0 To 500
                    Next
                    frmMain.Show()
                    Me.Hide()
                    conn.Close()
                    conn.Dispose()

                End If

            Else
                MsgBox("Account Does Not Exist!", MsgBoxStyle.Exclamation)
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            txtUsername.Text = ""
            txtPassword.Text = ""
        End Try

    End Sub
End Class