using Monbsoft.SimpleMC.Application.Domain;
using Monbsoft.SimpleMC.Application.Interfaces;

namespace Monbsoft.SimpleMC.Application.Services
{
    public class CalculationEngine
    {
        private readonly List<IRule> _rules;
        private readonly Random _random;

        public CalculationEngine(List<IRule> rules)
        {
            _rules = rules;
            _random = new Random();
        }

        /// <summary>
        /// Creates calculations by applying the rules.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Calculation> CreateCalculations()
        {
            var calculationList = new List<Calculation>();
            var rule = ChooseRule();

            for (int i = 0; i < 10; i++)
            {
                calculationList.Add(rule.Generate());
            }

            return calculationList;
        }

        /// <summary>
        /// Chooses a rule at random
        /// </summary>
        /// <returns>A calculation rule</returns>
        private IRule ChooseRule()
        {

            if (_rules.Count == 1)
                return _rules.First();

            int index = _random.Next(0, _rules.Count);
            return _rules[index];

        }


    }
}
