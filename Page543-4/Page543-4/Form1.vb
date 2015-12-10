Public Class Form1

    Dim dblScoopsTotal As Double
    Dim dblAdditionsTotal As Double
    Dim dblTotal As Double

    Const dblSingleScoop As Double = 2.2
    Const dblDoubleScoop As Double = 3D
    Const dblTripleScoop As Double = 4D
    Const dblAdditions As Double = 0.5

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

    Private Sub rdoOneScoop_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOneScoop.CheckedChanged
        dblScoopsTotal = If(rdoOneScoop.Checked, dblSingleScoop, 0D)
    End Sub

    Private Sub rdoTwoScoop_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTwoScoop.CheckedChanged
        dblScoopsTotal = If(rdoTwoScoop.Checked, dblDoubleScoop, 0D)
    End Sub

    Private Sub rdoThreeScoop_CheckedChanged(sender As Object, e As EventArgs) Handles rdoThreeScoop.CheckedChanged
        dblScoopsTotal = If(rdoThreeScoop.Checked, dblTripleScoop, 0D)
    End Sub
End Class
