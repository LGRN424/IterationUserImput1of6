using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IterationUserImput1of6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            Console.WriteLine("Part 1");
            //A one-dimensional array of strings.
            string[] places = new string[] { "tulum", "london", "moldava", "rio" };

            //Ask the user to input some text.
            Console.WriteLine("input if you want to visit, stay in, leave or never go to each of the following cities: \n ");


            //A loop that iterates through each string in the array and adds the user's text input to the end of each string
            for (int i = 0; i < places.Length; i++)
            {
                Console.Write("{0} : ", places[i]);
                string options = Console.ReadLine();
                places[i] = places[i] + options;
            }

            //A loop that prints off each string in the array on a separate line
            Console.WriteLine("\nElements in array are: ");

            for (int j = 0; j < places.Length; j++)
            {
                Console.Write("{0} , ", places[j]);
            }


            //Part 2

            Console.WriteLine("\nInfinite Loop");

            for (int k = 1; k < 0; k++)
            {
                k++;
                Console.WriteLine(k);
            }


            //Part 3

            Console.WriteLine("\nComparison Loops Less Than");
            for (int m = 1; m < 5; m++)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("\nComparsion Loops Less Than or EQUAL");

            for (int r = 1; r <= 5; r++)
            {
                Console.WriteLine(r);
            }

            //Part 4
            Console.WriteLine("\nMatch User Input");
            //A list of strings where each item in the list is unique.

            List<string> flightDest = new List<string> { "IAD", "CDG", "KBP", "LHR", "GRU", "AMS" };


            //Ask the user to input text to search for in the list.

            Console.WriteLine("Please input the airport you want to go to: ");
            string airportReq = Console.ReadLine();

            //A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
            //stops it from executing once a match has been found.

            foreach (string item in flightDest)
            {

                if (flightDest.Contains(airportReq))
                {
                    int IndexDeOp = flightDest.IndexOf(airportReq);


                    Console.WriteLine("The airport index is at {0} ", IndexDeOp);
                    break;
                }

                //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                else
                {
                    Console.WriteLine("Your requested airport is not on the list!");
                    break;

                }

            }
            //Part 5

            Console.WriteLine("\nIdentical Strings");

            //A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> departurePoint = new List<string> { "HNL", "YYZ", "UIO", "NRT", "YYZ", "MIA", "NRT" };
            

            Console.WriteLine("Please enter which airport you will depart from:  ");
            string leaveAirport = Console.ReadLine();


            //Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.
            foreach (string item in departurePoint)
            {
                if (departurePoint.Contains(item))
                {
                    int IndexDP = departurePoint.IndexOf(leaveAirport);


                    Console.WriteLine("The airport index is at {0} ", IndexDP);
                    break;
                }


                //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                else
                {
                    Console.WriteLine("Your requested airport is not on the list!");
                    break;

                }






                ////Part 6
                //Console.WriteLine("\nString Arrays");

                //List<string> list = new List<string>
                //{
                //    "Rio", "Lisbon", "Boston", "Kyiv", "Boston", "New York", "Toronto", "Boston"
                //};
                //List<string> new_list = new List<string>();

                //foreach (string item in list)
                //{
                //    if (new_list.Contains(item))             //checks to see if item in first list exists in the second list
                //    {
                //        Console.WriteLine(item + " has already appeared in the list");
                //    }
                //    else if (!new_list.Contains(item))       //use the 'not' operator before Contains() to check for the opposite
                //    {
                //        Console.WriteLine(item + " has not appeared in the list");

                //        new_list.Add(item);                   //adds item to the second list
                //    }
                //}
            }
                Console.ReadLine();
           
        }
    }
}
       



        

  

        
       
   
      

        

    


