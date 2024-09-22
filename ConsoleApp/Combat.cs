

namespace Classes
{
    public struct Interval
    {
        private float _minCombatValue;
        private float _maxCombatValue;

        public float GetCombatValue
        {
            get
            {
                return GetRandomValue(_minCombatValue, _maxCombatValue);
            }
        }
        public float MinCombatValue
        {
            get
            {
                return _minCombatValue;
            }
        }
        public float MaxCombatValue
        {
            get
            {
                return _maxCombatValue;
            }
        }
        public float AverageCombatValue
        {
            get
            {
                //Console.WriteLine("MinCombatValue-{0} MaxCombatValue-{1}", MinCombatValue, MaxCombatValue);
                return (MinCombatValue + MaxCombatValue) / 2;
            }
        }
        public Interval(int minIntValue, int maxIntValue) : this((float)minIntValue, (float)maxIntValue)
        {
            _minCombatValue = minIntValue;
            _maxCombatValue = maxIntValue;
            if (minIntValue > maxIntValue) 
            { 
                minIntValue = maxIntValue; 
            }
        }
        public Interval(float minFloatValue, float maxFloatValue)
        {
            _minCombatValue = minFloatValue;
            _maxCombatValue = maxFloatValue;
            if (minFloatValue > maxFloatValue) 
            { 
                minFloatValue = maxFloatValue; 
            }
        }
        public Interval(float value) : this((float)value, (float)value)
        {

        }
        private float GetRandomValue(float minValue, float maxValue)
        {
            Random rnd = new Random();
            var randomValue = rnd.NextDouble();
            return (float)rnd.NextDouble() * (maxValue - minValue) + minValue;

        }
    }
    struct Rate
    {
        public Unit _unitCombat;
        public float _damageCombat;
        public float _healthCombat;
        public Rate(Unit _unitFighter, float _damageFighter, float _healthFighter)
        {
            _unitCombat = _unitFighter;
            _damageCombat = _damageFighter;
            _healthCombat = _healthFighter;
        }
    }
    public class Combat
    {
        private List<Rate> Rate = new List<Rate> ();

        public Combat()
        {
            
            //List<Rate> Rate;
        }
        public void StartCombat(Unit playerOne, Unit playerTwo)
        {
            while (playerOne.Health > 0 || playerTwo.Health > 0)
            {
                Random rnd = new Random();
                var rndValue = rnd.Next(1, 10);
                if (rndValue % 2 == 0)
                {   
                    playerOne.SetDamage (playerTwo.Damage);
                    Rate.Add(new Rate(playerTwo, playerTwo.Damage, playerTwo.Health));
                }
                else
                {
                    playerTwo.SetDamage(playerOne.Damage);
                    Rate.Add(new Rate(playerOne, playerOne.Damage, playerOne.Health));
                }
            }
            return;
        }
        public void ShowResult()
        {
            for (int i = 0; i < Rate.Count; i++)
            {
                Console.WriteLine("Боец {0} нанёс урон {1} и оставил {2} здоровья", Rate[i]._unitCombat.Name, Rate[i]._unitCombat.Damage, Rate[i]._unitCombat.Health);
            }
        }

    }


}
