using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    class Tablero
    {
        private Deck player1;
        private Deck player2;

        public void Atacar(Carta cartaP1, Carta cartaP2)
        {
            if (cartaP1 is Character && cartaP2 is Character)
            {
                Character persona1;
                Character persona2;
                int Charactep1 = player1.cartas.IndexOf(cartaP1);
                int Charactep2 = player1.cartas.IndexOf(cartaP2);
                if (Charactep1 !=-1 && Charactep2 !=-1)
                {
                    persona1 = cartaP1 as Character;
                    persona2 = cartaP2 as Character;
                    if (persona1.AttackPoints-persona2.ResistPoints <=0 && persona2.AttackPoints - persona1.ResistPoints >0)
                    {
                        persona1.ResistPoints = persona2.AttackPoints - persona1.ResistPoints;
                        player2.cartas.Remove(cartaP2); //eliminamos la carta del jugador 2 ya que gano el primero 
                    }
                    else if(persona2.AttackPoints - persona1.ResistPoints <= 0 && persona1.AttackPoints - persona2.ResistPoints > 0)
                    {
                        persona2.ResistPoints = persona1.AttackPoints - persona2.ResistPoints;
                        player1.cartas.Remove(cartaP1); //eliminamos la carta del jugador 2 ya que gano el primero 
                    }
                    else
                    {
                        if (persona1.afinity.ToString()==persona1.afinity.ToString())// si ambos tiene la misma afinidad ambos vuelan 
                        {
                            player1.cartas.Remove(cartaP1);
                            player2.cartas.Remove(cartaP2);
                        }
                        else if (persona1.afinity.ToString() == "Knight" && persona1.afinity.ToString()== "Mage")//gana el 1
                        {
                            persona1.ResistPoints = persona2.AttackPoints - persona1.ResistPoints;
                            player2.cartas.Remove(cartaP2);
                        }
                        else if (persona1.afinity.ToString() == "Mage" && persona1.afinity.ToString() == "Undead")//gana el 1
                        {
                            persona1.ResistPoints = persona2.AttackPoints - persona1.ResistPoints;
                            player2.cartas.Remove(cartaP2);
                        }
                        else if (persona1.afinity.ToString() == "Undead" && persona1.afinity.ToString() == "Knight")//gana el 1
                        {
                            persona1.ResistPoints = persona2.AttackPoints - persona1.ResistPoints;
                            player2.cartas.Remove(cartaP2);
                        }
                        else //gana el 2 
                        {
                            persona2.ResistPoints = persona1.AttackPoints - persona2.ResistPoints;
                            player1.cartas.Remove(cartaP1);
                        }
                    }

                }
                else
                {
                    throw new Exception("No existe este personaje en la baraja  del jugador ");
                }

                // usuario.l_propia_libros.IndexOf(material);
            }
            else
            {
                throw new Exception("solo se pueden atacar los personajes  ");
            }

        }
        public void SupporActive(Carta cartaP1, Carta cartaP2)
        {

        }



    }
}
