using System.Data;

using HtmlLibrary.Tags.BodyTags;


namespace HtmlLibrary.Converter;



public static class HtmlConverter
{
    public static Table GetTable(DataTable dt, string? rowStyle = null, string? headerStyle = null, string? dataStyle = null)
    {
        Table table = new()
        {
            HeaderRow = new TableHeaderRow() { Style = rowStyle },
            DataRows = new TableDataRows()
        };

        foreach (DataColumn dc in dt.Columns)
        {
            table.HeaderRow.Cells.Add(new TableHeader(dc.ColumnName)
            {
                Style = headerStyle
            });
        }

        foreach (DataRow dr in dt.Rows)
        {
            TableDataRow datarow = new() { Style = rowStyle };
            //TODO: Check if null or DBNull
            foreach (object item in dr.ItemArray)
            {
                datarow.Cells.Add(new TableData(item) { Style = dataStyle });
            }
            table.DataRows.Add(datarow);
        }

        return table;
    }


    //public static OrderedList GetOrderedList<IList<object> data)
}
