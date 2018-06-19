using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierQuartett
{
    public class Functionality
    {

       private List<Animal> animalList = new List<Animal>();

       public Functionality() {
           this.animalList = generateCards();
       }

        //generirert die Objekte Animals
        public List<Animal> generateCards()
        {
            Animal leopard = new Animal("Leopard", 58, 31, 17, 1.6, "animal-images/leopard.jpg");
            Animal elephant = new Animal("Elefant", 10, 6000, 70, 3.3, "animal-images/elephant.jpg");
            Animal brownbear = new Animal("Braunbär", 40, 600, 25, 2.8, "animal-images/brownbear.jpg");
            Animal gorilla = new Animal("Gorilla", 40, 160, 40, 1.7, "animal-images/gorilla.jpg");
            Animal bluewhale = new Animal("Blauwal", 30, 200000, 80, 33, "animal-images/bluewhale.jpg");
            Animal giraffe = new Animal("Giraffe", 60, 1200, 35, 6, "animal-images/giraffe.jpg");
            Animal turtle = new Animal("Schildkröte", 2, 700, 200, 2.2, "animal-images/turtle.jpg");
            Animal lion = new Animal("Löwe", 80, 190, 14, 2.5, "animal-images/lion.jpg");

            List<Animal> animalList = new List<Animal>();

            animalList.Add(leopard);
            animalList.Add(elephant);
            animalList.Add(brownbear);
            animalList.Add(gorilla);
            animalList.Add(bluewhale);
            animalList.Add(giraffe);
            animalList.Add(turtle);
            animalList.Add(lion);


            return animalList;
        }

        //Verteilt die Karten in die Stapel der Spieler
        public List<Animal> DistributeCards()
        {

            Random rand = new Random();

            List<Animal> playerCards = new List<Animal>();

            while (playerCards.Count < 4)
            {
                int randomIndex = rand.Next(0, animalList.Count);
 
                playerCards.Add(animalList[randomIndex]);

                animalList.RemoveAt(randomIndex);

            }

            return playerCards;
        }

        public int fightCards(Animal player1CurrAnimal, double player1Value, Animal player2CurrAnimal, double player2Value)
        {
            int winner = 0;

            if(player1Value > player2Value)
            {
                // Die verlorene Karte wird aus dem Stapel von Player2 entfernt
                Form1.player2.Deck.Remove(player2CurrAnimal);
                // Die verlorene Karte wird dem Stapel von Player1 hinzugefügt
                Form1.player1.Deck.Add(player2CurrAnimal);
                // Der Gewinner wird deklariert
                winner = 1;

            }
            else if (player1Value < player2Value)
            {
                // Die verlorene Karte wird aus dem Stapel von Player1 entfernt
                Form1.player1.Deck.Remove(player1CurrAnimal);
                // Die verlorene Karte wird dem Stapel von Player2 hinzugefügt
                Form1.player2.Deck.Add(player1CurrAnimal);
                // Der Gewinner wird deklariert
                winner = 2;
            }
            else if (player1Value == player2Value)
            {
                // Die Karten haben ein Unentschieden
                winner = 0;
            }

            return winner;

        }

    }
}
  