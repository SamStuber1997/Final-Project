<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoldVehicle
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
		Me.Label1.Location = New System.Drawing.Point(204, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(286, 134)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Stuber's Auto Sales "
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dgvInventory
		'
		Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvInventory.Location = New System.Drawing.Point(-27, 186)
		Me.dgvInventory.Name = "dgvInventory"
		Me.dgvInventory.Size = New System.Drawing.Size(834, 319)
		Me.dgvInventory.TabIndex = 3
		'
		'SoldVehicle
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(819, 517)
		Me.Controls.Add(Me.dgvInventory)
		Me.Controls.Add(Me.Label1)
		Me.Name = "SoldVehicle"
		Me.Text = "SoldVehicle"
		CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents dgvInventory As DataGridView
End Class
