using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        Person person1;

        [SetUp]
        public void Setup()
        {
            person1 = new Person("Gonzalo", "4.877.368-7");
        }

        [Test]
        public void NameCorrectlyAssigned()
        {
            string expected = "Gonzalo";
            string actual = person1.Name;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void IDCorrectlyAssigned ()
        {
            string expected = "4.877.368-7";
            string actual = person1.ID;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void ValidNameAssigned()
        {
            person1.Name = "Guzman";
            Assert.AreEqual("Guzman",person1.Name);
        }

        [Test]
        public void NameNotValid()
        {
            person1.Name = "";
            Assert.AreEqual("Gonzalo",person1.Name);
        }

        [Test]
        public void validIDAssigned()
        {
            person1.ID = "4.579.395-3";
            Assert.AreEqual("4.579.395-3",person1.ID);
        }
        
        [Test]
        public void IDNotValid()
        {
            person1.ID = "4.877.368-1";
            Assert.AreEqual("4.877.368-7",person1.ID);
        }
    }
}