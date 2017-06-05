using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate4
{
    /// <summary>
    /// استفاده از دلیگیت با 
    /// invoke
    /// </summary>    
    public delegate void testDelegate();
    class Program
    {
        static void Main(string[] args)
        {            
            testDelegate dd = new testDelegate(PrintMessage);
            //dd();
            dd.Invoke();
            Console.ReadLine();
        }
        public static void PrintMessage()
        {
            Console.WriteLine("this is test");
        }
    }
}
