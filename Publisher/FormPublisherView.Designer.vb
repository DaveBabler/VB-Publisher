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
        Me.lblPublisherID.Location = New System.Drawing.Point(33, 38)
        Me.lblPublisherID.Name = "lblPublisherID"
        Me.lblPublisherID.Size = New System.Drawing.Size(116, 22)
        Me.lblPublisherID.TabIndex = 0
        Me.lblPublisherID.Text = "Publisher ID:"
        '
        'lblPublisherName
        '
        Me.lblPublisherName.AutoSize = True
        Me.lblPublisherName.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherName.Location = New System.Drawing.Point(33, 78)
        Me.lblPublisherName.Name = "lblPublisherName"
        Me.lblPublisherName.Size = New System.Drawing.Size(146, 22)
        Me.lblPublisherName.TabIndex = 1
        Me.lblPublisherName.Text = "Publisher Name:"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCompanyName.Location = New System.Drawing.Point(33, 118)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(144, 22)
        Me.lblCompanyName.TabIndex = 2
        Me.lblCompanyName.Text = "Company Name:"
        '
        'lblPublisherAddress
        '
        Me.lblPublisherAddress.AutoSize = True
        Me.lblPublisherAddress.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherAddress.Location = New System.Drawing.Point(33, 158)
        Me.lblPublisherAddress.Name = "lblPublisherAddress"
        Me.lblPublisherAddress.Size = New System.Drawing.Size(80, 22)
        Me.lblPublisherAddress.TabIndex = 3
        Me.lblPublisherAddress.Text = "Address:"
        '
        'lblPublisherCity
        '
        Me.lblPublisherCity.AutoSize = True
        Me.lblPublisherCity.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherCity.Location = New System.Drawing.Point(33, 198)
        Me.lblPublisherCity.Name = "lblPublisherCity"
        Me.lblPublisherCity.Size = New System.Drawing.Size(51, 22)
        Me.lblPublisherCity.TabIndex = 4
        Me.lblPublisherCity.Text = "City: "
        '
        'lblPublisherState
        '
        Me.lblPublisherState.AutoSize = True
        Me.lblPublisherState.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherState.Location = New System.Drawing.Point(33, 238)
        Me.lblPublisherState.Name = "lblPublisherState"
        Me.lblPublisherState.Size = New System.Drawing.Size(59, 22)
        Me.lblPublisherState.TabIndex = 5
        Me.lblPublisherState.Text = "State: "
        '
        'lblPublisherZip
        '
        Me.lblPublisherZip.AutoSize = True
        Me.lblPublisherZip.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherZip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherZip.Location = New System.Drawing.Point(33, 278)
        Me.lblPublisherZip.Name = "lblPublisherZip"
        Me.lblPublisherZip.Size = New System.Drawing.Size(42, 22)
        Me.lblPublisherZip.TabIndex = 6
        Me.lblPublisherZip.Text = "Zip:"
        '
        'lblPublisherPhone
        '
        Me.lblPublisherPhone.AutoSize = True
        Me.lblPublisherPhone.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherPhone.Location = New System.Drawing.Point(33, 318)
        Me.lblPublisherPhone.Name = "lblPublisherPhone"
        Me.lblPublisherPhone.Size = New System.Drawing.Size(137, 22)
        Me.lblPublisherPhone.TabIndex = 7
        Me.lblPublisherPhone.Text = "Phone Number:"
        '
        'lblPublisherFax
        '
        Me.lblPublisherFax.AutoSize = True
        Me.lblPublisherFax.Font = New System.Drawing.Font("Noto Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPublisherFax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPublisherFax.Location = New System.Drawing.Point(33, 358)
        Me.lblPublisherFax.Name = "lblPublisherFax"
        Me.lblPublisherFax.Size = New System.Drawing.Size(115, 22)
        Me.lblPublisherFax.TabIndex = 8
        Me.lblPublisherFax.Text = "Fax Number:"
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
End Class
