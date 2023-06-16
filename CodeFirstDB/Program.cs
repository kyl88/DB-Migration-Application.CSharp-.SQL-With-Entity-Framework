using System;
using System.Data.Entity;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DatePublished { get; set; } 
    }
    internal class Program
    {

        public class BlogDbContext: DbContext
        {
            public DbSet<Post> Posts { get; set; }  
        }
        static void Main(string[] args)
        {
           
        }
    }
}