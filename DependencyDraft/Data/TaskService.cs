using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyDraft.Data
{
    public class TaskService
    {
        public List<TaskItem> listOfTasks;
        public TaskService()
        {
            listOfTasks = TaskItem.GetSimpleList();
        }
        public void AddToList( string taskName, string nameOfColoborator)
        {
            listOfTasks.Add(new TaskItem(taskName, nameOfColoborator));
        }

    }
}
