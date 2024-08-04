using TodoList.Core.Entities;

namespace TodoList.Core.Ports.Driven
{
    public interface IToDoTaskRepository
    {
        Task<ToDoTask> Save(ToDoTask task);
        Task<IEnumerable<ToDoTask>> GetUserTasks(Guid userid);
        Task<ToDoTask> Update(ToDoTask task);
        Task<ToDoTask> ChangeStatus(Guid taskId, byte status);
    }
}
