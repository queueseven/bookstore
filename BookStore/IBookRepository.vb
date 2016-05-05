Imports BookStore.Models

Public Interface IBookRepository

    Function GetAllBooks() As List(Of Book)
    Sub Update(_currentId As Long?, currentBook As Book)
    Sub Delete(iD As Long?)
    Sub Save()
End Interface
