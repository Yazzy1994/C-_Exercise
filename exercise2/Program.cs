using System;
using System.Collections.Generic;

namespace Excersie_2 {
    class Program {
        static void Main(string[] args) {

            var listInput = new List<string>();

            var inpuut = true;
            do {
                Console.WriteLine("Lägg till en rad: ");
                var input = Console.ReadLine();
                if (input == "q" || input == "quit") {

                    break;


                } else {
                    listInput.Add(input);
                }

            }
            while (inpuut);

            Console.WriteLine("Filter: ");
            var filter = Console.ReadLine();
            foreach (var listName in listInput) {
                if(listName.StartsWith(filter)) {

                    Console.WriteLine(listName);
                }
               

            }

            Console.ReadKey();
            
        }
    }         
}
          

        

        
   
