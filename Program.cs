
namespace Calulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string answer;
            int result;
            Console.WriteLine("Welcome to Calulator");

            Console.WriteLine("Please Enter your First Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter your second Number");
            num2= Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("What Operation to do?");
            Console.WriteLine("please select your operation a for addition,s for subtrabtion ,m for multiplication,other key for devivtion !");

            answer = Console.ReadLine();
            if (answer == "a")
            {
                result = num1 + num2; 
            }
            else if(answer == "s")
            {
                result = num1 - num2;
            }
            else if(answer == "m")
            {
                result = num1*num2;
            }
            else
            {
                result = num1/num2;
            }
            Console.WriteLine("The result is ="+result);
            Console.WriteLine("Thank you for using this calulator !");
            Console.ReadKey();
        }
    }
}
