using System;
using System.Collections.Generic;
using System.Linq;
using SDeveloper.Data;
using SDeveloper.Data.Interfaces;

namespace SDeveloper.Test.Fakes
{
    /// <summary>
    /// Fake context
    /// </summary>
    /// <seealso cref="SDeveloper.Data.Interfaces.IEntityContext" />
    public class EntityContextFake : IEntityContext
    {
        private readonly List<Entity> _entities;

        public EntityContextFake()
        {
            _entities = new List<Entity>
            {
                new Entity
                {
                    Id = 1,
                    Created = DateTime.Now,
                    Type = "type1",
                    Content = "flkfpf erfgerpgj [egp [gjreg jgj  jgjepg[egk"
                },
                new Entity
                {
                    Id = 2,
                    Created = DateTime.Now,
                    Type = "type2",
                    Content = "flkfpf erfgerpgj [egp [gjreg jgj  jgjepg[egk"
                },
                new Entity
                {
                    Id = 3,
                    Created = DateTime.Now,
                    Type = "type1",
                    Content = "flkfpf erfgerpgj [egp [gjreg jgj  jgjepg[egk"
                },
                new Entity
                {
                    Id = 4,
                    Created = DateTime.Now,
                    Type = "type3",
                    Content = "flkfpf erfgerpgj [egp [gjreg jgj  jgjepg[egk"
                }
            };
        }

        /// <summary>
        /// Fake method.
        /// Gets the entities by the type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public List<Entity> GetEntitiesByType(string type)
        {
            return _entities.Where(w => w.Type == type).ToList();
        }
    }
}
