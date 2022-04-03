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

        //A?adir carta a la baraja
        [Test]
        public void TestAnadirCarta()
        {
            
            //Restar puntos a la baraja
            Character character = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Deck deck = new Deck("Juan");
            deck.AnadirCarta(character);
            Assert.AreEqual(18, deck.totalPoints);

            //Que no se pueda a?adir una carta con un costo mayor 
            Character character2 = new Character("prueba", 19, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            var exception = Assert.Throws<System.Exception>(() => deck.AnadirCarta(character2));
            Assert.AreEqual("No tienes suficientes costPoints para anadir esta carta", exception.Message);

            
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

            
            deck.AnadirCarta(character1);
            deck.AnadirCarta(character2);
            deck.AnadirCarta(character3);
            deck.AnadirCarta(character4);
            deck.AnadirCarta(character5);

            var exception = Assert.Throws<System.Exception>(() => deck.AnadirCarta(character6));
            
            Assert.AreEqual("Has superado el limite de cartas tipo character", exception.Message);
            

        }
        [Test]
        public void TestLimiteEquip()
        {
            Deck deck = new Deck("Juan");
            Character character1 = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Equip Equip1 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip2 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip3 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip4 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip5 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip6 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip7 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip8 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip9 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip10 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip11 = new Equip("prueba", 1, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);

            deck.AnadirCarta(character1);
            deck.AnadirCarta(Equip1);
            deck.AnadirCarta(Equip2);
            deck.AnadirCarta(Equip3);
            deck.AnadirCarta(Equip4);
            deck.AnadirCarta(Equip5);
            deck.AnadirCarta(Equip6);
            deck.AnadirCarta(Equip7);
            deck.AnadirCarta(Equip8);
            deck.AnadirCarta(Equip9);
            deck.AnadirCarta(Equip10);

            var exception = Assert.Throws<System.Exception>(() => deck.AnadirCarta(Equip11));
            Assert.AreEqual("Has superado el limite de cartas tipo equip", exception.Message);
        }
        [Test]
        public void TestLimiteSupportSkills()
        {
            Deck deck = new Deck("Juan");
            Character character1 = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            SupportSkill supportSkill = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill2 = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill3 = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill4 = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill5 = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            SupportSkill supportSkill6 = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);

            deck.AnadirCarta(character1);
            deck.AnadirCarta(supportSkill);
            deck.AnadirCarta(supportSkill2);
            deck.AnadirCarta(supportSkill3);
            deck.AnadirCarta(supportSkill4);
            deck.AnadirCarta(supportSkill5);

            var exception = Assert.Throws<System.Exception>(() => deck.AnadirCarta(supportSkill6));
            Assert.AreEqual("Has superado el limite de cartas tipo supportSkill", exception.Message);
        }
        [Test]
        public void TestBarajaVacia()
        {
            Character character = new Character("prueba", 2, Carta.l_Rarity.Common, 10, 10, Character.l_Afinity.Mage);
            Deck deck = new Deck("juan");
            List<Carta> listaCartas = new List<Carta>();
            listaCartas.Add(character);
            deck.AnadirCarta(character);

            Assert.AreEqual(listaCartas, deck.cartas);
        }
        [Test]
        public void TestEquiparCartaIgualAfinidad()
        {
            //Si tiene la misma afinidad se a?ade
            Character character = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Undead);
            Equip Equip1 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);

            character.AnadirEquip(Equip1);

            Assert.AreEqual(true, character.AnadirEquip(Equip1));

            //No se a?ade si no tiene la misma afinidad
            Character character2 = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Mage);
            Equip Equip2 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Knight, Equip.l_targetAttribute.RP, 12);

            character.AnadirEquip(Equip2);

            Assert.AreEqual(false, character.AnadirEquip(Equip2));
        }
        [Test]
        public void TestLimiteEquiparCartaPorAfinidad()
        {
            Character character = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Undead);
            Equip Equip1 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip2 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip3 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip4 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);

            character.AnadirEquip(Equip1);
            character.AnadirEquip(Equip2);
            character.AnadirEquip(Equip3);

            var exception = Assert.Throws<System.Exception>(() => character.AnadirEquip(Equip4));
            Assert.AreEqual("No se pueden equipar mas de tres cartas tipo equip", exception.Message);
        }
        [Test]
        public void TestReducirAPCartaEnemiga()
        {
            //que se reduzcan los puntos de ataque de la carta enemiga
            Tablero tablero = new Tablero();

            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");

            SupportSkill supportSkillJugador = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceAP, 8);
            Character characterEnemigo = new Character("prueba", 2, Carta.l_Rarity.Common,15, 10, Character.l_Afinity.Mage);

            deckJugador.AnadirCarta(supportSkillJugador);
            deckEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(supportSkillJugador, characterEnemigo); //?
            supportSkillJugador.ReducirAttackPoints(characterEnemigo);

            Assert.AreEqual(7, characterEnemigo.AttackPoints); 
        } 
        [Test]
        public void TestReducirRPCartaEnemiga()
        {
            //que se reduzcan los puntos de ataque de la carta enemiga
            Tablero tablero = new Tablero();

            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");

            SupportSkill supportSkillJugador = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
            Character characterEnemigo = new Character("prueba", 2, Carta.l_Rarity.Common,10,10, Character.l_Afinity.Mage);

            deckJugador.AnadirCarta(supportSkillJugador);
            deckEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(supportSkillJugador, characterEnemigo); 
            supportSkillJugador.ReducirResistPoints(characterEnemigo);

            Assert.AreEqual(2, characterEnemigo.ResistPoints); 
        } 
        [Test]
        public void TestReducirAmbosCartaEnemiga()
        {
            //que se reduzcan los puntos de ataque de la carta enemiga
            Tablero tablero = new Tablero();

            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");

            SupportSkill supportSkillJugador = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceAll, 8);
            Character characterEnemigo = new Character("prueba", 2, Carta.l_Rarity.Common, 18, 10, Character.l_Afinity.Mage);

            deckJugador.AnadirCarta(supportSkillJugador);
            deckEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(supportSkillJugador, characterEnemigo); 
            supportSkillJugador.ReducirTodo(characterEnemigo);

            Assert.AreEqual(10, characterEnemigo.AttackPoints);
            Assert.AreEqual(2, characterEnemigo.ResistPoints);
        } 

        [Test]
        public void TestRestaurarResistencia()
        {

        }

        [Test]
        public void TestAplicarEquip()
        {
            
        }
        [Test]
        public void TestRemoverCarta()
        {
            
        }
        [Test]
        public void TestDosBarajasDistintas()
        {
            
        }
        [Test]
        public void TestAtacar()
        {
            
        }
        [Test]
        public void TestDestruirPersonaje()
        {
            
        }
        [Test]
        public void TestJugadorPierde()
        {
            
        }
        [Test]
        public void TestUnicoUsoCarta()
        {
            
        }
    }
}