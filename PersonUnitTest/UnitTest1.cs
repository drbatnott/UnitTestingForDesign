using NUnit.Framework;
using System.Collections;
using System;
namespace PersonUnitTest
{
    public class Tests
    {
        Person p;
        String s;
        [SetUp]
        public void Setup()
        {
            //From our project description a person will have a first name and last name
            p = new Person("Fred", "Bloggs");
        }

        [Test]
        public void Test1()
        {
            
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}