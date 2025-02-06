using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace APIWorkshopTechCareerProject.Models.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User()
        {
        }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
