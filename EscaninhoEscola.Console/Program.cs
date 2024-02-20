using EscaninhoEscola.Console.ListaToDo;

class Program
{
    static void Main()
    {
        ToDoList toDoList = new ToDoList();
        toDoList.AddTarefasAoEscaninho("Buy milk");
        toDoList.AddTarefasAoEscaninho("Walk the dog");

        toDoList.EditarTarefasDoEscaninho(0, "Buy coffee");

        foreach (var task in toDoList.GetTasks())
        {
            Console.WriteLine(task);
        }
    }
}