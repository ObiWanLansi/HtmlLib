using System.Data;

using TestConsole.Html2.Tags.Body;


namespace TestConsole.Html2.Converter;



public static class HtmlConverter
{
    public static Table GetTable(DataTable dt, string rowStyle = null, string headerStyle = null, string dataStyle = null)
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
