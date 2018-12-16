﻿using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using CSharpTutorial.Library;

namespace CSharpTutorial.Test
{
    /// <summary>
    /// Summary description for DelegatesSampleTest
    /// </summary>
    [TestFixture]
    public class DelegatesSampleTest
    {
        public DelegatesSampleTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [Test]
        [TestCase(10)]
        public void TestDelegatesSample(int number)
        {
            DelegatesSample DelegatesSample = new DelegatesSample(number);
            var results = DelegatesSample.run();
        }
    }
}
