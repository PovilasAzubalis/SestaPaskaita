namespace PirmaUzduotis_FilmuVertinimas.Models
{
        public class FilmuSarasas
        {
                public List<Filmas> filmai = new List<Filmas>();

                public FilmuSarasas()
                {

                }


                public void PridetiFilma()
                {
                        Console.Write("Iveskite filmo pavadinima: ");
                        string pavadinimas = Console.ReadLine();
                        Console.Write("Iveskite filmo reitinga (1 - 10): ");
                        int.TryParse(Console.ReadLine(), out int reitingas);
                        Filmas naujasFilmas = new Filmas(pavadinimas, reitingas);
                        filmai.Add(naujasFilmas);
                }
                public void RodytiFilmuSarasa()
                {
                        foreach (Filmas filmas in filmai)
                        {
                                Console.WriteLine(filmas.ToString());
                        }
                }

                public void FilmaiPagalReitinga()
                {
                        Console.Write("Iveskite paieskos reitinga: ");
                        int.TryParse(Console.ReadLine(), out int inputReitingas);
                        var filmaiPagalReitinga = filmai.Where(x => x.reitingas > inputReitingas);

                        foreach (Filmas filmas in filmaiPagalReitinga)
                        {
                                Console.WriteLine(filmas.ToString());
                        }
                }

                public void FilmaiPagalPavadinima()
                {
                        Console.Write("Iveskite filmo pavadinima: ");
                        string inputPagalPavadinima = Console.ReadLine();
                        var filmaiPagalPavadinima = filmai.Where(x => x.filmoPavadinimas.Contains(inputPagalPavadinima));

                        foreach (Filmas filmas in filmaiPagalPavadinima)
                        {
                                Console.WriteLine(filmas.ToString());
                        }
                }

                public void UpdatePagalPavadinima()
                {
                        Console.Write("Iveskite filmo pavadinima: ");
                        string inputPagalPavadinima = Console.ReadLine();
                        var filmasPagalPavadinima = filmai.FindIndex(x => x.filmoPavadinimas.Equals(inputPagalPavadinima));
                        var filmasUpdate = filmai.ElementAt(filmasPagalPavadinima);
                        
                        int.TryParse(Console.ReadLine(), out int x);
                        filmasUpdate.reitingas = x;


                }

                public void IstrintiPagalPavadinima()
                {
                        Console.Write("Iveskite filmo pavadinima: ");
                        string inputPagalPavadinima = Console.ReadLine();
                        var filmasPagalPavadinima = filmai.FindIndex(x => x.filmoPavadinimas.Equals(inputPagalPavadinima));
                        var filmasIstrinti = filmai.ElementAt(filmasPagalPavadinima);

                        filmai.Remove(filmasIstrinti);


                }



        }
}
