Imports System.Security.Policy

Public Class FormCheckIn
    Private Sub PARKING_ZONEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PARKING_ZONEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SUT_PARKINGDataSet)

    End Sub

    Private Sub FormCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SUT_PARKINGDataSet.BOOKING' table. You can move, or remove it, as needed.
        Me.BOOKINGTableAdapter.Fill(Me.SUT_PARKINGDataSet.BOOKING)
        'TODO: This line of code loads data into the 'SUT_PARKINGDataSet.PARKING_SPACE' table. You can move, or remove it, as needed.
        Me.PARKING_SPACETableAdapter.Fill(Me.SUT_PARKINGDataSet.PARKING_SPACE)

        'TODO: This line of code loads data into the 'SUT_PARKINGDataSet.PARKING_ZONE' table. You can move, or remove it, as needed.
        Me.PARKING_ZONETableAdapter.Fill(Me.SUT_PARKINGDataSet.PARKING_ZONE)

    End Sub

    Private Sub PARKING_ZONEComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PARKING_ZONEComboBox.SelectedIndexChanged
        If PARKING_ZONEComboBox.SelectedValue IsNot Nothing Then
            Dim zoneId = PARKING_ZONEComboBox.SelectedValue
            Me.PARKING_SPACETableAdapter.FillBy(Me.SUT_PARKINGDataSet.PARKING_SPACE, zoneId)
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim spaceId = PARKING_SPACEComboBox.SelectedValue
        Dim carRegist = txtBoxRegist.Text
        Me.BOOKINGTableAdapter.InsertBooking(spaceId, carRegist)
        Me.LAST_BOOKING_VIEWTableAdapter.Fill(Me.SUT_PARKINGDataSet.LAST_BOOKING_VIEW)
        MessageBox.Show("Success")
    End Sub
End Class