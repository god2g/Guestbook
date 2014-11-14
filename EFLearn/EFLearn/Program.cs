using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BloggingContext>());
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name))
                {
                    var blog = new Blog { Name = name };
                    db.Blogs.Add(blog);
                    db.SaveChanges();
                }

                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");

            }
        }
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
    }

    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}
