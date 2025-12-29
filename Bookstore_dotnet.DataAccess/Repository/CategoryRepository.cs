using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_dotnet.DataAccess.Repository
{
    public class CategoryRepository : IRepository.ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Upddate(Category category)
        {
            _db.Categories.Update(category);
        }

        public void save()
        {
            _db.SaveChanges();
        }
    }
}