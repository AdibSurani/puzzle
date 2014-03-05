using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    static partial class Utility
    {
        public static readonly IEnumerable<int> Primes = new PrimesImpl();

        class PrimesImpl : IEnumerable<int>
        {
            List<int> primes = new List<int> { 2 };

            public IEnumerator<int> GetEnumerator()
            {
                foreach (var p in primes)
                {
                    yield return p;
                }
                for (int n = primes.Last() + 1; n <= int.MaxValue; n++)
                {
                    if (primes.TakeWhile(p => p * p <= n).All(p => n % p != 0))
                    {
                        primes.Add(n);
                        yield return n;
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
