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
  private IRepository<ClientUser> _repository;
  public UserLoginService(IRepository<ClientUser> repository)
  {
    _repository = repository;
  }

  public Task<Result<bool>> IsUserSignedUp(int nationalId, string password)
  {
    throw new NotImplementedException();
  }
}
