<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAverageShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.LblUnits = New System.Windows.Forms.Label()
        Me.ToolTipInputBox = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtDisplay = New System.Windows.Forms.TextBox()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblOutput = New System.Windows.Forms.Label()
        Me.LblDay = New System.Windows.Forms.Label()
        Me.lblavg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(148, 41)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(77, 22)
        Me.TxtInput.TabIndex = 0
        Me.ToolTipInputBox.SetToolTip(Me.TxtInput, "Input Units Here")
        '
        'LblUnits
        '
        Me.LblUnits.AutoSize = True
        Me.LblUnits.Location = New System.Drawing.Point(88, 41)
        Me.LblUnits.Name = "LblUnits"
        Me.LblUnits.Size = New System.Drawing.Size(44, 17)
        Me.LblUnits.TabIndex = 1
        Me.LblUnits.Text = "Units:"
        '
        'TxtDisplay
        '
        Me.TxtDisplay.Location = New System.Drawing.Point(45, 77)
        Me.TxtDisplay.MaximumSize = New System.Drawing.Size(300, 300)
        Me.TxtDisplay.MinimumSize = New System.Drawing.Size(300, 300)
        Me.TxtDisplay.Multiline = True
        Me.TxtDisplay.Name = "TxtDisplay"
        Me.TxtDisplay.ReadOnly = True
        Me.TxtDisplay.Size = New System.Drawing.Size(300, 300)
        Me.TxtDisplay.TabIndex = 100
        Me.TxtDisplay.TabStop = False
        '
        'BtnEnter
        '
        Me.BtnEnter.Location = New System.Drawing.Point(12, 437)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(114, 35)
        Me.BtnEnter.TabIndex = 1
        Me.BtnEnter.Text = "Enter"
        Me.ToolTipInputBox.SetToolTip(Me.BtnEnter, "Enter Data into the Application to Calculate Average")
        Me.BtnEnter.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(148, 436)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(113, 35)
        Me.BtnReset.TabIndex = 2
        Me.BtnReset.Text = "Reset"
        Me.ToolTipInputBox.SetToolTip(Me.BtnReset, "Reset Application and Erase Previous Data")
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(278, 437)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 36)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.ToolTipInputBox.SetToolTip(Me.BtnExit, "Close the Application")
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblOutput
        '
        Me.LblOutput.AutoSize = True
        Me.LblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblOutput.Location = New System.Drawing.Point(91, 380)
        Me.LblOutput.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.LblOutput.MaximumSize = New System.Drawing.Size(100, 100)
        Me.LblOutput.MinimumSize = New System.Drawing.Size(210, 40)
        Me.LblOutput.Name = "LblOutput"
        Me.LblOutput.Size = New System.Drawing.Size(210, 40)
        Me.LblOutput.TabIndex = 0
        '
        'LblDay
        '
        Me.LblDay.AutoSize = True
        Me.LblDay.Location = New System.Drawing.Point(247, 41)
        Me.LblDay.Name = "LblDay"
        Me.LblDay.Size = New System.Drawing.Size(45, 17)
        Me.LblDay.TabIndex = 7
        Me.LblDay.Text = "Day 1"
        '
        'lblavg
        '
        Me.lblavg.AutoSize = True
        Me.lblavg.Location = New System.Drawing.Point(44, 392)
        Me.lblavg.Name = "lblavg"
        Me.lblavg.Size = New System.Drawing.Size(37, 17)
        Me.lblavg.TabIndex = 101
        Me.lblavg.Text = "AVG"
        '
        'FrmAverageShipped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 492)
        Me.Controls.Add(Me.lblavg)
        Me.Controls.Add(Me.LblDay)
        Me.Controls.Add(Me.LblOutput)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.TxtDisplay)
        Me.Controls.Add(Me.LblUnits)
        Me.Controls.Add(Me.TxtInput)
        Me.Name = "FrmAverageShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtInput As TextBox
    Friend WithEvents LblUnits As Label
    Friend WithEvents ToolTipInputBox As ToolTip
    Friend WithEvents TxtDisplay As TextBox
    Friend WithEvents BtnEnter As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblOutput As Label
    Friend WithEvents LblDay As Label
    Friend WithEvents lblavg As Label
End Class
