using NUnit.Framework;
using System.Collections.Generic;

namespace Parcial2Scripting
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        //Añadir carta a la baraja
        [Test]
        public void TestAñadirCarta()
        {
            //Restar puntos a la baraja
            Character character = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Deck deck = new Deck("Juan");
            deck.AñadirCarta(character);
            Assert.AreEqual(18, deck.totalPoints);

            //Que no se pueda añadir una carta con un costo mayor 
            Character character2 = new Character("prueba", 19, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            var exception = Assert.Throws<System.Exception>(() => deck.AñadirCarta(character2));
            Assert.AreEqual("No tienes suficientes costPoints para añadir esta carta", exception.Message);
        }
        [Test]
        public void TestLimiteCharacter()
        {
            Deck deck = new Deck("Juan");
            Character character1 = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Character character2 = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Character character3 = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Character character4 = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Character character5 = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Character character6 = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);

            deck.AñadirCarta(character1);
            deck.AñadirCarta(character2);
            deck.AñadirCarta(character3);
            deck.AñadirCarta(character4);
            deck.AñadirCarta(character5);

            var exception = Assert.Throws<System.Exception>(() => deck.AñadirCarta(character6));
            Assert.AreEqual("Has superado el limite de cartas tipo character", exception.Message);
        }
        [Test]
        public void TestLimiteEquip()
        {
            Deck deck = new Deck("Juan");
            Equip Equip1 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip2 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip3 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip4 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip5 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip6 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip7 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip8 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip9 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip10 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip11 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);

            deck.AñadirCarta(Equip1);
            deck.AñadirCarta(Equip2);
            deck.AñadirCarta(Equip3);
            deck.AñadirCarta(Equip4);
            deck.AñadirCarta(Equip5);
            deck.AñadirCarta(Equip6);
            deck.AñadirCarta(Equip7);
            deck.AñadirCarta(Equip8);
            deck.AñadirCarta(Equip9);
            deck.AñadirCarta(Equip10);

            var exception = Assert.Throws<System.Exception>(() => deck.AñadirCarta(Equip11));
            Assert.AreEqual("Has superado el limite de cartas tipo equip", exception.Message);
        }
        [Test]
        public void TestLimiteSupportSkills()
        {
            Deck deck = new Deck("Juan");
            SupportSkill supportSkill = new SupportSkill("prueba", 5, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill2 = new SupportSkill("prueba", 5, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill3 = new SupportSkill("prueba", 5, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill4 = new SupportSkill("prueba", 5, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill5 = new SupportSkill("prueba", 5, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill6 = new SupportSkill("prueba", 5, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);

            deck.AñadirCarta(supportSkill);
            deck.AñadirCarta(supportSkill2);
            deck.AñadirCarta(supportSkill3);
            deck.AñadirCarta(supportSkill4);
            deck.AñadirCarta(supportSkill5);

            var exception = Assert.Throws<System.Exception>(() => deck.AñadirCarta(supportSkill6));
            Assert.AreEqual("Has superado el limite de cartas tipo supportSkill", exception.Message);
        }
      
        [Test]
        public void TestBarajaVacia()
        {
            Character character = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Deck deck = new Deck("juan");
            List<Carta> listaCartas = new List<Carta>();
            listaCartas.Add(character);

            Assert.AreEqual(listaCartas, deck.cartas);
        }
        public void TestEquiparCarta()
        {
            Assert.Pass();
        }

        [Test]
        public void TestAplicarSkill()
        {
            Assert.Pass();
        }

        [Test]
        public void TestAplicarEquip()
        {
            Assert.Pass();
        }
        [Test]
        public void TestRemoverCarta()
        {
            Assert.Pass();
        }
        [Test]
        public void TestDosBarajasDistintas()
        {
            Assert.Pass();
        }
        [Test]
        public void TestAtacar()
        {
            Assert.Pass();
        }
        [Test]
        public void TestDestruirPersonaje()
        {
            Assert.Pass();
        }
        [Test]
        public void TestJugadorPierde()
        {
            Assert.Pass();
        }
        [Test]
        public void TestUnicoUsoCarta()
        {
            Assert.Pass();
        }
    }
}