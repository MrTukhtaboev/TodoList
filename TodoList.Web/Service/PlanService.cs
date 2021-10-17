using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TodoList.Web.Models;

namespace TodoList.Web.Service
{
    public class PlanService : IPlanService
    {
        private readonly HttpClient _httpClient;
        public PlanService(HttpClient httpClient)
        {
            _httpClient = httpClient; 
        }

        public Task<Plan> CreatePlan(Plan plan)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Plan> DeletePlan(int Id)
        {
            var response = await _httpClient.DeleteAsync($"api/TodoList/DeletePlan/{Id}");
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Plan>(content);
        }

        public Task<Plan> GetPlan(int Id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Plan>> GetPlans()
        { 
            return await _httpClient.GetFromJsonAsync<Plan[]>("api/TodoList/GetPlans");
        }

        public Task<Plan> UpdatePlan(int Id, Plan plan)
        {
            throw new System.NotImplementedException();
        }
    }
}
