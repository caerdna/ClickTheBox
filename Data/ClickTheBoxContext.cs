using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClickTheBox.API.Models;

namespace ClickTheBox.Data
{
    public class ClickTheBoxContext : DbContext
    {
        public ClickTheBoxContext (DbContextOptions<ClickTheBoxContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Player { get; set; } = default!;
    }
}
