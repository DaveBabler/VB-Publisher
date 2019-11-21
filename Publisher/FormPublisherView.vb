' Program:                Publisher 
' Author:                 Dave Babler
' Date:                   2019-11-18
' Purpose:                Produces a summary report showing total revuneu, number of charters, and average hours per charter based on user input
' Colors used:            #ff00cc|rgb(255, 0, 204)  ~  #5a0048|rgb(90, 0, 72) (Darker shade ff0cc)
'                         #00ccff|rgb(0, 204, 255)
'                         #ccff00|rgb(204, 255, 0)
'                         End split complementary color scheme
'                         Standard Windows colors: Black, Gainsboro
' Assignment Paramaters:  Write a project to display the Publishers table from the Contacts.mdf database from the provided Student Datafiles (in assignment dropbox). 
'                         The Publishers table has the following fields: PubID (key), Name, Company Name, Address, City, State, Zip, Tele, Fax. 
'                         Allow the user To Select the publisher name from a sorted drop-down list; display the rest Of the fields In labels.

Public Class FormPublisherDisplay
    Friend datComboBox As DataTable
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        'This is for testing and will be removed
        Dim testSQL = SQLCalls.BuildUnSecureSQLString(1, "Publishers", GlobalClass.dbstrPublisher_Columns, "PubID")
        Dim testParamater = SQLCalls.ParamaterizedSQLCall("Publishers", GlobalClass.dbstrPublisher_Columns, "PubID")

        Console.WriteLine(testSQL)
        SQLCalls.QuickTest(1, testSQL)
        Console.WriteLine("_____________________________")
        SQLCalls.MSAccessParamaterizedSelect(testParamater, 1)
    End Sub

    Private Sub FormPublisherDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This will be where a try/catch block will go to catch data 
        'Hey the try catch is in a sub!
        SQLCalls.TestConnection()
        'Get a datatable 
        ' datComboBox = SQLCalls.DataTableForComboBox(SQLCalls.SELECT_FOR_CBO)
        'fill the combo box
        '  GlobalClass.PopulateComboBox(datComboBox, cboPublisher, "PubID", "Name")


        Dim adapter As New OleDb.OleDbDataAdapter(SQLCalls.SELECT_FOR_CBO, GlobalClass.OLE_DB_CON_PUBLISHERS)
        Dim tb As New DataTable()
        adapter.Fill(tb)
        cboPublisher.DataSource = tb
        cboPublisher.ValueMember = "PubID"
        cboPublisher.DisplayMember = "Name"
        adapter.Dispose()
        cboPublisher.SelectedIndex = 0


    End Sub

    Private Sub lblCompanyNameOut_Click(sender As Object, e As EventArgs) Handles lblCompanyNameOut.Click

    End Sub

    Private Sub cboPublisher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPublisher.SelectedIndexChanged
        Dim intMyInteger As Integer
        If TypeOf cboPublisher.SelectedValue Is Integer Then
            intMyInteger = DirectCast(cboPublisher.SelectedValue, Integer)
        End If



        Console.WriteLine("ProgramID: " & DirectCast(cboPublisher.SelectedItem, System.Data.DataRowView).Row.ItemArray(0).ToString())
        Dim intCurrentIndex As Integer = intMyInteger
        Dim strKeyCol As String = "PubID"
        Dim strSQLSelect As String

        strSQLSelect = SQLCalls.ParamaterizedSQLCall("Publishers", GlobalClass.dbstrPublisher_Columns, strKeyCol)
        SQLCalls.MSAccessParamaterizedSelect(strSQLSelect, intCurrentIndex)
    End Sub
End Class
'http://1bestcsharp.blogspot.com/2017/11/vb.net-display-mysql-data-depending-on-combobox-value.html
