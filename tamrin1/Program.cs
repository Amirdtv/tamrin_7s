using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[10,10];
            int cont = 0;
            Console.WriteLine("100 adad vared konin");

            for(int i =0;i<10;i++) 
                for(int j =0;j<10;j++)
                    x[j,i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("adad morednazar ra vared konin");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (x[j,i] == input)
                        cont++;
                }
            Console.Write("tedad adad moshabeh = ");
            Console.WriteLine(cont);

        }
    }
}
