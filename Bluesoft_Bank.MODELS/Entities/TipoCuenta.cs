using System;
using System.Collections.Generic;

namespace Bluesoft_Bank.DAL.DataContext;

public partial class TipoCuenta
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual ICollection<PersonaNatural> PersonaNaturals { get; set; } = new List<PersonaNatural>();

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();
}
