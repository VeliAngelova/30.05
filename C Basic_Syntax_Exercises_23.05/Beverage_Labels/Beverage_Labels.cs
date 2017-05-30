using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



        static void Main(string[] args)
        {
            var nameN = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
        
            var EnergyContent = int.Parse(Console.ReadLine());
            var SugarContent = int.Parse(Console.ReadLine());

            var volumeNa100 = volume / 100.0;//акo napisha double otpred
            // a prom sa mi int, 6te gi razdeli kato int i 6te gi zapi6e v double
            // a taka otnovo se gubi stojnostta sled desetinata zapetaq.
            // zatova slagame ".0" sled edno ot 4islata.
            var kcal = volumeNa100 * EnergyContent;
            var sugarsNaG = volumeNa100 * SugarContent;

            Console.WriteLine("{0}ml" + " {1}:", volume, nameN);
            Console.WriteLine("{0}kcal," + " {1}g sugars", kcal, sugarsNaG);
    
        }}}}}}}}}}}}
    }

