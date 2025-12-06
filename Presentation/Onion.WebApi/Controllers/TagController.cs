using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.DTOs;
using Onion.Application.IManagers;
using Onion.WebApi.Models.RequestModels.Books;
using Onion.WebApi.Models.ResponseModels.Tags;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagManager _tagManager;
        private readonly IMapper _mapper;

        public TagController(ITagManager tagManager, IMapper mapper)
        {
            _tagManager = tagManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> TagsList()
        {
            List<TagDTO> values = await _tagManager.GetAllAsync();
            List<TagResponseModel> responseModel = _mapper.Map<List<TagResponseModel>>(values);
            return Ok(responseModel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTag(int id)
        {
            TagDTO value = await _tagManager.GetByIdAsync(id);
            return Ok(_mapper.Map<TagResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagRequestModel model)
        {
            TagDTO tag = _mapper.Map<TagDTO>(model);
            await _tagManager.CreateAsync(tag);
            return Ok("Veri ekleme basarılıdır");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagRequestModel model)
        {
            TagDTO tag = _mapper.Map<TagDTO>(model);
            await _tagManager.UpdateAsync(tag);
            return Ok("Veri güncelleme basarılıdır");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PacifyTag(int id)
        {
            string mesaj = await _tagManager.SoftDeleteAsync(id);
            return Ok(mesaj);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTag(int id)
        {
            string mesaj = await _tagManager.HardDeleteAsync(id);
            return Ok(mesaj);
        }
    }
}
