using BlogSystem.Data;
using BlogSystem.Logic;
using BlogSystem.Repository;
using System;
using System.Linq;

namespace BlogSystem.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogContext ctx = new BlogContext();
            BlogRepository repo = new BlogRepository(ctx);
            BlogLogic logic = new BlogLogic(repo);

            ListAll(logic);

        }

        private static void ListAll(BlogLogic logic)
        {
            Console.WriteLine("\n:: ALL BLOGS ::\n");

            logic.GetAllBlogs()
                .ToList()
                .ForEach(x => Console.WriteLine(x.MainData));

            Console.ReadLine();
        }
    }
}
