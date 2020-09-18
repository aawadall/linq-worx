using System;
using System.IO;
using System.Collections.Generic;

namespace _17_sep_sln
{
    public class ResultWriter : IDisposable 
    {
        private readonly StreamWriter _streamWriter;
        public ResultWriter(string filePath)
        {
            _streamWriter = new StreamWriter(filePath);
        }

        public void Dispose()
        {
            _streamWriter.Dispose();
        }
        public void WriteData(string data)
        {
            try
            {
                _streamWriter.WriteLine(data); 
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine($"Exception {e.Message}");
                throw;
            }
        }

        public void WriteData(IEnumerable<string> data)
        {
            foreach (var line in data)
            {
                WriteData(line);
            }
        }
    }
}