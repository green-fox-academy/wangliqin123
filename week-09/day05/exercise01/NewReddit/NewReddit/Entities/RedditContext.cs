using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewReddit.Entities
{
    public class RedditContext :DbContext
    {
        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {
        }        
    }
}