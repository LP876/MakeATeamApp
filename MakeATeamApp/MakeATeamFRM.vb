Option Strict On
Imports System.IO

Public Class MakeATeamFRM
    Dim teams As Team() = New Team(9) {}  ' An array of Team objects
    Private teamCount As Integer = 0      ' The number of Teams added to teams()
    Private allPositions As String() = {"Centre", "Forward", "Defense", "Goalie", "Roamer"}
    Private allDivisions As String() = {"Premier", "Division 1", "Division 2", "Division 3", "Novice"}
    Private Sub MakeATeamFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateComboBox(leagueCBX, allDivisions)
        populateComboBox(pos1CBX, allPositions)
        populateComboBox(pos2CBX, allPositions)
        populateComboBox(pos3CBX, allPositions)
        populateComboBox(pos4CBX, allPositions)
    End Sub
    Sub populateComboBox(cbx As ComboBox, sa As String()) ' DO NOT MODIFY
        LoadBTN.Enabled = False
        For i = 0 To sa.GetUpperBound(0)
            cbx.Items.Add(sa(i))
        Next
    End Sub
    Private Sub makeTeamBTN_Click(sender As Object, e As EventArgs) Handles makeTeamBTN.Click
        Dim players As Player() = New Player(3) {}
        Dim teamName As String = teamNameTBX.Text
        Dim league As String = leagueCBX.Text
        Dim message As String = "You Must Specify at least one player for you team."

        If name1TBX.Text.Equals("") And name2TBX.Text.Equals("") And name3TBX.Text.Equals("") And name4TBX.Text.Equals("") Then
            MessageBox.Show(Message, "Invalid Team", MessageBoxButtons.OK)
        End If

        If Not name1TBX.Text.Equals("") And Not pos1CBX.Text.Equals("") And Not dob1DTP.Text.Equals("") Then
            players(0) = New Player(name1TBX.Text, pos1CBX.Text, dob1DTP.Value)
        End If
        If Not name2TBX.Text.Equals("") And Not pos2CBX.Text.Equals("") And Not dob2DTP.Text.Equals("") Then
            players(1) = New Player(name2TBX.Text, pos2CBX.Text, dob2DTP.Value)
        End If
        If Not name3TBX.Text.Equals("") And Not pos3CBX.Text.Equals("") And Not dob3DTP.Text.Equals("") Then
            players(2) = New Player(name3TBX.Text, pos3CBX.Text, dob3DTP.Value)
        End If
        If Not name4TBX.Text.Equals("") And Not pos4CBX.Text.Equals("") And Not dob4DTP.Text.Equals("") Then
            players(3) = New Player(name4TBX.Text, pos3CBX.Text, dob4DTP.Value)
        End If

        If Not name1TBX.Text.Equals("") Or Not name2TBX.Text.Equals("") Or Not name3TBX.Text.Equals("") Or Not name4TBX.Text.Equals("") Then
            teams(teamCount) = New Team(teamName, league, players)
            teamCount = teamCount + 1
            teamLBX.Items.Add(teamName)
            If teamCount = 10 Then makeTeamBTN.Enabled = False
            ClearTextBoxes()
        End If
    End Sub
    Private Sub teamLBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles teamLBX.SelectedIndexChanged
        ' DO NOT MODIFY Procedure
        Dim teamIndex As Integer = teamLBX.SelectedIndex
        outTBX.Text = teams(teamIndex).TeamSummary
    End Sub
    Private Sub ClearTextBoxes() ' DO NOT MODIFY Procedure
        name1TBX.Text = ""
        name2TBX.Text = ""
        name3TBX.Text = ""
        name4TBX.Text = ""
        teamNameTBX.Text = ""
    End Sub

    Private Sub browseBTN_Click(sender As Object, e As EventArgs) Handles BrowseBTN.Click
        Dim ofdialog As New OpenFileDialog
        Dim dresult As DialogResult
        dresult = ofdialog.ShowDialog()
        If Not dresult = DialogResult.Cancel Then
            FileTBX.Text = ofdialog.FileName
        End If
        If FileTBX.Text.Equals("") Then
            LoadBTN.Enabled = False
        ElseIf Not FileTBX.Text.Equals("") Then
            LoadBTN.Enabled = True
        End If
    End Sub

    Private Sub loadFileBTN_Click(sender As Object, e As EventArgs) Handles LoadBTN.Click
        Try
            Dim league As String
            Dim playerName As String
            Dim line As String
            Dim name As String
            Dim pPosition As String
            Dim tcnt As Integer = 0
            Dim fileName As String = FileTBX.Text
            Dim sReaderInput As StreamReader = New StreamReader(fileName)
            Dim teamName As String = teamLBX.Text


            Do Until sReaderInput.EndOfStream
                Dim token As String()
                line = sReaderInput.ReadLine()
                token = line.Split(","c)
                name = token(0)
                league = token(1)
                Dim pCount As Integer = 0
                Dim players As Player() = New Player(3) {}

                For i = 2 To token.GetUpperBound(0) Step 3
                    playerName = token(i)
                    pPosition = token(i + 2)
                    players(pCount) = New Player(token(i), token(i + 2), DateTime.Parse(token(i + 1)))
                    pCount = pCount + 1
                Next
                teams(tcnt) = New Team(token(0), token(1), players)
                teamLBX.Items.Add(token(0))
                tcnt = tcnt + 1
            Loop
            sReaderInput.Close()
        Catch ex As Exception
            MessageBox.Show("The File" & FileTBX.Text & " does not exist.", "Invalid File Name")
        End Try
    End Sub
    Private Sub fileNameTBX_TextChanged(sender As Object, e As EventArgs) Handles FileTBX.TextChanged
        LoadBTN.Enabled = True
    End Sub
End Class
Public Class Player
    Private v_name As String
    Private v_position As String
    Private v_DOB As Date
    Public Sub New(n As String, p As String, d As Date)
        PlayerName = n
        Position = p
        v_DOB = d
    End Sub
    Public Property PlayerName As String
        Get
            Return v_name
        End Get
        Set(value As String)
            v_name = value
        End Set
    End Property
    Public Property Position As String
        Get
            Return v_position
        End Get
        Set(value As String)
            v_position = value
        End Set
    End Property
    Public ReadOnly Property DOB As String
        Get
            Return String.Format("{0:MMMM dd, yyyy}", v_DOB)
        End Get
    End Property
    Public ReadOnly Property Summary As String
        Get
            Return PlayerName & " (" & Position & ", " & DOB & ")"
        End Get
    End Property
End Class
Public Class Team
    Private v_name As String
    Private v_league As String
    Private v_members As Player()
    Public Sub New(n As String, l As String, m As Player())
        TeamName = n
        League = l
        v_members = m
    End Sub
    Public Property TeamName As String
        Get
            Return v_name
        End Get
        Set(value As String)
            v_name = value
        End Set
    End Property
    Public Property League As String
        Get
            Return v_league
        End Get
        Set(value As String)
            v_league = value
        End Set
    End Property
    Public ReadOnly Property Members As String
        Get
            Dim s As String = ""
            For i = 0 To v_members.GetUpperBound(0)
                If Not v_members(i) Is Nothing Then
                    s = s & v_members(i).Summary & vbNewLine
                End If
            Next
            Return s
        End Get
    End Property
    Public ReadOnly Property TeamSummary As String
        Get
            Return "Team '" & TeamName & "' (League: " & League & ")" &
                    vbNewLine & vbNewLine &
                    "Members:" & vbNewLine & Members
        End Get
    End Property
End Class

