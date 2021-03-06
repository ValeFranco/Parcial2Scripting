using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

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
            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");
            Tablero tablero = new Tablero(deckJugador, deckEnemigo);

            Character character = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Undead);
            Equip Equip1 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            deckJugador.AnadirCarta(character);
            deckJugador.AnadirCarta(Equip1);

            Assert.AreEqual(true, character.AnadirEquip(Equip1, deckJugador));

            //No se a?ade si no tiene la misma afinidad
            Character character2 = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Mage);
            Equip Equip2 = new Equip("prueba2", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Knight, Equip.l_targetAttribute.RP, 12);

            Assert.AreEqual(false, character.AnadirEquip(Equip2, deckJugador));
        }
        [Test]
        public void TestLimiteEquiparCartaPorAfinidad()
        {
            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");
            Tablero tablero = new Tablero(deckJugador, deckEnemigo);

            Character character = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Undead);
            Equip Equip1 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip2 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip3 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip4 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            deckJugador.AnadirCarta(character);
            deckJugador.AnadirCarta(Equip1);
            deckJugador.AnadirCarta(Equip2);
            deckJugador.AnadirCarta(Equip3);
            deckJugador.AnadirCarta(Equip4);
            character.AnadirEquip(Equip1, deckJugador);
            character.AnadirEquip(Equip2, deckJugador);
            character.AnadirEquip(Equip3, deckJugador);

            var exception = Assert.Throws<System.Exception>(() => character.AnadirEquip(Equip4, deckJugador));
            Assert.AreEqual("No se pueden equipar mas de tres cartas tipo equip", exception.Message);
        }
        [Test]
        public void TestEliminarEquipoBaraja()
        {
            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");
            Tablero tablero = new Tablero(deckJugador, deckEnemigo);

            Character character = new Character("prueba", 5, Carta.l_Rarity.SuperRare, 17, 17, Character.l_Afinity.Undead);
            Equip Equip1 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip2 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip3 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            Equip Equip4 = new Equip("prueba", 3, Carta.l_Rarity.Rare, Equip.l_affinity.Undead, Equip.l_targetAttribute.RP, 12);
            deckJugador.AnadirCarta(character);
            deckJugador.AnadirCarta(Equip1);
            deckJugador.AnadirCarta(Equip2);

            Assert.AreEqual(3, deckJugador.cartas.Count());
            character.AnadirEquip(Equip1, deckJugador);
            Assert.AreEqual(2, deckJugador.cartas.Count());
            character.AnadirEquip(Equip2, deckJugador);
            Assert.AreEqual(1, deckJugador.cartas.Count());


        }
        [Test]
        public void TestReducirAPCartaEnemiga()
        {
            //que se reduzcan los puntos de ataque de la carta enemiga
          

            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");
            Tablero tablero = new Tablero(deckJugador, deckEnemigo);

            SupportSkill supportSkillJugador = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceAP, 8);
            Character characterEnemigo = new Character("prueba", 2, Carta.l_Rarity.Common,15, 10, Character.l_Afinity.Mage);
            Character characterJugador = new Character("prueba", 2, Carta.l_Rarity.Common, 15, 10, Character.l_Afinity.Mage);
            deckJugador.AnadirCarta(characterJugador);
            deckJugador.AnadirCarta(supportSkillJugador);
            deckEnemigo.AnadirCarta(characterEnemigo);

            tablero.SupportActive(supportSkillJugador, characterEnemigo); 

            Assert.AreEqual(7, characterEnemigo.AttackPoints); 
        } 
        [Test]
        public void TestReducirRPCartaEnemiga()
        {
            //que se reduzcan los puntos de ataque de la carta enemiga
        

            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");

            Tablero tablero = new Tablero(deckJugador, deckEnemigo);

            SupportSkill supportSkillJugador = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceRP, 8);
           Character characterEnemigo = new Character("prueba", 2, Carta.l_Rarity.Common,15, 10, Character.l_Afinity.Mage);
            Character characterJugador = new Character("prueba", 2, Carta.l_Rarity.Common, 15, 10, Character.l_Afinity.Mage);
            deckJugador.AnadirCarta(characterJugador);
            deckJugador.AnadirCarta(supportSkillJugador);
            deckEnemigo.AnadirCarta(characterEnemigo);

            tablero.SupportActive(supportSkillJugador, characterEnemigo); 
            
            Assert.AreEqual(2, characterEnemigo.ResistPoints); 
        } 
        [Test]
        public void TestReducirAmbosCartaEnemiga()
        {
            //que se reduzcan los puntos de ataque de la carta enemiga
           
            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");

            Tablero tablero = new Tablero(deckJugador, deckEnemigo);
            SupportSkill supportSkillJugador = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.ReduceAll, 8);
            Character characterEnemigo = new Character("prueba", 2, Carta.l_Rarity.Common, 18, 10, Character.l_Afinity.Mage);
            Character CharacterJugador = new Character("lordes", 4, Carta.l_Rarity.Common, 18, 10, Character.l_Afinity.Mage);
            deckJugador.AnadirCarta(CharacterJugador);
            deckJugador.AnadirCarta(supportSkillJugador);
            deckEnemigo.AnadirCarta(characterEnemigo);

            tablero.SupportActive(supportSkillJugador, characterEnemigo); 
            
            Assert.AreEqual(10, characterEnemigo.AttackPoints);
            Assert.AreEqual(2, characterEnemigo.ResistPoints);
        }
        [Test]
        public void TestRestaurarResistencia()
        {
            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");
            Tablero tablero = new Tablero(deckJugador, deckEnemigo);


            SupportSkill supportSkillJugador = new SupportSkill("Spartan", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.RestoreRP, 8);
            Character characterEnemigo = new Character("prueba", 2, Carta.l_Rarity.Common, 8, 3, Character.l_Afinity.Mage);
            Character target = new Character("prueba", 2, Carta.l_Rarity.Common, 4, 10, Character.l_Afinity.Mage);

            deckJugador.AnadirCarta(target);
            deckJugador.AnadirCarta(supportSkillJugador);
            deckEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(target, characterEnemigo);
            tablero.SupportActive(supportSkillJugador, target);
            Assert.AreEqual(1, deckJugador.cartas.Count());
            Assert.AreEqual(10, target.ResistPoints);
        }
        [Test]
        public void TestDestruirEquipEnemigo()
        {
            Deck deckJugador = new Deck("Vale");
            Deck deckEnemigo = new Deck("Laura");

            Tablero tablero = new Tablero(deckJugador, deckEnemigo);
            Character target = new Character("prueba", 2, Carta.l_Rarity.Common, 8, 18, Character.l_Afinity.Mage);
            Character enemigo  = new Character("enemigo", 2, Carta.l_Rarity.Common, 8, 18, Character.l_Afinity.Mage);

            Equip equip1 = new Equip("arma1", 1, Carta.l_Rarity.Common, Equip.l_affinity.Mage, Equip.l_targetAttribute.AP, 2);
            Equip equip2 = new Equip("arma2", 1, Carta.l_Rarity.Common, Equip.l_affinity.Mage, Equip.l_targetAttribute.AP, 1);

            //a?adimos la carta a la baraja del jugador 1
            deckJugador.AnadirCarta(target);
            deckJugador.AnadirCarta(equip1);
            deckJugador.AnadirCarta(equip2);
           // a?adimos el  equipo  al  personaje 
            target.AnadirEquip(equip1,deckJugador);
            target.AnadirEquip(equip2,deckJugador);
    
            List<Equip> equips = new List<Equip>();
            equips.Add(equip2);

            //comprobamos cuantos elementos  hay en la baraja  del jugador 1
            Assert.AreEqual(1, deckJugador.cartas.Count());
            // a?adimos  suppor y lo a?adimos a la baraja
            SupportSkill removeEquip = new SupportSkill("prueba", 1, Carta.l_Rarity.UltraRare, SupportSkill.l_effectType.DestroyEquip, 2);
            deckJugador.AnadirCarta(removeEquip);
            Assert.AreEqual(2, deckJugador.cartas.Count());
            // aplicamos la carta  y la eliminamos de la baraja 
            tablero.SupportActive(removeEquip,target);
             //comprobamo
            Assert.AreEqual(equips, target.equip);
            Assert.AreEqual(1,deckJugador.cartas.Count());

        }
        [Test]
        public void TestAumentarAPCartaCharacter()
        {
            //Tablero tablero = new Tablero();

            Deck deckJugador = new Deck("Vale");

            Character characterPropio = new Character("prueba", 2, Carta.l_Rarity.Common, 15, 10, Character.l_Afinity.Mage);
            Equip equip = new Equip("prueba", 3, Carta.l_Rarity.SuperRare, Equip.l_affinity.ALL, Equip.l_targetAttribute.AP, 2);

            deckJugador.AnadirCarta(characterPropio);
            deckJugador.AnadirCarta(equip);
            characterPropio.AnadirEquip(equip,deckJugador);
            // equip.AplicarEquip(characterPropio);

            Assert.AreEqual(17, characterPropio.AttackPoints);
        }
        [Test]
        public void TestAumentarRPCartaCharacter()
        {
            //Tablero tablero = new Tablero();

            Deck deckJugador = new Deck("Vale");

            Character characterPropio = new Character("prueba", 2, Carta.l_Rarity.Rare, 8, 10, Character.l_Afinity.Knight);
            Equip equip = new Equip("prueba", 3, Carta.l_Rarity.Common, Equip.l_affinity.Knight, Equip.l_targetAttribute.RP, 5);

            deckJugador.AnadirCarta(characterPropio);
            deckJugador.AnadirCarta(equip);
            characterPropio.AnadirEquip(equip,deckJugador);
           

            Assert.AreEqual(15, characterPropio.ResistPoints);
        }
        [Test]
        public void TestAumentarAmbosCartaCharacter()
        {
            //Tablero tablero = new Tablero();

            Deck deckJugador = new Deck("Vale");
            
            Character characterPropio = new Character("prueba", 2, Carta.l_Rarity.Common, 12, 14, Character.l_Afinity.Knight);
            Equip equip = new Equip("prueba", 3, Carta.l_Rarity.UltraRare, Equip.l_affinity.Knight, Equip.l_targetAttribute.ALL, 6);

            deckJugador.AnadirCarta(characterPropio);
            deckJugador.AnadirCarta(equip);
            characterPropio.AnadirEquip(equip,deckJugador);

            Assert.AreEqual(18, characterPropio.AttackPoints); 
            Assert.AreEqual(20, characterPropio.ResistPoints);

            var exception = Assert.Throws<System.Exception>(() => characterPropio.AplicarEquip(equip));
            Assert.AreEqual("la carta fue aplicada con anterioridad", exception.Message);
        }
        [Test]
        public void TestCartaNoEstaEnBaraja()
        {
            Deck barajaJugador = new Deck("Jugador1");
            Deck barajaEnemigo = new Deck("Jugador2");

            Tablero tablero = new Tablero(barajaJugador, barajaEnemigo);

            Character characterJugador = new Character("prueba", 20, Carta.l_Rarity.Rare, 14, 16, Character.l_Afinity.Mage);
            Character character = new Character("prueba", 20, Carta.l_Rarity.Common, 14, 10, Character.l_Afinity.Mage);
            Character characterEnemigo = new Character("prueba", 20, Carta.l_Rarity.Rare, 5, 14, Character.l_Afinity.Knight);

            barajaJugador.AnadirCarta(characterJugador);
            barajaEnemigo.AnadirCarta(characterEnemigo);

            var exception = Assert.Throws<System.Exception>(() => tablero.Atacar(character, characterEnemigo));
            Assert.AreEqual("No existe este personaje en la baraja del jugador", exception.Message);

        }
        [Test]
        public void TestAtacar()
        {
            Deck barajaJugador = new Deck("Jugador1");
            Deck barajaEnemigo = new Deck("Jugador2");

            Tablero tablero = new Tablero(barajaJugador, barajaEnemigo);

            Character characterJugador = new Character("prueba", 3, Carta.l_Rarity.SuperRare, 10, 20, Character.l_Afinity.Mage);
            Character characterEnemigo = new Character("prueba", 4, Carta.l_Rarity.Common, 5, 20, Character.l_Afinity.Mage);

            barajaJugador.AnadirCarta(characterJugador);
            barajaEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(characterJugador, characterEnemigo);

            Assert.AreEqual(15, characterJugador.ResistPoints);
            Assert.AreEqual(10, characterEnemigo.ResistPoints);

        }
        [Test]
        public void TestEmpate()
        {
            Deck barajaJugador = new Deck("Jugador1");
            Deck barajaEnemigo = new Deck("Jugador2");

            Tablero tablero = new Tablero(barajaJugador, barajaEnemigo);

            Character characterJugador = new Character("prueba", 2, Carta.l_Rarity.Rare, 4, 5, Character.l_Afinity.Mage);
            Character characterEnemigo = new Character("prueba", 5, Carta.l_Rarity.Rare, 5, 4, Character.l_Afinity.Undead);

            barajaJugador.AnadirCarta(characterJugador);
            barajaEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(characterJugador, characterEnemigo);
            Assert.AreEqual(0, barajaEnemigo.cartas.Count());
            Assert.AreEqual(false, barajaJugador.RemoverCarta(characterJugador));
            Assert.AreEqual(true, barajaEnemigo.RemoverCarta(characterEnemigo));

        }
        [Test]
        public void TestDestruirPersonaje()
        {
            Deck barajaJugador = new Deck("Jugador1");
            Deck barajaEnemigo = new Deck("Jugador2");

            Tablero tablero = new Tablero(barajaJugador, barajaEnemigo);
           
            Character characterJugador = new Character("prueba", 20, Carta.l_Rarity.Rare, 14, 16, Character.l_Afinity.Mage);
            Character characterEnemigo = new Character("prueba", 20, Carta.l_Rarity.Rare, 5, 14, Character.l_Afinity.Mage);

            barajaJugador.AnadirCarta(characterJugador);
            barajaEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(characterJugador, characterEnemigo);
            Assert.AreEqual(0, barajaEnemigo.cartas.Count());

            Assert.AreEqual(true, barajaEnemigo.RemoverCarta(characterEnemigo));
    
        }
        [Test]
        public void TestJugadorPierde()
        {
            /*
            Deck barajaJugador = new Deck("Jugador1");
            Deck barajaEnemigo = new Deck("Jugador2");

            Tablero tablero = new Tablero(barajaJugador, barajaEnemigo);

            Character characterJugador = new Character("prueba", 20, Carta.l_Rarity.Rare, 14, 16, Character.l_Afinity.Mage);
            Character characterEnemigo = new Character("prueba", 20, Carta.l_Rarity.Rare, 50, 50, Character.l_Afinity.Mage);
            Assert.AreEqual(false, barajaEnemigo.RemoverCarta(characterEnemigo));

            barajaJugador.AnadirCarta(characterJugador);
            barajaEnemigo.AnadirCarta(characterEnemigo);
            Assert.AreEqual(1, barajaJugador.cartas.Count());
            tablero.Atacar(characterJugador, characterEnemigo);
            Assert.AreEqual(0, barajaJugador.cartas.Count());

            Assert.AreEqual(true, tablero.PierdeJugador(barajaJugador));

            */

            Deck barajaJugador = new Deck("Jugador1");
            Deck barajaEnemigo = new Deck("Jugador2");

            Tablero tablero = new Tablero(barajaJugador, barajaEnemigo);

            Character characterJugador = new Character("prueba", 20, Carta.l_Rarity.Rare, 10, 14, Character.l_Afinity.Mage);
            Character characterEnemigo = new Character("prueba", 20, Carta.l_Rarity.Rare, 14, 16, Character.l_Afinity.Mage);

            barajaJugador.AnadirCarta(characterJugador);
            barajaEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(characterJugador, characterEnemigo);
            Assert.AreEqual(0, barajaJugador.cartas.Count());
          

            Assert.AreEqual(true, tablero.PierdeJugador());

            Assert.AreEqual(false, tablero.PierdeRival());
        }
        [Test]
        public void TestEnemigoPierde()
        {

            Deck barajaJugador = new Deck("Jugador1");
            Deck barajaEnemigo = new Deck("Jugador2");

            Tablero tablero = new Tablero(barajaJugador, barajaEnemigo);

            Character characterJugador = new Character("prueba", 20, Carta.l_Rarity.Rare, 23, 20, Character.l_Afinity.Mage);
            Character characterEnemigo = new Character("prueba", 20, Carta.l_Rarity.Rare, 14, 16, Character.l_Afinity.Mage);

            barajaJugador.AnadirCarta(characterJugador);
            barajaEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(characterJugador, characterEnemigo);
          

            Assert.AreEqual(false, tablero.PierdeJugador());

            Assert.AreEqual(true, tablero.PierdeRival());
        }
        [Test]
        public void TestUnicoUsoCarta()
        {

            Deck barajaJugador = new Deck("Jugador1");
            Deck barajaEnemigo = new Deck("Jugador2");

            Tablero tablero = new Tablero(barajaJugador, barajaEnemigo);

            Character characterJugador = new Character("prueba", 20, Carta.l_Rarity.Rare, 14, 16, Character.l_Afinity.Mage);
            Character characterEnemigo = new Character("prueba", 20, Carta.l_Rarity.Rare, 5, 14, Character.l_Afinity.Mage);

            barajaJugador.AnadirCarta(characterJugador);
            barajaEnemigo.AnadirCarta(characterEnemigo);

            tablero.Atacar(characterJugador, characterEnemigo);

            Assert.AreEqual(true, barajaEnemigo.RemoverCarta(characterEnemigo));

            var exception = Assert.Throws<System.Exception>(() => tablero.Atacar(characterJugador, characterEnemigo));
            Assert.AreEqual("No existe este personaje en la baraja del jugador", exception.Message);
        }
    }
}