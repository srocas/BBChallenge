using BBApplication.DTOs;
using BBApplication.Services;
using BBDomain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace BBApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagePostController : ControllerBase
    {
        private readonly IManagePostService _managePostService;
        public ManagePostController(IManagePostService managePostService) 
        {
            _managePostService = managePostService;
        }
        [HttpGet("posts")]
        public IActionResult GetPosts()
        {
            try
            {
               
                return Ok(_managePostService.GetPosts());
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPost("post")]
        public IActionResult AddPost(PostDTO postDto)
        {
            try
            {
                return Ok(_managePostService.AddPost(postDto));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("post")]
        public IActionResult EditPost(PostDTO postDto)
        {
            try
            {
                return Ok(_managePostService.EditPost(postDto));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
