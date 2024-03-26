namespace Methods_BarnettLandon
{
    internal class Program
    {

        //prints code to console and asks numbers/name
        static void Main(string[] args)
        {
            Console.WriteLine("Type a whole numba");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type anotha whole numba");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Mult(x,y));

            Console.WriteLine("Wusss yo name");
            string name = Console.ReadLine();

            Howdy(name);

            Cya();
        }
        //multiplies 2 user inputted numbers
        static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        //says hello
        static void Howdy(string username)
        {
            Console.WriteLine($"Howdy , {username}! ");
        }

        //says goodbye
        static void Cya()
        {
            Console.WriteLine("Have a lovely day <3");
        }
    }
}
