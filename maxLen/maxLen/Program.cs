using System;
using System.IO;
using System.Text;

namespace maxLen
{
   public class Program
    {
        static void Main(string[] args)
        {
            int maxLen = 0;
            using (var stream = new FileStream("input.txt", FileMode.Open))
            {
                maxLen = GetMaxLength(stream);
            }

            File.WriteAllText("output.txt", maxLen.ToString(), Encoding.ASCII);
        }
        
       public static int GetMaxLength(Stream stream)
        {
            var reader = new StreamReader(stream, Encoding.ASCII);
            int tempLength = 0, maxLength = 0;
            while (!reader.EndOfStream)
            {
                var ch = reader.Read();
                var value = ch - '0';
                if (value == 1)
                    tempLength++;
                else if (value==0)
                {
                    maxLength = Math.Max(maxLength, tempLength);
                    tempLength = 0;
                }
                else
                {
                    throw new ArgumentException("bad input");
                }
            }
            maxLength = Math.Max(maxLength, tempLength);
            return maxLength;

        }


    }
}