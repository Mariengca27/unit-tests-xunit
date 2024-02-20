using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EscaninhoEscola.Console.ListaToDo
{
    public class ToDoList
    {
        private List<string> _toDoList = new List<string>();

            

        public void AddTarefasAoEscaninho(string item)
        {
            _toDoList.Add(item);
        }


        public bool RemoverTarefasDoEscaninho(string item)
        {
          return  _toDoList.Remove(item);
        }


        public void EditarTarefasDoEscaninho(int indice, string novoItem)
        {
            if (indice < 0 || indice >= _toDoList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(indice), "Index is out of range.");
            }

            _toDoList[indice] = novoItem;
        }

        public IList<string> GetTasks()
        {
            return _toDoList.AsReadOnly();
        }




    }
}
