using BackAPI.Entity;
using BackAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace BackAPI.Services
{
    public class UserService : IUserService
    {
        public async Task<bool> AddUsers(UserModel userModel)
        {
            using var context = new Context();

            var user = new User
            {

                Name = GetRandomStr(),
                Lastname = GetRandomStr(),
                CreatedDate = GetRandomDate(),
                Email = GetRandomStr(),

                Password = GetRandomStr(),
            };

            context.Users.Add(user);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<List<User>> GetAllUsers()
        {
            using var context = new Context();
            return await context.Users.ToListAsync();
        }

        public async Task<bool> RemoveUsers()
        {
            using (var context = new Context())
            {
                var user = context.Users.FirstOrDefault();
                if (user != null)
                {
                    context.Users.Remove(user);
                }
            }
            return true;
        }
        private static string GetRandomStr()
        {
            int x = GetRandomInt(4, 10);

            string str = "";
            var r = new Random();
            while (str.Length < x)
            {
                char c = (char)r.Next(33, 125);
                if (char.IsLetterOrDigit(c))
                    str += c;
            }
            return str;
        }

        private static int GetRandomInt(int from, int to)
        {
            var dig = new Random();
            int x = dig.Next(from, to);
            return x;
        }

        private static DateTime GetRandomDate()
        {
            var gen = new Random();
            var start = new DateTime(1995,1,1);
            int range = (new DateTime(2006,1,1) - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
