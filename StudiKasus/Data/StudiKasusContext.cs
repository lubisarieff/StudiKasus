using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudiKasus.Models;

namespace StudiKasus.Data
{
    public class StudiKasusContext : DbContext
    {
        public StudiKasusContext (DbContextOptions<StudiKasusContext> options)
            : base(options)
        {
        }

        public DbSet<StudiKasus.Models.User> User { get; set; }
    }
}
