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

        cboPublisher.DataSource = dv
        cboPublisher.DisplayMember = "Name"
        cboPublisher.ValueMember = "PubID"

        'This shows the data from the data set
        For Each thisTable In Me.ContactsDataSet.Tables
            ' For each row, print the values of each column.
            Dim row As DataRow
            For Each row In thisTable.Rows
                Dim column As DataColumn
                For Each column In thisTable.Columns
                    Console.WriteLine(row(column))
                Next column
            Next row
        Next thisTable
    End Sub
End Class
