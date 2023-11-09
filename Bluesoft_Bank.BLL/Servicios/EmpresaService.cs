using Bluesoft_Bank.DAL.DataContext;
using Bluesoft_Bank.DAL.Repository;
using Bluesoft_Bank.MODELS.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.BLL.Servicios
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IGenericRepository<EmpresaDTO> _empresaRepository;

        public EmpresaService(IGenericRepository<EmpresaDTO> genericRepository)
        {
            this._empresaRepository = genericRepository;
        }
        public Task<bool> Actualizar(Empresa usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<EmpresaDTO> Insertar(EmpresaDTO usuario)
        {
            await this._empresaRepository.Insertar(usuario);

            return usuario;
        }

        public Task<Empresa> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Empresa>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
