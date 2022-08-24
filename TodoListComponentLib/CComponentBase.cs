using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListComponentLib
{
    public class CComponentBase : ComponentBase
    {
        [Parameter]
        public string CurrentUser { get; set; }
    }
}
