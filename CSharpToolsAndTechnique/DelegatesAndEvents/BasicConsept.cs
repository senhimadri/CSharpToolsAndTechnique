namespace CSharpToolsAndTechnique.DelegatesAndEvents;


public delegate void PrintDeligate(string text);

public static class BasicConsept
{
    public static void ConnectToDatabase(PrintDeligate log)
    {
        log("Inserting a New Records in Database ");

        log("The record got inserted.");
    }

}

public static  class ImplementationofBasicConsept
{
    static PrintDeligate PrinttoConsole = (string Text) =>
    {
        Console.WriteLine(Text);
    };

    static PrintDeligate PrinttoFile = (string Text) =>
    {
        File.AppendAllText("./log.txt", Text);
    };


    public static void DeligatesImplementation()
    {
        BasicConsept.ConnectToDatabase(PrinttoFile);
    }
}









