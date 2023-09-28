using BBDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDomain.Repositories
{
    public class ManagePostRepository : IManagePostRepository
    {
        private readonly ApplicationDBContext _context;

        public ManagePostRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Post> GetPosts()
        {
            return _context.Posts
                    .Include(s => s.PostCategory)
                    .ThenInclude(x=> x.Category)
                    .ThenInclude(s => s.SubCategories)
                    .ThenInclude(s => s.InteriorCategories).ToList();
        }
        public Post? GetPost(int idPost)
        {
            return _context.Posts.Include(s => s.PostCategory).Where(x => x.Id == idPost).FirstOrDefault(); ;
        }

        public Post AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post;
        }

        public Post EditPost(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
            return post;
        }
    }
}
