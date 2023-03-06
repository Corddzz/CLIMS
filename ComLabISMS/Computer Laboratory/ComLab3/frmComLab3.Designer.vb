<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComLab3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblDate = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnBack = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnTechOff = New System.Windows.Forms.Button
        Me.btnSpeechLab = New System.Windows.Forms.Button
        Me.btnComLab3 = New System.Windows.Forms.Button
        Me.btnComLab2 = New System.Windows.Forms.Button
        Me.btnComLab1 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.dgvComputerInventory = New System.Windows.Forms.DataGridView
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvComputerInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDate.Location = New System.Drawing.Point(437, 19)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(391, 31)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "COMPUTER LABORATORY 1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1264, 68)
        Me.Panel2.TabIndex = 53
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = Global.ComLabISMS.My.Resources.Resources.icons8_login_rounded_30
        Me.btnBack.Location = New System.Drawing.Point(0, 655)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(220, 50)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnTechOff)
        Me.Panel4.Controls.Add(Me.btnSpeechLab)
        Me.Panel4.Controls.Add(Me.btnComLab3)
        Me.Panel4.Controls.Add(Me.btnComLab2)
        Me.Panel4.Controls.Add(Me.btnComLab1)
        Me.Panel4.Controls.Add(Me.btnBack)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(220, 705)
        Me.Panel4.TabIndex = 55
        '
        'btnTechOff
        '
        Me.btnTechOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnTechOff.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTechOff.FlatAppearance.BorderSize = 0
        Me.btnTechOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTechOff.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnTechOff.ForeColor = System.Drawing.Color.White
        Me.btnTechOff.Image = Global.ComLabISMS.My.Resources.Resources.icons8_workstation_30
        Me.btnTechOff.Location = New System.Drawing.Point(0, 324)
        Me.btnTechOff.Name = "btnTechOff"
        Me.btnTechOff.Size = New System.Drawing.Size(220, 81)
        Me.btnTechOff.TabIndex = 16
        Me.btnTechOff.Text = "TECHNICAL OFFICE"
        Me.btnTechOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTechOff.UseVisualStyleBackColor = False
        '
        'btnSpeechLab
        '
        Me.btnSpeechLab.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnSpeechLab.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSpeechLab.FlatAppearance.BorderSize = 0
        Me.btnSpeechLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeechLab.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnSpeechLab.ForeColor = System.Drawing.Color.White
        Me.btnSpeechLab.Image = Global.ComLabISMS.My.Resources.Resources.icons8_workstation_30
        Me.btnSpeechLab.Location = New System.Drawing.Point(0, 243)
        Me.btnSpeechLab.Name = "btnSpeechLab"
        Me.btnSpeechLab.Size = New System.Drawing.Size(220, 81)
        Me.btnSpeechLab.TabIndex = 15
        Me.btnSpeechLab.Text = "SPEECH LAB"
        Me.btnSpeechLab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSpeechLab.UseVisualStyleBackColor = False
        '
        'btnComLab3
        '
        Me.btnComLab3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnComLab3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComLab3.FlatAppearance.BorderSize = 0
        Me.btnComLab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComLab3.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnComLab3.ForeColor = System.Drawing.Color.White
        Me.btnComLab3.Image = Global.ComLabISMS.My.Resources.Resources.icons8_workstation_30
        Me.btnComLab3.Location = New System.Drawing.Point(0, 162)
        Me.btnComLab3.Name = "btnComLab3"
        Me.btnComLab3.Size = New System.Drawing.Size(220, 81)
        Me.btnComLab3.TabIndex = 14
        Me.btnComLab3.Text = "COMPUTER LAB 3"
        Me.btnComLab3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnComLab3.UseVisualStyleBackColor = False
        '
        'btnComLab2
        '
        Me.btnComLab2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnComLab2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComLab2.FlatAppearance.BorderSize = 0
        Me.btnComLab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComLab2.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnComLab2.ForeColor = System.Drawing.Color.White
        Me.btnComLab2.Image = Global.ComLabISMS.My.Resources.Resources.icons8_workstation_30
        Me.btnComLab2.Location = New System.Drawing.Point(0, 81)
        Me.btnComLab2.Name = "btnComLab2"
        Me.btnComLab2.Size = New System.Drawing.Size(220, 81)
        Me.btnComLab2.TabIndex = 13
        Me.btnComLab2.Text = "COMPUTER LAB 2"
        Me.btnComLab2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnComLab2.UseVisualStyleBackColor = False
        '
        'btnComLab1
        '
        Me.btnComLab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnComLab1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComLab1.FlatAppearance.BorderSize = 0
        Me.btnComLab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComLab1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnComLab1.ForeColor = System.Drawing.Color.White
        Me.btnComLab1.Image = Global.ComLabISMS.My.Resources.Resources.icons8_workstation_30
        Me.btnComLab1.Location = New System.Drawing.Point(0, 0)
        Me.btnComLab1.Name = "btnComLab1"
        Me.btnComLab1.Size = New System.Drawing.Size(220, 81)
        Me.btnComLab1.TabIndex = 12
        Me.btnComLab1.Text = "COMPUTER LAB 1"
        Me.btnComLab1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnComLab1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BackgroundImage = Global.ComLabISMS.My.Resources.Resources.KCC_LAB_copy1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.dgvComputerInventory)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(220, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1044, 705)
        Me.Panel3.TabIndex = 62
        '
        'dgvComputerInventory
        '
        Me.dgvComputerInventory.AllowUserToAddRows = False
        Me.dgvComputerInventory.AllowUserToDeleteRows = False
        Me.dgvComputerInventory.AllowUserToResizeRows = False
        Me.dgvComputerInventory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvComputerInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvComputerInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvComputerInventory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.dgvComputerInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvComputerInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvComputerInventory.ColumnHeadersHeight = 60
        Me.dgvComputerInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvComputerInventory.Location = New System.Drawing.Point(204, 137)
        Me.dgvComputerInventory.Name = "dgvComputerInventory"
        Me.dgvComputerInventory.ReadOnly = True
        Me.dgvComputerInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvComputerInventory.RowHeadersVisible = False
        Me.dgvComputerInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvComputerInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComputerInventory.Size = New System.Drawing.Size(637, 430)
        Me.dgvComputerInventory.TabIndex = 63
        '
        'frmComLab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComLabISMS.My.Resources.Resources.gradient1__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 773)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmComLab1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmComputers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvComputerInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnTechOff As System.Windows.Forms.Button
    Friend WithEvents btnSpeechLab As System.Windows.Forms.Button
    Friend WithEvents btnComLab3 As System.Windows.Forms.Button
    Friend WithEvents btnComLab2 As System.Windows.Forms.Button
    Friend WithEvents btnComLab1 As System.Windows.Forms.Button
    Friend WithEvents dgvComputerInventory As System.Windows.Forms.DataGridView
End Class
