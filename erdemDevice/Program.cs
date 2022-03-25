// See https://aka.ms/new-console-template for more information
using Text2Xml;

var converter = new Text2XmlConverter()
{
    XmlTagRoot = "F",
    XmlTagRow = "R",
    XmlTagToken = "C",
    IncludeFirstLine = true,
    IncludeLastLine = true,
    EnumerateTokens = false,
    TextRowSeparator = "\n",
};

var tempPath = Path.GetTempFileName();
File.WriteAllText(tempPath, @"Yet another XML file.");

var xmlText = converter.Parse(tempPath);
Console.WriteLine(xmlText);