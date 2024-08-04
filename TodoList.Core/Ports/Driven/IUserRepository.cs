using TodoList.Core.Entities;

namespace TodoList.Core.Ports.Driven
{
    public interface IUserRepository
    {
        Task<User> Save(User user);
        Task<User> GetUserById(Guid id);
        Task Update(User user);
        Task ChangeStatus(Guid id, UserStatus status);
    }
}
