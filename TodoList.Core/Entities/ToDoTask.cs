using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Core.Entities
{
    public class ToDoTask
    {
        public Guid Id { get; set; }

        public Guid userId { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Description { get; set; }

        public byte Status { get; set; }

        public User User { get; set; }
    }
}
