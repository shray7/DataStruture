namespace ConsoleApp
{
    public class Math
    {
        public int Add(int a, int b)
        {
            return DoWork(a, b, true);
        }
        public int Subtract(int a, int b)
        {
            return DoWork(a, b, false);
        }

        private int DoWork(int a, int b, bool isAdd)
        {
            int carry;
            while (b != 0)
            {
                if (isAdd)
                    carry = a & b;
                else
                    carry = (~a) & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;
        }
    }
}
// XOR
// a b a^b
// 0 0 0
// 1 0 1 
// 0 1 1
// 1 1 0



// a b a&b
// 0 0 0
// 1 0 0 
// 0 1 0
// 1 1 1