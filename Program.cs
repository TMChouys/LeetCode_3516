namespace LeetCode_3516
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter x");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter z");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("The Answer:");
            Console.WriteLine(FindClosest(a, b, c));


            int FindClosest(int x, int y, int z)
            {
                int dX = x - z;
                int dY = y - z;

                if (dX < 0) dX = -dX;

                if (dY < 0) dY = -dY;

                if (dX < dY) return 1;
                else if (dX > dY) return 2;
                else return 0;

            }
        }
    }
}
