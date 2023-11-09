using Bluesoft_Bank.DAL.DataContext;
using Bluesoft_Bank.MODELS.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.BLL.Servicios
{
    public interface IEmpresaService
    {        
        Task<EmpresaDTO> Insertar(EmpresaDTO usuario);
        Task<bool> Actualizar(Empresa usuario);
        Task<bool> Eliminar(int id);
        Task<Empresa> Obtener(int id);
        Task<List<Empresa>> ObtenerTodos();
    }
}
