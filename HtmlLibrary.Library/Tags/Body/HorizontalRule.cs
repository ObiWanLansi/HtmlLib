namespace TestConsole.Html2.Tags.Body;



public sealed class HorizontalRule : HtmlContent
{
    public override string ToString() => $"<hr{GetAttributes()} />";
}
