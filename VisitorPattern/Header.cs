using System;
using VisitorPattern.Interfaces;

namespace VisitorPattern
{
    public class Header : IDocumentPart, IConvertable
    {
        public void convert(IDocumentConverter documentConverter)
        {
            documentConverter.Convert(this);
        }

        public void GetContent()
        {
            Console.WriteLine("Header: Get Header content");
        }

        public void SetContent()
        {
            Console.WriteLine("Header: Set Header content");
        }

        public void ToHtml()
        {
            Console.WriteLine("Header: Header is converted to html");
        }
    }
}
