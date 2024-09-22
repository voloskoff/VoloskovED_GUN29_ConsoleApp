
namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Unit playerOne = new Unit("First Player", 20f);
            Unit playerTwo = new Unit("Second Player", 30f);
           
            Helm helmPlayerOne = new Helm("");
            Helm helmPlayerTwo = new Helm("");
            Shell shellPlayerOne = new Shell("");
            Shell shellPlayerTwo = new Shell("");
            Boots bootsPlayerOne = new Boots("");
            Boots bootsPlayerTwo = new Boots("");

            helmPlayerOne.ArmorHelm = 0.3f;
            helmPlayerTwo.ArmorHelm = 0.5f;
            shellPlayerOne.ArmorShell = 0.1f;
            shellPlayerTwo.ArmorShell = 0.6f;
            bootsPlayerOne.ArmorBoots = 0.2f;
            bootsPlayerTwo.ArmorBoots = 0.3f;

           
            Weapon weaponPlayerOne = new Weapon("", 13f, 24f);
            Weapon weaponPlayerTwo = new Weapon("", 13f, 24f);
            playerOne.EquipWeapon(weaponPlayerOne);
            playerTwo.EquipWeapon(weaponPlayerTwo);
            playerOne.EquipHelm(helmPlayerOne);
            playerTwo.EquipHelm(helmPlayerTwo);
            playerOne.EquipShell(shellPlayerOne);
            playerTwo.EquipShell(shellPlayerTwo);
            playerOne.EquipBoots(bootsPlayerOne);
            playerTwo.EquipBoots(bootsPlayerTwo);

            //Console.WriteLine("Первый игрок: {0} - здоровья, ", playerOne.RealHealth());

            Console.WriteLine("Первый игрок: {0} - здоровья, {1} - урон", playerOne.RealHealth(), playerOne.Damage);
            Console.WriteLine("Второй игрок: {0} - здоровья, {1} - урон", playerTwo.RealHealth(), playerTwo.Damage);


            Combat combat = new Combat();
            Console.WriteLine("Начало боя");
            combat.StartCombat(playerOne, playerTwo);
            Console.WriteLine("Конец");
            combat.ShowResult();






















            //Console.WriteLine("Подготовка к бою");

            //Console.WriteLine("Введите имя бойца1");
            //var nameFirstFighter = Console.ReadLine();

            //Console.WriteLine("Имя бойца1 - {0}", nameFirstFighter);

            //Console.WriteLine("Введите начальное здоровье бойца1 (10-100)");
            //if (!float.TryParse(Console.ReadLine(), out float healthFighter))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (healthFighter < 10 || healthFighter > 100)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 10-100");
            //    return;
            //}
            //Console.WriteLine("Начальное здоровье бойца1 - {0}", healthFighter);

            //Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            //if (!float.TryParse(Console.ReadLine(), out float minDamageWeaponFighter))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (minDamageWeaponFighter < 0 || minDamageWeaponFighter > 20)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 0-20");
            //    return;
            //}
            //Console.WriteLine("Минимальный урон оружия - {0}", minDamageWeaponFighter);

            //Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            //if (!float.TryParse(Console.ReadLine(), out float maxDamageWeaponFighter))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (maxDamageWeaponFighter < 20 || maxDamageWeaponFighter > 40)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 20-40");
            //    return;
            //}
            //Console.WriteLine("Максимальный урон оружия - {0}", maxDamageWeaponFighter);
            //Interval intervalFirstFighter = new Interval(minDamageWeaponFighter,maxDamageWeaponFighter);

            //Unit unitFirstFighter = new Unit(nameFirstFighter, healthFighter);

            //Console.WriteLine("Фактическое значение здоровья равно: {0}", unitFirstFighter.RealHealth());



            //Console.WriteLine("Введите имя бойца2");

            //var nameSecondFighter = Console.ReadLine();
            //Console.WriteLine("Имя бойца2 - {0}", nameSecondFighter);

            //Console.WriteLine("Введите начальное здоровье бойца2 (10-100)");
            //if (!float.TryParse(Console.ReadLine(), out healthFighter))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (healthFighter < 10 || healthFighter > 100)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 10-100");
            //    return;
            //}
            //Console.WriteLine("Начальное здоровье бойца2 - {0}", healthFighter);

            //Console.WriteLine("Укажите минимальный урон оружия (0-20)");
            //if (!float.TryParse(Console.ReadLine(), out minDamageWeaponFighter))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (minDamageWeaponFighter < 0 || minDamageWeaponFighter > 20)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 0-20");
            //    return;
            //}
            //Console.WriteLine("Минимальный урон оружия - {0}", minDamageWeaponFighter);

            //Console.WriteLine("Укажите максимальный урон оружия (20-40)");
            //if (!float.TryParse(Console.ReadLine(), out maxDamageWeaponFighter))
            //{
            //    Console.WriteLine("Введенное число не float");
            //    return;
            //}
            //if (maxDamageWeaponFighter < 20 || maxDamageWeaponFighter > 40)
            //{
            //    Console.WriteLine("Введенное число не в диапазоне значений 20-40");
            //    return;
            //}
            //Console.WriteLine("Максимальный урон оружия - {0}", maxDamageWeaponFighter);
            //Interval intervalSecondFighter = new Interval(minDamageWeaponFighter, maxDamageWeaponFighter);

            //Unit unitSecondFighter = new Unit(nameSecondFighter, healthFighter);

            //Console.WriteLine("Фактическое значение здоровья равно: {0}", unitSecondFighter.RealHealth());

            //Console.WriteLine("Начало боя");
            //Combat combat = new Combat();
            //combat.StartCombat(unitFirstFighter, unitSecondFighter);
            //combat.ShowResult();


        }
    }
}