using System.Collections.Generic;
using System.Text;


namespace HtmlLibrary.Tags;



public class Body : List<HtmlContent>
{
    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine("<body>");

        foreach (HtmlContent item in this)
        {
            sb.AppendLine($"    {item}");
        }

        sb.Append("</body>");

        return sb.ToString();
    }
}
