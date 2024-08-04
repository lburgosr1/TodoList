using TodoList.Core.Entities;
using TodoList.Core.Ports.Driven;

namespace ToDoList.Persistence.Database
{
    public class ToDoTaskRepository : IToDoTaskRepository
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
