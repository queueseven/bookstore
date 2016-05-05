Imports System.IO
Imports BookStore
Imports BookStore.Models
Imports FileHelpers

Public MustInherit Class BookRepositoryBase
    Implements IBookRepository

    Private _data As List(Of Book)

    MustOverride Function LoadData() As List(Of Book)

    MustOverride Sub SaveData(data As List(Of Book))

    Public Sub Delete(iD As Long?) Implements IBookRepository.Delete
        If Not iD.HasValue Then
            Return
        End If

        _data.RemoveAll(Function(b) b.ID.Value = iD.Value)
        Save()
    End Sub

    Public Sub Update(currentId As Long?, currentBook As Book) Implements IBookRepository.Update
        If (currentId.HasValue) Then
            _data.RemoveAll(Function(b) b.ID.Value = currentId.Value)
            currentBook.ID = currentId
        Else
            currentBook.ID = If(_data.Any(), _data.Max(Function(b) b.ID.Value) + 1, 0)
        End If

        _data.Add(currentBook)
        Save()
    End Sub

    Public Function GetAllBooks() As List(Of Book) Implements IBookRepository.GetAllBooks

        If _data Is Nothing Then
            _data = LoadData()
        End If

        Return _data

    End Function

    Public Sub Save() Implements IBookRepository.Save
        SaveData(_data)
    End Sub
End Class

Public Class CsvBookRepository
    Inherits BookRepositoryBase

    <DelimitedRecord("|")>
    Public Class CsvBook
        Public Author As String
        Public Title As String
        <FieldConverter(ConverterKind.Date, "ddMMyyyy")>
        Public PubDate As DateTime
        Public ID As Long
    End Class

    Private Const fileName As String = "data.txt"

    Private _engine As FileHelperEngine(Of CsvBook)

    Public Overrides Function LoadData() As List(Of Book)

        _engine = New FileHelperEngine(Of CsvBook)()

        If Not File.Exists(fileName) Then
            Return New List(Of Book)
        End If

        Return _engine.ReadFile(fileName).Select(Function(csv) New Book With
        {
            .Author = csv.Author,
            .PublishDate = csv.PubDate,
            .ID = csv.ID,
            .Title = csv.Title
        }).ToList()

    End Function

    Public Overrides Sub SaveData(data As List(Of Book))
        _engine.WriteFile(fileName, data.Select(Function(b) New CsvBook With
        {
            .Author = b.Author,
            .PubDate = b.PublishDate,
            .ID = b.ID.Value,
            .Title = b.Title
        }))
    End Sub

End Class

Public Class DummyBookRepository
    Inherits BookRepositoryBase

    Public Overrides Function LoadData() As List(Of Book)
        Return New List(Of Book) From
        {
            New Book With
            {
                .ID = 1,
                .Author = "Bernard Cornwell",
                .Title = "Das brennende Land",
                .PublishDate = #05/19/2010#
            },
            New Book With
            {
                .ID = 2,
                .Author = "Bernard Cornwell",
                .Title = "Der leere Thron",
                .PublishDate = #06/01/2015#
            }
        }
    End Function

    Public Overrides Sub SaveData(data As List(Of Book))

    End Sub

End Class
