#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcEmployeeDetails.Models;

namespace MvcEmployeeDetails.Data
{
    public class MvcEmployeeDetailsContext : DbContext
    {
        public MvcEmployeeDetailsContext (DbContextOptions<MvcEmployeeDetailsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcEmployeeDetails.Models.Employee> Employee { get; set; }
    }
}
