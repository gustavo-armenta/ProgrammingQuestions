using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgrammingQuestions
{
    public class IntegerPrimes
    {
        // Given integer X, find all prime numbers on the range 0-X
        public List<int> FindPrimes(int value)
        {
            var primes = new List<int>();            

            for (int i = 2; i <= value; i++)
            {
                bool isPrime = true;
                for (int j = 0; j < primes.Count; j++)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
