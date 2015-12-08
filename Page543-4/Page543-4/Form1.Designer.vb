<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.buttonExitProgram = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonOrderNow = New System.Windows.Forms.Button()
        Me.buttonClearForm = New System.Windows.Forms.Button()
        Me.groupBoxScoops = New System.Windows.Forms.GroupBox()
        Me.rdoOneScoop = New System.Windows.Forms.RadioButton()
        Me.rdoTwoScoop = New System.Windows.Forms.RadioButton()
        Me.rdoThreeScoop = New System.Windows.Forms.RadioButton()
        Me.groupBoxFlavors = New System.Windows.Forms.GroupBox()
        Me.rdoMintChocChip = New System.Windows.Forms.RadioButton()
        Me.rdoSaltCaramel = New System.Windows.Forms.RadioButton()
        Me.rdoFudgeBrownie = New System.Windows.Forms.RadioButton()
        Me.groupBoxAdditions = New System.Windows.Forms.GroupBox()
        Me.chkPeanuts = New System.Windows.Forms.CheckBox()
        Me.chkWhipCream = New System.Windows.Forms.CheckBox()
        Me.chkCherries = New System.Windows.Forms.CheckBox()
        Me.chkKiwi = New System.Windows.Forms.CheckBox()
        Me.chkOreo = New System.Windows.Forms.CheckBox()
        Me.chkMMS = New System.Windows.Forms.CheckBox()
        Me.chkStrawberries = New System.Windows.Forms.CheckBox()
        Me.chkBrownieChunk = New System.Windows.Forms.CheckBox()
        Me.chkCookieDough = New System.Windows.Forms.CheckBox()
        Me.chkHotFudge = New System.Windows.Forms.CheckBox()
        Me.groupBoxTotal = New System.Windows.Forms.GroupBox()
        Me.scoopCost = New System.Windows.Forms.Label()
        Me.additionsCost = New System.Windows.Forms.Label()
        Me.lblTotalCostOutput = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.groupBoxScoops.SuspendLayout()
        Me.groupBoxFlavors.SuspendLayout()
        Me.groupBoxAdditions.SuspendLayout()
        Me.groupBoxTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonExitProgram
        '
        Me.buttonExitProgram.Location = New System.Drawing.Point(297, 423)
        Me.buttonExitProgram.Name = "buttonExitProgram"
        Me.buttonExitProgram.Size = New System.Drawing.Size(75, 23)
        Me.buttonExitProgram.TabIndex = 0
        Me.buttonExitProgram.Text = "Exit Order"
        Me.buttonExitProgram.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sanderson's Ice Cream Sundaes"
        '
        'buttonOrderNow
        '
        Me.buttonOrderNow.Location = New System.Drawing.Point(12, 423)
        Me.buttonOrderNow.Name = "buttonOrderNow"
        Me.buttonOrderNow.Size = New System.Drawing.Size(75, 23)
        Me.buttonOrderNow.TabIndex = 5
        Me.buttonOrderNow.Text = "Order Now"
        Me.buttonOrderNow.UseVisualStyleBackColor = True
        '
        'buttonClearForm
        '
        Me.buttonClearForm.Location = New System.Drawing.Point(150, 423)
        Me.buttonClearForm.Name = "buttonClearForm"
        Me.buttonClearForm.Size = New System.Drawing.Size(75, 23)
        Me.buttonClearForm.TabIndex = 6
        Me.buttonClearForm.Text = "Clear Order"
        Me.buttonClearForm.UseVisualStyleBackColor = True
        '
        'groupBoxScoops
        '
        Me.groupBoxScoops.BackColor = System.Drawing.Color.Transparent
        Me.groupBoxScoops.Controls.Add(Me.rdoThreeScoop)
        Me.groupBoxScoops.Controls.Add(Me.rdoTwoScoop)
        Me.groupBoxScoops.Controls.Add(Me.rdoOneScoop)
        Me.groupBoxScoops.Location = New System.Drawing.Point(12, 48)
        Me.groupBoxScoops.Name = "groupBoxScoops"
        Me.groupBoxScoops.Size = New System.Drawing.Size(112, 91)
        Me.groupBoxScoops.TabIndex = 7
        Me.groupBoxScoops.TabStop = False
        Me.groupBoxScoops.Text = "Scoops"
        '
        'rdoOneScoop
        '
        Me.rdoOneScoop.AutoSize = True
        Me.rdoOneScoop.Location = New System.Drawing.Point(6, 19)
        Me.rdoOneScoop.Name = "rdoOneScoop"
        Me.rdoOneScoop.Size = New System.Drawing.Size(94, 17)
        Me.rdoOneScoop.TabIndex = 0
        Me.rdoOneScoop.TabStop = True
        Me.rdoOneScoop.Text = "Single (One/1)"
        Me.rdoOneScoop.UseVisualStyleBackColor = True
        '
        'rdoTwoScoop
        '
        Me.rdoTwoScoop.AutoSize = True
        Me.rdoTwoScoop.Location = New System.Drawing.Point(6, 42)
        Me.rdoTwoScoop.Name = "rdoTwoScoop"
        Me.rdoTwoScoop.Size = New System.Drawing.Size(100, 17)
        Me.rdoTwoScoop.TabIndex = 1
        Me.rdoTwoScoop.TabStop = True
        Me.rdoTwoScoop.Text = "Double (Two/2)"
        Me.rdoTwoScoop.UseVisualStyleBackColor = True
        '
        'rdoThreeScoop
        '
        Me.rdoThreeScoop.AutoSize = True
        Me.rdoThreeScoop.Location = New System.Drawing.Point(6, 65)
        Me.rdoThreeScoop.Name = "rdoThreeScoop"
        Me.rdoThreeScoop.Size = New System.Drawing.Size(99, 17)
        Me.rdoThreeScoop.TabIndex = 2
        Me.rdoThreeScoop.TabStop = True
        Me.rdoThreeScoop.Text = "Triple (Three/3)"
        Me.rdoThreeScoop.UseVisualStyleBackColor = True
        '
        'groupBoxFlavors
        '
        Me.groupBoxFlavors.BackColor = System.Drawing.Color.Transparent
        Me.groupBoxFlavors.Controls.Add(Me.rdoFudgeBrownie)
        Me.groupBoxFlavors.Controls.Add(Me.rdoSaltCaramel)
        Me.groupBoxFlavors.Controls.Add(Me.rdoMintChocChip)
        Me.groupBoxFlavors.Location = New System.Drawing.Point(12, 145)
        Me.groupBoxFlavors.Name = "groupBoxFlavors"
        Me.groupBoxFlavors.Size = New System.Drawing.Size(126, 100)
        Me.groupBoxFlavors.TabIndex = 8
        Me.groupBoxFlavors.TabStop = False
        Me.groupBoxFlavors.Text = "Flavors"
        '
        'rdoMintChocChip
        '
        Me.rdoMintChocChip.AutoSize = True
        Me.rdoMintChocChip.Location = New System.Drawing.Point(6, 19)
        Me.rdoMintChocChip.Name = "rdoMintChocChip"
        Me.rdoMintChocChip.Size = New System.Drawing.Size(120, 17)
        Me.rdoMintChocChip.TabIndex = 0
        Me.rdoMintChocChip.TabStop = True
        Me.rdoMintChocChip.Text = "Mint Chocolate Chip"
        Me.rdoMintChocChip.UseVisualStyleBackColor = True
        '
        'rdoSaltCaramel
        '
        Me.rdoSaltCaramel.AutoSize = True
        Me.rdoSaltCaramel.Location = New System.Drawing.Point(6, 42)
        Me.rdoSaltCaramel.Name = "rdoSaltCaramel"
        Me.rdoSaltCaramel.Size = New System.Drawing.Size(96, 17)
        Me.rdoSaltCaramel.TabIndex = 1
        Me.rdoSaltCaramel.TabStop = True
        Me.rdoSaltCaramel.Text = "Salted Caramel"
        Me.rdoSaltCaramel.UseVisualStyleBackColor = True
        '
        'rdoFudgeBrownie
        '
        Me.rdoFudgeBrownie.AutoSize = True
        Me.rdoFudgeBrownie.Location = New System.Drawing.Point(6, 65)
        Me.rdoFudgeBrownie.Name = "rdoFudgeBrownie"
        Me.rdoFudgeBrownie.Size = New System.Drawing.Size(96, 17)
        Me.rdoFudgeBrownie.TabIndex = 2
        Me.rdoFudgeBrownie.TabStop = True
        Me.rdoFudgeBrownie.Text = "Fudge Brownie"
        Me.rdoFudgeBrownie.UseVisualStyleBackColor = True
        '
        'groupBoxAdditions
        '
        Me.groupBoxAdditions.Controls.Add(Me.chkHotFudge)
        Me.groupBoxAdditions.Controls.Add(Me.chkCookieDough)
        Me.groupBoxAdditions.Controls.Add(Me.chkBrownieChunk)
        Me.groupBoxAdditions.Controls.Add(Me.chkStrawberries)
        Me.groupBoxAdditions.Controls.Add(Me.chkMMS)
        Me.groupBoxAdditions.Controls.Add(Me.chkOreo)
        Me.groupBoxAdditions.Controls.Add(Me.chkKiwi)
        Me.groupBoxAdditions.Controls.Add(Me.chkCherries)
        Me.groupBoxAdditions.Controls.Add(Me.chkWhipCream)
        Me.groupBoxAdditions.Controls.Add(Me.chkPeanuts)
        Me.groupBoxAdditions.Location = New System.Drawing.Point(255, 48)
        Me.groupBoxAdditions.Name = "groupBoxAdditions"
        Me.groupBoxAdditions.Size = New System.Drawing.Size(117, 250)
        Me.groupBoxAdditions.TabIndex = 9
        Me.groupBoxAdditions.TabStop = False
        Me.groupBoxAdditions.Text = "Additions"
        '
        'chkPeanuts
        '
        Me.chkPeanuts.AutoSize = True
        Me.chkPeanuts.Location = New System.Drawing.Point(6, 19)
        Me.chkPeanuts.Name = "chkPeanuts"
        Me.chkPeanuts.Size = New System.Drawing.Size(65, 17)
        Me.chkPeanuts.TabIndex = 0
        Me.chkPeanuts.Text = "Peanuts"
        Me.chkPeanuts.UseVisualStyleBackColor = True
        '
        'chkWhipCream
        '
        Me.chkWhipCream.AutoSize = True
        Me.chkWhipCream.Location = New System.Drawing.Point(6, 43)
        Me.chkWhipCream.Name = "chkWhipCream"
        Me.chkWhipCream.Size = New System.Drawing.Size(102, 17)
        Me.chkWhipCream.TabIndex = 1
        Me.chkWhipCream.Text = "Whipped Cream"
        Me.chkWhipCream.UseVisualStyleBackColor = True
        '
        'chkCherries
        '
        Me.chkCherries.AutoSize = True
        Me.chkCherries.Location = New System.Drawing.Point(6, 66)
        Me.chkCherries.Name = "chkCherries"
        Me.chkCherries.Size = New System.Drawing.Size(64, 17)
        Me.chkCherries.TabIndex = 2
        Me.chkCherries.Text = "Cherries"
        Me.chkCherries.UseVisualStyleBackColor = True
        '
        'chkKiwi
        '
        Me.chkKiwi.AutoSize = True
        Me.chkKiwi.Location = New System.Drawing.Point(6, 89)
        Me.chkKiwi.Name = "chkKiwi"
        Me.chkKiwi.Size = New System.Drawing.Size(45, 17)
        Me.chkKiwi.TabIndex = 3
        Me.chkKiwi.Text = "Kiwi"
        Me.chkKiwi.UseVisualStyleBackColor = True
        '
        'chkOreo
        '
        Me.chkOreo.AutoSize = True
        Me.chkOreo.Location = New System.Drawing.Point(6, 112)
        Me.chkOreo.Name = "chkOreo"
        Me.chkOreo.Size = New System.Drawing.Size(49, 17)
        Me.chkOreo.TabIndex = 4
        Me.chkOreo.Text = "Oreo"
        Me.chkOreo.UseVisualStyleBackColor = True
        '
        'chkMMS
        '
        Me.chkMMS.AutoSize = True
        Me.chkMMS.Location = New System.Drawing.Point(6, 135)
        Me.chkMMS.Name = "chkMMS"
        Me.chkMMS.Size = New System.Drawing.Size(73, 17)
        Me.chkMMS.TabIndex = 5
        Me.chkMMS.Text = "M and Ms"
        Me.chkMMS.UseVisualStyleBackColor = True
        '
        'chkStrawberries
        '
        Me.chkStrawberries.AutoSize = True
        Me.chkStrawberries.Location = New System.Drawing.Point(6, 158)
        Me.chkStrawberries.Name = "chkStrawberries"
        Me.chkStrawberries.Size = New System.Drawing.Size(84, 17)
        Me.chkStrawberries.TabIndex = 6
        Me.chkStrawberries.Text = "Strawberries"
        Me.chkStrawberries.UseVisualStyleBackColor = True
        '
        'chkBrownieChunk
        '
        Me.chkBrownieChunk.AutoSize = True
        Me.chkBrownieChunk.Location = New System.Drawing.Point(6, 181)
        Me.chkBrownieChunk.Name = "chkBrownieChunk"
        Me.chkBrownieChunk.Size = New System.Drawing.Size(103, 17)
        Me.chkBrownieChunk.TabIndex = 7
        Me.chkBrownieChunk.Text = "Brownie Chunks"
        Me.chkBrownieChunk.UseVisualStyleBackColor = True
        '
        'chkCookieDough
        '
        Me.chkCookieDough.AutoSize = True
        Me.chkCookieDough.Location = New System.Drawing.Point(6, 204)
        Me.chkCookieDough.Name = "chkCookieDough"
        Me.chkCookieDough.Size = New System.Drawing.Size(94, 17)
        Me.chkCookieDough.TabIndex = 8
        Me.chkCookieDough.Text = "Cookie Dough"
        Me.chkCookieDough.UseVisualStyleBackColor = True
        '
        'chkHotFudge
        '
        Me.chkHotFudge.AutoSize = True
        Me.chkHotFudge.Location = New System.Drawing.Point(6, 227)
        Me.chkHotFudge.Name = "chkHotFudge"
        Me.chkHotFudge.Size = New System.Drawing.Size(76, 17)
        Me.chkHotFudge.TabIndex = 9
        Me.chkHotFudge.Text = "Hot Fudge"
        Me.chkHotFudge.UseVisualStyleBackColor = True
        '
        'groupBoxTotal
        '
        Me.groupBoxTotal.Controls.Add(Me.lblTotalCost)
        Me.groupBoxTotal.Controls.Add(Me.lblTotalCostOutput)
        Me.groupBoxTotal.Controls.Add(Me.additionsCost)
        Me.groupBoxTotal.Controls.Add(Me.scoopCost)
        Me.groupBoxTotal.Location = New System.Drawing.Point(12, 356)
        Me.groupBoxTotal.Name = "groupBoxTotal"
        Me.groupBoxTotal.Size = New System.Drawing.Size(360, 61)
        Me.groupBoxTotal.TabIndex = 10
        Me.groupBoxTotal.TabStop = False
        Me.groupBoxTotal.Text = "Costs and Total"
        '
        'scoopCost
        '
        Me.scoopCost.AutoSize = True
        Me.scoopCost.Location = New System.Drawing.Point(18, 16)
        Me.scoopCost.Name = "scoopCost"
        Me.scoopCost.Size = New System.Drawing.Size(68, 13)
        Me.scoopCost.TabIndex = 0
        Me.scoopCost.Text = "Scoop Cost: "
        '
        'additionsCost
        '
        Me.additionsCost.AutoSize = True
        Me.additionsCost.Location = New System.Drawing.Point(6, 34)
        Me.additionsCost.Name = "additionsCost"
        Me.additionsCost.Size = New System.Drawing.Size(80, 13)
        Me.additionsCost.TabIndex = 1
        Me.additionsCost.Text = "Additions Cost: "
        '
        'lblTotalCostOutput
        '
        Me.lblTotalCostOutput.BackColor = System.Drawing.Color.White
        Me.lblTotalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCostOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostOutput.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTotalCostOutput.Location = New System.Drawing.Point(249, 16)
        Me.lblTotalCostOutput.Name = "lblTotalCostOutput"
        Me.lblTotalCostOutput.Size = New System.Drawing.Size(105, 23)
        Me.lblTotalCostOutput.TabIndex = 2
        Me.lblTotalCostOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(185, 22)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Page543_4.My.Resources.Resources.ice_cream
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(384, 458)
        Me.Controls.Add(Me.groupBoxTotal)
        Me.Controls.Add(Me.groupBoxAdditions)
        Me.Controls.Add(Me.groupBoxFlavors)
        Me.Controls.Add(Me.groupBoxScoops)
        Me.Controls.Add(Me.buttonClearForm)
        Me.Controls.Add(Me.buttonOrderNow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonExitProgram)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sanderson's Ice Cream Sundaes Order Form"
        Me.groupBoxScoops.ResumeLayout(False)
        Me.groupBoxScoops.PerformLayout()
        Me.groupBoxFlavors.ResumeLayout(False)
        Me.groupBoxFlavors.PerformLayout()
        Me.groupBoxAdditions.ResumeLayout(False)
        Me.groupBoxAdditions.PerformLayout()
        Me.groupBoxTotal.ResumeLayout(False)
        Me.groupBoxTotal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonExitProgram As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buttonOrderNow As System.Windows.Forms.Button
    Friend WithEvents buttonClearForm As System.Windows.Forms.Button
    Friend WithEvents groupBoxScoops As System.Windows.Forms.GroupBox
    Friend WithEvents rdoThreeScoop As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTwoScoop As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOneScoop As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxFlavors As System.Windows.Forms.GroupBox
    Friend WithEvents rdoFudgeBrownie As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSaltCaramel As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMintChocChip As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxAdditions As System.Windows.Forms.GroupBox
    Friend WithEvents chkHotFudge As System.Windows.Forms.CheckBox
    Friend WithEvents chkCookieDough As System.Windows.Forms.CheckBox
    Friend WithEvents chkBrownieChunk As System.Windows.Forms.CheckBox
    Friend WithEvents chkStrawberries As System.Windows.Forms.CheckBox
    Friend WithEvents chkMMS As System.Windows.Forms.CheckBox
    Friend WithEvents chkOreo As System.Windows.Forms.CheckBox
    Friend WithEvents chkKiwi As System.Windows.Forms.CheckBox
    Friend WithEvents chkCherries As System.Windows.Forms.CheckBox
    Friend WithEvents chkWhipCream As System.Windows.Forms.CheckBox
    Friend WithEvents chkPeanuts As System.Windows.Forms.CheckBox
    Friend WithEvents groupBoxTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblTotalCostOutput As System.Windows.Forms.Label
    Friend WithEvents additionsCost As System.Windows.Forms.Label
    Friend WithEvents scoopCost As System.Windows.Forms.Label

End Class
