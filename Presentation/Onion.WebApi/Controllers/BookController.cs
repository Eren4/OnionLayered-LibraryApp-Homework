using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.DTOs;
using Onion.Application.IManagers;
using Onion.WebApi.Models.RequestModels.Books;
using Onion.WebApi.Models.ResponseModels.Books;

namespace Onion.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookManager _bookManager;
        private readonly IMapper _mapper;

        public BookController(IBookManager bookManager, IMapper mapper)
        {
            _bookManager = bookManager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> BooksList()
        {
            List<BookDTO> values = await _bookManager.GetAllAsync();
            List<BookResponseModel> responseModel = _mapper.Map<List<BookResponseModel>>(values);
            return Ok(responseModel);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            BookDTO value = await _bookManager.GetByIdAsync(id);
            return Ok(_mapper.Map<BookResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookRequestModel model)
        {
            BookDTO book = _mapper.Map<BookDTO>(model);
            await _bookManager.CreateAsync(book);
            return Ok("Veri ekleme basarılıdır");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBookRequestModel model)
        {
            BookDTO book = _mapper.Map<BookDTO>(model);
            await _bookManager.UpdateAsync(book);
            return Ok("Veri güncelleme basarılıdır");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PacifyBook(int id)
        {
            string mesaj = await _bookManager.SoftDeleteAsync(id);
            return Ok(mesaj);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBook(int id)
        {
            string mesaj = await _bookManager.HardDeleteAsync(id);
            return Ok(mesaj);
        }
    }
}
