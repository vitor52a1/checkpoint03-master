using CP3.MVC.Domain.Entities;
using CP3.MVC.Domain.Interfaces;
using CP3.MVC.Infrastructure.Data.AppData;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CP3.MVC.Infrastructure.Data.Repositories
{
    public class BarcoRepository : IBarcoRepository
    {
        private readonly ApplicationContext _context;

        public BarcoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public BarcoEntity? ObterPorId(int id)
        {
            return _context.Barcos.Find(id);
        }

        public IEnumerable<BarcoEntity>? ObterTodos()
        {
            return _context.Barcos.ToList();
        }

        public BarcoEntity? Adicionar(BarcoEntity barco)
        {
            _context.Barcos.Add(barco);
            _context.SaveChanges();
            return barco;
        }

        public BarcoEntity? Editar(BarcoEntity barco)
        {
            var barcoExistente = _context.Barcos.Find(barco.Id);
            if (barcoExistente == null) return null;

            _context.Entry(barcoExistente).CurrentValues.SetValues(barco);
            _context.SaveChanges();
            return barcoExistente;
        }

        public BarcoEntity? Remover(int id)
        {
            var barco = _context.Barcos.Find(id);
            if (barco == null) return null;

            _context.Barcos.Remove(barco);
            _context.SaveChanges();
            return barco;
        }
    }
}
