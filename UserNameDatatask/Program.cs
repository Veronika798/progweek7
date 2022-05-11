using System;

namespace UserNameDatatask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnime
            //programm kusib kasutaja sisestada numbrit 1-3
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja nime 1 tahte
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("sisesta oma eesnimi");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number 1-3");
            string userNumber = Console.ReadLine();
            

            GetUserNameNumber(userNumber, userName);
            
            

        }

        public static void GetUserNameNumber( string userInput)
        {
           
            if (userNumber == "3")
            {
                Console.Write($"Sinu nimi on{userInput.Length} sumbolit pikk.");
            }
 
            else if (userNumber == "2")
            {
                Console.WriteLine($"Sinu eesnime esimene taht on {userInput[0]}");
            }

            else if (userNumber == "1")
            {
                for (int i = userInput.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(userInput[i]);
                }
            }
        }










}

    }

