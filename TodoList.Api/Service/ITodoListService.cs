using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Api.Models;

namespace TodoList.Api.Service
{
    public interface ITodoListService
    {
        Task<IEnumerable<Plan>> GetPlans();
        Task<Plan> GetPlan(int Id);
        Task<Plan> UpdatePlan(int Id, Plan plan);
        Task<Plan> DeletePlan(int Id);
        Task<Plan> CreatePlan(Plan plan);

    }
}
