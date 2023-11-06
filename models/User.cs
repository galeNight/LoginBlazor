using System.ComponentModel.DataAnnotations;

namespace LoginBlazor.models
{
    public class User
    {
        
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

}
