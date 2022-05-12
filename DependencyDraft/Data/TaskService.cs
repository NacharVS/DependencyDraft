using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyDraft.Data
{
    public class TaskService
    {
        //public List<TaskService> listOfTasks = GetSimpleList();
        public TaskService()
        {
        }

        public TaskService(string taskName, string nameOfColoborator)
        {
            TaskName = taskName;
            NameOfColoborator = nameOfColoborator;
            InProgress = false;
            IsDone = false;
        }

        public string TaskName { get; set; }
        public string NameOfColoborator { get; set; }
        public bool InProgress { get; set; }
        public bool IsDone { get; set; }



        public List<TaskService> GetSimpleList()
        {
            var list = new List<TaskService>()
            {
                new TaskService()
                {
                    TaskName = "Buy Products",
                    NameOfColoborator = "Ivan",
                },
                new TaskService()
                {
                    TaskName = "Wash Car",
                    NameOfColoborator = "Egor",
                },
                new TaskService()
                {
                    TaskName = "Make a cake",
                    NameOfColoborator = "Alice",
                }
            };

            return list;
        }

        public void AddToList(List<TaskService> list, TaskService item)
        {
            list.Add(item);

        }

    }
}
