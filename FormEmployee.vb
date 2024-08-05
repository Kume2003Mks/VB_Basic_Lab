Public Class FormEmployee
    Private Sub FormEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SUT_PARKINGDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.EMPLOYEETableAdapter.Fill(Me.SUT_PARKINGDataSet.EMPLOYEE)

    End Sub
End Class