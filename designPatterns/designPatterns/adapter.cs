using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns
{
    public interface IEnemyAttacker
    {
        void fireWeapon();
        void driveForward();
        void assignDriver(string deriverName);
    }

    class EnemyTank : IEnemyAttacker
    {
     
 
        public void assignDriver(string deriverName)
        {
            Console.WriteLine("driver {0} is driving the tank" , deriverName);
        }

        public void driveForward()
        {
            Console.WriteLine("Enemy tank move");
        }

        public void fireWeapon()
        {
            Console.WriteLine("enemy tank does damage");
        }
    }

    public class EnemyRobot
    {
        public void smashWithHands()
        {
            Console.WriteLine("Enemy Robot cause damage with its hands");
        }
        public void moveForward()
        {
            Console.WriteLine("Enemy robot moves forward");
        }
        public void reachToHuman(string driverName)
        {
            Console.WriteLine("Enemy robot got angery on {0}",driverName);
        }
    }

    public class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot theRobot;
        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            theRobot = newRobot;
        }

        public void assignDriver(string deriverName)
        {
            theRobot.reachToHuman(deriverName);
        }

        public void driveForward()
        {
            theRobot.moveForward();
        }

        public void fireWeapon()
        {
            theRobot.smashWithHands();
        }
    }

    class adapter
    {
    }
}
