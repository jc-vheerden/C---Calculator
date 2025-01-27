namespace Calculator
{
     class Program
    {

        static void Main(string[] args)
        {
            int number1;
            int number2;
            string answerkey;
            int result;

            Console.WriteLine("Hello, This is the calculator program");
            
            Console.WriteLine("Please enter first number");
           number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            number2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What operation would you like to do?");
            Console.WriteLine("A for addition");
            Console.WriteLine("S for subtraction");
            Console.WriteLine("M for multiplication");
            Console.WriteLine("D for division");

            answerkey = Console.ReadLine();


            if (answerkey == "A")
            {
                result = number1 + number2;
            }
            else if (answerkey == "S")
            {
                result = number1 - number2;

            }
            else if (answerkey == "M")
            {
                result = number1 * number2;
            }
            else
            {
                result = number1/number2;

            }

            Console.WriteLine( "The result is:" + result);

        }

    }
}
