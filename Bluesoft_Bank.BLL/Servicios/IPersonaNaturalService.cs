using Bluesoft_Bank.DAL.DataContext;
using Bluesoft_Bank.MODELS.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.BLL.Servicios
{
    public interface IPersonaNaturalService
    {
        Task<PersonaNaturalDTO> Insertar(PersonaNaturalDTO usuario);
        Task<bool> Actualizar(PersonaNatural usuario);
        Task<bool> Eliminar(int id);
        Task<PersonaNatural> Obtener(int id);
        Task<List<PersonaNatural>> ObtenerTodos();
    }
}

