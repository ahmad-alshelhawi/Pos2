using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pos2.entities;
using Pos2.Models;
using Pos2.services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pos2.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepestory _category;
        private readonly IMapper _mapper;

        public CategoriesController(IMapper mapper, ICategoryRepestory category)
        {
            _mapper = mapper;
            _category = category;
        }

        [HttpGet("Get_all_categories")]
        public async Task<ActionResult<CategoryMapper[]>> get()
        {
            var categories = await _category.getAllCategories();
            return Ok(_mapper.Map<CategoryMapper[]>(categories));
        }


        [HttpGet("get_by_ID{id:int}")]
        public async Task<ActionResult<CategoryMapper>> getById(int id)
        {
            var category = await _category.getById(id);
            return Ok(_mapper.Map<CategoryMapper>(category));
        }

        [HttpPost("Add_Category")]
        public async Task<IActionResult> create(int id, string Name, DateOnly Date)
        {
            await _category.createCategory(id, Name, Date);
            return Ok(new { status = "Category Created successfully" });

        }

        [HttpPost("update:{id:int}")]
        public async Task<IActionResult> update(int id, string Name, DateOnly Date)
        {
            await _category.updateCategory(id, Name, Date);
            return Ok(new { status = "Category updated successfully" });
        }

        [HttpDelete("delete:{id:int}")]
        public async Task<IActionResult> delete(int id)
        {
            var category = await _category.getById(id);
            await _category.deleteCategory(id);
            return Ok(new { status = "Category deleted successfully" });

        }


    }
}
