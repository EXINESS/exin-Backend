using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;
using backend.Domain.Cores;
using backend.Infrastucture;
using backend.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using AutoMapper;
using backend.Domain.Cores.AchiveAggregate;
using backend.Domain.Cores.TokenAggregate;
using backend.Domain.Cores.TargetAggregate;
using backend.Domain.Cores.SubTaskAggregate;
using backend.Models.Targets;
using backend.Models.SubTaskDtos;
using backend.Models.FeedbackDtos;
using backend.Models.AchiveDtos;
using backend.Domain.Cores.FeedbackAggregate;
using backend.Models.TokenDtos;
using Microsoft.AspNetCore.Authorization;


namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ReportController:ControllerBase
    {
        private readonly exinDBContext _dBContext;
        private readonly IMapper _mapper;
        private readonly IAchiveRepository _achiveRepository;
        private readonly ITokenRepository _tokenRepository;
        private readonly ISubTaskRepository _subTaskRepository;
        private readonly ITargetRepository _targetRepository;
        private readonly IFeedbackRepository _feedbackRepository;

        public ReportController(exinDBContext exinDBContext,IMapper mapper,IAchiveRepository achiveRepository,ITokenRepository tokenRepository,ISubTaskRepository subTaskRepository,ITargetRepository targetRepository,IFeedbackRepository feedbackRepository)
        {
            exinDBContext = _dBContext;
            mapper = _mapper;
            achiveRepository = _achiveRepository;
            tokenRepository = _tokenRepository;
            subTaskRepository = _subTaskRepository;
            targetRepository = _targetRepository;
            feedbackRepository = _feedbackRepository;
        }

        [HttpGet("{token}")]
        public async Task<ActionResult<TokenDto>> GetTokenAsync(Domain.Cores.TokenAggregate.Token token)
        {
            var _token = await _tokenRepository.GetTokenAsync(token);
            if (_token is null)
            {
                return NotFound($"targetId{token}not found");
            }
            var tokenDto = _mapper.Map<TokenDto>(_token);
            return Ok(tokenDto);
        }
        [Authorize]
        public async Task<ActionResult<TokenDto>> CheckTokenAsync(Token token)
        {
            var item = await _tokenRepository.CheckTokenAsync(token);

            if (item is null)
            {
                return NotFound($"UserId{token}notfound");
            }
            else if (item.Timeout > DateTime.Now.TimeOfDay)
            {

                _tokenRepository.DelTokenAsync(token);
                return NotFound($"UserId{token}notfound");
            }
            else
            {
                var tokenmodel = _mapper.Map<Token>(item);
                return Ok(tokenmodel);
            }
        }
        public async Task<ActionResult<TokenDto>> DelTokenAsync(Domain.Cores.TokenAggregate.Token token)
        {
            var _token = await _tokenRepository.GetTokenAsync(token);
            if (token is null)
            {
                return NotFound($"targetid{token}notfound");
            }
            await _tokenRepository.DelTokenAsync(_token);
            return Ok();
        }

        [HttpGet("{achiveId}")]
        public async Task<ActionResult<AchiveDto>> GetAchiveAsync(Guid achiveId,Token token)
        {
            if (CheckTokenAsync(token) != null)
            {
                var achive = await _achiveRepository.GetAchiveByIdAsync(achiveId, token);
                if (achive is null)
                {
                    return NotFound($"achiveId{achiveId}not found");
                }
                var achiveDto = _mapper.Map<AchiveDto>(achive);
                return Ok(achiveDto);
            }
            return Unauthorized();
        }

        [HttpGet("{targetId}")]
        public async Task<ActionResult<TargetDto>> GetTargetAsync(Guid targetId, Token token)
        {
            if (CheckTokenAsync(token) != null)
            {
                var target = await _targetRepository.GetTargetByIdAsync(targetId, token);
                if (target is null)
                {
                    return NotFound($"targetId{targetId}not found");
                }
                var targetDto = _mapper.Map<TargetDto>(target);
                return Ok(targetDto);
            }
            return Unauthorized();
        }

        [HttpGet("{SubtaskId}")]
        public async Task<ActionResult<SubTaskDto>> GetSubtaskAsync(Guid SubtaskId, Token token)
        {

        }

        [HttpGet("{feedbackId}")]
        public async Task<ActionResult<FeedbackDto>> GetFeedbackAsync(Guid feedbackId, Token token)
        {

        }

    }
}
