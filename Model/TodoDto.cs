using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Routing.Model
{
    public class TodoDto
    {
        public Guid Id {get; set;}
        public string Title {get; set;}=string.Empty;
        public string Description {get; set;}=string.Empty;
        public bool IsDone {get; set;}
    }
}
