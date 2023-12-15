
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Users.Any()) return;
            
            var users = new List<User>
            {
                new User
                {
                    Name = "Anil",
                    City = "Pune",
                    Email = "anil@gmail.com",
                    DateOfBirth = DateTime.UtcNow.AddYears(-35),
                    Gender = "Male",
                    Education = "B.E",
                },
                new User
                {
                    Name = "Marie",
                    City = "Delhi",
                    Email = "marie@gmail.com",
                    DateOfBirth = DateTime.UtcNow.AddYears(-25),
                    Gender = "Female",
                    Education = "M.E",
                },
                
            };

            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();
        }
    }
}