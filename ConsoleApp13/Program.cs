using System;
namespace project
{
    class test1
    {
        public static void Main()
        {
            int X = Convert.ToInt32(Console.ReadLine());
            Calc(X);
        }//end Main
        private static void Calc(int X)
        {
            double Result = Math.Pow(X, 2) + (2 * X) - 4;
            Console.WriteLine(Result);
        }//end function
    }//end class

}//end namespace
