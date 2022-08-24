using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListComponentLib.Data;

namespace TodoListComponentLib.Components
{
    public partial class TodoList
    {
        public string Name { get; set; } = "Blazor";

        [Inject]
        public ITodoItemService DataService { get; set; }

        [Parameter]
        public List<TodoItem> Data { get; set; }

        [Parameter]
        public EventCallback<string> Add { get; set; }

        [Parameter]
        public EventCallback<TodoItem> Delete { get; set; }

    }
}
