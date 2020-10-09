using System;
using System.Collections.Generic;

namespace Klasser
{
    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Bil> bilar = new List<Bil>();

            var bil1 = new Bil("BMW Z3")
            {
                RegistreringsNummer = "Abc123",
                ViktIKilo = 1500,
                RegistreringsDatum = DateTime.Now,
                Elbil = false
            };
            bil1.KorMil(5678.55m);
            bilar.Add(bil1);

            var bil2 = new Bil("Nissan Qashqai")

            {
                RegistreringsNummer = "GMC456",
                ViktIKilo = 1500,
                RegistreringsDatum = DateTime.Now,
                Elbil = false

            };
            bil2.KorMil(444.55m);

            bilar.Add(bil2);

            var bil3 = new Bil("Tesla S")
            {
                RegistreringsNummer = "KKL789",
                ViktIKilo = 1500,
                RegistreringsDatum = DateTime.Now,
                Elbil = true
            };
            bil3.KorMil(123.55m);
            bilar.Add(bil3);

            var bil4 = new Bil("Volvo XC90")
            {
                RegistreringsNummer = "MNJ753",
                ViktIKilo = 1500,
                RegistreringsDatum = DateTime.Now,
                Elbil = false
            };

            bil4.KorMil(253.55m);
            bilar.Add(bil4);

            foreach (Bil bil in bilar)
            {

                Console.WriteLine($"Modell är : {bil.ModelNamn}");
                Console.WriteLine($"Modell är : {bil.RegistreringsNummer}");
                Console.WriteLine($"Modell är : {bil.ViktIKilo}");
                Console.WriteLine($"Modell är : {bil.RegistreringsDatum}");
                Console.WriteLine($"Bilen gick {bil.GetMil()} mil");

                if (bil.Elbil)
                {
                    Console.WriteLine("Detta är en elbil");
                }
                Console.WriteLine(" ");
            }

            List<Personer> personer = new List<Personer>();

            while (true)
            {
                Console.WriteLine("Ange någon av följande alternativ:");
                Console.WriteLine("1. Skapa ny person");
                Console.WriteLine("2. Lägg till bil på person");
                Console.WriteLine("3. Skriv ut personer och deras bilar");
                Console.WriteLine("4. Avsluta programmet");

                int alternativ = 0;
                int.TryParse(Console.ReadLine(), out alternativ);

                if (alternativ == 4)
                {
                    break;
                }

                if (alternativ < 4 && alternativ > 0)
                {

                    switch (alternativ)
                    {
                        case 1:
                            Console.WriteLine("Ange personens namn:");
                            string namn = Console.ReadLine();
                            Console.WriteLine("Ange personens ålder:");
                            int alder = int.Parse(Console.ReadLine());
                            Personer person = new Personer() { Alder = alder, Namn = namn };
                            personer.Add(person);

                            break;
                        case 2:
                            int personIndex = -1;
                            do
                            {
                                Console.WriteLine("Ange namn på person som du vill lägga till bil på:");
                                string personNamn = Console.ReadLine();


                                for (int i = 0; i < personer.Count; i++)
                                {
                                    if (personer[i].Namn == personNamn)
                                    {
                                        personIndex = i;
                                    }
                                }
                                if (personIndex == -1)
                                {
                                    Console.WriteLine("Det finns ingen person med detta namnet");
                                }
                            } while (personIndex == -1);

                            Console.WriteLine("Ange modell");
                            string modell = Console.ReadLine();
                            Console.WriteLine("Ange registeringsnummer");
                            string regNr = Console.ReadLine();
                            Console.WriteLine("Ange bilens vikt i kg");
                            int vikt = int.Parse(Console.ReadLine());
                            DateTime date = DateTime.Now;
                            Console.WriteLine("Är det en elbil j/n?");
                            string arElbil = Console.ReadLine();

                            bool elbil = false;
                            if (arElbil.ToLower() == "j")
                            {
                                elbil = true;
                            }
                            Bil bil = new Bil(modell)
                            {
                                Elbil = elbil,
                                RegistreringsDatum = date,
                                RegistreringsNummer = regNr,
                                ViktIKilo = vikt
                            };

                            personer[personIndex].Bilar.Add(bil);

                            break;
                        case 3:
                            foreach (Personer p in personer)
                            {
                                Console.WriteLine($"Personen {p.Namn} är {p.Alder} år gammal \n och har bilarna:");
                                foreach (Bil b in p.Bilar)
                                {

                                    Console.WriteLine($"Modell: {b.ModelNamn}");
                                    Console.WriteLine($"Registreringsnr: {b.RegistreringsNummer}");
                                    Console.WriteLine($"Registrerades: {b.RegistreringsDatum}");
                                    if (b.Elbil)
                                    {
                                        Console.WriteLine($"Detta är en elbil!");
                                    }
                                }

                            }
                            break;
                        default:
                            break;


                    }
                }
            }

        }
    }
}