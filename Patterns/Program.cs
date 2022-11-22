using Patterns.AbstractFactory;
using Patterns.AbstractFactory.Factories;

var document = new Document(new HtmlFactory());
Console.WriteLine(GetText());
document = new Document(new LatexFactory());
Console.WriteLine(GetText());
document = new Document(new PlainTextFactory());
Console.WriteLine(GetText());

string GetText() =>
    document.PlainText($"""
        Some Text
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit.
        Aenean commodo ligula eget dolor.
        {document.BoldText("Aenean massa. ")}
        Cum sociis natoque penatibus et
        {document.BoldText("From linq")}
        {document.HyperlinkText("Random text Site", "https://www.blindtextgenerator.com/lorem-ipsum")}

        """);