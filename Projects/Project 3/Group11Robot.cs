using System;
using static System.Collections.Specialized.BitVector32;

namespace RobotCaveFightTestArena
{
    public class Group11Robot : IRobot
    {
        private string name;
        private string[] studentNames;
        private double attack;
        private double defense;
        private double speed;
        private double constitution;
        private double health;
        private string primaryColor;
        private string secondaryColor;

        public double GetHealth()
        {
            return this.health;
        }

        public double GetMaxHealth()
        {
            return this.constitution * 10;
        }

        public string GetPrimaryColor()
        {
            return this.primaryColor;
        }

        public string GetRobotName()
        {
            return this.name;
        }

        public string GetSecondaryColor()
        {
            return this.secondaryColor;
        }
        public double GetAttack()
        {
            return this.attack;
        }

        public double GetDefense()
        {
            return this.defense;
        }
        public double GetSpeed()
        {
            return this.speed;
        }

        public string GetStats()
        {
            return $"Current Health: {this.GetHealth()}, Attack: {this.attack}, Defense: {this.defense}, Speed: {this.speed}";
        }

        public string[] GetStudentNames()
        {
            return this.studentNames;
        }

        public ActionResult PerformAction(IRobot opponent)
        {
            ActionResult action = new ActionResult("", "");

            Random random = new Random();

            int actionChoice = random.Next(1, 4);

            
            if (this.attack > 500 && actionChoice == 2)
            {
                actionChoice = 1;
            }

            switch (actionChoice)
            {
                case 1:
                    action = Attack(opponent);
                    break;
                case 2:
                    action = SuperBuff();
                    break;
                case 3:
                    action = SuperArmor();
                    break;
            }

            return action;
        }

        public void Reset()
        {
            this.attack = 12.0;
            this.defense = 13.0;
            this.speed = 5.0;
            this.constitution = 10.0;
            this.health = constitution * 10.0;
        }

        public void TakeDamage(double damage)
        {
            damage -= (this.defense / 100 * damage);

            this.health -= damage;
        }

        public ActionResult SuperBuff()
        {
            double buffPoints = 1000;

            this.speed -= buffPoints;
            this.defense += 90;
            this.attack += 910;

            return new ActionResult("Super Buff", "Power Up");
        }

        public ActionResult SuperArmor()
        {
            this.speed -= 100;
            this.defense += 100;

            return new ActionResult("Super Armor", "Power Up");
        }

        public ActionResult Attack(IRobot opponent)
        {
            opponent.TakeDamage(this.attack);

            return new ActionResult("Attack", "Punch");
        }

        public Group11Robot()
        {
            this.studentNames = new[] { "Adam Hooven", "Amalachukwu Emodi", "Larry Deskins" };
            this.name = "Optimus Prime";
            this.attack = 10.0;
            this.defense = 10.0;
            this.speed = 10.0;
            this.constitution = 10.0;
            this.health = this.constitution * 10.0;
            this.primaryColor = "#E81E27";
            this.secondaryColor = "#44BBFF";
        }
    }
}
