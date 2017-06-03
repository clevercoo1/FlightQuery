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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtSearch = New System.Windows.Forms.Button()
        Me.myDGV = New System.Windows.Forms.DataGridView()
        Me.Groupdisplay = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkApplyTime = New System.Windows.Forms.CheckBox()
        Me.ChkState = New System.Windows.Forms.CheckBox()
        Me.ChkAta = New System.Windows.Forms.CheckBox()
        Me.ChkAtd = New System.Windows.Forms.CheckBox()
        Me.ChkEta = New System.Windows.Forms.CheckBox()
        Me.ChkEtd = New System.Windows.Forms.CheckBox()
        Me.ChkCityx = New System.Windows.Forms.CheckBox()
        Me.ChkCity = New System.Windows.Forms.CheckBox()
        Me.ChkPlanen = New System.Windows.Forms.CheckBox()
        Me.ChkPlane = New System.Windows.Forms.CheckBox()
        Me.ChkCorp = New System.Windows.Forms.CheckBox()
        Me.ChkFlightnum = New System.Windows.Forms.CheckBox()
        Me.NO = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtMSG = New System.Windows.Forms.TextBox()
        Me.tlFunction = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolsbInsert = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Groupsearch = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textnum = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Combostate = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Labelstate = New System.Windows.Forms.Label()
        Me.Labdate = New System.Windows.Forms.Label()
        CType(Me.myDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Groupdisplay.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tlFunction.SuspendLayout()
        Me.Groupsearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(521, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(69, 26)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "查询"
        Me.txtSearch.UseVisualStyleBackColor = True
        '
        'myDGV
        '
        Me.myDGV.AllowUserToAddRows = False
        Me.myDGV.AllowUserToDeleteRows = False
        Me.myDGV.AllowUserToOrderColumns = True
        Me.myDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.myDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.myDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.myDGV.Location = New System.Drawing.Point(3, 42)
        Me.myDGV.MultiSelect = False
        Me.myDGV.Name = "myDGV"
        Me.myDGV.RowTemplate.Height = 23
        Me.myDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.myDGV.Size = New System.Drawing.Size(671, 201)
        Me.myDGV.TabIndex = 2
        Me.myDGV.TabStop = False
        '
        'Groupdisplay
        '
        Me.Groupdisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Groupdisplay.Controls.Add(Me.Panel1)
        Me.Groupdisplay.Controls.Add(Me.myDGV)
        Me.Groupdisplay.Controls.Add(Me.txtMSG)
        Me.Groupdisplay.Controls.Add(Me.tlFunction)
        Me.Groupdisplay.Location = New System.Drawing.Point(2, 63)
        Me.Groupdisplay.Name = "Groupdisplay"
        Me.Groupdisplay.Size = New System.Drawing.Size(677, 267)
        Me.Groupdisplay.TabIndex = 3
        Me.Groupdisplay.TabStop = False
        Me.Groupdisplay.Text = "数据显示"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ChkApplyTime)
        Me.Panel1.Controls.Add(Me.ChkState)
        Me.Panel1.Controls.Add(Me.ChkAta)
        Me.Panel1.Controls.Add(Me.ChkAtd)
        Me.Panel1.Controls.Add(Me.ChkEta)
        Me.Panel1.Controls.Add(Me.ChkEtd)
        Me.Panel1.Controls.Add(Me.ChkCityx)
        Me.Panel1.Controls.Add(Me.ChkCity)
        Me.Panel1.Controls.Add(Me.ChkPlanen)
        Me.Panel1.Controls.Add(Me.ChkPlane)
        Me.Panel1.Controls.Add(Me.ChkCorp)
        Me.Panel1.Controls.Add(Me.ChkFlightnum)
        Me.Panel1.Controls.Add(Me.NO)
        Me.Panel1.Controls.Add(Me.OK)
        Me.Panel1.Location = New System.Drawing.Point(19, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 165)
        Me.Panel1.TabIndex = 103
        '
        'ChkApplyTime
        '
        Me.ChkApplyTime.AutoSize = True
        Me.ChkApplyTime.Checked = True
        Me.ChkApplyTime.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkApplyTime.Location = New System.Drawing.Point(113, 132)
        Me.ChkApplyTime.Name = "ChkApplyTime"
        Me.ChkApplyTime.Size = New System.Drawing.Size(72, 16)
        Me.ChkApplyTime.TabIndex = 13
        Me.ChkApplyTime.Text = "计算时间"
        Me.ChkApplyTime.UseVisualStyleBackColor = True
        '
        'ChkState
        '
        Me.ChkState.AutoSize = True
        Me.ChkState.Checked = True
        Me.ChkState.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkState.Location = New System.Drawing.Point(113, 110)
        Me.ChkState.Name = "ChkState"
        Me.ChkState.Size = New System.Drawing.Size(72, 16)
        Me.ChkState.TabIndex = 12
        Me.ChkState.Text = "航班状态"
        Me.ChkState.UseVisualStyleBackColor = True
        '
        'ChkAta
        '
        Me.ChkAta.AutoSize = True
        Me.ChkAta.Checked = True
        Me.ChkAta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAta.Location = New System.Drawing.Point(113, 88)
        Me.ChkAta.Name = "ChkAta"
        Me.ChkAta.Size = New System.Drawing.Size(72, 16)
        Me.ChkAta.TabIndex = 11
        Me.ChkAta.Text = "实际到达"
        Me.ChkAta.UseVisualStyleBackColor = True
        '
        'ChkAtd
        '
        Me.ChkAtd.AutoSize = True
        Me.ChkAtd.Checked = True
        Me.ChkAtd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAtd.Location = New System.Drawing.Point(113, 65)
        Me.ChkAtd.Name = "ChkAtd"
        Me.ChkAtd.Size = New System.Drawing.Size(72, 16)
        Me.ChkAtd.TabIndex = 10
        Me.ChkAtd.Text = "实际起飞"
        Me.ChkAtd.UseVisualStyleBackColor = True
        '
        'ChkEta
        '
        Me.ChkEta.AutoSize = True
        Me.ChkEta.Checked = True
        Me.ChkEta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkEta.Location = New System.Drawing.Point(113, 42)
        Me.ChkEta.Name = "ChkEta"
        Me.ChkEta.Size = New System.Drawing.Size(72, 16)
        Me.ChkEta.TabIndex = 9
        Me.ChkEta.Text = "计划到达"
        Me.ChkEta.UseVisualStyleBackColor = True
        '
        'ChkEtd
        '
        Me.ChkEtd.AutoSize = True
        Me.ChkEtd.Checked = True
        Me.ChkEtd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkEtd.Location = New System.Drawing.Point(113, 19)
        Me.ChkEtd.Name = "ChkEtd"
        Me.ChkEtd.Size = New System.Drawing.Size(72, 16)
        Me.ChkEtd.TabIndex = 8
        Me.ChkEtd.Text = "计划起飞"
        Me.ChkEtd.UseVisualStyleBackColor = True
        '
        'ChkCityx
        '
        Me.ChkCityx.AutoSize = True
        Me.ChkCityx.Checked = True
        Me.ChkCityx.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCityx.Location = New System.Drawing.Point(19, 131)
        Me.ChkCityx.Name = "ChkCityx"
        Me.ChkCityx.Size = New System.Drawing.Size(72, 16)
        Me.ChkCityx.TabIndex = 7
        Me.ChkCityx.Text = "落地机场"
        Me.ChkCityx.UseVisualStyleBackColor = True
        '
        'ChkCity
        '
        Me.ChkCity.AutoSize = True
        Me.ChkCity.Checked = True
        Me.ChkCity.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCity.Location = New System.Drawing.Point(19, 108)
        Me.ChkCity.Name = "ChkCity"
        Me.ChkCity.Size = New System.Drawing.Size(72, 16)
        Me.ChkCity.TabIndex = 6
        Me.ChkCity.Text = "起飞机场"
        Me.ChkCity.UseVisualStyleBackColor = True
        '
        'ChkPlanen
        '
        Me.ChkPlanen.AutoSize = True
        Me.ChkPlanen.Checked = True
        Me.ChkPlanen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPlanen.Location = New System.Drawing.Point(19, 86)
        Me.ChkPlanen.Name = "ChkPlanen"
        Me.ChkPlanen.Size = New System.Drawing.Size(48, 16)
        Me.ChkPlanen.TabIndex = 5
        Me.ChkPlanen.Text = "机号"
        Me.ChkPlanen.UseVisualStyleBackColor = True
        '
        'ChkPlane
        '
        Me.ChkPlane.AutoSize = True
        Me.ChkPlane.Checked = True
        Me.ChkPlane.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPlane.Location = New System.Drawing.Point(19, 64)
        Me.ChkPlane.Name = "ChkPlane"
        Me.ChkPlane.Size = New System.Drawing.Size(48, 16)
        Me.ChkPlane.TabIndex = 4
        Me.ChkPlane.Text = "机型"
        Me.ChkPlane.UseVisualStyleBackColor = True
        '
        'ChkCorp
        '
        Me.ChkCorp.AutoSize = True
        Me.ChkCorp.Checked = True
        Me.ChkCorp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCorp.Location = New System.Drawing.Point(19, 42)
        Me.ChkCorp.Name = "ChkCorp"
        Me.ChkCorp.Size = New System.Drawing.Size(60, 16)
        Me.ChkCorp.TabIndex = 3
        Me.ChkCorp.Text = "三字码"
        Me.ChkCorp.UseVisualStyleBackColor = True
        '
        'ChkFlightnum
        '
        Me.ChkFlightnum.AutoSize = True
        Me.ChkFlightnum.Checked = True
        Me.ChkFlightnum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFlightnum.Location = New System.Drawing.Point(19, 19)
        Me.ChkFlightnum.Name = "ChkFlightnum"
        Me.ChkFlightnum.Size = New System.Drawing.Size(60, 16)
        Me.ChkFlightnum.TabIndex = 2
        Me.ChkFlightnum.Text = "航班号"
        Me.ChkFlightnum.UseVisualStyleBackColor = True
        '
        'NO
        '
        Me.NO.Location = New System.Drawing.Point(250, 64)
        Me.NO.Name = "NO"
        Me.NO.Size = New System.Drawing.Size(62, 28)
        Me.NO.TabIndex = 1
        Me.NO.Text = "关闭"
        Me.NO.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(250, 19)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(62, 27)
        Me.OK.TabIndex = 0
        Me.OK.TabStop = False
        Me.OK.Text = "确定"
        Me.OK.UseVisualStyleBackColor = True
        '
        'txtMSG
        '
        Me.txtMSG.BackColor = System.Drawing.Color.Azure
        Me.txtMSG.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtMSG.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtMSG.ForeColor = System.Drawing.Color.Blue
        Me.txtMSG.Location = New System.Drawing.Point(3, 243)
        Me.txtMSG.Name = "txtMSG"
        Me.txtMSG.ReadOnly = True
        Me.txtMSG.Size = New System.Drawing.Size(671, 21)
        Me.txtMSG.TabIndex = 101
        Me.txtMSG.TabStop = False
        Me.txtMSG.Text = "合计："
        '
        'tlFunction
        '
        Me.tlFunction.BackColor = System.Drawing.Color.Transparent
        Me.tlFunction.BackgroundImage = CType(resources.GetObject("tlFunction.BackgroundImage"), System.Drawing.Image)
        Me.tlFunction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlFunction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.ToolStripSeparator1, Me.ToolsbInsert, Me.ToolStripSeparator3})
        Me.tlFunction.Location = New System.Drawing.Point(3, 17)
        Me.tlFunction.Name = "tlFunction"
        Me.tlFunction.Size = New System.Drawing.Size(671, 25)
        Me.tlFunction.TabIndex = 102
        Me.tlFunction.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolsbInsert
        '
        Me.ToolsbInsert.BackColor = System.Drawing.Color.Transparent
        Me.ToolsbInsert.ForeColor = System.Drawing.Color.White
        Me.ToolsbInsert.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolsbInsert.Name = "ToolsbInsert"
        Me.ToolsbInsert.Size = New System.Drawing.Size(57, 22)
        Me.ToolsbInsert.Text = "自定义列"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'Groupsearch
        '
        Me.Groupsearch.Controls.Add(Me.Label1)
        Me.Groupsearch.Controls.Add(Me.Textnum)
        Me.Groupsearch.Controls.Add(Me.btnRefresh)
        Me.Groupsearch.Controls.Add(Me.Combostate)
        Me.Groupsearch.Controls.Add(Me.DateTimePicker1)
        Me.Groupsearch.Controls.Add(Me.Labelstate)
        Me.Groupsearch.Controls.Add(Me.Labdate)
        Me.Groupsearch.Controls.Add(Me.txtSearch)
        Me.Groupsearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.Groupsearch.Location = New System.Drawing.Point(0, 0)
        Me.Groupsearch.Name = "Groupsearch"
        Me.Groupsearch.Size = New System.Drawing.Size(680, 54)
        Me.Groupsearch.TabIndex = 4
        Me.Groupsearch.TabStop = False
        Me.Groupsearch.Text = "查询条件"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 2031
        Me.Label1.Text = "航班号"
        '
        'Textnum
        '
        Me.Textnum.Location = New System.Drawing.Point(385, 22)
        Me.Textnum.Name = "Textnum"
        Me.Textnum.Size = New System.Drawing.Size(80, 21)
        Me.Textnum.TabIndex = 2030
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(606, 18)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(62, 26)
        Me.btnRefresh.TabIndex = 2029
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Text = "复位"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Combostate
        '
        Me.Combostate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combostate.FormattingEnabled = True
        Me.Combostate.Location = New System.Drawing.Point(227, 22)
        Me.Combostate.Name = "Combostate"
        Me.Combostate.Size = New System.Drawing.Size(71, 20)
        Me.Combostate.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(54, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(110, 21)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Labelstate
        '
        Me.Labelstate.AutoSize = True
        Me.Labelstate.Location = New System.Drawing.Point(180, 25)
        Me.Labelstate.Name = "Labelstate"
        Me.Labelstate.Size = New System.Drawing.Size(41, 12)
        Me.Labelstate.TabIndex = 3
        Me.Labelstate.Text = "进出港"
        '
        'Labdate
        '
        Me.Labdate.AutoSize = True
        Me.Labdate.Location = New System.Drawing.Point(19, 25)
        Me.Labdate.Name = "Labdate"
        Me.Labdate.Size = New System.Drawing.Size(29, 12)
        Me.Labdate.TabIndex = 2
        Me.Labdate.Text = "日期"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 331)
        Me.Controls.Add(Me.Groupsearch)
        Me.Controls.Add(Me.Groupdisplay)
        Me.Name = "Form1"
        Me.Text = "航班查询"
        CType(Me.myDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Groupdisplay.ResumeLayout(False)
        Me.Groupdisplay.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tlFunction.ResumeLayout(False)
        Me.tlFunction.PerformLayout()
        Me.Groupsearch.ResumeLayout(False)
        Me.Groupsearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As System.Windows.Forms.Button
    Friend WithEvents myDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Groupdisplay As System.Windows.Forms.GroupBox
    Friend WithEvents Groupsearch As System.Windows.Forms.GroupBox
    Friend WithEvents Labdate As System.Windows.Forms.Label
    Friend WithEvents Labelstate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Combostate As System.Windows.Forms.ComboBox
    Friend WithEvents txtMSG As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents tlFunction As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolsbInsert As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NO As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents ChkApplyTime As System.Windows.Forms.CheckBox
    Friend WithEvents ChkState As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAta As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAtd As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEta As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEtd As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCityx As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCity As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPlanen As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPlane As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCorp As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFlightnum As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Textnum As System.Windows.Forms.TextBox

End Class
