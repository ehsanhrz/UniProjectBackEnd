using Ardalis.Specification;

namespace Clean.Architecture.Core.UserAggregate.Specifications;
public sealed class CheckUniqueEmail : Specification<ClientUser>
{
  public CheckUniqueEmail(string email)
  {
    Query.Where(item => item.Email == email);
  }
}
