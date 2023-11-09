using Bluesoft_Bank.DAL.DataContext;
using Bluesoft_Bank.MODELS.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.DAL.Repository
{
    public class PersonaNaturalRepository : IGenericRepository<PersonaNaturalDTO>
    {
        private readonly BluesoftBankContext _dbContext;

        public PersonaNaturalRepository(BluesoftBankContext bluesoftBankContext)
        {
            this._dbContext = bluesoftBankContext;
        }
        public Task<bool> Actualizar(PersonaNaturalDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PersonaNaturalDTO> Insertar(PersonaNaturalDTO usuario)
        {
            var persona = new PersonaNatural()
            {
                Nombre = usuario.Nombre,
                Correo = usuario.Correo,
                Contraseña = usuario.Contraseña,
                TipoCuentaId = usuario.TipoCuentaId
            };

            await this._dbContext.PersonaNaturals.AddAsync(persona);
            this._dbContext.SaveChanges();  
            return usuario;
        }

        public Task<PersonaNaturalDTO> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonaNaturalDTO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
