<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label17 = New System.Windows.Forms.Label
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtBMPFilename = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtHZFilename = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCodeEnd = New System.Windows.Forms.TextBox
        Me.txtCodeStart = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFilesCount = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtFilesPrefix = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(441, 138)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(433, 112)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Input"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Red
        Me.PictureBox3.Location = New System.Drawing.Point(58, 74)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 1)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1656, 2341)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(433, 112)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Output"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(260, 89)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(433, 112)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Help"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(365, 168)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = resources.GetString("Label17.Text")
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(12, 152)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(441, 297)
        Me.TabControl2.TabIndex = 3
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.PictureBox4)
        Me.TabPage4.Controls.Add(Me.ProgressBar1)
        Me.TabPage4.Controls.Add(Me.btnSave)
        Me.TabPage4.Controls.Add(Me.btnCreate)
        Me.TabPage4.Controls.Add(Me.btnRefresh)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(433, 271)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Create"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBMPFilename)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtHZFilename)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtCodeEnd)
        Me.GroupBox3.Controls.Add(Me.txtCodeStart)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(412, 98)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output"
        '
        'txtBMPFilename
        '
        Me.txtBMPFilename.Location = New System.Drawing.Point(83, 68)
        Me.txtBMPFilename.Name = "txtBMPFilename"
        Me.txtBMPFilename.Size = New System.Drawing.Size(319, 21)
        Me.txtBMPFilename.TabIndex = 33
        Me.txtBMPFilename.Text = "d:\2CEB0.BMP"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 12)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = ".BMP File:"
        '
        'txtHZFilename
        '
        Me.txtHZFilename.Location = New System.Drawing.Point(83, 41)
        Me.txtHZFilename.Name = "txtHZFilename"
        Me.txtHZFilename.Size = New System.Drawing.Size(319, 21)
        Me.txtHZFilename.TabIndex = 31
        Me.txtHZFilename.Text = "d:\2CEB0.HZ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 12)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = ".HZ File:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(145, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 12)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "End:"
        '
        'txtCodeEnd
        '
        Me.txtCodeEnd.Location = New System.Drawing.Point(180, 14)
        Me.txtCodeEnd.Name = "txtCodeEnd"
        Me.txtCodeEnd.Size = New System.Drawing.Size(56, 21)
        Me.txtCodeEnd.TabIndex = 28
        Me.txtCodeEnd.Text = "2EBE0"
        '
        'txtCodeStart
        '
        Me.txtCodeStart.Location = New System.Drawing.Point(83, 14)
        Me.txtCodeStart.Name = "txtCodeStart"
        Me.txtCodeStart.Size = New System.Drawing.Size(56, 21)
        Me.txtCodeStart.TabIndex = 27
        Me.txtCodeStart.Text = "2CEB0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 12)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Code Start:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFilesCount)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtFilesPrefix)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 42)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Source Picture Page Files"
        '
        'txtFilesCount
        '
        Me.txtFilesCount.Location = New System.Drawing.Point(376, 14)
        Me.txtFilesCount.Name = "txtFilesCount"
        Me.txtFilesCount.Size = New System.Drawing.Size(25, 21)
        Me.txtFilesCount.TabIndex = 31
        Me.txtFilesCount.Text = "8"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(347, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 12)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "max"
        '
        'txtFilesPrefix
        '
        Me.txtFilesPrefix.Location = New System.Drawing.Point(59, 14)
        Me.txtFilesPrefix.Name = "txtFilesPrefix"
        Me.txtFilesPrefix.Size = New System.Drawing.Size(282, 21)
        Me.txtFilesPrefix.TabIndex = 29
        Me.txtFilesPrefix.Text = "D:\工作\[学习]\编码字符集\2CEB0-2EBE0\xhx2_页面_"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 12)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Prefix:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 71)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PerPage"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(356, 14)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(48, 21)
        Me.TextBox7.TabIndex = 31
        Me.TextBox7.Text = "0.57"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(285, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "ColsMergin"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(356, 41)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(48, 21)
        Me.TextBox8.TabIndex = 29
        Me.TextBox8.Text = "20.35"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(285, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "RowsMergin"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(231, 14)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(48, 21)
        Me.TextBox5.TabIndex = 27
        Me.TextBox5.Text = "30"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Cols"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(231, 41)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(48, 21)
        Me.TextBox6.TabIndex = 25
        Me.TextBox6.Text = "31"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Rows"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(142, 14)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(48, 21)
        Me.TextBox3.TabIndex = 23
        Me.TextBox3.Text = "48"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Height"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(142, 41)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(48, 21)
        Me.TextBox4.TabIndex = 21
        Me.TextBox4.Text = "48"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 12)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Width"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(41, 41)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(48, 21)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.Text = "86"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 12)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Top"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(41, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 21)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "80"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Left"
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(175, 235)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 235)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(161, 16)
        Me.ProgressBar1.TabIndex = 20
        Me.ProgressBar1.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(205, 235)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(275, 235)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(64, 23)
        Me.btnCreate.TabIndex = 18
        Me.btnCreate.Text = "&Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(345, 235)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(414, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "currentX= ; currentY="
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListBox1)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(433, 271)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "View"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(41, 32)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(386, 232)
        Me.ListBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(41, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(305, 20)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "3x5.png")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "5x7.png")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 461)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHZFilename As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCodeEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtCodeStart As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFilesCount As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFilesPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBMPFilename As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
