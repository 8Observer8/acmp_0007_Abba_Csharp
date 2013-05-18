using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using acmp_0007_Abba_Csharp;

namespace UnitTestAbba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAbba_firstHeapIsTheLargest()
        {
            string firstHeap = "4958439238923098349024";
            string secondHeap = "189285";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_secondHeapIsTheLargest()
        {
            string firstHeap = "189285";
            string secondHeap = "4958439238923098349024";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_thirdHeapIsTheLargest()
        {
            string firstHeap = "283";
            string secondHeap = "189285";
            string thirdHeap = "4958439238923098349024";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_firstHeapIsTheLargest_oneSpaceInTheBegin()
        {
            string firstHeap = " 4958439238923098349024";
            string secondHeap = "189285";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_secondHeapIsTheLargest_oneSpaceInTheBegin()
        {
            string firstHeap = "189285";
            string secondHeap = " 4958439238923098349024";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_thirdHeapIsTheLargest_oneSpaceInTheBegin()
        {
            string firstHeap = "283";
            string secondHeap = "189285";
            string thirdHeap = " 4958439238923098349024";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_firstHeapIsTheLargest_twoSpaceInTheBegin()
        {
            string firstHeap = "  4958439238923098349024";
            string secondHeap = "189285";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_secondHeapIsTheLargest_twoSpaceInTheBegin()
        {
            string firstHeap = "189285";
            string secondHeap = "  4958439238923098349024";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_thirdHeapIsTheLargest_twoSpaceInTheBegin()
        {
            string firstHeap = "283";
            string secondHeap = "189285";
            string thirdHeap = "  4958439238923098349024";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void TestAbba_firstHeapIsTheLargest_oneSpaceInTheMiddle()
        {
            string firstHeap = "495843923 8923098349024";
            string secondHeap = "189285";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "ERROR";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_secondHeapIsTheLargest_oneSpaceInTheMiddle()
        {
            string firstHeap = "189285";
            string secondHeap = "495843923 8923098349024";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "ERROR";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_thirdHeapIsTheLargest_oneSpaceInTheMiddle()
        {
            string firstHeap = "283";
            string secondHeap = "189285";
            string thirdHeap = "495843 9238923098349024";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "ERROR";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_firstHeapIsTheLargest_twoSpaceInTheMiddle()
        {
            string firstHeap = "495843923  8923098349024";
            string secondHeap = "189285";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "ERROR";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_secondHeapIsTheLargest_twoSpaceInTheMiddle()
        {
            string firstHeap = "189285";
            string secondHeap = "495843923  8923098349024";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "ERROR";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_thirdHeapIsTheLargest_twoSpaceInTheMiddle()
        {
            string firstHeap = "283";
            string secondHeap = "189285";
            string thirdHeap = "495843  9238923098349024";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "ERROR";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_firstHeapIsTheLargest_oneSpaceInTheEnd()
        {
            string firstHeap = "4958439238923098349024 ";
            string secondHeap = "189285";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_secondHeapIsTheLargest_oneSpaceInTheEnd()
        {
            string firstHeap = "189285";
            string secondHeap = "4958439238923098349024 ";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_thirdHeapIsTheLargest_oneSpaceInTheEnd()
        {
            string firstHeap = "283";
            string secondHeap = "189285";
            string thirdHeap = "4958439238923098349024 ";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_firstHeapIsTheLargest_twoSpaceInTheEnd()
        {
            string firstHeap = "4958439238923098349024  ";
            string secondHeap = "189285";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_secondHeapIsTheLargest_twoSpaceInTheEnd()
        {
            string firstHeap = "189285";
            string secondHeap = "4958439238923098349024  ";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_thirdHeapIsTheLargest_twoSpaceInTheEnd()
        {
            string firstHeap = "283";
            string secondHeap = "189285";
            string thirdHeap = "4958439238923098349024  ";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "4958439238923098349024";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_firstHeapIsTheLargest_illegalCharacter()
        {
            string firstHeap = "49W58439238923098349024";
            string secondHeap = "189285";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "ERROR";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_secondHeapIsTheLargest_illegalCharacter()
        {
            string firstHeap = "189285";
            string secondHeap = "49W8439238923098349024  ";
            string thirdHeap = "283";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "ERROR";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAbba_thirdHeapIsTheLargest_illegalCharacter()
        {
            string firstHeap = "283";
            string secondHeap = "189285";
            string thirdHeap = "49W8439238923098349024  ";
            Abba a = new Abba();
            string result = a.abba(firstHeap, secondHeap, thirdHeap);
            string expected = "ERROR";
            Assert.AreEqual(expected, result);
        }
    }
}
