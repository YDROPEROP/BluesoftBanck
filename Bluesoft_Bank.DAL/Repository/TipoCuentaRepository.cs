using Bluesoft_Bank.DAL.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.DAL.Repository
{
    public class TipoCuentaRepository : IGenericRepository<TipoCuenta>
    {
        public Task<bool> Actualizar(TipoCuenta usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TipoCuenta> Insertar(TipoCuenta usuario)
        {
            throw new NotImplementedException();
        }

        public Task<TipoCuenta> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TipoCuenta>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
