namespace ConsoleApp3.Models;

public class ExpertDocument:ProDocument
{
    public override void DocumentSave()
    {
        Console.WriteLine("Document Saved in pdf format");
    }
    public override void DocumentOpen()
    {

        base.DocumentOpen();
    }

    public ExpertDocument(string name):base()
    {

    }
}
