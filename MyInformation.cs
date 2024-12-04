using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCShapSession
{
    public delegate void MyDelegate(string msg,string message1);
    public class MyInformation
    {
        public void MethodA(string message,string p)
        {
            Console.WriteLine(message);
        }

       public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }


    }
}
