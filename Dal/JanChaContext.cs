using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Model;
namespace Dal
{
    public class JanChaContext:DbContext
    {
        public JanChaContext(DbContextOptions<JanChaContext> options)
            : base(options)
        {
        }

        public DbSet<Stu> Movies { get; set; }
    }
}
