using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting._101.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting._101.Calculators.Tests
{
    [TestClass()]
    public class ConditionalTriplerTests
    {
        private ConditionalTripler service;

        [TestInitialize()]
        public void Initialize()
        {
            //Arrange
            service = new ConditionalTripler();
        }


        [TestMethod()]
        public void TripleIfSmall_WillTripleParameter_WhenParamIsUnder10()
        {
            //Action
            var result = service.DoMathIfSmall(8);

            //Assert
            Assert.AreEqual(24, result);
        }

        [TestMethod()]
        public void TripleIfSmall_WillTripleParam_WhenParamIs10Exactly()
        {
            //Action
            var result = service.DoMathIfSmall(10);

            //Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod()]
        public void TripleIfSmall_WillReturnParameter_WhenParamIsGT10()
        {
            //Action
            var result = service.DoMathIfSmall(11);

            //Assert
            Assert.AreEqual(11, result);
        }
    }
}