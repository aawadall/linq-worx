using System;
using System.Collections.Generic;
using System.IO;

namespace admin
{
    class Program
    {
        private static readonly int maxFebonacciIndex = 40;
        private static readonly double signalToNoise = 0.1f;
        private static readonly string filePath = "../17_sept/input.dat";

        static void Main(string[] args)
        {
            Console.WriteLine("Generating Febonacci + Noise");
            var febAndNoise = GenerateFebonacciAndNoise(maxFebonacciIndex, signalToNoise);
            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (var item in febAndNoise)
                {
                    outputFile.WriteLine(item);
                }
            }
            
        }

        private static List<long> GenerateFebonacciAndNoise(int maxFebonacciIndex, double signalToNoise)
        {
            int febIdx = 0;
            var result = new List<long>();
            var rnd = new Random();
            var signal = GetNextFeb();
            long last = 1;
            while(febIdx < maxFebonacciIndex) 
            {
                if(rnd.NextDouble() < signalToNoise)
                { // real signal 
                    signal.MoveNext();
                    last = signal.Current;
                    result.Add(last);
                    febIdx++;
                }
                else 
                { // noise 
                    result.Add(rnd.Next((int)last,(int)last+5));
                }
                
            }

            return result;
        }

        static public System.Collections.Generic.IEnumerator<long> GetNextFeb()
        {
            long current = 1;
            long next = 1;
            long swap;
            while (true)
            {
                yield return current;
                swap = next;
                next += current;
                current = swap;
            }
        }
    }
}
