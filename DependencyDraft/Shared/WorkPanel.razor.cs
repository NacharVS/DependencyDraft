using DependencyDraft.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyDraft.Shared
{
    public partial class WorkPanel
    {
        private string _taskName;
        private string _nameColoborator;
        private bool _inProgress;
        private bool _isDone;
        [Inject]
        TaskService taskService { get; set; }


    }
}
