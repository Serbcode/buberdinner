using BuberDinner.Domain.Entities;

namespace BuberDinner.Api.Controllers
{
    public interface ITodoService
    {
        Task<IEnumerable<Todo>> GetAll();
        Task<Todo?> GetOne(int id);
        Task<int> Create(Todo todo);
        Task Update(Todo todo);
        Task Delete(int id);
    }
}