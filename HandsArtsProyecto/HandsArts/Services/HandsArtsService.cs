using HandsArts.Data;
using HandsArts.Models;

namespace HandsArts.Services
{
    public class HandsArtsService : IHandsArtsService
    {
        private readonly ApplicationDbContext _context;

        public HandsArtsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddCategoryAsync(string categoryName)
        {
            var category = new Category { Name = categoryName };
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }
    }
}