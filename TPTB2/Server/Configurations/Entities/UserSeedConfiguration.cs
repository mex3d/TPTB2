using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPTB2.Shared.Domain;

namespace TPTB2.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                     new User
                     {
                     Id = 1,
                     Username = "DickRooster",
                     Contact = "99999998",
                     DateOfBirth = "22.03.1969",
                     Email = "FloppyDisk@gmail.com",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                    },
                     new User
                     {
                         Id = 2,
                         Username = "ArnoldSchwarzenegger",
                         Contact = "99999997",
                         DateOfBirth = "30.07.1947",
                         Email = "GigaChad@gmail.com",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         UpdatedBy = "System"
                     }
         );

        }
    }
}
