using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_TaskList_Components.Entities
{
    public class TaskList
    {
        public Guid ID { get; set; }
        public string description { get; set; }
        public bool concluded { get; set; }
        public DateTime createDate { get; set; }
    }
}
