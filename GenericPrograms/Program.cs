namespace GenericPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int num1, num2, num3 = 0;
            FindMaxNumber maxnum = new FindMaxNumber();


            while(flag)
            {
                Console.WriteLine("\n====================================\n");
                Console.WriteLine("\tWell-Come To Maximum find\n");
                Console.WriteLine("====================================\n");
                Console.WriteLine("1 : Maximum Integer \n\n\t0 : To Exit\n");
                Console.WriteLine("\n------------------------------------\n");
                Console.Write("Enter the option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n====================================\n");
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n----------{ Finding Maximum Number }-----------");
                        Console.Write("\nEnter first Number : ");
                        num1= Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter second Number : ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter third Number : ");
                        num3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nMaximum Number is : " + maxnum.maxInteger(num1,num2,num3)+"\n");

                        Console.WriteLine("------------------------------------------------");
                        Console.Write("Press any key......");
                        Console.ReadLine();
                        break;
                    case 0:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter Correct Option....!!");
                        break;

                }
            }

        }
    }
}