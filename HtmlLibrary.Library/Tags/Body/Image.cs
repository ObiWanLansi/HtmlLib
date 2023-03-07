using System.Text;

using DoofesZeug.Extensions;


namespace TestConsole.Html2;



public sealed class Image : HtmlContent
{
    public string Source { get; set; }

    public string Alternate { get; set; }

    public uint? Width { get; set; }

    public uint? Height { get; set; }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public Image(string strSource, string strAlternate = null, uint? iWidth = null, uint? iHeight = null)
    {
        this.Source = strSource;
        this.Alternate = strAlternate;
        this.Width = iWidth;
        this.Height = iHeight;
    }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public override string ToString()
    {
        StringBuilder sb = new(64);

        sb.Append("<img");
        sb.Append(GetAttributes());
        sb.Append($" src=\"{Source}\"");

        if (Alternate.IsNotEmpty())
        {
            sb.Append($" alt=\"{Alternate}\"");
        }

        if (Width != null)
        {
            sb.Append($" width=\"{Width}\"");
        }

        if (Height != null)
        {
            sb.Append($" height=\"{Height}\"");
        }

        sb.Append(" />");

        return sb.ToString();
    }
}
