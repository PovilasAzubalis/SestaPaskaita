namespace PirmaUzduotis_FilmuVertinimas.Models
{
        public class Filmas
        {
                public string filmoPavadinimas { get; set; }
                public int reitingas { get; set; }
                

                public Filmas(string filmoPavadinimas, int reitingas)
                {
                        this.filmoPavadinimas = filmoPavadinimas;
                        this.reitingas = reitingas;
                }

                public override string ToString()
                {
                        return $"\n| {filmoPavadinimas} | {reitingas} |\n";
                }
        }
}
