using System;
using System.Linq;

namespace JsonFruit
{
    public class Fruit
    {
        public string typeOfFruit { get; set; }

        public Fruit()
        {
        }

        public Fruit(string typeOfFruit)
        {
            this.typeOfFruit = typeOfFruit;
        }
    }
}
