using KresaLTD.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KresaLTD.Infrastructure.Data.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }

        private static List<User> CreateUsers()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            var user = new User()
            {
                Id = "beb93b68-264f-4784-a221-37a5ca33e0cc",
                UserName = "yulian",
                NormalizedUserName = "YULIAN",
                Email = "yuliantsvetkov@gmail.com",
                NormalizedEmail = "YULIANTSVETKOV@GMAIL.COM",
                PhoneNumber = "0888278055",
                FirstName = "Yulian",
                LastName = "Tsvetkov",
                City = "Kazanlak",
                Address = "Edelvais ",
                Country = "Bulgaria",
            };

            user.PasswordHash =
                 hasher.HashPassword(user, "123456");

            users.Add(user);

            return users;
        }
    }
}
