using AutoMapper;
using FilmesAPI.Data;
using Microsoft.AspNetCore.Mvc;
using study_dotnet5.Data.Dtos.Sessao;
using study_dotnet5.Models;
using System.Linq;

namespace study_dotnet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public SessaoController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaSessao(CreateSessaoDto dto)
        {
            Sessao sessao = _mapper.Map<Sessao>(dto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { Id = sessao.Id }, sessao );
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessaoPorId(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);

            if (sessao != null)
            {
                ReadSessaoDto readSessaoDto = _mapper.Map<ReadSessaoDto>(sessao);

                return Ok(readSessaoDto);
            }

            return NotFound();
        }
    }
}
