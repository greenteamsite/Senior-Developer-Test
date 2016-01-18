namespace SDeveloper.Data.Interfaces
{
    /// <summary>
    /// Intrface for config readers
    /// </summary>
    public interface IConfigReader
    {
        /// <summary>
        /// Gets the connection string from settings.
        /// </summary>
        /// <returns>The connection string</returns>
        string GetConnectionString();
    }
}
