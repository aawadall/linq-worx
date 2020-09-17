using System;
using System.IO;
using System.Collections.Generic;

namespace _17_sep_sln
{
    public class SourceReader
    {
        private readonly string _filePath;
        public SourceReader(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<string> ReadData()
        {
            using (var streamReader = new StreamReader(_filePath))
            {
                while(streamReader.Peek() >= 0)
                {
                    yield return streamReader.ReadLine();
                }
            }
        }
    }
}