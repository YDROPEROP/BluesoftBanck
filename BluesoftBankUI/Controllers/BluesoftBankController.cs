using Bluesoft_Bank.BLL.Servicios;
using Bluesoft_Bank.DAL.DataContext;
using Bluesoft_Bank.MODELS.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BluesoftBankUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BluesoftBankController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;
        private readonly IPersonaNaturalService _personaNaturalService;
        private readonly ITransaccionService _transaccionService;

        public BluesoftBankController(
            IEmpresaService empresaService,
            IPersonaNaturalService personaNaturalService,
            ITransaccionService transaccionService
            )
        {
            this._empresaService = empresaService;
            this._personaNaturalService = personaNaturalService;
            this._transaccionService = transaccionService;
        }


        [HttpPost("RegistrarEmpresa")]
        public async Task<EmpresaDTO> InsertarEmpres(EmpresaDTO empresa)
        {
           var datos = await this._empresaService.Insertar(empresa);
            return datos;
        }
        [HttpPost("RegistrarPersona")]
        public async Task<PersonaNaturalDTO> InsertarPersona(PersonaNaturalDTO personaNatural)
        {
            var datos = await this._personaNaturalService.Insertar(personaNatural);

            return datos;
        }


        [HttpGet("ObtenerTransacciones")]
        public async Task<List<Transaccion>> Obtener()
        {

            return await this._transaccionService.ObtenerTodos();
        }
    }
}
