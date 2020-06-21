Public Class FrmOptions

    Public MyCaller As FrmMasterpoints

    Private Sub FrmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each category In MyCaller.categories
            cmbCategory.Items.Add(category.Key)
        Next
        cmbCategory.SelectedIndex = cmbCategory.FindStringExact(My.Settings.standardPairs)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class