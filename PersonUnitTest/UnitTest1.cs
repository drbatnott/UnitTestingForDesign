using NUnit.Framework;
using System.Collections.Generic;
using System;
namespace PersonUnitTest
{
    public class Tests
    {
        Person p;
        List<Person> people;
        [SetUp]
        public void Setup()
        {
            //From our project description a person will have a first name and last name
            p = new Person("Fred", "Bloggs");
            people = new List<Person>();
        }

        [Test]
        public void Test1()
        {
            
            Assert.AreEqual("Fred",p.FirstName);
        }
        [Test]
        public void Test2()
        {

            Assert.AreEqual("Bloggs", p.LastName);
        }
        //The following is a bad test
        [Test]
        public void Test3()
        {
            people.Add(p);
            Assert.AreNotEqual(people[0].FirstName, "Fred");
            Assert.AreEqual(people[0], p);
        }
        //In tear down we ought to make sure that everything is closed 
        [TearDown]
        public void TearDown()
        {
            people.Clear();
        }
    }
}