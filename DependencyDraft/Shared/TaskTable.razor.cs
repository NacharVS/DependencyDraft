using DependencyDraft.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyDraft.Shared
{
    public partial class TaskTable
    {
        [Inject]
        TaskService taskService { get; set; }
        [Inject]
        MongoService dbService { get; set; }
        private string _taskName;
        private string _nameColoborator;
        private bool _inProgress;
        private bool _isDone;
        private string _day;

        private void RefreshList()
        {
            taskService.AddToList(_taskName, _nameColoborator);
        }

        protected override void OnInitialized()
        {
            taskService.listOfTasks = MongoService.GetListFromDb();
        }

    }
}
