namespace Graduation_Project.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Role_Name { get; set; }
        public List<Account>? Accounts { get; set; }
    }
}
