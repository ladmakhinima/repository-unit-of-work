using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Core.Domains;

namespace WebApi.Core.Contexts
{
    public class WebApiCoreDBContext : DbContext
    {
        public WebApiCoreDBContext(DbContextOptions options) : base(options) { }

        #region Database Tables
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        #endregion

        #region Database Configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.;Database=LearnRepoDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        #endregion


    }
}
