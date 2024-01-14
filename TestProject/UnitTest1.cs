using System.Security.Cryptography;
using NUnit.Framework;
using System.Collections.Generic;
using Курсач; // Замените на актуальное пространство имен вашего проекта

namespace TestProject
{
    public class AtkTests
    {
        Atk atk;

        [SetUp]
        public void Setup()
        {
            atk  = new Atk();
        }

        [Test]
        public void FindPrimes_Limit10_ReturnsExpectedResult()
        {
            // Arrange
            Atk atk = new Atk();
            string expected = "2, 3, 5, 7";

            // Act
            string result = atk.FindPrimes("10");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FindPrimes_Limit20_ReturnsExpectedResult()
        {
            // Arrange
            Atk atk = new Atk();

            // Act
            string result = atk.FindPrimes("20");

            // Assert
            Assert.AreEqual("2, 3, 5, 7, 11, 13, 17, 19", result);

        }

        [Test]
        public void FindPrimes_InvalidInput_ReturnsEmptyString()
        {
            // Arrange
            Atk atk = new Atk();
            string expected = "";

            // Act
            string result = atk.FindPrimes("invalid");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void FindPrimes_NullInput_ReturnsEmptyString()
        {
            // Arrange
            Atk atk = new Atk();
            string expected = "";

            // Act
            string result = atk.FindPrimes("");

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
