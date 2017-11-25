using CalorieApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieApp.Entities
{
    public class CalorieAppContext : DbContext
    {
        public CalorieAppContext (DbContextOptions<CalorieAppContext> options) : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
    }
}
