using System;
using System.Security.Cryptography.X509Certificates;
namespace GameOverridedemo
{
    public class Skill
    {
        protected string skillName;
        protected float basePower;
        protected float manaCost;

        public Skill()
        {
            skillName ="Basic skill";
            basePower = 10f;
            manaCost = 5f;
            Console.WriteLine("---> Konstruktor default skill <---");
        }

        public Skill(string name, float power, float cost)
        {
            Console.WriteLine("--> konstruktor berparameter skill <---");
            skillName = name;
            basePower = power;
            manaCost = cost;
        }

        public virtual float CalculateDamage()
        {
            Console.WriteLine("[Skill.CalculateDamage] menghutung damage dasar...");
            return basePower;
        }

        public void DisplaySkillInfo()
        {
            Console.WriteLine("SKILL NAME   : " + skillName);
            Console.WriteLine("BASE POWER   : " + basePower);
            Console.WriteLine("MANA COST    : " + manaCost);
        }
        
    }
}