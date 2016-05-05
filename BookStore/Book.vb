Imports FileHelpers

Namespace Models

    Public Class Book

        Public Property Title As String

        Public Property Author As String

        Public Property PublishDate As Date

        Public Property ID As Long?

        Public Function Copy() As Book

            Return New Book With
            {
                .Title = Title,
                .Author = Author,
                .PublishDate = PublishDate,
                .ID = Nothing
            }

        End Function

    End Class

End Namespace