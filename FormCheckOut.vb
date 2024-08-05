Public Class FormCheckOut
    Private Sub FormCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SUT_PARKINGDataSet.BOOKING' table. You can move, or remove it, as needed.
        Me.BOOKINGTableAdapter.Fill(Me.SUT_PARKINGDataSet.BOOKING)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim endDateTime = End_datetimeDateTimePicker.Value
        Dim bookingID = Booking_idTextBox.Text
        Me.BOOKINGTableAdapter.UpdateBookingEndDateTime(endDateTime, bookingID)
    End Sub
End Class