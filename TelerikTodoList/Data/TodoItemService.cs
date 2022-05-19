public class TodoItemService
{
    private List<TodoItem> data { get; set; } = new();
    public async Task<List<TodoItem>> Read()
    {
        return await Task.FromResult(data);
    }



    public async Task<bool> Create(TodoItem item)
    {
        data.Add(item);
        return await Task.FromResult(true);
    }

    public async Task<bool> Delete(TodoItem item)
    {
        data.Remove(item);
        return await Task.FromResult(true);
    }
}