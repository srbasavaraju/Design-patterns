using System;
using System.Collections.Generic;
using System.Text;
using VisitorPattern.Interfaces;

namespace VisitorPattern
{
    public class Document: IDocumentConverter
    {
        List<IDocumentPart> documentParts;

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
        public void ToHtml()
        {
            // loop with all the toHtml and print
        }

        public void Convert(Header header)
        {
            header.ToHtml();
        }

        public void Convert(Footer footer)
        {
            footer.ToHtml();
        }

        public void Convert(Paragrapgh paragrapgh)
        {
            paragrapgh.ToHtml();
        }

        public void Convert(Hyperlink hyperlink)
        {
            hyperlink.ToHtml();
        }
    }
}
