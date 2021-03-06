using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<NvdrRecord> NvdrRecords { get; set; }
        public DbSet<NvdrEmail> NvdrEmails { get; set; }
        public DbSet<NvdrFaultEmail> NvdrFaultEmails { get; set; }


    }

}
