using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_two_dimensional_arrays {
    class Program {
        static void Main(string[] args) {

            // type[,] arrayname = new type[rowcount, columncount]

            //Code that creates a 3x2 array and assigns values with one statement 
            int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 }  };

            //Code that creates and assigns values to 3x2 array of strings 
            string[,] products = { { "CS2015", "Murach's C# 2015" },
                                    { "JAVAPRG", "Murach's Java programming"}, 
                                    {"ASP46CG", "Murach's ASP.NET 4.6 with C# 2015" } };                            


            //Code that works with the numbers array 
            /* int numbersOfRows = numbers.GetLength(0);
            int numbersOfColumns = numbers.GetLength(1);
            int sumOfFirstRow = numbers[0, 0] + numbers[0, 1]; */

            //Code that display the numbers
            string numberString = "";
            for (int i = 0; i < numbers.GetLength(0); i++) {  //GetLength method is to get the number of rows or columns in a rectangular array. 


                for (int j = 0; j < numbers.GetLength(1); j++) {  //Use nested for loops to iterate through the rows and columns of a rectangular array
                    numberString += numbers[i, j] + " ";


                }

                numberString += "\n";
            }
            Console.WriteLine(numberString);

            string productString = ""; 
            for(int i = 0; i < products.GetLength(0); i++) { //GetLength method is to get the number of rows or columns in a rectangular array. 

                for(int j = 0; j < products.GetLength(1); j++) {  //Use nested for loops to iterate through the rows and columns of a rectangular array

                    productString += products[i, j] + "\t\t"; 
                }

                productString += "\n"; 
            }

            Console.WriteLine(productString);




            Console.ReadKey();

        }
    }
}
