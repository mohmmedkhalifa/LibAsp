using Library.Database;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class LanguageRepository
    {
        private readonly BookStoreContext _bookStoreContext = null;


        public LanguageRepository(BookStoreContext context)
        {
            _bookStoreContext = context;
        }


        public async Task<List<LanguageModel>> GetAllLanguage()
        {
            return await _bookStoreContext.Languages.Select(x => new LanguageModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,

            }).ToListAsync();

        }
    }
}
