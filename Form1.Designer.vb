<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.lstFactorialBox = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblChooseNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.Image = CType(resources.GetObject("picBackground.Image"), System.Drawing.Image)
        Me.picBackground.Location = New System.Drawing.Point(-1, 25)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(802, 426)
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'lstFactorialBox
        '
        Me.lstFactorialBox.FormattingEnabled = True
        Me.lstFactorialBox.Location = New System.Drawing.Point(491, 80)
        Me.lstFactorialBox.Name = "lstFactorialBox"
        Me.lstFactorialBox.Size = New System.Drawing.Size(115, 290)
        Me.lstFactorialBox.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(243, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(315, 35)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Factorial Calculator"
        '
        'lblChooseNumber
        '
        Me.lblChooseNumber.AutoSize = True
        Me.lblChooseNumber.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseNumber.Location = New System.Drawing.Point(24, 112)
        Me.lblChooseNumber.Name = "lblChooseNumber"
        Me.lblChooseNumber.Size = New System.Drawing.Size(329, 35)
        Me.lblChooseNumber.TabIndex = 3
        Me.lblChooseNumber.Text = "Pick a number 1 - 12"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(127, 167)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 32)
        Me.txtNumber.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(72, 226)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(202, 57)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblChooseNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstFactorialBox)
        Me.Controls.Add(Me.picBackground)
        Me.Name = "frmMain"
        Me.Text = "Factorial Calculator"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents lstFactorialBox As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblChooseNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnCalculate As Button
End Class
