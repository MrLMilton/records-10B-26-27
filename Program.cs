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
            Console.WriteLine(Wildwood.title);
        }
    }
}
