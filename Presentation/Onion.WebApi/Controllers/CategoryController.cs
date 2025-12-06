using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.DTOs;
using Onion.Application.IManagers;
using Onion.WebApi.Models.RequestModels.Books;
using Onion.WebApi.Models.ResponseModels.Categories;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IMapper _mapper;
       
        public CategoryController(ICategoryManager categoryManager,IMapper mapper)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> CategoriesList()
        {
            List<CategoryDTO> values = await _categoryManager.GetAllAsync();
            List<CategoryResponseModel> responseModel = _mapper.Map<List<CategoryResponseModel>>(values);
            return Ok(responseModel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            CategoryDTO value = await _categoryManager.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoryResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestModel model)
        {
            CategoryDTO category = _mapper.Map<CategoryDTO>(model);
            await _categoryManager.CreateAsync(category);
            return Ok("Veri ekleme basarılıdır");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryRequestModel model)
        {
            CategoryDTO category = _mapper.Map<CategoryDTO>(model);
            await _categoryManager.UpdateAsync(category);
            return Ok("Veri güncelleme basarılıdır");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PacifyCategory(int id)
        {
            string mesaj =  await _categoryManager.SoftDeleteAsync(id);
            return Ok(mesaj);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            string mesaj = await _categoryManager.HardDeleteAsync(id);
            return Ok(mesaj);
        }
    }
}
