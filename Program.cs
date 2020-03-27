using System;

namespace MyApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 2
            Console.WriteLine("exercise 2");
            double a=Convert.ToDouble(Console.ReadLine());
            if (a>500 && a<1000)
            {
                Console.WriteLine("discount 3%="+a);
                double j=a-(a*0.03);
                Console.WriteLine("discount="+j);
            }
            if (a>1000)
            {
                Console.WriteLine("discount 5%="+a);
                double i=a-(a*0.05);
                Console.WriteLine("discount="+i);
            }
            //exercise 3
            Console.WriteLine("exercise 3");
            double A,B,C,D;
            Console.WriteLine("first number A=");   
            A=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("second number B=");   
            B=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("third number C=");   
            C=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("fourth number D=");   
            D=Convert.ToDouble(Console.ReadLine());
            if (A<B && B<C && C<D)
            {
                Console.WriteLine("These numbers are increasing");
                Console.WriteLine("a litlle number="+A);
            }
            if (A==B && B==C && C==D)
            {
                Console.WriteLine("These numbers are equally");
                Console.WriteLine("multtiply="+(A*B*C*D));
            }
            //exercise 3
            Console.WriteLine("exercise 3");
            int a1,b1,c1,s;
            Console.WriteLine("first number=");
            a1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second number=");
            b1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("third number=");
            c1=Convert.ToInt32(Console.ReadLine());
                int max=Math.Max(Math.Max(a1,b1),c1),min=Math.Min(Math.Min(a1,b1),c1);
                s=a1+b1+c1;
                a1=max;
                b1=s-max-min;
                c1=min;
                Console.WriteLine($"{a1},{b1},{c1}");
        Console.ReadKey();
        }
    }
}
