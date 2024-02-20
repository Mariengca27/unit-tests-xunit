using EscaninhoEscola.Console.ListaToDo;

class Program
{
    static void Main()
    {
        ToDoList toDoList = new ToDoList();


        //toDoList.AddTarefasAoEscaninho("Buy milk");
        //toDoList.AddTarefasAoEscaninho("Walk the dog");

        //toDoList.EditarTarefasDoEscaninho(0, "Buy coffee");

        //foreach (var task in toDoList.GetTasks())
        //{
        //    Console.WriteLine(task);
        //}



        while (true)
        {
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Remove task");
            Console.WriteLine("3. Edit task");
            Console.WriteLine("4. View tasks");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Coloque o nome de uma nova tarefa: ");
                    string task = Console.ReadLine();
                    toDoList.AddTarefasAoEscaninho(task);
                    break;
                case "2":
                    Console.Write("Nome de uma tarefa para ser removida: ");
                    task = Console.ReadLine();
                    toDoList.RemoverTarefasDoEscaninho(task);
                    break;
                case "3":
                    Console.Write("Editar uma tarefa, digite o index da mesma para ajudar a localizá-la ");
                    int index = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new task: ");
                    task = Console.ReadLine();
                    toDoList.EditarTarefasDoEscaninho(index, task);
                    break;
                case "4":
                    Console.WriteLine("Lista de Tarefas já listadas :");
                    foreach (var t in toDoList.GetTasks())
                    {
                        Console.WriteLine(t);
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("ESSA OPÇÃO NÃO EXISTE, FAVOR TENTAR NOVAMENTE.");
                    break;





            }
}