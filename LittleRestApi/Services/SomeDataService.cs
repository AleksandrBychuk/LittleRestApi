using LittleRestApi.Data;
using LittleRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LittleRestApi.Services
{
    public interface ISomeDataService
    {
        Task<List<SomeData>> GetSomeDatasRange(int from = 0, int to = 0);
    }

    public class SomeDataService : ISomeDataService
    {
        private readonly AppDbContext _appDbContext;
        public SomeDataService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<SomeData>> GetSomeDatasRange(int from = 0, int to = 0)
        {
            var result = await _appDbContext.SomeDatas.Skip(from).Take(to).ToListAsync();
            return result;
        }
    }
}
