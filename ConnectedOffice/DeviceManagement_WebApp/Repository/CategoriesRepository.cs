using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Task FindAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public object FirstOrDefaultAsync(Func<object, bool> value)
        {
            return _context.Category.FirstOrDefault();
        }

        public Category GetMostRecentCategory()
        {
            return _context.Category.OrderByDescending(category => category.DateCreated).FirstOrDefault();
        }

        //public Task SaveChangesAsync()
        //{
        //    return _context.SaveChanges();
        //}
    }
}
