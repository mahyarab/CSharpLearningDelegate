using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate3
{
    /// <summary>
    /// delegate is type safe function pointer
    /// </summary>
    public delegate void testDelegate(string something);
    class Program
    {
        static void Main(string[] args)
        {
            string jamshid = "salam";
            //PrintMessage(jamshid);
            testDelegate dd = new testDelegate(PrintMessage);
            dd(jamshid);
            Console.ReadLine();
        }    
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }


}
