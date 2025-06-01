namespace Inherit;

public abstract class Document(string type, string fileName, string content)
{
    public string Type { get; set; } = type;
    public string FileName { get; set; } = fileName;
    public string Content { get; set; } = content;

    public abstract void ShowContent();

    public void SetType(string type)
    {
        Type = type;
    }
    
    public void SetFileName(string fileName)
    {
        FileName = fileName;
    }
    
    public void SetContent(string content)
    {
        Content = content;
    }
}