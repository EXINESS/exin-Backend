using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models.Targets;
using backend.Infrastucture;
namespace backend.Domain.Contracts
{
    [Route("api/[controller]")]
    [ApiController]
    public class TargetController:ControllerBase
    {
        private readonly exinDBContext _dBContext;
        public TargetController(exinDBContext dBContext )
        {
            dBContext = _dBContext;
        }
    }
}
