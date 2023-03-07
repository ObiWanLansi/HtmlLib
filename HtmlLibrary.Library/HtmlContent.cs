using System.Text;


namespace TestConsole.Html2;



public abstract class HtmlContent
{
    public string Class { get; set; }


    public string Style { get; set; }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    protected string GetAttributes()
    {
        StringBuilder sb = new(32);

        if (Class != null)
        {
            sb.Append($" class=\"{Class}\"");
        }

        if (Style != null)
        {
            sb.Append($" style=\"{Style}\"");
        }

        return sb.ToString();
    }
}
