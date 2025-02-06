using APIWorkshopTechCareerProject.Application.Request;

namespace APIWorkshopTechCareerProject.Application.Services
{
    public interface IAuthService
    {
        Task<string> GenerateJwtToken(CreateJwtBodyRequestDto request);
    }
}
