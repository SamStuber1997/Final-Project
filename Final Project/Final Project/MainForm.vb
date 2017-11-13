Public Class MainForm
	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub AddVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddVehicleToolStripMenuItem.Click
		frmAddVehicle.ShowDialog()
	End Sub

	Private Sub RemoveVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveVehicleToolStripMenuItem.Click
		frmRemoveVehicle.ShowDialog()
	End Sub

	Private Sub SoldVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoldVehicleToolStripMenuItem.Click
		frmRemoveVehicle.ShowDialog()
	End Sub

	Private Sub InventoryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryReportToolStripMenuItem.Click
		frmInventory.ShowDialog()
	End Sub
End Class
