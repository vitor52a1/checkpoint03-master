using CP3.MVC.Application.Dtos;

namespace CP3.MVC.Application.Interfaces
{
    public interface IBarcoApplicationService
    {
        IEnumerable<BarcoDto> ObterTodosBarcos();
        BarcoDto? ObterBarcoPorId(int id);
        void AdicionarBarco(BarcoDto barco);
        void EditarBarco(int id, BarcoDto barco);
        void RemoverBarco(int id);
    }
}
