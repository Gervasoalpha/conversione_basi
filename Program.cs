using System;

namespace conversione_basi
{
    class Program
    {
        static void Main(string[] args)
        {

            cb num = new cb();
            Console.Clear();
            num.set(1011.1001,5);

            num.print();

            num.conv(7);
            
            num.print();
            //Console.WriteLine(cb.todec(55.4,9));
            //Console.WriteLine(cb.tobase(50.41,7));
        }
    }
}
