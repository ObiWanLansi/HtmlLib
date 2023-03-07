using System.Text;

using DoofesZeug.Extensions;


namespace TestConsole.Html2;



public sealed class Link : HtmlContent
{
    public string Caption { get; set; }

    public string Href { get; set; }

    public string Target { get; set; }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public Link(string strCaption, string strHref, string strTarget = null)
    {
        this.Caption = strCaption;
        this.Href = strHref;
        this.Target = strTarget;
    }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public override string ToString()
    {
        StringBuilder sb = new(64);

        sb.Append("<a");
        sb.Append(GetAttributes());
        sb.Append($" href=\"{Href}\"");

        if (Target.IsNotEmpty())
        {
            sb.Append($" target=\"{Target}\"");
        }

        sb.Append($">{Caption}</a>");

        return sb.ToString();
    }
}
