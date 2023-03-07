using System.Text;


namespace TestConsole.Html2;



public class Head
{
    public Title Title { get; set; }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine("<head>");
        sb.AppendLine($"    {Title}");
        sb.Append("</head>");

        return sb.ToString();
    }
}
