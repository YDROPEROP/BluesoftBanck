using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.MODELS.DTOs
{
    public class PersonaNaturalDTO
    {
        public string Nombre { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public string Contraseña { get; set; } = null!;

        public int TipoCuentaId { get; set; }
    }
}
