namespace GenericPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int iNo1, iNo2, iNo3;
            float fNo1,fNo2, fNo3;
            string sNo1, sNo2, sNo3;
            FindMaxNumber maxnum = new FindMaxNumber();


            while(flag)
            {
                Console.WriteLine("\n=======================================\n");
                Console.WriteLine("\tWell-Come To Maximum find\n");
                Console.WriteLine("====================================\n");
                Console.WriteLine("1 : Finding Maximum Integer Number \n2 : Finding Maximum Floating Point Number\n3 : Finding Maximum Word\n\n\t0 : To Exit\n");
                Console.WriteLine("\n------------------------------------\n");
                Console.Write("Enter the option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n=======================================\n");
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n----------{ Finding Maximum Integer Number }-----------");
                        Console.Write("\nEnter first Number : ");
                        iNo1= Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter second Number : ");
                        iNo2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter third Number : ");
                        iNo3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nMaximum Number is : " + maxnum.maxInteger(iNo1,iNo2,iNo3)+"\n");

                        Console.WriteLine("------------------------------------------------");
                        Console.Write("Press any key......");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("\n----------{ Finding Maximum Floating Point Number }-----------");
                        Console.Write("\nEnter first Number : ");
                        fNo1 = (float)Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter second Number : ");
                        fNo2 = (float)Convert.ToDouble(Console.ReadLine());
                        Console.Write("\nEnter third Number : ");
                        fNo3 = (float)Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\nMaximum Number is : " + maxnum.maxFloat(fNo1,fNo2,fNo3) + "\n");

                        Console.WriteLine("------------------------------------------------");
                        Console.Write("Press any key......");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("\n----------{ Finding Maximum Word }-----------");
                        Console.Write("\nEnter first word : ");
                        sNo1 = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter second word : ");
                        sNo2 = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter third word : ");
                        sNo3 = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("\nMaximum Length of Word is : " + maxnum.maxString(sNo1, sNo2, sNo3) + "\n");

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