using System;
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
        private ActionResult myAction;


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
            throw new NotImplementedException();
        }

        public void Reset()
        {
            this.defense = 10.0;
            this.speed = 10.0;
            this.constitution = 10.0;
            this.health = this.constitution * 10.0;
        }

        public void TakeDamage(double damage)
        {
            throw new NotImplementedException();
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

