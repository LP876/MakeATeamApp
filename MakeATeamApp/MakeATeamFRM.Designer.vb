<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakeATeamFRM
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
        Me.newTeamGBX = New System.Windows.Forms.GroupBox()
        Me.leagueLBL = New System.Windows.Forms.Label()
        Me.leagueCBX = New System.Windows.Forms.ComboBox()
        Me.teamNameTBX = New System.Windows.Forms.TextBox()
        Me.teamNameLBL = New System.Windows.Forms.Label()
        Me.playersGBX = New System.Windows.Forms.GroupBox()
        Me.pos4CBX = New System.Windows.Forms.ComboBox()
        Me.pos3CBX = New System.Windows.Forms.ComboBox()
        Me.pos2CBX = New System.Windows.Forms.ComboBox()
        Me.dob4DTP = New System.Windows.Forms.DateTimePicker()
        Me.dob3DTP = New System.Windows.Forms.DateTimePicker()
        Me.name3TBX = New System.Windows.Forms.TextBox()
        Me.dob2DTP = New System.Windows.Forms.DateTimePicker()
        Me.name2TBX = New System.Windows.Forms.TextBox()
        Me.DOB_LBL = New System.Windows.Forms.Label()
        Me.dob1DTP = New System.Windows.Forms.DateTimePicker()
        Me.pos1CBX = New System.Windows.Forms.ComboBox()
        Me.PositionLBL = New System.Windows.Forms.Label()
        Me.name1TBX = New System.Windows.Forms.TextBox()
        Me.nameLBL = New System.Windows.Forms.Label()
        Me.teamToDisplayLBL = New System.Windows.Forms.Label()
        Me.teamLBX = New System.Windows.Forms.ListBox()
        Me.makeTeamBTN = New System.Windows.Forms.Button()
        Me.outTBX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FileTBX = New System.Windows.Forms.TextBox()
        Me.BrowseBTN = New System.Windows.Forms.Button()
        Me.LoadBTN = New System.Windows.Forms.Button()
        Me.name4TBX = New System.Windows.Forms.TextBox()
        Me.newTeamGBX.SuspendLayout()
        Me.playersGBX.SuspendLayout()
        Me.SuspendLayout()
        '
        'newTeamGBX
        '
        Me.newTeamGBX.Controls.Add(Me.leagueLBL)
        Me.newTeamGBX.Controls.Add(Me.leagueCBX)
        Me.newTeamGBX.Controls.Add(Me.teamNameTBX)
        Me.newTeamGBX.Controls.Add(Me.teamNameLBL)
        Me.newTeamGBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTeamGBX.Location = New System.Drawing.Point(13, 14)
        Me.newTeamGBX.Name = "newTeamGBX"
        Me.newTeamGBX.Size = New System.Drawing.Size(197, 178)
        Me.newTeamGBX.TabIndex = 0
        Me.newTeamGBX.TabStop = False
        Me.newTeamGBX.Text = "New team entry:"
        '
        'leagueLBL
        '
        Me.leagueLBL.AutoSize = True
        Me.leagueLBL.Location = New System.Drawing.Point(7, 98)
        Me.leagueLBL.Name = "leagueLBL"
        Me.leagueLBL.Size = New System.Drawing.Size(102, 20)
        Me.leagueLBL.TabIndex = 3
        Me.leagueLBL.Text = "League level:"
        '
        'leagueCBX
        '
        Me.leagueCBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leagueCBX.FormattingEnabled = True
        Me.leagueCBX.Location = New System.Drawing.Point(10, 124)
        Me.leagueCBX.Name = "leagueCBX"
        Me.leagueCBX.Size = New System.Drawing.Size(165, 28)
        Me.leagueCBX.TabIndex = 2
        '
        'teamNameTBX
        '
        Me.teamNameTBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamNameTBX.Location = New System.Drawing.Point(10, 50)
        Me.teamNameTBX.Name = "teamNameTBX"
        Me.teamNameTBX.Size = New System.Drawing.Size(165, 26)
        Me.teamNameTBX.TabIndex = 1
        '
        'teamNameLBL
        '
        Me.teamNameLBL.AutoSize = True
        Me.teamNameLBL.Location = New System.Drawing.Point(7, 27)
        Me.teamNameLBL.Name = "teamNameLBL"
        Me.teamNameLBL.Size = New System.Drawing.Size(97, 20)
        Me.teamNameLBL.TabIndex = 0
        Me.teamNameLBL.Text = "Team name:"
        '
        'playersGBX
        '
        Me.playersGBX.Controls.Add(Me.name4TBX)
        Me.playersGBX.Controls.Add(Me.pos4CBX)
        Me.playersGBX.Controls.Add(Me.pos3CBX)
        Me.playersGBX.Controls.Add(Me.pos2CBX)
        Me.playersGBX.Controls.Add(Me.dob4DTP)
        Me.playersGBX.Controls.Add(Me.dob3DTP)
        Me.playersGBX.Controls.Add(Me.name3TBX)
        Me.playersGBX.Controls.Add(Me.dob2DTP)
        Me.playersGBX.Controls.Add(Me.name2TBX)
        Me.playersGBX.Controls.Add(Me.DOB_LBL)
        Me.playersGBX.Controls.Add(Me.dob1DTP)
        Me.playersGBX.Controls.Add(Me.pos1CBX)
        Me.playersGBX.Controls.Add(Me.PositionLBL)
        Me.playersGBX.Controls.Add(Me.name1TBX)
        Me.playersGBX.Controls.Add(Me.nameLBL)
        Me.playersGBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playersGBX.Location = New System.Drawing.Point(240, 14)
        Me.playersGBX.Name = "playersGBX"
        Me.playersGBX.Size = New System.Drawing.Size(479, 233)
        Me.playersGBX.TabIndex = 1
        Me.playersGBX.TabStop = False
        Me.playersGBX.Text = "Team members (4 maximum):"
        '
        'pos4CBX
        '
        Me.pos4CBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pos4CBX.FormattingEnabled = True
        Me.pos4CBX.Location = New System.Drawing.Point(191, 187)
        Me.pos4CBX.Name = "pos4CBX"
        Me.pos4CBX.Size = New System.Drawing.Size(121, 28)
        Me.pos4CBX.TabIndex = 17
        '
        'pos3CBX
        '
        Me.pos3CBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pos3CBX.FormattingEnabled = True
        Me.pos3CBX.Location = New System.Drawing.Point(191, 141)
        Me.pos3CBX.Name = "pos3CBX"
        Me.pos3CBX.Size = New System.Drawing.Size(121, 28)
        Me.pos3CBX.TabIndex = 16
        '
        'pos2CBX
        '
        Me.pos2CBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pos2CBX.FormattingEnabled = True
        Me.pos2CBX.Location = New System.Drawing.Point(191, 98)
        Me.pos2CBX.Name = "pos2CBX"
        Me.pos2CBX.Size = New System.Drawing.Size(121, 28)
        Me.pos2CBX.TabIndex = 15
        '
        'dob4DTP
        '
        Me.dob4DTP.CustomFormat = "d/MM/yyyy"
        Me.dob4DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dob4DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob4DTP.Location = New System.Drawing.Point(341, 187)
        Me.dob4DTP.Name = "dob4DTP"
        Me.dob4DTP.Size = New System.Drawing.Size(124, 26)
        Me.dob4DTP.TabIndex = 14
        '
        'dob3DTP
        '
        Me.dob3DTP.CustomFormat = "d/MM/yyyy"
        Me.dob3DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dob3DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob3DTP.Location = New System.Drawing.Point(341, 141)
        Me.dob3DTP.Name = "dob3DTP"
        Me.dob3DTP.Size = New System.Drawing.Size(124, 26)
        Me.dob3DTP.TabIndex = 11
        '
        'name3TBX
        '
        Me.name3TBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.name3TBX.Location = New System.Drawing.Point(20, 141)
        Me.name3TBX.Name = "name3TBX"
        Me.name3TBX.Size = New System.Drawing.Size(146, 26)
        Me.name3TBX.TabIndex = 9
        '
        'dob2DTP
        '
        Me.dob2DTP.CustomFormat = "d/MM/yyyy"
        Me.dob2DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dob2DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob2DTP.Location = New System.Drawing.Point(341, 97)
        Me.dob2DTP.Name = "dob2DTP"
        Me.dob2DTP.Size = New System.Drawing.Size(124, 26)
        Me.dob2DTP.TabIndex = 8
        '
        'name2TBX
        '
        Me.name2TBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name2TBX.Location = New System.Drawing.Point(20, 97)
        Me.name2TBX.Name = "name2TBX"
        Me.name2TBX.Size = New System.Drawing.Size(146, 26)
        Me.name2TBX.TabIndex = 6
        '
        'DOB_LBL
        '
        Me.DOB_LBL.AutoSize = True
        Me.DOB_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB_LBL.Location = New System.Drawing.Point(341, 28)
        Me.DOB_LBL.Name = "DOB_LBL"
        Me.DOB_LBL.Size = New System.Drawing.Size(101, 20)
        Me.DOB_LBL.TabIndex = 5
        Me.DOB_LBL.Text = "Date of birth:"
        '
        'dob1DTP
        '
        Me.dob1DTP.CustomFormat = "d/MM/yyyy"
        Me.dob1DTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dob1DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dob1DTP.Location = New System.Drawing.Point(341, 51)
        Me.dob1DTP.Name = "dob1DTP"
        Me.dob1DTP.Size = New System.Drawing.Size(124, 26)
        Me.dob1DTP.TabIndex = 4
        '
        'pos1CBX
        '
        Me.pos1CBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pos1CBX.FormattingEnabled = True
        Me.pos1CBX.Location = New System.Drawing.Point(191, 50)
        Me.pos1CBX.Name = "pos1CBX"
        Me.pos1CBX.Size = New System.Drawing.Size(121, 28)
        Me.pos1CBX.TabIndex = 3
        '
        'PositionLBL
        '
        Me.PositionLBL.AutoSize = True
        Me.PositionLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionLBL.Location = New System.Drawing.Point(188, 27)
        Me.PositionLBL.Name = "PositionLBL"
        Me.PositionLBL.Size = New System.Drawing.Size(69, 20)
        Me.PositionLBL.TabIndex = 2
        Me.PositionLBL.Text = "Position:"
        '
        'name1TBX
        '
        Me.name1TBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.name1TBX.Location = New System.Drawing.Point(20, 51)
        Me.name1TBX.Name = "name1TBX"
        Me.name1TBX.Size = New System.Drawing.Size(146, 26)
        Me.name1TBX.TabIndex = 1
        '
        'nameLBL
        '
        Me.nameLBL.AutoSize = True
        Me.nameLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLBL.Location = New System.Drawing.Point(17, 27)
        Me.nameLBL.Name = "nameLBL"
        Me.nameLBL.Size = New System.Drawing.Size(55, 20)
        Me.nameLBL.TabIndex = 0
        Me.nameLBL.Text = "Name:"
        '
        'teamToDisplayLBL
        '
        Me.teamToDisplayLBL.AutoSize = True
        Me.teamToDisplayLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamToDisplayLBL.Location = New System.Drawing.Point(20, 274)
        Me.teamToDisplayLBL.Name = "teamToDisplayLBL"
        Me.teamToDisplayLBL.Size = New System.Drawing.Size(123, 20)
        Me.teamToDisplayLBL.TabIndex = 2
        Me.teamToDisplayLBL.Text = "Team to display:"
        '
        'teamLBX
        '
        Me.teamLBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamLBX.FormattingEnabled = True
        Me.teamLBX.ItemHeight = 20
        Me.teamLBX.Location = New System.Drawing.Point(23, 298)
        Me.teamLBX.Name = "teamLBX"
        Me.teamLBX.Size = New System.Drawing.Size(197, 144)
        Me.teamLBX.TabIndex = 3
        '
        'makeTeamBTN
        '
        Me.makeTeamBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makeTeamBTN.Location = New System.Drawing.Point(15, 213)
        Me.makeTeamBTN.Name = "makeTeamBTN"
        Me.makeTeamBTN.Size = New System.Drawing.Size(195, 34)
        Me.makeTeamBTN.TabIndex = 4
        Me.makeTeamBTN.Text = "Make The Team"
        Me.makeTeamBTN.UseVisualStyleBackColor = True
        '
        'outTBX
        '
        Me.outTBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outTBX.Location = New System.Drawing.Point(240, 274)
        Me.outTBX.Multiline = True
        Me.outTBX.Name = "outTBX"
        Me.outTBX.ReadOnly = True
        Me.outTBX.Size = New System.Drawing.Size(479, 167)
        Me.outTBX.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 470)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Team file to load"
        '
        'FileTBX
        '
        Me.FileTBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileTBX.Location = New System.Drawing.Point(155, 467)
        Me.FileTBX.Name = "FileTBX"
        Me.FileTBX.Size = New System.Drawing.Size(251, 26)
        Me.FileTBX.TabIndex = 7
        '
        'BrowseBTN
        '
        Me.BrowseBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseBTN.Location = New System.Drawing.Point(431, 467)
        Me.BrowseBTN.Name = "BrowseBTN"
        Me.BrowseBTN.Size = New System.Drawing.Size(75, 26)
        Me.BrowseBTN.TabIndex = 8
        Me.BrowseBTN.Text = "Browse"
        Me.BrowseBTN.UseVisualStyleBackColor = True
        '
        'LoadBTN
        '
        Me.LoadBTN.Enabled = False
        Me.LoadBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBTN.Location = New System.Drawing.Point(529, 468)
        Me.LoadBTN.Name = "LoadBTN"
        Me.LoadBTN.Size = New System.Drawing.Size(176, 26)
        Me.LoadBTN.TabIndex = 9
        Me.LoadBTN.Text = "Load teams from file"
        Me.LoadBTN.UseVisualStyleBackColor = True
        '
        'name4TBX
        '
        Me.name4TBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.name4TBX.Location = New System.Drawing.Point(20, 187)
        Me.name4TBX.Name = "name4TBX"
        Me.name4TBX.Size = New System.Drawing.Size(146, 26)
        Me.name4TBX.TabIndex = 18
        '
        'MakeATeamFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 512)
        Me.Controls.Add(Me.LoadBTN)
        Me.Controls.Add(Me.BrowseBTN)
        Me.Controls.Add(Me.FileTBX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.outTBX)
        Me.Controls.Add(Me.makeTeamBTN)
        Me.Controls.Add(Me.teamLBX)
        Me.Controls.Add(Me.teamToDisplayLBL)
        Me.Controls.Add(Me.playersGBX)
        Me.Controls.Add(Me.newTeamGBX)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MakeATeamFRM"
        Me.Text = "Make A Team"
        Me.newTeamGBX.ResumeLayout(False)
        Me.newTeamGBX.PerformLayout()
        Me.playersGBX.ResumeLayout(False)
        Me.playersGBX.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents newTeamGBX As GroupBox
    Friend WithEvents teamNameTBX As TextBox
    Friend WithEvents teamNameLBL As Label
    Friend WithEvents leagueLBL As Label
    Friend WithEvents leagueCBX As ComboBox
    Friend WithEvents playersGBX As GroupBox
    Friend WithEvents dob4DTP As DateTimePicker
    Friend WithEvents name3TBX As TextBox
    Friend WithEvents name2TBX As TextBox
    Friend WithEvents DOB_LBL As Label
    Friend WithEvents dob1DTP As DateTimePicker
    Friend WithEvents pos1CBX As ComboBox
    Friend WithEvents PositionLBL As Label
    Friend WithEvents name1TBX As TextBox
    Friend WithEvents nameLBL As Label
    Friend WithEvents teamToDisplayLBL As Label
    Friend WithEvents teamLBX As ListBox
    Friend WithEvents makeTeamBTN As Button
    Friend WithEvents outTBX As TextBox
    Friend WithEvents dob3DTP As DateTimePicker
    Friend WithEvents dob2DTP As DateTimePicker
    Friend WithEvents pos4CBX As ComboBox
    Friend WithEvents pos3CBX As ComboBox
    Friend WithEvents pos2CBX As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FileTBX As TextBox
    Friend WithEvents BrowseBTN As Button
    Friend WithEvents LoadBTN As Button
    Friend WithEvents name4TBX As TextBox
End Class
