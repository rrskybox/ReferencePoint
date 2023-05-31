<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReferencePointForm
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
        Dim GroupBox5 As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReferencePointForm))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RefPntName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AzimuthBox = New System.Windows.Forms.NumericUpDown()
        Me.AltitudeBox = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BuildButton = New System.Windows.Forms.Button()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AlwaysOnTopCheckBox = New System.Windows.Forms.CheckBox()
        GroupBox5 = New System.Windows.Forms.GroupBox()
        GroupBox5.SuspendLayout()
        CType(Me.AzimuthBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AltitudeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        GroupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        GroupBox5.Controls.Add(Me.Label9)
        GroupBox5.Controls.Add(Me.RefPntName)
        GroupBox5.Location = New System.Drawing.Point(16, 7)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New System.Drawing.Size(320, 43)
        GroupBox5.TabIndex = 18
        GroupBox5.TabStop = False
        GroupBox5.Text = "Step 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Enter Reference Point Name"
        '
        'RefPntName
        '
        Me.RefPntName.Location = New System.Drawing.Point(171, 17)
        Me.RefPntName.Name = "RefPntName"
        Me.RefPntName.Size = New System.Drawing.Size(138, 20)
        Me.RefPntName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Azimuth"
        '
        'AzimuthBox
        '
        Me.AzimuthBox.DecimalPlaces = 4
        Me.AzimuthBox.Location = New System.Drawing.Point(234, 56)
        Me.AzimuthBox.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.AzimuthBox.Name = "AzimuthBox"
        Me.AzimuthBox.Size = New System.Drawing.Size(75, 20)
        Me.AzimuthBox.TabIndex = 2
        Me.AzimuthBox.Value = New Decimal(New Integer() {1, 0, 0, 327680})
        '
        'AltitudeBox
        '
        Me.AltitudeBox.DecimalPlaces = 4
        Me.AltitudeBox.Location = New System.Drawing.Point(234, 88)
        Me.AltitudeBox.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.AltitudeBox.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.AltitudeBox.Name = "AltitudeBox"
        Me.AltitudeBox.Size = New System.Drawing.Size(75, 20)
        Me.AltitudeBox.TabIndex = 4
        Me.AltitudeBox.Value = New Decimal(New Integer() {1, 0, 0, 327680})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Altitude"
        '
        'BuildButton
        '
        Me.BuildButton.Location = New System.Drawing.Point(121, 19)
        Me.BuildButton.Name = "BuildButton"
        Me.BuildButton.Size = New System.Drawing.Size(75, 23)
        Me.BuildButton.TabIndex = 5
        Me.BuildButton.Text = "Build SDB"
        Me.BuildButton.UseVisualStyleBackColor = True
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(234, 22)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(75, 23)
        Me.DownloadButton.TabIndex = 6
        Me.DownloadButton.Text = "Download"
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Use the handpaddle to center your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " mount on the light screen, then press:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 78)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 39)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Or enter the target" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Azimuth and Altitude" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "coordinates here:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Press: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(327, 32)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "This reference point location is now available by using" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " the ""Find"" function in " &
    "TSX."
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(261, 400)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitButton.TabIndex = 14
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DownloadButton)
        Me.GroupBox1.Controls.Add(Me.AltitudeBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.AzimuthBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 128)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 2"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.BuildButton)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 52)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Step 3"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 117)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Step 4:  In TSX"
        '
        'AlwaysOnTopCheckBox
        '
        Me.AlwaysOnTopCheckBox.AutoSize = True
        Me.AlwaysOnTopCheckBox.Location = New System.Drawing.Point(21, 406)
        Me.AlwaysOnTopCheckBox.Name = "AlwaysOnTopCheckBox"
        Me.AlwaysOnTopCheckBox.Size = New System.Drawing.Size(98, 17)
        Me.AlwaysOnTopCheckBox.TabIndex = 19
        Me.AlwaysOnTopCheckBox.Text = "Always On Top"
        Me.AlwaysOnTopCheckBox.UseVisualStyleBackColor = True
        '
        'ReferencePointForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 435)
        Me.Controls.Add(Me.AlwaysOnTopCheckBox)
        Me.Controls.Add(GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ReferencePointForm"
        Me.Text = "Reference Point"
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        CType(Me.AzimuthBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AltitudeBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AzimuthBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents AltitudeBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BuildButton As System.Windows.Forms.Button
    Friend WithEvents DownloadButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RefPntName As TextBox
    Friend WithEvents AlwaysOnTopCheckBox As CheckBox
End Class
