using Microsoft.AspNetCore.Mvc;
using backend.Infrastucture;
using AutoMapper;
using backend.Domain.Cores.TargetAggregate;
using backend.Domain.Cores.TokenAggregate;
using backend.Models.TokenDtos;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PDPController : ControllerBase
    {
        private readonly exinDBContext _dBContext;
        private readonly IMapper _mapper;
        private readonly ITargetRepository _targetRepository;
        private readonly ITokenRepository _tokenRepository;
        private readonly ISubTaskService _subTaskService;
        public PDPController(exinDBContext dBContext, ITargetRepository targetRepository, IMapper mapper, ITokenRepository tokenRepository, ISubTaskService subTaskService)
        {
            dBContext = _dBContext;
            targetRepository = _targetRepository;
            mapper = _mapper;
            tokenRepository = _tokenRepository;
            _subTaskService = subTaskService;
        }
        //public async Task<ActionResult<Token>> GetTokenAsync(Token token)
        //{
            
        //}

        public async Task<ActionResult<TokenDTO>> CheckTokenAsync(Token token)
        {
            var item=await _tokenRepository.CheckTokenAsync(token);
           
            if (item is null) { 
                return  NotFound($"UserId{token}notfound");
            }
            
            var tokenmodel=_mapper.Map<Token>(item);
            return Ok(tokenmodel);

        }
        [HttpGet("{token}")]
        public async Task<ActionResult<TargetDTO>> GetTargetByIdAsync([FromRoute] Guid id,Token token)
        {
            if (CheckTokenAsync(token)!=null)
            {
                var target=await _targetRepository.GetTargetByIdAsync(id,token);
                if (target is null)
                {
                    return NotFound($"targetId{id}not found");
                }
                var targetDto=_mapper.Map<TargetDTO>(target);
                return Ok(targetDto);
            }

        }

        [HttpPost]
        public async Task<ActionResult<TargetDTO>> AddTargetAsync(Target target, Token token)
        {
            if (CheckTokenAsync(token) != null)
            {
                
            }
            else
            {
                return NoContent();
            }
        }
        [HttpPut("{targetId}")]
        public async Task<ActionResult<TargetDTO>> EditeTargetAsync(Guid targetId, Token token)
        {

        }
        [HttpDelete("{targetId}")]
        public async Task<ActionResult<TargetDTO>> DeleteTargetAsync(Guid targetId, Token token)
        {

        }
        public async Task<ActionResult<TargetDTO>> GetSubTaskByIdAsync(Guid id, Token token)
        {

        }

        [HttpPost]
        public async Task<ActionResult<TargetDTO>> AddSubTaskAsync(Target target, Token token)
        {

        }
        public async Task<ActionResult<TargetDTO>> EditeSubTaskAsync(Guid targetId, Token token)
        {

        }
        [HttpDelete("{subtaskId}")]
        public async Task<ActionResult<TargetDTO>> DeleteSubTaskAsync(Guid  subtaskId, Token token)
        {

        }

        public async Task<ActionResult<TargetDTO>> CheckStatusTaskAsync(Guid subtaskId)
        {

        }


    }
}
