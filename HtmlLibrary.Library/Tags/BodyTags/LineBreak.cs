namespace HtmlLibrary.Tags.BodyTags;



public sealed class LineBreak : HtmlContent
{
    public override string ToString() => $"<br{GetAttributes()} />";
}
