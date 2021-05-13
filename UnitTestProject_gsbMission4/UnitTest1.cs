using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Mission4GSB;

namespace UnitTestProject_gsbMission4
{
    [TestClass]
    public class UnitTest1
    {
        GestionDate d = new GestionDate();
        GestionDate dp = new GestionDate();


        [TestMethod]
        public void TestJour()
        {

            Assert.AreEqual("202103", d.dateJour(), "Ce n'est pas la date du jour");
            Assert.AreNotEqual("202101", d.dateJour(), "Ce n'est pas la date du jour");


        }

        [TestMethod]
        public void TestMoisPrecedent()
        {
            Assert.AreEqual("202102", d.dateMoisPrecedent(), "Ce n'est pas le mois précedant la date du jour");
            Assert.AreNotEqual("202003", d.dateMoisPrecedent(), "Ce n'est pas le mois précedant la date du jour");
        }

        [TestMethod]
        public void TestMoisSuivant()
        {
            Assert.AreEqual("202104", d.dateMoisSuivant(), "Ce n'est pas le mois précedant la date du jour");
            Assert.AreNotEqual("202106", d.dateMoisSuivant(), "Ce n'est pas le mois précedant la date du jour");
        }
    }
    
}
