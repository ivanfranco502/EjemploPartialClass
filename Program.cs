using System;

namespace EjemploPartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclarePartialClassFirsExample();
        }

        private static void DeclarePartialClassFirsExample()
        {
            CoOrds myCoOrds = new CoOrds(10, 15);
            myCoOrds.PrintCoOrds();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    public partial class CoOrds
    {
        private int x;
        private int y;

        public CoOrds(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public partial class CoOrds
    {
        public void PrintCoOrds()
        {
            Console.WriteLine("CoOrds: {0},{1}", x, y);
        }
    }
    partial interface ITest
    {
        void Interface_Test();
    }
    partial interface ITest
    {
        void Interface_Test2();
    }
    partial struct S1
    {
        void Struct_Test() { }
    }
    partial struct S1
    {
        void Struct_Test2() { }
    }
}
