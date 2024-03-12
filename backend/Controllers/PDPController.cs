using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;
using backend.Domain.Cores;
using backend.Infrastucture;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PDPController:ControllerBase
    {
        private readonly exinDBContext _dBContext;
        public PDPController(exinDBContext dBContext)
        {
            dBContext = _dBContext;
        }
    }
}
