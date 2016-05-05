Imports BookStore
Imports BookStore.Models

Public Class Main

    Enum Mode
        List = 0
        Edit = 1
    End Enum


    Private _bookRepository As IBookRepository
    Private _data As List(Of Book)
    Private _mode As Mode
    Private _currentId As Long?

    Public Sub New()
        ''        _bookRepository = New DummyBookRepository()
        _bookRepository = New CsvBookRepository()
        InitializeComponent()
        EnterListMode()
    End Sub

    Private Sub DisableEditControls()
        For Each ctrl In New Control() {IdTextBox, AuthorTextBox, PublishDateTimePicker, TitleTextBox}
            ctrl.Enabled = False
        Next

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        Select Case _mode
            Case Mode.List
                Dim currentBook As Book = GetCurrentBook()
                _currentId = currentBook.ID
                Dim copy = currentBook.Copy()
                EnterEditMode(copy)
            Case Mode.Edit
                EnterListMode()
            Case Else
                Throw New InvalidOperationException("unknown mode")
        End Select

    End Sub

    Private Sub EnterEditMode(book As Book)
        _mode = Mode.Edit
        EnableEditControls()
        BookBindingSource.DataSource = book
        UpdateNavButtonState()
        EditButton.Text = "Cancel"
        SaveButton.Enabled = True
        DeleteButton.Enabled = False
        NewButton.Enabled = False
        SearchGroupBox.Enabled = False
    End Sub

    Private Sub EnterListMode()
        _mode = Mode.List
        DisableEditControls()
        If _data IsNot Nothing Then
            BookBindingSource.DataSource = _data
        End If
        UpdateNavButtonState()
        EditButton.Text = "Edit"
        EditButton.Enabled = True
        SaveButton.Enabled = False
        DeleteButton.Enabled = True
        NewButton.Enabled = True
        SearchGroupBox.Enabled = True
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim currentBook As Book = GetCurrentBook()
        _bookRepository.Update(_currentId, currentBook)
        EnterListMode()
    End Sub

    Private Function GetCurrentBook() As Book
        Return DirectCast(BookBindingSource.Current, Book)
    End Function

    Private Sub EnableEditControls()
        For Each ctrl In New Control() {AuthorTextBox, PublishDateTimePicker, TitleTextBox}
            ctrl.Enabled = True
        Next
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDataFromRepository()
    End Sub

    Private Sub UpdateDataFromRepository()
        _data = _bookRepository.GetAllBooks()

        BookBindingSource.DataSource = _data
        BookBindingSource.ResetBindings(False)
        UpdateNavButtonState()
    End Sub

    Private Sub UpdateNavButtonState()
        PrevButton.Enabled = BookBindingSource.Count > 0 AndAlso Not BookBindingSource.Position = 0
        NextButton.Enabled = BookBindingSource.Count > 0 AndAlso Not BookBindingSource.Position = BookBindingSource.Count - 1
        EditButton.Enabled = EditButton.Enabled AndAlso BookBindingSource.Count > 0
        DeleteButton.Enabled = DeleteButton.Enabled AndAlso BookBindingSource.Count > 0
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        BookBindingSource.MoveNext()
    End Sub

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        BookBindingSource.MovePrevious()
    End Sub

    Private Sub BookBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles BookBindingSource.PositionChanged
        UpdateNavButtonState()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If MessageBox.Show(Me, "Delete this book?", "Confirm delete", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
            Return
        End If

        Dim currentBook = GetCurrentBook()
        If currentBook IsNot Nothing Then
            _bookRepository.Delete(currentBook.ID)
            UpdateDataFromRepository()
        End If

    End Sub

    Private Sub NewButton_Click(sender As Object, e As EventArgs) Handles NewButton.Click
        EnterEditMode(New Book())
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles IdSearchBox.TextChanged, TitleSearchBox.TextChanged, AuthorSearchBox.TextChanged, YearSearchBox.TextChanged

        Dim hits = _data.Where(Function(b) b.Author.ToLowerInvariant().Contains(AuthorSearchBox.Text.ToLowerInvariant()) AndAlso
                                           b.Title.ToLowerInvariant().Contains(TitleSearchBox.Text.ToLowerInvariant()) AndAlso
                                           b.ID.ToString().Contains(IdSearchBox.Text) AndAlso
                                           b.PublishDate.Year.ToString().StartsWith(YearSearchBox.Text)).ToList()

        If hits.Any Then
            BookBindingSource.Position = _data.IndexOf(hits.First())
        End If

    End Sub

End Class
