using System;
using System.IO;
using Newtonsoft.Json.Linq;
using SDeveloper.Data.Interfaces;

namespace SDeveloper.Data
{
    /// <summary>
    /// Implementation IConfigReader by JSON file
    /// </summary>
    /// <seealso cref="SDeveloper.Data.Interfaces.IConfigReader" />
    public class JsonConfigReader : IConfigReader
    {
        /// <summary>
        /// The configurations settings
        /// </summary>
        private readonly JObject _configurations;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonConfigReader"/> class.
        /// </summary>
        public JsonConfigReader()
        {
            _configurations = LoadJson();
        }

        /// <summary>
        /// Gets the connection string from settings.
        /// </summary>
        /// <returns>
        /// The connection string
        /// </returns>
        public string GetConnectionString()
        {
            return (string) _configurations["connectionString"];
        }

        /// <summary>
        /// Loads settings from configuration.json file.
        /// </summary>
        /// <returns>
        /// Configuration settings
        /// </returns>
        private JObject LoadJson()
        {
            string filePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, "configuration.json");

            // The main reasons for using Newtonsoft.Json are simple and high-performance 
            return JObject.Parse(File.ReadAllText(filePath));
        }
    }
}
