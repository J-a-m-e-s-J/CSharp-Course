namespace Inherit;

public class Pdf(string fileName, string content) : Document("pdf", fileName, content)
{
    public override void ShowContent()
    {
        Console.WriteLine($"filename: {FileName}.pdf\n" +
                          $"content: {Content}\n");
    }
}