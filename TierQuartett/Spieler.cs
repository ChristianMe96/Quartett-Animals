using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierQuartett
{
    public class Spieler
    {
        private string name;
        public string Name
         {
             set
             {
                 this.name = value;
             }
            get
            {
                return name;
            }
        }

        private List<Animal> deck;
        public List<Animal> Deck
             {
            set
            {
                this.deck = value;
            }
            get
            {
                return deck;
            }
        }
    }
}
