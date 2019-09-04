using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace o7planning.CSharp
{
    class MyClass
    {

        static void Main(string[] args)
        {
            int i32Var4Switch = 10;
            int i32Var4For = 10;
            int i32Var4If = 10;


            Console.WriteLine("Linh Saru");
            Console.ReadLine();

            switch (i32Var4Switch)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    break;

                case 9:
                case 10:
                    break;

                default:
                    break;
            }

            if (i32Var4If == 100)
            {
                Console.WriteLine("i32Var4If = 100");
                Console.WriteLine("Exit");
            }

            for (i32Var4For =0; i32Var4For < 10; i32Var4For++)
            {
                Console.WriteLine("######");
            }   
        }
    }
}
