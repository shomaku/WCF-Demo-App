Imports System.Text
Imports Newtonsoft.Json

Public Class JsonService
    Implements IJsonService

    Public Function UploadJson(ByVal bytes As Byte()) As String Implements IJsonService.UploadJson
        If bytes Is Nothing OrElse bytes.Length < 1 Then Return Nothing
        Dim data = ParseJson(bytes)
        Return data.User.Name
    End Function

    Private Function ParseJson(ByVal bytes As Byte()) As JsonData
        Dim json = Encoding.UTF8.GetString(bytes)
        Return JsonConvert.DeserializeObject(Of JsonData)(json)
    End Function
End Class
