<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormParkingSpace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormParkingSpace))
        Me.SUT_PARKINGDataSet = New lab_1.SUT_PARKINGDataSet()
        Me.LIST_BOOKING_VIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIST_BOOKING_VIEWTableAdapter = New lab_1.SUT_PARKINGDataSetTableAdapters.LIST_BOOKING_VIEWTableAdapter()
        Me.TableAdapterManager = New lab_1.SUT_PARKINGDataSetTableAdapters.TableAdapterManager()
        Me.LIST_BOOKING_VIEWBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LIST_BOOKING_VIEWDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SUT_PARKINGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_BOOKING_VIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIST_BOOKING_VIEWBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LIST_BOOKING_VIEWBindingNavigator.SuspendLayout()
        CType(Me.LIST_BOOKING_VIEWDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.PARKING_SPACETableAdapter = Nothing
        Me.TableAdapterManager.PARKING_ZONETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = lab_1.SUT_PARKINGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.LIST_BOOKING_VIEWBindingNavigator.Size = New System.Drawing.Size(800, 31)
        Me.LIST_BOOKING_VIEWBindingNavigator.TabIndex = 0
        Me.LIST_BOOKING_VIEWBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'LIST_BOOKING_VIEWBindingNavigatorSaveItem
        '
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Enabled = False
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Image = CType(resources.GetObject("LIST_BOOKING_VIEWBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Name = "LIST_BOOKING_VIEWBindingNavigatorSaveItem"
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.LIST_BOOKING_VIEWBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LIST_BOOKING_VIEWDataGridView
        '
        Me.LIST_BOOKING_VIEWDataGridView.AutoGenerateColumns = False
        Me.LIST_BOOKING_VIEWDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LIST_BOOKING_VIEWDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.LIST_BOOKING_VIEWDataGridView.DataSource = Me.LIST_BOOKING_VIEWBindingSource
        Me.LIST_BOOKING_VIEWDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LIST_BOOKING_VIEWDataGridView.Location = New System.Drawing.Point(0, 31)
        Me.LIST_BOOKING_VIEWDataGridView.Name = "LIST_BOOKING_VIEWDataGridView"
        Me.LIST_BOOKING_VIEWDataGridView.RowHeadersWidth = 51
        Me.LIST_BOOKING_VIEWDataGridView.RowTemplate.Height = 24
        Me.LIST_BOOKING_VIEWDataGridView.Size = New System.Drawing.Size(800, 419)
        Me.LIST_BOOKING_VIEWDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "booking_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "booking_id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Space"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Space"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Zone"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Zone"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Car Registration"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Car Registration"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Start" & Global.Microsoft.VisualBasic.ChrW(10) & "Booking"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Start" & Global.Microsoft.VisualBasic.ChrW(10) & "Booking"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "End Booking"
        Me.DataGridViewTextBoxColumn6.HeaderText = "End Booking"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'FormParkingSpace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LIST_BOOKING_VIEWDataGridView)
        Me.Controls.Add(Me.LIST_BOOKING_VIEWBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormParkingSpace"
        Me.Text = "FormParkingSpace"
        CType(Me.SUT_PARKINGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_BOOKING_VIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIST_BOOKING_VIEWBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LIST_BOOKING_VIEWBindingNavigator.ResumeLayout(False)
        Me.LIST_BOOKING_VIEWBindingNavigator.PerformLayout()
        CType(Me.LIST_BOOKING_VIEWDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LIST_BOOKING_VIEWDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
