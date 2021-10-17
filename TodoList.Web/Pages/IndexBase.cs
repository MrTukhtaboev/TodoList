using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Web.Service;

namespace TodoList.Web.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public IPlanService PlanService { get; set; }
        protected TodoList.Web.Models.Plan[] Plans { get; set; }
        
        protected async override Task OnInitializedAsync()
        {
            Plans = (await PlanService.GetPlans()).ToArray();    
        }
    }
}
