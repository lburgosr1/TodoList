using TodoList.Core.Entities;
using ToDoList.Core.Ports.Drivers;

namespace ToDoList.Core.Services
{
    public class ToDoTaskService : IToDoTaskService
    {
        public Task<ToDoTask> ChangeStatus(Guid taskId, byte status)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToDoTask>> GetUserTasks(Guid userid)
        {
            throw new NotImplementedException();
        }

        public Task<ToDoTask> Save(ToDoTask task)
        {
            throw new NotImplementedException();
        }

        public Task<ToDoTask> Update(ToDoTask task)
        {
            throw new NotImplementedException();
        }
    }
}
