using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class FieldEdgeDBContext : DbContext
    {
        public FieldEdgeDBContext(DbContextOptions<FieldEdgeDBContext> options) : base(options)
        {
        }

        public DbSet<CustomerMaster> CustomerMaster { get; set; }

    }
}
