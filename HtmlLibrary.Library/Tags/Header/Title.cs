﻿namespace TestConsole.Html2;



public class Title : OneLineContent
{
    public Title(string content) : base("title", content) { }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public static implicit operator Title(string title) => new(title);
}