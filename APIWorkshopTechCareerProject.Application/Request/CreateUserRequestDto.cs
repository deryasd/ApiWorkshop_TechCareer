using System.ComponentModel.DataAnnotations;

namespace APIWorkshopTechCareerProject.Application.Request
{
    public class CreateUserRequestDto
    {
        [Required]
        public string UserName{ get; set; }
        [Required]
        public string Password{ get; set; }
    }
}
