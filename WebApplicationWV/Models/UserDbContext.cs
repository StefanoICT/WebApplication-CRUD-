using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationWV.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            LoadDefaultUsers();
        }

        public List<User> getUsers() => Users.Local.ToList<User>();
        //dit is een verandering voor de github sync
        private void LoadDefaultUsers()
        {
            Users.Add(new User { UserId = 100L, DateOfBirth = DateTime.Now, FirstName = "Stefano" });
            Users.Add(new User { UserId = 200L, DateOfBirth = DateTime.Now, FirstName = "Alpha" });
        }
    }
}
