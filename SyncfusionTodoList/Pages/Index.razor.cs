using Microsoft.AspNetCore.Components;
using System.Xml.Linq;
using TodoListComponentLib.Data;

namespace SyncfusionTodoList.Pages
{
    public partial class Index
    {
        [Inject]
        public ITodoItemService ItemService { get; set; }
        private List<TodoItem> todoItems { get; set; }

        private async Task LoadData()
        {
            todoItems = await ItemService.Read();
        }
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await LoadData();
        }

        public async Task Add(string name)
        {
            await ItemService.Create(new TodoItem { Name = name });
            await LoadData();
        }

        public async Task Delete(TodoItem item)
        {
            await ItemService.Delete(item);
            await LoadData();
        }
    }
}
