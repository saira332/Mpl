using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPatterns
{

   public interface RobotPlan
    {
         void setRobotHead(string head);
        void setRobotTorso(string torso);
        void setRobotArms(string arms);
        void setRobotLegs(string legs);
    }
   public  class Robot : RobotPlan
    {
        private string robotHead;
        private string robotTorso;
        private string robotArms;
        private string robotLegs;


       
        public void setRobotHead(string head)
        {
            robotHead = head;
        }
        public string getRobotHead()
        {
            return robotHead;
        }
        public void setRobotTorso(string torso)
        {
            robotTorso = torso;
        }
        public string getRobotTorso()
        {
            return robotTorso;
        }
        public void setRobotArms(string arms)
        {
            robotArms = arms;
        }
        public string getRobotArms()
        {
            return robotArms;
        }
        public void setRobotLegs(string legs)
        {
            robotLegs = legs;
        }
        public string getRobotLegs()
        {
            return robotLegs;
        }


    }
    class builder
    {

    }



    public interface RobotBuilder
    {
        void buildRobotHead();
        void buildRobotTorso();
        void buildRobotArms();
        void buildRobotLegs();
        Robot getRobot();
    }

    class OldRobotBuilder : RobotBuilder
    {
        private Robot robot;

        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }
        public void buildRobotHead()
        {
            robot.setRobotHead("Tin head");
        }
        public void buildRobotTorso()
        {
            robot.setRobotTorso("Tin Torso");
        }
        public void buildRobotArms()
        {
            robot.setRobotArms("Tin Arms");
        }
        public void buildRobotLegs()
        {
            robot.setRobotLegs("Tin Legs");
        }
        public Robot getRobot()
        {
            return this.robot;
        } 
    }

     public class RobotEngineer
        {
            private RobotBuilder robotBuilder;

            public RobotEngineer(RobotBuilder robotBuilder)
            {
                this.robotBuilder = robotBuilder;
            }

            public Robot getRobot()
            {
                return this.robotBuilder.getRobot();
            }

            public void makeRobot()
            {
                this.robotBuilder.buildRobotHead();
                this.robotBuilder.buildRobotTorso();
                this.robotBuilder.buildRobotArms();
                this.robotBuilder.buildRobotLegs();
            }
        }


}
