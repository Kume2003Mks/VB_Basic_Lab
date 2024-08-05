Public Class FormParkingSpace
    Private Sub FormParkingSpace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SUT_PARKINGDataSet.LIST_BOOKING_VIEW' table. You can move, or remove it, as needed.
        Me.LIST_BOOKING_VIEWTableAdapter.Fill(Me.SUT_PARKINGDataSet.LIST_BOOKING_VIEW)

    End Sub
End Class