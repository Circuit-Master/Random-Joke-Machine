using System.Runtime.InteropServices;
using System;
using System.Security.Cryptography;
using System.Xml.Linq;


namespace random_joke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // defineing jokes
            string[] jokes = new string[]
            {
                "Where are average things manufactured?",
                "Why do we tell actors to “break a leg?”",
                "Hear about the new restaurant called Karma?",
                "Did you hear about the actor who fell through the floorboards?",
                "Did you hear about the claustrophobic astronaut?",
                "Why don’t scientists trust atoms?",
                "What’s the best thing about Switzerland?",
                "What sits at the bottom of the sea and twitches?",
                "How does Moses make tea?",
                "What kind of exercise do lazy people do?",
                "A pair of cows were talking in the field. One says,\n“Have you heard about the mad cow disease that’s going around?”",
                "I told my wife she was dawing her eyebrows too high,"


            };
            // defineing awnsers
            string[] ansr = new string[]
            {
                "The satisfactory.",
                "Because every play has a cast.",
                "There’s no menu: You get what you deserve.",
                "He was just going through a stage.",
                "He just needed a little space.",
                "Because they make up everything.",
                "I don’t know, but the flag is a big plus.",
                "A nervous wreck.",
                "He brews.",
                "Diddly-squats.",
                "“Yeah,” the other cow says.\n“Makes me glad I’m a penguin.”",
                "She looked suprised"

            };
            // funny popups
            string[] funnymsgs = new string[]
            {              
               "How much time do you have?",              
               "P.S.  Go touch grass.",
               "WHY ARE YOU STILL HERE?"
            };


            int msg = 0;
            int count = 0;
            int i = 0;
            int counter = 1;
            int[] usedjokes = new int[jokes.Length];
            int insult = 1;
            bool roast = false;
            

            // main loop
            while (true)
            {

                // defineing the new group of random ints
                Random rnd = new Random();

                // changing a to another after the first loop
                string anothera = "a";
                if (count >= 1)
                    anothera = "another";
                if (roast == true)
                {
                    Console.WriteLine($"{funnymsgs[msg]}\n");
                    msg++;
                    roast = false;
                }


                Console.WriteLine($"Would you like to hear {anothera} joke? Y/N:");
                count++;
                string yorn = Console.ReadLine();
                Console.Clear();

                if (insult == 5 && msg + 1 <= funnymsgs.Length) // checks if there is any text to display
                {
                    roast= true;
                    insult = 1;                   
                }
                insult++;


                // generates a random number != any previous numbers
                int testcount = 0;                
                while (true)
                {
                    if (i == usedjokes[testcount])
                    {
                        i = rnd.Next(0, jokes.Length); //returns random integers >= 0 and < 11
                        testcount = 0;
                    }
                    else
                    {
                        testcount++;
                    }
                    if (testcount == usedjokes.Length - 1)
                    {
                        usedjokes[counter - 1] = i;
                        break;
                    }
                }


                // checks if user input is equal to yes
                if (String.Equals("y", yorn) || String.Equals("Y", yorn))
                {
                    Console.WriteLine($"{jokes[i]}");
                    Console.WriteLine("\n\nPRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine($"\n\n{ansr[i]}");
                    Console.WriteLine("\n\nPRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    Console.Clear();
                    counter++;
                }
                else if (String.Equals("n", yorn) || String.Equals("N", yorn)) // checks if user input is equal to no
                {
                    Console.WriteLine("you're no fun...");
                    Console.WriteLine(":(");
                    Console.WriteLine("\n\nPRESS ANY KEY TO EXIT\n\n\n\n\n\n\n");
                    break;
                }                
                              
                if (counter > jokes.Length) // ends program if it rus out of jokes
                {
                    Console.WriteLine($"Sorry, we are out of jokes. \n\nYou fliped through all {jokes.Length} of our jokes.\n\n\nPRESS ANY KEY TO EXIT\n\n\n\n\n\n");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
