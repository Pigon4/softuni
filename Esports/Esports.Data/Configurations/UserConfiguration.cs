using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Esports.DataModels;
using Microsoft.AspNetCore.Identity;

namespace Esports.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(GenerateUsers());   
        }

        public List<ApplicationUser> GenerateUsers()
        {
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            List<ApplicationUser> users = new List<ApplicationUser>();
            ApplicationUser user = new ApplicationUser
            {
                Id = Guid.Parse("f54a976d-7fd7-4b63-85d5-e4e21acf66e8"),
                UserName = "Pigon",
                Email = "lachezar10@abv.bg",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 44,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "Qw12345!"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("28ff8e0a-d24b-417a-82a3-cd1f0c9df182"),
                UserName = "Ash_aimed",
                Email = "Ash.aimed.15@gmail.com",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 16,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "5e2-A0818"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("ccdd2512-6b29-4b7a-9175-0a3be6be13b4"),
                UserName = "rich jermaine",
                Email = "RichJer@gmail.com",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 25,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "fD-8E43-89"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("07b3d80f-c301-45ae-8e59-27926862c2f5"),
                UserName = "FncFan",
                Email = "fncnumberone@gmail.com",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 7,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "1-310AFf0C944C"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("2405e5fe-aad2-452d-8655-5245baee9f2a"),
                UserName = "saddd",
                Email = "depression@gmail.com",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 13,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "a-87C8ABC810F5"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("b6d3f7cb-eef3-43e6-ba6a-ab2cae8aad24"),
                UserName = "Lazy asperger",
                Email = "shouldvestartearlier@gmail.com",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 31,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "CAea0-4CD2-45C"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("fda99316-de5d-45a1-a2fc-fabc5e74efbb"),
                UserName = "Brezho",
                Email = "Brezhovica@yahoo.com",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 34,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "570-05dE-489"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("d6bad4f5-34a8-4313-b86f-b36b8898d130"),
                UserName = "du44",
                Email = "Drago_Ussopp@gmail.com",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 18,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "0Ee3-B5CC"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("926ff209-2068-40ac-a957-a94523b2ffb5"),
                UserName = "the one",
                Email = "pieceisreal@gmail.com",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 1,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "ACCFB0-F085-4dC"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("0971c874-4d75-413a-84bf-9bb817b5227f"),
                UserName = "extravagantly",
                Email = "creative@abv.bg",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 39,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "BF-d1F0-4A40-99D"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("aac7256f-ad4a-4634-a5a8-18f85572331a"),
                UserName = "Jesper",
                Email = "Jesper_Beovarie@gmail.com",
                EmailConfirmed = false,
                HasClaimedFreeReward = true,
                Points = 28,
                PasswordHash = passwordHasher.HashPassword(new ApplicationUser(), "9F8B-48a1-9E0A-87C"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ConcurrencyStamp = Guid.NewGuid().ToString("D"),
                LockoutEnabled = false
            };
            user.NormalizedEmail = user.Email.ToUpper();
            user.NormalizedUserName = user.UserName.ToUpper();
            users.Add(user);

            return users;
        }
    }
}
