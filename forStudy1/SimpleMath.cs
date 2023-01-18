namespace forStudy1
{
    internal static class SimpleMath
    {
        public static int Evklid(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            while (x * y != 0)
            {
                if (x > y) { x = x % y; }
                else { y = y % x; }
            }
            return x + y;

        }
    }
}
