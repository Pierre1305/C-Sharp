using System;

namespace Villkor_och_loopar
{



    class Program
    {
        static void Main(string[] args)
        {
            int startNummer = 0,
                startTimme = 0,
                startMinut = 0,
                startSekund = 0,
                slutTimme = 0,
                slutMinut = 0,
                slutSekund = 0,
                antalTavlande = 0,
                startTidSekunder = 0,
                slutTidSekunder = 0,
                malTidSekunder = 0,
                bastaTid = int.MaxValue,
                bastaStartNummer = 0;



            while (true)
            {
                Console.Write("Ange ett start nummer : ");
                int.TryParse(Console.ReadLine(), out startNummer);
                if (startNummer < 1)
                {
                    break;
                }
                antalTavlande++;
                Console.Write("Ange starttimme (00-23): ");
                int.TryParse(Console.ReadLine(), out startTimme);

                Console.Write("Ange startminut (00-59): ");
                int.TryParse(Console.ReadLine(), out startMinut);

                Console.Write("Ange startsekund (00-59): ");
                int.TryParse(Console.ReadLine(), out startSekund);

                Console.Write("Ange sluttimme (00-23): ");
                int.TryParse(Console.ReadLine(), out slutTimme);

                Console.Write("Ange slutminut (00-59): ");
                int.TryParse(Console.ReadLine(), out slutMinut);

                Console.Write("Ange sluttsekund (00-59): ");
                int.TryParse(Console.ReadLine(), out slutSekund);


                startTidSekunder = (startTimme * 3600) + (startMinut * 60) + startSekund;
                slutTidSekunder = (slutTimme * 3600) + (slutMinut * 60) + slutSekund;

                if (startTidSekunder > slutTidSekunder)
                {
                    slutTidSekunder += (24 * 3600);
                }

                malTidSekunder = slutTidSekunder - startTidSekunder;
                if (malTidSekunder < bastaTid)
                {
                    bastaTid = malTidSekunder;
                    bastaStartNummer = startNummer;
                }

            }


            if (antalTavlande == 0)
            {
                Console.WriteLine("Inga tävlande");
                return;
            }
                        
                Console.WriteLine($"Startnummer {bastaStartNummer} är vinnaren");
            

            int bastaTidTimmar = Convert.ToInt32(Math.Floor((decimal)bastaTid / 3600));

            int bastaTidMinuter = Convert.ToInt32(Math.Floor((decimal)bastaTid / 60) - (bastaTidTimmar * 60));

            int bastaTidSekunder = bastaTid % 60;

            Console.WriteLine($"Vinnande sluttid: {bastaTidTimmar} timmar {bastaTidMinuter} minuter {bastaTidSekunder} sekunder");
            Console.WriteLine($"Antal tävlande: {antalTavlande}");
        }




        
    }
}
