namespace TasksCom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hii everyone its a game ");
            Console.WriteLine("Press E to Enter and Q to quit");
            //Console.WriteLine


            ConsoleKeyInfo key = Console.ReadKey(true);
            
            if (key.Key == ConsoleKey.E)
            {
                WTTC();
            }

            if (key.Key == ConsoleKey.Q)
            {
                Console.WriteLine("You quit");
            }





        }

        static void WTTC()
        {
            bool isrunning = false;
            Console.WriteLine("Press A program 1 and B for program 2");
            while (true)
            {


                ConsoleKeyInfo key = Console.ReadKey(true);

                
                if (key.Key == ConsoleKey.A)
                {
                    Console.WriteLine("-----------PROGRAM #1------------");
                    Task1();
                    Console.WriteLine("Do you want to run task2");
                    
                }

                if (key.Key == ConsoleKey.B)
                {
                    //isRunning = true;
                    Console.WriteLine("-----------PROGRAM #2------------");
                    Task2();
                    Console.WriteLine("Do you want to run task1");

                }
               

                if (key.Key == ConsoleKey.Q)
                {
                    break;
                }

            }
        }


        static void Task1()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int a = 2;
            int b = 3;
            int c = 4;

            int j = 0;
            //int[] res = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (j == 0)
                {
                    Console.WriteLine(arr[i] + "*" + a + "=" + arr[i] * a);

                    j++;
                }
                else if (j == 1)
                {
                    Console.WriteLine(arr[i] + "*" + b + "=" + arr[i] * b);

                    j++;
                }
                else if (j == 2)
                {
                    Console.WriteLine(arr[i] + "*" + c + "=" + arr[i] * c);

                    j++;
                }
                if (j > 2)
                {
                    j = 0;
                }

            }


        }

        static void Task2()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7 };
            int[] num = { 2, 3, 4 };

            int j = 0;
            //int[] res = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (j == 0)
                {

                    Console.WriteLine(arr[i] + "*" + num[j] + "=" + arr[i] * num[j]);


                }
                else if (j == 1)
                {
                    Console.WriteLine(arr[i] + "*" + num[j] + "=" + arr[i] * num[j]);


                }
                else if (j == 2)
                {
                    Console.WriteLine(arr[i] + "*" + num[j] + "=" + arr[i] * num[j]);


                }
                j++;
                if (j > 2)
                {
                    j = 0;
                }

            }
        }
    }
}
