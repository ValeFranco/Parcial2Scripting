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
                    
                      cartaP1.ResistPoints -=cartaP2.AttackPoints;
                      cartaP2.ResistPoints -= cartaP1.AttackPoints;
                //  player2.cartas.Remove(cartaP2); //eliminamos la carta del jugador 2 ya que gano el primero 
                return;
                  

                }
                else
                {
                    throw new Exception("No existe este personaje en la baraja  del jugador ");
                }

                // usuario.l_propia_libros.IndexOf(material);
            
          

        }
        public void SupporActive(SupportSkill cartaP1, Character cartaP2)
        {
            int carta1 = player1.cartas.IndexOf(cartaP1);
            int carta2 = player2.cartas.IndexOf(cartaP2);
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
                        }
                        else
                        {
                            cartaP2.ResistPoints += cartaP1.effectPoints;
                        }


                    }

                }
                else // si el jugador es enemigo 
                {
                    throw new Exception("No existe estas cartas  en las baraja  del jugador 1 o 2");
                }
            }
        }



    }
}
