Imports System
Imports System.Drawing

Namespace Processing.Data

    Public Class HtmlDocument
        Private vListHtmlObject As New List(Of Object)

#Region "Data Process"

        Public Sub AddTitleAndContent(Title As String, Content As String, Optional FontName As String = "Arial", Optional FontSize As Single = 11, Optional TitleFontBold As Boolean = False, Optional TitleFontUnderline As Boolean = False, Optional TitleFontItalic As Boolean = False, Optional TitleFontColor As Drawing.Color = Nothing, Optional ContentFontColor As Drawing.Color = Nothing, Optional TitleEnter As Boolean = False, Optional HideContentNull As Boolean = False)
            If Not (Content = "" AndAlso HideContentNull) Then
                Dim HtmlParagraph As New HtmlParagraph
                HtmlParagraph.AddContent(Title, FontName, FontSize, TitleFontBold, TitleFontUnderline, TitleFontItalic, TitleFontColor, TitleEnter)
                HtmlParagraph.AddContent(Content, FontName, FontSize, False, False, False, ContentFontColor, False)
                vListHtmlObject.Add(HtmlParagraph)
            End If
        End Sub

        Public Sub AddParagraph(Content As String, Optional FontName As String = "Arial", Optional FontSize As Single = 11, Optional FontBold As Boolean = False, Optional FontUnderline As Boolean = False, Optional FontItalic As Boolean = False, Optional FontColor As Drawing.Color = Nothing, Optional MarginTop As Single = 6, Optional MarginBottom As Single = 0, Optional MarginLeft As Single = 0, Optional MarginRight As Single = 0, Optional BorderTop As Boolean = False, Optional BorderBottom As Boolean = False, Optional BorderLeft As Boolean = False, Optional BorderRight As Boolean = False, Optional BorderColor As Drawing.Color = Nothing, Optional BorderLineWidth As Single = 1)
            Dim HtmlParagraph As New HtmlParagraph
            HtmlParagraph.AddContent(Content, FontName, FontSize, FontBold, FontUnderline, FontItalic, FontColor)
            HtmlParagraph.MarginTop = MarginTop
            HtmlParagraph.MarginBottom = MarginBottom
            HtmlParagraph.MarginLeft = MarginLeft
            HtmlParagraph.MarginRight = MarginRight
            HtmlParagraph.BorderTop = BorderTop
            HtmlParagraph.BorderBottom = BorderBottom
            HtmlParagraph.BorderLeft = BorderLeft
            HtmlParagraph.BorderRight = BorderRight
            HtmlParagraph.BorderColor = BorderColor
            HtmlParagraph.BorderLineWidth = BorderLineWidth
            vListHtmlObject.Add(HtmlParagraph)
        End Sub

        Public Sub AddParagraph(ByVal HtmlParagraph As HtmlParagraph)
            vListHtmlObject.Add(HtmlParagraph)
        End Sub

        Public Sub AddContent(Content As String, Optional FontName As String = "Arial", Optional FontSize As Single = 11, Optional FontBold As Boolean = False, Optional FontUnderline As Boolean = False, Optional FontItalic As Boolean = False, Optional FontColor As Drawing.Color = Nothing)
            Dim HtmlContent As New HtmlContent
            HtmlContent.Content = Content
            HtmlContent.FontName = FontName
            HtmlContent.FontSize = FontSize
            HtmlContent.FontBold = FontBold
            HtmlContent.FontUnderline = FontUnderline
            HtmlContent.FontItalic = FontItalic
            HtmlContent.FontColor = FontColor
            vListHtmlObject.Add(HtmlContent)
        End Sub

        Public Sub AddContent(ByVal HtmlContent As HtmlContent)
            vListHtmlObject.Add(HtmlContent)
        End Sub

        Public Sub AddImage(ByVal HtmlImage As HtmlImage)
            vListHtmlObject.Add(HtmlImage)
        End Sub

        Public Function AddImage(Link As String) As HtmlImage
            Dim HtmlImage As New HtmlImage(Link)
            vListHtmlObject.Add(HtmlImage)
            Return HtmlImage
        End Function

        Public Function AddImage(BinaryData As Byte()) As HtmlImage
            Dim HtmlImage As New HtmlImage(BinaryData)
            vListHtmlObject.Add(HtmlImage)
            Return HtmlImage
        End Function

        Public Function AddImage(SelectCommand As String, PrimaryKeyValue As String, IsSystemDatabase As Boolean) As HtmlImage
            Dim HtmlImage As New HtmlImage(SelectCommand, PrimaryKeyValue, IsSystemDatabase)
            vListHtmlObject.Add(HtmlImage)
            Return HtmlImage
        End Function

        Public Function AddImage(TableName As String, PropertyFileData As String, PropertyPrimaryKey As String, PrimaryKeyValue As String, IsSystemDatabase As Boolean) As HtmlImage
            Dim HtmlImage As New HtmlImage(TableName, PropertyFileData, PropertyPrimaryKey, PrimaryKeyValue, IsSystemDatabase)
            vListHtmlObject.Add(HtmlImage)
            Return HtmlImage
        End Function

        Public Sub AddTable(ByVal HtmlTable As HtmlTable)
            vListHtmlObject.Add(HtmlTable)
        End Sub

        'Public Sub AddTable(ByVal DataSource As DataTable)
        '    Dim HtmlTable As New HtmlTable
        '    HtmlTable.DataSource = DataSource
        '    vListHtmlObject.Add(HtmlTable)
        'End Sub

        Public ReadOnly Property HtmlCode As String
            Get
                Dim Result As String = ""
                Result += " <!DOCTYPE html>" + vbNewLine
                Result += "<html>" + vbNewLine
                Result += "<body>" + vbNewLine

                For Each HtmlObject As Object In vListHtmlObject
                    If TypeOf (HtmlObject) Is HtmlParagraph Then
                        Dim HtmlParagraph As HtmlParagraph = HtmlObject
                        Result += HtmlParagraph.HtmlCode + vbNewLine

                    ElseIf TypeOf (HtmlObject) Is HtmlContent Then
                        Dim HtmlContent As HtmlContent = HtmlObject
                        Result += HtmlContent.HtmlCode + vbNewLine

                    ElseIf TypeOf (HtmlObject) Is HtmlImage Then
                        Dim HtmlImage As HtmlImage = HtmlObject
                        Result += HtmlImage.HtmlCode + vbNewLine

                    ElseIf TypeOf (HtmlObject) Is HtmlTable Then
                        Dim HtmlTable As HtmlTable = HtmlObject
                        Result += HtmlTable.HtmlCode + vbNewLine

                    End If
                Next

                Result += "</body>" + vbNewLine
                Result += "</html>" + vbNewLine
                Return Result
            End Get
        End Property
