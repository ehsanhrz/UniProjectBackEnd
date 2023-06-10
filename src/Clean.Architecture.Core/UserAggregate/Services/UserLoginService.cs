using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Result;
using Clean.Architecture.Core.UserAggregate.Interfaces;
using Clean.Architecture.Core.UserAggregate.Specifications;
using Clean.Architecture.SharedKernel.Interfaces;

namespace Clean.Architecture.Core.UserAggregate.Services;
public class UserLoginService : IUserLogin
{
  private readonly IRepository<ClientUser> _repository;
  public UserLoginService(IRepository<ClientUser> repository)
  {
    _repository = repository;
  }

  public async Task<Result<bool>> IsUserSignedUp(int nationalId, string password)
  {
    var isUserSignedUpSpec = new IsUserSignedUp(nationalId, password);
    var checkResult = await _repository.FirstOrDefaultAsync(isUserSignedUpSpec);
    if (checkResult == null)
    {
      Result.Success(false);
    }

    return Result.Success(true);
  }
  
}
