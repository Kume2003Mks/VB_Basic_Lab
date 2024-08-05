<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckOut
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
        Me.components = New System.ComponentModel.Container()
        Dim Booking_idLabel As System.Windows.Forms.Label
        Dim Prkspace_idLabel As System.Windows.Forms.Label
        Dim Car_registLabel As System.Windows.Forms.Label
        Dim Start_datetimeLabel As System.Windows.Forms.Label
        Dim End_datetimeLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CarregistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOOKINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUT_PARKINGDataSet = New lab_1.SUT_PARKINGDataSet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Booking_idTextBox = New System.Windows.Forms.TextBox()
        Me.Prkspace_idTextBox = New System.Windows.Forms.TextBox()
        Me.Car_registTextBox = New System.Windows.Forms.TextBox()
        Me.Start_datetimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.End_datetimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BOOKINGTableAdapter = New lab_1.SUT_PARKINGDataSetTableAdapters.BOOKINGTableAdapter()
        Me.TableAdapterManager = New lab_1.SUT_PARKINGDataSetTableAdapters.TableAdapterManager()
        Booking_idLabel = New System.Windows.Forms.Label()
        Prkspace_idLabel = New System.Windows.Forms.Label()
        Car_registLabel = New System.Windows.Forms.Label()
        Start_datetimeLabel = New System.Windows.Forms.Label()
        End_datetimeLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUT_PARKINGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Booking_idLabel
        '
        Booking_idLabel.AutoSize = True
        Booking_idLabel.Location = New System.Drawing.Point(35, 70)
        Booking_idLabel.Name = "Booking_idLabel"
        Booking_idLabel.Size = New System.Drawing.Size(73, 16)
        Booking_idLabel.TabIndex = 0
        Booking_idLabel.Text = "booking id:"
        '
        'Prkspace_idLabel
        '
        Prkspace_idLabel.AutoSize = True
        Prkspace_idLabel.Location = New System.Drawing.Point(35, 98)
        Prkspace_idLabel.Name = "Prkspace_idLabel"
        Prkspace_idLabel.Size = New System.Drawing.Size(81, 16)
        Prkspace_idLabel.TabIndex = 2
        Prkspace_idLabel.Text = "prkspace id:"
        '
        'Car_registLabel
        '
        Car_registLabel.AutoSize = True
        Car_registLabel.Location = New System.Drawing.Point(35, 126)
        Car_registLabel.Name = "Car_registLabel"
        Car_registLabel.Size = New System.Drawing.Size(65, 16)
        Car_registLabel.TabIndex = 4
        Car_registLabel.Text = "car regist:"
        '
        'Start_datetimeLabel
        '
        Start_datetimeLabel.AutoSize = True
        Start_datetimeLabel.Location = New System.Drawing.Point(35, 155)
        Start_datetimeLabel.Name = "Start_datetimeLabel"
        Start_datetimeLabel.Size = New System.Drawing.Size(90, 16)
        Start_datetimeLabel.TabIndex = 6
        Start_datetimeLabel.Text = "start datetime:"
        '
        'End_datetimeLabel
        '
        End_datetimeLabel.AutoSize = True
        End_datetimeLabel.Location = New System.Drawing.Point(35, 183)
        End_datetimeLabel.Name = "End_datetimeLabel"
        End_datetimeLabel.Size = New System.Drawing.Size(88, 16)
        End_datetimeLabel.TabIndex = 8
        End_datetimeLabel.Text = "end datetime:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarregistDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BOOKINGBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Location = New System.Drawing.Point(27, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(370, 396)
        Me.DataGridView1.TabIndex = 0
        '
        'CarregistDataGridViewTextBoxColumn
        '
        Me.CarregistDataGridViewTextBoxColumn.DataPropertyName = "car_regist"
        Me.CarregistDataGridViewTextBoxColumn.HeaderText = "car_regist"
        Me.CarregistDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CarregistDataGridViewTextBoxColumn.Name = "CarregistDataGridViewTextBoxColumn"
        Me.CarregistDataGridViewTextBoxColumn.Width = 125
        '
        'BOOKINGBindingSource
        '
        Me.BOOKINGBindingSource.DataMember = "BOOKING"
        Me.BOOKINGBindingSource.DataSource = Me.SUT_PARKINGDataSet
        '
        'SUT_PARKINGDataSet
        '
        Me.SUT_PARKINGDataSet.DataSetName = "SUT_PARKINGDataSet"
        Me.SUT_PARKINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(24)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Booking_idLabel)
        Me.Panel1.Controls.Add(Me.Booking_idTextBox)
        Me.Panel1.Controls.Add(Prkspace_idLabel)
        Me.Panel1.Controls.Add(Me.Prkspace_idTextBox)
        Me.Panel1.Controls.Add(Car_registLabel)
        Me.Panel1.Controls.Add(Me.Car_registTextBox)
        Me.Panel1.Controls.Add(Start_datetimeLabel)
        Me.Panel1.Controls.Add(Me.Start_datetimeDateTimePicker)
        Me.Panel1.Controls.Add(End_datetimeLabel)
        Me.Panel1.Controls.Add(Me.End_datetimeDateTimePicker)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(403, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 396)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(103, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 62)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Booking_idTextBox
        '
        Me.Booking_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKINGBindingSource, "booking_id", True))
        Me.Booking_idTextBox.Location = New System.Drawing.Point(131, 67)
        Me.Booking_idTextBox.Name = "Booking_idTextBox"
        Me.Booking_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Booking_idTextBox.TabIndex = 1
        '
        'Prkspace_idTextBox
        '
        Me.Prkspace_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKINGBindingSource, "prkspace_id", True))
        Me.Prkspace_idTextBox.Location = New System.Drawing.Point(131, 95)
        Me.Prkspace_idTextBox.Name = "Prkspace_idTextBox"
        Me.Prkspace_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Prkspace_idTextBox.TabIndex = 3
        '
        'Car_registTextBox
        '
        Me.Car_registTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BOOKINGBindingSource, "car_regist", True))
        Me.Car_registTextBox.Location = New System.Drawing.Point(131, 123)
        Me.Car_registTextBox.Name = "Car_registTextBox"
        Me.Car_registTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Car_registTextBox.TabIndex = 5
        '
        'Start_datetimeDateTimePicker
        '
        Me.Start_datetimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BOOKINGBindingSource, "start_datetime", True))
        Me.Start_datetimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Start_datetimeDateTimePicker.Location = New System.Drawing.Point(131, 151)
        Me.Start_datetimeDateTimePicker.Name = "Start_datetimeDateTimePicker"
        Me.Start_datetimeDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Start_datetimeDateTimePicker.TabIndex = 7
        '
        'End_datetimeDateTimePicker
        '
        Me.End_datetimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BOOKINGBindingSource, "end_datetime", True))
        Me.End_datetimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.End_datetimeDateTimePicker.Location = New System.Drawing.Point(131, 179)
        Me.End_datetimeDateTimePicker.Name = "End_datetimeDateTimePicker"
        Me.End_datetimeDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.End_datetimeDateTimePicker.TabIndex = 9
        '
        'BOOKINGTableAdapter
        '
        Me.BOOKINGTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKINGTableAdapter = Me.BOOKINGTableAdapter
        Me.TableAdapterManager.EMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.PARKING_SPACETableAdapter = Nothing
        Me.TableAdapterManager.PARKING_ZONETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = lab_1.SUT_PARKINGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormCheckOut"
        Me.Text = "FormCheckOut"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUT_PARKINGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SUT_PARKINGDataSet As SUT_PARKINGDataSet
    Friend WithEvents BOOKINGBindingSource As BindingSource
    Friend WithEvents BOOKINGTableAdapter As SUT_PARKINGDataSetTableAdapters.BOOKINGTableAdapter
    Friend WithEvents CarregistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Booking_idTextBox As TextBox
    Friend WithEvents Prkspace_idTextBox As TextBox
    Friend WithEvents Car_registTextBox As TextBox
    Friend WithEvents Start_datetimeDateTimePicker As DateTimePicker
    Friend WithEvents End_datetimeDateTimePicker As DateTimePicker
    Friend WithEvents TableAdapterManager As SUT_PARKINGDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
End Class
