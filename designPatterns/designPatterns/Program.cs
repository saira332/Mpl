using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            singlon s1 = singlon.setObj();
            s1.Message("this is s1");
            singlon s2 = singlon.setObj();
            s1.Message("this is s2");
            singlon s3 = singlon.setObj();
            s1.Message("this is s3");
            singlon s4 = singlon.setObj();
            s1.Message("this is s4");
            Console.WriteLine("no of objects = {0}", singlon.objCount);
            Console.ReadKey();

            //Decorator

            //CarDecoration c = new CarDecoration();
            //c.EngineType();
            //c = new PetrolEngine();
            //c.EngineType();
            //c = new DieselENgine();
            //c.EngineType();


            //Observer
            INotify e1 = new EventNotification("event abc");
            INotify s1 = new SpecialOffer("special offer");

            subject s = new subject();
            s.Register(e1);
            s.Register(s1);
            s.annouce();

            //Builder

            //OldRobotBuilder oldStyleRobot = new OldRobotBuilder();

            //RobotEngineer robootEngineer = new RobotEngineer(oldStyleRobot);

            //robootEngineer.makeRobot();
            //Robot firstRobot = robootEngineer.getRobot();
            //Console.WriteLine("robot head  : {0} ", firstRobot.getRobotHead());
            //Console.WriteLine("robot body  : {0} ", firstRobot.getRobotTorso());
            //Console.WriteLine("robot Arms  : {0} ", firstRobot.getRobotArms());
            //Console.WriteLine("robot Legs  : {0} ", firstRobot.getRobotLegs());

            //Adopter
            //EnemyTank tank = new EnemyTank();
            //EnemyRobot robot = new EnemyRobot();
            //IEnemyAttacker robotAdopter = new EnemyRobotAdapter(robot);

            //Console.WriteLine("the robot");
            //robot.smashWithHands();
            //robot.moveForward();
            //robot.reachToHuman("john");

            //structure
            //Animal tomy = new Dog();
            //Animal sparrow = new Bird();
            //Console.WriteLine("Dog : {0}", tomy.tryToFly());
            //Console.WriteLine("Bird : {0}", sparrow.tryToFly());

            //tomy.setFlyingAbility(new ItFlys());


            //Console.WriteLine("Dog : {0}", tomy.tryToFly());




            Console.ReadKey();
        }
    }
}
