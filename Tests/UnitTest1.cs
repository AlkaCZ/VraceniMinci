using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VraceniMinci;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Spravne_Vraceni_Na_Korunu()
        {
            //Arrange
            int testovaneCislo = 1;

            //Act
            Program.Rozdeleni(true, true, true, true, true, testovaneCislo);
            //Assert
            Assert.AreEqual(testovaneCislo, Program.pocetJedna);
        }
        [TestMethod]
        public void Spravne_Vraceni_Pouze_V_PadesatiKorunach()
        {
            //Arrange
            int testovaneCislo = 150;

            //Act
            Program.Rozdeleni(true, false, false, false, false, testovaneCislo);
            //Assert
            Assert.AreEqual(3, Program.pocetPadesat);
        }
        [TestMethod]
        public void Spravne_Vraceni_Pouze_V_PetiKorunach()
        {
            //Arrange
            int testovaneCislo = 50;

            //Act
            Program.Rozdeleni(false, false, false, true, false, testovaneCislo);
            //Assert
            Assert.AreEqual(10, Program.pocetPet);
        }
        [TestMethod]
        public void Spravne_Vraceni_Vsechny_Rady()
        {
            //Arrange
            int testovaneCislo = 88;

            //Act
            Program.Rozdeleni(true, true, true, true, true, testovaneCislo);
            //Assert
            Assert.AreEqual(1, Program.pocetPadesat);
            Assert.AreEqual(1, Program.pocetDvacet);
            Assert.AreEqual(1, Program.pocetDeset);
            Assert.AreEqual(1, Program.pocetPet);
            Assert.AreEqual(1, Program.pocetDva);
            Assert.AreEqual(1, Program.pocetJedna);


        }
    }
}
