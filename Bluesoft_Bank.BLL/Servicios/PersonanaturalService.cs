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
    public class PersonanaturalService : IPersonaNaturalService
    {
        private readonly IGenericRepository<PersonaNaturalDTO> _personaNaturalRepository;

        public PersonanaturalService(IGenericRepository<PersonaNaturalDTO> genericRepository)
        {
            this._personaNaturalRepository = genericRepository;
        }
        public Task<bool> Actualizar(PersonaNatural usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PersonaNaturalDTO> Insertar(PersonaNaturalDTO usuario)
        {
            return await this._personaNaturalRepository.Insertar(usuario);
        }

        public Task<PersonaNatural> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonaNatural>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
