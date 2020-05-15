using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Number_Form_Converter
{
    class Program
    {
        public static void Main(string[] args)
        {

            bool runningtheprogram = true;
            while (runningtheprogram)
            {

                Console.Clear();
                Console.WriteLine("Do you want to convert a complex number from:");
                Console.WriteLine("1. Rectangular form to Polar form.");
                Console.WriteLine("2. Polar form to Rectangular form.");
                Console.WriteLine("3. Polar form to Exponential form.");
                Console.WriteLine("4. Exponential form to Polar form.");
                Console.WriteLine("5. Exit Program.");
                Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
                string recOrPol = Console.ReadLine();
                while (recOrPol != "1" && recOrPol != "2" && recOrPol != "3" && recOrPol != "4" && recOrPol != "5")
                {
                    Console.Clear();
                    Console.WriteLine("Do you want to convert a complex number from:");
                    Console.WriteLine("1. Rectangular form to Polar form.");
                    Console.WriteLine("2. Polar form to Rectangular form.");
                    Console.WriteLine("3. Polar form to Exponential form.");
                    Console.WriteLine("4. Exponential form to Polar form.");
                    Console.WriteLine("5. Exit Program.");
                    Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
                    Console.WriteLine("Please only write '1' or '2' or '3' or '4' or '5'.");
                    recOrPol = Console.ReadLine();
                }
                Console.Clear();
                if (recOrPol == "1")
                {
                    Program.RecToPol();
                }
                else if (recOrPol == "2")
                {
                    Program.PolToRec();
                }
                else if (recOrPol == "3")
                {
                    Program.PolToExp();
                }
                else if (recOrPol == "4")
                {
                    Program.ExpToPol();
                }
                else
                {
                    runningtheprogram = false;
                    Environment.Exit(0);
                }
            }
        }

        public static void RecToPol()
        {
            Console.WriteLine("What is the Real component of the Complex number?");
            Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
            Console.Write("Real(Z) = ");
            double realComponent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("What is the Imaginary component of the Complex number?");
            Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
            Console.Write("Imaginary(Z) = ");
            double imaginaryComponent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("the Complex number is: Z = (" + realComponent + ") + (" + imaginaryComponent + ")i");
            Console.WriteLine("type '1' for RAD or '2' for DEG or '3' to go back to the start of the program:");
            string changedYourMind = Console.ReadLine();
            while (changedYourMind != "1" && changedYourMind != "2" && changedYourMind != "3")
            {
                Console.Clear();
                Console.WriteLine("the Complex number is: Z = (" + realComponent + ") + (" + imaginaryComponent + ")i");
                Console.WriteLine("type '1' for RAD or '2' for DEG or '3' to go back to the start of the program:");
                Console.WriteLine("Please only write '1' or '2' or '3'.");
                changedYourMind = Console.ReadLine();
            }
            Console.Clear();
            double angle;
            if (changedYourMind == "1")
            {
                angle = Math.Atan2(imaginaryComponent, realComponent);
            }
            else if (changedYourMind == "2")
            {
                angle = (Math.Atan2(imaginaryComponent, realComponent) * (180 / Math.PI));
            }
            else
            {
                return;
            }
            double distance = Math.Sqrt(Math.Pow(realComponent, 2) + Math.Pow(imaginaryComponent, 2));
            Console.WriteLine("Rectangular form: Z = (" + realComponent + ") + (" + imaginaryComponent + ")i");
            Console.WriteLine("Polar form: Z = " + distance + "(cos(" + angle + ") + i sin(" + angle + "))");
            Console.ReadLine();
        }

        public static void PolToRec()
        {
            Console.WriteLine("What is the radius of the Complex number?");
            Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
            Console.Write("r(Z) = ");
            double radiusComponent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("What is the angle of the Complex number?");
            Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
            Console.Write("0(Z) = ");
            double angleComponent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("the Complex number is: Z = " + radiusComponent + "(cos(" + angleComponent + ") + i sin(" + angleComponent + "))");
            Console.WriteLine("type '1' for RAD or '2' for DEG or '3' to go back to the start of the program:");
            string changedYourMind = Console.ReadLine();
            while (changedYourMind != "1" && changedYourMind != "2" && changedYourMind != "3")
            {
                Console.Clear();
                Console.WriteLine("the Complex number is: Z = " + radiusComponent + "(cos(" + angleComponent + ") + i sin(" + angleComponent + "))");
                Console.WriteLine("type '1' for RAD '2' for DEG or '3' to go back to the start of the program:");
                Console.WriteLine("Please only write '1' or '2' or '3'.");
                changedYourMind = Console.ReadLine();
            }
            Console.Clear();
            double real;
            double imaginary;
            if (changedYourMind == "1")
            {
                real = (radiusComponent * Math.Cos(angleComponent));
                imaginary = (radiusComponent * Math.Sin(angleComponent));
            }
            else if (changedYourMind == "2")
            {
                double tempA = (angleComponent * Math.PI / 180);
                real = (radiusComponent * Math.Cos(tempA));
                imaginary = (radiusComponent * Math.Sin(tempA));
            }
            else
            {
                return;
            }
            Console.WriteLine("Polar form: Z = " + radiusComponent + "(cos(" + angleComponent + ") + i sin(" + angleComponent + "))");
            Console.WriteLine("Rectangular form: Z = (" + real + ") + (" + imaginary + ")i");
            Console.ReadLine();
        }

        public static void PolToExp()
        {
            Console.WriteLine("What is the radius of the Complex number?");
            Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
            Console.Write("r(Z) = ");
            double radiusComponent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("What is the angle of the Complex number?");
            Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
            Console.Write("0(Z) = ");
            double angleComponent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("the Complex number is: Z = " + radiusComponent + "(cos(" + angleComponent + ") + i sin(" + angleComponent + "))");
            Console.WriteLine("type '1' to confirm or '2' to go back to the start of the program:");
            string changedYourMind = Console.ReadLine();
            while (changedYourMind != "1" && changedYourMind != "2")
            {
                Console.Clear();
                Console.WriteLine("the Complex number is: Z = " + radiusComponent + "(cos(" + angleComponent + ") + i sin(" + angleComponent + "))");
                Console.WriteLine("type '1' to confirm or '2' to go back to the start of the program:");
                Console.WriteLine("Please only write '1' or '2'.");
                changedYourMind = Console.ReadLine();
            }
            Console.Clear();
            if (changedYourMind == "1")
            {
                Console.WriteLine("Polar form: Z = " + radiusComponent + "(cos(" + angleComponent + ") + i sin(" + angleComponent + "))");
                Console.WriteLine("Exponential form: Z = " + radiusComponent + "e^" + angleComponent + "");
            }
            else
            {
                return;
            }
            Console.ReadLine();
        }

        public static void ExpToPol()
        {
            Console.WriteLine("What is the radius of the Complex number?");
            Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
            Console.Write("r(Z) = ");
            double radiusComponent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("What is the angle of the Complex number?");
            Console.WriteLine("Note: use '.' for decimal points and ',' only for visual markers since ',' is invisible to the program.");
            Console.Write("0(Z) = ");
            double angleComponent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("the Complex number is: Z = " + radiusComponent + "e^" + angleComponent + "");
            Console.WriteLine("type '1' to confirm or '2' to go back to the start of the program:");
            string changedYourMind = Console.ReadLine();
            while (changedYourMind != "1" && changedYourMind != "2")
            {
                Console.Clear();
                Console.WriteLine("the Complex number is: Z = " + radiusComponent + "e^" + angleComponent + "");
                Console.WriteLine("type '1' to confirm or '2' to go back to the start of the program:");
                Console.WriteLine("Please only write '1' or '2'.");
                changedYourMind = Console.ReadLine();
            }
            Console.Clear();
            if (changedYourMind == "1")
            {
                Console.WriteLine("Exponential form: Z = " + radiusComponent + "e^" + angleComponent + "");
                Console.WriteLine("Polar form: Z = " + radiusComponent + "(cos(" + angleComponent + ") + i sin(" + angleComponent + "))");
            }
            else
            {
                return;
            }
            Console.ReadLine();
        }

    }
}
