using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Api.Data;
using TodoList.Api.Models;

namespace TodoList.Api.Service
{
    public class TodoListService : ITodoListService
    {
        private readonly AppDbContext _appDbContext;
        public TodoListService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Plan> CreatePlan(Plan plan)
        {
            var entry = await _appDbContext.Plans.AddAsync(plan);
            await _appDbContext.SaveChangesAsync();
            return entry.Entity;
        }

        public async Task<Plan> DeletePlan(int Id)
        {
            var entity = _appDbContext.Plans.FirstOrDefault(p => p.Id == Id);
            _appDbContext.Plans.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;

        }

        public async Task<Plan> GetPlan(int Id)
        {
            var entity = await _appDbContext.Plans.FirstOrDefaultAsync(p => p.Id == Id);
            return entity;
        }

        public async Task<IEnumerable<Plan>> GetPlans()
        {
            var entities = await _appDbContext.Plans.ToListAsync();
            return entities;
        }

        public async Task<Plan> UpdatePlan(int Id, Plan plan)
        {
            var entity = await _appDbContext.Plans.FirstOrDefaultAsync(p => p.Id == Id);
            entity.DateTime = plan.DateTime;
            entity.Description = plan.Description;
            entity.Title = plan.Title;
            await _appDbContext.SaveChangesAsync();
            
            return entity;
        }
    }
}
