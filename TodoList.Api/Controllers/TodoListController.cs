using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TodoList.Api.Models;
using TodoList.Api.Service;

namespace TodoList.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TodoListController : ControllerBase
    {
        private readonly ITodoListService _todoListService;
        public TodoListController(ITodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlans()
        {
            var plans = await _todoListService.GetPlans();
            return Ok(plans);
        }

        [HttpGet("{Id:int}")]
        public async Task<IActionResult> GetPlan(int Id)
        {
            var plan = await _todoListService.GetPlan(Id);
            return Ok(plan);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlan(Plan plan)
        {
            var result = await _todoListService.CreatePlan(plan);
            return Ok(result);
        }

        [HttpDelete("{Id:int}")]
        public async Task<IActionResult> DeletePlan(int Id)
        {
            var result = await _todoListService.DeletePlan(Id);
            return Ok(result);
        }

        [HttpPut("{Id:int}")]
        public async Task<IActionResult> UpdatePlan(int Id, Plan plan)
        {
            var result = await _todoListService.UpdatePlan(Id, plan);
            return Ok(result);
        }
    }
}
