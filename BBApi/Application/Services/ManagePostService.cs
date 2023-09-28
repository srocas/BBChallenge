using AutoMapper;
using BBApplication.DTOs;
using BBDomain.Entities;
using BBDomain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBApplication.Services
{
    public class ManagePostService : IManagePostService
    {
        private readonly IMapper _mapper;
        private readonly IManagePostRepository _managePostRepository;
        public ManagePostService(IManagePostRepository managePostRepository, IMapper mapper) {
            _managePostRepository = managePostRepository;
            _mapper= mapper;
        }
        public List<PostDTO> GetPosts()
        {
            var posts = _managePostRepository.GetPosts();
            return _mapper.Map<List<PostDTO>>(_managePostRepository.GetPosts());
        }
        public bool AddPost(PostDTO postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            return _managePostRepository.AddPost(post).Id > 0;
        }

        public bool EditPost(PostDTO postDto)
        {
            var post = _managePostRepository.GetPost(postDto.Id);
            if (post is null)
            {
                return false;
            }

            post.PostCategory.RemoveAll(x => x.Id > 0);
            post.PostCategory= _mapper.Map<List<PostCategory>>(postDto.PostCategory);
            return _managePostRepository.EditPost(post).Id > 0;
        }
    }
}
