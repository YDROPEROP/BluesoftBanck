using Bluesoft_Bank.DAL.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.BLL.Servicios
{
    public interface ITransaccionService
    {
        Task<Transaccion> Insertar(Transaccion usuario);
        Task<bool> Actualizar(Transaccion usuario);
        Task<bool> Eliminar(int id);
        Task<Transaccion> Obtener(int id);
        Task<List<Transaccion>> ObtenerTodos();
    }
}

