using System;

namespace GameOverridedemo
{
    public class HealSkill : Skill
    {
        private float bonusHeal;

        public HealSkill()
        {
            bonusHeal = 20f;
            Console.WriteLine("---> konstruktor default HealSkill <---");

        }

        public HealSkill(float bonusHeal, string name, float power, float cost) : base(name, power, cost)
        {
            Console.WriteLine("---> konstruktor berparameter Healskill <---");
            this.bonusHeal = bonusHeal;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[HealSkill.CalculateDamage] Menghitung nilai healing...");
            float healAmount = basePower + bonusHeal;
            return healAmount;
        }

        public void DisplaySkillInfo3()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("BONUS HEAL  : " + bonusHeal);
            Console.WriteLine("======================");
        }
    }
}