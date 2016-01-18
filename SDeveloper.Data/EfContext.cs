using System.Data.Entity;

namespace SDeveloper.Data
{
    /// <summary>
    /// DataBase Context
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class EfContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EfContext"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public EfContext(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer(new EntityDbInitializer());
        }

        /// <summary>
        /// Gets or sets the entities.
        /// </summary>
        /// <value>
        /// The entities.
        /// </value>
        public DbSet<Entity> Entities { get; set; }
    }


}
