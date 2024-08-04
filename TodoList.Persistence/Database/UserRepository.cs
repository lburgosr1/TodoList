using TodoList.Core;
using TodoList.Core.Entities;
using TodoList.Core.Ports.Driven;

namespace ToDoList.Persistence.Database
{
    public class UserRepository : IUserRepository
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
