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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoOneScoop = New System.Windows.Forms.RadioButton()
        Me.rdoTwoScoop = New System.Windows.Forms.RadioButton()
        Me.rdoThreeScoop = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonExitProgram
        '
        Me.buttonExitProgram.Location = New System.Drawing.Point(297, 358)
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
        Me.buttonOrderNow.Location = New System.Drawing.Point(12, 358)
        Me.buttonOrderNow.Name = "buttonOrderNow"
        Me.buttonOrderNow.Size = New System.Drawing.Size(75, 23)
        Me.buttonOrderNow.TabIndex = 5
        Me.buttonOrderNow.Text = "Order Now"
        Me.buttonOrderNow.UseVisualStyleBackColor = True
        '
        'buttonClearForm
        '
        Me.buttonClearForm.Location = New System.Drawing.Point(153, 358)
        Me.buttonClearForm.Name = "buttonClearForm"
        Me.buttonClearForm.Size = New System.Drawing.Size(75, 23)
        Me.buttonClearForm.TabIndex = 6
        Me.buttonClearForm.Text = "Clear Order"
        Me.buttonClearForm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdoThreeScoop)
        Me.GroupBox1.Controls.Add(Me.rdoTwoScoop)
        Me.GroupBox1.Controls.Add(Me.rdoOneScoop)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scoops"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Page543_4.My.Resources.Resources.ice_cream
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(384, 393)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.buttonClearForm)
        Me.Controls.Add(Me.buttonOrderNow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonExitProgram)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sanderson's Ice Cream Sundaes Order Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonExitProgram As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buttonOrderNow As System.Windows.Forms.Button
    Friend WithEvents buttonClearForm As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoThreeScoop As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTwoScoop As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOneScoop As System.Windows.Forms.RadioButton

End Class
