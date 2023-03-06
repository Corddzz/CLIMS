Imports MySql.Data.MySqlClient
Module connection
    Public cmd As New MySqlCommand
    Public sql As String
    Public result As Integer
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public reportselect As String
    Public reportname As String = ""
    'Public rptname As String = ""
End Module

