using System;
namespace CSVHelperDemo
{
    class Program
    {
        static void Main(string[] args)
        {           
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Implement CSV Handling \n2.Implement CSV to JSON \n3.Implement JSON to CSV \n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Operation.ImplementCSVHandling();
                        break;
                    case 2:
                        Operation.ImplementCSVToJson();
                        break;
                    case 3:
                        Operation.ImplementJsonToCSV();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            } 
        }
    }
}