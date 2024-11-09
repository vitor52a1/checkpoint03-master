using CP3.MVC.Domain.Interfaces;
using CP3.MVC.Infrastructure.Data.AppData;

namespace CP3.MVC.Infrastructure.Data.Repositories
{
    public class BarcoRepository : IBarcoRepository
    {
        private readonly ApplicationContext _context;

        public BarcoRepository(ApplicationContext context)
        {
            _context = context;
        }

       
    }
}
