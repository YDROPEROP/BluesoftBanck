using Bluesoft_Bank.DAL.DataContext;
using Bluesoft_Bank.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.BLL.Servicios
{
    public class TransaccionService : ITransaccionService
    {
        private readonly IGenericRepository<Transaccion> _transaccionRepository;

        public TransaccionService(IGenericRepository<Transaccion> genericRepository)
        {
            this._transaccionRepository = genericRepository;
        }
        public Task<bool> Actualizar(Transaccion usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Transaccion> Insertar(Transaccion usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Transaccion> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Transaccion>> ObtenerTodos()
        {
            return await this._transaccionRepository.ObtenerTodos();
        }
    }
}
