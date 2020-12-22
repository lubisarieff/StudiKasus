using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StudiKasus.Models;

namespace StudiKasus.Data
{
    public class StudiKasusContext : DbContext
    {
        public StudiKasusContext (DbContextOptions<StudiKasusContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
            string path = Directory.GetCurrentDirectory();
            var status = new Dictionary<int, string>()
            {
                { 1, "ACTIVE"},
                { 2, "INACTIVE"},
                { 3, "EXPIRED"}
            };

            var usersFromJson = new List<User>();
            using (StreamReader reader = new StreamReader($@"{path}\Data\users.json"))
			{
                string json = reader.ReadToEnd();
                usersFromJson = JsonConvert.DeserializeObject<List<User>>(json);
			}

            var users = new List<User>();
            int id = 1;

            foreach (var u in usersFromJson)
            {
                users.Add(new User()
                {
                    Id = id,
                    Name = u.Name,
                    UserName = u.UserName,
                    Email = u.Email,
                    Status = status[new Random().Next(1,3)],
                    Phone = u.Phone
                });
                
                id++;
			}

            modelBuilder.Entity<User>().HasData(users);
		}
	}
}
