using Bluesoft_Bank.DAL.DataContext;
using Bluesoft_Bank.MODELS.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.DAL.Repository
{
    public class EmpresaRepository : IGenericRepository<EmpresaDTO>
    {
        private readonly BluesoftBankContext _dbContext;

        public EmpresaRepository(BluesoftBankContext bluesoftBankContext)
        {
            this._dbContext = bluesoftBankContext;
        }
        public Task<bool> Actualizar(EmpresaDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<EmpresaDTO> Insertar(EmpresaDTO usuario)
        {
            var empresa = new Empresa()
            {
                Nombre = usuario.Nombre,
                Correo = usuario.Correo,
                Contraseña = usuario.Contraseña,
                TipoCuentaId = usuario.TipoCuentaId
            };

            await this._dbContext.Empresas.AddAsync(empresa);
            this._dbContext.SaveChanges();
            return usuario;
        }

        public Task<EmpresaDTO> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmpresaDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
