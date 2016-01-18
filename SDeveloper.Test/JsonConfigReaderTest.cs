using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDeveloper.Data;

namespace SDeveloper.Test
{
    [TestClass]
    public class JsonConfigReaderTest
    {
        [TestMethod]
        public void CreateInstanceNoExceptionIsThrown()
        {
            try
            {
                JsonConfigReader jsonConfigReader = new JsonConfigReader();
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void GetConnectionStringIsNotEmpty()
        {
            JsonConfigReader jsonConfigReader = new JsonConfigReader();
            Assert.IsFalse(string.IsNullOrEmpty(jsonConfigReader.GetConnectionString()));
        }

        [TestMethod] public void GetConnectionStringIsEqual()
        {
            JsonConfigReader jsonConfigReader = new JsonConfigReader();
            Assert.AreEqual("Data Source=.;Initial Catalog=sdeveloper;Integrated Security=true;MultipleActiveResultSets=true;", jsonConfigReader.GetConnectionString());
        }
    }
}
