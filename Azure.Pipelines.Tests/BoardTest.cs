using Azure.Pipelines.Data;
using Azure.Pipelines.Models.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Azure.Pipelines.Tests
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidPropertyException))]
        public void NameIsEmpty_ThrowException()
        {
            throw new InvalidPropertyException();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPropertyException))]
        public void LongNameforBoard_ThrowException()
        {
            throw new InvalidPropertyException();
        }
    }
}