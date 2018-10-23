using System;
using System.Collections.Generic;
using System.Numerics;

namespace Demo.Release.Lib
{
    public class Exam
    {
        static readonly BigInteger[] B = new BigInteger[26];
        static readonly int[] Primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

        static BigInteger Combination(int n, int r)
        {
            if (n < r) return 0;
            if (n == r) return 1;
            return B[n] / (B[r] * B[n - r]);
        }

        static void GenerateFactorials()
        {
            B[0] = 1;
            int index = 1;
            for (BigInteger i = 1; i <= 25; i++)
            {
                B[index] = B[index - 1] * i;
                index++;
            }
        }

        static void Generate(int k, int s, ref Dictionary<Int32, List<Int32>> d, ref int till)
        {

            for (int i = 0; i < Primes.Length; i++)
            {
                List<Int32> data = new List<Int32>();
                for (int j = Primes[i]; j <= s; j = j + Primes[i])
                {
                    data.Add(j);
                }
                if (data.Count < k)
                {
                    till = i;
                    break;
                }
                d.Add(Primes[i], data);
            }
        }

        static BigInteger GenerateAnswer(int k, int s, Dictionary<Int32, List<Int32>> d, int till)
        {
            BigInteger answer = 0;

            for (int i = 0; i < till; i++)
            {
                answer = answer + Combination(d[Primes[i]].Count, k);
                for (int j = 0; j < i; j++)
                {
                    int divisibleNumbers = 0;
                    for (int l = 0; l < d[Primes[i]].Count; l++)
                    {
                        int temp = d[Primes[i]][l];
                        if (temp % Primes[j] == 0)
                        {
                            divisibleNumbers++;
                        }
                    }
                    answer = answer - Combination(divisibleNumbers, k);
                }
            }

            return answer;
        }

        public static void Solve(int k, int s)
        {
            GenerateFactorials();
            int till = 0;
            Dictionary<Int32, List<Int32>> d = new Dictionary<Int32, List<Int32>>();
            Generate(k, s, ref d, ref till);
            BigInteger answer = GenerateAnswer(k, s, d, till);
            if (answer > 10000) answer = 10000;
            Console.WriteLine(answer);
        }
    }
}
