using Inspection.Application.Activities;
using Inspection.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inspection.Web.Controllers
{
    public class ActivityController : BaseController
    {
        /// <summary>
        /// GetActivities
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new List.Query());
        }

        /// <summary>
        /// GetActivity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        /// <summary>
        /// CreateActivity
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody] Activity activity)
        {
            return Ok(await Mediator.Send(new Create.Command { Activity = activity }));
        }

        /// <summary>
        /// UpdateActivity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="activity"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateActivity(Guid id, Activity activity)
        {
            activity.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Activity = activity }));
        }

        /// <summary>
        /// DeleteActivity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="activity"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}
