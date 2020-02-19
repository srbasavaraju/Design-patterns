using System;
using VisitorPattern.Interfaces;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document docuement = new Document();
            // docuement.ToHtml();

            IDocumentConverter documentConverter = new HtmlConverter();
           // docuement.Convert(new HtmlConverter());


        }
    }
}
