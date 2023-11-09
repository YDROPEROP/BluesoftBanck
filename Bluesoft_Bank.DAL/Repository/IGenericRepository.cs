using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.DAL.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Insertar(T usuario);
        Task<bool> Actualizar(T usuario);
        Task<bool> Eliminar(int id);
        Task<T> Obtener(int id);
        Task<List<T>> ObtenerTodos();
    }
}
