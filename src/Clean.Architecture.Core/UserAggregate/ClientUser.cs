using Clean.Architecture.SharedKernel.Interfaces;
using Clean.Architecture.SharedKernel;
using System.Text.Json.Serialization;

namespace Clean.Architecture.Core.UserAggregate;
public class ClientUser : EntityBase, IAggregateRoot
{

  [JsonConstructor]
  public ClientUser() { }

  public ClientUser(Int32 nationalId, string password, string email)
  {
    this.NationalID = nationalId;
    this.Password = password;
    this.Email = email;
  }

  public void VerifiUser()
  {
    this.UserVerfied = true;
    this.EmailVerfied = true;
  }
  public bool UserVerfied { get; private set; }

  public string Password { get; set; } = string.Empty;

  public string Email { get; set; } = string.Empty;

  public bool EmailVerfied { get; private set; }
  
  public Int32 NationalID { get; set; }

}
