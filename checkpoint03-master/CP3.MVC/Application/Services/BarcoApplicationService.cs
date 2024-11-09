using CP3.MVC.Application.Dtos;
using CP3.MVC.Application.Interfaces;
using CP3.MVC.Domain.Entities;
using CP3.MVC.Domain.Interfaces;

namespace CP3.MVC.Application.Services
{
    public class BarcoApplicationService : IBarcoApplicationService
    {
        private readonly IBarcoRepository _barcoRepository;

        public BarcoApplicationService(IBarcoRepository barcoRepository)
        {
            _barcoRepository = barcoRepository;
        }
    }
}