#End Region

    End Class

    Public Class HtmlParagraph
        Private vListOfContent As New List(Of HtmlContent)

        Private vBorderColor As Drawing.Color = Color.Empty
        Private vBorderLineWidth As Single = 1
        Private vBorderTop As Boolean
        Private vBorderBottom As Boolean
        Private vBorderLeft As Boolean
        Private vBorderRight As Boolean

        Private vMarginTop As Single = 6
        Private vMarginBottom As Single = 0
        Private vMarginLeft As Single = 0
        Private vMarginRight As Single = 0

#Region "Data Property"

        Public Property BorderColor As Drawing.Color
            Get
                Return vBorderColor
            End Get
            Set(ByVal value As Drawing.Color)
                vBorderColor = value
            End Set
        End Property

        Public Property BorderLineWidth As Single
            Get
                Return vBorderLineWidth
            End Get
            Set(ByVal value As Single)
                vBorderLineWidth = value
            End Set
        End Property

        Public Property BorderTop As Boolean
            Get
                Return vBorderTop
            End Get
            Set(ByVal value As Boolean)
                vBorderTop = value
            End Set
        End Property

        Public Property BorderBottom As Boolean
            Get
                Return vBorderBottom
            End Get
            Set(ByVal value As Boolean)
                vBorderBottom = value
            End Set
        End Property

        Public Property BorderLeft As Boolean
            Get
                Return vBorderLeft
            End Get
            Set(ByVal value As Boolean)
                vBorderLeft = value
            End Set
        End Property

        Public Property BorderRight As Boolean
            Get
                Return vBorderRight
            End Get
            Set(ByVal value As Boolean)
                vBorderRight = value
            End Set
        End Property

        Public Property MarginTop As Single
            Get
                Return vMarginTop
            End Get
            Set(ByVal value As Single)
                vMarginTop = value
            End Set
        End Property

        Public Property MarginBottom As Single
            Get
                Return vMarginBottom
            End Get
            Set(ByVal value As Single)
                vMarginBottom = value
            End Set
        End Property

        Public Property MarginLeft As Single
            Get
                Return vMarginLeft
            End Get
            Set(ByVal value As Single)
                vMarginLeft = value
            End Set
        End Property

        Public Property MarginRight As Single
            Get
                Return vMarginRight
            End Get
            Set(ByVal value As Single)
                vMarginRight = value
            End Set
        End Property

