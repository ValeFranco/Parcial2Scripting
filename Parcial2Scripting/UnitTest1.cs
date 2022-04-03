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

        //A�adir carta a la baraja
        [Test]
        public void TestA�adirCarta()
        {
            //Restar puntos a la baraja
            Character character = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Deck deck = new Deck("Juan");
            deck.A�adirCarta(character);
            Assert.AreEqual(18, deck.totalPoints);

            //Que no se pueda a�adir una carta con un costo mayor 
            Character character2 = new Character("prueba", 19, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            var exception = Assert.Throws<System.Exception>(() => deck.A�adirCarta(character2));
            Assert.AreEqual("No tienes suficientes costPoints para a�adir esta carta", exception.Message);
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

            deck.A�adirCarta(character1);
            deck.A�adirCarta(character2);
            deck.A�adirCarta(character3);
            deck.A�adirCarta(character4);
            deck.A�adirCarta(character5);

            var exception = Assert.Throws<System.Exception>(() => deck.A�adirCarta(character6));
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

            deck.A�adirCarta(Equip1);
            deck.A�adirCarta(Equip2);
            deck.A�adirCarta(Equip3);
            deck.A�adirCarta(Equip4);
            deck.A�adirCarta(Equip5);
            deck.A�adirCarta(Equip6);
            deck.A�adirCarta(Equip7);
            deck.A�adirCarta(Equip8);
            deck.A�adirCarta(Equip9);
            deck.A�adirCarta(Equip10);

            var exception = Assert.Throws<System.Exception>(() => deck.A�adirCarta(Equip11));
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

            deck.A�adirCarta(supportSkill);
            deck.A�adirCarta(supportSkill2);
            deck.A�adirCarta(supportSkill3);
            deck.A�adirCarta(supportSkill4);
            deck.A�adirCarta(supportSkill5);

            var exception = Assert.Throws<System.Exception>(() => deck.A�adirCarta(supportSkill6));
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