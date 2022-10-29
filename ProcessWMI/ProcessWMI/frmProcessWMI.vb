#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: http://www.facebook.com/g2gnet (for Thailand)
' / Facebook: http://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com
' /
' / Purpose: List process with WMI (Windows Management Instrumental) and kill processes as needed.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports System.Management   '/--> Don't forget Add References before.
Imports System.IO

Public Class frmProcessWMI
    Private SortColumn As Integer = -1

    ' / S T A R T ... H E R E
    Private Sub frmProcessWMI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitListView()
        Call ListProcess()
        '// ComboBox
        With cmbTimer
            .DropDownStyle = ComboBoxStyle.DropDownList
            .MaxDropDownItems = 12
            .IntegralHeight = False '/ Set maximum DropDownItems ComboBox to show.
            For iSec As Byte = 1 To 60
                .Items.Add(iSec)
            Next
            .SelectedIndex = 4    '/ Set 5 second.
        End With
        Timer1.Interval = CInt(cmbTimer.Text) * 1000    '/ 1000 millisecond = 1 Sec.
        Timer1.Enabled = True     '/ Start working.
        '// Sample
        txtProcessName.Text = ""

        '// Event Handler Sort Order Column on ListView.
        AddHandler ListView1.ColumnClick, AddressOf Me.ListView1_ColumnClick
    End Sub

    ' / ----------------------------------------------------------------------------------------
    ' / List Process.
    Private Sub btnListProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnListProcess.Click
        Call InitListView()
        Call ListProcess()
    End Sub

    ' / ----------------------------------------------------------------------------------------
    ' / Sorting ListView Items by Column Using Windows Forms.
    ' / https://learn.microsoft.com/en-us/previous-versions/dotnet/articles/ms996467(v=msdn.10)?redirectedfrom=MSDN
    Private Sub ListView1_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs)
        '/ Determine whether the column is the same as the last column clicked.
        If e.Column <> SortColumn Then
            '/ Set the sort column to the new column.
            SortColumn = e.Column
            '/ Set the sort order to ascending by default.
            ListView1.Sorting = SortOrder.Ascending
        Else
            '/ Determine what the last sort order was and change it.
            If ListView1.Sorting = SortOrder.Ascending Then
                ListView1.Sorting = SortOrder.Descending
            Else
                ListView1.Sorting = SortOrder.Ascending
            End If
        End If
        '/ Call the sort method to manually sort.
        ListView1.Sort()
        '/ Set the ListViewItemSorter property to a new ListViewItemComparer object.
        ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting)
    End Sub

    ' / ----------------------------------------------------------------------------------------
    ' / Initailize ListView Control
    Sub InitListView()
        With ListView1
            .Clear()
            .View = View.Details
            .Sorting = SortOrder.Ascending
            .GridLines = True
            .FullRowSelect = True
            .HideSelection = False
            .MultiSelect = False
            ' 1st Column Index = 0
            .Columns.Add("Process ID", ListView1.Width \ 2 - 180)
            .Columns.Add("Executable Path", ListView1.Width \ 2 + 155)
        End With
    End Sub

    ' / ----------------------------------------------------------------------------------------
    ' / Listing Process.
    Sub ListProcess()
        Try
            Dim searcher As New ManagementObjectSearcher( _
                "root\CIMV2", _
                "SELECT * FROM Win32_Process")
            Dim LV As ListViewItem
            For Each queryObj As ManagementObject In searcher.Get()
                If Not IsNothing(queryObj("ExecutablePath")) Then
                    LV = ListView1.Items.Add(String.Format("{0}", queryObj("ProcessId")))  ' Primary Node
                    LV.SubItems.Add(String.Format("{0}", queryObj("ExecutablePath")))
                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        End Try
    End Sub

    ' / ----------------------------------------------------------------------------------------
    ' / Kill Process which you want.
    Private Sub btnTerminate_Click(sender As System.Object, e As System.EventArgs) Handles btnTerminate.Click
        ' / Kill Process with Process ID
        Dim PID As Integer = CInt(ListView1.SelectedItems(0).SubItems(0).Text)
        Dim myProcID As Process
        myProcID = Process.GetProcessById(PID)
        Try
            'MsgBox("You'll kill Process ID : " & PID)
            If (MsgBox("Are you sure to kill the process: " & PID & "?", vbYesNo + MsgBoxStyle.Question + vbDefaultButton2, "Confirm kill process") = MsgBoxResult.No) Then Return
            '/ Kill process from Process ID.
            myProcID.Kill()
            Call InitListView()
            Call ListProcess()
        Catch err As Exception
            ' / If it didn't work.
            MessageBox.Show("An error occurred for kill Process ID : " & err.Message)
        End Try

    End Sub

    ' / ----------------------------------------------------------------------------------------
    ' / If the program opens at any time will kill that process at the specified time.
    ' / ----------------------------------------------------------------------------------------
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If txtProcessName.Text.Trim = "" Or txtProcessName.Text.Trim.Length = 0 Then Return
        ' / Kill Process.
        Try
            '/ Add References ... System.Management
            Dim process As Process
            Dim myFile As String = Path.GetFileNameWithoutExtension(txtProcessName.Text)    '// Get only Filename without '.exe' or Extension.
            For Each process In process.GetProcessesByName(myFile)
                process.Kill()
            Next
        Catch ex As Exception
            ' / If it didn't work.
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbTimer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTimer.SelectedIndexChanged
        Timer1.Interval = CInt(cmbTimer.Text) * 1000
    End Sub

    Private Sub frmProcessWMI_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If ListView1.Items.Count = 0 Then Return
        With ListView1
            .Columns(0).Width = ListView1.Width \ 2 - 180
            .Columns(1).Width = ListView1.Width \ 2 + 155
        End With
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmProcessWMI_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

End Class

