using GreenFoxQuizApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxQuizApp.Entities
{
    public class GreenFoxQuizAppContext : DbContext
    {
        public GreenFoxQuizAppContext(DbContextOptions<GreenFoxQuizAppContext> options): base(options)
        {

        }

        public DbSet<Quiz> Quizes { get; set; }

    }
}
