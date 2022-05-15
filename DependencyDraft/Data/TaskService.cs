using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyDraft.Data
{
    public class TaskService
    {
        [BsonId]
        public ObjectId _id;
        public List<TaskItem> listOfTasks;

        public DateTime TimeOfAdd { get; set; }
        public TaskService()
        {
            listOfTasks = TaskItem.GetSimpleList();
        }
        public void AddToList( string taskName, string nameOfColoborator)
        {
            listOfTasks.Add(new TaskItem(taskName, nameOfColoborator));
        }

        public void LocalTime()
        {
            TimeOfAdd.AddHours(3);//добавить 3 часа к текущему времени
        }

    }
}
