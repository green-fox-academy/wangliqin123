using Microsoft.EntityFrameworkCore;
using RedditApp.Models;

namespace RedditApp.Entities
{
    public class RedditContext : DbContext
    {
        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {
        }

        public DbSet<Reddit> Posts { get; set; }
    }
}