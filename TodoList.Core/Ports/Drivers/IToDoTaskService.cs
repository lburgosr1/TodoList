using TodoList.Core.Entities;

namespace ToDoList.Core.Ports.Drivers
{
    public interface IToDoTaskService
    {
        Task<ToDoTask> Save(ToDoTask task);
        Task<IEnumerable<ToDoTask>> GetUserTasks(Guid userid);
        Task<ToDoTask> Update(ToDoTask task);
        Task<ToDoTask> ChangeStatus(Guid taskId, byte status);
    }
}
