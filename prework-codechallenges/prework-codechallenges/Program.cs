using System;

namespace prework_codechallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int userInputInt;
            int[] arr = new int[5];
            int rows;
            int cols;
            Random randomNum = new Random();




            // This section is for ArrayMax
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a number between 1-10: ");
                userInput = Console.ReadLine();
                userInputInt = Convert.ToInt32(userInput);
                arr[i] = userInputInt;
            }

            Console.WriteLine("[{0},{1},{2},{3},{4}]", arr[0], arr[1], arr[2], arr[3], arr[4]);
            Console.Write("Please choose a value from the array: ");
            userInput = Console.ReadLine();
            userInputInt = Convert.ToInt32(userInput);
            Console.WriteLine("Score: {0}", ArrayMax(arr, userInputInt));
            Console.ReadKey();
            Console.Clear();




            // This section is for Leap Year
            Console.Write("Please enter a year: ");
            userInput = Console.ReadLine();
            userInputInt = Convert.ToInt32(userInput);
            Console.WriteLine(IsLeapYear(userInputInt));
            Console.ReadKey();
            Console.Clear();




            // This section is for Perfect Sequence
            Console.WriteLine("[2,2] - {0}", IsPerfectSequence(new int[] { 2, 2 }));
            Console.WriteLine("[1,3,2] - {0}", IsPerfectSequence(new int[] { 1, 3, 2 }));
            Console.WriteLine("[0,0,0,0] - {0}", IsPerfectSequence(new int[] { 0, 0, 0, 0 }));
            Console.WriteLine("[4,5,6] - {0}", IsPerfectSequence(new int[] { 4, 5, 6 }));
            Console.WriteLine("[0,2,-2] - {0}", IsPerfectSequence(new int[] { 0, 2, -2 }));
            Console.ReadKey();
            Console.Clear();




            // This section is for Sum of Rows
            Console.Write("Please choose the length of the rows of the array: ");
            userInput = Console.ReadLine();
            rows = Convert.ToInt32(userInput);
            Console.Write("Please choose the length of the columns of the array: ");
            userInput = Console.ReadLine();
            cols = Convert.ToInt32(userInput);
            int[,] multArray = new int[rows,cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    multArray[i, j] = randomNum.Next(10);
                }
            }

            Console.Write("[ ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("{" + multArray[i, j] + ",");
                    }
                    else if (j == cols - 1)
                    {
                        Console.Write(multArray[i, j] + "} ");
                    }
                    else
                    {
                        Console.Write(multArray[i, j] + ",");
                    }
                }
            }
            Console.WriteLine("]");
            arr = SumOfRows(multArray);

            for(int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("[{0},", arr[i]);
                }
                else if(i == arr.Length - 1)
                {
                    Console.WriteLine("{0}]", arr[i]);
                }
                else
                {
                    Console.Write("{0},", arr[i]);
                }
            }

            Console.ReadKey();
            Console.Clear();
        }

        // Challenge 1
        static int ArrayMax(int[] arr, int userVal)
        {
            int count = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == userVal)
                {
                    count++;
                }
            }

            return userVal * count;
        }

        // Challenge 2
        static string IsLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        return Convert.ToString(year) + " is a Leap Year";
                    }
                    else
                    {
                        return Convert.ToString(year) + " is not a Leap Year";
                    }
                }
                else
                {
                    return Convert.ToString(year) + " is a Leap Year";
                }
            }
            else
            {
                return Convert.ToString(year) + " is not a Leap Year";
            }
        }

        // Challenge 3
        static string IsPerfectSequence(int[] arr)
        {
            int sum = 0;
            int product = 1;
            bool nonNegative = true;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                product *= arr[i];

                if(arr[i] < 0)
                {
                    nonNegative = false;
                }
            }

            if(sum == product && nonNegative)
            {
                return "This array is a Perfect Sequence";
            }
            else
            {
                return "This array is not a Perfect Sequence";
            }
        }

        // Challenge 4
        static int[] SumOfRows(int[,] arr)
        {
            int[] sumArr = new int[arr.GetLength(0)];
            int sum;

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;

                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }

                sumArr[i] = sum;
            }

            return sumArr;
        }
    }
}
