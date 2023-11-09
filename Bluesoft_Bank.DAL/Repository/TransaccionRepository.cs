using Bluesoft_Bank.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluesoft_Bank.DAL.Repository
{
    public class TransaccionRepository : IGenericRepository<Transaccion>
    {
        private readonly BluesoftBankContext _dbContext;

        public TransaccionRepository(BluesoftBankContext bluesoftBankContext)
        {
            this._dbContext = bluesoftBankContext;
        }
        public Task<bool> Actualizar(Transaccion usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Transaccion> Insertar(Transaccion giro)
        {
            var transaccion = new Transaccion()
            {
                Valor = giro.Valor,
                TipoTransaccionId = giro.TipoTransaccionId,
                TipoCuentaId = giro.TipoCuentaId,
                PersonaNaturalId = giro.PersonaNaturalId,
                EmpresaId = giro.EmpresaId,
            };

            await this._dbContext.Transaccions.AddAsync(transaccion);
            this._dbContext.SaveChanges();
            return transaccion;
        }

        public Task<Transaccion> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Transaccion>> ObtenerTodos()
        {

            //var transacciones = await this._dbContext.Transaccions.ToListAsync();
            /*join p in this._dbContext.PersonaNaturals on v.PersonaNaturalId equals p.Id
                                join tc in this._dbContext.TipoCuenta on v.TipoCuentaId equals tc.Id
                                join tt in this._dbContext.TipoTransaccions on v.TipoTransaccionId equals tt.Id
                                    Valor = v.Valor,
                                   TipoTransaccion = tt,
                                   TipoCuenta = tc,
                                   Empresa = e,
                                   PersonaNatural = p,
                */
            var transacciones = await (from v in this._dbContext.Transaccions
                                join e in this._dbContext.Empresas on v.EmpresaId equals e.Id
                                select new Transaccion
                                {
                                    Valor = v.Valor,
                                    Empresa = e,
                                }).ToListAsync();
            /*var transacciones = await (from v in this._dbContext.Transaccions
                                        join e in this._dbContext.Empresas on v.EmpresaId equals e.Id into empresaGroup
                                        from empresa in empresaGroup.DefaultIfEmpty()
                                        join p in this._dbContext.PersonaNaturals on v.PersonaNaturalId equals p.Id into personaGroup
                                        from persona in personaGroup.DefaultIfEmpty()
                                        join tc in this._dbContext.TipoCuenta on v.TipoCuentaId equals tc.Id into tipoCuentaGroup
                                        from tipoCuenta in tipoCuentaGroup.DefaultIfEmpty()
                                        join tt in this._dbContext.TipoTransaccions on v.TipoTransaccionId equals tt.Id into tipoTransaccionGroup
                                        from tipoTransaccion in tipoTransaccionGroup.DefaultIfEmpty()
                                        select new Transaccion
                                        {
                                            Valor = v.Valor,
                                            Empresa = empresa,
                                            TipoTransaccion = tipoTransaccion,
                                            TipoCuenta = tipoCuenta,
                                            PersonaNatural = persona
                                        }).ToListAsync();*/

            return transacciones;
        }
    }
}
