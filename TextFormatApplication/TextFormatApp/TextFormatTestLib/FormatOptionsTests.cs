using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TextFormatLib;


namespace TextFormatTestLib
{
    [TestFixture]
    public class FormatOptionsTests
    {
        TextFormatOptions testOption;

        [SetUp]
        public void TestInitialize()
        {
            testOption = new TextFormatOptions();
        }

        [Test]
        public void TestInputIsString()
        {
            string input = "This is string input";
            testOption.setInput(input);
            Assert.AreSame(input.GetType(), testOption.getCurrentInput().GetType());
        }

        [Test]
        public void TestIfReturnInputWhenInputIsNull()
        {
            Assert.AreEqual("", testOption.getCurrentInput());
        }

        [Test]
        public void TestIfSetInputIsSameAsGetInput()
        {
            string inputText = "Hello";
            testOption.setInput(inputText);
            Assert.AreEqual(inputText, testOption.getCurrentInput());
        }

        [Test]
        public void TestInputIsValid()
        {
            string input = "This is Input Text";
            testOption.setInput(input);
            Assert.AreEqual(input, testOption.getCurrentInput());
        }

        [Test]
        public void TestInputObjectIsNotNull()
        {
            Assert.IsFalse(testOption.setInput(null));
        }


        [Test]
        public void TestCapitalizeInput()
        {
            string input = "inPUT";
            testOption.setInput(input);
            testOption.CapitalizeInput();
            Assert.AreEqual("INPUT", testOption.getCurrentInput());
        }

        [Test]
        public void TestIfNullInputIsCapitalized()
        {
            testOption.setInput(null);
            Assert.IsFalse(testOption.CapitalizeInput());
        }

        [Test]
        public void TestIfEmptyStringIsCapitalized()
        {
            testOption.setInput("");
            Assert.IsFalse(testOption.CapitalizeInput());
        }

        [Test]
        public void TestNumberOfLinesInInput()
        {
            string input = @"Line1
                             Line2
                             Line3";
            testOption.setInput(input);
            Assert.AreEqual(3, testOption.NumberOfLinesInInput());
        }

        [Test]
        public void TestNumberOfLinesIsZeroIfInputIsNull()
        {
            testOption.setInput(null);
            Assert.AreEqual(0, testOption.NumberOfLinesInInput());
        }


        [Test]
        public void TestEachInputLineStartsWithSpecificString()
        {
            string input = @"Line1
Line2
Line3";
            testOption.setInput(input);
            testOption.UpdateEachLineWithSpecificStartString("Text");
            string output = @"TextLine1
TextLine2
TextLine3";
            Assert.AreEqual(output, testOption.getCurrentInput());
        }

        [Test]
        public void TestEachInputLineEndsWithSpecificString()
        {
            string input = @"Line1
Line2
Line3";

            testOption.setInput(input);
            testOption.UpdateEachLineWithSpecificEndString("Text");
            string output = @"Line1Text
Line2Text
Line3Text";
            Assert.AreEqual(output, testOption.getCurrentInput());
        }
    }
}
