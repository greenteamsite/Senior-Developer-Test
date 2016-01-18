using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDeveloper.Data;
using SDeveloper.Data.Interfaces;

namespace SDeveloper.Test
{
    [TestClass]
    public class EntityContextTest
    {
        private readonly IEntityContext _context;
        public EntityContextTest()
        {
            _context = new EntityContext(new EfContext("Data Source=.;Initial Catalog=sdeveloper;Integrated Security=true;MultipleActiveResultSets=true;"));
        }

        [TestMethod]
        public void GetEntitiesByTypePassNullNoExceptionIsThrown()
        {
            try
            {
                _context.GetEntitiesByType(null);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        public void GetEntitiesByTypePassNullIsNull()
        {
            Assert.IsNull(_context.GetEntitiesByType(null));
        }
        
        [TestMethod]
        public void GetEntitiesByTypePassTypeIsNotNull()
        {
            Assert.IsNotNull(_context.GetEntitiesByType("11111"));
        }

        [TestMethod]
        public void GetEntitiesByTypePassTypeAreEqual()
        {
            string realTypeFromDb = "type1";
            string procedureResult = _context.GetEntitiesByType(realTypeFromDb).Select(s => s.Type).FirstOrDefault();
            Assert.AreEqual(realTypeFromDb, procedureResult);
        }
    }
}
