using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;
using backend.Domain.Cores;
using backend.Infrastucture;
using backend.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using backend.Domain.Cores.AchiveAggregate;
using backend.Models.AchiveDtos;
using AutoMapper;
using backend.Domain.Cores.TokenAggregate;
using backend.Models.TokenDtos;
using backend.Domain.Cores.TargetAggregate;
using backend.Models.TargetDtos;
using backend.Models.Targets;


namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AchiveController:ControllerBase
    {
        private readonly exinDBContext _dBContext;
        private readonly IMapper _mapper;
        private readonly IAchiveRepository _achiveRepository;
        private readonly ITokenRepository _tokenRepository;

        public AchiveController(exinDBContext exinDBContext,IAchiveRepository achiveRepository,IMapper mapper,ITokenRepository tokenRepository)
        {
            exinDBContext=_dBContext;
          mapper=_mapper;
            achiveRepository = _achiveRepository;
            tokenRepository = _tokenRepository;
        }
        public async Task<ActionResult<TokenDto>> CheckTokenAsync(Token token)
        {
            var item = await _tokenRepository.CheckTokenAsync(token);

            if (item is null)
            {
                return NotFound($"UserId{token}notfound");
            }

            var tokenmodel = _mapper.Map<Token>(item);
            return Ok(tokenmodel);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AchiveDto>> GetAchiveByIdAsync(Guid id, Token token)
        {
            if (CheckTokenAsync(token) != null)
            {
                var achive = await _achiveRepository.GetAchiveByIdAsync(id, token);
                if (achive is null)
                {
                    return NotFound($"achiveId{id}not found");
                }
                var achiveDto = _mapper.Map<AchiveDto>(achive);
                return Ok(achiveDto);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<AchiveDto>> AddAchiveAsync(Achive achive, Token token, AchiveForAddDto achiveForAddDto)
        {
            if (CheckTokenAsync(token) != null)
            {
                var _achive = _mapper.Map<AchiveDto>(achiveForAddDto);
                await _achiveRepository.AddAchiveAsync(achive, token);
                var achiveDto = _mapper.Map<AchiveDto>(_achive);
                return Ok(achiveDto);
            }
            else
            {
                return NoContent();
            }
        }
        [HttpPut("{Id}")]
        public async Task<ActionResult<AchiveDto>> EditeAchiveAsync(Guid Id, Token token, AchiveForEditeDto achiveForEditeDto)
        {
            if (CheckTokenAsync(token) != null)
            {
                var achive = await _achiveRepository.GetAchiveByIdAsync(Id, token);
                if (achive is null)
                {
                    return NotFound($"achiveid{Id}notfound");

                }
                _mapper.Map(achive, achiveForEditeDto);
                return Ok(achive);
            }
            return BadRequest();
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult<AchiveDto>> DeleteAchiveAsync(Guid Id, Token token)
        {
            if (CheckTokenAsync(token) != null)
            {
                var target = await _achiveRepository.GetAchiveByIdAsync(Id, token);
                if (target is null)
                {
                    return NotFound($"achiveid{Id}notfound");
                }
                await _achiveRepository.DeleteAchiveAsync(Id, token);
                return Ok();
            }
            return BadRequest();
        }


    }
}
