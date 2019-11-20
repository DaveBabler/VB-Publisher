Public Class SQLCalls
    'Parameterized queries to access is below:
    'https://stackoverflow.com/questions/16759516/sql-injection-prevention-with-microsoft-access-and-vb-net/16760887
    'will probably need to create variables for colums and datatypes

    Protected Const OLE_DB_CON_PUBLISHERS As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\dabab\OneDrive\HCC Current\COP-1332-27779 Visual Basic Beginning\Assignements\10 - Publisher\Contacts.mdb"""

    Public Shared Function BuildUnSecureSQLString(ByVal intKeyValue As Integer, ByVal strTable As String, ByRef strColumnList As String(), strKeyColName As String) As String
        Dim strSelectedColumns As String = ""
        Dim strSQLOut As String = ""
        Dim strSelect As String = "SELECT "
        Dim intLastCol As Integer = strColumnList.Count - 1
        Dim strFrom As String = "FROM " & strTable
        Dim strWhere As String = "WHERE " & strKeyColName & " = " & intKeyValue.ToString()



        For i = 0 To strColumnList.Count - 1
            'WARNING!!!! WE MAY NEED TO ADD BRACKETS AROUND EACH COLUMN NAME
            If i = intLastCol Then
                'No comma at the very end of the list
                strSelectedColumns = strSelectedColumns & strColumnList(i) & " "
            Else
                strSelectedColumns = strSelectedColumns & strColumnList(i) & ", "
            End If

        Next i
        strSelect = strSelect & strSelectedColumns

        strSQLOut = strSelect & Environment.NewLine _
            & strFrom & Environment.NewLine _
            & strWhere
        Return strSQLOut
    End Function


    Public Shared Sub QuickTest(ByVal intKeyID As Integer)
        Dim strSQL As String = "SELECT * FROM Publishers WHERE PubID = " & intKeyID.ToString()
        Dim odaPubs As New OleDb.OleDbDataAdapter(strSQL, OLE_DB_CON_PUBLISHERS)
        Dim datRow As New DataTable
        odaPubs.Fill(datRow)

        odaPubs.Dispose()

        For Each col In GlobalClass.dbstrPublisher_Columns
            Console.WriteLine(datRow.Rows(0)(col).ToString())
        Next



    End Sub

End Class
