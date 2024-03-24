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


    }
}
