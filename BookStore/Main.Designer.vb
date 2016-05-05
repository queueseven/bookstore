<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.PublishDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AuthorTextBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoadDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.SearchGroupBox = New System.Windows.Forms.GroupBox()
        Me.IdSearchBox = New System.Windows.Forms.TextBox()
        Me.TitleSearchBox = New System.Windows.Forms.TextBox()
        Me.AuthorSearchBox = New System.Windows.Forms.TextBox()
        Me.YearSearchBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SearchGroupBox.SuspendLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Me.EditButton)
        Me.GroupBox1.Controls.Add(Me.PublishDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.AuthorTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 180)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book information"
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Location = New System.Drawing.Point(292, 151)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Enabled = False
        Me.SaveButton.Location = New System.Drawing.Point(211, 151)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditButton.Location = New System.Drawing.Point(129, 151)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 6
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'PublishDateTimePicker
        '
        Me.PublishDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublishDateTimePicker.CustomFormat = ""
        Me.PublishDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookBindingSource, "PublishDate", True))
        Me.PublishDateTimePicker.Enabled = False
        Me.PublishDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PublishDateTimePicker.Location = New System.Drawing.Point(129, 114)
        Me.PublishDateTimePicker.Name = "PublishDateTimePicker"
        Me.PublishDateTimePicker.Size = New System.Drawing.Size(238, 22)
        Me.PublishDateTimePicker.TabIndex = 9
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Author", True))
        Me.AuthorTextBox.Enabled = False
        Me.AuthorTextBox.FormattingEnabled = True
        Me.AuthorTextBox.Location = New System.Drawing.Point(129, 84)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(238, 24)
        Me.AuthorTextBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Publishing date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "#"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Title"
        '
        'IdTextBox
        '
        Me.IdTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "ID", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(129, 28)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(238, 22)
        Me.IdTextBox.TabIndex = 4
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Title", True))
        Me.TitleTextBox.Enabled = False
        Me.TitleTextBox.Location = New System.Drawing.Point(129, 56)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(238, 22)
        Me.TitleTextBox.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDataToolStripMenuItem, Me.SaveToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(167, 82)
        '
        'LoadDataToolStripMenuItem
        '
        Me.LoadDataToolStripMenuItem.Name = "LoadDataToolStripMenuItem"
        Me.LoadDataToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoadDataToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.LoadDataToolStripMenuItem.Text = "Load"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'PrevButton
        '
        Me.PrevButton.Enabled = False
        Me.PrevButton.Location = New System.Drawing.Point(12, 211)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(75, 23)
        Me.PrevButton.TabIndex = 5
        Me.PrevButton.Text = "Previous"
        Me.PrevButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Enabled = False
        Me.NextButton.Location = New System.Drawing.Point(93, 211)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 6
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NewButton.Location = New System.Drawing.Point(298, 211)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(94, 23)
        Me.NewButton.TabIndex = 10
        Me.NewButton.Text = "New book"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'SearchGroupBox
        '
        Me.SearchGroupBox.Controls.Add(Me.IdSearchBox)
        Me.SearchGroupBox.Controls.Add(Me.TitleSearchBox)
        Me.SearchGroupBox.Controls.Add(Me.AuthorSearchBox)
        Me.SearchGroupBox.Controls.Add(Me.YearSearchBox)
        Me.SearchGroupBox.Controls.Add(Me.Label5)
        Me.SearchGroupBox.Controls.Add(Me.Label6)
        Me.SearchGroupBox.Controls.Add(Me.Label7)
        Me.SearchGroupBox.Controls.Add(Me.Label8)
        Me.SearchGroupBox.Location = New System.Drawing.Point(403, 12)
        Me.SearchGroupBox.Name = "SearchGroupBox"
        Me.SearchGroupBox.Size = New System.Drawing.Size(264, 180)
        Me.SearchGroupBox.TabIndex = 11
        Me.SearchGroupBox.TabStop = False
        Me.SearchGroupBox.Text = "Suche"
        '
        'IdSearchBox
        '
        Me.IdSearchBox.Location = New System.Drawing.Point(126, 28)
        Me.IdSearchBox.Name = "IdSearchBox"
        Me.IdSearchBox.Size = New System.Drawing.Size(132, 22)
        Me.IdSearchBox.TabIndex = 8
        '
        'TitleSearchBox
        '
        Me.TitleSearchBox.Location = New System.Drawing.Point(126, 56)
        Me.TitleSearchBox.Name = "TitleSearchBox"
        Me.TitleSearchBox.Size = New System.Drawing.Size(132, 22)
        Me.TitleSearchBox.TabIndex = 8
        '
        'AuthorSearchBox
        '
        Me.AuthorSearchBox.Location = New System.Drawing.Point(126, 84)
        Me.AuthorSearchBox.Name = "AuthorSearchBox"
        Me.AuthorSearchBox.Size = New System.Drawing.Size(132, 22)
        Me.AuthorSearchBox.TabIndex = 8
        '
        'YearSearchBox
        '
        Me.YearSearchBox.Location = New System.Drawing.Point(126, 113)
        Me.YearSearchBox.Name = "YearSearchBox"
        Me.YearSearchBox.Size = New System.Drawing.Size(132, 22)
        Me.YearSearchBox.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Title"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Author"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Publishing year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "#"
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataSource = GetType(BookStore.Models.Book)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 246)
        Me.Controls.Add(Me.SearchGroupBox)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(426, 293)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "Bookstore"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SearchGroupBox.ResumeLayout(False)
        Me.SearchGroupBox.PerformLayout()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PublishDateTimePicker As DateTimePicker
    Friend WithEvents AuthorTextBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LoadDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents PrevButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents NewButton As Button
    Friend WithEvents SearchGroupBox As GroupBox
    Friend WithEvents YearSearchBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents IdSearchBox As TextBox
    Friend WithEvents TitleSearchBox As TextBox
    Friend WithEvents AuthorSearchBox As TextBox
End Class
