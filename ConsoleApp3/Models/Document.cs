namespace ConsoleApp3.Models;

public class Document
{
    public virtual void DocumentEdit()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions");
    }
   
    public virtual void DocumentSave() 
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }
    public virtual void DocumentOpen() 
    {

        Console.WriteLine("Documnent opened");
    }
    public Document()
    {
        
    }
    public Document(string name)
    {
        
    }
}
