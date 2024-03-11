using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;
using backend.Domain.Cores;
using backend.Infrastucture;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDPController:ControllerBase
    {
        private readonly exinDBContext _dBContext;
        public TargetController(exinDBContext dBContext)
        {
            dBContext = _dBContext;
        }
    }
}
