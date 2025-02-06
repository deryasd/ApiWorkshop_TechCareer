using APIWorkshopTechCareerProject.Application.Request;
using APIWorkshopTechCareerProject.Application.Response;

namespace APIWorkshopTechCareerProject.Application.Services
{
    public interface IUserService
    {
        Task<CreateUserResponseDto> CreateAsync(CreateUserRequestDto request);
        Task<SignInResponseDto> SignAsUser(SignInRequestDto request);
        Task<GetUserInformationResponseDto> GetUserInformation(int userId);

    }
}
