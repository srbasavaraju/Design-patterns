namespace VisitorPattern.Interfaces
{
    public interface IDocumentConverter
    {
        void Convert(Header header);
        void Convert(Footer footer);
        void Convert(Paragrapgh paragrapgh);
        void Convert(Hyperlink hyperlink);
    }
}
