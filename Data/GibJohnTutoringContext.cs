using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GibJohnTutoring.Models;

namespace GibJohnTutoring.Data
{
    public class GibJohnTutoringContext : DbContext
    {
        public GibJohnTutoringContext (DbContextOptions<GibJohnTutoringContext> options)
            : base(options)
        {
        }

        public DbSet<GibJohnTutoring.Models.BookTutor> BookTutor { get; set; } = default!;
    }
}
