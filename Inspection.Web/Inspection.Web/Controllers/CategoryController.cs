using Inspection.Application.Categories;
using Inspection.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inspection.Web.Controllers
{
    public class CategoryController : BaseController
    {
        /// <summary>
        /// GetCategories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return await Mediator.Send(new List.Query());
        }

        /// <summary>
        /// GetCategory
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        /// <summary>
        /// CreateCategory
        /// </summary>
        /// <param name="Category"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Category Category)
        {
            return Ok(await Mediator.Send(new Create.Command { Category = Category }));
        }

        /// <summary>
        /// UpdateCategory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Category"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(Guid id, Category Category)
        {
            Category.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Category = Category }));
        }

        /// <summary>
        /// DeleteCategory
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Category"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}
