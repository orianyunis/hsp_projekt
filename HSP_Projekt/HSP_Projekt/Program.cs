using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoehe, breit, flaeche, iY, iX;
            Console.WriteLine("Bitte, Informieren Sie die Höhe und Breit Ihres Rechtecksprofil");
            Console.WriteLine("Bitte Höhe eingeben:");
            hoehe = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte Breit eingeben:");
            breit = Convert.ToDouble(Console.ReadLine());

            if ((breit > 0) && (hoehe > 0))
            {
                Console.Clear();
                ///Fläche////
                flaeche = hoehe * breit;
                Console.WriteLine("Die Fläche ihres Rechtecksprofil ist " + flaeche + " .");
                ///Flächenträgheitsmoment
                iY = (breit * (hoehe * hoehe * hoehe)) / 12;
                iX = (hoehe * (breit * breit * breit)) / 12;

                Console.WriteLine("Die Flächenträgheitsmoment ihres Rechtecksprofil sind für Iy = " + iY + ". Für Ix = " + iX + " .");


            }


            Console.ReadKey();
        }
    }
}







