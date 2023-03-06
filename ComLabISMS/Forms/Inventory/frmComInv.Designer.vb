<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComInv
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
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvComInv = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvComInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDate.Location = New System.Drawing.Point(538, 19)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(345, 31)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "COMPUTER INVENTORY"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1420, 68)
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
        Me.Panel3.Controls.Add(Me.btnDelete)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.dgvComInv)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(220, 68)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 705)
        Me.Panel3.TabIndex = 62
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.ComLabISMS.My.Resources.Resources.icons8_remove_30
        Me.btnDelete.Location = New System.Drawing.Point(912, 15)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(220, 50)
        Me.btnDelete.TabIndex = 69
        Me.btnDelete.Text = "Delete Data"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.ComLabISMS.My.Resources.Resources.icons8_edit_301
        Me.btnUpdate.Location = New System.Drawing.Point(666, 15)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(220, 50)
        Me.btnUpdate.TabIndex = 68
        Me.btnUpdate.Text = "Edit Data"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.ComLabISMS.My.Resources.Resources.icons8_add_new_30
        Me.btnAdd.Location = New System.Drawing.Point(420, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(220, 50)
        Me.btnAdd.TabIndex = 67
        Me.btnAdd.Text = "Add Data"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 20)
        Me.TextBox1.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Search "
        '
        'dgvComInv
        '
        Me.dgvComInv.AllowUserToAddRows = False
        Me.dgvComInv.AllowUserToDeleteRows = False
        Me.dgvComInv.AllowUserToResizeRows = False
        Me.dgvComInv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvComInv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvComInv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvComInv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.dgvComInv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvComInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvComInv.ColumnHeadersHeight = 60
        Me.dgvComInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvComInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvComInv.Location = New System.Drawing.Point(6, 73)
        Me.dgvComInv.Name = "dgvComInv"
        Me.dgvComInv.ReadOnly = True
        Me.dgvComInv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvComInv.RowHeadersVisible = False
        Me.dgvComInv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvComInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComInv.Size = New System.Drawing.Size(1182, 620)
        Me.dgvComInv.TabIndex = 64
        '
        'Column1
        '
        Me.Column1.HeaderText = "COMPUTER ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "COMPUTER NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "DATE ADDED"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "OPERATING SYSTEM"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "RAM"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "PROCESSOR"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "LOCATION"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "STATUS"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "DESCRIPTION"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'frmComInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComLabISMS.My.Resources.Resources.gradient1__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1420, 773)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmComInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmComputers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvComInv, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvComInv As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
