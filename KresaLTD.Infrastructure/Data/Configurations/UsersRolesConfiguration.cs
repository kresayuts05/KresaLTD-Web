using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KresaLTD.Infrastructure.Data.Configurations
{
    public class UsersRolesConifiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(GiveUsersRoles());
        }

        private List<IdentityUserRole<string>> GiveUsersRoles()
        {
            var users = new List<IdentityUserRole<string>>();

            users.Add(new IdentityUserRole<string>()
            {
                RoleId = "74796ebf-6d17-411a-8e53-93e95b459fb7",
                UserId = "beb93b68-264f-4784-a221-37a5ca33e0cc"
            });

            return users;
        }
    }
}
