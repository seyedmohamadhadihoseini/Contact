using System;
using System.Web; 
namespace itpro
{

    class Program
    {
        
        /// <summary>
        /// To print Esealy and Good 
        /// </summary>
        /// <param name="s">the internal String</param>
        /// <param name="IsWriteLine">Is Writeline?</param>
        /// <param name="adad">the internal number</param>
        public static void print(string s = "", bool IsWriteLine = true, double adad = -1)
        { 
            if (IsWriteLine)
            {
                if (s!="")
                    Console.WriteLine(s);
                else
                    Console.WriteLine(adad);
            }
            else
            {
                if (s!="")
                    Console.Write(s);
                else
                    Console.Write(adad);
            }
        }
       

        static void Main(string[] args)
        {
            amal a = new amal();

            print(adad: a.aparat(5,2, new devide()));
        }
    }
  class amal
    {
        public int aparat(int a,int b,operate op)
        {
            return op.part(a, b);
        }
    }
   abstract class operate
    {
        public abstract int part(int a, int b);
        
        
        
    }
    class Add : operate
    {
        public override int part(int a, int b)
        {
            return a + b;
        }
    }
    class minus : Add
    {
        public override int part(int a,int b)
        {
            return a - b;
        }
    }
    class multyply : operate
    {
        public override int part(int a, int b)
        {
            return a * b;
        }
    }
    class devide : multyply
    {
        public override int part(int a,int b)
        {
            return a / b;
        }
    }
}
