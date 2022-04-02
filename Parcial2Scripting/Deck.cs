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
        internal uint totalPoints;
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
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                  throw new Exception("el nombre no puede tener espacios en blanco  ");
                }
                else
                {
                  nombreJugador = value;
                }

            }


        }

       public void AñadirCarta(Carta carta)
        {

        }
    }
}
