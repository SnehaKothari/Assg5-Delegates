using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatess
{
    public delegate string InputParserDel(string s);
    public class ConsoleParser
    {
        InputParserDel onWord = Word;
        InputParserDel onNumber = Number;
        InputParserDel onJunk = Junk;
        public static string Word(string str)
        {
            str = "String contains words";
            Console.WriteLine(str);
            return str;
        }
        public static string Number(string str)
        {
            str = "String contains numbers";
            Console.WriteLine(str);
            return str;
        }
        public static string Junk(string str)
        {
            str = "String contains special characters";
            Console.WriteLine(str);
            return str;
        }
    }
}