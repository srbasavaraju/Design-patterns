using System;
using VisitorPattern.Interfaces;

namespace VisitorPattern
{
    public class HtmlConverter : IDocumentConverter
    {
        public void Convert(Header header)
        {
            header.ToHtml();
            Console.WriteLine("DocumentConverter: Header is converted to html");
        }

        public void Convert(Footer footer)
        {
            footer.ToHtml();
            Console.WriteLine("DocumentConverter: footer is converted to html");
        }

        public void Convert(Paragrapgh paragrapgh)
        {
            paragrapgh.ToHtml();
            Console.WriteLine("DocumentConverter: paragraph is converted to html");
        }

        public void Convert(Hyperlink hyperlink)
        {
            hyperlink.ToHtml();
            Console.WriteLine("DocumentConverter: Hyperlink is converted to html");
        }
    }
}
