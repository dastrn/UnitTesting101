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
    public class ConditionalDoublerTests
    {
        private ConditionalDoubler doubler;

        [TestInitialize()]
        public void Initialize()
        {
            //Arrange
            doubler = new ConditionalDoubler();
        }

        #region DoubleIfSmall Tests
        [TestMethod()]
        public void DoubleIfSmall_Doubles_IfParameterIsLessThan100()
        {
            //Action
            var result = doubler.DoMathIfSmall(99);

            //Assert
            Assert.AreEqual(198, result);
        }

        [TestMethod()]
        public void DoubleIfSmall_Doubles_IfParameterIs100()
        {
            //Action
            var result = doubler.DoMathIfSmall(100);

            //Assert
            Assert.AreEqual(200, result);
        }

        [TestMethod()]
        public void DoubleIfSmall_ReturnsParameter_IfParameterIsGreaterThan100()
        {
            //Action
            var result = doubler.DoMathIfSmall(101);

            //Assert
            Assert.AreEqual(101, result);
        }
        #endregion


        #region DoubleIfLarge Tests
        [TestMethod()]
        public void DoubleIfLarge_Doubles_IfParameterIsLessThan100()
        {
            //Action
            var result = doubler.DoMathIfLarge(99);

            //Assert
            Assert.AreEqual(99, result);
        }

        [TestMethod()]
        public void DoubleIfLarge_ReturnsParameter_IfParameterIs100()
        {
            //Action
            var result = doubler.DoMathIfLarge(100);

            //Assert
            Assert.AreEqual(200, result);
        }

        [TestMethod()]
        public void DoubleIfLarge_ReturnsParameter_IfParameterIsGreaterThan100()
        {
            //Action
            var result = doubler.DoMathIfLarge(101);

            //Assert
            Assert.AreEqual(202, result);
        }
        #endregion
    }
}