#End Region

#Region "Data Process"

        Public Sub AddContent(HtmlContent As HtmlContent)
            vListOfContent.Add(HtmlContent)
        End Sub

        Public Sub AddContent(Content As String, Optional FontName As String = "Arial", Optional FontSize As Single = 11, Optional FontBold As Boolean = False, Optional FontUnderline As Boolean = False, Optional FontItalic As Boolean = False, Optional FontColor As Drawing.Color = Nothing, Optional FontEnter As Boolean = False)
            Dim HtmlContent As New HtmlContent
            HtmlContent.Content = Content
            HtmlContent.FontName = FontName
            HtmlContent.FontSize = FontSize
            HtmlContent.FontBold = FontBold
            HtmlContent.FontUnderline = FontUnderline
            HtmlContent.FontItalic = FontItalic
            HtmlContent.FontColor = FontColor
            HtmlContent.FontEnter = FontEnter
            vListOfContent.Add(HtmlContent)
        End Sub

        Public ReadOnly Property HtmlCode() As String
            Get
                Dim Result As String = ""
                Dim ParagraphContent As String = ""

                For Each Content As HtmlContent In vListOfContent
                    ParagraphContent += Content.HtmlCode + vbNewLine
                Next

                If ParagraphContent <> "" Then
                    Dim ParagraphCode As String = "<p class=MsoNormal style='margin-top:0.0pt;margin-right:0.0pt;margin-bottom:0.0pt;margin-left:0.0pt;margin-bottom:0.0pt;line-height:normal;layout-grid-mode:char'>{0}</p>"
                    ParagraphCode = Replace(ParagraphCode, "{0}", ParagraphContent)

                    If vBorderTop = False Then
                        ParagraphCode = Replace(ParagraphCode, "margin-top:0.0pt", String.Format("margin-top:{0}pt", vMarginTop))
                    End If

                    If vBorderBottom = False Then
                        ParagraphCode = Replace(ParagraphCode, "margin-bottom:0.0pt", String.Format("margin-bottom:{0}pt", vMarginBottom))
                    End If

                    If vBorderLeft = False Then
                        ParagraphCode = Replace(ParagraphCode, "margin-left:0.0pt", String.Format("margin-left:{0}pt", vMarginLeft))
                    Else
                        ParagraphCode = Replace(ParagraphCode, "margin-left:0.0pt", String.Format("margin-left:{0}pt", 5))
                    End If

                    If vBorderRight = False Then
                        ParagraphCode = Replace(ParagraphCode, "margin-right:0.0pt", String.Format("margin-right:{0}pt", vMarginRight))
                    Else
                        ParagraphCode = Replace(ParagraphCode, "margin-right:0.0pt", String.Format("margin-right:{0}pt", 5))
                    End If

                    If vBorderTop OrElse vBorderBottom OrElse vBorderLeft OrElse vBorderRight Then
                        Dim BorderCode As String = "<div style='border:none;border-top:solid #4F81BD 1.0pt;border-bottom:solid #4F81BD 1.0pt;border-left:solid #4F81BD 1.0pt;border-right:solid #4F81BD 1.0pt;padding: 0pt 0pt 0pt 0pt;margin-top:0.0pt;margin-right:0.0pt;margin-bottom:0.0pt;margin-left:0.0pt;margin-bottom:0.0pt'>"

                        BorderCode = Replace(BorderCode, "margin-left:0.0pt", String.Format("margin-left:{0}pt", vMarginLeft))
                        BorderCode = Replace(BorderCode, "margin-right:0.0pt", String.Format("margin-right:{0}pt", vMarginRight))

                        If vBorderTop = False Then
                            BorderCode = Replace(BorderCode, "border-top:solid #4F81BD 1.0pt;", "")
                        Else
                            BorderCode = Replace(BorderCode, "margin-top:0.0pt", String.Format("margin-top:{0}pt", vMarginTop))
                        End If

                        If vBorderBottom = False Then
                            BorderCode = Replace(BorderCode, "border-bottom:solid #4F81BD 1.0pt;", "")
                        Else
                            BorderCode = Replace(BorderCode, "margin-bottom:0.0pt", String.Format("margin-bottom:{0}pt", vMarginBottom))
                        End If

                        If vBorderLeft = False Then
                            BorderCode = Replace(BorderCode, "border-left:solid #4F81BD 1.0pt;", "")
                        End If

                        If vBorderRight = False Then
                            BorderCode = Replace(BorderCode, "border-right:solid #4F81BD 1.0pt;", "")
                        End If

                        If vBorderColor <> Color.Empty Then
                            Dim Color As String = ColorTranslator.ToHtml(vBorderColor)
                            BorderCode = Replace(BorderCode, "#4F81BD", Color)
                        End If

                        BorderCode = Replace(BorderCode, "1.0pt", String.Format("{0}pt", BorderLineWidth))
                        Result = BorderCode + ParagraphCode + "</div>"
                    Else
                        Result = ParagraphCode
                    End If
                End If
                Return Result
            End Get
        End Property

