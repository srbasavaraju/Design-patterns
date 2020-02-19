namespace VisitorPattern.Interfaces
{
    public interface IDocumentPart
    {
        void GetContent();
        void SetContent();

        void convert(IDocumentConverter documentConverter);
    }
}
