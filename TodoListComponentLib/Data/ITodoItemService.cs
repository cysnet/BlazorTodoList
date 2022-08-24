using TodoListComponentLib.Data;

namespace TodoListComponentLib.Data
{
    public interface ITodoItemService
    {
        Task<List<TodoItem>> Read();
        Task<bool> Create(TodoItem item);
        Task<bool> Delete(TodoItem item);
    }
}