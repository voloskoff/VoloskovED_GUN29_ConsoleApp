namespace Classes
{
    public class Helm
    {
        private float _armorHelm;
        public string Name { get; } = "Helm";
        public float ArmorHelm
        {
            get
            {
                return _armorHelm;
            }
            set
            {
                _armorHelm = value;
                if (value < 0) { _armorHelm = 0; }
                if (value > 1) { _armorHelm = 1f; }
            }
        }
        public Helm(string helmName)
        {
            Name = helmName;
        }
    }
    public class Shell
    {
        private float _armorShell;
        public string Name { get; } = "Shell";
        public float ArmorShell
        {
            get
            {
                return _armorShell;
            }
            set
            {
                _armorShell = value;
                if (value < 0) { _armorShell = 0; }
                if (value > 1) { _armorShell = 1f; }
            }
        }
        public Shell(string shellName)
        {
            Name = shellName;
        }
    }
    public class Boots
    {
        private float _armorBoots;
        public string Name { get; } = "Boots";
        public float ArmorBoots
        {
            get
            {
                return _armorBoots;
            }
            set
            {
                _armorBoots = value;
                if (value < 0) { _armorBoots = 0; }
                if (value > 1) { _armorBoots = 1f; }
            }
        }
        public Boots(string bootsName)
        {
            Name = bootsName;
        }
    }
}

