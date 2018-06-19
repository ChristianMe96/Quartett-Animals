using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierQuartett
{
    public class Animal
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        // speed in km/h 
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
        }

        // weight in kg
        private int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
        }
        // age in years
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
        }
        // bodysize in meter
        private double bodysize;
        public double BodySize
        {
            get
            {
                return bodysize;
            }
        }

        // image path
        private string image;
        public string Image
        {
            get
            {
                return image;
            }
        }

        public Animal()
        {

        }


        public Animal(string name, int speed, int weight, int age, double bodysize, string image)
        {
            this.name = name;
            this.speed = speed;
            this.weight = weight;
            this.age = age;
            this.bodysize = bodysize;
            this.image = image;
        }
    }
}
