Public Class SQLCalls
    'Parameterized queries to access is below:
    'https://stackoverflow.com/questions/16759516/sql-injection-prevention-with-microsoft-access-and-vb-net/16760887
    'https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlparametercollection.addwithvalue?view=netframework-4.8
    'https://www.codeguru.com/columns/vb/using-parameterized-queries-and-reports-in-vb.net-database-applications.htm

    'will probably need to create variables for colums and datatypes

    Protected Const OLE_DB_CON_PUBLISHERS As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\dabab\OneDrive\HCC Current\COP-1332-27779 Visual Basic Beginning\Assignements\10 - Publisher\Contacts.mdb"""

    Public Shared Function BuildUnSecureSQLString(ByVal intKeyValue As Integer, ByVal strTable As String, ByRef strColumnList As String(), strKeyColName As String) As String
        Dim strSelectedColumns As String = ""
        Dim strSQLOut As String = ""
        Dim strSelect As String = "SELECT "
        Dim intLastCol As Integer = strColumnList.Count - 1
        Dim strFrom As String = "FROM " & strTable
        Dim strWhere As String = "WHERE " & SQLCalls.AddBrackets(strKeyColName) & " = " & intKeyValue.ToString()



        For i = 0 To strColumnList.Count - 1
            'WARNING!!!! column names must be in brackets if there are spaces   
            If i = intLastCol Then
                'No comma at the very end of the list
                strSelectedColumns = strSelectedColumns & SQLCalls.AddBrackets(strColumnList(i)) & " "
            Else
                strSelectedColumns = strSelectedColumns & SQLCalls.AddBrackets(strColumnList(i)) & ", "
            End If

        Next i
        strSelect = strSelect & strSelectedColumns

        strSQLOut = strSelect & Environment.NewLine _
            & strFrom & Environment.NewLine _
            & strWhere
        Return strSQLOut
    End Function


    Public Shared Function ParamaterizedSQLCall(ByVal intKeyValue As Integer, ByVal strTable As String, ByRef strColumnList As String(), strKeyColName As String) As String
        Dim strSelectedColumns As String = ""
        Dim strSQLOut As String = ""
        Dim strSelect As String = "SELECT "
        Dim intLastCol As Integer = strColumnList.Count - 1
        Dim strFrom As String = "FROM " & strTable
        Dim strWhere As String = "WHERE " & SQLCalls.AddBrackets(strKeyColName) & " = " & intKeyValue.ToString()



        For i = 0 To strColumnList.Count - 1
            'WARNING!!!! column names must be in brackets if there are spaces   
            If i = intLastCol Then
                'No comma at the very end of the list
                strSelectedColumns = strSelectedColumns & SQLCalls.AddBrackets(strColumnList(i)) & " "
            Else
                strSelectedColumns = strSelectedColumns & SQLCalls.AddBrackets(strColumnList(i)) & ", "
            End If

        Next i
        strSelect = strSelect & strSelectedColumns

        strSQLOut = strSelect & Environment.NewLine _
            & strFrom & Environment.NewLine _
            & strWhere
        Return strSQLOut
    End Function



    Public Shared Sub QuickTest(ByVal intKeyID As Integer, strSQL As String)
        'Dim strSQL As String = "SELECT * FROM Publishers WHERE PubID = " & intKeyID.ToString()
        Dim odaPubs As New OleDb.OleDbDataAdapter(strSQL, OLE_DB_CON_PUBLISHERS)
        Dim datRow As New DataTable
        odaPubs.Fill(datRow)

        odaPubs.Dispose()

        For Each col In GlobalClass.dbstrPublisher_Columns
            Console.WriteLine(datRow.Rows(0)(col).ToString())
        Next



    End Sub
    Public Shared Function AddBrackets(strIncString As String) As String
        Dim strWithBrackets As String
        strWithBrackets = "[" & strIncString & "]"
        Return strWithBrackets

    End Function

End Class
