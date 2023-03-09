using System;
using System.Data;
using System.IO;

using DoofesZeug.Extensions;

using HtmlLibrary.Converter;
using HtmlLibrary.Tags.BodyTags;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


string DIV = new('=', 120);

void Div() => Console.Out.WriteLineAsync(DIV);

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


DataTable dtMetaData = DataTableExtension.LoadFromSQLiteFile(new(@"D:\BigData\OpenStreetMap\World\central-america-latest.sqlite"), "Node");

Table table = HtmlConverter.GetTable(dtMetaData, "color: blue;", "font-size: 16; border: 2px solid red;", "border: 1px solid grey;");
table.Style = "border:3px solid black;";

//Table table = new()
//{
//    HeaderRow = new("Header 1", "Header 2", "Header 3"),
//    DataRows = new()
//    {
//        new ( "1", "2", "3" ) ,
//        new ( "4", "5", "6" ) ,
//        new ( 7, 8, 9 ) ,
//    },
//    Style = "border:3px solid blue;"
//};

//Console.Out.WriteLineAsync(table.ToString());
File.WriteAllText(@"C:\Work\Table.html", table.ToString());

Div();
