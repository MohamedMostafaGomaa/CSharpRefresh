﻿using NUnit.Framework;
using HackerrankAlgorithms.Logic;
using System.Collections.Generic;

namespace HackerrankAlgorithms.Test
{
    [TestFixture]
    public class StacksAndQueuesTest
    {
        [Test]
        [TestCase("{[()]}", true)]
        [TestCase("{[(])}", false)]
        [TestCase("{{[[(())]]}}", true)]
        [TestCase("}][}}(}][))]", false)]
        [TestCase("[](){()}", true)]
        [TestCase("()", true)]
        [TestCase("({}([][]))[]()", true)]
        [TestCase("{)[](}]}]}))}(())(", false)]
        [TestCase("([[)", false)]

        public void IsBalancedBracketsTest(string str, bool expected)
        {
            bool result = StacksAndQueuesSample.IsBalancedBrackets(str);
            Assert.AreEqual(result, expected);
        }


        [Test]
        [TestCase(new string[] { "A", "B", "C", "D" }, "A,B,C,D,")]
        [TestCase(new string[] { "Abdallah", "Ali", "Ziad", "Omar" }, "Abdallah,Ali,Ziad,Omar,")]
        public void QueueUsingTwoStacksTest(string[] arrInput, string expected)
        {
            string result = StacksAndQueuesSample.QueueUsingTwoStacks(arrInput);
            Assert.AreEqual(result, expected);
        }
    }
}
