using PirmaUzduotis_FilmuVertinimas.Models;

namespace _1_PirmaUzduotis_FilmuVertinimas.Services
{
        // Sukurkite konsolinę programą, kuri leis vartotojui įvesti n filmų pavadinimus ir jų reitingus (nuo 1 iki 10).
        // Duomenis saugokite sąraše ar masyve.

        // Leiskite vartotojui pasirinkti iš meniu, ką jis nori atlikti su įvestais duomenimis:
        // a.Rodyti visus filmus ir jų reitingus.
        // b. Rodyti tik tuos filmus, kurių reitingas didesnis nei nurodyta vertė.
        // c. Rasti filmą pagal pavadinimą ir parodyti jo reitingą.
        // d. Atnaujinti filmo reitingą.
        // e. Ištrinti filmą iš sąrašo.
        // f. Išeiti iš programos.

        public class UI
        {
                public static void Main(string[] args)
                {
                        FilmuSarasas filmuSarasas = new FilmuSarasas();

                        MeniuText();
                        MeniuInputCheck(out bool inputMeniuCheck, out int inputMeniu);

                        while (inputMeniuCheck == true)
                        {
                                Meniu(ref inputMeniu, ref filmuSarasas);
                                Console.WriteLine();
                                MeniuText();
                                MeniuInputCheck(out inputMeniuCheck, out inputMeniu);
                        }



                }


                public static (bool, int) MeniuInputCheck(out bool inputMeniuCheck, out int inputMeniu)
                {
                        inputMeniuCheck = int.TryParse(Console.ReadLine(), out inputMeniu);
                        return (inputMeniuCheck, inputMeniu);
                }


                public static void MeniuText()
                {
                        Console.WriteLine(".:MENIU:.");
                        Console.WriteLine("1 - Ivesti filma i filmu sarasa.");
                        Console.WriteLine("2 - Rodyti visus filmus ir jų reitingus.");
                        Console.WriteLine("3 - Rodyti tik tuos filmus, kurių reitingas didesnis nei nurodyta vertė.");
                        Console.WriteLine("4 - Rasti filmą pagal pavadinimą ir parodyti jo reitingą.");
                        Console.WriteLine("5 - Atnaujinti filmo reitingą.");
                        Console.WriteLine("6 - Ištrinti filmą iš sąrašo.");
                        Console.WriteLine("0 - Išeiti iš programos.");

                }

                public static void Meniu(ref int inputMeniu, ref FilmuSarasas filmuSarasas)
                {
                        switch (inputMeniu)
                        {
                                case 0:
                                        Environment.Exit(0);
                                        break;
                                case 1:
                                        filmuSarasas.PridetiFilma();
                                        break;
                                case 2:
                                        filmuSarasas.RodytiFilmuSarasa();
                                        break;
                                case 3:
                                        filmuSarasas.FilmaiPagalReitinga();
                                        break;
                                case 4:
                                        filmuSarasas.FilmaiPagalPavadinima();
                                        break;
                                case 5:
                                        filmuSarasas.UpdatePagalPavadinima();
                                        break;
                                case 6:
                                        filmuSarasas.IstrintiPagalPavadinima();
                                        break;
                                default:
                                        break;
                        }
                }
        }
}

