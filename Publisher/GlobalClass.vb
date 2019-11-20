Public Class GlobalClass
    'Prepared statements to microsoft access: https://stackoverflow.com/questions/6572448/ms-access-prepared-statements
    'get set methods for properties https://www.tutlane.com/tutorial/visual-basic/vb-properties-get-set
    'selecting values from a datatable https://forums.asp.net/t/1208106.aspx?Selecting+columns+from+a+datatable+for+a+dataview+
    Public Const OLE_DB_CON_PUBLISHERS As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\dabab\OneDrive\HCC Current\COP-1332-27779 Visual Basic Beginning\Assignements\10 - Publisher\Contacts.mdb"""
    Public Shared dbstrPublisher_Columns As String() = {"PubID", "Name", "Company Name", "Address", "City", "State", "Zip", "Telephone", "Fax"}

End Class
