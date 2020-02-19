using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Interfaces;

namespace VisitorPattern
{
    public class Hyperlink: IDocumentPart, IConvertable
    {
        public void convert(IDocumentConverter documentConverter)
        {
            documentConverter.Convert(this);
        }

        public void GetContent()
        {
            Console.WriteLine("Hyperlink: Get Hyperlink content");
        }

        public void SetContent()
        {
            Console.WriteLine("Hyperlink: Set Hyperlink content");
        }

        public void ToHtml()
        {
            Console.WriteLine("Hyperlink: Hyperlink is converted to html");
        }
    }
}
