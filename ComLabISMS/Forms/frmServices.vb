Public Class frmServices

    Private Sub RoundButton(ByVal btn As Button)

        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()

        'Top left Corner
        radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        radius.AddLine(10, 0, btn.Width - 20, 0)

        'Top Right Corner
        radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        radius.AddLine(btnBorrowReturn.Width, 20, btn.Width, btn.Height - 10)

        'Lower Right Corner
        radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        'Lower Left Corner
        radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        radius.CloseFigure()

        btnBorrowReturn.Region = New Region(radius)
        btnRepair.Region = New Region(radius)
        

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmMain.show()
        Me.Close()

    End Sub

    Private Sub btnRepair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepair.Click
        frmRepair.Show()
        Me.Close()
    End Sub

    Private Sub btnBorrowReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrowReturn.Click
        'frmBorrow.Show()

        frmBorret.Show()
        Me.Close()

    End Sub

    Private Sub frmServices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RoundButton(btnBorrowReturn)
        RoundButton(btnRepair)
    End Sub
End Class