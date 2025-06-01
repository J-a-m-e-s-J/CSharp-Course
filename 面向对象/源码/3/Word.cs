namespace Inherit;

public class Word(string fileName, string contents) : Document("docx", fileName, contents)
{
    public override void ShowContent()
    {
        Console.WriteLine($"filename: {FileName}.docx\n" +
                          $"content: {Content}\n");
    }
}