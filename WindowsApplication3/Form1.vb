Imports System.IO
Imports Newtonsoft.Json.Linq
Imports System.Text.RegularExpressions

Public Class Form1
    ''' <summary>
    ''' 程序入口
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPersonalRecord_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Panel1.Visible = False
            InitFace()
            AddDgvColumns()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    ''' <summary>
    ''' 初始化
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitFace()
        Me.Combostate.Items.Add("进港")
        Me.Combostate.Items.Add("出港")
        Me.Combostate.Text = "进港"

        ChkFlightnum.Checked = My.Settings.ChkFlightnum
        ChkCorp.Checked = My.Settings.ChkCorp
        ChkPlane.Checked = My.Settings.ChkPlane
        ChkPlanen.Checked = My.Settings.ChkPlanen
        ChkCity.Checked = My.Settings.ChkCity
        ChkCityx.Checked = My.Settings.ChkCityx
        ChkEtd.Checked = My.Settings.ChkEtd
        ChkEta.Checked = My.Settings.ChkEta
        ChkAtd.Checked = My.Settings.ChkAtd
        ChkAta.Checked = My.Settings.ChkAta
        ChkState.Checked = My.Settings.ChkState
        ChkApplyTime.Checked = My.Settings.ChkApplyTime

        '    Dim ex As Boolean
        '    ex = File.Exists("c:\xx.txt")
        '    If ex = True Then
        '        Dim sc As Object = New Object
        '        Dim str = File.ReadAllLines("c:\xx.txt")
        '        Dim strx As String = ""
        '        Dim stry As String = ""
        '        For i = 0 To str.Length - 1 Step 1
        '            strx += str(i) & vbCrLf
        '        Next
        '        stry = "Sub Main" & vbCrLf & _
        'strx & _
        '"End Sub"
        '        Dim strProgram As String = "Sub Main" & vbCrLf & _
        '    "MsgBox ""Hello World""" & vbCrLf & _
        '    "End Sub"
        '        sc = CreateObject("ScriptControl")
        '        sc.language = "VBScript"
        '        sc.addcode(stry)
        '        sc.run("Main")

        '    Else
        '        Return
        '    End If
    End Sub

    ''' <summary>
    ''' 查询按钮
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click, txtSearch.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim url As String = "http://218.93.121.46/WebServiceFlightDyn.asmx/GetFlightDyn"
        Dim state As String = ""
        Dim d As String = ""
        If Not IsNothing(Me.Combostate.Text) Then
            state = Me.Combostate.Text.Trim
            d = Me.DateTimePicker1.Value.Date
            d = Replace(d, "/", "-")
            Dim f As String = "fDate=" + d + "&fType=" + state
            Dim result As String = request(url, f)
            Dim jsonObj As JObject = JObject.Parse(result)
            Dim str As String = ""
            Dim x As Integer = jsonObj.First
            x -= 1
            Dim entityX As New List(Of person)
            Dim ds As New DataSet
            For i = 0 To x Step 1
                Dim entity As New person
                entity.Flightnum = jsonObj("records").Item(i)("Flightnum").ToString()
                entity.Corp = jsonObj("records").Item(i)("Corp").ToString()
                entity.Plane = jsonObj("records").Item(i)("Plane").ToString()
                entity.Planen = jsonObj("records").Item(i)("Planen").ToString()
                entity.City = jsonObj("records").Item(i)("City").ToString()
                entity.Cityx = jsonObj("records").Item(i)("Cityx").ToString()
                entity.Etd = jsonObj("records").Item(i)("Etd").ToString()
                entity.Eta = jsonObj("records").Item(i)("Eta").ToString()
                entity.Atd = jsonObj("records").Item(i)("Atd").ToString()
                entity.Ata = jsonObj("records").Item(i)("Ata").ToString()
                entity.State = jsonObj("records").Item(i)("State").ToString()
                entity.ApplyTime = jsonObj("records").Item(i)("ApplyTime").ToString()
                entityX.Add(entity)
            Next
            If Me.Textnum.Text <> "" Then
                Dim search As String = Me.Textnum.Text
                Dim entityV As New List(Of person)
                For i = 0 To x Step 1
                    Dim u As String = entityX(i).Flightnum.ToString
                    u = Regex.Replace(u, "[a-zA-Z]", "")
                    If search = u Then
                        entityV.Add(entityX(i))
                    End If
                Next
                Me.myDGV.DataSource = entityV
            Else
                Me.myDGV.DataSource = entityX
            End If
            If Me.myDGV.Rows.Count > 0 Then
                Me.myDGV.CurrentCell = Nothing
            End If
            Me.txtMSG.Text = "合计(航班数)：" & entityX.Count & " 条"
            Me.myDGV.Columns.Item(0).Frozen = True
            Me.myDGV.Columns.Item(1).Frozen = True
        End If
    End Sub

    ''' <summary>
    ''' 复位查询条件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            Me.myDGV.DataSource = Nothing
            Me.txtMSG.Text = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    ''' <summary>
    ''' 数据请求
    ''' </summary>
    ''' <param name="url"></param>
    ''' <param name="f"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function request(ByRef url As String, ByRef f As String) As String
        Try
            Dim strURL As String = url
            Dim Arequest As System.Net.HttpWebRequest
            Arequest = System.Net.HttpWebRequest.Create(strURL)
            Arequest.Method = "post"
            Arequest.ContentType = "application/x-www-form-urlencoded"
            Arequest.Timeout = 100000
            Arequest.KeepAlive = False
            Arequest.CookieContainer = New Net.CookieContainer
            Net.ServicePointManager.DefaultConnectionLimit = 200
            ' 添加header
            Dim paraUrlCoded As String = f
            Dim fDate As Byte()
            fDate = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded)
            Arequest.ContentLength = fDate.Length
            System.GC.Collect()
            Arequest.Proxy = Nothing
            Dim writer As Stream = Arequest.GetRequestStream()
            writer.Write(fDate, 0, fDate.Length)
            writer.Flush()
            writer.Close()
            Dim response As System.Net.HttpWebResponse = Arequest.GetResponse()
            Dim s As System.IO.Stream = Arequest.GetResponse.GetResponseStream()
            Dim StrDate As String = ""
            Dim strValue As String = ""
            Dim Reader As StreamReader = New StreamReader(s, System.Text.Encoding.UTF8)
            strValue = Reader.ReadLine()
            Return strValue
        Catch ex As System.Net.ProtocolViolationException
            MessageBox.Show(ex.Message)
            Return String.Empty
        End Try
    End Function

    ''' <summary>
    ''' 添加表头
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AddDgvColumns()
        With Me.myDGV
            .Columns.Clear()
            Dim checkboxcolumn As New DataGridViewCheckBoxColumn()
            .Columns.Add(checkboxcolumn)
            .Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Item(0).FillWeight = 5

            .AutoGenerateColumns = False
            .Columns.Add("FlightNum", "航班号")
            .Columns("Flightnum").DataPropertyName = "Flightnum"
            .Columns("Flightnum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Flightnum").FillWeight = 30
            .Columns("Flightnum").ReadOnly = True
            If ChkFlightnum.Checked = False Then
                .Columns("Flightnum").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("Corp", "航空公司三字码")
            .Columns("Corp").DataPropertyName = "Corp"
            .Columns("Corp").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Corp").FillWeight = 30
            .Columns("Corp").ReadOnly = True
            If ChkCorp.Checked = False Then
                .Columns("Corp").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("Plane", "机型")
            .Columns("Plane").DataPropertyName = "Plane"
            .Columns("Plane").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Plane").FillWeight = 30
            .Columns("Plane").ReadOnly = True
            If ChkPlane.Checked = False Then
                .Columns("Plane").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("Planen", "机号")
            .Columns("Planen").DataPropertyName = "Planen"
            .Columns("Planen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Planen").FillWeight = 30
            .Columns("Planen").ReadOnly = True
            If ChkPlanen.Checked = False Then
                .Columns("Planen").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("City", "起飞机场")
            .Columns("City").DataPropertyName = "City"
            .Columns("City").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("City").FillWeight = 30
            .Columns("City").ReadOnly = True
            If ChkCity.Checked = False Then
                .Columns("City").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("Cityx", "落地机场")
            .Columns("Cityx").DataPropertyName = "Cityx"
            .Columns("Cityx").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Cityx").FillWeight = 30
            .Columns("Cityx").ReadOnly = True
            If ChkCityx.Checked = False Then
                .Columns("Cityx").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("Etd", "计划起飞")
            .Columns("Etd").DataPropertyName = "Etd"
            .Columns("Etd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Etd").FillWeight = 30
            .Columns("Etd").ReadOnly = True
            If ChkEtd.Checked = False Then
                .Columns("Etd").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("Atd", "实际起飞")
            .Columns("Atd").DataPropertyName = "Atd"
            .Columns("Atd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Atd").FillWeight = 30
            .Columns("Atd").ReadOnly = True
            If ChkAtd.Checked = False Then
                .Columns("Atd").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("Eta", "计划到达")
            .Columns("Eta").DataPropertyName = "Eta"
            .Columns("Eta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Eta").FillWeight = 30
            .Columns("Eta").ReadOnly = True
            If ChkEta.Checked = False Then
                .Columns("Eta").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("Ata", "实际到达")
            .Columns("Ata").DataPropertyName = "Ata"
            .Columns("Ata").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Ata").FillWeight = 30
            .Columns("Ata").ReadOnly = True
            If ChkAta.Checked = False Then
                .Columns("Ata").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("State", "航班状态")
            .Columns("State").DataPropertyName = "State"
            .Columns("State").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("State").FillWeight = 30
            .Columns("State").ReadOnly = True
            If ChkState.Checked = False Then
                .Columns("State").Visible = False
            End If

            .AutoGenerateColumns = False
            .Columns.Add("ApplyTime", "计算时间(CTOT)")
            .Columns("ApplyTime").DataPropertyName = "ApplyTime"
            .Columns("ApplyTime").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("ApplyTime").FillWeight = 30
            .Columns("ApplyTime").ReadOnly = True
            If ChkApplyTime.Checked = False Then
                .Columns("ApplyTime").Visible = False
            End If

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    ''' <summary>
    ''' Gridview表头状态控制
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub a(sender As Object, e As EventArgs) Handles myDGV.SizeChanged
        If Me.WindowState = FormWindowState.Maximized Then
            Me.myDGV.Columns.Item(0).Frozen = False
            Me.myDGV.Columns.Item(1).Frozen = False
            Me.myDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Me.myDGV.Columns.Item(0).Frozen = True
            Me.myDGV.Columns.Item(1).Frozen = True
        Else
            Me.myDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Me.myDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        End If
    End Sub

    ''' <summary>
    ''' 行号
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub myDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles myDGV.RowPostPaint
        DgvSerNumber(sender, e)
    End Sub

    Public Sub DgvSerNumber(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
        Try
            Dim dgv As DataGridView = CType(sender, DataGridView)

            Dim rect As Rectangle = New Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height)

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rect, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter Or TextFormatFlags.Right)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "绘制序号")
        End Try
    End Sub

    ''' <summary>
    ''' 设置控制
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolsbInsert_Click(sender As Object, e As EventArgs) Handles ToolsbInsert.Click
        Me.Panel1.Visible = True
    End Sub

    Private Sub NO_Click(sender As Object, e As EventArgs) Handles NO.Click
        Me.Panel1.Visible = False
    End Sub

    ''' <summary>
    ''' 自定义列
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim xx As String = ""

        If ChkFlightnum.Checked = False Then
            myDGV.Columns("Flightnum").Visible = False
            xx += "myDGV.Columns(" + """Flightnum""" + ").Visible = False" + vbCrLf
            My.Settings.ChkFlightnum = False
        Else
            myDGV.Columns("Flightnum").Visible = True
            My.Settings.ChkFlightnum = True
        End If

        If ChkCorp.Checked = False Then
            myDGV.Columns("Corp").Visible = False
            xx += "myDGV.Columns(" + """Corp""" + ").Visible = False" + vbCrLf
            My.Settings.ChkCorp = False
        Else
            myDGV.Columns("Corp").Visible = True
            My.Settings.ChkCorp = True
        End If

        If ChkPlane.Checked = False Then
            myDGV.Columns("Plane").Visible = False
            xx += "myDGV.Columns(" + """Plane""" + ").Visible = False" + vbCrLf
            My.Settings.ChkPlane = False
        Else
            myDGV.Columns("Plane").Visible = True
            My.Settings.ChkPlane = True
        End If

        If ChkPlanen.Checked = False Then
            myDGV.Columns("Planen").Visible = False
            xx += "myDGV.Columns(" + """Planen""" + ").Visible = False" + vbCrLf
            My.Settings.ChkPlanen = False
        Else
            myDGV.Columns("Planen").Visible = True
            My.Settings.ChkPlanen = True
        End If

        If ChkCity.Checked = False Then
            myDGV.Columns("City").Visible = False
            xx += "myDGV.Columns(" + """City""" + ").Visible = False" + vbCrLf
            My.Settings.ChkCity = False
        Else
            myDGV.Columns("City").Visible = True
            My.Settings.ChkCity = True
        End If

        If ChkCityx.Checked = False Then
            myDGV.Columns("Cityx").Visible = False
            xx += "myDGV.Columns(" + """Cityx""" + ").Visible = False" + vbCrLf
            My.Settings.ChkCityx = False
        Else
            myDGV.Columns("Cityx").Visible = True
            My.Settings.ChkCityx = True
        End If

        If ChkEtd.Checked = False Then
            myDGV.Columns("Etd").Visible = False
            xx += "myDGV.Columns(" + """Etd""" + ").Visible = False" + vbCrLf
            My.Settings.ChkEtd = False
        Else
            myDGV.Columns("Etd").Visible = True
            My.Settings.ChkEtd = True
        End If

        If ChkEta.Checked = False Then
            myDGV.Columns("Eta").Visible = False
            xx += "myDGV.Columns(" + """Eta""" + ").Visible = False" + vbCrLf
            My.Settings.ChkEta = False
        Else
            myDGV.Columns("Eta").Visible = True
            My.Settings.ChkEta = True
        End If

        If ChkAtd.Checked = False Then
            myDGV.Columns("Atd").Visible = False
            xx += "myDGV.Columns(" + """Atd""" + ").Visible = False" + vbCrLf
            My.Settings.ChkAtd = False
        Else
            myDGV.Columns("Atd").Visible = True
            My.Settings.ChkAtd = True
        End If

        If ChkAta.Checked = False Then
            myDGV.Columns("Ata").Visible = False
            xx += "myDGV.Columns(" + """Ata""" + ").Visible = False" + vbCrLf
            My.Settings.ChkAta = False
        Else
            myDGV.Columns("Ata").Visible = True
            My.Settings.ChkAta = True
        End If

        If ChkApplyTime.Checked = False Then
            myDGV.Columns("ApplyTime").Visible = False
            xx += "myDGV.Columns(" + """ApplyTime""" + ").Visible = False" + vbCrLf
            My.Settings.ChkApplyTime = False
        Else
            myDGV.Columns("ApplyTime").Visible = True
            My.Settings.ChkApplyTime = True
        End If

        If ChkState.Checked = False Then
            myDGV.Columns("State").Visible = False
            xx += "myDGV.Columns(" + """State""" + ").Visible = False" + vbCrLf
            My.Settings.ChkState = False
        Else
            myDGV.Columns("State").Visible = True
            My.Settings.ChkState = True
        End If

        File.WriteAllText("c:\xx.txt", xx)
        Me.Panel1.Visible = False
    End Sub

End Class
