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
        dblTotal = dblScoopsTotal + dblAdditionsTotal
        lblScoopCostOutput.Text = dblScoopsTotal.ToString("c")
        lblAdditionCostOutput.Text = dblAdditionsTotal.ToString("c")
        lblTotalCostOutput.Text = dblTotal.ToString("c")
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

    Private Sub chkPeanuts_CheckedChanged(sender As Object, e As EventArgs) Handles chkPeanuts.CheckedChanged
        dblAdditionsTotal += If(chkPeanuts.Checked, dblAdditions, -dblAdditions)
    End Sub

    Private Sub chkStrawberries_CheckedChanged(sender As Object, e As EventArgs) Handles chkStrawberries.CheckedChanged
        dblAdditionsTotal += If(chkStrawberries.Checked, dblAdditions, -dblAdditions)
    End Sub

    Private Sub chkWhipCream_CheckedChanged(sender As Object, e As EventArgs) Handles chkWhipCream.CheckedChanged
        dblAdditionsTotal += If(chkWhipCream.Checked, dblAdditions, -dblAdditions)
    End Sub

    Private Sub chkCherries_CheckedChanged(sender As Object, e As EventArgs) Handles chkCherries.CheckedChanged
        dblAdditionsTotal += If(chkCherries.Checked, dblAdditions, -dblAdditions)
    End Sub

    Private Sub chkBrownieChunk_CheckedChanged(sender As Object, e As EventArgs) Handles chkBrownieChunk.CheckedChanged
        dblAdditionsTotal += If(chkBrownieChunk.Checked, dblAdditions, -dblAdditions)
    End Sub

    Private Sub chkCookieDough_CheckedChanged(sender As Object, e As EventArgs) Handles chkCookieDough.CheckedChanged
        dblAdditionsTotal += If(chkCookieDough.Checked, dblAdditions, -dblAdditions)
    End Sub

    Private Sub chkHotFudge_CheckedChanged(sender As Object, e As EventArgs) Handles chkHotFudge.CheckedChanged
        dblAdditionsTotal += If(chkHotFudge.Checked, dblAdditions, -dblAdditions)
    End Sub

    Private Sub chkKiwi_CheckedChanged(sender As Object, e As EventArgs) Handles chkKiwi.CheckedChanged
        dblAdditionsTotal += If(chkKiwi.Checked, dblAdditions, -dblAdditions)
    End Sub

    Private Sub chkMMS_CheckedChanged(sender As Object, e As EventArgs) Handles chkMMS.CheckedChanged
        dblAdditionsTotal += If(chkMMS.Checked, dblAdditions, -dblAdditions)
    End Sub

    Private Sub chkOreo_CheckedChanged(sender As Object, e As EventArgs) Handles chkOreo.CheckedChanged
        dblAdditionsTotal += If(chkOreo.Checked, dblAdditions, -dblAdditions)
    End Sub
End Class
