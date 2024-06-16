namespace Classes
{
    public class Weapon
    {
        
        public string Name { get; } = "No Weapon";

        public float MinDamage { get; private set; } = 0f;
        public float MaxDamage { get; private set; } = 0f;
        public float Damage { get {  return GetDamage(); } }

        
        public Weapon(string nameWeapon)
        {
            Name = nameWeapon;
        }
        public Weapon(string nameWeapon, float minDamage, float maxDamage) : this(nameWeapon) 
        { 
            SetDamageParams(minDamage, maxDamage);
            
        }
        public void SetDamageParams(float minDamageParam, float maxDamageParam)
        {
            MinDamage = minDamageParam;
            MaxDamage = maxDamageParam;
            //проверка допустимых входных значений
            if (MinDamage > MaxDamage)
            {
                MinDamage = MinDamage + MaxDamage;
                MaxDamage = MinDamage - MaxDamage;
                MinDamage = MinDamage - MaxDamage;
                Console.WriteLine("У {0} minDamage больше maxDamage - числа меняются местами", Name);
                //дописать в консоль название оружия
            }
            if (minDamageParam < 1f)
            {
                MinDamage = 1f;
                Console.WriteLine("У {0} minDamage равен меньше 1 - minDamage принудительно присвоено занчение 1", Name);
            }
            if (maxDamageParam <= 1f)
            {
                MaxDamage = 10f;
                Console.WriteLine("У {0} maxDamage равен меньше 1 - maxDamage принудительно присвоено занчение 10", Name);
            }

        }
        public float GetDamage()
        {
            Console.WriteLine("Средний урон оружия будет равен {0} попугаев", (MinDamage + MaxDamage) / 2);
            return (MinDamage + MaxDamage) / 2;
        }

    }
}
