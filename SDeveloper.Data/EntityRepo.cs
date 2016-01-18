using System.Collections.Generic;
using SDeveloper.Data.Interfaces;

namespace SDeveloper.Data
{
    /// <summary>
    /// Data Repository
    /// </summary>
    public class EntityRepo
    {
        private readonly IEntityContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRepo"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public EntityRepo(IEntityContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the entities by type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The entities</returns>
        public List<Entity> GetEntitiesByType(string type)
        {
            return _context.GetEntitiesByType(type);
        }
    }
}
