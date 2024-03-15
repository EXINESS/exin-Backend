using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;
using backend.Domain.Cores;
using backend.Infrastucture;
using backend.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PDPController:ControllerBase
    {
        private readonly exinDBContext _dBContext;
        private readonly ITargetService _targetService;
        private readonly ISubTaskService _subTaskService;

        public PDPController(exinDBContext dBContext)
        {
            dBContext = _dBContext;
         
        }

        [HttpGet]
        public ActionResult<IEnumerable<Target>> Get()
        {
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
        public ActionResult Remove(Guid id)
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
