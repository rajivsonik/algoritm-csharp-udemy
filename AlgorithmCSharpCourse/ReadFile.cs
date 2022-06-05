using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmCSharpCourse
{
    public class ReadFile
    {
        public static IEnumerable<int> ReadInts(string filePath)

        {
            using (TextReader reader = File.OpenText(filePath))
            {
                string thisLine;
                while ( (thisLine = reader.ReadLine()) != null)
                {
                    yield return int.Parse(thisLine);
                }
            }
        }
    }
}
