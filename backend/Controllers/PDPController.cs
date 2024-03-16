using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;
using backend.Domain.Cores;
using backend.Infrastucture;
using backend.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Configuration;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PDPController:ControllerBase
    {
        private readonly exinDBContext _dBContext;
        private readonly ITargetService _targetService;
        private readonly ISubTaskService _subTaskService;
        private string TokenChecker(string token)
        {
            string _token = new Token().token;
            if (token == _token)
            {
                if ()
                {
                    
                }
            }
            else
            {
               return "Invalid Token";
            }


        }

        public PDPController(exinDBContext dBContext)
        {
            dBContext = _dBContext;
         
        }

        [HttpGet("{token}")]
        public ActionResult<IEnumerable<Target>> Get(string token)
        {
            //token=
            var items=_targetService.GetAll();
           
            return Ok(items);
        }
        //[HttpGet]
        //public ActionResult<IEnumerable<SubTask>> Get()
        //{
        //    var items = _subTaskService.GetAll();
        //    return Ok(items);
        //}

        [HttpGet("{id}")]
        public ActionResult<Target> Get(Guid id)
        {
            var item = _targetService.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(Guid id,string token)
        {
            var existingItem = _targetService.GetById(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            _targetService.DelTarget(id);
            return Ok();
        }
        //[HttpDelete("{id}")]
        //public ActionResult Remove(Guid id)
        //{
        //    var existingItem = _subTaskService.GetById(id);

        //    if (existingItem == null)
        //    {
        //        return NotFound();
        //    }

        //   _subTaskService.DelSubTask(id);
        //    return Ok();
        //}
    }
}
