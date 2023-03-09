using System.Text;

using HtmlLibrary.Tags.HeaderTags;


namespace HtmlLibrary.Tags;



public class Head
{
    public Title? Title { get; set; }

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
