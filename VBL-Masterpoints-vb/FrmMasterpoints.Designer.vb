<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMasterpoints
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasterpoints))
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblFileType = New System.Windows.Forms.Label()
        Me.lblMasterpointTable = New System.Windows.Forms.Label()
        Me.dgvMasterpoints = New System.Windows.Forms.DataGridView()
        Me.ColRankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVBL1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColName1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVBL2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColName2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPointsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblMasterpointsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataMasterpoints = New VBL_Masterpoints_vb.DataSetMasterpoints()
        Me.sfdFile = New System.Windows.Forms.SaveFileDialog()
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.dgvTotals = New System.Windows.Forms.DataGridView()
        Me.ColVBLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPointsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblTotalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnEmptyTotals = New System.Windows.Forms.Button()
        CType(Me.dgvMasterpoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMasterpointsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataMasterpoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTotals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTotalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbout.Location = New System.Drawing.Point(394, 12)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 0
        Me.btnAbout.Text = "O&ver..."
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'txtFilename
        '
        Me.txtFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilename.Location = New System.Drawing.Point(12, 167)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(457, 20)
        Me.txtFilename.TabIndex = 1
        Me.txtFilename.TabStop = False
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(12, 143)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(49, 13)
        Me.lblFilename.TabIndex = 2
        Me.lblFilename.Text = "Bestand:"
        '
        'ofdFile
        '
        Me.ofdFile.Filter = "Masterpoint-bestanden|*.txt;*.csv"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(67, 138)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFile.TabIndex = 3
        Me.btnOpenFile.Text = "&Openen"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'cmbCategory
        '
        Me.cmbCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(206, 193)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(263, 21)
        Me.cmbCategory.TabIndex = 4
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(12, 196)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(188, 13)
        Me.lblCategory.TabIndex = 5
        Me.lblCategory.Text = "Categorie (enkel voor parentornooien):"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(12, 17)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(376, 78)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'lblFileType
        '
        Me.lblFileType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFileType.Location = New System.Drawing.Point(99, 143)
        Me.lblFileType.Name = "lblFileType"
        Me.lblFileType.Size = New System.Drawing.Size(370, 13)
        Me.lblFileType.TabIndex = 7
        Me.lblFileType.Text = "Type: <geen bestand geselecteerd>"
        Me.lblFileType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMasterpointTable
        '
        Me.lblMasterpointTable.AutoSize = True
        Me.lblMasterpointTable.Location = New System.Drawing.Point(12, 246)
        Me.lblMasterpointTable.Name = "lblMasterpointTable"
        Me.lblMasterpointTable.Size = New System.Drawing.Size(190, 13)
        Me.lblMasterpointTable.TabIndex = 8
        Me.lblMasterpointTable.Text = "Gegevens in laatst geopende bestand:"
        '
        'dgvMasterpoints
        '
        Me.dgvMasterpoints.AllowUserToAddRows = False
        Me.dgvMasterpoints.AllowUserToDeleteRows = False
        Me.dgvMasterpoints.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMasterpoints.AutoGenerateColumns = False
        Me.dgvMasterpoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMasterpoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterpoints.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRankDataGridViewTextBoxColumn, Me.ColVBL1DataGridViewTextBoxColumn, Me.ColName1DataGridViewTextBoxColumn, Me.ColVBL2DataGridViewTextBoxColumn, Me.ColName2DataGridViewTextBoxColumn, Me.ColPointsDataGridViewTextBoxColumn})
        Me.dgvMasterpoints.DataSource = Me.TblMasterpointsBindingSource
        Me.dgvMasterpoints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMasterpoints.Location = New System.Drawing.Point(15, 262)
        Me.dgvMasterpoints.Name = "dgvMasterpoints"
        Me.dgvMasterpoints.Size = New System.Drawing.Size(454, 237)
        Me.dgvMasterpoints.TabIndex = 9
        '
        'ColRankDataGridViewTextBoxColumn
        '
        Me.ColRankDataGridViewTextBoxColumn.DataPropertyName = "colRank"
        Me.ColRankDataGridViewTextBoxColumn.HeaderText = "Rang"
        Me.ColRankDataGridViewTextBoxColumn.Name = "ColRankDataGridViewTextBoxColumn"
        Me.ColRankDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColRankDataGridViewTextBoxColumn.ToolTipText = "Rangschikking van het paar"
        Me.ColRankDataGridViewTextBoxColumn.Width = 58
        '
        'ColVBL1DataGridViewTextBoxColumn
        '
        Me.ColVBL1DataGridViewTextBoxColumn.DataPropertyName = "colVBL1"
        Me.ColVBL1DataGridViewTextBoxColumn.HeaderText = "VBL 1"
        Me.ColVBL1DataGridViewTextBoxColumn.Name = "ColVBL1DataGridViewTextBoxColumn"
        Me.ColVBL1DataGridViewTextBoxColumn.ReadOnly = True
        Me.ColVBL1DataGridViewTextBoxColumn.ToolTipText = "VBL-nummer speler 1"
        Me.ColVBL1DataGridViewTextBoxColumn.Width = 61
        '
        'ColName1DataGridViewTextBoxColumn
        '
        Me.ColName1DataGridViewTextBoxColumn.DataPropertyName = "colName1"
        Me.ColName1DataGridViewTextBoxColumn.HeaderText = "Naam 1"
        Me.ColName1DataGridViewTextBoxColumn.Name = "ColName1DataGridViewTextBoxColumn"
        Me.ColName1DataGridViewTextBoxColumn.ReadOnly = True
        Me.ColName1DataGridViewTextBoxColumn.ToolTipText = "Naam speler 1"
        Me.ColName1DataGridViewTextBoxColumn.Width = 69
        '
        'ColVBL2DataGridViewTextBoxColumn
        '
        Me.ColVBL2DataGridViewTextBoxColumn.DataPropertyName = "colVBL2"
        Me.ColVBL2DataGridViewTextBoxColumn.HeaderText = "VBL 2"
        Me.ColVBL2DataGridViewTextBoxColumn.Name = "ColVBL2DataGridViewTextBoxColumn"
        Me.ColVBL2DataGridViewTextBoxColumn.ReadOnly = True
        Me.ColVBL2DataGridViewTextBoxColumn.ToolTipText = "VBL-nummer speler 2"
        Me.ColVBL2DataGridViewTextBoxColumn.Width = 61
        '
        'ColName2DataGridViewTextBoxColumn
        '
        Me.ColName2DataGridViewTextBoxColumn.DataPropertyName = "colName2"
        Me.ColName2DataGridViewTextBoxColumn.HeaderText = "Naam 2"
        Me.ColName2DataGridViewTextBoxColumn.Name = "ColName2DataGridViewTextBoxColumn"
        Me.ColName2DataGridViewTextBoxColumn.ReadOnly = True
        Me.ColName2DataGridViewTextBoxColumn.ToolTipText = "Naam speler 2"
        Me.ColName2DataGridViewTextBoxColumn.Width = 69
        '
        'ColPointsDataGridViewTextBoxColumn
        '
        Me.ColPointsDataGridViewTextBoxColumn.DataPropertyName = "colPoints"
        Me.ColPointsDataGridViewTextBoxColumn.HeaderText = "Masterpoints"
        Me.ColPointsDataGridViewTextBoxColumn.Name = "ColPointsDataGridViewTextBoxColumn"
        Me.ColPointsDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColPointsDataGridViewTextBoxColumn.ToolTipText = "Toegekende Masterpoints"
        Me.ColPointsDataGridViewTextBoxColumn.Width = 92
        '
        'TblMasterpointsBindingSource
        '
        Me.TblMasterpointsBindingSource.DataMember = "tblMasterpoints"
        Me.TblMasterpointsBindingSource.DataSource = Me.dataMasterpoints
        '
        'dataMasterpoints
        '
        Me.dataMasterpoints.DataSetName = "DataSetMasterpoints"
        Me.dataMasterpoints.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sfdFile
        '
        Me.sfdFile.Filter = "CSV-bestanden|*.csv"
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveFile.Location = New System.Drawing.Point(251, 233)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(218, 23)
        Me.btnSaveFile.TabIndex = 10
        Me.btnSaveFile.Text = "Totalen &exporteren naar CSV"
        Me.btnSaveFile.UseVisualStyleBackColor = True
        '
        'dgvTotals
        '
        Me.dgvTotals.AllowUserToAddRows = False
        Me.dgvTotals.AllowUserToDeleteRows = False
        Me.dgvTotals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTotals.AutoGenerateColumns = False
        Me.dgvTotals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColVBLDataGridViewTextBoxColumn, Me.ColPointsDataGridViewTextBoxColumn1})
        Me.dgvTotals.DataSource = Me.TblTotalsBindingSource
        Me.dgvTotals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTotals.Location = New System.Drawing.Point(475, 41)
        Me.dgvTotals.Name = "dgvTotals"
        Me.dgvTotals.Size = New System.Drawing.Size(247, 458)
        Me.dgvTotals.TabIndex = 11
        '
        'ColVBLDataGridViewTextBoxColumn
        '
        Me.ColVBLDataGridViewTextBoxColumn.DataPropertyName = "colVBL"
        Me.ColVBLDataGridViewTextBoxColumn.HeaderText = "VBL-nummer"
        Me.ColVBLDataGridViewTextBoxColumn.Name = "ColVBLDataGridViewTextBoxColumn"
        Me.ColVBLDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColVBLDataGridViewTextBoxColumn.Width = 92
        '
        'ColPointsDataGridViewTextBoxColumn1
        '
        Me.ColPointsDataGridViewTextBoxColumn1.DataPropertyName = "colPoints"
        Me.ColPointsDataGridViewTextBoxColumn1.HeaderText = "Masterpoints"
        Me.ColPointsDataGridViewTextBoxColumn1.Name = "ColPointsDataGridViewTextBoxColumn1"
        Me.ColPointsDataGridViewTextBoxColumn1.Width = 92
        '
        'TblTotalsBindingSource
        '
        Me.TblTotalsBindingSource.DataMember = "tblTotals"
        Me.TblTotalsBindingSource.DataSource = Me.dataMasterpoints
        '
        'lblTotals
        '
        Me.lblTotals.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotals.AutoSize = True
        Me.lblTotals.Location = New System.Drawing.Point(472, 25)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(46, 13)
        Me.lblTotals.TabIndex = 12
        Me.lblTotals.Text = "Totalen:"
        '
        'btnOptions
        '
        Me.btnOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOptions.Location = New System.Drawing.Point(394, 41)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(75, 23)
        Me.btnOptions.TabIndex = 13
        Me.btnOptions.Text = "O&pties..."
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnEmptyTotals
        '
        Me.btnEmptyTotals.Location = New System.Drawing.Point(604, 12)
        Me.btnEmptyTotals.Name = "btnEmptyTotals"
        Me.btnEmptyTotals.Size = New System.Drawing.Size(118, 23)
        Me.btnEmptyTotals.TabIndex = 14
        Me.btnEmptyTotals.Text = "Totalen &leegmaken"
        Me.btnEmptyTotals.UseVisualStyleBackColor = True
        '
        'FrmMasterpoints
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.btnEmptyTotals)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.lblTotals)
        Me.Controls.Add(Me.dgvTotals)
        Me.Controls.Add(Me.btnSaveFile)
        Me.Controls.Add(Me.dgvMasterpoints)
        Me.Controls.Add(Me.lblMasterpointTable)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.lblFileType)
        Me.Controls.Add(Me.lblInstructions)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(750, 550)
        Me.Name = "FrmMasterpoints"
        Me.Text = "VBL - Masterpoints"
        CType(Me.dgvMasterpoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMasterpointsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataMasterpoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTotals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTotalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAbout As Button
    Friend WithEvents txtFilename As TextBox
    Friend WithEvents lblFilename As Label
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblFileType As Label
    Friend WithEvents lblMasterpointTable As Label
    Friend WithEvents dgvMasterpoints As DataGridView
    Friend WithEvents TblMasterpointsBindingSource As BindingSource
    Friend WithEvents dataMasterpoints As DataSetMasterpoints
    Friend WithEvents ColRankDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColVBL1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColName1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColVBL2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColName2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColPointsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents sfdFile As SaveFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSaveFile As Button
    Friend WithEvents dgvTotals As DataGridView
    Friend WithEvents lblTotals As Label
    Friend WithEvents btnOptions As Button
    Friend WithEvents ColVBLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColPointsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TblTotalsBindingSource As BindingSource
    Friend WithEvents btnEmptyTotals As Button
End Class
