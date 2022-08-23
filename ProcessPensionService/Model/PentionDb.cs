using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessPensionService.Model
{
    public class PentionDb : DbContext
    {
        public PentionDb()
        { 
        }


        public PentionDb(DbContextOptions<PentionDb> options) : base(options)
        { 
        
        }

        public DbSet<ProcessPension> ProcessPensions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:pmsdatabase.database.windows.net,1433;Initial Catalog=ProcessPension;Persist Security Info=False;User ID=azureroot;Password=abhinav@195;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
             
            }

        
        }

    }
}
