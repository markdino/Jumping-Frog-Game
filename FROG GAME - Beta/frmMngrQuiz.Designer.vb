<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMngrQuiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMngrQuiz))
        Dim IDLabel As System.Windows.Forms.Label
        Dim QuizLabel As System.Windows.Forms.Label
        Dim CorrectLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.MathquizDataSet = New FROG_GAME___Beta.mathquizDataSet()
        Me.MathBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MathTableAdapter = New FROG_GAME___Beta.mathquizDataSetTableAdapters.MathTableAdapter()
        Me.TableAdapterManager = New FROG_GAME___Beta.mathquizDataSetTableAdapters.TableAdapterManager()
        Me.MathBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MathBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MathDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.QuizTextBox = New System.Windows.Forms.TextBox()
        Me.ATextBox = New System.Windows.Forms.TextBox()
        Me.BTextBox = New System.Windows.Forms.TextBox()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        Me.DTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.CorrectTextBox = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        QuizLabel = New System.Windows.Forms.Label()
        CorrectLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.MathquizDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MathBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MathBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MathBindingNavigator.SuspendLayout()
        CType(Me.MathDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MathquizDataSet
        '
        Me.MathquizDataSet.DataSetName = "mathquizDataSet"
        Me.MathquizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MathBindingSource
        '
        Me.MathBindingSource.DataMember = "Math"
        Me.MathBindingSource.DataSource = Me.MathquizDataSet
        '
        'MathTableAdapter
        '
        Me.MathTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MathTableAdapter = Me.MathTableAdapter
        Me.TableAdapterManager.UpdateOrder = FROG_GAME___Beta.mathquizDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MathBindingNavigator
        '
        Me.MathBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MathBindingNavigator.BindingSource = Me.MathBindingSource
        Me.MathBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MathBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MathBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MathBindingNavigatorSaveItem})
        Me.MathBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MathBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MathBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MathBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MathBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MathBindingNavigator.Name = "MathBindingNavigator"
        Me.MathBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MathBindingNavigator.Size = New System.Drawing.Size(887, 25)
        Me.MathBindingNavigator.TabIndex = 0
        Me.MathBindingNavigator.Text = "BindingNavigator1"
        Me.MathBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MathBindingNavigatorSaveItem
        '
        Me.MathBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MathBindingNavigatorSaveItem.Image = CType(resources.GetObject("MathBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MathBindingNavigatorSaveItem.Name = "MathBindingNavigatorSaveItem"
        Me.MathBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MathBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MathDataGridView
        '
        Me.MathDataGridView.AllowUserToAddRows = False
        Me.MathDataGridView.AllowUserToDeleteRows = False
        Me.MathDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MathDataGridView.AutoGenerateColumns = False
        Me.MathDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MathDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MathDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8})
        Me.MathDataGridView.DataSource = Me.MathBindingSource
        Me.MathDataGridView.Location = New System.Drawing.Point(12, 48)
        Me.MathDataGridView.Name = "MathDataGridView"
        Me.MathDataGridView.Size = New System.Drawing.Size(855, 180)
        Me.MathDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Quiz"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quiz"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "A"
        Me.DataGridViewTextBoxColumn3.HeaderText = "A"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "B"
        Me.DataGridViewTextBoxColumn4.HeaderText = "B"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "C"
        Me.DataGridViewTextBoxColumn5.HeaderText = "C"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "D"
        Me.DataGridViewTextBoxColumn6.HeaderText = "D"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "take"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "take"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Correct"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Correct"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(15, 250)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MathBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(42, 251)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(58, 19)
        Me.IDTextBox.TabIndex = 3
        '
        'QuizLabel
        '
        QuizLabel.AutoSize = True
        QuizLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuizLabel.Location = New System.Drawing.Point(15, 278)
        QuizLabel.Name = "QuizLabel"
        QuizLabel.Size = New System.Drawing.Size(77, 20)
        QuizLabel.TabIndex = 4
        QuizLabel.Text = "Question:"
        '
        'QuizTextBox
        '
        Me.QuizTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuizTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MathBindingSource, "Quiz", True))
        Me.QuizTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuizTextBox.Location = New System.Drawing.Point(18, 301)
        Me.QuizTextBox.Multiline = True
        Me.QuizTextBox.Name = "QuizTextBox"
        Me.QuizTextBox.Size = New System.Drawing.Size(493, 137)
        Me.QuizTextBox.TabIndex = 5
        '
        'ATextBox
        '
        Me.ATextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MathBindingSource, "A", True))
        Me.ATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATextBox.Location = New System.Drawing.Point(525, 254)
        Me.ATextBox.Name = "ATextBox"
        Me.ATextBox.Size = New System.Drawing.Size(157, 26)
        Me.ATextBox.TabIndex = 7
        '
        'BTextBox
        '
        Me.BTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MathBindingSource, "B", True))
        Me.BTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTextBox.Location = New System.Drawing.Point(710, 254)
        Me.BTextBox.Name = "BTextBox"
        Me.BTextBox.Size = New System.Drawing.Size(157, 26)
        Me.BTextBox.TabIndex = 9
        '
        'CTextBox
        '
        Me.CTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MathBindingSource, "C", True))
        Me.CTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTextBox.Location = New System.Drawing.Point(524, 286)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(157, 26)
        Me.CTextBox.TabIndex = 11
        '
        'DTextBox
        '
        Me.DTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MathBindingSource, "D", True))
        Me.DTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTextBox.Location = New System.Drawing.Point(710, 286)
        Me.DTextBox.Name = "DTextBox"
        Me.DTextBox.Size = New System.Drawing.Size(157, 26)
        Me.DTextBox.TabIndex = 12
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MathBindingSource, "Notes", True))
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(523, 376)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(344, 62)
        Me.NotesTextBox.TabIndex = 13
        '
        'CorrectLabel
        '
        CorrectLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CorrectLabel.AutoSize = True
        CorrectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorrectLabel.Location = New System.Drawing.Point(521, 321)
        CorrectLabel.Name = "CorrectLabel"
        CorrectLabel.Size = New System.Drawing.Size(65, 20)
        CorrectLabel.TabIndex = 13
        CorrectLabel.Text = "Correct:"
        '
        'CorrectTextBox
        '
        Me.CorrectTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CorrectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MathBindingSource, "Correct", True))
        Me.CorrectTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorrectTextBox.Location = New System.Drawing.Point(591, 318)
        Me.CorrectTextBox.Name = "CorrectTextBox"
        Me.CorrectTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CorrectTextBox.TabIndex = 14
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(559, 447)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 33)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(681, 447)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 33)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(777, 447)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 33)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(463, 447)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 33)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(445, 257)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 20)
        Label1.TabIndex = 2
        Label1.Text = "Answers:"
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(521, 353)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(55, 20)
        Label2.TabIndex = 13
        Label2.Text = "Notes:"
        '
        'frmMngrQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 487)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Label2)
        Me.Controls.Add(CorrectLabel)
        Me.Controls.Add(Me.CorrectTextBox)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.DTextBox)
        Me.Controls.Add(Me.CTextBox)
        Me.Controls.Add(Me.BTextBox)
        Me.Controls.Add(Me.ATextBox)
        Me.Controls.Add(QuizLabel)
        Me.Controls.Add(Me.QuizTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.MathDataGridView)
        Me.Controls.Add(Me.MathBindingNavigator)
        Me.MinimumSize = New System.Drawing.Size(903, 526)
        Me.Name = "frmMngrQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager Quiz"
        CType(Me.MathquizDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MathBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MathBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MathBindingNavigator.ResumeLayout(False)
        Me.MathBindingNavigator.PerformLayout()
        CType(Me.MathDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MathquizDataSet As mathquizDataSet
    Friend WithEvents MathBindingSource As BindingSource
    Friend WithEvents MathTableAdapter As mathquizDataSetTableAdapters.MathTableAdapter
    Friend WithEvents TableAdapterManager As mathquizDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MathBindingNavigator As BindingNavigator
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
    Friend WithEvents MathBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MathDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents QuizTextBox As TextBox
    Friend WithEvents ATextBox As TextBox
    Friend WithEvents BTextBox As TextBox
    Friend WithEvents CTextBox As TextBox
    Friend WithEvents DTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents CorrectTextBox As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
End Class