#End Region


    End Class

    Public Class HtmlContent
        Private vContent As String = ""
        Private vFontName As String = "Arial"
        Private vFontSize As Single = 11
        Private vFontBold As Boolean = False
        Private vFontUnderline As Boolean = False
        Private vFontItalic As Boolean = False
        Private vFontColor As Drawing.Color = Color.Empty
        Private vFontEnter As Boolean = False

#Region "Data Property"

        Public Property Content As String
            Get
                Return vContent
            End Get
            Set(ByVal value As String)
                vContent = value
            End Set
        End Property

        Public Property FontName As String
            Get
                Return vFontName
            End Get
            Set(ByVal value As String)
                vFontName = value
            End Set
        End Property

        Public Property FontSize As Single
            Get
                Return vFontSize
            End Get
            Set(ByVal value As Single)
                vFontSize = value
            End Set
        End Property

        Public Property FontBold As Boolean
            Get
                Return vFontBold
            End Get
            Set(ByVal value As Boolean)
                vFontBold = value
            End Set
        End Property

        Public Property FontUnderline As Boolean
            Get
                Return vFontUnderline
            End Get
            Set(ByVal value As Boolean)
                vFontUnderline = value
            End Set
        End Property

        Public Property FontItalic As Boolean
            Get
                Return vFontItalic
            End Get
            Set(ByVal value As Boolean)
                vFontItalic = value
            End Set
        End Property

        Public Property FontColor As Drawing.Color
            Get
                Return vFontColor
            End Get
            Set(ByVal value As Drawing.Color)
                vFontColor = value
            End Set
        End Property

        Public Property FontEnter As Boolean
            Get
                Return vFontEnter
            End Get
            Set(ByVal value As Boolean)
                vFontEnter = value
            End Set
        End Property

        Public ReadOnly Property HtmlCode() As String
            Get
                Dim Result As String = ""

                If vContent <> "" Then
                    Dim Content As String = vContent
                    Me.ReplaceSpecialChar(Content)
                    Me.ReplaceLeftSpace(Content)

                    Dim ContentCode As String = "<span style='font-size: 10.0pt;font-family:""Arial"",""sans-serif"";color:#376092'><b><i><u>{0}</b></i></u></span><br>"
                    ContentCode = Replace(ContentCode, "font-family:""Arial"",""sans-serif""", String.Format("font-family:""{0}"",""sans-serif""", vFontName))
                    ContentCode = Replace(ContentCode, "font-size: 10.0pt", String.Format("font-size: {0}pt", vFontSize))
                    ContentCode = Replace(ContentCode, "{0}", Content)

                    If vFontBold = False Then
                        ContentCode = Replace(ContentCode, "<b>", "")
                        ContentCode = Replace(ContentCode, "</b>", "")
                    End If

                    If vFontItalic = False Then
                        ContentCode = Replace(ContentCode, "<i>", "")
                        ContentCode = Replace(ContentCode, "</i>", "")
                    End If

                    If vFontUnderline = False Then
                        ContentCode = Replace(ContentCode, "<u>", "")
                        ContentCode = Replace(ContentCode, "</u>", "")
                    End If

                    If vFontColor = Color.Empty Then
                        ContentCode = Replace(ContentCode, ";color:#376092", "")
                    Else
                        Dim Color As String = ColorTranslator.ToHtml(vFontColor)
                        ContentCode = Replace(ContentCode, ";color:#376092", String.Format(";color:{0}", Color))
                    End If

                    If vFontEnter = False Then
                        ContentCode = Replace(ContentCode, "<br>", "")
                    End If

                    Result = ContentCode
                End If
                Return Result
            End Get
        End Property

