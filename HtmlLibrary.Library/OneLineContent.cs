namespace TestConsole.Html2;



public abstract class OneLineContent : HtmlContent
{
    private readonly string tag;

    private readonly object content;

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    protected OneLineContent(string tag, object content)
    {
        this.tag = tag;
        this.content = content;
    }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public override string ToString() => $"<{tag}{GetAttributes()}>{content}</{tag}>";
}
