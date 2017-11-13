<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDealerStatus
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
		Me.btnClose = New System.Windows.Forms.Button()
		Me.lblValue = New System.Windows.Forms.Label()
		Me.lblProfit = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnClose
		'
		Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(105, 172)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(168, 32)
		Me.btnClose.TabIndex = 9
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'lblValue
		'
		Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblValue.Location = New System.Drawing.Point(227, 117)
		Me.lblValue.Name = "lblValue"
		Me.lblValue.Size = New System.Drawing.Size(131, 34)
		Me.lblValue.TabIndex = 8
		'
		'lblProfit
		'
		Me.lblProfit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProfit.Location = New System.Drawing.Point(227, 40)
		Me.lblProfit.Name = "lblProfit"
		Me.lblProfit.Size = New System.Drawing.Size(131, 34)
		Me.lblProfit.TabIndex = 7
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(40, 118)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(123, 20)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Inventory Value:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(40, 41)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(150, 20)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Sold Vehicle Profits:"
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Blue
		Me.Label3.Location = New System.Drawing.Point(54, 243)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(286, 134)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Stuber's Auto Sales "
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'frmDealerStatus
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(398, 393)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.lblValue)
		Me.Controls.Add(Me.lblProfit)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmDealerStatus"
		Me.Text = "Dealer Status"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnClose As Button
	Friend WithEvents lblValue As Label
	Friend WithEvents lblProfit As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
End Class
