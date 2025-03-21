namespace CCAD17MenteeGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sortedArray = DutchFlag.Solution([1, 1, 0, 0, 2, 1, 1, 2]);
            Console.WriteLine(sortedArray.ToString());
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}