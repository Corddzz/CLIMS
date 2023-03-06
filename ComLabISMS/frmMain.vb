Public Class frmMain

    Private Sub btnServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServices.Click
        frmServ.Show()

    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click

        frmInventory.Show()

    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        'reportname = "CrystalReport1"
        'reportselect = "SELECT * FROM `tblborret`"
        'tblborretreports.Show()

        frmReports.Show()



    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result = MessageBox.Show(" Are you sure you want to Exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLogin.Show()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '// 24hr Time Format //
        'lblTime.Text = TimeString

        '// 12hr Time Format //
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")

        '// Date //
        lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy")

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        frmUsers.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBorrow.Show()

    End Sub

    Private Sub btnLogout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show(" Are you sure you want to Logout?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
        frmLogin.Close()
        Me.Close()

    End Sub
End Class