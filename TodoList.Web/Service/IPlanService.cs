using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Web.Models;

namespace TodoList.Web.Service
{
    public interface IPlanService
    {
        Task<IEnumerable<Plan>> GetPlans();
        Task<Plan> GetPlan(int Id);
        Task<Plan> UpdatePlan(int Id, Plan plan);
        Task<Plan> DeletePlan(int Id);
        Task<Plan> CreatePlan(Plan plan);
    }
}
