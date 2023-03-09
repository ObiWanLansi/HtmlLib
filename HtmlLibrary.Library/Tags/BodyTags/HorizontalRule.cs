namespace HtmlLibrary.Tags.BodyTags;



public sealed class HorizontalRule : HtmlContent
{
    public override string ToString() => $"<hr{GetAttributes()} />";
}
