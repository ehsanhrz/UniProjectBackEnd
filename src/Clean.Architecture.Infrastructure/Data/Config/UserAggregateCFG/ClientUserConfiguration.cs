using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clean.Architecture.Core.UserAggregate;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Clean.Architecture.Infrastructure.Data.Config.UserAggregateCFG;
public class ClientUserConfiguration : IEntityTypeConfiguration<ClientUser>
{
  public void Configure(EntityTypeBuilder<ClientUser> builder)
  {
    builder.ToTable(nameof(ClientUser));

    builder.HasIndex(p => p.NationalID).IsUnique();

    builder.HasKey(p => p.Id);

    builder.Property<string>(p => p.Password).IsRequired();

    builder.Property<bool>(p => p.UserVerfied).IsRequired();

    builder.Property<bool>(p => p.EmailVerfied).IsRequired();

    builder.Property<string>(p => p.Email);

    builder.Property<Int32>(p => p.NationalID).IsRequired();

  }
}
