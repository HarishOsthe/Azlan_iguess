Imports System.Data.OleDb

Module Module1
    Public conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\iguess.accdb;Persist Security Info=True;Jet OLEDB:Database Password=admin")
    Public q1, q2, q3 As String
End Module
