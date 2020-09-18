using System;
using System.Collections.Generic;
using System.Linq;


namespace _17_sep_sln
{
    class Program
    {
        private static readonly string filePath = "../17_sept/input.dat";
        private static readonly string feb_seq = "../17_sept/feb.dat";
        private static readonly string outputPth = "out.dat";
        static void Main(string[] args)
        {
            var inputFileReader = new SourceReader(filePath);
            var matchFileReader = new SourceReader(feb_seq);
            

            var sourceSeq = inputFileReader.ReadData();
            var matchData = matchFileReader.ReadData();

            using (var resultFileWriter = new ResultWriter(outputPth))
            {
                var filtered = sourceSeq.Zip(matchData, (a,b) => (a,b) ).Where(p => p.a == p.b).Select(p => p.a);
                resultFileWriter.WriteData(filtered);
            }
           
        }

    }
}
