using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the database operation...");
            var _dbContext = new CodeFirstContext();
            var post = new Post()
            {
                Title = "My second post",
                Description = "My second post",
                CreatedDate = DateTime.Now
            };
            _dbContext.Posts.Add(post);
            _dbContext.SaveChanges();
            Console.WriteLine("Successfully saved in the database");
            Console.ReadKey();
        }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
    }

    public class CodeFirstContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }

}
