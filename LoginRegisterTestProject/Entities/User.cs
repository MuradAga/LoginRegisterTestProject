using System.ComponentModel.DataAnnotations;

namespace LoginRegisterTestProject.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
