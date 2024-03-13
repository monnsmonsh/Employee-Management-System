using BaseLibrary.DTOs;
using BaseLibrary.Responses;


namespace ServerLibrary.Repositories.Contratcs
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAsync(Register user);
        Task<LoginResponse> CreateAsync(Login user);
    }
}
