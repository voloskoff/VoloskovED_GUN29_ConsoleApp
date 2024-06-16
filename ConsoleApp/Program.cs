using ConsoleApp;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подготовка к бою");
            Console.WriteLine("Введите имя бойца1");
            
            var nameFirstFighter = Console.ReadLine();
            Console.WriteLine("Имя бойца1 - {0}", nameFirstFighter);
            
            Console.WriteLine("Введите начальное здоровье бойца1 (10-100)");
            if (!float.TryParse(Console.ReadLine(), out float healthFighter))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (healthFighter < 10 || healthFighter > 100)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 10-100");
                return;
            }
            Console.WriteLine("Начальное здоровье бойца1 - {0}", healthFighter);

            Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            if (!float.TryParse(Console.ReadLine(), out float minDamageWeaponFighter))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (minDamageWeaponFighter < 0 || minDamageWeaponFighter > 20)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 0-20");
                return;
            }
            Console.WriteLine("Минимальный урон оружия - {0}", minDamageWeaponFighter);

            Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            if (!float.TryParse(Console.ReadLine(), out float maxDamageWeaponFighter))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (maxDamageWeaponFighter < 20 || maxDamageWeaponFighter > 40)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 20-40");
                return;
            }
            Console.WriteLine("Максимальный урон оружия - {0}", maxDamageWeaponFighter);
            Interval intervalFirstFighter = new Interval(minDamageWeaponFighter,maxDamageWeaponFighter);

            Unit unitFirstFighter = new Unit(nameFirstFighter, healthFighter);
            
            Console.WriteLine("Фактическое значение здоровья равно: {0}", unitFirstFighter.RealHealth());



            Console.WriteLine("Введите имя бойца2");

            var nameSecondFighter = Console.ReadLine();
            Console.WriteLine("Имя бойца2 - {0}", nameSecondFighter);

            Console.WriteLine("Введите начальное здоровье бойца2 (10-100)");
            if (!float.TryParse(Console.ReadLine(), out healthFighter))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (healthFighter < 10 || healthFighter > 100)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 10-100");
                return;
            }
            Console.WriteLine("Начальное здоровье бойца2 - {0}", healthFighter);

            Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            if (!float.TryParse(Console.ReadLine(), out minDamageWeaponFighter))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (minDamageWeaponFighter < 0 || minDamageWeaponFighter > 20)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 0-20");
                return;
            }
            Console.WriteLine("Минимальный урон оружия - {0}", minDamageWeaponFighter);

            Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            if (!float.TryParse(Console.ReadLine(), out maxDamageWeaponFighter))
            {
                Console.WriteLine("Введенное число не float");
                return;
            }
            if (maxDamageWeaponFighter < 20 || maxDamageWeaponFighter > 40)
            {
                Console.WriteLine("Введенное число не в диапазоне значений 20-40");
                return;
            }
            Console.WriteLine("Максимальный урон оружия - {0}", maxDamageWeaponFighter);
            Interval intervalSecondFighter = new Interval(minDamageWeaponFighter, maxDamageWeaponFighter);

            Unit unitSecondFighter = new Unit(nameSecondFighter, healthFighter);

            Console.WriteLine("Фактическое значение здоровья равно: {0}", unitSecondFighter.RealHealth());
            
            Console.WriteLine("Начало боя");
            Combat combat = new Combat();
            combat.StartCombat(unitFirstFighter, unitSecondFighter, intervalFirstFighter.GetCombatValue, intervalSecondFighter.GetCombatValue);
            combat.ShowResult();


        }
    }
}