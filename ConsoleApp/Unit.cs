using System;

namespace Classes
{
    public class Unit
    {
        private float _health = 0;
        private float _baseDamage = 5f;
        private float _damage;
        private Helm _armorHelm = new Helm("");
        private Shell _armorShell = new Shell("");
        private Boots _armorBoots = new Boots ("");
        private Weapon _weapon = new Weapon("");

        public string Name { get; set; } 
        public float Health { get { return _health; } set { _health = value; } }
        public float Damage
        {
            get
            {
                _damage = _weapon.Damage + _baseDamage;
                //Console.WriteLine("_damage = {0}", _weapon.Damage);
                return _damage;
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
                
            }
        }

        public Unit() : this("Unknown Unit", 10)
        {

        }
        
        public Unit(string unitName, float unitHealth)
        {
            this.Name = unitName;
            _health = unitHealth;
        }

        public float RealHealth()
        {
            _health = Health * (1f + Armor);
            return _health;
        }
        public bool SetDamage(float damage)
        {

            _health = _health - damage * Armor;
            if (_health <= 0f)
            {
                //Console.WriteLine("Здоровье Юнита меньше 0");
                return true;
            }
            else
            {
                return false;
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
