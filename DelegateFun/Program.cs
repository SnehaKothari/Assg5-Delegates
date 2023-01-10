using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegatess;

namespace DelegateFun
{
    public class Program
    {
public void Run(string s,InputParserDel onWord,InputParserDel onNumber,InputParserDel onJunk)
        {
            if (s.All(char.IsDigit))
            {
                onNumber(s);
            }
            else if (s.All(char.IsLetterOrDigit))
            {
                onWord(s);

            }
            else if (!(s.All(char.IsLetterOrDigit)))
            {
                onJunk(s);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Program delegates = new Program();
                Console.WriteLine("Enter the string");
                string str ;
                str = Console.ReadLine();
                delegates.Run(str, ConsoleParser.Word, ConsoleParser.Number, ConsoleParser.Junk);
            }
        }
    }
}
