using System;

namespace CSharp.Samples.Utilities
{

    public class CurrencyGenerator
    {
        #region Variables
        static readonly Random RandomObject = new Random();
        private readonly double _minimumValue;
        private readonly double _deltaValue;
        #endregion

        public CurrencyGenerator(double minimumValue = 1.0f, double deltaValue = 1000.0f)
        {
            _minimumValue = minimumValue;
            _deltaValue = deltaValue;
        }

        #region Methods
        public decimal GenerateAmount()
        {
            var randomNumber = RandomObject.NextDouble();
            return (decimal) (_minimumValue + (randomNumber * _deltaValue));
        }
        #endregion
    }

}
