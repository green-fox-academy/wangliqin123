using RedditApp.Entities;
using RedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Repositories
{
    public class RedditRepository
    {
        RedditContext RedditContext;

        public RedditRepository(RedditContext redditContext)
        {
            RedditContext = redditContext;
        }

        public List<Reddit> GetList()
        {
            return RedditContext.Posts.ToList();
        }
    }
}