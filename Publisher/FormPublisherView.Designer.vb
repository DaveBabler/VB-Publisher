<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPublisherDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnuPublisherViewer = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelectPublisher = New System.Windows.Forms.Label()
        Me.cboPublisher = New System.Windows.Forms.ComboBox()
        Me.grpPublisherInfo = New System.Windows.Forms.GroupBox()
        Me.lblPublisherID = New System.Windows.Forms.Label()
        Me.lblPublisherName = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblPublisherAddress = New System.Windows.Forms.Label()
        Me.lblPublisherCity = New System.Windows.Forms.Label()
        Me.lblPublisherState = New System.Windows.Forms.Label()
        Me.lblPublisherZip = New System.Windows.Forms.Label()
        Me.lblPublisherPhone = New System.Windows.Forms.Label()
        Me.lblPublisherFax = New System.Windows.Forms.Label()
        Me.lblPublisherFaxOut = New System.Windows.Forms.Label()
        Me.lblPublisherPhoneOut = New System.Windows.Forms.Label()
        Me.lblPublisherZipOut = New System.Windows.Forms.Label()
        Me.lblPublisherStateOut = New System.Windows.Forms.Label()
        Me.lblPublisherCityOut = New System.Windows.Forms.Label()
        Me.lblPublisherAddressOut = New System.Windows.Forms.Label()
        Me.lblCompanyNameOut = New System.Windows.Forms.Label()
        Me.lblPublisherNameOut = New System.Windows.Forms.Label()
        Me.lblPublisherIDOut = New System.Windows.Forms.Label()
        Me.mnuPublisherViewer.SuspendLayout()
        Me.grpPublisherInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuPublisherViewer
        '
        Me.mnuPublisherViewer.BackColor = System.Drawing.Color.Gainsboro
        Me.mnuPublisherViewer.Font = New System.Drawing.Font("Noto Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.mnuPublisherViewer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuPublisherViewer.Location = New System.Drawing.Point(0, 0)
        Me.mnuPublisherViewer.Name = "mnuPublisherViewer"
        Me.mnuPublisherViewer.Size = New System.Drawing.Size(816, 26)
        Me.mnuPublisherViewer.TabIndex = 0
        Me.mnuPublisherViewer.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(51, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'lblSelectPublisher
        '
        Me.lblSelectPublisher.AutoSize = True
        Me.lblSelectPublisher.Font = New System.Drawing.Font("Noto Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblSelectPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSelectPublisher.Location = New System.Drawing.Point(65, 50)
        Me.lblSelectPublisher.Name = "lblSelectPublisher"
        Me.lblSelectPublisher.Size = New System.Drawing.Size(252, 26)
        Me.lblSelectPublisher.TabIndex = 1
        Me.lblSelectPublisher.Text = "Select Publisher to View:"
        '
        'cboPublisher
        '
        Me.cboPublisher.BackColor = System.Drawing.Color.DarkGray
        Me.cboPublisher.Font = New System.Drawing.Font("Noto Serif Cond", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cboPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cboPublisher.FormattingEnabled = True
        Me.cboPublisher.Location = New System.Drawing.Point(359, 46)
        Me.cboPublisher.Name = "cboPublisher"
        Me.cboPublisher.Size = New System.Drawing.Size(392, 34)
        Me.cboPublisher.TabIndex = 2
        '
        'grpPublisherInfo
        '
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherFaxOut)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherPhoneOut)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherZipOut)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherStateOut)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherCityOut)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherAddressOut)
        Me.grpPublisherInfo.Controls.Add(Me.lblCompanyNameOut)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherNameOut)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherIDOut)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherFax)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherPhone)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherZip)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherState)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherCity)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherAddress)
        Me.grpPublisherInfo.Controls.Add(Me.lblCompanyName)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherName)
        Me.grpPublisherInfo.Controls.Add(Me.lblPublisherID)
        Me.grpPublisherInfo.Font = New System.Drawing.Font("Noto Serif Light", 9.749999!)
        Me.grpPublisherInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grpPublisherInfo.Location = New System.Drawing.Point(64, 108)
        Me.grpPublisherInfo.Name = "grpPublisherInfo"
        Me.grpPublisherInfo.Size = New System.Drawing.Size(689, 402)
        Me.grpPublisherInfo.TabIndex = 3
        Me.grpPublisherInfo.TabStop = False
        Me.grpPublisherInfo.Text = "Publisher Information"
        '
        'lblPublisherID
        '
        Me.lblPublisherID.AutoSize = True
        Me.lblPublisherID.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherID.Location = New System.Drawing.Point(65, 38)
        Me.lblPublisherID.Name = "lblPublisherID"
        Me.lblPublisherID.Size = New System.Drawing.Size(116, 22)
        Me.lblPublisherID.TabIndex = 0
        Me.lblPublisherID.Text = "Publisher ID:"
        Me.lblPublisherID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPublisherName
        '
        Me.lblPublisherName.AutoSize = True
        Me.lblPublisherName.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherName.Location = New System.Drawing.Point(35, 78)
        Me.lblPublisherName.Name = "lblPublisherName"
        Me.lblPublisherName.Size = New System.Drawing.Size(146, 22)
        Me.lblPublisherName.TabIndex = 1
        Me.lblPublisherName.Text = "Publisher Name:"
        Me.lblPublisherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCompanyName.Location = New System.Drawing.Point(37, 118)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(144, 22)
        Me.lblCompanyName.TabIndex = 2
        Me.lblCompanyName.Text = "Company Name:"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPublisherAddress
        '
        Me.lblPublisherAddress.AutoSize = True
        Me.lblPublisherAddress.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherAddress.Location = New System.Drawing.Point(101, 158)
        Me.lblPublisherAddress.Name = "lblPublisherAddress"
        Me.lblPublisherAddress.Size = New System.Drawing.Size(80, 22)
        Me.lblPublisherAddress.TabIndex = 3
        Me.lblPublisherAddress.Text = "Address:"
        Me.lblPublisherAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPublisherCity
        '
        Me.lblPublisherCity.AutoSize = True
        Me.lblPublisherCity.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherCity.Location = New System.Drawing.Point(130, 198)
        Me.lblPublisherCity.Name = "lblPublisherCity"
        Me.lblPublisherCity.Size = New System.Drawing.Size(51, 22)
        Me.lblPublisherCity.TabIndex = 4
        Me.lblPublisherCity.Text = "City: "
        Me.lblPublisherCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPublisherState
        '
        Me.lblPublisherState.AutoSize = True
        Me.lblPublisherState.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherState.Location = New System.Drawing.Point(122, 238)
        Me.lblPublisherState.Name = "lblPublisherState"
        Me.lblPublisherState.Size = New System.Drawing.Size(59, 22)
        Me.lblPublisherState.TabIndex = 5
        Me.lblPublisherState.Text = "State: "
        Me.lblPublisherState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPublisherZip
        '
        Me.lblPublisherZip.AutoSize = True
        Me.lblPublisherZip.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherZip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherZip.Location = New System.Drawing.Point(139, 278)
        Me.lblPublisherZip.Name = "lblPublisherZip"
        Me.lblPublisherZip.Size = New System.Drawing.Size(42, 22)
        Me.lblPublisherZip.TabIndex = 6
        Me.lblPublisherZip.Text = "Zip:"
        Me.lblPublisherZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPublisherPhone
        '
        Me.lblPublisherPhone.AutoSize = True
        Me.lblPublisherPhone.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherPhone.Location = New System.Drawing.Point(44, 318)
        Me.lblPublisherPhone.Name = "lblPublisherPhone"
        Me.lblPublisherPhone.Size = New System.Drawing.Size(137, 22)
        Me.lblPublisherPhone.TabIndex = 7
        Me.lblPublisherPhone.Text = "Phone Number:"
        Me.lblPublisherPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPublisherFax
        '
        Me.lblPublisherFax.AutoSize = True
        Me.lblPublisherFax.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherFax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherFax.Location = New System.Drawing.Point(66, 358)
        Me.lblPublisherFax.Name = "lblPublisherFax"
        Me.lblPublisherFax.Size = New System.Drawing.Size(115, 22)
        Me.lblPublisherFax.TabIndex = 8
        Me.lblPublisherFax.Text = "Fax Number:"
        Me.lblPublisherFax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPublisherFaxOut
        '
        Me.lblPublisherFaxOut.AutoSize = True
        Me.lblPublisherFaxOut.Font = New System.Drawing.Font("Noto Serif Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherFaxOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherFaxOut.Location = New System.Drawing.Point(193, 358)
        Me.lblPublisherFaxOut.Name = "lblPublisherFaxOut"
        Me.lblPublisherFaxOut.Size = New System.Drawing.Size(98, 22)
        Me.lblPublisherFaxOut.TabIndex = 17
        Me.lblPublisherFaxOut.Text = "123-456-7890"
        Me.lblPublisherFaxOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublisherPhoneOut
        '
        Me.lblPublisherPhoneOut.AutoSize = True
        Me.lblPublisherPhoneOut.Font = New System.Drawing.Font("Noto Serif Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherPhoneOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherPhoneOut.Location = New System.Drawing.Point(193, 318)
        Me.lblPublisherPhoneOut.Name = "lblPublisherPhoneOut"
        Me.lblPublisherPhoneOut.Size = New System.Drawing.Size(98, 22)
        Me.lblPublisherPhoneOut.TabIndex = 16
        Me.lblPublisherPhoneOut.Text = "123-456-7890"
        Me.lblPublisherPhoneOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublisherZipOut
        '
        Me.lblPublisherZipOut.AutoSize = True
        Me.lblPublisherZipOut.Font = New System.Drawing.Font("Noto Serif Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherZipOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherZipOut.Location = New System.Drawing.Point(193, 278)
        Me.lblPublisherZipOut.Name = "lblPublisherZipOut"
        Me.lblPublisherZipOut.Size = New System.Drawing.Size(86, 22)
        Me.lblPublisherZipOut.TabIndex = 15
        Me.lblPublisherZipOut.Text = "12345-1234"
        Me.lblPublisherZipOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublisherStateOut
        '
        Me.lblPublisherStateOut.AutoSize = True
        Me.lblPublisherStateOut.Font = New System.Drawing.Font("Noto Serif Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherStateOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherStateOut.Location = New System.Drawing.Point(193, 238)
        Me.lblPublisherStateOut.Name = "lblPublisherStateOut"
        Me.lblPublisherStateOut.Size = New System.Drawing.Size(30, 22)
        Me.lblPublisherStateOut.TabIndex = 14
        Me.lblPublisherStateOut.Text = "XX"
        Me.lblPublisherStateOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublisherCityOut
        '
        Me.lblPublisherCityOut.AutoSize = True
        Me.lblPublisherCityOut.Font = New System.Drawing.Font("Noto Serif Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherCityOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherCityOut.Location = New System.Drawing.Point(193, 198)
        Me.lblPublisherCityOut.Name = "lblPublisherCityOut"
        Me.lblPublisherCityOut.Size = New System.Drawing.Size(118, 22)
        Me.lblPublisherCityOut.TabIndex = 13
        Me.lblPublisherCityOut.Text = "Probably a City"
        Me.lblPublisherCityOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublisherAddressOut
        '
        Me.lblPublisherAddressOut.AutoSize = True
        Me.lblPublisherAddressOut.Font = New System.Drawing.Font("Noto Serif Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherAddressOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherAddressOut.Location = New System.Drawing.Point(193, 158)
        Me.lblPublisherAddressOut.Name = "lblPublisherAddressOut"
        Me.lblPublisherAddressOut.Size = New System.Drawing.Size(194, 22)
        Me.lblPublisherAddressOut.TabIndex = 12
        Me.lblPublisherAddressOut.Text = "12345 SomeStreet Ave #45"
        Me.lblPublisherAddressOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCompanyNameOut
        '
        Me.lblCompanyNameOut.AutoSize = True
        Me.lblCompanyNameOut.Font = New System.Drawing.Font("Noto Serif Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompanyNameOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCompanyNameOut.Location = New System.Drawing.Point(193, 118)
        Me.lblCompanyNameOut.Name = "lblCompanyNameOut"
        Me.lblCompanyNameOut.Size = New System.Drawing.Size(94, 22)
        Me.lblCompanyNameOut.TabIndex = 11
        Me.lblCompanyNameOut.Text = "Some Name"
        Me.lblCompanyNameOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublisherNameOut
        '
        Me.lblPublisherNameOut.AutoSize = True
        Me.lblPublisherNameOut.Font = New System.Drawing.Font("Noto Serif Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherNameOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherNameOut.Location = New System.Drawing.Point(193, 78)
        Me.lblPublisherNameOut.Name = "lblPublisherNameOut"
        Me.lblPublisherNameOut.Size = New System.Drawing.Size(204, 22)
        Me.lblPublisherNameOut.TabIndex = 10
        Me.lblPublisherNameOut.Text = "A Publisher, one presumes."
        Me.lblPublisherNameOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublisherIDOut
        '
        Me.lblPublisherIDOut.AutoSize = True
        Me.lblPublisherIDOut.Font = New System.Drawing.Font("Noto Serif Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherIDOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherIDOut.Location = New System.Drawing.Point(193, 38)
        Me.lblPublisherIDOut.Name = "lblPublisherIDOut"
        Me.lblPublisherIDOut.Size = New System.Drawing.Size(90, 22)
        Me.lblPublisherIDOut.TabIndex = 9
        Me.lblPublisherIDOut.Text = "8888888888"
        Me.lblPublisherIDOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormPublisherDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(816, 566)
        Me.Controls.Add(Me.grpPublisherInfo)
        Me.Controls.Add(Me.cboPublisher)
        Me.Controls.Add(Me.lblSelectPublisher)
        Me.Controls.Add(Me.mnuPublisherViewer)
        Me.Font = New System.Drawing.Font("Noto Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainMenuStrip = Me.mnuPublisherViewer
        Me.Name = "FormPublisherDisplay"
        Me.Text = "Publisher Viewer"
        Me.mnuPublisherViewer.ResumeLayout(False)
        Me.mnuPublisherViewer.PerformLayout()
        Me.grpPublisherInfo.ResumeLayout(False)
        Me.grpPublisherInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuPublisherViewer As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSelectPublisher As Label
    Friend WithEvents cboPublisher As ComboBox
    Friend WithEvents grpPublisherInfo As GroupBox
    Friend WithEvents lblPublisherID As Label
    Friend WithEvents lblPublisherCity As Label
    Friend WithEvents lblPublisherAddress As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblPublisherName As Label
    Friend WithEvents lblPublisherState As Label
    Friend WithEvents lblPublisherFax As Label
    Friend WithEvents lblPublisherPhone As Label
    Friend WithEvents lblPublisherZip As Label
    Friend WithEvents lblPublisherFaxOut As Label
    Friend WithEvents lblPublisherPhoneOut As Label
    Friend WithEvents lblPublisherZipOut As Label
    Friend WithEvents lblPublisherStateOut As Label
    Friend WithEvents lblPublisherCityOut As Label
    Friend WithEvents lblPublisherAddressOut As Label
    Friend WithEvents lblCompanyNameOut As Label
    Friend WithEvents lblPublisherNameOut As Label
    Friend WithEvents lblPublisherIDOut As Label
End Class
