using BBDomain.Entities;

namespace BBDomain.Repositories
{
    public interface IManagePostRepository
    {
        public List<Post> GetPosts();
        public Post? GetPost(int idPost);
        public Post AddPost(Post post);
        public Post EditPost(Post post);
    }
}
