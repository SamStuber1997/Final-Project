<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoveVehicle
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
		Me.txtStockNumber = New System.Windows.Forms.TextBox()
		Me.btnRemove = New System.Windows.Forms.Button()
		Me.dgvInventory = New System.Windows.Forms.DataGridView()
		Me.Label2 = New System.Windows.Forms.Label()
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(220, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(133, 44)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "StockNumber:"
		'
		'txtStockNumber
		'
		Me.txtStockNumber.Location = New System.Drawing.Point(359, 34)
		Me.txtStockNumber.Name = "txtStockNumber"
		Me.txtStockNumber.Size = New System.Drawing.Size(100, 20)
		Me.txtStockNumber.TabIndex = 1
		'
		'btnRemove
		'
		Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRemove.Location = New System.Drawing.Point(49, 24)
		Me.btnRemove.Name = "btnRemove"
		Me.btnRemove.Size = New System.Drawing.Size(129, 36)
		Me.btnRemove.TabIndex = 2
		Me.btnRemove.Text = "Remove "
		Me.btnRemove.UseVisualStyleBackColor = True
		'
		'dgvInventory
		'
		Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInventory.Location = New System.Drawing.Point(1, 100)
		Me.dgvInventory.Name = "dgvInventory"
		Me.dgvInventory.Size = New System.Drawing.Size(547, 149)
		Me.dgvInventory.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Blue
		Me.Label2.Location = New System.Drawing.Point(117, 272)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(286, 134)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Stuber's Auto Sales "
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'frmRemoveVehicle
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(549, 415)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.dgvInventory)
		Me.Controls.Add(Me.btnRemove)
		Me.Controls.Add(Me.txtStockNumber)
		Me.Controls.Add(Me.Label1)
		Me.Name = "frmRemoveVehicle"
		Me.Text = "Remove Vehicle "
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents txtStockNumber As TextBox
	Friend WithEvents btnRemove As Button
	Friend WithEvents dgvInventory As DataGridView
	Friend WithEvents Label2 As Label
End Class
