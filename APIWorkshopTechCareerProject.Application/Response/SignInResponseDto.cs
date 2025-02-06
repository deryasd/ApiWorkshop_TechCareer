namespace APIWorkshopTechCareerProject.Application.Response
{
    public class SignInResponseDto
    {
        public string Token{ get; set; }

        public SignInResponseDto(string token)
        {
            Token = token;
        }
    }
}
