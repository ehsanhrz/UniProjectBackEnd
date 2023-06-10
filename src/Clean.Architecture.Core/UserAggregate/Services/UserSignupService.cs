using Ardalis.Result;
using Clean.Architecture.Core.UserAggregate.Interfaces;
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


    public Task<Result<ClientUser>> CreateUser(string nationalId, string passWord, string email)
    {
      throw new NotImplementedException();
    }

    public Task<Result> CheckUniqueEmail(string email)
    {
      throw new NotImplementedException();
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
