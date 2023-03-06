
Public Class frmComInv


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmInventory.Show()
    End Sub

    Private Sub btnComLab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComLab1.Click
      
        dgvComInv.Rows.Clear()
        SelectAll("SELECT * FROM `tblcominv` WHERE LOCATION = 'Computer Laboratory 1'")
        MyLoad(dgvComInv, "LoadComInv")

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmAddComInv.Show()

    End Sub

    Private Sub frmComInv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvComInv.Rows.Clear()
        SelectAll("SELECT * FROM `tblinventory WHERE LOCATION ")
        MyLoad(dgvComInv, "LoadComInv")
    End Sub

    Private Sub btnComLab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComLab2.Click
        dgvComInv.Rows.Clear()
        SelectAll("SELECT * FROM `tblcominv` WHERE LOCATION = 'Computer Laboratory 2'")
        MyLoad(dgvComInv, "LoadComInv")
    End Sub

    Private Sub btnComLab3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComLab3.Click
        dgvComInv.Rows.Clear()
        SelectAll("SELECT * FROM `tblcominv` WHERE LOCATION = 'Computer Laboratory 3'")
        MyLoad(dgvComInv, "LoadComInv")
    End Sub

    Private Sub btnSpeechLab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeechLab.Click
        dgvComInv.Rows.Clear()
        SelectAll("SELECT * FROM `tblcominv` WHERE LOCATION = 'Speech Lab'")
        MyLoad(dgvComInv, "LoadComInv")
    End Sub

    Private Sub btnTechOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTechOff.Click
        dgvComInv.Rows.Clear()
        SelectAll("SELECT * FROM `tblcominv` WHERE LOCATION = 'Tech Office'")
        MyLoad(dgvComInv, "LoadComInv")
    End Sub
End Class