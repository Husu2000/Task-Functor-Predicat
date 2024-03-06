namespace ConsoleApp3.Models;

public class ProDocument:Document
{
    public override void DocumentSave()
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }
    public sealed override void DocumentEdit()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions");
    }
    public override void DocumentOpen()
    {

        Console.WriteLine("Documnent opened");
    }
    public ProDocument()
    {

    }
    public ProDocument(string name)
    {
        Console.WriteLine(name);
    }
}
