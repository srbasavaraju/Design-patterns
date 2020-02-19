using System;
using VisitorPattern.Interfaces;

namespace VisitorPattern
{
    public class Paragrapgh: IDocumentPart, IConvertable
    {
        public void convert(IDocumentConverter documentConverter)
        {
            documentConverter.Convert(this);
        }

        public void GetContent()
        {
            Console.WriteLine("Paragraph: Get Paragraph content");
        }

        public void SetContent()
        {
            Console.WriteLine("Paragraph: Set Paragraph content");
        }

        public void ToHtml()
        {
            Console.WriteLine("Paragraph: Paragraph is converted to html");
        }
    }
}
