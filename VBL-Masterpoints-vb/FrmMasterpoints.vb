Imports System.IO
Imports System.Text

Public Class FrmMasterpoints

    Dim whitelistExtensions As String() = {"txt", "csv"}
    Dim determinedFileType As String = "" ' Messer of CSV
    Dim intNumberOfSeries As Integer = 0
    Public categories As New Dictionary(Of String, Decimal)
    Dim fso As StreamReader
    Dim sfo As StreamWriter

    Private Function calculatePointsClub(ByVal number_of_pairs As Integer, ByVal rank_of_pair As Integer, Optional ByVal number_of_series As Integer = 1) As Decimal
        ' Declare variables
        Dim percents As New Dictionary(Of Integer, Decimal)
        Dim tmpMaxPoints As Decimal = number_of_pairs * 0.04 / number_of_series
        Dim tmpPointsUntilRank As Integer = number_of_pairs \ (3 * number_of_series)
        Dim tmpKey As Integer = 0

        ' Initialize percents array
        percents.Add(1, 1)
        percents.Add(2, 0.75)
        percents.Add(3, 0.5)
        percents.Add(4, 0.4)
        percents.Add(5, 0.35)
        percents.Add(6, 0.3)
        percents.Add(7, 0.25)
        percents.Add(8, 0.2)
        percents.Add(9, 0.15)
        percents.Add(10, 0.1)
        percents.Add(11, 0.09)
        percents.Add(12, 0.08)
        percents.Add(13, 0.07)
        percents.Add(14, 0.06)
        percents.Add(15, 0.05)
        percents.Add(16, 0.04)
        percents.Add(17, 0.03)
        percents.Add(18, 0.02)
        percents.Add(19, 0.01)

        If rank_of_pair <= tmpPointsUntilRank Then
            tmpKey = rank_of_pair
            Do While Not percents.ContainsKey(tmpKey)
                tmpKey -= 1
            Loop
            Return Math.Round(percents(tmpKey) * tmpMaxPoints, 2, MidpointRounding.AwayFromZero)
        Else
            Return 0.01
        End If
    End Function

    Private Function calculatePointsPairs(ByVal number_of_pairs As Integer, ByVal rank_of_pair As Integer, Optional ByVal number_of_series As Integer = 1, Optional ByVal category_multiplier As Decimal = 1.0, Optional ByVal cap As Decimal = 0.0) As Decimal
        ' Declare variables
        Dim pointsPairs As New Dictionary(Of Integer, Decimal)
        Dim tmpMaxPoints As Decimal = (number_of_pairs * 0.1 / number_of_series) * category_multiplier
        Dim tmpPointsUntilRank As Integer = number_of_pairs \ (3 * number_of_series)
        Dim tmpKey As Integer = 0

        ' Initialize points array
        pointsPairs.Add(1, 1)
        pointsPairs.Add(2, 0.95)
        pointsPairs.Add(3, 0.9)
        pointsPairs.Add(4, 0.85)
        pointsPairs.Add(5, 0.8)
        pointsPairs.Add(6, 0.75)
        pointsPairs.Add(7, 0.7)
        pointsPairs.Add(8, 0.65)
        pointsPairs.Add(9, 0.6)
        pointsPairs.Add(10, 0.55)
        pointsPairs.Add(11, 0.5)
        pointsPairs.Add(12, 0.45)
        pointsPairs.Add(13, 0.4)
        pointsPairs.Add(14, 0.35)
        pointsPairs.Add(15, 0.3)
        pointsPairs.Add(16, 0.25)
        pointsPairs.Add(17, 0.2)
        pointsPairs.Add(18, 0.19)
        pointsPairs.Add(21, 0.18)
        pointsPairs.Add(25, 0.17)
        pointsPairs.Add(29, 0.16)
        pointsPairs.Add(33, 0.15)
        pointsPairs.Add(37, 0.14)
        pointsPairs.Add(41, 0.13)
        pointsPairs.Add(45, 0.12)
        pointsPairs.Add(49, 0.11)
        pointsPairs.Add(53, 0.1)
        pointsPairs.Add(57, 0.09)
        pointsPairs.Add(61, 0.08)
        pointsPairs.Add(66, 0.07)
        pointsPairs.Add(71, 0.06)
        pointsPairs.Add(76, 0.05)
        pointsPairs.Add(81, 0.04)
        pointsPairs.Add(86, 0.03)
        pointsPairs.Add(91, 0.02)
        pointsPairs.Add(96, 0.01)

        ' Cap if necessary
        If cap > 0 And tmpMaxPoints > cap Then
            tmpMaxPoints = cap
        End If

        If rank_of_pair <= tmpPointsUntilRank Then
            tmpKey = rank_of_pair
            Do While Not pointsPairs.ContainsKey(tmpKey)
                tmpKey -= 1
            Loop
            Return Math.Round(pointsPairs(tmpKey) * tmpMaxPoints, 2, MidpointRounding.AwayFromZero)
        Else
            Return 0.01
        End If

    End Function

    Private Function calculatePointsIndiv(ByVal number_of_players As Integer, ByVal rank_of_player As Integer) As Decimal
        ' Declare variables
        Dim percents As New Dictionary(Of Integer, Decimal)
        Dim tmpMaxPoints As Decimal = (number_of_players \ 4) * 0.08
        Dim tmpPointsUntilRank As Integer = ((number_of_players \ 4) * 4) \ 3
        Dim tmpKey As Integer = 0

        ' Initialize points array
        percents.Add(1, 1)
        percents.Add(2, 0.75)
        percents.Add(3, 0.5)
        percents.Add(4, 0.4)
        percents.Add(5, 0.35)
        percents.Add(6, 0.3)
        percents.Add(7, 0.25)
        percents.Add(8, 0.2)
        percents.Add(9, 0.15)
        percents.Add(10, 0.1)
        percents.Add(11, 0.09)
        percents.Add(12, 0.08)
        percents.Add(13, 0.07)
        percents.Add(14, 0.06)
        percents.Add(15, 0.05)
        percents.Add(16, 0.04)
        percents.Add(17, 0.03)
        percents.Add(18, 0.02)
        percents.Add(19, 0.01)

        If rank_of_player <= tmpPointsUntilRank Then
            tmpKey = rank_of_player
            Do While Not percents.ContainsKey(tmpKey)
                tmpKey -= 1
            Loop
            Return Math.Round(percents(tmpKey) * tmpMaxPoints, 2, MidpointRounding.AwayFromZero)
        Else
            Return 0.01
        End If

    End Function

    Private Sub checkFile(ByVal filename As String)
        Dim strFileExtension As String = filename.Substring(filename.Length - 3)
        Dim strFirstLine As String
        If Not whitelistExtensions.Contains(strFileExtension) Then
            MessageBox.Show("Het bestand heeft niet de juiste extensie." + vbCrLf + vbCrLf + "Dit programma kan enkel de volgende bestanden lezen:" + vbCrLf + String.Join("; ", whitelistExtensions), "VBL - Masterpoints", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Probeer bestand te lezen
            Try
                fso = New StreamReader(filename)
                strFirstLine = fso.ReadLine()
                fso.Close()

                If strFirstLine.Substring(0, 2) = "A=" Then
                    determinedFileType = "MesserTXT"
                ElseIf strFirstLine.Substring(0, 5) = "CLUB;" Then
                    determinedFileType = "MesserCSV"
                Else
                    determinedFileType = ""
                    MessageBox.Show("Onbekend gegevensformaat." + vbCrLf + "Stuur het bestand naar de maker van dit programma voor verder onderzoek.", "VBL - Masterpoints", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                If determinedFileType <> "" Then
                    lblFileType.Text = "Type: " + determinedFileType
                    txtFilename.Text = filename
                    cmbCategory.Enabled = True
                    btnSaveFile.Enabled = True
                    btnEmptyTotals.Enabled = True
                Else
                    lblFileType.Text = "Type: <geen bestand geselecteerd>"
                    txtFilename.Text = ""
                    cmbCategory.Enabled = False
                    btnSaveFile.Enabled = False
                End If

            Catch ex As FileNotFoundException
                MessageBox.Show("Het opgegeven bestand bestaat niet.", "VBL - Masterpoints", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Fout bij lezen van bestand!", "VBL - Masterpoints", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                processData(filename)
            End Try
        End If
    End Sub

    Private Sub processData(ByVal filename As String)
        ' Clear table
        dataMasterpoints.tblMasterpoints.Clear()

        Dim strLine As String
        Dim arrData As String()
        Dim table As DataSetMasterpoints.tblMasterpointsDataTable = dataMasterpoints.tblMasterpoints

        ' Check type
        Select Case determinedFileType
            Case "MesserTXT"
                ' Comma separated csv
                fso = New StreamReader(filename, Encoding.GetEncoding("windows-1252"))
                strLine = fso.ReadLine()

                intNumberOfSeries = CInt(strLine.Substring(strLine.Length - 1))

                While fso.Peek() >= 0
                    strLine = fso.ReadLine()
                    arrData = strLine.Split(",")
                    If arrData.Length < 5 Then
                        ' Individual drive
                        table.AddtblMasterpointsRow(CShort(arrData(0)), arrData(1), "", arrData(2), "", 0)
                    Else
                        ' Pairs drive
                        table.AddtblMasterpointsRow(CShort(arrData(0)), arrData(1), arrData(3), arrData(2), arrData(4), 0)
                    End If
                End While
                fso.Close()
            Case "MesserCSV"
                ' Semicolon separated csv
                fso = New StreamReader(filename, Encoding.GetEncoding("windows-1252"))
                strLine = fso.ReadLine() ' Ignore first line: only used to determine file type
                strLine = fso.ReadLine() ' Read line 2 (format example: DRIVE;PAREN;2;0;Test 2;171231T2)

                ' Split string to array
                Dim lineData As String() = strLine.Split(";")
                intNumberOfSeries = CInt(lineData(2))

                Dim tmpSplit As String()

                While fso.Peek() >= 0
                    strLine = fso.ReadLine()
                    arrData = strLine.Split(";")
                    If lineData(1) = "INDIVIDUEEL" Then
                        ' Individual drive
                        tmpSplit = arrData(4).Split(",")
                        table.AddtblMasterpointsRow(CShort(arrData(0)), tmpSplit(0), "", tmpSplit(1), "", 0)
                        intNumberOfSeries = 1
                    Else
                        ' Pairs drive
                        table.AddtblMasterpointsRow(CShort(arrData(0)), arrData(4), arrData(6), arrData(5), arrData(7), 0)
                    End If
                End While
                fso.Close()
        End Select

        processCalculation()
    End Sub

    Private Sub processCalculation()
        Dim tmpPoints As Decimal
        Dim tmpMultiplier As Decimal = categories(cmbCategory.SelectedItem.ToString)
        Dim table As DataSetMasterpoints.tblMasterpointsDataTable = dataMasterpoints.tblMasterpoints
        Dim totals As DataSetMasterpoints.tblTotalsDataTable = dataMasterpoints.tblTotals
        Dim tmpRow As DataRow
        Dim tmpTotalPoints As Decimal

        ' Calculate points
        For Each row As DataRow In table.Rows

            If row("colVBL2") = "" AndAlso row("colName2") = "" Then
                ' Individual tournament

                ' Get points
                tmpPoints = calculatePointsIndiv(table.Rows.Count, row("colRank"))

                row.SetField("colPoints", tmpPoints)

                tmpRow = totals.FindBycolVBL(row("colVBL1"))
                If tmpRow IsNot Nothing Then
                    tmpTotalPoints = tmpRow("colPoints") + tmpPoints
                    tmpRow.SetField("colPoints", tmpTotalPoints)
                Else
                    totals.AddtblTotalsRow(row("colVBL1"), tmpPoints)
                End If
            Else
                ' Pairs tournament

                ' Get points
                Select Case cmbCategory.SelectedItem
                    Case "Clubtornooi"
                        tmpPoints = calculatePointsClub(table.Rows.Count, row("colRank"), intNumberOfSeries)
                    Case "Categorie VI (niet geclassificeerd)"
                        tmpPoints = calculatePointsPairs(table.Rows.Count, row("colRank"), intNumberOfSeries, tmpMultiplier, 10)
                    Case "Categorie V", "Categorie IV", "Categorie III", "Categorie II", "Categorie I"
                        tmpPoints = calculatePointsPairs(table.Rows.Count, row("colRank"), intNumberOfSeries, tmpMultiplier)
                End Select


                row.SetField("colPoints", tmpPoints)

                tmpRow = totals.FindBycolVBL(row("colVBL1"))
                If tmpRow IsNot Nothing Then
                    tmpTotalPoints = tmpRow("colPoints") + tmpPoints
                    tmpRow.SetField("colPoints", tmpTotalPoints)
                Else
                    totals.AddtblTotalsRow(row("colVBL1"), tmpPoints)
                End If
                tmpRow = totals.FindBycolVBL(row("colVBL2"))
                If tmpRow IsNot Nothing Then
                    tmpTotalPoints = tmpRow("colPoints") + tmpPoints
                    tmpRow.SetField("colPoints", tmpTotalPoints)
                Else
                    totals.AddtblTotalsRow(row("colVBL2"), tmpPoints)
                End If
            End If
        Next

        ' Sort table
        dgvMasterpoints.Sort(dgvMasterpoints.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        ' Select first row
        dgvMasterpoints.CurrentCell = dgvMasterpoints.Rows(0).Cells(0)
    End Sub

    Private Sub buildCSV(ByVal filename As String)
        Try
            If File.Exists(filename) Then
                File.Delete(filename)
            End If

            sfo = New StreamWriter(filename)

            Dim totals As DataSetMasterpoints.tblTotalsDataTable = dataMasterpoints.tblTotals

            For Each row As DataRow In totals.Rows
                If row("colVBL") <> "0" Then
                    sfo.WriteLine(row("colVBL").ToString & ";" & row("colPoints").ToString)
                End If
            Next
            sfo.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ' Toon messagebox
        MessageBox.Show("VBL-masterpoints berekenen voor club-, grote en individuele tornooien" + vbCrLf + "v." + My.Application.Info.Version.ToString + vbCrLf + vbCrLf + "© 2017 - Martijn Verstraelen" + vbCrLf + "ict@vbl.be", "VBL - Masterpoints", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        ofdFile.ShowDialog()
    End Sub

    Private Sub FrmMasterpoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Categorieën voorbereiden
        categories.Add("Clubtornooi", 1.0)
        categories.Add("Categorie VI (niet geclassificeerd)", 1.0)
        categories.Add("Categorie V", 1.0)
        categories.Add("Categorie IV", 1.2)
        categories.Add("Categorie III", 1.4)
        categories.Add("Categorie II", 1.6)
        categories.Add("Categorie I", 2.0)

        For Each category In categories
            cmbCategory.Items.Add(category.Key)
        Next
        cmbCategory.SelectedIndex = cmbCategory.FindStringExact(My.Settings.standardPairs)
        cmbCategory.Enabled = False
        btnSaveFile.Enabled = False
        btnEmptyTotals.Enabled = False

        ' Command-line argumenten ophalen
        Dim arguments As String() = Environment.GetCommandLineArgs

        If arguments.Length > 1 Then
            Dim i As Integer

            For i = 1 To arguments.Length - 1 Step 1
                checkFile(arguments(i))
            Next
        End If
    End Sub

    Private Sub ofdFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdFile.FileOk
        checkFile(ofdFile.FileName.ToString)
    End Sub

    Private Sub FrmMasterpoints_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)

        For Each file In files
            checkFile(file)
        Next
    End Sub

    Private Sub FrmMasterpoints_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If dgvTotals.Rows.Count > 0 AndAlso MessageBox.Show("Opgelet! Het nu wijzigen van de categorie zal de tabel met totalen leegmaken. Weet u zeker dat u dit wil doen?", "VBL - Masterpoints", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            If dgvMasterpoints.Rows.Count() > 0 Then
                ' Clear table
                dataMasterpoints.tblTotals.Clear()

                processCalculation()
            End If
        End If
    End Sub

    Private Sub btnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click
        sfdFile.ShowDialog()
    End Sub

    Private Sub sfdFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfdFile.FileOk
        buildCSV(sfdFile.FileName.ToString)
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Dim optionsForm As New FrmOptions
        optionsForm.MyCaller = Me

        If optionsForm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            My.Settings.standardPairs = optionsForm.cmbCategory.SelectedItem
        End If
        optionsForm.Dispose()
    End Sub

    Private Sub btnEmptyTotals_Click(sender As Object, e As EventArgs) Handles btnEmptyTotals.Click
        If dgvTotals.Rows.Count > 0 AndAlso MessageBox.Show("Opgelet! De tabel met totalen wordt leeggemaakt. Weet u zeker dat u dit wil doen?", "VBL - Masterpoints", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            If dgvMasterpoints.Rows.Count() > 0 Then
                ' Clear table
                dataMasterpoints.tblTotals.Clear()
                btnEmptyTotals.Enabled = False
                btnSaveFile.Enabled = False
            End If
        End If
    End Sub
End Class
