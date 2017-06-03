''' <summary>
''' 航班表
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class person
#Region "属性"
    Public Sub New()
        _Flightnum = String.Empty
        _Corp = String.Empty
        _Plane = String.Empty
        _Planen = String.Empty
        _City = String.Empty
        _Cityx = String.Empty
        _Etd = String.Empty
        _Eta = String.Empty
        _Atd = String.Empty
        _Ata = String.Empty
        _State = String.Empty
        _ApplyTime = String.Empty

    End Sub

    Private _Flightnum As String
    ''' <summary>
    ''' 航班号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Flightnum() As String
        Get
            Return _Flightnum
        End Get
        Set(ByVal Value As String)
            _Flightnum = Value
        End Set
    End Property

    Private _Corp As String
    ''' <summary>
    ''' 航空公司三字码
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Corp() As String
        Get
            Return _Corp
        End Get
        Set(ByVal Value As String)
            _Corp = Value
        End Set
    End Property

    Private _City As String
    ''' <summary>
    ''' 起飞机场
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal Value As String)
            _City = Value
        End Set
    End Property

    Private _Planen As String
    ''' <summary>
    ''' 机号
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Planen() As String
        Get
            Return _Planen
        End Get
        Set(ByVal Value As String)
            _Planen = Value
        End Set
    End Property

    Private _Plane As String
    ''' <summary>
    ''' 机型
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Plane() As String
        Get
            Return _Plane
        End Get
        Set(ByVal Value As String)
            _Plane = Value
        End Set
    End Property

    Private _Cityx As String
    ''' <summary>
    ''' 落地机场
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cityx() As String
        Get
            Return _Cityx
        End Get
        Set(ByVal Value As String)
            _Cityx = Value
        End Set
    End Property

    Private _Etd As String
    ''' <summary>
    ''' 计划起飞时间
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Etd() As String
        Get
            Return _Etd
        End Get
        Set(ByVal Value As String)
            _Etd = Value
        End Set
    End Property

    Private _Eta As String
    ''' <summary>
    ''' 计划到达时间
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Eta() As String
        Get
            Return _Eta
        End Get
        Set(ByVal Value As String)
            _Eta = Value
        End Set
    End Property

    Private _Atd As String
    ''' <summary>
    ''' 实际起飞时间
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Atd() As String
        Get
            Return _Atd
        End Get
        Set(ByVal Value As String)
            _Atd = Value
        End Set
    End Property

    Private _Ata As String
    ''' <summary>
    ''' 实际到达时间
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Ata() As String
        Get
            Return _Ata
        End Get
        Set(ByVal Value As String)
            _Ata = Value
        End Set
    End Property

    Private _State As String
    ''' <summary>
    ''' 航班状态
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property State() As String
        Get
            Return _State
        End Get
        Set(ByVal Value As String)
            _State = Value
        End Set
    End Property

    Private _ApplyTime As String
    ''' <summary>
    ''' 计算时间(CTOT)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ApplyTime() As String
        Get
            Return _ApplyTime
        End Get
        Set(ByVal Value As String)
            _ApplyTime = Value
        End Set
    End Property
#End Region

#Region "枚举/方法"
    ''' <summary>
    ''' 审批状态名称
    ''' </summary>
    ''' <param name="Status"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function StatusName(ByVal Status As String) As String
        Dim Name As String = String.Empty

        Select Case Status
            Case "0"
                Name = "未审批"
            Case "1"
                Name = "通过"
            Case "2"
                Name = "暂停使用"
            Case "3"
                Name = "退单"
        End Select

        Return Name
    End Function
#End Region
End Class
