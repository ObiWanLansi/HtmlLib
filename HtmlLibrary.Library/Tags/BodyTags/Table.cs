using System;
using System.Collections.Generic;
using System.Text;


namespace HtmlLibrary.Tags.BodyTags;



public abstract class TableCell : OneLineContent
{
    protected TableCell(string tag, object content) : base(tag, content) { }
}



public sealed class TableHeader : TableCell
{
    public TableHeader(object header) : base("th", header) { }

    public static implicit operator TableHeader(string header)
    {
        return new(header);
    }
}



public sealed class TableData : TableCell
{
    public TableData(object data) : base("td", data) { }
}



public abstract class TableRow<T> : HtmlContent where T : TableCell
{
    public List<T> Cells { get; set; }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    protected TableRow(params object[] content)
    {
        Cells = new();

        foreach (object cell in content)
        {
            Cells.Add((T)Activator.CreateInstance(typeof(T), cell));
        }
    }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public override string ToString()
    {
        StringBuilder sb = new(256);
        sb.Append($"<tr{GetAttributes()}>");
        foreach (T cell in Cells)
        {
            sb.Append(cell);
        }
        sb.Append("</tr>");
        return sb.ToString();
    }
}



public sealed class TableHeaderRow : TableRow<TableHeader>
{
    public TableHeaderRow(params object[] content) : base(content) { }
}



public sealed class TableDataRow : TableRow<TableData>
{
    public TableDataRow(params object[] content) : base(content) { }
}



public sealed class TableDataRows : List<TableDataRow>
{
    public override string ToString()
    {
        StringBuilder sb = new(256);

        foreach (TableDataRow row in this)
        {
            sb.Append(row);
        }

        return sb.ToString();
    }
}



public sealed class Table : HtmlContent
{
    public TableHeaderRow? HeaderRow { get; set; }

    public TableDataRows? DataRows { get; set; }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public Table() { }


    public Table(params string[] columnNames) => HeaderRow = new TableHeaderRow(columnNames);

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public override string ToString()
    {
        StringBuilder sb = new(256);

        sb.Append($"<table{GetAttributes()}>");


        if (HeaderRow != null)
        {
            sb.Append(HeaderRow);
        }

        if (DataRows != null)
        {
            sb.Append(DataRows);
        }

        sb.Append("</table>");

        return sb.ToString();
    }
}
