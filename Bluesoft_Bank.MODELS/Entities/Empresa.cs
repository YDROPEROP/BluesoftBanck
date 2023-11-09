using System;
using System.Collections.Generic;

namespace Bluesoft_Bank.DAL.DataContext;

public partial class Empresa
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int TipoCuentaId { get; set; }

    public virtual TipoCuenta TipoCuenta { get; set; } = null!;

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();
}
