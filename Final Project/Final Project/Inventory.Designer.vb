<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtStockNumber = New System.Windows.Forms.TextBox()
		Me.btnSell = New System.Windows.Forms.Button()
		Me.dgvInventory = New System.Windows.Forms.DataGridView()
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Blue
		Me.Label1.Location = New System.Drawing.Point(348, 45)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(286, 134)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Stuber's Auto Sales "
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(313, 208)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(114, 20)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Stock Number:"
		'
		'txtStockNumber
		'
		Me.txtStockNumber.Location = New System.Drawing.Point(442, 210)
		Me.txtStockNumber.Name = "txtStockNumber"
		Me.txtStockNumber.Size = New System.Drawing.Size(100, 20)
		Me.txtStockNumber.TabIndex = 4
		'
		'btnSell
		'
		Me.btnSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSell.Location = New System.Drawing.Point(586, 204)
		Me.btnSell.Name = "btnSell"
		Me.btnSell.Size = New System.Drawing.Size(129, 28)
		Me.btnSell.TabIndex = 5
		Me.btnSell.Text = "Sell Vehicle "
		Me.btnSell.UseVisualStyleBackColor = True
		'
		'dgvInventory
		'
		Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInventory.Location = New System.Drawing.Point(2, 249)
		Me.dgvInventory.Name = "dgvInventory"
		Me.dgvInventory.Size = New System.Drawing.Size(875, 150)
		Me.dgvInventory.TabIndex = 6
		'
		'frmInventory
		'
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(805, 439)
		Me.Controls.Add(Me.dgvInventory)
		Me.Controls.Add(Me.btnSell)
		Me.Controls.Add(Me.txtStockNumber)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmInventory"
		Me.Text = "Inventory"
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtStockNumber As TextBox
	Friend WithEvents btnSell As Button
	Friend WithEvents dgvInventory As DataGridView
End Class
