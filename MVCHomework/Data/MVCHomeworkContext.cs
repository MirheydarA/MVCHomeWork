using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCHomework.Models;

namespace MVCHomework.Data
{
    public class MVCHomeworkContext : DbContext
    {
        public MVCHomeworkContext (DbContextOptions<MVCHomeworkContext> options)
            : base(options)
        {
        }

        public DbSet<MVCHomework.Models.Movie> Movie { get; set; } = default!;
    }
}
