using Ardalis.Result;

namespace Clean.Architecture.Core.UserAggregate.Interfaces;
public interface IUserSignup
{
  
    public Task<Result<ClientUser>> CreateUser(Int32 nationalId, string passWord, string email);

    public Task<Result<bool>> CheckUniqueNationalId(Int32 nationalId);

    public Task<Result> CheckUniqueEmail(string email);

    public Task<Result> FireEmailVerficationCodeSender(ClientUser user);

    public Task<Result> ResetEmailCodeVerficationsender(ClientUser user);

    public Task<Result> ChangeUserEmailForValidation(ClientUser user, string Email);

    public Task<Result> CeckEmailVerficationCode(ClientUser user, int code);

}
