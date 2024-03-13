

namespace BaseLibrary.Responses
{
    public record LoginResponse(bool Flag, string Message = null!, string Tocken = null!, string RefreshToken = null!);

}
