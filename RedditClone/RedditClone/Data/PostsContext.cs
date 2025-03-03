using Microsoft.EntityFrameworkCore;
using RedditClone.Model;

namespace RedditClone.Data;

public class PostsContext
{
    public class TaskContext : DbContext
    {
        public DbSet<Posts> Posts { get; set; }
        public string DbPath { get; }



    }
}