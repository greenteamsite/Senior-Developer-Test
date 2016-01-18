using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using SDeveloper.Data.Interfaces;

namespace SDeveloper.Data
{
    /// <summary>
    /// Additional data layer for implementing less related code
    /// </summary>
    /// <seealso cref="SDeveloper.Data.Interfaces.IEntityContext" />
    public class EntityContext : IEntityContext
    {
        private readonly EfContext _efContext;

        public EntityContext(EfContext efContext)
        {
            _efContext = efContext;
        }

        /// <summary>
        /// Gets entities by type by Stored Procedure.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>List of entity</returns>
        public List<Entity> GetEntitiesByType(string type)
        {
            if (string.IsNullOrEmpty(type))
            {
                return null;
            }

            var entities = _efContext.Entities.SqlQuery("[dbo].[GetEntitiesByType] @Type",
                new SqlParameter
                {
                    ParameterName = "Type",
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input,
                    Value = type,
                });

            return entities.ToList();
        }
    }
}
