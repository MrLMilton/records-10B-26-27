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
                title = this.title;
                certificate = this.certificate;
                cinemaShowings = this.cinemaShowings;
                runtime = this.runtime;
                beingShown = this.beingShown;
                ticketPrice = this.ticketPrice;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
