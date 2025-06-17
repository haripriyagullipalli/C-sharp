
namespace ASP.Models
{
    public class TaskItem
    {
        public string task { get; set; }
        public int id { get; set; }
        public bool done { get; set; }
    }
    
    public class Todo
    {
        public List<TaskItem> _todoList;
        private int _id { get; set; }

        public Todo()
        {
            _todoList = new List<TaskItem>();
            _id = 0;
        }

        public string AddTask(string task)
        {
            // _todoList.Add(task);
            if (task == "")
            {
                return "task should not be empty";
            }
            else
            {
                _todoList.Add(new TaskItem { task = task, id = _id, done = false });
                _id++;
                return "added task";
            }
        }

        public List<TaskItem> GetTodoList()
        {
            return _todoList;
        }

        public string RemoveTask(int id)
        {
            TaskItem item = _todoList.FirstOrDefault(x => x.id == id);
            if (item == null)
            {
                return "task doesn't exist";
            }
            else
            {
                _todoList.Remove(_todoList.Find(x => x.id == id));
                return "removed task";
            }
        }

        public string ToggleTask(int taskId)
        {
            TaskItem task = _todoList.Find(x => x.id == taskId);
            if (task == null)
            {
                return "task doesn't exist";
            }
            else
            {
                task.done = !task.done;
                return "task updated";
            }
        }
    }
}