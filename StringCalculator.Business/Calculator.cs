using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Business
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
                return 0;

            var delimiter = GetDelimiter(numbers);

            var listOfIntegerNumbers = GetListOfNumberFromString(numbers, delimiter);

            ThrowAnExceptionWhenNumbersAreNegative(listOfIntegerNumbers);

            return listOfIntegerNumbers.Sum();
        }

        #region Private Methods

        /// <summary>
        /// Returns the Delimiter contained in the numbers string
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private string GetDelimiter(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                return numbers.Substring(2, 1);
            }

            return ",";
        }

        /// <summary>
        /// Splits String into an integer list based on the seperator
        /// New Line and // are split by default 
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="seperator"></param>
        /// <returns></returns>
        private List<int> GetListOfNumberFromString(string numbers, string delimiter)
        {
            var delimitorArray = new string[] { delimiter, "\n", "//" };
            var stringOfNumbers = numbers.Split(delimitorArray, StringSplitOptions.RemoveEmptyEntries);

            return stringOfNumbers.Select(num => int.Parse(num)).ToList();
        }

        /// <summary>
        /// Throw Exception indicating which number is negative. Multiple negatives are seperated with a comma
        /// </summary>
        /// <param name="listOfIntegerNumbers"></param>
        private void ThrowAnExceptionWhenNumbersAreNegative(List<int> listOfIntegerNumbers)
        {
            var listOfNegativeNumbers = listOfIntegerNumbers.Where(number => number < 0);

            if (listOfNegativeNumbers.Any())
            {
                throw new ArgumentException("negatives not allowed " + string.Join(",", listOfNegativeNumbers));
            }
        }

        #endregion
    }
}
