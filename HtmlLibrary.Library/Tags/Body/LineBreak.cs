namespace TestConsole.Html2.Tags.Body;



public sealed class LineBreak : HtmlContent
{
    public override string ToString() => $"<br{GetAttributes()} />";
}
