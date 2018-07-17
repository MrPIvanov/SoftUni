using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var allEmploes = new List<Employee>();

        allEmploes.Add(new Employee("Pesho"));

        var documents = new List<string>();
        documents.Add("document1");
        documents.Add("document2");
        documents.Add("document3");
        allEmploes.Add(new Manager("Ivan", documents));

        var printer = new DetailsPrinter(allEmploes);
        printer.PrintDetails();
    }
}