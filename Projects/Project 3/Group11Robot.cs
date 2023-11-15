using System;
namespace RobotCaveFightTestArena
{
    public class Group11Robot : IRobot
    {
        private string name;
        private string[] studentNames = { "Adam Hooven", "Larry Deskins", "Amalachukwu Emodi", "Madison Hotchkiss" };
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
            throw new NotImplementedException();
        }

        public void TakeDamage(double damage)
        {
            throw new NotImplementedException();
        }
    }
}

