namespace Classes
{
    public class Unit
    {
        private float _health = 0;
        private float _baseDamage = 5f;
        private Helm _armorHelm;
        private Shell _armorShell;
        private Boots _armorBoots;
        private Weapon _weapon;

        public string Name { get; } 
        public float Health { get { return _health; } }
        public float Damage
        {
            get 
            {
                Weapon weapon = new Weapon("FighterWeapon");
                return weapon.Damage + _baseDamage; 
            }
        } 

        public float Armor
        {
            get 
            {
                var armor = _armorHelm.ArmorHelm + _armorShell.ArmorShell + _armorBoots.ArmorBoots; ;
                if (armor < 0) armor = 0;
                if (armor >= 1) armor = 1;
                return armor;
                //return _armorHelm.ArmorHelm + _armorShell.ArmorShell + _armorBoots.ArmorBoots;
            }
        }

        public Unit() : this("Unknown Unit")
        {

        }
        public Unit(string unitName)
        {
            Name = unitName;
        }
        public Unit(string unitName, float unitHealth)
        {
            Name = unitName;
            _health = unitHealth;
        }

        public float RealHealth()
        {
            _health = Health * (1f /*+ Armor*/);
           // Console.WriteLine("Здоровье Юнита щас {0}",_health);
            return _health;
        }
        public void SetDamage(float damage)
        {

            _health = _health - damage /** Armor*/;
            if (_health <= 0f)
            {
                Console.WriteLine("Здоровье Юнита меньше 0");
                //return true;
            }
            else
            {
                //return false;
            }
        }
        public void EquipWeapon(Weapon weapon)
        {
            _weapon = weapon;
        }
        public void EquipHelm(Helm helm)
        {
            _armorHelm = helm;
        }
        public void EquipShell(Shell shell)
        {
            _armorShell = shell;
        }
        public void EquipBoots(Boots boots)
        {
            _armorBoots = boots;
        }
       
    }
}
