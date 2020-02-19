using System;
using VisitorPattern.Interfaces;

namespace VisitorPattern
{
    public class Footer: IDocumentPart, IConvertable
    {
        public void convert(IDocumentConverter documentConverter)
        {
            documentConverter.Convert(this);
        }

        public void GetContent()
        {
            Console.WriteLine("Footer: Get Footer content");
        }

        public void SetContent()
        {
            Console.WriteLine("Footer: Set Footer content");
        }

        public void ToHtml()
        {
            Console.WriteLine("Footer: Footer is converted to html");
        }
    }
}
