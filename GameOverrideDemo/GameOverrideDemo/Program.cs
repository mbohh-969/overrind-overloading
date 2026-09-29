using System;

namespace GameOverridedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO OVERRIDEING (GAME SKILLS) ===\n");
            //1
            Console.WriteLine("1. Membuat PhysicalSkill");
            PhysicalSkill slash = new PhysicalSkill(0.3f, "slash", 50f, 15f);
            slash.DisplaySkillInfo2();
            float slashDamage = slash.CalculateDamage();
            Console.WriteLine("Damage yang dihasilkan: " + slashDamage + "\n");
            //2
            Console.WriteLine("2. Membuat MagicSkill");
            MagicSkill fireball = new MagicSkill("Fire", "Fireball", 40f, 25f);
            fireball.DisplaySkillInfo1();
            float fireDamage = fireball.CalculateDamage();
            Console.WriteLine("Damage yang dihasilkan: " + fireDamage + "\n");
            //3
            Console.WriteLine("3. Membuat HealSkill");
            HealSkill heal = new HealSkill(30f, "Heal", 50f, 20f);
            heal.DisplaySkillInfo3();
            float healAmount = heal.CalculateDamage();
            Console.WriteLine("Healing yang dihasilkan: " + healAmount + "\n");

        }
    }
}