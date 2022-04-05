using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    class Tablero
    {
        internal Deck player1;
        internal Deck player2;

        public Tablero(Deck player1, Deck player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void Atacar(Character cartaP1, Character cartaP2)
        {
          int Charactep1 = player1.cartas.IndexOf(cartaP1);
          int Charactep2 = player2.cartas.IndexOf(cartaP2);

           if (Charactep1 !=-1 && Charactep2 !=-1)
           {
           

                    cartaP1 = (player1.cartas.ElementAt(Charactep1)) as Character;
                    cartaP2 = (player2.cartas.ElementAt(Charactep2)) as Character;

                    //¿hay un empate?

               if(cartaP1.resistPoints <= cartaP2.attackPoints && cartaP2.resistPoints <= cartaP1.attackPoints)
               {

                    //carta 1 y carta 2 tienen afinidades iguales
                    if(cartaP1.afinity == cartaP2.afinity)
                    {
                        cartaP1.resistPoints -= cartaP2.attackPoints;
                        cartaP2.resistPoints -= cartaP1.attackPoints;
                        player1.RemoverCarta(cartaP1);
                        player2.RemoverCarta(cartaP2);


                    }

                    // Carta 1 tiene ventaja sobre carta 2 por ser mago
                    else if(cartaP1.afinity == Character.l_Afinity.Mage && cartaP2.afinity == Character.l_Afinity.Undead)
                    {
                        cartaP1.attackPoints++;
                        cartaP2.attackPoints--;

                        cartaP1.resistPoints -= cartaP2.attackPoints;
                        cartaP2.resistPoints -= cartaP1.attackPoints;

                        player1.RemoverCarta(cartaP1);
                        player2.RemoverCarta(cartaP2);
                    }

                    //carta 1 tiene ventaja sobre carta 2 por ser caballero

                    else if(cartaP1.afinity == Character.l_Afinity.Knight && cartaP2.afinity == Character.l_Afinity.Mage)
                    {
                        cartaP1.attackPoints++;
                        cartaP2.attackPoints--;

                        cartaP1.resistPoints -= cartaP2.attackPoints;
                        cartaP2.resistPoints -= cartaP1.attackPoints;

                        player1.RemoverCarta(cartaP1);
                        player2.RemoverCarta(cartaP2);

                    }

                    // carta 1 tiene ventaja sobre carta 2 por ser undead

                     else if( cartaP1.afinity == Character.l_Afinity.Undead && cartaP2.afinity == Character.l_Afinity.Knight)
                    {
                        cartaP1.attackPoints++;
                        cartaP2.attackPoints--;

                        cartaP1.resistPoints -= cartaP2.attackPoints;
                        cartaP2.resistPoints -= cartaP1.attackPoints;

                        player1.RemoverCarta(cartaP1);
                        player2.RemoverCarta(cartaP2);
                    }


                    //SI NO ESTA EN VENTAJA, ESTA EN DESVENTAJA, ENTONCES:
                    else
                    {
                        cartaP1.attackPoints--;
                        cartaP2.attackPoints++;

                        cartaP1.resistPoints -= cartaP2.attackPoints;
                        cartaP2.resistPoints -= cartaP1.attackPoints;

                        player1.RemoverCarta(cartaP1);
                        player2.RemoverCarta(cartaP2);
                    }


                }

               else
                {

                    cartaP1.resistPoints -= cartaP2.attackPoints;
                    cartaP2.resistPoints -= cartaP1.attackPoints;

                    player1.RemoverCarta(cartaP1);
                    player2.RemoverCarta(cartaP2);

                }


               // carta1: 4 AP y 5RP MAGO
               // carta2 5 AP y 4 RP UNDEAD

               // CHECKEO DE AFINIDAD: CARTA1 GANA

               //carta1 : 5AP y 5RP
               //carta2  4AP y 4RP

               //SE RESTA

               //carta1: 5AP y 1 RP
               //carta2  4AP -1RP


            }
            else
            {
                    throw new Exception("No existe este personaje en la baraja del jugador");
            }

            
          

        }
        public void SupporActive(SupportSkill cartaP1, Character cartaP2)
        {
            int carta1 = player1.cartas.IndexOf(cartaP1); //si el support exite  en la baraja
            int carta2 = player2.cartas.IndexOf(cartaP2); // si exite el personaje en la baraja enemiga
            if (carta1 != -1 && carta2 != -1) //comprobar si exites en respectivas cosas  
            {
                    if (cartaP1.effectType.ToString() == "ReduceAP")
                    {
                        cartaP2.AttackPoints -= cartaP1.effectPoints;

                    }
                    else if (cartaP1.effectType.ToString() == "ReduceRP")
                    {
                        cartaP2.ResistPoints -= cartaP1.effectPoints;
                    }
                    else if (cartaP1.effectType.ToString() == "ReduceAll")
                    {
                        cartaP2.AttackPoints -= cartaP1.effectPoints;
                        cartaP2.ResistPoints -= cartaP1.effectPoints;
                    }
                    else if (cartaP1.effectType.ToString() == "DestroyEquip")
                    {

                    cartaP2.equip.RemoveAt(0);
                    }
            }
            else
            {
                int carta3 = player1.cartas.IndexOf(cartaP2);
                if (carta3 != -1) // si es jugador aliado 
                {
                    if (cartaP1.effectType.ToString() == "RestoreRP")
                    {
                        if (cartaP2.ResistPoints + cartaP1.effectPoints > cartaP2.Heald)//si es mayor 
                        {
                            cartaP2.ResistPoints = cartaP2.Heald;
                            foreach (Carta elemento in player1.cartas)
                            {
                                if (elemento is Character)
                                {
                                    cartaP2.ResistPoints = (elemento as Character).ResistPoints;
                                }


                            }
                        }
                        else
                        {
                            cartaP2.ResistPoints += cartaP1.effectPoints;

                        }


                    }
                    else if (cartaP1.effectType.ToString() == "DestroyEquip")
                    {

                        cartaP2.equip.RemoveAt(0);
                    }

                }
                else 
                {
                    throw new Exception("No existe estas cartas en las baraja  del jugador 1 o 2");
                }
            }
        }



    }
}
