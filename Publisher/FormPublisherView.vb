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

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        'This is for testing and will be removed
        Dim testSQL = SQLCalls.BuildUnSecureSQLString(1, "Publishers", GlobalClass.dbstrPublisher_Columns, "PubID")
        Console.WriteLine(testSQL)
        SQLCalls.QuickTest(1)
    End Sub

    Private Sub FormPublisherDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This will be where a try/catch block will go to catch data 

    End Sub
End Class
