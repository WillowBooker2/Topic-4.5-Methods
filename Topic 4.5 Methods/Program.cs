namespace Topic_4._5_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for a joke.");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Joke(num);
            drawPikachu(num);
            knockKnockJoke(num);
            
        }
        static void Joke()
        {

            Console.WriteLine("99 little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine("99 little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again");
            Thread.Sleep(500);
            Console.WriteLine("100 little bugs in the code.");

        }
        static void Joke(int numBugs)
        {
            
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(500);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(500);
            Console.WriteLine("Fix a bug, run it again");
            Thread.Sleep(500);
            Console.WriteLine((++numBugs) + " little bugs in the code.");

        }

        static void drawPikachu(int numBugs)
        {

            Console.WriteLine("Would you like to see a Pikachu?");
            string answer = Console.ReadLine().Trim().ToUpper();
            if (answer == "YES")
            {
                Console.WriteLine("Cool, here it is! It may take to load so give it a second. :3");
                Thread.Sleep(1000);
                Console.WriteLine("       ,___          .-;'    ");
                Thread.Sleep(500);
                Console.WriteLine("       `\"-.`\\_...._/`.`      ");
                Thread.Sleep(500);
                Console.WriteLine("    ,      \\        /        ");
                Thread.Sleep(750);
                Console.WriteLine("  .-' ',   / ()   ()\\ ");
                Thread.Sleep(100);
                Console.WriteLine("`'._   \\  /()    .  (| ");
                Thread.Sleep(2000);
                Console.WriteLine("    > .' ;,     -'-  / ");
                Thread.Sleep(1500);
                Console.WriteLine("   '-.'-.|  , \\    , \\  ");
                Thread.Sleep(500);
                Console.WriteLine("      `>.|;, \\_)    \\_)  ");
                Thread.Sleep(500);
                Console.WriteLine("       `-;      ,   /  ");
                Thread.Sleep(50);
                Console.WriteLine("          \\    /   < ");
                Thread.Sleep(570);
                Console.WriteLine("           '. <`'-,_)          ");
                Thread.Sleep(1000);
                Console.WriteLine("             '._)              ");
            }

            else if (answer == "NO")
            { 
              Console.WriteLine("You're so mean to me. :(");
                Console.WriteLine("You will now be kicked. Be nicer next time.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }



        static void knockKnockJoke(int numBugs)
        {
            Console.WriteLine("You want to hear a knock knock joke?");
            string respomse = Console.ReadLine().Trim().ToUpper();
            while (respomse != "YES" & respomse != "NO")
            {
                Console.WriteLine("Please give me a valid response.");
                respomse = Console.ReadLine();
                
            }
            if (respomse == "NO")
            {
                Console.WriteLine("Aw you're such a fish.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            Console.WriteLine("Knock knock.");
            string who = Console.ReadLine().Trim().ToUpper();
            if (who == "WHO'S THERE?" || who == "WHOS THERE?" || who == "WHO'S THERE" || who == "WHOS THERE") 
            {
              Console.WriteLine("Hatch.");
                string hatch = Console.ReadLine().Trim().ToUpper();
                if(hatch == "HATCH WHO?" || hatch == "HATCH WHO")
                {
                    Console.WriteLine("Bless you.");

                }
                else if (hatch != "HATCH WHO?")
                {
                    Console.WriteLine("If you can't follow the joke, then please leave, stinky.");
                }

            }
            else if (who != "WHO'S THERE?")
            {
                Console.WriteLine("If you can't follow the joke, then please leave, stinky.");

            }

        }

    }
}