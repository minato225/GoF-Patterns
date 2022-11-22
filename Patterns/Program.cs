using Patterns.AbstractFactory;
using Patterns.AbstractFactory.Factories;

var documents = new List<Document>
{
    new Document(new HtmlFactory()),
    new Document(new LatexFactory()),
    new Document(new PlainTextFactory())
};

foreach(var document in documents)
    Console.WriteLine(GetText(document));

static string GetText(Document document) =>
    document.PlainText($"""
        Some Text
        Lorem ipsum dolor sit amet, consectetuer adipiscing elit.
        Aenean commodo ligula eget dolor.
        {document.BoldText("Aenean massa. ")}
        Cum sociis natoque penatibus et
        {document.BoldText("From linq")}
        {document.HyperlinkText("Random text Site", "https://www.blindtextgenerator.com/lorem-ipsum")}

        """);