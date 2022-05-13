using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyDraft.Data
{
    public class TaskItem
    {
        public TaskItem()
        {
        }

        public TaskItem(string taskName, string nameOfColoborator)
        {
            TaskName = taskName;
            NameOfColoborator = nameOfColoborator;
            InProgress = true;
            IsDone = false;
        }

        public string TaskName { get; set; }
        public string NameOfColoborator { get; set; }
        public bool InProgress { get; set; }
        public bool IsDone { get; set; }

        public static List<TaskItem> GetSimpleList()
        {
            var list = new List<TaskItem>()
            {
                new TaskItem()
                {
                    TaskName = "Buy Products",
                    NameOfColoborator = "Ivan",
                },
                new TaskItem()
                {
                    TaskName = "Wash Car",
                    NameOfColoborator = "Egor",
                },
                new TaskItem()
                {
                    TaskName = "Make a cake",
                    NameOfColoborator = "Alice",
                }
        };

            return list;
        }
    }
}
