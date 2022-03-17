﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class MyStackTests
    {
        //[TestMethod()]
        //public void MyStackTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void PushTest()
        {
            //Arange
            MyStack stack = new MyStack();

            //Act
            stack.Push(1);
            stack.Push(2);

            //Assert
            int expected = 2;
            Assert.AreEqual(expected, stack.Count);
        }

        [TestMethod()]
        public void PopTest()
        {
            //Arange
            MyStack stack = new MyStack();

            //Act
            stack.Push(1);
            stack.Push(2);

            stack.Pop();
            stack.Pop();

            //Asert
            int expected = 0;
            Assert.AreEqual(expected, stack.Count);

        }

        [TestMethod()]
        public void PeekTest()
        {
            //Arange
            MyStack stack = new MyStack();

            //Act
            stack.Push(1);
            stack.Push(2);

            //Asert
            int expected = 2;
            Assert.AreEqual(expected, stack.Peek());

        }
    }
}