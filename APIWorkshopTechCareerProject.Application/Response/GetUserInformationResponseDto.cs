using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWorkshopTechCareerProject.Application.Response
{
    public class GetUserInformationResponseDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public GetUserInformationResponseDto(int ıd, string userName, string password)
        {
            Id = ıd;
            UserName = userName;
            Password = password;
        }
    }
}
