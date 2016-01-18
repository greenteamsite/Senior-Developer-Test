using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDeveloper.Data.Interfaces;
using SDeveloper.Test.Fakes;

namespace SDeveloper.Test
{
    [TestClass]
    public class EntityRepoTest
    {
        private readonly IEntityContext _context;

        public EntityRepoTest()
        {
            _context = new EntityContextFake();
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
        public void GetEntitiesByTypePassNullEmptyResult()
        {
            Assert.IsTrue(_context.GetEntitiesByType(null).Count == 0);
        }
    }
}
