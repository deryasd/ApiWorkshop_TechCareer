using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace APIWorkshopTechCareerProject.Application.Request
{
    public class CreateJwtBodyRequestDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public CreateJwtBodyRequestDto(int ıd, string userName)
        {
            Id = ıd;
            UserName = userName;
        }
    }
}
