namespace forStudy1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Ratio(1, -2);
            var r2 = new Ratio(120, 40);
            var r3 = new Ratio(-3, -4);

            var r4 = new Ratio(683, 4);
            var r5 = new Ratio(683, 4);
            r4 += r5;

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r1 == r2);
            Console.WriteLine(r4);
            Console.WriteLine(r5);
        }
    }
}