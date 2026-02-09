namespace Assignment5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Check if Palindrome");
                int numCheck = int.Parse(Console.ReadLine());
                Console.WriteLine(IsPalindrome(numCheck));
            }
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Sum of Nums");
                int numCheck = int.Parse(Console.ReadLine());
                Console.WriteLine(CalcualteSum(numCheck));
            }
            Console.WriteLine();


            int[] uniqueNums = { 1, 2, 3, 4 };
            int[] repeatNums = { 1, 1, 3, 4 };
            Console.WriteLine("Unique numbers");
            Console.WriteLine(LookForNum(uniqueNums));

            Console.WriteLine();
            Console.WriteLine("Repeated numbers");
            Console.WriteLine(LookForNum(repeatNums));


        }
        static bool IsPalindrome(int x)
        {
            if(x < 0)
                return false;

            //list to hold values
            List<int> listNums = new List<int>();

            //adds the remainder which will get a 1 int num to listnum
            while (x != 0)
            {
                listNums.Add(x % 10);
                x /= 10;
            }

            //variables for checks
            int left = 0;
            int right = listNums.Count - 1;

            //actual check left from right
            while(left < right)
            {
                if(listNums[left] != listNums[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            // case not true
            return true;
        }
        static int CalcualteSum(int x)
        {
            int sum = 0;

            //need to check logic to check for pos and neg nums
            while (x != 0)
            {
                //if a negative number case == last number checked
                if(x > -10 && x < 0)
                {
                    sum += (x % 10);
                }
                else
                {
                    //this make sure that each digit is a positive number
                    sum += Math.Abs( x % 10);
                }

                //this will get the next digit inline to the math problem
                x = x / 10;
            }
            return sum;
        }
        //
        static bool LookForNum(int[] x)
        {
            x.Sort();

            for (int i = 0; i < x.Length -1; i++)
            {
                if (x[i] == x[i + 1])
                {
                    return true; 
                }
            }
            return false;
        }
    }
}
