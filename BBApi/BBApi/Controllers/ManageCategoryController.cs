using BBApplication.DTOs;
using BBApplication.Services;
using BBDomain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace BBApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManageCategoryController : ControllerBase
    {
        private readonly IManageCategoryService _manageCategoryService;
        public ManageCategoryController(IManageCategoryService manageCategoryService) 
        {
            _manageCategoryService = manageCategoryService;
        }
        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            try
            {
               
                return Ok(_manageCategoryService.GetCategories());
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("subcategories/{idCategory}")]
        public IActionResult GetSubCategories(int idCategory)
        {
            try
            {
                return Ok(_manageCategoryService.GetSubCategoriesByIdCategory(idCategory));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpGet("interiorcategories/{idSubCategory}")]
        public IActionResult GetInteriorCategories(int idSubCategory)
        {
            try
            {
                return Ok(_manageCategoryService.GetInteriorCategoriesByIdSubCategory(idSubCategory));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("category")]
        public IActionResult AddCategory(CategoryDTO category)
        {
            try
            {
                return Ok(_manageCategoryService.AddCategory(category));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPost("subCategory")]
        public IActionResult AddSubCategory(SubCategoryDTO subCategory)
        {
            try
            {
                return Ok(_manageCategoryService.AddSubCategory(subCategory));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPost("interiorCategory")]
        public IActionResult AddInteriorCategory(InteriorCategoryDTO interiorCategory)
        {
            try
            {
                return Ok(_manageCategoryService.AddInteriorCategory(interiorCategory));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPut("category")]
        public IActionResult EditCategory(CategoryDTO category)
        {
            try
            {
                if (_manageCategoryService.EditCategory(category))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPut("subCategory")]
        public IActionResult EditSubCategory(SubCategoryDTO subCategory)
        {
            try
            {
                if (_manageCategoryService.EditSubCategory(subCategory))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPut("interiorCategory")]
        public IActionResult EditInteriorCategory(InteriorCategoryDTO interiorCategory)
        {
            try
            {
                if (_manageCategoryService.EditInteriorCategory(interiorCategory))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpDelete("category/{idCategory}")]
        public IActionResult DeleteCategory(int idCategory)
        {
            try
            {
                if (_manageCategoryService.DeleteCategory(idCategory))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpDelete("subCategory/{idSubCategory}")]
        public IActionResult DeleteSubCategory(int idSubCategory)
        {
            try
            {
                if (_manageCategoryService.DeleteSubCategory(idSubCategory))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpDelete("interiorCategory/{idInteriorCategory}")]
        public IActionResult DeleteInteriorCategory(int idInteriorCategory)
        {
            try
            {
                if (_manageCategoryService.DeleteInteriorCategory(idInteriorCategory))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
