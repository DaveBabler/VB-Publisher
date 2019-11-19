' Program:                Yachts 
' Author:                 Dave Babler
' Date:                   2019-1118
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
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub PublishersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PublishersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ContactsDataSet)

    End Sub

    Private Sub FormPublisherDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ContactsDataSet.Publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.ContactsDataSet.Publishers)
        Console.WriteLine(Me.ContactsDataSet.Tables.ToString)
        Dim dv As DataView = ContactsDataSet.Tables("Publishers").DefaultView

        Dim pubs As DataTable = ContactsDataSet.Tables("Publisher")




        cboPublisher.DataSource = dv
        cboPublisher.DisplayMember = "Name"
        cboPublisher.ValueMember = "PubID"


        'This shows the data from the data set
        'For Each thisTable In Me.ContactsDataSet.Tables

        '    ' For each row, print the values of each column.
        '    Dim row As DataRow
        '    For Each row In thisTable.Rows
        '        Dim column As DataColumn

        '        For Each column In thisTable.Columns

        '            Console.WriteLine(row(column))
        '        Next column
        '    Next row
        'Next thisTable

        Dim dt As New DataTable()
        'create the datatable
        dt.Columns.Add(New DataColumn("Country"))
        dt.Columns.Add(New DataColumn("City"))
        dt.Columns.Add(New DataColumn("Name"))
        'Store first row
        Dim row As DataRow = dt.NewRow()

        row("Country") = "Canada"
        row("City") = "Ontario"
        row("Name") = "Cambridge"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Country") = "United States"
        row("City") = "CA"
        row("Name") = "San Francisco"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Country") = "Canada"
        row("City") = "Ontario"
        row("Name") = "Hamilton"
        dt.Rows.Add(row)
        row = dt.NewRow()
        row("Country") = "Canada"
        row("City") = "Ontario"
        row("Name") = "Milton"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Country") = "United Kingdom"
        row("City") = "Wales"
        row("Name") = "Bangor"
        dt.Rows.Add(row)
        row = dt.NewRow()
        row("Country") = "United Kingdom"
        row("City") = "Wales"
        row("Name") = "Cardiff"
        dt.Rows.Add(row)


        row = dt.NewRow()
        row("Country") = "Canada"
        row("City") = "Ontario"
        row("Name") = "Halton"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Country") = "United Kingdom"
        row("City") = "Wales"
        row("Name") = "Swansea"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Country") = "United States"
        row("City") = "CA"
        row("Name") = "Los Angeles"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Country") = "United States"
        row("City") = "CA"
        row("Name") = "Merced"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Country") = "United States"
        row("City") = "CA"
        row("Name") = "Morgan Hill"
        dt.Rows.Add(row)

        row = dt.NewRow()
        row("Country") = "United Kingdom"
        row("City") = "Wales"
        row("Name") = "New Port"
        dt.Rows.Add(row)

        Dim dj As New DataView()
        dj = dt.DefaultView
        'Adding multiple filter
        'You can change this condition to Or instead of AND
        dj.RowFilter = "City  like '" + "Wa" + "%' AND Country like '" + "Un" + "%'"

        'Retreiving top 2 values 
        'For demo we are fetching only two . you can change this in your final code
        Dim sortedRows As IEnumerable(Of DataRow) = dj.Cast(Of DataRowView)().Take(2).[Select](Function(r) r.Row)

        'Convert that to string array
        'Change the column index as per your need
        Dim rowAsString = String.Join(", ", sortedRows.Select(Function(c) c(0).ToString()).ToArray())
        Console.WriteLine(rowAsString)


        dv.RowFilter = "PubID = 1"

        Dim dvSortRow As IEnumerable(Of DataRow) = dv.Cast(Of DataRowView)().Take(8).[Select](Function(r) r.Row)
        Dim stringerRow = String.Join(", ", dvSortRow.Select(Function(f) f(2).ToString()).ToArray())  'This definately gets a value out 
        Console.WriteLine(stringerRow)

    End Sub
    Private Sub PrintTableOrView(ByVal view As DataView, ByVal label As String)
        Console.WriteLine(label)
        Dim i As Integer
        For i = 0 To view.Count - 1

            Console.WriteLine(view(i)("column"))
        Next
        Console.WriteLine()
    End Sub


    'https://docs.microsoft.com/en-us/dotnet/api/system.data.dataview.totable?redirectedfrom=MSDN&view=netframework-4.8#System_Data_DataView_ToTable_System_Boolean_System_String___
    'https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/filtering-with-dataview-linq-to-dataset
    'https://forums.asp.net/t/2097404.aspx?DataView+filter+and+returning+a+string+array
    'https://stackoverflow.com/questions/19660082/gettin-the-all-the-column-values-of-datagridview-in-vb-net-in-variables-on-enter

End Class
