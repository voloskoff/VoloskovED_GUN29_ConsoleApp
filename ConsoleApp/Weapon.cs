
namespace Classes
{
    public class Weapon
    {
        private float _minDamage;
        private float _maxDamage;
        private Interval _interval;

        public string Name { get; } = "No Weapon";
        
        public float MinDamage 
        { 
            get { return _minDamage; } 
            private set 
            {
                if (value < 1f)
                {
                    _minDamage = 1f;
                    return;
                }
                _minDamage = value;
            }
        }
        public float MaxDamage 
        {
            get { return _maxDamage; }
            private set
            {
                if (value <= 1f)
                {
                    _maxDamage = 10f;
                    return;
                }
                _maxDamage = value;
            }
        } 
        public float Damage { get {  return _interval.AverageCombatValue; } }

        
        public Weapon(string nameWeapon)
        {
            Name = nameWeapon;
        }
        public Weapon(string nameWeapon, float minDamage, float maxDamage) : this(nameWeapon) 
        {
            this.Name = nameWeapon;
            MinDamage = _minDamage;
            MaxDamage = _maxDamage;
            if (_minDamage > _maxDamage)
            {
                MinDamage = MaxDamage;
            }
            Interval SetDamage = new Interval(minDamage, maxDamage);            

        }
        
        public float GetDamage()
        {
           // Console.WriteLine("Средний урон оружия будет равен {0} попугаев", _interval.AverageCombatValue);
            return _interval.AverageCombatValue;
        }

    }
}
