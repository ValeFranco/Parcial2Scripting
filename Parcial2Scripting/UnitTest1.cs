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

        //Aņadir carta a la baraja
        [Test]
        public void TestAņadirCarta()
        {
            //Restar puntos a la baraja
            Character character = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Deck deck = new Deck("Juan");
            deck.AņadirCarta(character);
            Assert.AreEqual(18, deck.totalPoints);

            //Que no se pueda aņadir una carta con un costo mayor 
            Character character2 = new Character("prueba", 19, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            var exception = Assert.Throws<System.Exception>(() => deck.AņadirCarta(character2));
            Assert.AreEqual("No tienes suficientes costPoints para aņadir esta carta", exception.Message);
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

            deck.AņadirCarta(character1);
            deck.AņadirCarta(character2);
            deck.AņadirCarta(character3);
            deck.AņadirCarta(character4);
            deck.AņadirCarta(character5);

            var exception = Assert.Throws<System.Exception>(() => deck.AņadirCarta(character6));
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

            deck.AņadirCarta(Equip1);
            deck.AņadirCarta(Equip2);
            deck.AņadirCarta(Equip3);
            deck.AņadirCarta(Equip4);
            deck.AņadirCarta(Equip5);
            deck.AņadirCarta(Equip6);
            deck.AņadirCarta(Equip7);
            deck.AņadirCarta(Equip8);
            deck.AņadirCarta(Equip9);
            deck.AņadirCarta(Equip10);

            var exception = Assert.Throws<System.Exception>(() => deck.AņadirCarta(Equip11));
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

            deck.AņadirCarta(supportSkill);
            deck.AņadirCarta(supportSkill2);
            deck.AņadirCarta(supportSkill3);
            deck.AņadirCarta(supportSkill4);
            deck.AņadirCarta(supportSkill5);

            var exception = Assert.Throws<System.Exception>(() => deck.AņadirCarta(supportSkill6));
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
        [Test]
        public void TestEquiparCartaIgualAfinidad()
        {
            //Si tiene la misma afinidad se aņade
            Character character = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Undead);
            Equip Equip1 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);

            character.equip.Add(Equip1);

            //No se aņade si no tiene la misma afinidad
            Character character2 = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Mage);
            Equip Equip2 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Knight, Equip.l_targetAttribute.RP, 12);

            var exception = Assert.Throws<System.Exception>(() => character.equip.Add(Equip2));
            Assert.AreEqual("No se puede equipar una carta en character que no tenga la misma afinidad", exception.Message);
        }
        [Test]
        public void TestLimiteEquiparCartaPorAfinidad()
        {
            Character character = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Undead);
            Equip Equip1 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip2 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Mage, Equip.l_targetAttribute.RP, 12);
            Equip Equip3 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Knight, Equip.l_targetAttribute.RP, 12);
            Equip Equip4 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Knight, Equip.l_targetAttribute.RP, 12);

            character.equip.Add(Equip1);
            character.equip.Add(Equip2);
            character.equip.Add(Equip3);

            var exception = Assert.Throws<System.Exception>(() => character.equip.Add(Equip4));
            Assert.AreEqual("No se pueden equipar mas de tres cartas tipo equip", exception.Message);
        }
        [Test]
        public void TestAplicarSkill()
        {
            Deck deck1 = new Deck("Vale");
            Deck deck2 = new Deck("Laura");

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