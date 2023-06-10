using Ardalis.Result;
using Clean.Architecture.Core.UserAggregate.Interfaces;
using Clean.Architecture.Core.UserAggregate.Specifications;
using Clean.Architecture.SharedKernel.Interfaces;
using MediatR;

namespace Clean.Architecture.Core.UserAggregate.Services;

public class UserSignupService : IUserSignup
{

    private readonly IRepository<ClientUser> _clientUserRepository;
    private readonly IMediator _mediator;
    public UserSignupService(IRepository<ClientUser> repositoryClientUser, IMediator mediator)
    {
        _clientUserRepository = repositoryClientUser;
        _mediator = mediator;
    }


    public async Task<Result<ClientUser>> CreateUser(Int32 nationalId, string passWord, string email)
    {
      try
      {
        var newUser = new ClientUser(nationalId, passWord, email);
        var result = await _clientUserRepository.AddAsync(newUser);
        var operationResult = await _clientUserRepository.SaveChangesAsync();
        if (operationResult > 0)
        {
          return Result.Success(result);
        }

        return Result.Error("Something Wrong in DB");
      }
      catch (Exception error)
      {
        return Result.Error(error.Message);
      }

    }

    public async Task<Result<bool>> CheckUniqueNationalId(int nationalId)
    {
      var nationalIdSpec = new CheckUniqueNationalId(nationalId);

      var searchResult = await _clientUserRepository.FirstOrDefaultAsync(nationalIdSpec);

      if (searchResult != null)
      {
        return Result.Error("This National Id Already Exists");
      }

      return Result.Success();
    }

    public async Task<Result> CheckUniqueEmail(string email)
    {
      var emailSpec = new CheckUniqueEmail(email);

      var searchResult = await _clientUserRepository.FirstOrDefaultAsync(emailSpec);

      if (searchResult != null)
      {
        return Result.Error("This Email Already Exists");
      }

      return Result.Success();
    }

    public Task<Result> FireEmailVerficationCodeSender(ClientUser user)
    {
      throw new NotImplementedException();
    }

    public Task<Result> ResetEmailCodeVerficationsender(ClientUser user)
    {
      throw new NotImplementedException();
    }

    public Task<Result> ChangeUserEmailForValidation(ClientUser user, string Email)
    {
      throw new NotImplementedException();
    }

    public Task<Result> CeckEmailVerficationCode(ClientUser user, int code)
    {
      throw new NotImplementedException();
    }
}
