namespace ConsoleApp14
{
    public class Once
    {
        protected static int temp = 0;
        protected static int counter = 0;
        public int OnceAdd(int a, int b)
        {
            int res = a + b;
            if (counter == 0)
            {
                temp = res;
                counter++;
            }
            if (temp == res)
            {
                return res;
            }
            return temp;
        }
    }
}
