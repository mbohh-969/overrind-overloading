using System;

namespace GameOverridedemo
{
    public class PhysicalSkill : Skill
    {
        private float critRate;
        public PhysicalSkill()
        {
            critRate = 0.1f;
            Console.WriteLine("---> Konstruktor default physical skill <---");
        }
        public PhysicalSkill(float critRate, string name, float power, float cost): base(name, power, cost)
        {
            Console.WriteLine("---> Konstruktor berparameter physical skill <---");
            this.critRate = critRate;
        }
        public override float CalculateDamage()
        {
            Console.WriteLine("[PhysicalSkill.calculateDamage] Menghitung damage fisik dengan kritikal hit");
            float damage = basePower * (1 + critRate);
            return damage;
        }

        public void DisplaySkillInfo2()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("CRIT RATE    : " + (critRate * 100)+"%");
            Console.WriteLine("======================");
        }
    }
}