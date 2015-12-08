Public Class Form1

    Private Sub buttonExitProgram_Click(sender As Object, e As EventArgs) Handles buttonExitProgram.Click
        'End Application
        Application.Exit()
    End Sub

    Private Sub buttonClearForm_Click(sender As Object, e As EventArgs) Handles buttonClearForm.Click
        ' Clear all radio buttons, check boxes and total box
        For Each rdoBtn As RadioButton In groupBoxScoops.Controls
            rdoBtn.Checked = False
        Next
        For Each rdoBtn As RadioButton In groupBoxFlavors.Controls
            rdoBtn.Checked = False
        Next
        For Each chkBox As CheckBox In groupBoxAdditions.Controls
            chkBox.Checked = False
        Next
        lblScoopCostOutput.Text = String.Empty
        lblAdditionCostOutput.Text = String.Empty
        lblTotalCostOutput.Text = String.Empty

        groupBoxScoops.Focus()
    End Sub

    Private Sub buttonOrderNow_Click(sender As Object, e As EventArgs) Handles buttonOrderNow.Click

    End Sub
End Class
