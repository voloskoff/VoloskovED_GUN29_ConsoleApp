using Classes;

namespace ConsoleApp
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
                return (_minCombatValue + _minCombatValue) / 2;
            }
        }
        public Interval(int minIntValue, int maxIntValue) : this((float)minIntValue, (float)maxIntValue)
        {

        }
        public Interval(float minFloatValue, float maxFloatValue)
        {
            _minCombatValue = minFloatValue;
            _maxCombatValue = maxFloatValue;
        }
        public Interval(float value) : this(value, value)
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
        private List<Rate> ratesCombat;
        //private int _indexRateCombat= 0;
        public Combat()
        {
            //ratesCombat = new Rate[_indexRateCombat];
            List<Rate> ratesCombat = new List<Rate>();

        }
        public void StartCombat(Unit fighterFirst, Unit fighterSecond, float damageFirstFighter, float damageSecondFighter)
        {
            while (fighterFirst.Health > 0 || fighterSecond.Health > 0)
            {
                Random rnd = new Random();
                var rndValue = rnd.Next(1, 10);
                if (rndValue % 2 == 0)
                {
                    Console.WriteLine("tyt1");
                    fighterFirst.SetDamage(damageFirstFighter);
                    //ratesCombat.Add(new Rate(fighterFirst, damageFirstFighter, fighterFirst.Health));


                }
                else
                {
                    Console.WriteLine("tyt2");
                    fighterSecond.SetDamage(damageSecondFighter);
                    //ratesCombat.Add(new Rate(fighterSecond, damageSecondFighter, fighterSecond.Health));
                }
            }
            return;
        }
        public void ShowResult()
        {
            for (int i = 0; i < ratesCombat.Count; i++)
            {
                Console.WriteLine("Боец {0} нанёс урон {1} и оставил {2} здоровья", ratesCombat[i]._unitCombat.Name,
                    ratesCombat[i]._unitCombat.Damage, ratesCombat[i]._unitCombat.Health);
            }

        }

    }
}
