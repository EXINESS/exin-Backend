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

        [HttpGet("{achiveId}")]
        public async Task<ActionResult<AchiveDto>> GetAchiveAsync(Guid achiveId,Token token)
        {

        }

        [HttpGet("{targetId}")]
        public async Task<ActionResult<TargetDto>> GetTargetAsync(Guid targetId, Token token)
        {

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
