using APIWorkshopTechCareerProject.Application.Request;
using APIWorkshopTechCareerProject.Application.Response;
using APIWorkshopTechCareerProject.DataAccess.Data;
using APIWorkshopTechCareerProject.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace APIWorkshopTechCareerProject.Application.Services
{
    public class UserService : IUserService
    {
        private readonly TechCareerDbContext _context;
        private readonly IAuthService _authService;

        public UserService(TechCareerDbContext context, IAuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        public async Task<CreateUserResponseDto> CreateAsync(CreateUserRequestDto request)
        {
            bool isExistUser = await _context.Users.AnyAsync(x => x.UserName == request.UserName);
            
            if (isExistUser) 
                throw new Exception("User already exist!");

            var user = new User(request.UserName,request.Password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return new CreateUserResponseDto(user.Id);
        }

        public async Task<GetUserInformationResponseDto> GetUserInformation(int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
                throw new Exception("User couldn't find!");

            return new GetUserInformationResponseDto(user.Id, user.UserName, user.Password);
        }

        public async Task<SignInResponseDto> SignAsUser(SignInRequestDto request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == request.UserName && x.Password == request.Password);

            if (user == null)
                throw new Exception("User or password is wrong!");

            var token = await _authService.GenerateJwtToken(new CreateJwtBodyRequestDto(user.Id,user.UserName));

            return new SignInResponseDto(token);
        }
    }
}