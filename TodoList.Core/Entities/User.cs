using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string Password { get; set; }

        public DateTime CreationDate { get; set; }

        public UserStatus Status { get; set; }

        public ICollection<ToDoTask> Tasks { get; set; }
    }
}
