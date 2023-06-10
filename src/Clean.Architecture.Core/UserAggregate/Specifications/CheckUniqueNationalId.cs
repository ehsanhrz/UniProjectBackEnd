using Ardalis.Specification;

namespace Clean.Architecture.Core.UserAggregate.Specifications;

public sealed class CheckUniqueNationalId : Specification<ClientUser>
{
  public CheckUniqueNationalId(Int32 nationalId)
  {
    Query.Where(item => item.NationalID == nationalId);
  }
}
