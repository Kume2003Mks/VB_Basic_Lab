<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCheckIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Booking_idLabel As System.Windows.Forms.Label
        Dim Prkspace_idLabel As System.Windows.Forms.Label
        Dim Car_registLabel As System.Windows.Forms.Label
        Dim Start_datetimeLabel As System.Windows.Forms.Label
        Dim End_datetimeLabel As System.Windows.Forms.Label
        Me.SUT_PARKINGDataSet = New lab_1.SUT_PARKINGDataSet()
        Me.PARKING_ZONEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PARKING_ZONETableAdapter = New lab_1.SUT_PARKINGDataSetTableAdapters.PARKING_ZONETableAdapter()
        Me.TableAdapterManager = New lab_1.SUT_PARKINGDataSetTableAdapters.TableAdapterManager()
        Me.PARKING_ZONEComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PARKING_SPACEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PARKING_SPACETableAdapter = New lab_1.SUT_PARKINGDataSetTableAdapters.PARKING_SPACETableAdapter()
        Me.PARKING_SPACEComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxRegist = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.LAST_BOOKING_VIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAST_BOOKING_VIEWTableAdapter = New lab_1.SUT_PARKINGDataSetTableAdapters.LAST_BOOKING_VIEWTableAdapter()
        Me.Booking_idTextBox = New System.Windows.Forms.TextBox()
        Me.Prkspace_idTextBox = New System.Windows.Forms.TextBox()
        Me.Car_registTextBox = New System.Windows.Forms.TextBox()
        Me.Start_datetimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.End_datetimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BOOKINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKINGTableAdapter = New lab_1.SUT_PARKINGDataSetTableAdapters.BOOKINGTableAdapter()
        Booking_idLabel = New System.Windows.Forms.Label()
        Prkspace_idLabel = New System.Windows.Forms.Label()
        Car_registLabel = New System.Windows.Forms.Label()
        Start_datetimeLabel = New System.Windows.Forms.Label()
        End_datetimeLabel = New System.Windows.Forms.Label()
        CType(Me.SUT_PARKINGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARKING_ZONEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARKING_SPACEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAST_BOOKING_VIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Booking_idLabel
        '
        Booking_idLabel.AutoSize = True
        Booking_idLabel.Location = New System.Drawing.Point(94, 384)
        Booking_idLabel.Name = "Booking_idLabel"
        Booking_idLabel.Size = New System.Drawing.Size(73, 16)
        Booking_idLabel.TabIndex = 7
        Booking_idLabel.Text = "booking id:"
        '
        'Prkspace_idLabel
        '
        Prkspace_idLabel.AutoSize = True
        Prkspace_idLabel.Location = New System.Drawing.Point(94, 412)
        Prkspace_idLabel.Name = "Prkspace_idLabel"
        Prkspace_idLabel.Size = New System.Drawing.Size(81, 16)
        Prkspace_idLabel.TabIndex = 9
        Prkspace_idLabel.Text = "prkspace id:"
        '
        'Car_registLabel
        '
        Car_registLabel.AutoSize = True
        Car_registLabel.Location = New System.Drawing.Point(94, 440)
        Car_registLabel.Name = "Car_registLabel"
        Car_registLabel.Size = New System.Drawing.Size(65, 16)
        Car_registLabel.TabIndex = 11
        Car_registLabel.Text = "car regist:"
        '
        'Start_datetimeLabel
        '
        Start_datetimeLabel.AutoSize = True
        Start_datetimeLabel.Location = New System.Drawing.Point(94, 469)
        Start_datetimeLabel.Name = "Start_datetimeLabel"
        Start_datetimeLabel.Size = New System.Drawing.Size(90, 16)
        Start_datetimeLabel.TabIndex = 13
        Start_datetimeLabel.Text = "start datetime:"
        '
        'End_datetimeLabel
        '
        End_datetimeLabel.AutoSize = True
        End_datetimeLabel.Location = New System.Drawing.Point(94, 497)
        End_datetimeLabel.Name = "End_datetimeLabel"
        End_datetimeLabel.Size = New System.Drawing.Size(88, 16)
        End_datetimeLabel.TabIndex = 15
        End_datetimeLabel.Text = "end datetime:"
        '
        'SUT_PARKINGDataSet
        '
        Me.SUT_PARKINGDataSet.DataSetName = "SUT_PARKINGDataSet"
        Me.SUT_PARKINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PARKING_ZONEBindingSource
        '
        Me.PARKING_ZONEBindingSource.DataMember = "PARKING_ZONE"
        Me.PARKING_ZONEBindingSource.DataSource = Me.SUT_PARKINGDataSet
        '
        'PARKING_ZONETableAdapter
        '
        Me.PARKING_ZONETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKINGTableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.PARKING_SPACETableAdapter = Nothing
        Me.TableAdapterManager.PARKING_ZONETableAdapter = Me.PARKING_ZONETableAdapter
        Me.TableAdapterManager.UpdateOrder = lab_1.SUT_PARKINGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PARKING_ZONEComboBox
        '
        Me.PARKING_ZONEComboBox.DataSource = Me.PARKING_ZONEBindingSource
        Me.PARKING_ZONEComboBox.DisplayMember = "prkzone_name"
        Me.PARKING_ZONEComboBox.FormattingEnabled = True
        Me.PARKING_ZONEComboBox.Location = New System.Drawing.Point(90, 132)
        Me.PARKING_ZONEComboBox.Name = "PARKING_ZONEComboBox"
        Me.PARKING_ZONEComboBox.Size = New System.Drawing.Size(300, 24)
        Me.PARKING_ZONEComboBox.TabIndex = 1
        Me.PARKING_ZONEComboBox.ValueMember = "prkzone_id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Zone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Spaces"
        '
        'PARKING_SPACEBindingSource
        '
        Me.PARKING_SPACEBindingSource.DataMember = "PARKING_SPACE"
        Me.PARKING_SPACEBindingSource.DataSource = Me.SUT_PARKINGDataSet
        '
        'PARKING_SPACETableAdapter
        '
        Me.PARKING_SPACETableAdapter.ClearBeforeFill = True
        '
        'PARKING_SPACEComboBox
        '
        Me.PARKING_SPACEComboBox.DataSource = Me.PARKING_SPACEBindingSource
        Me.PARKING_SPACEComboBox.DisplayMember = "prkspace_id"
        Me.PARKING_SPACEComboBox.FormattingEnabled = True
        Me.PARKING_SPACEComboBox.Location = New System.Drawing.Point(90, 199)
        Me.PARKING_SPACEComboBox.Name = "PARKING_SPACEComboBox"
        Me.PARKING_SPACEComboBox.Size = New System.Drawing.Size(300, 24)
        Me.PARKING_SPACEComboBox.TabIndex = 3
        Me.PARKING_SPACEComboBox.ValueMember = "prkspace_id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Car Registration "
        '
        'txtBoxRegist
        '
        Me.txtBoxRegist.Location = New System.Drawing.Point(93, 272)
        Me.txtBoxRegist.Name = "txtBoxRegist"
        Me.txtBoxRegist.Size = New System.Drawing.Size(297, 22)
        Me.txtBoxRegist.TabIndex = 4
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInsert.FlatAppearance.BorderSize = 2
        Me.btnInsert.Location = New System.Drawing.Point(486, 132)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(222, 162)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'LAST_BOOKING_VIEWBindingSource
        '
        Me.LAST_BOOKING_VIEWBindingSource.DataMember = "LAST_BOOKING_VIEW"
        Me.LAST_BOOKING_VIEWBindingSource.DataSource = Me.SUT_PARKINGDataSet
        '
        'LAST_BOOKING_VIEWTableAdapter
        '
        Me.LAST_BOOKING_VIEWTableAdapter.ClearBeforeFill = True
        '
        'Booking_idTextBox
        '
        Me.Booking_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LAST_BOOKING_VIEWBindingSource, "booking_id", True))
        Me.Booking_idTextBox.Location = New System.Drawing.Point(190, 381)
        Me.Booking_idTextBox.Name = "Booking_idTextBox"
        Me.Booking_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Booking_idTextBox.TabIndex = 8
        '
        'Prkspace_idTextBox
        '
        Me.Prkspace_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LAST_BOOKING_VIEWBindingSource, "prkspace_id", True))
        Me.Prkspace_idTextBox.Location = New System.Drawing.Point(190, 409)
        Me.Prkspace_idTextBox.Name = "Prkspace_idTextBox"
        Me.Prkspace_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Prkspace_idTextBox.TabIndex = 10
        '
        'Car_registTextBox
        '
        Me.Car_registTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LAST_BOOKING_VIEWBindingSource, "car_regist", True))
        Me.Car_registTextBox.Location = New System.Drawing.Point(190, 437)
        Me.Car_registTextBox.Name = "Car_registTextBox"
        Me.Car_registTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Car_registTextBox.TabIndex = 12
        '
        'Start_datetimeDateTimePicker
        '
        Me.Start_datetimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LAST_BOOKING_VIEWBindingSource, "start_datetime", True))
        Me.Start_datetimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Start_datetimeDateTimePicker.Location = New System.Drawing.Point(190, 465)
        Me.Start_datetimeDateTimePicker.Name = "Start_datetimeDateTimePicker"
        Me.Start_datetimeDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Start_datetimeDateTimePicker.TabIndex = 14
        '
        'End_datetimeDateTimePicker
        '
        Me.End_datetimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LAST_BOOKING_VIEWBindingSource, "end_datetime", True))
        Me.End_datetimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.End_datetimeDateTimePicker.Location = New System.Drawing.Point(190, 493)
        Me.End_datetimeDateTimePicker.Name = "End_datetimeDateTimePicker"
        Me.End_datetimeDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.End_datetimeDateTimePicker.TabIndex = 16
        '
        'BOOKINGBindingSource
        '
        Me.BOOKINGBindingSource.DataMember = "BOOKING"
        Me.BOOKINGBindingSource.DataSource = Me.SUT_PARKINGDataSet
        '
        'BOOKINGTableAdapter
        '
        Me.BOOKINGTableAdapter.ClearBeforeFill = True
        '
        'FormCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 665)
        Me.Controls.Add(Booking_idLabel)
        Me.Controls.Add(Me.Booking_idTextBox)
        Me.Controls.Add(Prkspace_idLabel)
        Me.Controls.Add(Me.Prkspace_idTextBox)
        Me.Controls.Add(Car_registLabel)
        Me.Controls.Add(Me.Car_registTextBox)
        Me.Controls.Add(Start_datetimeLabel)
        Me.Controls.Add(Me.Start_datetimeDateTimePicker)
        Me.Controls.Add(End_datetimeLabel)
        Me.Controls.Add(Me.End_datetimeDateTimePicker)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtBoxRegist)
        Me.Controls.Add(Me.PARKING_SPACEComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PARKING_ZONEComboBox)
        Me.Name = "FormCheckIn"
        Me.Text = "FormCheckIn"
        CType(Me.SUT_PARKINGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARKING_ZONEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARKING_SPACEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAST_BOOKING_VIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SUT_PARKINGDataSet As SUT_PARKINGDataSet
    Friend WithEvents PARKING_ZONEBindingSource As BindingSource
    Friend WithEvents PARKING_ZONETableAdapter As SUT_PARKINGDataSetTableAdapters.PARKING_ZONETableAdapter
    Friend WithEvents TableAdapterManager As SUT_PARKINGDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PARKING_ZONEComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PARKING_SPACEBindingSource As BindingSource
    Friend WithEvents PARKING_SPACETableAdapter As SUT_PARKINGDataSetTableAdapters.PARKING_SPACETableAdapter
    Friend WithEvents PARKING_SPACEComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxRegist As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents LAST_BOOKING_VIEWBindingSource As BindingSource
    Friend WithEvents LAST_BOOKING_VIEWTableAdapter As SUT_PARKINGDataSetTableAdapters.LAST_BOOKING_VIEWTableAdapter
    Friend WithEvents Booking_idTextBox As TextBox
    Friend WithEvents Prkspace_idTextBox As TextBox
    Friend WithEvents Car_registTextBox As TextBox
    Friend WithEvents Start_datetimeDateTimePicker As DateTimePicker
    Friend WithEvents End_datetimeDateTimePicker As DateTimePicker
    Friend WithEvents BOOKINGBindingSource As BindingSource
    Friend WithEvents BOOKINGTableAdapter As SUT_PARKINGDataSetTableAdapters.BOOKINGTableAdapter
End Class
