using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    
    class Class1
    {
        // 가변길이 매개변수
        public int Add(params int[] nums) 
        {
            int sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            return sum;
        }
        public double Add(double a=0, double b=0)
        {
            return a + b;
        }
        static public void Test_Add()
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.Add(3, 5, 6, 7));
            Console.WriteLine(class1.Add(b: 2.3, a: 3.6)); //명명된 매개변수
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Test_Add();
            //Class2.Test_Human();
        }
    }
    
}
