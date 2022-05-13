using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyDraft.Data
{
    public class MongoService
    {

        public void AddCurrentListToDB(TaskService service, string day)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("DependensiInTaskList");
            var collection = database.GetCollection<TaskService>(day);
            collection.InsertOne(service);
        }
    }
}
