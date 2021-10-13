using BlogSystem.Data;
using BlogSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Logic
{
    public interface IBlogLogic
    {
        Blog GetBlogById(int id);
        void ChangeBlogTitle(int id, string newTitle);
        IList<Blog> GetAllBlogs();
    }


    public class BlogLogic : IBlogLogic
    {
        IBlogRepository blogRepo;

        public BlogLogic(IBlogRepository repo) // DEP. INJ.
        {
            this.blogRepo = repo;
        }

        public void ChangeBlogTitle(int id, string newTitle)
        {
            blogRepo.ChangeTitle(id, newTitle);
        }

        public IList<Blog> GetAllBlogs()
        {
            return blogRepo.GetAll().ToList();
        }

        public Blog GetBlogById(int id)
        {
            return blogRepo.GetOne(id);
        }
    }
}
