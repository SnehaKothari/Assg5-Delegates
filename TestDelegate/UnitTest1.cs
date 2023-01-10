using Xunit;
using System;
using System.Text.Json;
using Delegatess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection.Metadata;
using DelegateFun;
using Delegatess;
using Moq;
using Autofac.Extras.Moq;
using Assert=Xunit.Assert;

namespace TestDelegate
{
    public class UnitTest1
    {
        [Fact]
        public void WordTest()
        {
            string result = "String contains words";
            //Arrange
            var mock=new Mock<InputParserDel>();
            //Act
            mock.Setup(p => p(It.IsAny<string>())).Returns(ConsoleParser.Word);
            var actual = ConsoleParser.Word("Abc");
            //Assert
            Assert.Equal(result, actual);
        }
        [Fact]
        public void NumberTest()
        {
            string result = "String contains numbers";
            //Arrange
            var mock = new Mock<InputParserDel>();
            //Act
            mock.Setup(p => p(It.IsAny<string>())).Returns(ConsoleParser.Number);
            var actual = ConsoleParser.Number("123");
            //Assert
            Assert.Equal(result, actual);
        }
        [Fact]
        public void JunkTest()
        {
            string result = "String contains special characters";
            //Arrange
            var mock = new Mock<InputParserDel>();
            //Act
            mock.Setup(p => p(It.IsAny<string>())).Returns(ConsoleParser.Junk);
            var actual = ConsoleParser.Junk("$*%");
            //Assert
            Assert.Equal(result, actual);
        }
    }
}