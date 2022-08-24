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
        /// <summary>
        /// 绑定输入框
        /// </summary>
        private string Name { get; set; } = "Blazor";

        /// <summary>
        /// 绑定的数据源
        /// </summary>
        [Parameter]
        public List<TodoItem> Data { get; set; }

        /// <summary>
        /// 添加Item操作
        /// </summary>
        [Parameter]
        public EventCallback<string> Add { get; set; }

        /// <summary>
        /// 删除操作
        /// </summary>
        [Parameter]
        public EventCallback<TodoItem> Delete { get; set; }


        private async Task AddItem()
        {
            if (!string.IsNullOrEmpty(Name))
            {
                await Add.InvokeAsync(Name);
            }
        }

        private async Task DeleteItem(TodoItem item)
        {
            await Delete.InvokeAsync(item);
        }
    }
}
