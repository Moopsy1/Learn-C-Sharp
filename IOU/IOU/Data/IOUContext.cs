using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IOU.Models;

namespace IOU.Data
{
    public class IOUContext : DbContext
    {
        public IOUContext (DbContextOptions<IOUContext> options)
            : base(options)
        {
        }

        public DbSet<IOU.Models.User> User { get; set; }

        public DbSet<IOU.Models.IOUSlip> IOUSlip { get; set; }
    }
}
