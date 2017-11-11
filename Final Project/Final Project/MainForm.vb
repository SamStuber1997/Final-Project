Public Class MainForm
	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub AddVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddVehicleToolStripMenuItem.Click
		frmAddVehicle.ShowDialog()
	End Sub
End Class
