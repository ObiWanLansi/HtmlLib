using System;


namespace HtmlLibrary.Tags;



public class Html
{
    private const string DOCTYPE = "<!DOCTYPE html>";

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public Head? Head { get; set; }

    public Body? Body { get; set; }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public override string ToString()
    {
        return $"{DOCTYPE}<html>{Environment.NewLine}{Head}{Environment.NewLine}{Body}{Environment.NewLine}</html>";
    }
}
