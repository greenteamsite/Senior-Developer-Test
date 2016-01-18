using System.Collections.Generic;

namespace SDeveloper.Data.Interfaces
{
    public interface IEntityContext
    {
        List<Entity> GetEntitiesByType(string type);
    }
}
