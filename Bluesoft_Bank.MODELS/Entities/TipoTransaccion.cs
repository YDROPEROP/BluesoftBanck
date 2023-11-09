using System;
using System.Collections.Generic;

namespace Bluesoft_Bank.DAL.DataContext;

public partial class TipoTransaccion
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();
}
