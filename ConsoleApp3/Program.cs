
using ConsoleApp3.Models;


string basic;
string pro;
string expert;
Console.Write("Enter name1 -->: ");
basic = Console.ReadLine();
Console.Write("Enter name2-->: ");
pro = Console.ReadLine();
Console.Write("Enter name3-->: ");
expert = Console.ReadLine();

Document doc = new Document(basic);
ProDocument prodoc = new ProDocument(pro);
ExpertDocument expertdoc = new ExpertDocument(expert);
doc.DocumentEdit();
prodoc.DocumentSave();
expertdoc.DocumentOpen();
doc.DocumentSave();
prodoc.DocumentOpen();
expertdoc.DocumentEdit();