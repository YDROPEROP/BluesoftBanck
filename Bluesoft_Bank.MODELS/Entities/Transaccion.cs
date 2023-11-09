using System;
using System.Collections.Generic;

namespace Bluesoft_Bank.DAL.DataContext;

public partial class Transaccion
{
    public int Id { get; set; }

    public decimal Valor { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? TipoTransaccionId { get; set; }

    public int? TipoCuentaId { get; set; }

    public int? PersonaNaturalId { get; set; }

    public int? EmpresaId { get; set; }

    public virtual Empresa? Empresa { get; set; }

    public virtual PersonaNatural? PersonaNatural { get; set; }

    public virtual TipoCuenta? TipoCuenta { get; set; }

    public virtual TipoTransaccion? TipoTransaccion { get; set; }
}
