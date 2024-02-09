/* 
 * Author: Saul Barajas
 * Course: COMP003A-L01
 * Purpose: Implementing loops in C#
 */
namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
         // (Right Triangle)
            Console.WriteLine("For Loop Section (Right Triangle)");
            Console.Write(" Enter a positive whole number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";
            for (int i = 0; i < limit; i++ )
            {
                Console.WriteLine(output);
                output += "#";
            }

            // Friends
            Console.WriteLine("ForEach Section(Friends)");
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            // Counting by 5s
            Console.WriteLine("Do - While Loop Section(Counting by 5s)");
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <=50);

            // Foobar
            Console.WriteLine("While Loop Section (FooBar)");
            int counter2 = 1;
            while (counter2 <=20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }
        }
    }
}
