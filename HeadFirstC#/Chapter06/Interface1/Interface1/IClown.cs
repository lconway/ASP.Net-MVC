using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();
    }

    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }

        void ScareLittleChildren();
    }

    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        private string funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return "Hi kids!  I have a " + FunnyThingIHave; }
        }

        public void Honk()
        {
            Console.WriteLine("Hi kids!  I have a " + FunnyThingIHave);
        }
    }

    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
            : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get { return "I have " + numberOfScaryThings + " spiders"; }
        }

        public void ScareTheLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha!");
        }
    }
}
