using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace NoNeedForFoodVisitor.Tests {
    [TestClass]
    public class FoodTests {
        private double Percentage { get; set; } = 1.0;

        private IFood GetFoodMock() {
            var mock = new Mock<IFood>();
            mock.SetupProperty(f => f.Salt);
            return mock.Object;
        }

        [TestMethod]
        public void AlterSaltAmount_ValidAmount_SaltAmountAltered() {
            // Arrange
            Percentage = 1.5;
            var food = GetFoodMock();
            var expectedSalt = food.Salt * Percentage;
            // Act
            food.AlterSalt(Percentage);
            // Assert
            Assert.AreEqual(expectedSalt, food.Salt);
        }

        [TestMethod]
        public void AlterSaltAmount_InvalidAmount_Exception() {
            // Arrange
            var food = GetFoodMock();
            // Act && Assert
            Assert.ThrowsException<Exception>(() => food.AlterSalt(-Percentage));
        }

        [TestMethod]
        public void AlterPepperAmount_ValidAmount_PepperAmountAltered() {
            // Arrange
            Percentage = 1.5;
            var food = GetFoodMock();
            var expectedPepper = food.Pepper * Percentage;
            // Act
            food.AlterPepper(Percentage);
            // Assert
            Assert.AreEqual(expectedPepper, food.Pepper);
        }

        [TestMethod]
        public void AlterPepperAmount_InvalidAmount_Exception() {
            // Arrange
            var food = GetFoodMock();
            // Act && Assert
            Assert.ThrowsException<Exception>(() => food.AlterPepper(-Percentage));
        }
    }
}