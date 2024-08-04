using TodoList.Core.Entities;
using TodoList.Core;

namespace ToDoList.Core.Ports.Drivers
{
    public interface IUserService
    {
        Task<User> Save(User user);
        Task<User> GetUserById(Guid id);
        Task Update(User user);
        Task ChangeStatus(Guid id, UserStatus status);
    }
}
