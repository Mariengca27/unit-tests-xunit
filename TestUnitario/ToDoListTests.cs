using EscaninhoEscola.Console.ListaToDo;

namespace TestUnitario
{
    public class ToDoListTests
    {
        [Fact]
        public void TestAddTask()
        {
            //Arrange
            ToDoList toDoList = new ToDoList();


            //Act    
            toDoList.AddTarefasAoEscaninho("Test task");

            //Assert
            Assert.Contains("Test task", toDoList.GetTasks());

        }

        [Fact]
        public void TestRemoveTask()
        {
            ToDoList toDoList = new ToDoList();
            toDoList.AddTarefasAoEscaninho("Test task");
            bool result = toDoList.RemoverTarefasDoEscaninho("Test task");

            Assert.True(result);
            Assert.DoesNotContain("Test task", toDoList.GetTasks());
        }

        [Fact]
        public void TestEditTask()
        {
            ToDoList toDoList = new ToDoList();
            toDoList.AddTarefasAoEscaninho("Test task");
            toDoList.EditarTarefasDoEscaninho(0, "Edited task");

            Assert.DoesNotContain("Test task", toDoList.GetTasks());
            Assert.Contains("Edited task", toDoList.GetTasks());
        }






    }
}