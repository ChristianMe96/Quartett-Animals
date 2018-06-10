using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierQuartett
{
    public class Functionality
    {

        public void ResetGame()
        {

        }

        public List<Animal> generateCards()
        {
            Animal leopard = new Animal("Leopard", 58, 31, 17, 1.6);
            Animal elephant = new Animal("Elefant", 10, 6000, 70, 3.3);
            Animal brownbear = new Animal("Braunbär", 40, 600, 25, 2.8);
            Animal gorilla = new Animal("gorilla", 40, 160, 40, 1.7);

            List<Animal> animalList = new List<Animal>();

            animalList.Add(leopard);
            animalList.Add(elephant);
            animalList.Add(brownbear);
            animalList.Add(gorilla);



            return animalList;
        }


        public List<Animal> DistributeCards()
        {

            List<Animal> animalList = generateCards();

            Random rand = new Random();

            List<Animal> playerCards = new List<Animal>();

            while (playerCards.Count < 2)
            {
                int randomIndex = rand.Next(0, animalList.Count);
 
                playerCards.Add(animalList[randomIndex]);

             //   animalList.RemoveAt(randomIndex);

            }

            return playerCards;
        }

        public void fightCards(double player1Value, double player2Value)
        {
            // 
            // TO DO ------- Berechnung Welcher ausgewählte Wert gewonnen hat
            // double als parameter oder ganzes Object ???? ..
            
           
        }

    }
}
  