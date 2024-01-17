using WebApplication1.Core;
using WebApplication1.Data;

using WebApplication1.Core.Models;
namespace WebApplication1.Repositories
{
    public class FeedbackRepository : CoreRepository<feedback, ApplicationDbcontext>
    {

        public FeedbackRepository(ApplicationDbcontext context) : base(context)
        {
                
        }
    }
}
