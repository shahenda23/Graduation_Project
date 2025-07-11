using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Graduation_Project.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("Role")]
        public int Role_Id { get; set; }

        public Role? Role { get; set; }
    }
}
