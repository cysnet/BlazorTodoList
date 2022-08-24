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
        [Inject]
        public ITodoItemService DataService { get; set; }
        public string Name { get; set; } = "";

        public List<TodoItem> Data { get; set; }

        private async Task LoadData()
        {
            Data = await DataService.Read();
        }

        protected override async Task OnInitializedAsync()
        {
            await LoadData();

            await base.OnInitializedAsync();
        }

        async Task Add()
        {
            await DataService.Create(new TodoItem() { Name = Name });

            await LoadData();
        }

        async Task Delete(TodoItem item)
        {
            await DataService.Delete(item);

            await LoadData();
        }
    }
}
