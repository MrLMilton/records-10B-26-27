using System.Globalization;

namespace records_10B_26_27
{
    internal class Program
    {
        struct film
        {
            public string title;
            public string certificate;
            public string[] cinemaShowings;
            public int runtime;
            public bool beingShown;
            public double ticketPrice;

            public film(string title, string certificate, string[] cinemaShowings, int runtime, bool beingShown, double ticketPrice)
            {
                this.title = title;
                this.certificate = certificate;
                this.cinemaShowings = cinemaShowings;
                this.runtime = runtime;
                this.beingShown = beingShown;
                this.ticketPrice = ticketPrice;
            }

        }
        static void Main(string[] args)
        {
            film Wildwood = new film("Wildwood", "12A", ["Showcase Cinema de Lux Leeds", "Cineworld Cinema - Leeds" , "ODEON Luxe Leeds Bradford" , "ODEON Huddersfield"], 131, true,7.99);
            film LordOfTheRings = new film("The Lord of the Rings: The Fellowship of the Ring", "PG", ["Home viewing"], 178, false, 0);
            film RogueOne = new film("Rogue One: A Star Wars Story", "12A", ["Home viewing"], 133, false, 0);
            film DunePartThree = new film("Dune: Part Three", "15", ["Showcase Cinema de Lux Leeds", "Cineworld Cinema - Leeds", "ODEON Luxe Leeds Bradford", "ODEON Huddersfield"], 165, false, 9.50);
            film Interstellar = new film("Interstellar", "12A", ["Home viewing"], 169, false, 0);
            film TheHobbit = new film("The Hobbit: An Unexpected Journey", "12A", ["Home viewing"], 169, false, 0);
            Console.WriteLine(Wildwood.title);
            for (int i = 0; i < Wildwood.cinemaShowings.Length; i++)
            { 
                Console.WriteLine(Wildwood.cinemaShowings[i]); 
            }
        }
    }
}
