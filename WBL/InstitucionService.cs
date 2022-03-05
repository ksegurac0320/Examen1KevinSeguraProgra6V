using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IInstitucionService
    {
        Task<DBEntity> CREATE(InstitucionEntity entity);
        Task<DBEntity> DELETE(InstitucionEntity entity);
        Task<IEnumerable<InstitucionEntity>> GET();
        Task<InstitucionEntity> GETBYID(InstitucionEntity entity);
        Task<DBEntity> UPDATE(InstitucionEntity entity);
    }

    public class InstitucionService : IInstitucionService
    {
        private readonly IDataAccess sql;

        public InstitucionService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud
        //Metodo GET
        public async Task<IEnumerable<InstitucionEntity>> GET()
        {
            try
            {
                var result = sql.QueryAsync<InstitucionEntity>("dbo.InstitucionObtener");
                return await result;
            }
            catch (Exception)
            {
                throw;
            }

        }

        //Metodo GETBYID
        public async Task<InstitucionEntity> GETBYID(InstitucionEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<InstitucionEntity>("dbo.InstitucionObtener", new { entity.Id_Institucion });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //METODO CREATE
        public async Task<DBEntity> CREATE(InstitucionEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.InstitucionInsertar", new
                {
                    entity.Codigo,
                    entity.Nombre,
                    entity.Telefono,
                    entity.Estado
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }

        }

        //METODO UPDATE
        public async Task<DBEntity> UPDATE(InstitucionEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.InstitucionActualizar", new
                {
                    entity.Id_Institucion,
                    entity.Codigo,
                    entity.Nombre,
                    entity.Telefono,
                    entity.Estado
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }

        }

        //METODO DELETE
        public async Task<DBEntity> DELETE(InstitucionEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("dbo.InstitucionEliminar", new
                {
                    entity.Id_Institucion
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }

        }

        #endregion

    }

    //****
}
