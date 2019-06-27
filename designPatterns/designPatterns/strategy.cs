using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns
{
    public class Animal
    {
        private string name;
        private string sound;
        public Flys flyingType;
        public void setName(string newName)
        {
            name = newName;
        }
        public string getName()
        {
            return name;
        }
        public void setSound(string newSound)
        {
            sound = newSound;
        }
        public string getSound()
        {
            return sound;
        }

        public string tryToFly()
        {
            return flyingType.fly();
        }

        public void setFlyingAbility(Flys newFlyType)
        {
            flyingType = newFlyType;
        }
    }
    public interface Flys
    {
        string fly();
    }
    class ItFlys : Flys
    {
        public string fly()
        {
            return "can fly";
        }
    }
    class CantFlys : Flys
    {
        public string fly()
        {
            return "I can't fly";
        }
    }
    public class Dog : Animal
    {
        public Dog()
        {
            setSound("Bark");
            flyingType = new CantFlys();
        }
        public void digHole()
        {
            Console.WriteLine("Dug a hole");
        }

    }
    public class  Bird : Animal
    {
        public Bird()
        {
            setSound("Tweet");
            flyingType = new ItFlys();
        }
        public void buildNust()
        {
            Console.WriteLine("build a nust");
        }

    }

    class strategy
    {
    }
}
