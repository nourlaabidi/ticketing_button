using WebApplication1.Core;
using WebApplication1.Data;

using WebApplication1.Core.Models;

namespace WebApplication1.Repositories
{
    public class CategoryRepository : CoreRepository<Category, ApplicationDbcontext>
    {
        public CategoryRepository(ApplicationDbcontext context) : base(context)
            { }
    }
}
