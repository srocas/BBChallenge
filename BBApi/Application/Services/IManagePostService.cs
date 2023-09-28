using BBApplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBApplication.Services
{
    public interface IManagePostService
    {
        public List<PostDTO> GetPosts();
        public bool AddPost(PostDTO postDto);
        public bool EditPost(PostDTO postDto);
    }
}
