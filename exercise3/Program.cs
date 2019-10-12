using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            //Code that computes the avarage of an array of totals
            decimal[] totals = { 14.95m, 12.95m, 11.95m, 9.95m };
            decimal sum = totals[0] + totals[1] + totals[2] + totals[3];
            decimal average = sum / 4;

            //Code that puts the numbers 0 through 9 into a array
            int[] numbers = new int[10]; 
            for(int i = 0; i < numbers.Length; i++) {
                numbers[i] = i; 
            }

            //Code that displays the numbers array in a message box 
            string numberString = ""; 
            for(int i = 0; i < numbers.Length; i++) {
                numberString += numbers[i]; 

                Console.WriteLine(numberString);
            }

            //Code that uses a for loop to compute the average of the totals array 
            decimal sum1 = 0.0m; 
            for(int i = 0; i < totals.Length; i++) {

                sum1 += totals[i];
            }
            decimal average1 = sum1 / totals.Length;


            //Code that desplays thet totals array in a Console.WriteLine 
            string totalString1 = ""; 
            for(int i = 0; i < totals.Length; i++) {
                totalString1 += totals[i] + "\n";
            }
             Console.WriteLine("The total are: \n" + totalString1 + "\n" + "Sum:" + "" + sum +
                    "\n" + "Averange:" + ""+ average);



            Console.ReadKey();

        }
    }
}
