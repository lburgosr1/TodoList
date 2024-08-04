using TodoList.Core;
using TodoList.Core.Entities;
using ToDoList.Core.Ports.Drivers;

namespace ToDoList.Core.Services
{
    public class UserService : IUserService
    {
        public Task ChangeStatus(Guid id, UserStatus status)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Save(User user)
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
