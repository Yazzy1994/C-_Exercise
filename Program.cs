using System;

namespace ConsoleApp2 {
    enum Mode {
        Mulitply, Percentage
    }
    class Program {
        static void Main(string[] args) {

            var mode = Mode.Mulitply; 

            decimal X, Y;

            Console.WriteLine("X:");
            var inputX = Console.ReadLine();
            Console.WriteLine("Y:");
            var inputY = Console.ReadLine();



            if (!decimal.TryParse(inputX, out X) || !decimal.TryParse(inputY, out Y)) {

                Console.WriteLine("Error");
            } else {

                Console.WriteLine(@" Resultat " + X.ToString("N3") + "\n" + "\t" + Y.ToString("N3"));
                decimal result;

                Console.WriteLine("Mode: ");
                var inputMode = Console.ReadLine();

                if (inputMode == "percent") {
                    mode = Mode.Percentage;
                } else if (inputMode == "multiply") {
                    mode = Mode.Mulitply;
                }

                
                if (mode == Mode.Mulitply) {
                    result = X * Y;

                } else {
                    result = X / Y; 
                }

                Console.WriteLine("Resultat: " + result.ToString(mode == Mode.Percentage ? "P2" : "N3")); 

            }
            Console.ReadKey();





        

        }
    }
}
