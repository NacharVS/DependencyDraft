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

        
    }
}
