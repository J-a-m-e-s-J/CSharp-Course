namespace Inherit;

internal static class Inherit
{
    public static void Main(string[] args)
    {
        Pdf pdf = new Pdf("pdf1", "This is a PDF document.");
        Word word = new Word("word1", "This is a Word document.");
        
        pdf.ShowContent();
        word.ShowContent();
    }
}