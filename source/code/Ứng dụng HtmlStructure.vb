 Public Sub LoadData()
        Dim HtmlTable As New HtmlTable
        HtmlTable.AddCell(Me.GetCellHeader("WorkID"), RowIndex:=1, FontBold:=True)
        HtmlTable.AddCell(Me.GetCellValue("WorkID"), RowIndex:=1)
        HtmlTable.AddCell(Me.GetCellHeader("RecordDate"), RowIndex:=1, FontBold:=True)
        HtmlTable.AddCell(Me.GetCellValue("RecordDate"), RowIndex:=1)
        HtmlTable.AddCell(Me.GetCellHeader("TypeID"), RowIndex:=1, FontBold:=True)
        HtmlTable.AddCell(Me.GetCellValue("TypeID"), RowIndex:=1)


        Dim HtmlDocument As New HtmlDocument
        HtmlDocument.AddTable(HtmlTable)
        WebBrowser.DocumentText = HtmlDocument.HtmlCode

    
    End Sub