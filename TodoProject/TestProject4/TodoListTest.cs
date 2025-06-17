using ASP.Models;

namespace TestProject4;

public class TodoListTest
{
    [Fact]
    public void GetTodoList()
    {
        List<TaskItem> _list = new List<TaskItem>();
        Todo todo = new Todo();
        
        todo.AddTask("drink water");
        Assert.Equal(1, todo.GetTodoList().Count);
    }

    [Fact]
    public void AddTask()
    {
        List<TaskItem> _list = new List<TaskItem>();
        Todo todo = new Todo();
        
        Assert.Equal("task should not be empty", todo.AddTask(""));
        Assert.Equal("added task", todo.AddTask("read book"));
    }

    [Fact]
    public void RemoveTask()
    {
        List<TaskItem> _list = new List<TaskItem>();
        Todo todo = new Todo();
        
        todo.AddTask("drink water");
        Assert.Equal("removed task", todo.RemoveTask(0));
        Assert.Equal("task doesn't exist", todo.RemoveTask(0));
    }

    [Fact]
    public void UpdateTask()
    {
        List<TaskItem> _list = new List<TaskItem>();
        Todo todo = new Todo();
        
        todo.AddTask("drink water");
        Assert.Equal("task updated", todo.ToggleTask(0));
        Assert.Equal("task doesn't exist", todo.ToggleTask(1));
    }
}