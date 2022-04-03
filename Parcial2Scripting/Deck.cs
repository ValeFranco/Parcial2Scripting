using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Scripting
{
    public class Deck
    {
        private string nombreJugador;
        internal uint totalPoints = 20;
        internal List<Carta> cartas;
        private byte characterCount;
        private byte equipCount;
        private byte supportCount;


        public Deck(string nombreJugador)
        {
            NombreJugador = nombreJugador;

            characterCount = 0;
            supportCount = 0;
            equipCount = 0;

            cartas = new List<Carta>();

        }


        internal string NombreJugador
        {
            get => nombreJugador;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                  throw new Exception("el nombre no puede tener espacios en blanco  ");
                }
                else
                {
                  nombreJugador = value;
                }
            }
        }

       public void AnadirCarta(Carta carta)
       {
            
            if (cartas.Count()==0)
            {
                if(carta is Character)
                {
                    if (totalPoints >= carta.CostPoint)
                    {
                        cartas.Add(carta);
                        characterCount++;
                        totalPoints -= carta.CostPoint;
                        return;

                    }
                    else
                    {
                        throw new Exception("No tienes suficientes costPoints para anadir esta carta");
                    }
                  
                }

                else
                {
                    throw new Exception("la primera carta DEBE de ser un character");
                }

            }
            else
            {
                if(totalPoints >= carta.CostPoint)
                {
                    

                    if(carta is Character)
                    {
                        if(characterCount<5)
                        {
                            cartas.Add(carta);
                            totalPoints -= carta.CostPoint;
                            characterCount++;
                        }

                        else
                        {
                            throw new Exception("Has superado el limite de cartas tipo character");
                        }
                       
                    }
                    else if(carta is SupportSkill)
                    {
                        if(supportCount<5)
                        {
                            cartas.Add(carta);
                            totalPoints -= carta.CostPoint;
                            supportCount++;
                        }

                        else
                        {
                            throw new Exception("Has superado el limite de cartas tipo supportSkill");
                        }


                    }
                    else if( carta is Equip)
                    {
                        if(equipCount<10)
                        {
                            cartas.Add(carta);
                            totalPoints -= carta.CostPoint;
                            equipCount++;
                        }

                        else
                        {
                            throw new Exception("Has superado el limite de cartas tipo equip");
                        }

                    }

                  
                }

                else
                {
                    throw new Exception("No tienes suficientes costPoints para anadir esta carta");
                }

            }

        }
       public void RemoverCarta(Carta carta)
       {

       }
    }
}
