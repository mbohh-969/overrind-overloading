using System;
using System.Linq.Expressions;

namespace GameOverridedemo
{
    public class MagicSkill : Skill
    {
        private string elementType;

        public MagicSkill()
        {
            elementType = "Normal";
            Console.WriteLine("---> konstruktor default magicSkill <---");
        }

        public MagicSkill(string elementType, string name, float power, float cost) : base(name, power, cost)
        {
            Console.WriteLine("---> konstruktor berparameter magicskill <---");
            this.elementType = elementType;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[MagicSkill.CaculateDamage] Menghitung damage sihir dengan elemen...");
            float damage = basePower;
            if (elementType == "fire")
            {
                damage *= 1.5f;
                Console.WriteLine("[MagicSkill] Bonus elemen fire! damage x1.5");
            }
            else if (elementType == "ice")
            {
                damage *= 1.2f;
                Console.WriteLine("[MagicSkill] Bonus elemen ice! Damager x1.2");
            }
            return damage;
        }

        public void DisplaySkillInfo1()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("ELEMEN TYPE  : " + elementType);
            Console.WriteLine("======================");
        }
    }
}