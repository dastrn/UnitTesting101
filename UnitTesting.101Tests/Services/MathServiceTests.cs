using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting._101Tests.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using UnitTesting._101.Calculators;

namespace UnitTesting._101Tests.Services.Tests
{
    [TestClass()]
    public class MathServiceTests
    {
        private MathService service;

        [TestInitialize()]
        public void Initialize()
        {
            //Arrange
            var doublerMock = new Mock<IComputer>();

            doublerMock.Setup(obj => obj.DoMathIfLarge(It.IsAny<int>())).Returns(1000);
            doublerMock.Setup(obj => obj.DoMathIfSmall(It.IsAny<int>())).Returns(2);

            service = new MathService(doublerMock.Object);
        }


        [TestMethod()]
        public void DoMathTest()
        {
            //Action
            var result = service.DoMath(5, true);

            //Assert
            Assert.AreEqual(1000, result);
        }

        [TestMethod()]
        public void DoMathTest2()
        {
            //Action
            var result = service.DoMath(5, false);

            //Assert
            Assert.AreEqual(2, result);
        }
    }
}