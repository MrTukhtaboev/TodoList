using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using TodoList.Web.Service;

namespace TodoList.Web.Pages
{
    public class PlanBase : ComponentBase
    {
        [Inject]
        public IPlanService PlanService { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public string Title { get; set; }
        
        [Parameter]
        public DateTime DateTime { get; set; }

        [Parameter]
        public string Description {  get; set; }    

        protected async void DeletePlan_OnClick()
        {
            var result = await PlanService.DeletePlan(Id);
        }
    
    }
}
