using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate5
{
    /// <summary>
    /// دلیل اصلی استفاده از دلیگیت ها 
    /// جهت انتقال داده است
    /// main reason of delegate is cominication
    /// main reason of use delegate callback, callback, callback
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyLoopClass mc = new MyLoopClass();
            //mc.run();
            mc.run(jamshid);
            Console.ReadKey();
        }
        public static void jamshid(int i)
        {
            Console.WriteLine(i);
        }
    }
    public delegate void MyLoopClassCallBack(int i);
    public class MyLoopClass
    {
        public void run(MyLoopClassCallBack callback)
        {
            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(i);
                callback(i);
            }
        }
    }
}
