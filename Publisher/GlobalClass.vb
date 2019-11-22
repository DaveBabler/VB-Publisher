Public Class GlobalClass
    'Prepared statements to microsoft access: https://stackoverflow.com/questions/6572448/ms-access-prepared-statements
    'get set methods for properties https://www.tutlane.com/tutorial/visual-basic/vb-properties-get-set
    'selecting values from a datatable https://forums.asp.net/t/1208106.aspx?Selecting+columns+from+a+datatable+for+a+dataview+
    Public Const OLE_DB_CON_PUBLISHERS As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\dabab\OneDrive\HCC Current\COP-1332-27779 Visual Basic Beginning\Assignements\10 - Publisher\Contacts.mdb"""
    Public Shared dbstrPublisher_Columns As String() = {"PubID", "Name", "Company Name", "Address", "City", "State", "Zip", "Telephone", "Fax"}
    Public Shared dicSpecialFixer As New Dictionary(Of String, String)

    Public Shared Sub GetLabelList(ByVal Parent As Control)
        For Each Child As Control In Parent.Controls
            If TypeOf Child Is Label Then
                MessageBox.Show(Child.Text)
            End If
            If Child.Controls.Count > 0 Then
                GetLabelList(Child)
            End If
        Next Child
    End Sub


    Public Shared Sub ChangeLabelByName(ByVal Parent As Control, ByVal strLabelSuffix As String, ByVal strSearchLabelName As String, ByVal strIncomingValue As String)
        'Recursively grabs all controls on a form
        'If the control is a label it checks the naming conventions to see if it matches a lookup
        'If so, it changes the text of that label.
        For Each Child As Control In Parent.Controls
            If TypeOf Child Is Label Then
                If Child.Name.Contains(strLabelSuffix) AndAlso Child.Name.Contains(strSearchLabelName) Then
                    Child.Text = strIncomingValue
                    'Console.WriteLine(Child.Name.ToString())
                    'Console.WriteLine("_________________________")
                    Exit For
                End If
            End If
            If Child.Controls.Count > 0 Then
                ChangeLabelByName(Child, strLabelSuffix, strSearchLabelName, strIncomingValue)
            End If
        Next Child

    End Sub



    Public Shared Sub ChangeLabelByName(ByVal Parent As Control, ByVal strLabelSuffix As String, ByVal strSearchLabelName As String, ByVal strIncomingValue As String, ByVal dicSpecialNameFixer As Dictionary(Of String, String))
        'Recursively grabs all controls on a form
        'If the control is a label it checks the naming conventions to see if it matches a lookup
        'If so, it changes the text of that label.
        '____________________ special circumstances involve a name in the database attributes not quite matching up to a label correctly
        '____________________ if these cannot be rectified with a simple removal of a space then this will be fixed here by marrying 
        '____________________ a dictionary of helpers

        If dicSpecialFixer.ContainsKey(strSearchLabelName) Then
            'Console.WriteLine("This key {0} & This value {1}", strSearchLabelName, dicSpecialFixer.Item(strSearchLabelName))
            strSearchLabelName = dicSpecialFixer.Item(strSearchLabelName)
        End If

        For Each Child As Control In Parent.Controls
                If TypeOf Child Is Label Then
                    If Child.Name.Contains(strLabelSuffix) AndAlso Child.Name.Contains(strSearchLabelName) Then
                        Child.Text = strIncomingValue
                        'Console.WriteLine(Child.Name.ToString())
                        'Console.WriteLine("_________________________")
                        Exit For
                    End If
                End If
                If Child.Controls.Count > 0 Then
                    ChangeLabelByName(Child, strLabelSuffix, strSearchLabelName, strIncomingValue)
                End If
            Next Child

    End Sub
    Public Shared Sub PopulateComboBox(ByVal datFromDb As DataTable, ByRef cboBoxToPopulate As ComboBox, strAttributeKey As String, strAttributeDisplay As String)
        'Clears then populates a combo box!
        cboBoxToPopulate.Text = ""
        cboBoxToPopulate.Items.Clear()

        For i = 0 To datFromDb.Rows.Count

            cboBoxToPopulate.ValueMember = strAttributeKey
            cboBoxToPopulate.DisplayMember = strAttributeDisplay
        Next i


    End Sub



End Class
