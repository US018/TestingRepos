using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class AppDbContaxt: DbContext
    {
        public AppDbContaxt(DbContextOptions<AppDbContaxt> options) : base(options)
        {

        }
        public DbSet<DataModel> DataModels { get; set; }

    }
}

