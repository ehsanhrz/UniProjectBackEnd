using Ardalis.Specification;

namespace Clean.Architecture.Core.UserAggregate.Specifications;

public sealed class IsUserSignedUp : Specification<ClientUser>
{
  public IsUserSignedUp(Int32 nationalId, string password)
  {
    Query.Where(record => record.NationalID == nationalId && record.Password == password);
  }
}
