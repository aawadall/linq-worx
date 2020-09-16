using System;
using System.Collections.Generic;
using System.IO;

namespace admin
{
    class Program
    {
        private static readonly int maxFebonacciIndex = 25;
        private static readonly double signalToNoise = 0.1f;
        private static readonly string filePath = "./input.dat";

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

        private static List<int> GenerateFebonacciAndNoise(int maxFebonacciIndex, double signalToNoise)
        {
            int febIdx = 0;
            var result = new List<int>();
            var rnd = new Random();
            var signal = GetNextFeb();
            while(febIdx < maxFebonacciIndex) 
            {
                if(rnd.NextDouble() < signalToNoise)
                { // real signal 
                    signal.MoveNext();
                    result.Add(signal.Current);
                    febIdx++;
                }
                else 
                { // noise 
                    result.Add(rnd.Next(maxFebonacciIndex*maxFebonacciIndex));
                }
                
            }

            return result;
        }

        static public System.Collections.Generic.IEnumerator<int> GetNextFeb()
        {
            int current = 1;
            int next = 1;
            int swap;
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
