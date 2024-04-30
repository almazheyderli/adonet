using adonetTask.Controllers;
using Core.Models;

namespace adonetTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeController employeeController = new EmployeeController();

            do
            {
                Console.WriteLine("1.Isci elave et");
                Console.WriteLine("2.Isci sil");
                Console.WriteLine("3.Yenile ");
                Console.WriteLine("4.Iscilere bax");
                Console.WriteLine("5.Cixis");
                string answerStr;
                byte answerByte;
                do
                {
                    Console.WriteLine("Secim edin");
                    answerStr= Console.ReadLine();
                } while(!byte.TryParse(answerStr, out answerByte));


                switch(answerByte)
                {
                    case 1:
                        employeeController.Add();

                        break;
                }
            }
            while (true);
        }
    }
}
