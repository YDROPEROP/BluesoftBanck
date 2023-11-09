using Bluesoft_Bank.DAL.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.DAL.Repository
{
    public class TipoTransaccionRepository : IGenericRepository<TipoTransaccion>
    {
        public Task<bool> Actualizar(TipoTransaccion usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TipoTransaccion> Insertar(TipoTransaccion usuario)
        {
            throw new NotImplementedException();
        }

        public Task<TipoTransaccion> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TipoTransaccion>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
