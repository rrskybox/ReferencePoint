Imports System.IO
Imports System.Linq.Expressions

'Windows Visual Basic Forms Application: Reference Point
'
' Tool to aid the creation and usage of a TSX Sky Database reference point.
'
' See file "Reference Point Description.docx" for details.
'
'
' ------------------------------------------------------------------------
'
' Author: R.McAlister (2016)
'
' Version 1.0  - First light
'
' Version 2.0 - Added 64 and 32 bit versions
'
' ------------------------------------------------------------------------
'
'
Imports System.Reflection


Public Class ReferencePointForm

    'Dim TSXDir As String = "\Documents\Software Bisque\TheSky Professional Edition 64\SDBs\"
    'Dim TSXObj As String = "TheSky64."
    Dim TSXDir As String = "\Documents\Software Bisque\TheSkyX Professional Edition\SDBs\"
    Dim TSXObj As String = "TheSkyX."

    Private Sub BuildButton_Click(sender As Object, e As EventArgs) Handles BuildButton.Click
        'Reads in the embedded text file "MyFlatFieldSDB.txt", changes the Alt and Az fields
        '  then rewrites it back out to the SoftwareBisque SDBs folder

        If (RefPntName.Text = "") Then
            Return
        End If

        'Installs the dbq file
        Dim FFDestinationPath As String = "C:\Users\" + System.Environment.UserName + TSXDir + RefPntName.Text + " SDB.txt"
        Dim fdstream As Stream
        Dim dassembly As [Assembly]

        'Collect the file contents to be written
        dassembly = [Assembly].GetExecutingAssembly()
        fdstream = dassembly.GetManifestResourceStream("ReferencePoint.ReferencePointSDB.txt")
        Dim fdstreamreader = New StreamReader(fdstream)
        Dim dstring = fdstreamreader.ReadToEnd()
        'Create header to the header the hard way:
        Dim hstring = "<?xml version=""1.0""?>" + Environment.NewLine +
                      "<!DOCTYPE TheSkyDatabase>" + Environment.NewLine +
                      "<TheSkyDatabaseHeader version = ""1.00"">" + Environment.NewLine +
                       "    <identifier>" + RefPntName.Text + "</identifier>" + Environment.NewLine +
                       "    <sdbDescription>" + RefPntName.Text + " Reference Point" + Environment.NewLine
        Dim allString = hstring + dstring + Environment.NewLine
        My.Computer.FileSystem.WriteAllText(FFDestinationPath, allString, False)
        '
        'Fill in fields and output to file
        Dim fe As New SDB_Node

        fe.Label = RefPntName.Text
        fe.raHours = AzimuthBox.Value.ToString("G")
        fe.decDegrees = AltitudeBox.Value.ToString("G")
        fe.ObjType = "Reference Point"
        fe.MaxFOV = "100"
        fe.MinFOV = "0"

        Dim fstring = fe.Entry()
        My.Computer.FileSystem.WriteAllText(FFDestinationPath, fstring, True)

        Return
    End Sub

    Private Sub Download_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        'Gets the current az/alt coordinates from TSX and stroes them in the form variables

        Dim tsxt = CreateObject(TSXObj + "sky6RASCOMtele")
        Try
            tsxt.GetAzAlt()
        Catch
            MessageBox.Show("No telescope coordinates found")
        End Try

        AzimuthBox.Value = tsxt.dAz
        AltitudeBox.Value = tsxt.dAlt
        Return
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Close()
        Return
    End Sub

    Private Sub AlwaysOnTopCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AlwaysOnTopCheckBox.CheckedChanged
        If (AlwaysOnTopCheckBox.Checked) Then
            My.Settings.AlwaysOnTop = True

        Else
            My.Settings.AlwaysOnTop = False
        End If
        My.Settings.Save()
        Me.TopMost = My.Settings.AlwaysOnTop
    End Sub

End Class
