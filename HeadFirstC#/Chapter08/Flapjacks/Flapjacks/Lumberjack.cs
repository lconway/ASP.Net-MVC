using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flapjacks
{
    enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana
    }

    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public int FlapjackCount { get { return meal.Count; } }

        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
                meal.Push(food);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine(Name + "'s eating flapjacks");
            for (int i = 0; i < meal.Count; i++)
                Console.WriteLine(Name + " ate a " + meal.Pop() + " flapjack");
        }
    }
}
