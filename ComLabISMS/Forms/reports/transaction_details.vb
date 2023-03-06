Public Class transaction_details

    Private Sub transaction_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
        dgvDetails.Rows.Clear()
        SelectAll("SELECT `tblborret_details`.`ID`, tblborret_details.`ITEMID`, tblinv.NAME, tblinv.ITEMTYPE, tblinv.LOCATION, tblborret_details.QUANTITY, tblborret_details.REMARKS, tblborret_details.STATUS FROM `tblborret_details` LEFT JOIN tblinv ON tblborret_details.ITEMID = tblinv.CONTROLNUMBER WHERE tblborret_details.TRANSACTION_ID = '" & Me.Text & "'")
        MyLoad(dgvDetails, "LoadDetailsReport")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        reportname = "BorrowedItemReports"
        reportselect = "SELECT `tblborret_details`.`ID`, tblborret_details.`ITEMID`, tblinv.NAME, tblinv.ITEMTYPE, tblinv.LOCATION, tblborret_details.QUANTITY, tblborret_details.REMARKS, tblborret_details.STATUS FROM `tblborret_details` LEFT JOIN tblinv ON tblborret_details.ITEMID = tblinv.CONTROLNUMBER WHERE tblborret_details.TRANSACTION_ID = '" & Me.Text & "'"
        tblborretreports.Show()

    End Sub
End Class