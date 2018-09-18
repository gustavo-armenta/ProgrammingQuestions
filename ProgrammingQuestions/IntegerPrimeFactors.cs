using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgrammingQuestions
{
    public class IntegerPrimeFactors
    {
        // Given integer X, find if P^Q=X
        public List<int> FindPrimeFactors(int value)
        {
            var integerPrimes = new IntegerPrimes();
            var primes = integerPrimes.FindPrimes(value);
            var factors = new Dictionary<int, int>();
            var current = value;

            for (int i = 0; i < primes.Count; i++)
            {
                while (current % primes[i] == 0)
                {                    
                    if(!factors.ContainsKey(primes[i]))
                    {
                        factors[primes[i]] = 0;
                    }

                    factors[primes[i]]++;
                    current = current / primes[i];
                }
            }

            int P = 1;
            int Q = 0;
            foreach(var factor in factors)
            {
                P = P * factor.Key;
                if (Q == 0)
                {
                    Q = factor.Value;
                }
                else if (Q != factor.Value)
                {
                    return new List<int>();
                }
            }

            return new List<int> { P, Q };
        }
    }
}