#End Region

#Region "Data Process"
        Private Sub ReplaceSpecialChar(ByRef Content As String)
            Content = Replace(Content, """", "&quot;")
            Content = Replace(Content, "<", "&lt;")
            Content = Replace(Content, ">", "&gt;")
        End Sub

        Private Sub ReplaceLeftSpace(ByRef Content As String)
            Dim NewParagraph As String = LTrim(Content)
            Dim Space As String = ""
            If Content.Length > NewParagraph.Length Then
                Space = Content.Substring(0, Content.Length - NewParagraph.Length)
                Space = Replace(Space, " ", "&nbsp;")
                Content = Space + NewParagraph
            End If
        End Sub

#End Region


    End Class

    Public Class HtmlContentSqlCode

    End Class

    Public Class HtmlContentVisualBaiscCode
        Private vVisualBaiscContent As String = ""
        Private vVisualBaiscKeyWord() As String = New String() {"AddHandler", "AddressOf", "Alias", "And", "AndAlso", "As", "Boolean", "ByRef", "Byte", "ByVal", "Call", "Case", "Catch", "CBool", "CByte", "CChar", "CDate", "CDec", "CDbl", "Char", "CInt", "Class", "CLng", "CObj", "Const""Continue", "CSByte", "CShort", "CSng", "CStr", "CType", "CUInt", "CULng", "CUShort", "Date", "Decimal", "Declare", "Default", "Delegate", "Dim", "DirectCast", "Do", "Double", "Each", "Else", "ElseIf", "End", "EndIf", "Enum", "Erase", "Error", "Event", "Exit", "False", "Finally", "For", "Friend", "Function", "Get", "GetType", "GetXMLNamespace", "Global", "Go", "GoTo", "Sub", "To", "Handles", "If", "Implements", "Imports", "In", "Inherits", "Integer", "Interface", "Is", "IsNot", "Let", "Lib", "Like", "Long", "Loop", "Me", "Mod", "Module", "MustInherit", "MustOverride", "MyBase", "MyClass", "Namespace", "Narrowing", "New", "Next", "Not", "Nothing", "NotInheritable", "NotOverridable", "Object", "Of", "On", "Operator", "Option", "Optional", "Or", "OrElse", "Overloads", "Overridable", "Overrides", "ParamArray", "Partial", "Private", "Property", "Protected", "Public", "RaiseEvent", "ReadOnly", "ReDim", "REM", "RemoveHandler", "Resume", "Return", "SByte", "Select", "Set", "Shadows", "Shared", "Short", "Single", "Static", "Step", "Stop", "String", "Structure", "Sub", "SyncLock", "Then", "Throw", "To", "True", "Try", "TryCast", "TypeOf", "Variant", "Wend", "UInteger", "ULong", "UShort", "Using", "When", "While", "Widening", "With", "WithEvents", "WriteOnly", "Xor", "#Const", "#Else", "#ElseIf", "#End", "#If", "#Region"}

#Region "Data Property"

        Public Property VisualBaiscContent As String
            Get
                Return vVisualBaiscContent
            End Get
            Set(ByVal value As String)
                vVisualBaiscContent = value
            End Set
        End Property

        Public ReadOnly Property HtmlCode() As String
            Get
                Dim Content As String = vVisualBaiscContent
                Me.ReplaceLeftSpace(Content)
                Me.ReplaceSpecialChar(Content)

                Dim SplitList As List(Of String) = eBOSS.Core.Functions.String.SplitTextToList(Content, " ")
                If SplitList.Count > 1 Then
                    For Each KeyWord As String In SplitList
                        If vVisualBaiscKeyWord.Contains(KeyWord) Then
                            Content = Replace(Content, " " + KeyWord + " ", String.Format(" <span style='color:blue'>{0}</span> ", KeyWord))
                            Content = Replace(Content, KeyWord + " ", String.Format("<span style='color:blue'>{0}</span> ", KeyWord))
                            Content = Replace(Content, " " + KeyWord, String.Format(" <span style='color:blue'>{0}</span>", KeyWord))
                        End If
                    Next
                ElseIf SplitList.Count = 1 Then
                    Dim KeyWord As String = SplitList(0)
                    If vVisualBaiscKeyWord.Contains(KeyWord) Then
                        Content = Replace(Content, " " + KeyWord + " ", String.Format(" <span style='color:blue'>{0}</span> ", KeyWord))
                        Content = Replace(Content, KeyWord + " ", String.Format("<span style='color:blue'>{0}</span> ", KeyWord))
                        Content = Replace(Content, " " + KeyWord, String.Format(" <span style='color:blue'>{0}</span>", KeyWord))
                    End If
                End If

                If Content.Contains("&quot;") Then
                    Dim PharseList As List(Of String) = eBOSS.Core.Functions.String.SplitTextToList(Content, "&quot;")
                    If PharseList.Count > 1 Then
                        For Index As Integer = 0 To PharseList.Count - 1
                            If Index Mod 2 = 1 Then
                                Dim Pharse As String = "&quot;" + PharseList(Index) + "&quot;"
                                Content = Replace(Content, Pharse, String.Format("<span style='color:red'>{0}</span>", Pharse))
                            End If
                        Next
                    End If
                End If

                If Content.Contains(" '/ ") Then
                    Dim PharseList As List(Of String) = eBOSS.Core.Functions.String.SplitTextToList(Content, " '/ ")
                    If PharseList.Count > 1 Then
                        For Index As Integer = 0 To PharseList.Count - 1
                            If Index Mod 2 = 1 Then
                                Dim Pharse As String = " '/ " + PharseList(Index)
                                Content = Replace(Content, Pharse, String.Format("<span style='color:green'>{0}</span>", Pharse))
                            End If
                        Next
                    End If
                End If

                Return Content
            End Get
        End Property

#End Region

#Region "Data Process"
        Private Sub ReplaceSpecialChar(ByRef Content As String)
            Content = Replace(Content, """", "&quot;")
            Content = Replace(Content, "<", "&lt;")
            Content = Replace(Content, ">", "&gt;")
        End Sub

        Private Sub ReplaceLeftSpace(ByRef Content As String)
            Dim NewParagraph As String = LTrim(Content)
            Dim Space As String = ""
            If Content.Length > NewParagraph.Length Then
                Space = Content.Substring(0, Content.Length - NewParagraph.Length)
                Space = Replace(Space, " ", "&nbsp;")
                Content = Space + NewParagraph
            End If
        End Sub

#End Region

    End Class

    Public Class HtmlTable
        Private vListCells As List(Of HtmlTableCell)
        Private vCellSpacing As Integer
        Private vCellPadding As Integer

        Public Sub New()

        End Sub

        Public Property CellSpacing As Integer
            Get
                Return vCellSpacing
            End Get
            Set(ByVal value As Integer)
                vCellSpacing = value
            End Set
        End Property

        Public Property CellPadding As Integer
            Get
                Return vCellPadding
            End Get
            Set(ByVal value As Integer)
                vCellPadding = value
            End Set
        End Property

        Public ReadOnly Property HtmlCode() As String
            Get
                Dim Result As String = "<span style ='font-size: 10.0pt;font-family:""Arial""'><table width = '100%' cellspacing='0' cellpadding='0'>" + vbNewLine
              
                If CellSpacing <> 0 Then
                    Result = Replace(Result, "cellspacing='0'", String.Format("cellspacing='{0}'"), vCellSpacing)
                Else
                    Result = Replace(Result, "cellspacing='0'", "")
                End If

                If CellPadding <> 0 Then
                    Result = Replace(Result, "cellpadding='0'", String.Format("cellpadding='{0}'"), vCellPadding)
                Else
                    Result = Replace(Result, "cellpadding='0'", "")
                End If

                Dim RowsContent As String = ""
                If vListCells.Count > 0 Then
                    Dim CheckRowIndex As Integer = vListCells(0).RowIndex
                    RowsContent += "<tr width='100%' height='100%'>" + vbNewLine

                    For Each Cell As HtmlTableCell In vListCells
                        If Cell.RowIndex = CheckRowIndex Then
                            RowsContent += Cell.HtmlCode + vbNewLine
                        Else
                            RowsContent += "</tr>" + vbNewLine
                            RowsContent += "<tr>" + vbNewLine
                            RowsContent += Cell.HtmlCode + vbNewLine
                            CheckRowIndex = Cell.RowIndex
                        End If
                    Next

                    RowsContent += "</tr>" + vbNewLine
                End If

                Result += RowsContent + vbNewLine

                Result &= "</table></span>" + vbNewLine

                Return Result
            End Get
        End Property

        Public Function AddCell(Value As String, RowIndex As Integer, Optional IsHeader As Boolean = False, Optional RowSpan As Integer = 1, Optional ColumnSpan As Integer = 1, Optional FontBold As Boolean = False) As HtmlTableCell
            Dim Result As New HtmlTableCell(Value, RowIndex, IsHeader:=IsHeader, RowSpan:=RowSpan, ColumnSpan:=ColumnSpan, FontBold:=FontBold)

            If vListCells Is Nothing Then
                vListCells = New List(Of HtmlTableCell)
            End If

            vListCells.Add(Result)

            Return Result
        End Function

    End Class

    Public Class HtmlTableCell
        Private vValue As String = ""
        Private vRowIndex As Integer = -1
        Private vIsHeader As Boolean = False
        Private vRowSpan As Integer
        Private vColumnSpan As Integer
        Private vWidth As Integer
        Private vHeight As Integer
        Private vHorizontalAlign As EnumAlign = EnumAlign.Left
        Private vVerticalAlign As EnumVAlign = EnumVAlign.Top
        Private vFontBold As Boolean

        Public Sub New(Value As String, RowIndex As Integer, Optional IsHeader As Boolean = False, Optional RowSpan As Integer = 1, Optional ColumnSpan As Integer = 1, Optional FontBold As Boolean = False)
            vValue = Value
            vRowIndex = RowIndex
            vRowSpan = RowSpan
            vColumnSpan = ColumnSpan
            vFontBold = FontBold
            vIsHeader = IsHeader
        End Sub

#Region "Data Property"

        Public Property Value As String
            Get
                Return vValue
            End Get
            Set(value As String)
                vValue = value
            End Set
        End Property

        Public Property RowIndex As Integer
            Get
                Return vRowIndex
            End Get
            Set(value As Integer)
                vRowIndex = value
            End Set
        End Property

        Public Property IsHeader As Boolean
            Get
                Return vIsHeader
            End Get
            Set(value As Boolean)
                vIsHeader = value
            End Set
        End Property

        Public Property ColumnSpan As Integer
            Get
                Return vColumnSpan
            End Get
            Set(value As Integer)
                vColumnSpan = value
            End Set
        End Property

        Public Property RowSpan As Integer
            Get
                Return vRowSpan
            End Get
            Set(value As Integer)
                vRowSpan = value
            End Set
        End Property

        Public Property Width As Integer
            Get
                Return vWidth
            End Get
            Set(value As Integer)
                vWidth = value
            End Set
        End Property

        Public Property Height As Integer
            Get
                Return vHeight
            End Get
            Set(value As Integer)
                vHeight = value
            End Set
        End Property

        Public Property HorizontalAlign As EnumAlign
            Get
                Return vHorizontalAlign
            End Get
            Set(value As EnumAlign)
                vHorizontalAlign = value
            End Set
        End Property

        Public Property VerticalAlign As EnumVAlign
            Get
                Return vVerticalAlign
            End Get
            Set(value As EnumVAlign)
                vVerticalAlign = value
            End Set
        End Property

        Public Property FontBold As Boolean
            Get
                Return vFontBold
            End Get
            Set(ByVal value As Boolean)
                vFontBold = value
            End Set
        End Property

        Public ReadOnly Property HtmlCode() As String
            Get
                Dim CellCode As String = ""

                If vValue <> "" Then
                    If vIsHeader Then
                        CellCode = String.Format("<th rowspan='1' colspan='1' width='100%' height='100%' align='center' valign='middle'><b>{0}</b></th>", vValue) + vbNewLine
                    Else
                        CellCode = String.Format("<td rowspan='1' colspan='1' width='100%' height='100%' align='center' valign='middle'><b>{0}</b></td>", vValue) + vbNewLine
                    End If

                    If vFontBold = False Then
                        CellCode = Replace(CellCode, "<b>", "")
                        CellCode = Replace(CellCode, "</b>", "")
                    End If

                    If vRowSpan <> 1 Then
                        CellCode = Replace(CellCode, " rowspan='1'", String.Format(" rowspan='{0}'", vRowSpan))
                    Else
                        CellCode = Replace(CellCode, " rowspan='1'", "")
                    End If

                    If vColumnSpan <> 1 Then
                        CellCode = Replace(CellCode, " colspan='1'", String.Format(" colspan='{0}'", vColumnSpan))
                    Else
                        CellCode = Replace(CellCode, " colspan='1'", "")
                    End If

                    If vWidth <> 0 Then
                        CellCode = Replace(CellCode, " width='100%'", String.Format(" width='{0}'", vWidth))
                    Else
                        CellCode = Replace(CellCode, " width='100%'", "")
                    End If

                    If vHeight <> 0 Then
                        CellCode = Replace(CellCode, " height='100%'", String.Format(" height='{0}'", vHeight))
                    Else
                        CellCode = Replace(CellCode, " height='100%'", "")
                    End If

                    If vHorizontalAlign.ToString <> "" Then
                        CellCode = Replace(CellCode, " align='center'", String.Format(" align='{0}'", vHorizontalAlign.ToString))
                    Else
                        CellCode = Replace(CellCode, " align='center'", "")
                    End If

                    If vVerticalAlign.ToString <> "" Then
                        CellCode = Replace(CellCode, " valign='middle'", String.Format(" valign='{0}'", vVerticalAlign.ToString))
                    Else
                        CellCode = Replace(CellCode, " valign='middle'", "")
                    End If
                End If

                Return CellCode
            End Get
        End Property

#End Region

    End Class

    Public Class HtmlImage
        Private vLink As String = ""
        Private vBinaryData As Byte()
        Private vHeight As Integer
        Private vWidth As Integer

        Public Sub New()
        End Sub

        Public Sub New(Link As String)
            vLink = Link
        End Sub

        Public Sub New(BinaryData As Byte())
            vBinaryData = BinaryData
        End Sub

        Public Sub New(SelectCommand As String, PrimaryKeyValue As String, IsSystemDatabase As Boolean)
            Me.GetBinaryData(SelectCommand, PrimaryKeyValue, IsSystemDatabase)
        End Sub

        Public Sub New(TableName As String, PropertyFileData As String, PropertyPrimaryKey As String, PrimaryKeyValue As String, IsSystemDatabase As Boolean)
            Me.GetBinaryData(TableName, PropertyFileData, PropertyPrimaryKey, PrimaryKeyValue, IsSystemDatabase)
        End Sub

#Region "Data Property"
        Public Property Link As String
            Get
                Return vLink
            End Get
            Set(ByVal value As String)
                vLink = value
            End Set
        End Property

        Public Property BinaryData As Byte()
            Get
                Return vBinaryData
            End Get
            Set(ByVal value As Byte())
                vBinaryData = value
            End Set
        End Property

        Public Property Height As Integer
            Get
                Return vHeight
            End Get
            Set(value As Integer)
                vHeight = value
            End Set
        End Property

        Public Property Width As Integer
            Get
                Return vWidth
            End Get
            Set(value As Integer)
                vWidth = value
            End Set
        End Property

        Public ReadOnly Property HtmlCode() As String
            Get
                Dim Result As String = ""
                If vLink <> "" Then
                    Result = String.Format("<img src='{0}' width='100%' height='100%'>", vLink)

                ElseIf Not vBinaryData Is Nothing AndAlso vBinaryData.Length > 1 Then
                    Result = String.Format("<img width='100%' height='100%' src='data:image/jpeg;base64,{0}'/>", Convert.ToBase64String(vBinaryData))
                End If


                If vWidth <> 0 Then
                    Result = Replace(Result, " width='100%'", String.Format(" width='{0}'", vWidth))
                Else
                    Result = Replace(Result, " width='100%'", "")
                End If

                If vHeight <> 0 Then
                    Result = Replace(Result, " height='100%'", String.Format(" height='{0}'", vHeight))
                Else
                    Result = Replace(Result, " height='100%'", "")
                End If

                Return Result
            End Get
        End Property

#End Region

#Region "Data Process"
        Public Sub GetBinaryData(SelectCommand As String, PrimaryKeyValue As String, IsSystemDatabase As Boolean)
            Dim SqlFileData As New eBOSS.Systems.Processing.Sql.SqlValue(IsSystemDatabase)
            SqlFileData.SelectCommand = SelectCommand
            SqlFileData.AddSqlParameter("PrimaryKey", PrimaryKeyValue)
            vBinaryData = SqlFileData.ToObject
        End Sub

        Public Sub GetBinaryData(TableName As String, PropertyFileData As String, PropertyPrimaryKey As String, PrimaryKeyValue As String, IsSystemDatabase As Boolean)
            Dim SelectCommand As String = String.Format("SELECT {0} FROM {1} WHERE {2} = @PrimaryKey", PropertyFileData, TableName, PropertyPrimaryKey)
            Me.GetBinaryData(SelectCommand, PrimaryKeyValue, IsSystemDatabase)
        End Sub
#End Region
    End Class

End Namespace

