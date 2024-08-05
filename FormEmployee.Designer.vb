<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployee
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
        Dim Employee_idLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim BirthdayLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmployee))
        Me.SUT_PARKINGDataSet = New lab_1.SUT_PARKINGDataSet()
        Me.LIST_BOOKING_VIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIST_BOOKING_VIEWTableAdapter = New lab_1.SUT_PARKINGDataSetTableAdapters.LIST_BOOKING_VIEWTableAdapter()
        Me.TableAdapterManager = New lab_1.SUT_PARKINGDataSetTableAdapters.TableAdapterManager()
        Me.EMPLOYEETableAdapter = New lab_1.SUT_PARKINGDataSetTableAdapters.EMPLOYEETableAdapter()
        Me.LIST_BOOKING_VIEWBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EMPLOYEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_idTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdayDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Employee_idLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        BirthdayLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        CType(Me.SUT_PARKINGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_BOOKING_VIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_BOOKING_VIEWBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LIST_BOOKING_VIEWBindingNavigator.SuspendLayout()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Employee_idLabel
        '
        Employee_idLabel.AutoSize = True
        Employee_idLabel.Location = New System.Drawing.Point(229, 152)
        Employee_idLabel.Name = "Employee_idLabel"
        Employee_idLabel.Size = New System.Drawing.Size(85, 16)
        Employee_idLabel.TabIndex = 1
        Employee_idLabel.Text = "employee id:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Location = New System.Drawing.Point(229, 180)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(67, 16)
        First_nameLabel.TabIndex = 3
        First_nameLabel.Text = "first name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Location = New System.Drawing.Point(229, 208)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(68, 16)
        Last_nameLabel.TabIndex = 5
        Last_nameLabel.Text = "last name:"
        '
        'BirthdayLabel
        '
        BirthdayLabel.AutoSize = True
        BirthdayLabel.Location = New System.Drawing.Point(229, 237)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New System.Drawing.Size(58, 16)
        BirthdayLabel.TabIndex = 7
        BirthdayLabel.Text = "birthday:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(229, 264)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(47, 16)
        SalaryLabel.TabIndex = 9
        SalaryLabel.Text = "salary:"
        '
        'SUT_PARKINGDataSet
        '
        Me.SUT_PARKINGDataSet.DataSetName = "SUT_PARKINGDataSet"
        Me.SUT_PARKINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LIST_BOOKING_VIEWBindingSource
        '
        Me.LIST_BOOKING_VIEWBindingSource.DataMember = "LIST_BOOKING_VIEW"
        Me.LIST_BOOKING_VIEWBindingSource.DataSource = Me.SUT_PARKINGDataSet
        '
        'LIST_BOOKING_VIEWTableAdapter
        '
        Me.LIST_BOOKING_VIEWTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOOKINGTableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEETableAdapter = Me.EMPLOYEETableAdapter
        Me.TableAdapterManager.PARKING_SPACETableAdapter = Nothing
        Me.TableAdapterManager.PARKING_ZONETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = lab_1.SUT_PARKINGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMPLOYEETableAdapter
        '
        Me.EMPLOYEETableAdapter.ClearBeforeFill = True
        '
        'LIST_BOOKING_VIEWBindingNavigator
        '
        Me.LIST_BOOKING_VIEWBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LIST_BOOKING_VIEWBindingNavigator.BindingSource = Me.LIST_BOOKING_VIEWBindingSource
        Me.LIST_BOOKING_VIEWBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LIST_BOOKING_VIEWBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LIST_BOOKING_VIEWBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.LIST_BOOKING_VIEWBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem})
        Me.LIST_BOOKING_VIEWBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LIST_BOOKING_VIEWBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LIST_BOOKING_VIEWBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LIST_BOOKING_VIEWBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LIST_BOOKING_VIEWBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LIST_BOOKING_VIEWBindingNavigator.Name = "LIST_BOOKING_VIEWBindingNavigator"
        Me.LIST_BOOKING_VIEWBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LIST_BOOKING_VIEWBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.LIST_BOOKING_VIEWBindingNavigator.TabIndex = 0
        Me.LIST_BOOKING_VIEWBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'LIST_BOOKING_VIEWBindingNavigatorSaveItem
        '
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Enabled = False
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Image = CType(resources.GetObject("LIST_BOOKING_VIEWBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Name = "LIST_BOOKING_VIEWBindingNavigatorSaveItem"
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EMPLOYEEBindingSource
        '
        Me.EMPLOYEEBindingSource.DataMember = "EMPLOYEE"
        Me.EMPLOYEEBindingSource.DataSource = Me.SUT_PARKINGDataSet
        '
        'Employee_idTextBox
        '
        Me.Employee_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "employee_id", True))
        Me.Employee_idTextBox.Location = New System.Drawing.Point(320, 149)
        Me.Employee_idTextBox.Name = "Employee_idTextBox"
        Me.Employee_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Employee_idTextBox.TabIndex = 2
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(320, 177)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.First_nameTextBox.TabIndex = 4
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "last_name", True))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(320, 205)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Last_nameTextBox.TabIndex = 6
        '
        'BirthdayDateTimePicker
        '
        Me.BirthdayDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EMPLOYEEBindingSource, "birthday", True))
        Me.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthdayDateTimePicker.Location = New System.Drawing.Point(320, 233)
        Me.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker"
        Me.BirthdayDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.BirthdayDateTimePicker.TabIndex = 8
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLOYEEBindingSource, "salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(320, 261)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(200, 22)
        Me.SalaryTextBox.TabIndex = 10
        '
        'FormEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Employee_idLabel)
        Me.Controls.Add(Me.Employee_idTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(BirthdayLabel)
        Me.Controls.Add(Me.BirthdayDateTimePicker)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Me.LIST_BOOKING_VIEWBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEmployee"
        Me.Text = "FormEmployee"
        CType(Me.SUT_PARKINGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_BOOKING_VIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_BOOKING_VIEWBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LIST_BOOKING_VIEWBindingNavigator.ResumeLayout(False)
        Me.LIST_BOOKING_VIEWBindingNavigator.PerformLayout()
        CType(Me.EMPLOYEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SUT_PARKINGDataSet As SUT_PARKINGDataSet
    Friend WithEvents LIST_BOOKING_VIEWBindingSource As BindingSource
    Friend WithEvents LIST_BOOKING_VIEWTableAdapter As SUT_PARKINGDataSetTableAdapters.LIST_BOOKING_VIEWTableAdapter
    Friend WithEvents TableAdapterManager As SUT_PARKINGDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LIST_BOOKING_VIEWBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents LIST_BOOKING_VIEWBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EMPLOYEETableAdapter As SUT_PARKINGDataSetTableAdapters.EMPLOYEETableAdapter
    Friend WithEvents EMPLOYEEBindingSource As BindingSource
    Friend WithEvents Employee_idTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents BirthdayDateTimePicker As DateTimePicker
    Friend WithEvents SalaryTextBox As TextBox
End Class
